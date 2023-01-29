using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZMGDesktop
{
    public partial class FrmDetaljniPrikazKlijenta : Form
    {
        private Klijent selektiran;
        private RacunService racunServis = new RacunService();
        private RadniNalogService radniNalogServis = new RadniNalogService();
        public FrmDetaljniPrikazKlijenta()
        {
            InitializeComponent();
            ucitajPomoc();
        }

        private void ucitajPomoc()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        public FrmDetaljniPrikazKlijenta(Klijent klijent)
        {
            InitializeComponent();
            ucitajPomoc();
            this.selektiran = klijent;
        }

        private void FrmDetaljniPrikazKlijenta_Load(object sender, EventArgs e)
        {
            provjeriKlijenta(selektiran);
            ucitajRadneNaloge(selektiran);
            ucitajRacune(selektiran);

        }

        private void ucitajRacune(Klijent selektiran)
        {
            var racuni = racunServis.DohvatiRacuneZaKlijenta(selektiran);
            dgvRacuni.DataSource = racuni;
            dgvRacuni.Columns[5].Visible = false;
            dgvRacuni.Columns[6].Visible = false;
            dgvRacuni.Columns[7].Visible = false;
            dgvRacuni.Columns[15].Visible = false;
        }

        private void ucitajRadneNaloge(Klijent selektiran)
        {
            var radniNalozi = radniNalogServis.DohvatiRadneNalogeZaKlijenta(selektiran);
            dgvRadniNalozi.DataSource = radniNalozi;
            dgvRadniNalozi.Columns[6].Visible = false;
            dgvRadniNalozi.Columns[7].Visible = false;
            dgvRadniNalozi.Columns[10].Visible = false;
            dgvRadniNalozi.Columns[11].Visible = false;
        }

        private void provjeriKlijenta(Klijent selektiran)
        {
            if(selektiran == null)
            {
                MessageBox.Show("Nije odabran nijedan klijent", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                labelImePrezime.Text = selektiran.Naziv;
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string path = Path.Combine(Application.StartupPath, "Pomoc\\Pomoc\\Klijenti\\DetaljiKlijenta\\detaljiKlijenta.html");
                System.Diagnostics.Process.Start(path);
            }
        }

    }
}
