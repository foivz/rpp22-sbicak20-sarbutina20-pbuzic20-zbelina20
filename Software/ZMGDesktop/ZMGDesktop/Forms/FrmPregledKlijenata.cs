using BusinessLogicLayer.Services;
using DataAccessLayer.Iznimke;
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
    public partial class FrmPregledKlijenata : Form
    {
        private KlijentServices servis = new KlijentServices();
        public FrmPregledKlijenata()
        {
            InitializeComponent();
        }

        private void FrmPregledKlijenata_Load(object sender, EventArgs e)
        {
            ucitajKlijente();
        }

        private void ucitajKlijente()
        {
            var klijenti = servis.DohvatiKlijente();
            dgvKlijenti.DataSource = klijenti;
            dgvKlijenti.Columns[9].Visible = false;
            dgvKlijenti.Columns[10].Visible = false;
            dgvKlijenti.Columns[11].Visible = false;
            dgvKlijenti.Columns[12].Visible = false;
            dgvKlijenti.Columns[13].Visible = false;
        }

        private void btnDetaljiKlijenta_Click(object sender, EventArgs e)
        {
            var selektiran = dohvatiSelektiranog();
            if(selektiran != null)
            {
                FrmDetaljniPrikazKlijenta forma = new FrmDetaljniPrikazKlijenta(selektiran);
                forma.ShowDialog();
            }
        }

        private Klijent dohvatiSelektiranog()
        {
            return dgvKlijenti.CurrentRow.DataBoundItem as Klijent;
        }

        private void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            FrmDodajKlijenta forma = new FrmDodajKlijenta();
            forma.ShowDialog();
            ucitajKlijente();
        }

        private void btnIzbrisiKlijenta_Click(object sender, EventArgs e)
        {
            var selektiran = dohvatiSelektiranog();
            try
            {
                if (selektiran != null)
                {
                    izbrisiKlijenta(selektiran);
                }
            }
            catch (BrisanjeKlijentaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
           
        }

        private void izbrisiKlijenta(Klijent selektiran)
        {
            servis.Remove(selektiran);
            ucitajKlijente();
        }

        private void btnUrediKlijenta_Click(object sender, EventArgs e)
        {
            var selektiran = dohvatiSelektiranog();
            if(selektiran != null)
            {
                FrmDodajKlijenta forma = new FrmDodajKlijenta(selektiran);
                forma.ShowDialog();
                ucitajKlijente();
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUveziKlijenta_Click(object sender, EventArgs e)
        {
            FrmXML form = new FrmXML();
            form.ShowDialog();
            ucitajKlijente();
        }
    }
}
