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
            this.desetNajboljih = desetNajboljih;
        }
        public FrmIzvjestajKlijenata()
        {
            InitializeComponent();
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
    }
}
