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
    public partial class FrmIzdajNoviRacun : Form
    {
        //objekti
        Poslodavac poslodavac;
        // servisi
        KlijentServices klijentServis;
        public FrmIzdajNoviRacun(Poslodavac poslodavac1)
        {
            InitializeComponent();
            klijentServis= new KlijentServices();
            poslodavac = poslodavac1;
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
            cmbKlijenti.DataSource = klijentServis.DohvatiKlijente();
            InitTextBoxPoslodavac(poslodavac);
        }

        private void cmbKlijenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Klijent selektirati = cmbKlijenti.SelectedItem as Klijent;
            InitTextBoxKlijent(selektirati);
            
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
    }
}
