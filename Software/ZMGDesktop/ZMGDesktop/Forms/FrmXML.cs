using BusinessLogicLayer.Services;
using DataAccessLayer.Iznimke;
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
using System.Xml;
using System.Xml.Linq;
using ZMGDesktop.ValidacijaUnosa;

namespace ZMGDesktop
{
    public partial class FrmXML : Form
    {
        private string fileName;
        private KlijentServices servisKlijent = new KlijentServices();
        private Validacija validacija = new Validacija();
        public FrmXML()
        {
            InitializeComponent();
            ucitajPomoc();
        }

        private void ucitajPomoc()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
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
                        if (provjeri(klijent))
                            servisKlijent.Add(klijent);
                        else
                        {
                            MessageBox.Show("Neuspješno ubacivanje korisnika", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        };
                            
                    }
                    dgvKlijentiXML.DataSource = klijentiList;
                    dgvKlijentiXML.Columns[0].Visible = false;
                    dgvKlijentiXML.Columns[8].Visible = false;
                    dgvKlijentiXML.Columns[9].Visible = false;
                    dgvKlijentiXML.Columns[10].Visible = false;
                    dgvKlijentiXML.Columns[11].Visible = false;
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
            catch (TelefonException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            catch (IBANException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            catch (OIBException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            catch (EmailException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private bool provjeri(Klijent klijent)
        {
            if (klijent.IBAN == "" || klijent.Naziv == "" || klijent.Mjesto == "" || klijent.Adresa == "" || klijent.OIB == "" || klijent.BrojTelefona == "" || klijent.Email == "")
            {
                MessageBox.Show("Potrebno je ispuniti sva polja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (validacija.provjeraSamoSlova(klijent.Naziv) == false)
            {
                MessageBox.Show("Naziv može sadržavati samo slova", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (validacija.provjeraOIB(klijent.OIB) == false)
            {
                MessageBox.Show("Krivo unesen OIB", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (validacija.provjeraUlica(klijent.Adresa) == false)
            {
                MessageBox.Show("Krivo unesena adresa", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (validacija.provjeraRacuna(klijent.IBAN) == false)
            {
                MessageBox.Show("Krivo uneesn IBAN račun", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (validacija.provjeraMjesta(klijent.Mjesto) == false)
            {
                MessageBox.Show("Krivo uneseno mjesto", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (validacija.provjeraTelefon(klijent.BrojTelefona) == false)
            {
                MessageBox.Show("Krivi broj telefona", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (validacija.provjeraMaila(klijent.Email) == false)
            {
                MessageBox.Show("Krivi email", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string path = Path.Combine(Application.StartupPath, "..\\..\\Pomoc\\Klijenti\\UveziKlijentaXML\\uveziKlijenta.html");
                System.Diagnostics.Process.Start(path);
            }
        }
        
    }
}
