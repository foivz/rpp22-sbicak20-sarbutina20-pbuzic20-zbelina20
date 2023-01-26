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
    public partial class FrmDodajStavke : Form
    {

        List<StavkaRacun> stavkaRacunList;
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
            stavkaRacunList = new List<StavkaRacun>();
            klijent= _klijent;
            racun = _racun;
        }

        private void FrmDodajStavke_Load(object sender, EventArgs e)
        {
            cmbUsluge.DataSource= uslugaServis.DohvatiUsluge();
            cmbRoba.DataSource = robaServis.DohvatiRobuKlijenta(klijent.Klijent_ID);
        }

        private void Refresh()
        {
            dgvStavkeDodaj.DataSource = null;
            dgvStavkeDodaj.DataSource = stavkaRacunList;
            dgvStavkeDodaj.Columns[0].Visible = false;
            dgvStavkeDodaj.Columns[1].Visible = false;
            dgvStavkeDodaj.Columns[2].Visible = false;
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
                Racun_ID = racun.Racun_ID,
                Racun = racun,
                Roba = cmbRoba.SelectedItem as Roba,
                Usluga= cmbUsluge.SelectedItem as Usluga,
                KolikoRobePoJedinici = int.Parse(txtKolikoRobePoJedinici.Text),
                KolicinaRobe = int.Parse(txtKolicina.Text),
                DatumIzrade = dtpDatumIzrade.Value,
                JedinicaMjere = txtJedinicaMjere.Text,
                JedinicnaCijena = float.Parse(txtJedinicnaCijena.Text),
                UkupnaCijenaStavke = (double)(float.Parse(txtJedinicnaCijena.Text) * int.Parse(txtKolikoRobePoJedinici.Text))
                
            };
            stavkaRacunList.Add(stavka);
            Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvStavkeDodaj.CurrentRow != null)
            {
                StavkaRacun selektiranaStavka = dgvStavkeDodaj.CurrentRow.DataBoundItem as StavkaRacun;
                if (selektiranaStavka != null)
                {
                    stavkaRacunList.Remove(selektiranaStavka);
                }
            }
            Refresh();
        }

        private void dgvStavkeDodaj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
