using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using EntitiesLayer.GlobalniObjekti;
using System;
using System.Collections;
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
    public partial class FrmDodajStavke : Form
    {
        //objekti
        Klijent klijent;
        Racun racun;
        Roba selektiranaRoba;
        Usluga selektiranaUsluga;
        //servisi
        UslugaServices uslugaServis;
        RobaService robaServis;
        StavkaRacunService stavkaServis;

        public FrmDodajStavke(Klijent _klijent, Racun _racun)
        {
            InitializeComponent();
            ucitajPomoc();
            uslugaServis= new UslugaServices();
            robaServis= new RobaService();
            stavkaServis= new StavkaRacunService();
            klijent= _klijent;
            racun= _racun;
        }

        private void ucitajPomoc()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void FrmDodajStavke_Load(object sender, EventArgs e)
        {
            cmbUsluge.DataSource= uslugaServis.DohvatiUsluge();
            cmbRoba.DataSource = robaServis.DohvatiRobuKlijenta(klijent.Klijent_ID);
            dgvStavkeDodaj.DataSource = null;
        }

        private void Refresh()
        {
            dgvStavkeDodaj.DataSource = null;
            dgvStavkeDodaj.DataSource = GlobalListaStavki.stavkaRacunaList;
            dgvStavkeDodaj.Columns[0].Visible = false;
            dgvStavkeDodaj.Columns[1].Visible = false;
            dgvStavkeDodaj.Columns[2].Visible = false;
            dgvStavkeDodaj.Columns[9].Visible = false;
        }

        private void btnNatrag_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            // napraviStavku(Stavka, selektiranaRoba, selektiranaUsluga)
            StavkaRacun stavka = new StavkaRacun
            {
                KolikoRobePoJedinici = int.Parse(txtKolikoRobePoJedinici.Text),
                KolicinaRobe = int.Parse(txtKolicina.Text),
                DatumIzrade = dtpDatumIzrade.Value,
                JedinicaMjere = txtJedinicaMjere.Text,
                JedinicnaCijena = double.Parse(txtJedinicnaCijena.Text),
                UkupnaCijenaStavke = (double)(double.Parse(txtJedinicnaCijena.Text) * int.Parse(txtKolicina.Text))
                
            };
            stavka = stavkaServis.InitStavka(stavka, selektiranaRoba, selektiranaUsluga);
            GlobalListaStavki.stavkaRacunaList.Add(stavka);
            Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvStavkeDodaj.CurrentRow != null)
            {
                StavkaRacun selektiranaStavka = dgvStavkeDodaj.CurrentRow.DataBoundItem as StavkaRacun;
                if (selektiranaStavka != null)
                {
                    GlobalListaStavki.stavkaRacunaList.Remove(selektiranaStavka);
                }
            }
            Refresh();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string path = Path.Combine(Application.StartupPath, "..\\..\\Pomoc\\Racuni\\Stavke\\stavkeRacuna.html");
                System.Diagnostics.Process.Start(path);
            }
        }

        private void cmbUsluge_SelectedIndexChanged(object sender, EventArgs e)
        {
            selektiranaUsluga = cmbUsluge.SelectedItem as Usluga;
        }

        private void cmbRoba_SelectedIndexChanged(object sender, EventArgs e)
        {
            selektiranaRoba = cmbRoba.SelectedItem as Roba;
        }
    }
}
