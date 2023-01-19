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
            
            var naziv = txtNaziv.Text;
            var kolicina = Convert.ToInt32(txtKolicina.Text);
            var odabranaJedinica = cmbMjernaJedinica.SelectedItem.ToString();
            var cijena = Convert.ToDouble(txtCijena.Text);
            var opis = txtOpis.Text;
            //var opasno = Convert.ToByte(txtOpis);
            var qr_kod = GenerirajRandomString();
            Materijal noviMaterijal = new Materijal
            {
                Naziv = naziv,
                Kolicina = kolicina,
                JedinicaMjere = odabranaJedinica,
                CijenaMaterijala = cijena,
                Opis = opis,
                OpasnoPoZivot = 1,
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
