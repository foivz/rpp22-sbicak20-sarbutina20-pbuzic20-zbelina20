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
        RacunService racunServis;
        //objekti
        Poslodavac poslodavac;
        Klijent selektirani;
        Radnik radnik;

        public FrmRacuni(Radnik _radnik)
        {
            InitializeComponent();
            poslodavacServis = new PoslodavacServices();
            klijentServis= new KlijentServices();
            racunServis = new RacunService();
            radnik = _radnik;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnIzdajNoviRacun_Click(object sender, EventArgs e)
        {
            FrmIzdajNoviRacun noviRacun = new FrmIzdajNoviRacun(poslodavac, radnik);
            noviRacun.ShowDialog();
        }

        private void FrmRacuni_Load(object sender, EventArgs e)
        {
            poslodavac = poslodavacServis.GetPoslodavac();
            cmbKlijent.DataSource = klijentServis.DohvatiKlijente();
            Refresh();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbKlijent_SelectedIndexChanged(object sender, EventArgs e)
        {
            selektirani = cmbKlijent.SelectedItem as Klijent;
        }

        private void Refresh()
        {
            dgvRacuni.DataSource = racunServis.DohvatiSveRacune();
            dgvRacuni.Columns[13].Visible = false;
            dgvRacuni.Columns[15].Visible = false;
        }
    }
}
