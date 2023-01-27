using BusinessLogicLayer.Services;
using DataAccessLayer.Iznimke;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZMGDesktop.ValidacijaUnosa;

namespace ZMGDesktop
{
    public partial class FrmDodajKlijenta : Form
    {
        private KlijentServices servisKlijent = new KlijentServices();
        private Klijent selektiran;
        private Validacija validacija = new Validacija();
        public FrmDodajKlijenta()
        {
            InitializeComponent();
            ucitajPomoc();
        }

        private void ucitajPomoc()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        public FrmDodajKlijenta(Klijent klijent)
        {
            InitializeComponent();
            ucitajPomoc();
            this.selektiran = klijent;
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (provjeriUnos() == true)
            {
                try
                {
                    if (selektiran == null)
                    {
                        dodajKlijenta();
                        Close();
                    }
                    else
                    {
                        azurirajKlijenta(selektiran);
                        Close();
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
        }

        private void azurirajKlijenta(Klijent selektiran)
        {
            selektiran.Naziv = txtNaziv.Text;
            selektiran.OIB = txtOIB.Text;
            selektiran.Adresa = txtAdresa.Text;
            selektiran.IBAN = txtIBAN.Text;
            selektiran.Mjesto = txtMjesto.Text;
            selektiran.BrojTelefona = txtTelefon.Text;
            selektiran.Email = txtEmail.Text;
            servisKlijent.Update(selektiran);
        }

        private bool provjeriUnos()
        {
            if(txtIBAN.Text == "" || txtNaziv.Text == "" || txtMjesto.Text == "" || txtAdresa.Text == "" || txtOIB.Text == "" || txtTelefon.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Potrebno je ispuniti sva polja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(validacija.provjeraSamoSlova(txtNaziv.Text) == false)
            {
                MessageBox.Show("Naziv može sadržavati samo slova");
                return false;
            }
            if(validacija.provjeraOIB(txtOIB.Text) == false)
            {
                MessageBox.Show("Krivo unesen OIB");
                return false;
            }
            if(validacija.provjeraUlica(txtAdresa.Text) == false)
            {
                MessageBox.Show("Krivo unesena adresa");
                return false;
            }
            if(validacija.provjeraRacuna(txtIBAN.Text) == false)
            {
                MessageBox.Show("Krivo uneesn IBAN račun");
                return false;
            }
            if(validacija.provjeraMjesta(txtMjesto.Text) == false)
            {
                MessageBox.Show("Krivo uneseno mjesto");
                return false;
            }
            if(validacija.provjeraTelefon(txtTelefon.Text) == false)
            {
                MessageBox.Show("Krivi broj telefona");
                return false;
            }
            if(validacija.provjeraMaila(txtEmail.Text) == false)
            {
                MessageBox.Show("Krivi email");
                return false;
            }
            return true;
        }

        private void dodajKlijenta()
        {
            var klijent = new Klijent
            {
                Naziv = txtNaziv.Text,
                Adresa = txtAdresa.Text,
                Mjesto = txtMjesto.Text,
                OIB = txtOIB.Text,
                BrojTelefona = txtTelefon.Text,
                Email = txtEmail.Text,
                IBAN = txtIBAN.Text
            };
            servisKlijent.Add(klijent);
        }

        private void FrmDodajKlijenta_Load(object sender, EventArgs e)
        {
            if(selektiran != null)
            {
                labelDodajKlijenta.Text = selektiran.Naziv;
                ucitajPodatke(selektiran);
            }
            else
            {
                labelDodajKlijenta.Text = "Dodaj klijenta";
            }
        }

        private void ucitajPodatke(Klijent selektiran)
        {
            txtNaziv.Text = selektiran.Naziv;
            txtOIB.Text = selektiran.OIB;
            txtAdresa.Text = selektiran.Adresa;
            txtIBAN.Text = selektiran.IBAN;
            txtMjesto.Text = selektiran.Mjesto;
            txtTelefon.Text = selektiran.BrojTelefona;
            txtEmail.Text = selektiran.Email;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start("C:\\Users\\Patrik\\source\\repos\\rpp22-sbicak20-sarbutina20-pbuzic20-zbelina20\\Documentation\\Pomoc\\Klijenti\\DodajKlijenta\\dodajKlijenta.html");
            }
        }
    }
}
