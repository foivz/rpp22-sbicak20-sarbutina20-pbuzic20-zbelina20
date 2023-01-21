using BusinessLogicLayer.Services;
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
using System.Windows.Media.Animation;

namespace ZMGDesktop
{
    public partial class FrmZaprimiMaterijal : Form
    {
        MaterijalServices matServis = new MaterijalServices();
        string provjereniQR;
        public FrmZaprimiMaterijal()
        {
            InitializeComponent();

        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SkenirajMaterijal(string skeniranQR)
        {
            /*QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(skeniranQR, QRCodeGenerator.ECCLevel.L);
            Base64QRCode qrKod = new Base64QRCode(qrCodeData);
            string decodedString = qrKod.GetGraphic(20);
            string naziv = decodedString;
            int kolicina = int.Parse(parts[1]);*/


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
            var uspjeh = matServis.AzurirajMaterijal(provjereniQR, kolicina);
            if (uspjeh) this.Close();
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
