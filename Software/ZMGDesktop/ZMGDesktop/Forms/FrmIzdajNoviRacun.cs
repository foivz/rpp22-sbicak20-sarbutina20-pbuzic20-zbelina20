using BusinessLogicLayer.LogikaZaRacune;
using BusinessLogicLayer.PDF;
using BusinessLogicLayer.Services;
using Email;
using EntitiesLayer.Entities;
using EntitiesLayer.GlobalniObjekti;
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

namespace ZMGDesktop
{
    public partial class FrmIzdajNoviRacun : Form
    {
        //objekti
        Poslodavac poslodavac;
        Klijent selektiratiKlijent;
        Racun racun;
        Radnik radnik;
        // servisi
        KlijentServices klijentServis;
        PoslodavacServices poslodavacServis;
        RacunanjeAPI racunanjeAPI;
        RacunService racunServis;
        public FrmIzdajNoviRacun(Poslodavac _poslodavac, Radnik _radnik)
        {
            InitializeComponent();
            ucitajPomoc();
            klijentServis= new KlijentServices();
            poslodavacServis= new PoslodavacServices();
            racunanjeAPI= new RacunanjeAPI();
            racunServis= new RacunService();

            poslodavac = _poslodavac;
            radnik = _radnik;
            racun = new Racun();
        }

        private void ucitajPomoc()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }


        private void FrmIzdajNoviRacun_Load(object sender, EventArgs e)
        {
            poslodavac = poslodavacServis.GetPoslodavac();
            cmbKlijenti.DataSource = klijentServis.DohvatiKlijente();
            InitTextBoxPoslodavac(poslodavac);
            txtNacinPlacanja.Text = "(T) Transakcijski račun";
            txtRokPlacanja.Text = "do 15 dana";
            txtUkupniIznos.Text = "0";
            txtUkupno.Text = "0";
            txtPDV.Text = "0";

            racun.Radnik = radnik;
        }

        private void cmbKlijenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            selektiratiKlijent = cmbKlijenti.SelectedItem as Klijent;
            InitTextBoxKlijent(selektiratiKlijent);
            GlobalListaStavki.stavkaRacunaList.Clear();
            Osvjezi();
            
        }


        // inicijalizacija textboxova
        private void InitTextBoxKlijent(Klijent klijent)
        {
            txtK_Adresa.Text = klijent.Adresa;
            txtK_Naziv.Text = klijent.Naziv;
            txtK_OIB.Text = klijent.OIB;
            txtK_Email.Text = klijent.Email;

            racun.Klijent = klijent;
        }


        private void InitTextBoxPoslodavac(Poslodavac poslodavac)
        {
            txtP_BrObrtnice.Text = poslodavac.BrojObrtnice;
            txtP_Banka.Text = poslodavac.Banka;
            txtP_BrojMobitela.Text = poslodavac.BrojTelefona;
            txtP_Drzava.Text = poslodavac.Drzava;
            txtP_Mjesto.Text = poslodavac.Mjesto;
            txtP_Ulica.Text = poslodavac.Adresa;
            txtP_TELFAX.Text = poslodavac.TEL_FAX;
            txtP_ObrtniRegistar.Text = poslodavac.UpisObrtniRegistar;
            txtP_Poslovnica.Text = poslodavac.Poslovnica;
            txtP_Naziv.Text = poslodavac.Naziv;
            txtP_IBAN.Text = poslodavac.IBAN;
            txtP_OIB.Text = poslodavac.OIB;

            racun.Poslodavac = poslodavac;
        }

        private void btnDodajStavke_Click(object sender, EventArgs e)
        {
            FrmDodajStavke formaStavki = new FrmDodajStavke(selektiratiKlijent, racun);
            formaStavki.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            formaStavki.ShowDialog();
        }

        double ukupno, pdv, ukupnoiznos;

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            Osvjezi();

            ukupno = racunanjeAPI.RacunanjeUkupnog(GlobalListaStavki.stavkaRacunaList);
            pdv = racunanjeAPI.RacunanjePDV(ukupno);
            ukupnoiznos = racunanjeAPI.RacunanjeUkupnogPDV(ukupno, pdv);

            txtUkupno.Text = ukupno.ToString();
            txtPDV.Text = pdv.ToString();
            txtUkupniIznos.Text = ukupnoiznos.ToString();

            racun.UkupnaCijena = ukupnoiznos;
            racun.PDV = pdv;
            racun.UkupnoStavke = ukupno;
        }

        private void Poruka()
        {
            string from = $"{poslodavac.Email}";
            string to = $"{selektiratiKlijent.Email}";
            string subject = $"Račun {DateTime.Now}";
            string text = "Poštovani,<br> u prilogu se nalazi račun. Izdan je u elektroničnom obliku te valja bez potpisa.";
            EmailAPI.NapraviEmail(from, to, subject, text);
        }

        private async void btnIzdajRacun_Click(object sender, EventArgs e)
        {
            var izdajRacun = Task.Run(() => IzdajRacunAsync());
            await izdajRacun;
            if (izdajRacun.Result == true)
            {
                Dispose();
            }
        }

        private async Task<bool> IzdajRacunAsync()
        {
            if (GlobalListaStavki.stavkaRacunaList.Count != 0)
            {
                if (chkAutoEmail.Checked == true)
                {
                    InitRacun(racun);
                    racunServis.DodajRacun(racun);
                    racun = racunServis.DohvatiZadnjiRacun();
                    Poruka();
                    GeneriranjePDF.SacuvajPDF(racun, GlobalListaStavki.stavkaRacunaList);
                    EmailAPI.DodajPrilog(GeneriranjePDF.nazivDatoteke);
                    EmailAPI.Posalji();
                    MessageBox.Show($"Uspješno ste izdali račun i poslali klijentu na mail ({selektiratiKlijent.Email})", "Izdavanje računa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    InitRacun(racun);
                    racunServis.DodajRacun(racun);
                    MessageBox.Show("Uspješno ste izdali račun.", "Izdavanje računa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Morate imati barem jednu stavku.", "Izdavanje računa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPDFpregled_Click(object sender, EventArgs e)
        {
            GeneriranjePDF.SacuvajPDF(racun, GlobalListaStavki.stavkaRacunaList);
            GeneriranjePDF.OtvoriPDF();
        }

        private void Osvjezi()
        {
            dgvStavke.DataSource = null;
            dgvStavke.DataSource = GlobalListaStavki.stavkaRacunaList;
            dgvStavke.Columns[0].Visible = false;
            dgvStavke.Columns[1].Visible = false;
            dgvStavke.Columns[2].Visible = false;
            dgvStavke.Columns[9].Visible = false;
        }

        private void InitRacun(Racun racun)
        {
            racun.NacinPlacanja = txtNacinPlacanja.Text;
            racun.RokPlacanja = txtRokPlacanja.Text;
            racun.StavkaRacun = GlobalListaStavki.stavkaRacunaList;
            racun.Fakturirao = "TEST";
            racun.Poslodavac = poslodavac;
            racun.DatumIzdavanja = DateTime.Now;
            racun.Klijent = selektiratiKlijent;
            racun.Klijent_ID = selektiratiKlijent.Klijent_ID;
            racun.Poslodavac_ID = poslodavac.Poslodavac_ID;
            racun.Opis = "OPIS";
            racun.UkupnaCijena = ukupnoiznos;
            racun.PDV = pdv;
            racun.UkupnoStavke = ukupno;
            racun.Radnik= radnik;
            racun.Radnik_ID = radnik.Radnik_ID;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string path = Path.Combine(Application.StartupPath, "..\\..\\Pomoc\\Racuni\\DodajRacun\\dodajRacun.html");
                System.Diagnostics.Process.Start(path);
            }
        }
    }
}
