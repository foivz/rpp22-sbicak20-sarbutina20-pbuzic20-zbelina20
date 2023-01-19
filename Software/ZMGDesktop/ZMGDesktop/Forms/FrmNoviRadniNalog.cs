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
            var status = txtStatus.Text;
            var radnik = txtRadnik.Text;
            var klijent = cmbKlijent.SelectedItem as Klijent;

            RadniNalog randiNalog = new RadniNalog()
            {
                Kolicina = kolicina,
                Opis = opis,
                QR_kod= qrKod,
                DatumStvaranja= datumStvaranja,
                Status = status,
                Radnik_ID = Radnik.Radnik_ID,
                Klijent_ID = klijent.Klijent_ID,
                Klijent = klijent,
                Radnik = Radnik
            };

            servis.DodajRadniNalog(randiNalog);
            Close();
        }

        private void FrmNoviRadniNalog_Load(object sender, EventArgs e)
        {
            UcitajKlijente();
            txtRadnik.Text = Radnik.Ime + " " + Radnik.Prezime;
        }

        private void UcitajKlijente()
        {
            KlijentServices klijentServices = new KlijentServices();
            var klijenti = klijentServices.DohvatiKlijente();
            cmbKlijent.DataSource = klijenti;
        }
    }
}
