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

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            pretrazivanje = 0;
            sortiranje = 0;
            //pretrazivanje
            rbtnDatumIzdaje.Checked = false;
            rbtnVasiRacuni.Checked = false;
            rbtnUkupniIznos.Checked = false;
            // sortiranje
            rbtnSilazno.Checked = false;
            rbtnUzlazno.Checked = false;

            Refresh();
        }

        int pretrazivanje = 0;
        int sortiranje = 0;
        private void rbtnDatumIzdaje_CheckedChanged(object sender, EventArgs e)
        {
            pretrazivanje = 1;
        }

        private void rbtnUkupniIznos_CheckedChanged(object sender, EventArgs e)
        {
            pretrazivanje = 2;
        }

        private void rbtnVasiRacuni_CheckedChanged(object sender, EventArgs e)
        {
            pretrazivanje = 3;
        }

        private void btnPretrazivanje_Click(object sender, EventArgs e)
        {
            dgvRacuni.DataSource = racunServis.DohvatiRacunePretrazivanje(selektirani, radnik.Radnik_ID, pretrazivanje, sortiranje);
        }

        private void rbtnUzlazno_CheckedChanged(object sender, EventArgs e)
        {
            sortiranje = 0;
        }

        private void rbtnSilazno_CheckedChanged(object sender, EventArgs e)
        {
            sortiranje = 1;
        }

        private void btnDetaljniPregled_Click(object sender, EventArgs e)
        {
            if (dgvRacuni.CurrentRow != null)
            {
                Racun selektiraniRacun = dgvRacuni.CurrentRow.DataBoundItem as Racun;
                if (selektiraniRacun!= null )
                {
                    FrmDetaljniPregledRacun pregledRacuna = new FrmDetaljniPregledRacun(selektiraniRacun);
                    pregledRacuna.ShowDialog();
                }
            }
        }
    }
}
