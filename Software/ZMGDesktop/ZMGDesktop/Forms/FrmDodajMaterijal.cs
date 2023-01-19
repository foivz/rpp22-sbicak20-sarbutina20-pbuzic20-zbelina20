using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EntitiesLayer.Entities.Enumeracije;

namespace ZMGDesktop
{
    public partial class FrmDodajMaterijal : Form
    {
        MaterijalServices matServis = new MaterijalServices();
        public FrmDodajMaterijal()
        {
            InitializeComponent();
        }

       

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDodajMaterijal_Load(object sender, EventArgs e)
        {
            UcitajMjerneJedinice();
        }

        private void UcitajMjerneJedinice()
        {
            cmbMjernaJedinica.DataSource = Enum.GetValues(typeof(MjerneJedinice));
        }

        private void btnDodajMaterijal_Click(object sender, EventArgs e)
        {
            
            string naziv = txtNaziv.Text;
            int kolicina = Convert.ToInt32(txtKolicina.Text);
            string odabranaJedinica = cmbMjernaJedinica.SelectedItem.ToString();
            float cijena = float.Parse(txtCijena.Text);
            string opis = txtOpis.Text;
            int opasno = Convert.ToInt16(txtOpasno.Text);
            string qr_kod = GenerirajRandomString();
            Materijal noviMaterijal = new Materijal
            {
                Naziv = naziv,
                Kolicina = kolicina,
                JedinicaMjere = odabranaJedinica,
                CijenaMaterijala = cijena,
                Opis = opis,
                OpasnoPoZivot = opasno,
                QR_kod = qr_kod
            };
            matServis.dodajMaterijal(noviMaterijal);
            this.Close();
        }

        string GenerirajRandomString()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 20)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
