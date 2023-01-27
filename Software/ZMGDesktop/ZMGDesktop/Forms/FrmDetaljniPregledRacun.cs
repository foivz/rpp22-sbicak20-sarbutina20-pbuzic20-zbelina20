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
    public partial class FrmDetaljniPregledRacun : Form
    {
        //objekti
        Racun racun;
        List<StavkaRacun> stavkeList;
        Poslodavac poslodavac;
        Klijent klijent;
        Radnik radnik;

        //servisi
        StavkaRacunService stavkaServis;
        public FrmDetaljniPregledRacun(Racun _racun)
        {
            InitializeComponent();
            racun = _racun;
            poslodavac = racun.Poslodavac;
            klijent= racun.Klijent;
            radnik= racun.Radnik;

            stavkaServis = new StavkaRacunService();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void FrmDetaljniPregledRacun_Load(object sender, EventArgs e)
        {
            lblBrojRacuna.Text = racun.Racun_ID.ToString();
            InitPoslodavac();
            InitKlijent();
            InitStavke();
            InitUkupno();
            InitPlacanje();
            InitDatum();
            Refresh();
        }

        private void InitPoslodavac()
        {
            txtP_BrObrtnice.Text = poslodavac.BrojObrtnice;
            txtP_Banka.Text = poslodavac.Banka;
            txtP_BrojMobitela.Text = poslodavac.BrojTelefona;
            txtP_Drzava.Text = poslodavac.Drzava;
            txtP_Mjesto.Text = poslodavac.Mjesto;
            txtP_Ulica.Text = poslodavac.Adresa;
            txtP_TELFAX.Text = poslodavac.TEL_FAX;
            txtP_ObrtniRegistar.Text = poslodavac.UpisObrtniRegistar;
            txtP_Poslovnica.Text = poslodavac.Poslovnica;
            txtP_Naziv.Text = poslodavac.Naziv;
            txtP_IBAN.Text = poslodavac.IBAN;
            txtP_OIB.Text = poslodavac.OIB;
        }
        private void InitKlijent()
        {
            txtK_Adresa.Text = klijent.Adresa;
            txtK_Email.Text = klijent.Email;
            txtK_Mjesto.Text = klijent.Mjesto;
            txtK_Naziv.Text= klijent.Naziv;
            txtK_OIB.Text= klijent.OIB;
            txtK_TEL.Text = klijent.BrojTelefona;
            txtK_IBAN.Text = klijent.IBAN;
        }
        private void InitUkupno()
        {
            txtUkupno.Text = racun.UkupnoStavke.ToString();
            txtPDV.Text = racun.PDV.ToString();
            txtUkupniIznos.Text = racun.UkupnaCijena.ToString();
        }
        private void InitStavke()
        {
            stavkeList = stavkaServis.DohvatiStavkeRacuna(racun.Racun_ID);
        }

        private void Refresh()
        {
            dgvStavke.DataSource = stavkeList;
            dgvStavke.Columns[0].Visible = false;
            dgvStavke.Columns[1].Visible = false;
            dgvStavke.Columns[2].Visible = false;
            dgvStavke.Columns[9].Visible = false;
        }

        private void InitDatum()
        {
            txtDatumIzdavanja.Text = racun.DatumIzdavanja.Value.ToShortDateString();
            txtVrijeme.Text = racun.DatumIzdavanja.Value.ToShortTimeString();
        }
        private void InitPlacanje()
        {
            txtNacinPlacanja.Text = racun.NacinPlacanja;
            txtRokPlacanja.Text = racun.RokPlacanja;
            txtFakturirao.Text = racun.Fakturirao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
