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
        public FrmNoviRadniNalog(Radnik radnik)
        {
            InitializeComponent();
            Radnik = radnik;
        }

        RadniNalogService servis = new RadniNalogService();
        List<Materijal> materijali = new List<Materijal>();

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPodnesi_Click(object sender, EventArgs e)
        {
            var kolicina = int.Parse(txtKolicina.Text);
            var opis = txtOpis.Text;
            var qrKod = txtQRKod.Text;
            var datumStvaranja = dtpDatumStvaranja.Value;
            var status = cmbStatus.SelectedItem as string;
            var radnik = txtRadnik.Text;
            var klijent = cmbKlijent.SelectedItem as Klijent;

            RadniNalog radniNalog = new RadniNalog()
            {
                Kolicina = kolicina,
                Opis = opis,
                QR_kod = qrKod,
                DatumStvaranja = datumStvaranja,
                Status = status,
                Radnik_ID = Radnik.Radnik_ID,
                Klijent_ID = klijent.Klijent_ID,
                Klijent = klijent,
                Radnik = Radnik,
                Materijal = materijali
            };

            servis.DodajRadniNalog(radniNalog);
            Close();
        }

        private void FrmNoviRadniNalog_Load(object sender, EventArgs e)
        {
            UcitajKlijente();
            UcitajMaterijale();
            txtRadnik.Text = Radnik.Ime + " " + Radnik.Prezime;
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
            string QRKod = GenerirajRandomString();

            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(QRKod, QRCodeGenerator.ECCLevel.Q); //generiranje QR koda
            var qrCode = new QRCode(qrCodeData); //stvaranje Bitmap objekta koji se koristi da bi se prikazala slika

            txtQRKod.Text = QRKod;

            var qrCodeImage = qrCode.GetGraphic(8); //stvaranje slike QR koda
            pbQRKod.Image = qrCodeImage;
        }

        string GenerirajRandomString()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 20)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
