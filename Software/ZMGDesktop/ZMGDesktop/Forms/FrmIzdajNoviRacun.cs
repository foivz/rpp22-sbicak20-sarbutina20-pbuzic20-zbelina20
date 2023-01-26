using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using EntitiesLayer.GlobalniObjekti;
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
    public partial class FrmIzdajNoviRacun : Form
    {
        //objekti
        Poslodavac poslodavac;
        Klijent selektiratiKlijent;
        Racun racun;
        // servisi
        KlijentServices klijentServis;
        PoslodavacServices poslodavacServis;
        public FrmIzdajNoviRacun(Poslodavac poslodavac1)
        {
            InitializeComponent();
            klijentServis= new KlijentServices();
            poslodavacServis= new PoslodavacServices();
            poslodavac = poslodavac1;
            racun = new Racun();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmIzdajNoviRacun_Load(object sender, EventArgs e)
        {
            poslodavac = poslodavacServis.GetPoslodavac();
            cmbKlijenti.DataSource = klijentServis.DohvatiKlijente();
            InitTextBoxPoslodavac(poslodavac);
            txtNacinPlacanja.Text = "(T) Transakcijski račun";
            txtRokPlacanja.Text = "do 15 dana";
        }

        private void cmbKlijenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            selektiratiKlijent = cmbKlijenti.SelectedItem as Klijent;
            InitTextBoxKlijent(selektiratiKlijent);
            GlobalListaStavki.stavkaRacunaList.Clear();
            
        }


        // inicijalizacija textboxova
        private void InitTextBoxKlijent(Klijent klijent)
        {
            txtK_Adresa.Text = klijent.Adresa;
            txtK_Ime.Text = klijent.Naziv;
            txtK_OIB.Text = klijent.OIB;
            txtK_Email.Text = klijent.Email;
        }


        private void InitTextBoxPoslodavac(Poslodavac poslodavac)
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

        private void btnDodajStavke_Click(object sender, EventArgs e)
        {
            FrmDodajStavke formaStavki = new FrmDodajStavke(selektiratiKlijent);
            formaStavki.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            formaStavki.ShowDialog();
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            dgvStavke.DataSource = GlobalListaStavki.stavkaRacunaList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
