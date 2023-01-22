using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using ZMGDesktop.ValidacijaUnosa;
using HidLibrary;
using System.Threading;

namespace ZMGDesktop
{
    public partial class FrmZaprimiMaterijal : Form
    {
        HidDevice skener;
        MaterijalServices matServis = new MaterijalServices();
        string provjereniQR;
        private bool skeniranje = true;

        public FrmZaprimiMaterijal()
        {
            InitializeComponent();
            InitializeScanner();
        }

        private void InitializeScanner()
        {
            skeniranje = true;

            var devices = HidDevices.Enumerate();
           
            skener = devices.FirstOrDefault(d => d.Attributes.VendorId == 0x1234 && d.Attributes.ProductId == 0x5678);
            
            if (skener == null) return;

            skener.OpenDevice();
            
            Task.Run(() => ReadDataFromScanner());
        }

        private void ReadDataFromScanner()
        {
            while (skeniranje)
            {
                var report = skener.ReadReport();
                if (report != null)
                {
                    var podaci = Encoding.ASCII.GetString(report.Data);
                    SkenirajMaterijal(podaci);
                }
            }
        }


        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SkenirajMaterijal(string skeniranQR)
        {
            skeniranje = false;


            var uspjeh = matServis.ProvjeriQR(skeniranQR);
            if (!uspjeh) MessageBox.Show("Neuspješno skeniranje materijala");
            else
            {
                provjereniQR = skeniranQR;
                lblSkeniraj.Visible = false;
                numKolicina.Visible = true;
                btnZaprimi.Visible = true;
                lblKolicina.Visible = true;
            }

        }

        private void btnProba_Click(object sender, EventArgs e)
        {
            string proba = "QEDA24L588AHRU2MFEK7";
            SkenirajMaterijal(proba);
        }

        private void btnZaprimi_Click(object sender, EventArgs e)
        {
            int kolicina = (int)numKolicina.Value;
            var materijal = matServis.AzurirajMaterijal(provjereniQR, kolicina);
            if (materijal != null)
            {
                FrmPrimka primka = new FrmPrimka(materijal, kolicina);
                primka.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Neuspješno zaprimljen materijal");
            
        }

        private void FrmZaprimiMaterijal_Load(object sender, EventArgs e)
        {
            numKolicina.Visible = false;
            btnZaprimi.Visible = false;
            lblKolicina.Visible = false;
            provjereniQR = "";
        }
    }
}
