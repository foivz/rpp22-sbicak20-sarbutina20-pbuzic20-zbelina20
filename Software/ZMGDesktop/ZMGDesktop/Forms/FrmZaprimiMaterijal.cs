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
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using iTextSharp.text.pdf;
using ZXing;
using System.Drawing.Imaging;

namespace ZMGDesktop
{
    public partial class FrmZaprimiMaterijal : Form
    {
        MaterijalServices matServis = new MaterijalServices();
        string provjereniQR;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice = null;


        public FrmZaprimiMaterijal()
        {
            InitializeComponent();
            ucitajPomoc();
        }

        private void FrmZaprimiMaterijal_Load(object sender, EventArgs e)
        {
            numKolicina.Visible = false;
            btnZaprimi.Visible = false;
            lblKolicina.Visible = false;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cboDevice.Items.Add(filterInfo.Name);
            }
            cboDevice.SelectedIndex = 0;

            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;

            var barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            var result = barcodeWriter.Write("T5JNVEU7YEJ7ORLKYO0U");
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string filePath = Path.Combine(desktopPath, "qrcode.png");

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                result.Save(stream, ImageFormat.Png);
            }
        }

        private void btnKreni_Click(object sender, EventArgs e)
        {
            
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picQR.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void ucitajPomoc()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        


        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SkenirajMaterijal(string skeniranQR)
        {


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
            string proba = "WNQDSCM90PALUKXBANUA";
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

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string path = Path.Combine(Application.StartupPath, "Pomoc\\Pomoc\\Skladiste\\ZaprimiMaterijal\\zaprimiMaterijal.html");
                System.Diagnostics.Process.Start(path);
            }
        }

        private void FrmZaprimiMaterijal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (captureDevice.IsRunning) captureDevice.Stop();
            }
            catch (Exception ex)
            {
                this.Close();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(picQR.Image!= null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)picQR.Image);
                if(result != null)
                {
                    SkenirajMaterijal(result.ToString());
                    timer1.Stop();
                    if (captureDevice.IsRunning) captureDevice.Stop();
                }
            }
        }
    }
}
