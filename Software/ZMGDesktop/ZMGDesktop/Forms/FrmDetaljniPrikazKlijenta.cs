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
    public partial class FrmDetaljniPrikazKlijenta : Form
    {
        private Klijent selektiran;
        private RacunService racunServis = new RacunService();
        private RadniNalogService radniNalogServis = new RadniNalogService();
        public FrmDetaljniPrikazKlijenta()
        {
            InitializeComponent();
        }

        public FrmDetaljniPrikazKlijenta(Klijent klijent)
        {
            InitializeComponent();
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
            dgvRacuni.Columns[8].Visible = false;
            dgvRacuni.Columns[9].Visible = false;
            dgvRacuni.Columns[10].Visible = false;
            dgvRacuni.Columns[11].Visible = false;
        }

        private void ucitajRadneNaloge(Klijent selektiran)
        {
            var radniNalozi = radniNalogServis.DohvatiRadneNalogeZaKlijenta(selektiran);
            dgvRadniNalozi.DataSource = radniNalozi;
            dgvRadniNalozi.Columns[7].Visible = false;
            dgvRadniNalozi.Columns[8].Visible = false;
            dgvRadniNalozi.Columns[9].Visible = false;
        }

        private void provjeriKlijenta(Klijent selektiran)
        {
            if(selektiran == null)
            {
                MessageBox.Show("Nije odabran nijedan klijent", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblImeiPrezime.Text = selektiran.Naziv;
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
