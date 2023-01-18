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
    public partial class FrmLogin : Form
    {
        private RadnikServices servis = new RadnikServices();
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var korime = txtKorIme.Text;
            var lozinka = txtLozinka.Text;
            Radnik radnik = new Radnik
            {
                Korime = korime,
                Lozinka = lozinka
            };

            Radnik provjereniRadnik = servis.ProvjeriRadnika(radnik);
            if (provjereniRadnik != null)
            {
                FrmPocetna pocetna = new FrmPocetna();
                pocetna.Show();
                this.Hide();
            }
            else MessageBox.Show("Krivi podaci!");
            
        }
    }
}
