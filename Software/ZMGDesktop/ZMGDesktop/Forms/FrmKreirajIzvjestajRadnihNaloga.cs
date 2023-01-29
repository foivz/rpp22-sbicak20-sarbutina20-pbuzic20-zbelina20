using BusinessLogicLayer.Services;
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
    public partial class FrmKreirajIzvjestajRadnihNaloga : Form
    {
        RadniNalogService servis = new RadniNalogService();

        public FrmKreirajIzvjestajRadnihNaloga()
        {
            InitializeComponent();
            ucitajPomoc();
        }

        private void ucitajPomoc()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void FrmKreirajIzvjestajRadnihNaloga_Load(object sender, EventArgs e)
        {
            var listaRadnihNaloga = servis.DohvatiRadneNalogePoStatusima();
            radniNalogBindingSource.DataSource = listaRadnihNaloga;

            this.reportViewRadniNalozi.RefreshReport();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string path = Path.Combine(Application.StartupPath, "Pomoc\\Pomoc\\Izvjestaji\\IzvjestajRadnihNaloga\\izvjestajRadnihNaloga.html");
                System.Diagnostics.Process.Start(path);
            }
        }
    }
}
