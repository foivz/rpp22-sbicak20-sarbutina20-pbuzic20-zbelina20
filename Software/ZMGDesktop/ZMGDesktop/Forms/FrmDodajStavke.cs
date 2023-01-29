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
using System.Management.Instrumentation;
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
            txtJedinicaMjere.Text = "kg";
            Osvjezi();
        }

        private void Osvjezi()
        {
            this.Invalidate();
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

        private int kolikoRobe, kolicinaRobe;
        private double jedinicnaCijena;
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                kolikoRobe= int.Parse(txtKolikoRobePoJedinici.Text);
                jedinicnaCijena = double.Parse(txtJedinicnaCijena.Text);
                kolicinaRobe = int.Parse(txtKolicina.Text);

            } catch(FormatException)
            {
                MessageBox.Show("Neispravan unos znakova tamo gdje se traže brojevi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StavkaRacun stavka = new StavkaRacun
            {
                KolikoRobePoJedinici = kolikoRobe,
                KolicinaRobe = kolicinaRobe,
                DatumIzrade = dtpDatumIzrade.Value,
                JedinicaMjere = txtJedinicaMjere.Text,
                JedinicnaCijena = jedinicnaCijena,
                UkupnaCijenaStavke = Math.Round((double)(jedinicnaCijena * kolikoRobe), 2)

            };
            stavka = stavkaServis.InitStavka(stavka, selektiranaRoba, selektiranaUsluga);
            if (stavkaServis.ProvjeriDuplikat(GlobalListaStavki.stavkaRacunaList, stavka)){
                MessageBox.Show("Stavka je već dodana!", "Provjera stavki", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            GlobalListaStavki.stavkaRacunaList.Add(stavka);
            Osvjezi();
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
            Osvjezi();
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
