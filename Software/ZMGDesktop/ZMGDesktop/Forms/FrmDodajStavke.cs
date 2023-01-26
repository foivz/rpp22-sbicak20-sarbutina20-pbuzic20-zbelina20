using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using EntitiesLayer.GlobalniObjekti;
using System;
using System.Collections;
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
    public partial class FrmDodajStavke : Form
    {
        //objekti
        Klijent klijent;
        Racun racun;
        //servisi
        UslugaServices uslugaServis;
        RobaService robaServis;

        public FrmDodajStavke(Klijent _klijent, Racun _racun)
        {
            InitializeComponent();
            uslugaServis= new UslugaServices();
            robaServis= new RobaService();
            klijent= _klijent;
            racun= _racun;
        }

        private void FrmDodajStavke_Load(object sender, EventArgs e)
        {
            cmbUsluge.DataSource= uslugaServis.DohvatiUsluge();
            cmbRoba.DataSource = robaServis.DohvatiRobuKlijenta(klijent.Klijent_ID);
            Refresh();
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
            StavkaRacun stavka = new StavkaRacun
            {
                Usluga_ID = (cmbUsluge.SelectedItem as Usluga).Usluga_ID,
                Roba_ID = (cmbRoba.SelectedItem as Roba).Roba_ID,
                Roba = cmbRoba.SelectedItem as Roba,
                //Racun = racun,
                //Racun_ID = racun.Racun_ID,
                Usluga= cmbUsluge.SelectedItem as Usluga,
                KolikoRobePoJedinici = int.Parse(txtKolikoRobePoJedinici.Text),
                KolicinaRobe = int.Parse(txtKolicina.Text),
                DatumIzrade = dtpDatumIzrade.Value,
                JedinicaMjere = txtJedinicaMjere.Text,
                JedinicnaCijena = double.Parse(txtJedinicnaCijena.Text),
                UkupnaCijenaStavke = (double)(double.Parse(txtJedinicnaCijena.Text) * int.Parse(txtKolicina.Text))
                
            };
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

        private void dgvStavkeDodaj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
