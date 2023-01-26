using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace ZMGDesktop
{
    public partial class FrmNoviRadniNalog : Form
    {
        Radnik Radnik = new Radnik();
        Klijent odabraniKlijent = new Klijent();

        public FrmNoviRadniNalog(Radnik radnik)
        {
            InitializeComponent();
            Radnik = radnik;
        }

        RadniNalogService servis = new RadniNalogService();
        RobaService robaServis = new RobaService();

        List<Materijal> materijali = new List<Materijal>();
        List<Roba> robaZaRadniNalog = new List<Roba>();

        string QRKod = "";

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPodnesi_Click(object sender, EventArgs e)
        {
            var status = cmbStatus.SelectedItem as string;

            if (txtKolicina.Text == "" || status == "")
            {
                MessageBox.Show("Morate upisati količinu i status!");
            }
            else
            {
                var kolicina = int.Parse(txtKolicina.Text);
                var opis = txtOpis.Text;
                var datumStvaranja = dtpDatumStvaranja.Value;
                var radnik = txtRadnik.Text;

                RadniNalog radniNalog = new RadniNalog()
                {
                    Kolicina = kolicina,
                    Opis = opis,
                    QR_kod = QRKod,
                    DatumStvaranja = datumStvaranja,
                    Status = status,
                    Radnik_ID = Radnik.Radnik_ID,
                    Klijent_ID = odabraniKlijent.Klijent_ID,
                    Klijent = odabraniKlijent,
                    Radnik = Radnik,
                    Materijal = materijali,
                    Roba = robaZaRadniNalog
                };

                servis.DodajRadniNalog(radniNalog);
                Close();
            }
        }

        private void FrmNoviRadniNalog_Load(object sender, EventArgs e)
        {
            UcitajKlijente();
            UcitajMaterijale();
            txtRadnik.Text = Radnik.Ime + " " + Radnik.Prezime;
            UcitajRobu();
            
        }

        private void UcitajRobu()
        {
            List<Roba> listaRobe = robaServis.DohvatiRobuKlijenta(odabraniKlijent.Klijent_ID);
            dgvKlijentovaRoba.DataSource = listaRobe;
            dgvKlijentovaRoba.Columns[3].Visible = false;
            dgvKlijentovaRoba.Columns[4].Visible = false;
            dgvKlijentovaRoba.Columns[5].Visible = false;
            dgvKlijentovaRoba.Columns[6].Visible = false;
        }

        private void UcitajMaterijale()
        {
            MaterijalServices materijalServices= new MaterijalServices();
            var materijali = materijalServices.DohvatiMaterijale();
            cmbMaterijali.DataSource = materijali;
        }

        private void UcitajKlijente()
        {
            KlijentServices klijentServices = new KlijentServices();
            var klijenti = klijentServices.DohvatiKlijente();
            cmbKlijent.DataSource = klijenti;
        }

        private void btnDodajMaterijal_Click(object sender, EventArgs e)
        {
            var materijal = cmbMaterijali.SelectedItem as Materijal;
            materijali.Add(materijal);

            List<Materijal> lista = new List<Materijal>();
            lista.AddRange(materijali);

            btnDodajMaterijalUTablicu(lista);
        }

        private void btnDodajMaterijalUTablicu(List<Materijal> materijali)
        {
            dgvMaterijali.DataSource = materijali;
            dgvMaterijali.Columns[8].Visible = false;
            dgvMaterijali.Columns[9].Visible = false;
            dgvMaterijali.Columns[10].Visible = false;
            dgvMaterijali.Columns[11].Visible = false;
            dgvMaterijali.Columns[12].Visible = false;
        }

        private void btnGenerirajQRKod_Click(object sender, EventArgs e)
        {
            QRKod += "UkupnaKolicina(kg)=" + txtKolicina.Text + ";";

            foreach (var r in robaZaRadniNalog)
            {
                QRKod += "NazivRobe=" + r.Naziv + ";" + "KolicinaRobe=" + r.Kolicina + ";" + "KlijentID=" + r.Klijent_ID + ";";
            }

            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(QRKod, QRCodeGenerator.ECCLevel.Q); //generiranje QR koda
            var qrCode = new QRCode(qrCodeData); //stvaranje Bitmap objekta koji se koristi da bi se prikazala slika

            var qrCodeImage = qrCode.GetGraphic(3); //stvaranje slike QR koda
            pbQRKod.Image = qrCodeImage;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbKlijent_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabraniKlijent = cmbKlijent.SelectedItem as Klijent;
            UcitajRobu();
        }

        private void btnDodajNovuRobu_Click(object sender, EventArgs e)
        {
            if(txtNazivRobe.Text == "" || txtKolicinaRobe.Text == "")
            {
                MessageBox.Show("Morate upisati naziv robe i količinu robe koju želite unijeti!");
            }
            else
            {
                Roba novaRoba = new Roba
                {
                    Naziv = txtNazivRobe.Text,
                    Kolicina = txtKolicinaRobe.Text,
                    Klijent_ID = odabraniKlijent.Klijent_ID
                };

                robaServis.Add(novaRoba);
            }

            UcitajRobu();
        }

        private void btnDodajRobuNaRadniNalog_Click(object sender, EventArgs e)
        {
            Roba selektiranaRoba = dgvKlijentovaRoba.CurrentRow.DataBoundItem as Roba;
            robaZaRadniNalog.Add(selektiranaRoba);
            UcitajRobuRadnogNaloga();
        }

        private void UcitajRobuRadnogNaloga()
        {
            dgvRobaRadnogNaloga.DataSource = null;
            dgvRobaRadnogNaloga.DataSource = robaZaRadniNalog;
            dgvRobaRadnogNaloga.Columns[3].Visible = false;
            dgvRobaRadnogNaloga.Columns[4].Visible = false;
            dgvRobaRadnogNaloga.Columns[5].Visible = false;
            dgvRobaRadnogNaloga.Columns[6].Visible = false;
        }

        private void btnObrisiRobuSRadnogNaloga_Click(object sender, EventArgs e)
        {

        }
    }
}
