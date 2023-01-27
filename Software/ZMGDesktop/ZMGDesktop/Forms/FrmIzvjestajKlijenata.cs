using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
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
            provjeri(desetNajboljih);
            klijentBindingSource.DataSource = desetNajboljih;
            this.reportViewer1.RefreshReport();
        }

        private void provjeri(List<Klijent> desetNajboljih)
        {
            if(desetNajboljih.Count() == 0)
            {
                throw new Exception("Nema nikakvih podataka");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("C:\\Users\\Patrik\\source\\repos\\rpp22-sbicak20-sarbutina20-pbuzic20-zbelina20\\Documentation\\Pomoc\\Izvještaji\\IzvjestajKlijenata\\izvjestajKlijenata.html");
            }
        }

        
    }
}
