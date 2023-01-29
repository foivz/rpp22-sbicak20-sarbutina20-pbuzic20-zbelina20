using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace ZMGDesktop
{
    public partial class FrmPrimka : Form
    {
        Materijal mat;
        int kol;
        PrimkaServices primkaServis = new PrimkaServices();
        public FrmPrimka(Materijal materijal, int kolicina)
        {
            mat = materijal;
            kol = kolicina;
            InitializeComponent();
            ucitajPomoc();
        }

        private void ucitajPomoc()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrimka_Load(object sender, EventArgs e)
        {
            txtKolicina.Text = kol.ToString();
            txtMjernaJedinica.Text = mat.JedinicaMjere.ToString();
            txtNaziv.Text = mat.Naziv.ToString();
            txtDatum.Text = DateTime.Now.ToString();
            PohraniBaza();
        }

        private void PohraniBaza()
        {
            Primka primka = new Primka();
            primka.Naziv_Materijal = mat.Naziv.ToString();
            primka.Kolicina = kol;
            primka.Datum = DateTime.Now.Date;
            primkaServis.dodajPrimku(primka);
        }

        private void btnPohrani_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.RestoreDirectory = true;
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string podaci = "Naziv materijala: " + txtNaziv.Text + Environment.NewLine + "Količina: " + txtKolicina.Text + " " + txtMjernaJedinica.Text + Environment.NewLine + "Datum: " + txtDatum.Text;
                    File.WriteAllText(saveDialog.FileName, podaci);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string path = Path.Combine(Application.StartupPath, "Pomoc\\Pomoc\\Skladiste\\Primka\\primka.html");
                System.Diagnostics.Process.Start(path);
            }
        }
    }
}
