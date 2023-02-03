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
using iTextSharp.text;
using iTextSharp.text.pdf;


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
            Document doc = new Document(PageSize.A4, 10, 10, 42, 35); 
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Documents (.pdf)|.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                doc.Open();
                Paragraph title = new Paragraph("Podaci o materijalu");
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                Paragraph naziv = new Paragraph("Naziv: " + txtNaziv.Text);
                doc.Add(naziv);

                Paragraph kolicina = new Paragraph("Kolicina: " + txtKolicina.Text + " " + txtMjernaJedinica.Text);
                doc.Add(kolicina);

                Paragraph datum = new Paragraph("Datum: " + txtDatum.Text);
                doc.Add(datum);

                doc.Close();
                MessageBox.Show("PDF dokument uspješno kreiran i spremljen.");

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

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
