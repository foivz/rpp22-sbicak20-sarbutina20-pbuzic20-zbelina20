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
    public partial class FrmKatalog : Form
    {
        UslugaServices uslugaServis = new UslugaServices();
        MaterijalServices matServis = new MaterijalServices();
        public FrmKatalog()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajMaterijal dodaj = new FrmDodajMaterijal();
            dodaj.ShowDialog();
            PrikaziMaterijale();
            Update();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            var odabraniMaterijal = dgvMaterijali.CurrentRow.DataBoundItem as Materijal;
            if(odabraniMaterijal != null)
            {
                bool uspjeh = matServis.obrisiMaterijal(odabraniMaterijal);

                if (uspjeh == false)
                {
                    MessageBox.Show("Aplikacije nije uspjela obrisati materijal");
                }
                
                PrikaziMaterijale();
            }
        }

        private void btnZaprimi_Click(object sender, EventArgs e)
        {
            FrmZaprimiMaterijal zaprimi = new FrmZaprimiMaterijal();
            zaprimi.ShowDialog();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKatalog_Load(object sender, EventArgs e)
        {
            PrikaziMaterijale();
            PrikaziUsluge();
        }

        private void PrikaziUsluge()
        {
            var usluge =  uslugaServis.DohvatiUsluge();
            dgvUsluge.DataSource = usluge;
        }

        private void PrikaziMaterijale()
        {
            var materijali =  matServis.DohvatiMaterijale();

            dgvMaterijali.DataSource = materijali;
            dgvMaterijali.Columns["Primka_ID"].Visible = false;
            dgvMaterijali.Columns["Usluga_ID"].Visible = false;
            dgvMaterijali.Columns["Primka"].Visible = false;
            dgvMaterijali.Columns["Usluga"].Visible = false;
        }
    }
}
