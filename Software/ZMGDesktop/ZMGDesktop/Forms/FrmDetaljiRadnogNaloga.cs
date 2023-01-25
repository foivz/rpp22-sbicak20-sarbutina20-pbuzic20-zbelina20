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
    public partial class FrmDetaljiRadnogNaloga : Form
    {
        RadniNalog radniNalog = new RadniNalog();
        Radnik Radnik = new Radnik();
        public FrmDetaljiRadnogNaloga(RadniNalog odabraniRadniNalog, Radnik radnik)
        {
            InitializeComponent();
            radniNalog = odabraniRadniNalog;
            Radnik = radnik;
        }

        RadniNalogService servis = new RadniNalogService();

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var klijent = cmbKlijent.SelectedItem as Klijent;

            RadniNalog RadniNalog = new RadniNalog()
            {
                RadniNalog_ID = radniNalog.RadniNalog_ID,
                Kolicina = int.Parse(txtKolicina.Text),
                Opis = txtOpis.Text,
                QR_kod = txtQRKod.Text,
                DatumStvaranja = dtpDatumStvaranja.Value,
                Status = cmbStatus.SelectedItem as string,
                Radnik_ID = Radnik.Radnik_ID,
                Klijent_ID = klijent.Klijent_ID,
                Radnik = Radnik,
                Klijent = klijent
            };
            //poslati email
            servis.AzurirajRadniNalog(RadniNalog);
            Close();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            txtKolicina.Enabled = true;
            txtOpis.Enabled = true;
            cmbStatus.Enabled = true;
            cmbKlijent.Enabled = true;
        }

        private void FrmDetaljiRadnogNaloga_Load(object sender, EventArgs e)
        {
            label1.Text += radniNalog.RadniNalog_ID.ToString();
            txtRadnik.Text = Radnik.Ime + " " + Radnik.Prezime;
            txtKolicina.Enabled = false;
            txtOpis.Enabled = false;
            txtQRKod.Enabled = false;
            dtpDatumStvaranja.Enabled = false;
            cmbStatus.Enabled = false;
            cmbKlijent.Enabled = false;

            txtKolicina.Text = radniNalog.Kolicina.ToString();
            txtOpis.Text = radniNalog.Opis;
            txtQRKod.Text = radniNalog.QR_kod;
            dtpDatumStvaranja.Value = radniNalog.DatumStvaranja;
            cmbStatus.Text = radniNalog.Status;
            cmbKlijent.SelectedItem = radniNalog.Klijent;

            UcitajKlijente();
            OdaberiKlijenta(radniNalog.Klijent_ID);
        }

        private void OdaberiKlijenta(int? klijent_ID)
        {
            for (int i = 0; i < cmbKlijent.Items.Count; i++)
            {
                Klijent klijent = cmbKlijent.Items[i] as Klijent;
                if(klijent.Klijent_ID == klijent_ID)
                {
                    cmbKlijent.SelectedIndex = i;
                    break;
                }
            }
        }

        private void UcitajKlijente()
        {
            KlijentServices klijentServices = new KlijentServices();
            var klijenti = klijentServices.DohvatiKlijente();
            cmbKlijent.DataSource = klijenti;
        }
    }
}
