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
    public partial class FrmPopisIzvjestaja : Form
    {
        private KlijentServices servisKlijent = new KlijentServices();
        private RadniNalogService servisRadnihNaloga = new RadniNalogService();

        List<Klijent> desetNajboljih;
        List<RadniNalog> radniNaloziPoStatusima;
        public FrmPopisIzvjestaja()
        {
            InitializeComponent();
            ucitajPomoc();
        }

        private void ucitajPomoc()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void btnIzvjestajKlijenata_Click(object sender, EventArgs e)
        {
            FrmIzvjestajKlijenata form = new FrmIzvjestajKlijenata(desetNajboljih);
            form.ShowDialog();
        }

        private void FrmPopisIzvjestaja_Load(object sender, EventArgs e)
        {
            ucitajKlijente();
            ucitajRadneNaloge();
        }

        private void ucitajRadneNaloge()
        {
            radniNaloziPoStatusima = servisRadnihNaloga.DohvatiRadneNalogePoStatusima();
            dgvRadniNalozi.DataSource = radniNaloziPoStatusima;
            dgvRadniNalozi.Columns[6].Visible = false;
            dgvRadniNalozi.Columns[7].Visible = false;
            dgvRadniNalozi.Columns[10].Visible = false;
            dgvRadniNalozi.Columns[11].Visible = false;
        }

        private void ucitajKlijente()
        {
            desetNajboljih = servisKlijent.DohvatiDesetNajboljih();
            provjeri(desetNajboljih);
            dgvKlijenti.DataSource = desetNajboljih;
            dgvKlijenti.Columns[8].Visible = false;
            dgvKlijenti.Columns[9].Visible = false;
            dgvKlijenti.Columns[10].Visible = false;
            dgvKlijenti.Columns[11].Visible = false;
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

        private void btnIzvjestajRadnihNaloga_Click(object sender, EventArgs e)
        {
            FrmKreirajIzvjestajRadnihNaloga frmKreirajIzvjestajRadnihNaloga = new FrmKreirajIzvjestajRadnihNaloga();
            frmKreirajIzvjestajRadnihNaloga.ShowDialog();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string path = Path.Combine(Application.StartupPath, "..\\..\\Pomoc\\Izvjestaji\\Izvjestaji\\izvjestaji.html");
                System.Diagnostics.Process.Start(path);
            }
        }
    }
}
