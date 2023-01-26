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
    public partial class FrmDodajStavke : Form
    {

        //objekti
        Klijent klijent;
        //servisi
        UslugaServices uslugaServis;
        RobaService robaServis;
        public FrmDodajStavke(Klijent _klijent)
        {
            InitializeComponent();
            uslugaServis= new UslugaServices();
            robaServis= new RobaService();
            klijent= _klijent;
        }

        private void FrmDodajStavke_Load(object sender, EventArgs e)
        {
            cmbUsluge.DataSource= uslugaServis.DohvatiUsluge();
            cmbRoba.DataSource = robaServis.DohvatiRobuKlijenta(klijent.Klijent_ID);
        }

        private void btnNatrag_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
