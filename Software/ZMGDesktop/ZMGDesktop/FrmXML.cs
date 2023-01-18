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
using System.Xml;
using System.Xml.Linq;

namespace ZMGDesktop
{
    public partial class FrmXML : Form
    {
        private string fileName;
        private KlijentServices servisKlijent = new KlijentServices();
        public FrmXML()
        {
            InitializeComponent();
        }

        private void FrmXML_Load(object sender, EventArgs e)
        {
            btnUnesi.Enabled = false;
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Odaberite XML datoteku";
            openFileDialog.Filter = "XML File (*.xml)|*.xml";
            DialogResult result = openFileDialog.ShowDialog(); 
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                btnUnesi.Enabled = true;
                fileName = openFileDialog.FileName;
                MessageBox.Show(fileName);
            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument xDoc = XDocument.Load(fileName);
                List<Klijent> klijentiList = xDoc.Descendants("klijent").
                    Select(klijent =>
                    new Klijent
                    {
                        Naziv = klijent.Element("Naziv").Value,
                        Adresa = klijent.Element("Adresa").Value,
                        Mjesto = klijent.Element("Mjesto").Value,
                        OIB = klijent.Element("OIB").Value,
                        BrojTelefona = klijent.Element("BrojTelefona").Value,
                        Email = klijent.Element("Email").Value,
                        IBAN = klijent.Element("IBAN").Value
                    }).ToList();
                if (klijentiList.Count != 0)
                {
                    foreach (var klijent in klijentiList)
                    {
                        servisKlijent.Add(klijent);
                    }
                    dgvKlijentiXML.DataSource = klijentiList;
                    dgvKlijentiXML.Columns[0].Visible = false;
                    dgvKlijentiXML.Columns[9].Visible = false;
                    dgvKlijentiXML.Columns[10].Visible = false;
                    dgvKlijentiXML.Columns[11].Visible = false;
                    dgvKlijentiXML.Columns[12].Visible = false;
                    MessageBox.Show("Uspješno učitani korisnici");
                }
                else
                {
                    MessageBox.Show("Krivi format XML datoteke, ne mogu pročitati");
                }
            }
            catch (UserException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }
    }
}
