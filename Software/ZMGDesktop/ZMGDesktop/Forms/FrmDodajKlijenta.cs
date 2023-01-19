﻿using BusinessLogicLayer.Services;
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
        }

        public FrmDodajKlijenta(Klijent klijent)
        {
            InitializeComponent();
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
                if (selektiran == null)
                {
                    try
                    {
                        dodajKlijenta();
                        Close();
                    }
                    catch (UserException ex)
                    {
                        MessageBox.Show(ex.Poruka);
                    }
                    
                }
                else
                {
                    azurirajKlijenta(selektiran);
                    Close();
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
            if(validacija.provjeraSamoSlova(txtMjesto.Text) == false)
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
                ucitajPodatke(selektiran);
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
    }
}
