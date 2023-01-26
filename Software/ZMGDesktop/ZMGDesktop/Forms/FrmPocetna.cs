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
    public partial class FrmPocetna : Form
    {
        Radnik radnik;
        public FrmPocetna()
        {
            InitializeComponent();
        }

        public FrmPocetna(Radnik provjereniRadnik)
        {
            radnik = provjereniRadnik;
            this.FormClosing += new FormClosingEventHandler(MyForm_FormClosing);
            InitializeComponent();
        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            FrmPregledKlijenata forma = new FrmPregledKlijenata();
            forma.ShowDialog();
        }

        private void btnRadniNalozi_Click(object sender, EventArgs e)
        {
            FrmPopisRadnihNaloga frmPopisRadnihNaloga = new FrmPopisRadnihNaloga(radnik);
            frmPopisRadnihNaloga.ShowDialog();
        }

        private void btnStanjeSkladista_Click(object sender, EventArgs e)
        {
            FrmKatalog katalog = new FrmKatalog();
            katalog.ShowDialog();
        }

        private void btnIzvjestaji_Click(object sender, EventArgs e)
        {
            FrmPopisIzvjestaja form = new FrmPopisIzvjestaja();
            form.ShowDialog();
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRacuni_Click(object sender, EventArgs e)
        {
            FrmRacuni racuni = new FrmRacuni(radnik);
            racuni.ShowDialog();
        }

        private void FrmPocetna_Load(object sender, EventArgs e)
        {

        }
    }
}
