using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
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
                Radnik = Radnik
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
        }
    }
}
