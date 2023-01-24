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
    public partial class FrmPopisIzvjestaja : Form
    {
        private KlijentServices servisKlijent = new KlijentServices();
        List<Klijent> desetNajboljih;
        public FrmPopisIzvjestaja()
        {
            InitializeComponent();
        }

        private void btnIzvjestajKlijenata_Click(object sender, EventArgs e)
        {
            FrmIzvjestajKlijenata form = new FrmIzvjestajKlijenata(desetNajboljih);
            form.ShowDialog();
        }

        private void FrmPopisIzvjestaja_Load(object sender, EventArgs e)
        {
            ucitajKlijente();
        }

        private void ucitajKlijente()
        {
            desetNajboljih = servisKlijent.DohvatiDesetNajboljih();
            provjeri(desetNajboljih);
            dgvKlijenti.DataSource = desetNajboljih;
            dgvKlijenti.Columns[9].Visible = false;
            dgvKlijenti.Columns[10].Visible = false;
            dgvKlijenti.Columns[11].Visible = false;
            dgvKlijenti.Columns[12].Visible = false;
            dgvKlijenti.Columns[13].Visible = false;
        }

        private void provjeri(List<Klijent> desetNajboljih)
        {
            if (desetNajboljih.Count() == 0)
            {
                throw new Exception("Nema nikakvih podataka");
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
