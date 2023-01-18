using BusinessLogicLayer.Services;
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
        MaterijalServices servis = new MaterijalServices();
        public FrmKatalog()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajMaterijal dodaj = new FrmDodajMaterijal();
            dodaj.Show();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }

        private void btnZaprimi_Click(object sender, EventArgs e)
        {
            FrmZaprimiMaterijal zaprimi = new FrmZaprimiMaterijal();
            zaprimi.ShowDialog();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }

        private void FrmKatalog_Load(object sender, EventArgs e)
        {
            PrikaziMaterijale();
        }

        private void PrikaziMaterijale()
        {
            var materijali = servis.DohvatiMaterijale();

            dgvMaterijali.DataSource = materijali;
            dgvMaterijali.Columns["Primka_ID"].Visible = false;
            dgvMaterijali.Columns["Usluga_ID"].Visible = false;
            dgvMaterijali.Columns["Primka"].Visible = false;
            dgvMaterijali.Columns["Usluga"].Visible = false;
        }
    }
}
