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

        // servisi
        KlijentServices klijentServis;
        public FrmIzdajNoviRacun()
        {
            InitializeComponent();
            klijentServis= new KlijentServices();
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
        }

        private void cmbKlijenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Klijent selektirati = cmbKlijenti.SelectedItem as Klijent;
            txtK_Adresa.Text = selektirati.Adresa;
            txtK_Ime.Text = selektirati.Naziv;
            txtK_OIB.Text = selektirati.OIB;
            txtK_Email.Text = selektirati.Email;
        }
    }
}
