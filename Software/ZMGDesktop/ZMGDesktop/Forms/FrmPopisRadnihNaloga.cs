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
    public partial class FrmPopisRadnihNaloga : Form
    {
        Radnik Radnik = new Radnik();
        public FrmPopisRadnihNaloga(Radnik radnik)
        {
            InitializeComponent();
            ucitajPomoc();
            Radnik = radnik;
        }

        private void ucitajPomoc()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        RadniNalogService servis = new RadniNalogService();

        private void btnNoviRadniNalog_Click(object sender, EventArgs e)
        {
            FrmNoviRadniNalog frmNoviRadniNalog = new FrmNoviRadniNalog(Radnik);
            frmNoviRadniNalog.ShowDialog();
            UcitajRadneNaloge();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPopisRadnihNaloga_Load(object sender, EventArgs e)
        {
            UcitajRadneNaloge();
        }

        private void UcitajRadneNaloge()
        {
            var popisRadnihNaloga = servis.DohvatiRadneNaloge();
            dgvPopisRadnihNaloga.DataSource = popisRadnihNaloga;
            dgvPopisRadnihNaloga.Columns[6].Visible = false;
            dgvPopisRadnihNaloga.Columns[7].Visible = false;
            dgvPopisRadnihNaloga.Columns[10].Visible = false;
            dgvPopisRadnihNaloga.Columns[11].Visible = false;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            var odabraniRadniNalog = DohvatiRadniNalog();

            if(odabraniRadniNalog == null)
            {
                MessageBox.Show("Morate odabrati radni nalog da biste ga izbrisali!");
            }
            else
            {
                servis.ObrisiRadniNalog(odabraniRadniNalog);
            }
            
            UcitajRadneNaloge();
        }

        private RadniNalog DohvatiRadniNalog()
        {
            if(dgvPopisRadnihNaloga.CurrentRow != null)
            {
                return dgvPopisRadnihNaloga.CurrentRow.DataBoundItem as RadniNalog;
            }
            return null;
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            var odabraniRadniNalog = DohvatiRadniNalog();

            if (odabraniRadniNalog == null)
            {
                MessageBox.Show("Morate odabrati radni nalog da biste vidjeli njegove detalje!");
            }
            else
            {
                FrmDetaljiRadnogNaloga frmDetaljiRadnogNaloga = new FrmDetaljiRadnogNaloga(odabraniRadniNalog, Radnik);
                frmDetaljiRadnogNaloga.ShowDialog();
            }
            
            UcitajRadneNaloge();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string path = Path.Combine(Application.StartupPath, "Pomoc\\Pomoc\\RadniNalozi\\RadniNalozi\\radniNalozi.html");
                System.Diagnostics.Process.Start(path);
            }
        }
    }
}
