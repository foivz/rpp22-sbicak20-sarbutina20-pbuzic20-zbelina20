﻿using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace ZMGDesktop
{
    public partial class FrmDetaljiRadnogNaloga : Form
    {
        RadniNalog radniNalog;
        Radnik Radnik;
        Klijent odabraniKlijent;
        public FrmDetaljiRadnogNaloga(RadniNalog odabraniRadniNalog, Radnik radnik)
        {
            InitializeComponent();
            radniNalog = odabraniRadniNalog;
            Radnik = radnik;
        }

        List<Materijal> materijali = new List<Materijal>();
        List<Roba> robaZaRadniNalog = new List<Roba>();

        RadniNalogService servis = new RadniNalogService();
        RobaService robaServis = new RobaService();

        string QRKod = "";

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var klijent = cmbKlijent.SelectedItem as Klijent;
            RadniNalog AzuriraniRadniNalog = new RadniNalog()
            {
                RadniNalog_ID = radniNalog.RadniNalog_ID,
                Kolicina = int.Parse(txtKolicina.Text),
                Opis = txtOpis.Text,
                DatumStvaranja = dtpDatumStvaranja.Value,
                Status = cmbStatus.SelectedItem as string,
                QR_kod = QRKod,
                Radnik_ID = Radnik.Radnik_ID,
                Klijent_ID = klijent.Klijent_ID,
                Radnik = Radnik,
                Klijent = klijent
            };
            //poslati email
            servis.AzurirajRadniNalog(AzuriraniRadniNalog);
            Close();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            txtKolicina.Enabled = true;
            txtOpis.Enabled = true;
            txtNazivRobe.Enabled = true;
            txtKolicinaRobe.Enabled = true;

            cmbStatus.Enabled = true;
            cmbMaterijali.Enabled = true;

            btnGenerirajQRKod.Enabled = true;
            btnSpremi.Enabled = true;
            btnDodajNovuRobu.Enabled = true;
        }

        private void FrmDetaljiRadnogNaloga_Load(object sender, EventArgs e)
        {
            label1.Text += radniNalog.RadniNalog_ID.ToString();
            txtRadnik.Text = Radnik.Ime + " " + Radnik.Prezime;
            
            txtKolicina.Enabled = false;
            txtOpis.Enabled = false;
            dtpDatumStvaranja.Enabled = false;
            cmbStatus.Enabled = false;
            cmbKlijent.Enabled = false;
            cmbMaterijali.Enabled = false;
            txtNazivRobe.Enabled = false;
            txtKolicinaRobe.Enabled = false;

            btnDodajMaterijal.Enabled = false;
            btnGenerirajQRKod.Enabled = false;
            btnSpremi.Enabled = false;
            btnDodajRobuNaRadniNalog.Enabled = false;
            btnObrisiRobuSRadnogNaloga.Enabled = false;
            btnDodajNovuRobu.Enabled = false;

            txtKolicina.Text = radniNalog.Kolicina.ToString();
            txtOpis.Text = radniNalog.Opis;
            dtpDatumStvaranja.Value = radniNalog.DatumStvaranja;
            cmbStatus.Text = radniNalog.Status;
            cmbKlijent.SelectedItem = radniNalog.Klijent;

            dgvMaterijali.DataSource = radniNalog.Materijal.ToList();
            dgvRobaRadnogNaloga.DataSource = radniNalog.Roba.ToList();
            dgvKlijentovaRoba.DataSource = radniNalog.Klijent;

            UcitajMaterijale();
            UcitajKlijente();
            UcitajRobuRadnogNaloga();
            DodajMaterijalUTablicu();
            OdaberiKlijenta(radniNalog.Klijent_ID);
        }

        private void OdaberiKlijenta(int? klijent_ID)
        {
            for (int i = 0; i < cmbKlijent.Items.Count; i++)
            {
                Klijent klijent = cmbKlijent.Items[i] as Klijent;
                if(klijent.Klijent_ID == klijent_ID)
                {
                    cmbKlijent.SelectedIndex = i;
                    break;
                }
            }
        }

        private void UcitajKlijente()
        {
            KlijentServices klijentServices = new KlijentServices();
            var klijenti = klijentServices.DohvatiKlijente();
            cmbKlijent.DataSource = klijenti;
        }

        private void btnDodajRobuNaRadniNalog_Click(object sender, EventArgs e)
        {
            
        }

        private void UcitajRobuRadnogNaloga()
        {
            dgvRobaRadnogNaloga.Columns[3].Visible = false;
            dgvRobaRadnogNaloga.Columns[4].Visible = false;
            dgvRobaRadnogNaloga.Columns[5].Visible = false;
            dgvRobaRadnogNaloga.Columns[6].Visible = false;
        }

        private void btnObrisiRobuSRadnogNaloga_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDodajNovuRobu_Click(object sender, EventArgs e)
        {
            if (txtNazivRobe.Text == "" || txtKolicinaRobe.Text == "")
            {
                MessageBox.Show("Morate upisati naziv robe i količinu robe koju želite unijeti!");
            }
            else
            {
                Roba novaRoba = new Roba
                {
                    Naziv = txtNazivRobe.Text,
                    Kolicina = txtKolicinaRobe.Text,
                    Klijent_ID = odabraniKlijent.Klijent_ID
                };

                robaServis.Add(novaRoba);
            }

            UcitajRobu();
        }

        private void UcitajMaterijale()
        {
            MaterijalServices materijalServices = new MaterijalServices();
            var materijali = materijalServices.DohvatiMaterijale();
            cmbMaterijali.DataSource = materijali;
        }

        private void UcitajRobu()
        {
            List<Roba> listaRobe = robaServis.DohvatiRobuKlijenta(odabraniKlijent.Klijent_ID);
            dgvKlijentovaRoba.DataSource = listaRobe;
            dgvKlijentovaRoba.Columns[3].Visible = false;
            dgvKlijentovaRoba.Columns[4].Visible = false;
            dgvKlijentovaRoba.Columns[5].Visible = false;
            dgvKlijentovaRoba.Columns[6].Visible = false;
        }

        private void btnDodajMaterijal_Click(object sender, EventArgs e)
        {
            
        }

        private void DodajMaterijalUTablicu()
        {
            dgvMaterijali.Columns[8].Visible = false;
            dgvMaterijali.Columns[9].Visible = false;
            dgvMaterijali.Columns[10].Visible = false;
            dgvMaterijali.Columns[11].Visible = false;
            dgvMaterijali.Columns[12].Visible = false;
        }

        private void btnGenerirajQRKod_Click(object sender, EventArgs e)
        {
            QRKod = "";
            QRKod += "UkupnaKolicina(kg)=" + txtKolicina.Text + ";";

            foreach (var r in robaZaRadniNalog)
            {
                QRKod += "NazivRobe=" + r.Naziv + ";" + "KolicinaRobe=" + r.Kolicina + ";" + "KlijentID=" + r.Klijent_ID + ";";
            }

            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(QRKod, QRCodeGenerator.ECCLevel.Q); //generiranje QR koda
            var qrCode = new QRCode(qrCodeData); //stvaranje Bitmap objekta koji se koristi da bi se prikazala slika

            var qrCodeImage = qrCode.GetGraphic(3); //stvaranje slike QR koda
            pbQRKod.Image = qrCodeImage;
        }

        private void cmbKlijent_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabraniKlijent = cmbKlijent.SelectedItem as Klijent;
            UcitajRobu();
        }
    }
}
