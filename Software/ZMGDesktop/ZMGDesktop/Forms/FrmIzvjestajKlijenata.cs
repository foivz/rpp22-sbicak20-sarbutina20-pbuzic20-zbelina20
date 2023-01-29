using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ZMGDesktop
{
    public partial class FrmIzvjestajKlijenata : Form
    {
        KlijentServices servisKlijenta = new KlijentServices();
        List<Klijent> desetNajboljih;

        public FrmIzvjestajKlijenata(List<Klijent> desetNajboljih)
        {
            InitializeComponent();
            ucitajPomoc();
            this.desetNajboljih = desetNajboljih;
        }
        public FrmIzvjestajKlijenata()
        {
            InitializeComponent();
            ucitajPomoc();
        }

        private void ucitajPomoc()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void FrmIzvjestajKlijenata_Load(object sender, EventArgs e)
        {
            kreirajIzvjestaj();
        }

        private void kreirajIzvjestaj()
        {
            try
            {
                provjeri(desetNajboljih);
                klijentBindingSource.DataSource = desetNajboljih;
                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {
                MessageBox.Show("Nema dovoljno klijenta ili računa da bi kreirao izvještaj deseet najvećih klijenata.");
            }
           
        }

        private void provjeri(List<Klijent> desetNajboljih)
        {
            if(desetNajboljih.Count() == 0)
            {
                throw new Exception("Nema dovoljno podataka");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string path = Path.Combine(Application.StartupPath, "..\\..\\Pomoc\\Izvjestaji\\IzvjestajKlijenata\\izvjestajKlijenata.html");
                System.Diagnostics.Process.Start(path);
            }
        }

        
    }
}
