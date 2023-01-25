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
    public partial class FrmRacuni : Form
    {

        //servisi
        PoslodavacServices poslodavacServis;
        KlijentServices klijentServis;
        //objekti
        Poslodavac poslodavac;
        Klijent selektirani;

        public FrmRacuni()
        {
            InitializeComponent();
            poslodavacServis = new PoslodavacServices();
            klijentServis= new KlijentServices();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnIzdajNoviRacun_Click(object sender, EventArgs e)
        {
            FrmIzdajNoviRacun noviRacun = new FrmIzdajNoviRacun(poslodavac);
            noviRacun.ShowDialog();
        }

        private void FrmRacuni_Load(object sender, EventArgs e)
        {
            poslodavac = poslodavacServis.GetPoslodavac();
            cmbKlijent.DataSource = klijentServis.DohvatiKlijente();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbKlijent_SelectedIndexChanged(object sender, EventArgs e)
        {
            selektirani = cmbKlijent.SelectedItem as Klijent;
        }
    }
}
