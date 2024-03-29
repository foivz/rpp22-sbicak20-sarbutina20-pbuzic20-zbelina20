﻿namespace ZMGDesktop
{
    partial class FrmDetaljniPregledRacun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.labelObrtniRegistar = new System.Windows.Forms.Label();
            this.labelBrojObrtnice = new System.Windows.Forms.Label();
            this.labelOIB = new System.Windows.Forms.Label();
            this.labelPoslovnica = new System.Windows.Forms.Label();
            this.labelUlica = new System.Windows.Forms.Label();
            this.txtP_ObrtniRegistar = new System.Windows.Forms.TextBox();
            this.txtP_BrObrtnice = new System.Windows.Forms.TextBox();
            this.txtP_OIB = new System.Windows.Forms.TextBox();
            this.txtP_Poslovnica = new System.Windows.Forms.TextBox();
            this.txtP_Ulica = new System.Windows.Forms.TextBox();
            this.labelNazivKlijenta = new System.Windows.Forms.Label();
            this.labelAdresaKlijenta = new System.Windows.Forms.Label();
            this.labelOIBKlijenta = new System.Windows.Forms.Label();
            this.txtK_Naziv = new System.Windows.Forms.TextBox();
            this.txtK_Adresa = new System.Windows.Forms.TextBox();
            this.txtK_OIB = new System.Windows.Forms.TextBox();
            this.txtNacinPlacanja = new System.Windows.Forms.TextBox();
            this.labelNacinPlacanja = new System.Windows.Forms.Label();
            this.txtRokPlacanja = new System.Windows.Forms.TextBox();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.txtPDV = new System.Windows.Forms.TextBox();
            this.txtUkupniIznos = new System.Windows.Forms.TextBox();
            this.labelMjesto = new System.Windows.Forms.Label();
            this.txtP_Mjesto = new System.Windows.Forms.TextBox();
            this.txtP_Drzava = new System.Windows.Forms.TextBox();
            this.labelDrzava = new System.Windows.Forms.Label();
            this.labelBanka = new System.Windows.Forms.Label();
            this.txtP_Banka = new System.Windows.Forms.TextBox();
            this.labelIBAN = new System.Windows.Forms.Label();
            this.txtP_IBAN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.txtP_Naziv = new System.Windows.Forms.TextBox();
            this.txtP_BrojMobitela = new System.Windows.Forms.TextBox();
            this.labelBrojMobitela = new System.Windows.Forms.Label();
            this.txtP_TELFAX = new System.Windows.Forms.TextBox();
            this.labelTelFax = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtK_TEL = new System.Windows.Forms.TextBox();
            this.labelTelKlijent = new System.Windows.Forms.Label();
            this.txtK_IBAN = new System.Windows.Forms.TextBox();
            this.labelIBANKlijenta = new System.Windows.Forms.Label();
            this.txtK_Email = new System.Windows.Forms.TextBox();
            this.labelKIme = new System.Windows.Forms.Label();
            this.txtK_Mjesto = new System.Windows.Forms.TextBox();
            this.labelMjestoKlijenta = new System.Windows.Forms.Label();
            this.labelRokPlacanja = new System.Windows.Forms.Label();
            this.labelUkupno = new System.Windows.Forms.Label();
            this.labelUkupniIznos = new System.Windows.Forms.Label();
            this.labelPDV = new System.Windows.Forms.Label();
            this.labelRacunBroj = new System.Windows.Forms.Label();
            this.lblBrojRacuna = new System.Windows.Forms.Label();
            this.txtDatumIzdavanja = new System.Windows.Forms.TextBox();
            this.labelDatumIzdavanja = new System.Windows.Forms.Label();
            this.txtVrijeme = new System.Windows.Forms.TextBox();
            this.labelVrijeme = new System.Windows.Forms.Label();
            this.txtFakturirao = new System.Windows.Forms.TextBox();
            this.labelFakturirao = new System.Windows.Forms.Label();
            this.btnPDFpregled = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStavke
            // 
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(241, 404);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.Size = new System.Drawing.Size(841, 196);
            this.dgvStavke.TabIndex = 3;
            // 
            // labelObrtniRegistar
            // 
            this.labelObrtniRegistar.AutoSize = true;
            this.labelObrtniRegistar.Location = new System.Drawing.Point(17, 43);
            this.labelObrtniRegistar.Name = "labelObrtniRegistar";
            this.labelObrtniRegistar.Size = new System.Drawing.Size(106, 13);
            this.labelObrtniRegistar.TabIndex = 6;
            this.labelObrtniRegistar.Text = "Upis u obrtni registar:";
            // 
            // labelBrojObrtnice
            // 
            this.labelBrojObrtnice.AutoSize = true;
            this.labelBrojObrtnice.Location = new System.Drawing.Point(42, 70);
            this.labelBrojObrtnice.Name = "labelBrojObrtnice";
            this.labelBrojObrtnice.Size = new System.Drawing.Size(81, 13);
            this.labelBrojObrtnice.TabIndex = 7;
            this.labelBrojObrtnice.Text = "Br. OBRTNICE:";
            // 
            // labelOIB
            // 
            this.labelOIB.AutoSize = true;
            this.labelOIB.Location = new System.Drawing.Point(98, 96);
            this.labelOIB.Name = "labelOIB";
            this.labelOIB.Size = new System.Drawing.Size(28, 13);
            this.labelOIB.TabIndex = 8;
            this.labelOIB.Text = "OIB:";
            // 
            // labelPoslovnica
            // 
            this.labelPoslovnica.AutoSize = true;
            this.labelPoslovnica.Location = new System.Drawing.Point(64, 125);
            this.labelPoslovnica.Name = "labelPoslovnica";
            this.labelPoslovnica.Size = new System.Drawing.Size(62, 13);
            this.labelPoslovnica.TabIndex = 9;
            this.labelPoslovnica.Text = "Poslovnica:";
            // 
            // labelUlica
            // 
            this.labelUlica.AutoSize = true;
            this.labelUlica.Location = new System.Drawing.Point(85, 151);
            this.labelUlica.Name = "labelUlica";
            this.labelUlica.Size = new System.Drawing.Size(34, 13);
            this.labelUlica.TabIndex = 11;
            this.labelUlica.Text = "Ulica:";
            // 
            // txtP_ObrtniRegistar
            // 
            this.txtP_ObrtniRegistar.Location = new System.Drawing.Point(129, 40);
            this.txtP_ObrtniRegistar.Name = "txtP_ObrtniRegistar";
            this.txtP_ObrtniRegistar.ReadOnly = true;
            this.txtP_ObrtniRegistar.Size = new System.Drawing.Size(260, 20);
            this.txtP_ObrtniRegistar.TabIndex = 12;
            // 
            // txtP_BrObrtnice
            // 
            this.txtP_BrObrtnice.Location = new System.Drawing.Point(129, 67);
            this.txtP_BrObrtnice.Name = "txtP_BrObrtnice";
            this.txtP_BrObrtnice.ReadOnly = true;
            this.txtP_BrObrtnice.Size = new System.Drawing.Size(260, 20);
            this.txtP_BrObrtnice.TabIndex = 13;
            // 
            // txtP_OIB
            // 
            this.txtP_OIB.Location = new System.Drawing.Point(129, 93);
            this.txtP_OIB.Name = "txtP_OIB";
            this.txtP_OIB.ReadOnly = true;
            this.txtP_OIB.Size = new System.Drawing.Size(260, 20);
            this.txtP_OIB.TabIndex = 14;
            // 
            // txtP_Poslovnica
            // 
            this.txtP_Poslovnica.Location = new System.Drawing.Point(129, 122);
            this.txtP_Poslovnica.Name = "txtP_Poslovnica";
            this.txtP_Poslovnica.ReadOnly = true;
            this.txtP_Poslovnica.Size = new System.Drawing.Size(260, 20);
            this.txtP_Poslovnica.TabIndex = 15;
            // 
            // txtP_Ulica
            // 
            this.txtP_Ulica.Location = new System.Drawing.Point(129, 148);
            this.txtP_Ulica.Name = "txtP_Ulica";
            this.txtP_Ulica.ReadOnly = true;
            this.txtP_Ulica.Size = new System.Drawing.Size(260, 20);
            this.txtP_Ulica.TabIndex = 16;
            // 
            // labelNazivKlijenta
            // 
            this.labelNazivKlijenta.AutoSize = true;
            this.labelNazivKlijenta.Location = new System.Drawing.Point(17, 31);
            this.labelNazivKlijenta.Name = "labelNazivKlijenta";
            this.labelNazivKlijenta.Size = new System.Drawing.Size(37, 13);
            this.labelNazivKlijenta.TabIndex = 18;
            this.labelNazivKlijenta.Text = "Naziv:";
            // 
            // labelAdresaKlijenta
            // 
            this.labelAdresaKlijenta.AutoSize = true;
            this.labelAdresaKlijenta.Location = new System.Drawing.Point(11, 57);
            this.labelAdresaKlijenta.Name = "labelAdresaKlijenta";
            this.labelAdresaKlijenta.Size = new System.Drawing.Size(43, 13);
            this.labelAdresaKlijenta.TabIndex = 19;
            this.labelAdresaKlijenta.Text = "Adresa:";
            // 
            // labelOIBKlijenta
            // 
            this.labelOIBKlijenta.AutoSize = true;
            this.labelOIBKlijenta.Location = new System.Drawing.Point(26, 108);
            this.labelOIBKlijenta.Name = "labelOIBKlijenta";
            this.labelOIBKlijenta.Size = new System.Drawing.Size(28, 13);
            this.labelOIBKlijenta.TabIndex = 20;
            this.labelOIBKlijenta.Text = "OIB:";
            // 
            // txtK_Naziv
            // 
            this.txtK_Naziv.Location = new System.Drawing.Point(60, 28);
            this.txtK_Naziv.Name = "txtK_Naziv";
            this.txtK_Naziv.ReadOnly = true;
            this.txtK_Naziv.Size = new System.Drawing.Size(179, 20);
            this.txtK_Naziv.TabIndex = 23;
            // 
            // txtK_Adresa
            // 
            this.txtK_Adresa.Location = new System.Drawing.Point(60, 54);
            this.txtK_Adresa.Name = "txtK_Adresa";
            this.txtK_Adresa.ReadOnly = true;
            this.txtK_Adresa.Size = new System.Drawing.Size(179, 20);
            this.txtK_Adresa.TabIndex = 24;
            // 
            // txtK_OIB
            // 
            this.txtK_OIB.Location = new System.Drawing.Point(60, 105);
            this.txtK_OIB.Name = "txtK_OIB";
            this.txtK_OIB.ReadOnly = true;
            this.txtK_OIB.Size = new System.Drawing.Size(179, 20);
            this.txtK_OIB.TabIndex = 25;
            // 
            // txtNacinPlacanja
            // 
            this.txtNacinPlacanja.Location = new System.Drawing.Point(325, 613);
            this.txtNacinPlacanja.Name = "txtNacinPlacanja";
            this.txtNacinPlacanja.ReadOnly = true;
            this.txtNacinPlacanja.Size = new System.Drawing.Size(179, 20);
            this.txtNacinPlacanja.TabIndex = 28;
            // 
            // labelNacinPlacanja
            // 
            this.labelNacinPlacanja.AutoSize = true;
            this.labelNacinPlacanja.Location = new System.Drawing.Point(238, 616);
            this.labelNacinPlacanja.Name = "labelNacinPlacanja";
            this.labelNacinPlacanja.Size = new System.Drawing.Size(81, 13);
            this.labelNacinPlacanja.TabIndex = 29;
            this.labelNacinPlacanja.Text = "Način plaćanja:";
            // 
            // txtRokPlacanja
            // 
            this.txtRokPlacanja.Location = new System.Drawing.Point(325, 639);
            this.txtRokPlacanja.Name = "txtRokPlacanja";
            this.txtRokPlacanja.ReadOnly = true;
            this.txtRokPlacanja.Size = new System.Drawing.Size(179, 20);
            this.txtRokPlacanja.TabIndex = 30;
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(903, 613);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.ReadOnly = true;
            this.txtUkupno.Size = new System.Drawing.Size(179, 20);
            this.txtUkupno.TabIndex = 31;
            // 
            // txtPDV
            // 
            this.txtPDV.Location = new System.Drawing.Point(903, 639);
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.ReadOnly = true;
            this.txtPDV.Size = new System.Drawing.Size(179, 20);
            this.txtPDV.TabIndex = 32;
            // 
            // txtUkupniIznos
            // 
            this.txtUkupniIznos.Location = new System.Drawing.Point(903, 665);
            this.txtUkupniIznos.Name = "txtUkupniIznos";
            this.txtUkupniIznos.ReadOnly = true;
            this.txtUkupniIznos.Size = new System.Drawing.Size(179, 20);
            this.txtUkupniIznos.TabIndex = 33;
            // 
            // labelMjesto
            // 
            this.labelMjesto.AutoSize = true;
            this.labelMjesto.Location = new System.Drawing.Point(85, 180);
            this.labelMjesto.Name = "labelMjesto";
            this.labelMjesto.Size = new System.Drawing.Size(41, 13);
            this.labelMjesto.TabIndex = 34;
            this.labelMjesto.Text = "Mjesto:";
            // 
            // txtP_Mjesto
            // 
            this.txtP_Mjesto.Location = new System.Drawing.Point(129, 177);
            this.txtP_Mjesto.Name = "txtP_Mjesto";
            this.txtP_Mjesto.ReadOnly = true;
            this.txtP_Mjesto.Size = new System.Drawing.Size(260, 20);
            this.txtP_Mjesto.TabIndex = 35;
            // 
            // txtP_Drzava
            // 
            this.txtP_Drzava.Location = new System.Drawing.Point(129, 205);
            this.txtP_Drzava.Name = "txtP_Drzava";
            this.txtP_Drzava.ReadOnly = true;
            this.txtP_Drzava.Size = new System.Drawing.Size(260, 20);
            this.txtP_Drzava.TabIndex = 36;
            // 
            // labelDrzava
            // 
            this.labelDrzava.AutoSize = true;
            this.labelDrzava.Location = new System.Drawing.Point(85, 206);
            this.labelDrzava.Name = "labelDrzava";
            this.labelDrzava.Size = new System.Drawing.Size(44, 13);
            this.labelDrzava.TabIndex = 37;
            this.labelDrzava.Text = "Država:";
            // 
            // labelBanka
            // 
            this.labelBanka.AutoSize = true;
            this.labelBanka.Location = new System.Drawing.Point(85, 238);
            this.labelBanka.Name = "labelBanka";
            this.labelBanka.Size = new System.Drawing.Size(41, 13);
            this.labelBanka.TabIndex = 38;
            this.labelBanka.Text = "Banka:";
            // 
            // txtP_Banka
            // 
            this.txtP_Banka.Location = new System.Drawing.Point(129, 235);
            this.txtP_Banka.Name = "txtP_Banka";
            this.txtP_Banka.ReadOnly = true;
            this.txtP_Banka.Size = new System.Drawing.Size(260, 20);
            this.txtP_Banka.TabIndex = 39;
            // 
            // labelIBAN
            // 
            this.labelIBAN.AutoSize = true;
            this.labelIBAN.Location = new System.Drawing.Point(88, 263);
            this.labelIBAN.Name = "labelIBAN";
            this.labelIBAN.Size = new System.Drawing.Size(35, 13);
            this.labelIBAN.TabIndex = 40;
            this.labelIBAN.Text = "IBAN:";
            // 
            // txtP_IBAN
            // 
            this.txtP_IBAN.Location = new System.Drawing.Point(129, 263);
            this.txtP_IBAN.Name = "txtP_IBAN";
            this.txtP_IBAN.ReadOnly = true;
            this.txtP_IBAN.Size = new System.Drawing.Size(260, 20);
            this.txtP_IBAN.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNaziv);
            this.groupBox1.Controls.Add(this.txtP_Naziv);
            this.groupBox1.Controls.Add(this.txtP_BrojMobitela);
            this.groupBox1.Controls.Add(this.labelBrojMobitela);
            this.groupBox1.Controls.Add(this.txtP_TELFAX);
            this.groupBox1.Controls.Add(this.labelTelFax);
            this.groupBox1.Controls.Add(this.txtP_Banka);
            this.groupBox1.Controls.Add(this.txtP_IBAN);
            this.groupBox1.Controls.Add(this.labelObrtniRegistar);
            this.groupBox1.Controls.Add(this.labelIBAN);
            this.groupBox1.Controls.Add(this.labelBrojObrtnice);
            this.groupBox1.Controls.Add(this.labelOIB);
            this.groupBox1.Controls.Add(this.labelBanka);
            this.groupBox1.Controls.Add(this.labelPoslovnica);
            this.groupBox1.Controls.Add(this.labelDrzava);
            this.groupBox1.Controls.Add(this.labelUlica);
            this.groupBox1.Controls.Add(this.txtP_Drzava);
            this.groupBox1.Controls.Add(this.txtP_ObrtniRegistar);
            this.groupBox1.Controls.Add(this.txtP_Mjesto);
            this.groupBox1.Controls.Add(this.txtP_BrObrtnice);
            this.groupBox1.Controls.Add(this.labelMjesto);
            this.groupBox1.Controls.Add(this.txtP_OIB);
            this.groupBox1.Controls.Add(this.txtP_Poslovnica);
            this.groupBox1.Controls.Add(this.txtP_Ulica);
            this.groupBox1.Location = new System.Drawing.Point(241, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 352);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Poslodavac";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(86, 17);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNaziv.Size = new System.Drawing.Size(37, 13);
            this.labelNaziv.TabIndex = 46;
            this.labelNaziv.Text = "Naziv:";
            // 
            // txtP_Naziv
            // 
            this.txtP_Naziv.Location = new System.Drawing.Point(129, 14);
            this.txtP_Naziv.Name = "txtP_Naziv";
            this.txtP_Naziv.ReadOnly = true;
            this.txtP_Naziv.Size = new System.Drawing.Size(260, 20);
            this.txtP_Naziv.TabIndex = 47;
            // 
            // txtP_BrojMobitela
            // 
            this.txtP_BrojMobitela.Location = new System.Drawing.Point(129, 318);
            this.txtP_BrojMobitela.Name = "txtP_BrojMobitela";
            this.txtP_BrojMobitela.ReadOnly = true;
            this.txtP_BrojMobitela.Size = new System.Drawing.Size(260, 20);
            this.txtP_BrojMobitela.TabIndex = 45;
            // 
            // labelBrojMobitela
            // 
            this.labelBrojMobitela.AutoSize = true;
            this.labelBrojMobitela.Location = new System.Drawing.Point(53, 321);
            this.labelBrojMobitela.Name = "labelBrojMobitela";
            this.labelBrojMobitela.Size = new System.Drawing.Size(70, 13);
            this.labelBrojMobitela.TabIndex = 44;
            this.labelBrojMobitela.Text = "Broj mobitela:";
            // 
            // txtP_TELFAX
            // 
            this.txtP_TELFAX.Location = new System.Drawing.Point(129, 290);
            this.txtP_TELFAX.Name = "txtP_TELFAX";
            this.txtP_TELFAX.ReadOnly = true;
            this.txtP_TELFAX.Size = new System.Drawing.Size(260, 20);
            this.txtP_TELFAX.TabIndex = 43;
            // 
            // labelTelFax
            // 
            this.labelTelFax.AutoSize = true;
            this.labelTelFax.Location = new System.Drawing.Point(68, 293);
            this.labelTelFax.Name = "labelTelFax";
            this.labelTelFax.Size = new System.Drawing.Size(55, 13);
            this.labelTelFax.TabIndex = 42;
            this.labelTelFax.Text = "TEL/FAX:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtK_TEL);
            this.groupBox2.Controls.Add(this.labelTelKlijent);
            this.groupBox2.Controls.Add(this.txtK_IBAN);
            this.groupBox2.Controls.Add(this.labelIBANKlijenta);
            this.groupBox2.Controls.Add(this.txtK_Email);
            this.groupBox2.Controls.Add(this.labelKIme);
            this.groupBox2.Controls.Add(this.txtK_Mjesto);
            this.groupBox2.Controls.Add(this.labelMjestoKlijenta);
            this.groupBox2.Controls.Add(this.txtK_Naziv);
            this.groupBox2.Controls.Add(this.labelNazivKlijenta);
            this.groupBox2.Controls.Add(this.labelAdresaKlijenta);
            this.groupBox2.Controls.Add(this.labelOIBKlijenta);
            this.groupBox2.Controls.Add(this.txtK_Adresa);
            this.groupBox2.Controls.Add(this.txtK_OIB);
            this.groupBox2.Location = new System.Drawing.Point(815, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 217);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Klijent";
            // 
            // txtK_TEL
            // 
            this.txtK_TEL.Location = new System.Drawing.Point(60, 183);
            this.txtK_TEL.Name = "txtK_TEL";
            this.txtK_TEL.ReadOnly = true;
            this.txtK_TEL.Size = new System.Drawing.Size(179, 20);
            this.txtK_TEL.TabIndex = 55;
            // 
            // labelTelKlijent
            // 
            this.labelTelKlijent.AutoSize = true;
            this.labelTelKlijent.Location = new System.Drawing.Point(22, 186);
            this.labelTelKlijent.Name = "labelTelKlijent";
            this.labelTelKlijent.Size = new System.Drawing.Size(30, 13);
            this.labelTelKlijent.TabIndex = 54;
            this.labelTelKlijent.Text = "TEL:";
            // 
            // txtK_IBAN
            // 
            this.txtK_IBAN.Location = new System.Drawing.Point(60, 157);
            this.txtK_IBAN.Name = "txtK_IBAN";
            this.txtK_IBAN.ReadOnly = true;
            this.txtK_IBAN.Size = new System.Drawing.Size(179, 20);
            this.txtK_IBAN.TabIndex = 31;
            // 
            // labelIBANKlijenta
            // 
            this.labelIBANKlijenta.AutoSize = true;
            this.labelIBANKlijenta.Location = new System.Drawing.Point(19, 160);
            this.labelIBANKlijenta.Name = "labelIBANKlijenta";
            this.labelIBANKlijenta.Size = new System.Drawing.Size(35, 13);
            this.labelIBANKlijenta.TabIndex = 30;
            this.labelIBANKlijenta.Text = "IBAN:";
            // 
            // txtK_Email
            // 
            this.txtK_Email.Location = new System.Drawing.Point(60, 131);
            this.txtK_Email.Name = "txtK_Email";
            this.txtK_Email.ReadOnly = true;
            this.txtK_Email.Size = new System.Drawing.Size(179, 20);
            this.txtK_Email.TabIndex = 29;
            // 
            // labelKIme
            // 
            this.labelKIme.AutoSize = true;
            this.labelKIme.Location = new System.Drawing.Point(19, 134);
            this.labelKIme.Name = "labelKIme";
            this.labelKIme.Size = new System.Drawing.Size(35, 13);
            this.labelKIme.TabIndex = 28;
            this.labelKIme.Text = "Email:";
            // 
            // txtK_Mjesto
            // 
            this.txtK_Mjesto.Location = new System.Drawing.Point(60, 80);
            this.txtK_Mjesto.Name = "txtK_Mjesto";
            this.txtK_Mjesto.ReadOnly = true;
            this.txtK_Mjesto.Size = new System.Drawing.Size(179, 20);
            this.txtK_Mjesto.TabIndex = 27;
            // 
            // labelMjestoKlijenta
            // 
            this.labelMjestoKlijenta.AutoSize = true;
            this.labelMjestoKlijenta.Location = new System.Drawing.Point(11, 83);
            this.labelMjestoKlijenta.Name = "labelMjestoKlijenta";
            this.labelMjestoKlijenta.Size = new System.Drawing.Size(41, 13);
            this.labelMjestoKlijenta.TabIndex = 26;
            this.labelMjestoKlijenta.Text = "Mjesto:";
            // 
            // labelRokPlacanja
            // 
            this.labelRokPlacanja.AutoSize = true;
            this.labelRokPlacanja.Location = new System.Drawing.Point(246, 639);
            this.labelRokPlacanja.Name = "labelRokPlacanja";
            this.labelRokPlacanja.Size = new System.Drawing.Size(73, 13);
            this.labelRokPlacanja.TabIndex = 44;
            this.labelRokPlacanja.Text = "Rok plaćanja:";
            // 
            // labelUkupno
            // 
            this.labelUkupno.AutoSize = true;
            this.labelUkupno.Location = new System.Drawing.Point(849, 616);
            this.labelUkupno.Name = "labelUkupno";
            this.labelUkupno.Size = new System.Drawing.Size(48, 13);
            this.labelUkupno.TabIndex = 45;
            this.labelUkupno.Text = "Ukupno:";
            // 
            // labelUkupniIznos
            // 
            this.labelUkupniIznos.AutoSize = true;
            this.labelUkupniIznos.Location = new System.Drawing.Point(826, 668);
            this.labelUkupniIznos.Name = "labelUkupniIznos";
            this.labelUkupniIznos.Size = new System.Drawing.Size(71, 13);
            this.labelUkupniIznos.TabIndex = 46;
            this.labelUkupniIznos.Text = "Ukupni iznos:";
            // 
            // labelPDV
            // 
            this.labelPDV.AutoSize = true;
            this.labelPDV.Location = new System.Drawing.Point(842, 642);
            this.labelPDV.Name = "labelPDV";
            this.labelPDV.Size = new System.Drawing.Size(55, 13);
            this.labelPDV.TabIndex = 47;
            this.labelPDV.Text = "PDV 25%:";
            // 
            // labelRacunBroj
            // 
            this.labelRacunBroj.AutoSize = true;
            this.labelRacunBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRacunBroj.Location = new System.Drawing.Point(808, 44);
            this.labelRacunBroj.Name = "labelRacunBroj";
            this.labelRacunBroj.Size = new System.Drawing.Size(181, 37);
            this.labelRacunBroj.TabIndex = 48;
            this.labelRacunBroj.Text = "Račun broj:";
            // 
            // lblBrojRacuna
            // 
            this.lblBrojRacuna.AutoSize = true;
            this.lblBrojRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojRacuna.Location = new System.Drawing.Point(995, 44);
            this.lblBrojRacuna.Name = "lblBrojRacuna";
            this.lblBrojRacuna.Size = new System.Drawing.Size(62, 37);
            this.lblBrojRacuna.TabIndex = 49;
            this.lblBrojRacuna.Text = "xxx";
            // 
            // txtDatumIzdavanja
            // 
            this.txtDatumIzdavanja.Location = new System.Drawing.Point(875, 339);
            this.txtDatumIzdavanja.Name = "txtDatumIzdavanja";
            this.txtDatumIzdavanja.ReadOnly = true;
            this.txtDatumIzdavanja.Size = new System.Drawing.Size(179, 20);
            this.txtDatumIzdavanja.TabIndex = 33;
            // 
            // labelDatumIzdavanja
            // 
            this.labelDatumIzdavanja.AutoSize = true;
            this.labelDatumIzdavanja.Location = new System.Drawing.Point(781, 342);
            this.labelDatumIzdavanja.Name = "labelDatumIzdavanja";
            this.labelDatumIzdavanja.Size = new System.Drawing.Size(89, 13);
            this.labelDatumIzdavanja.TabIndex = 32;
            this.labelDatumIzdavanja.Text = "Datum izdavanja:";
            // 
            // txtVrijeme
            // 
            this.txtVrijeme.Location = new System.Drawing.Point(875, 365);
            this.txtVrijeme.Name = "txtVrijeme";
            this.txtVrijeme.ReadOnly = true;
            this.txtVrijeme.Size = new System.Drawing.Size(179, 20);
            this.txtVrijeme.TabIndex = 51;
            // 
            // labelVrijeme
            // 
            this.labelVrijeme.AutoSize = true;
            this.labelVrijeme.Location = new System.Drawing.Point(823, 365);
            this.labelVrijeme.Name = "labelVrijeme";
            this.labelVrijeme.Size = new System.Drawing.Size(44, 13);
            this.labelVrijeme.TabIndex = 50;
            this.labelVrijeme.Text = "Vrijeme:";
            // 
            // txtFakturirao
            // 
            this.txtFakturirao.Location = new System.Drawing.Point(325, 668);
            this.txtFakturirao.Name = "txtFakturirao";
            this.txtFakturirao.ReadOnly = true;
            this.txtFakturirao.Size = new System.Drawing.Size(179, 20);
            this.txtFakturirao.TabIndex = 53;
            // 
            // labelFakturirao
            // 
            this.labelFakturirao.AutoSize = true;
            this.labelFakturirao.Location = new System.Drawing.Point(265, 668);
            this.labelFakturirao.Name = "labelFakturirao";
            this.labelFakturirao.Size = new System.Drawing.Size(57, 13);
            this.labelFakturirao.TabIndex = 52;
            this.labelFakturirao.Text = "Fakturirao:";
            // 
            // btnPDFpregled
            // 
            this.btnPDFpregled.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPDFpregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPDFpregled.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPDFpregled.Location = new System.Drawing.Point(241, 725);
            this.btnPDFpregled.Name = "btnPDFpregled";
            this.btnPDFpregled.Size = new System.Drawing.Size(147, 40);
            this.btnPDFpregled.TabIndex = 54;
            this.btnPDFpregled.Text = "Pregled PDF-a";
            this.btnPDFpregled.UseVisualStyleBackColor = false;
            this.btnPDFpregled.Click += new System.EventHandler(this.btnPDFpregled_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(70, 451);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.ReadOnly = true;
            this.txtOpis.Size = new System.Drawing.Size(155, 76);
            this.txtOpis.TabIndex = 57;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(72, 436);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(31, 13);
            this.label28.TabIndex = 56;
            this.label28.Text = "Opis:";
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNatrag.Location = new System.Drawing.Point(935, 725);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(147, 40);
            this.btnNatrag.TabIndex = 58;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // FrmDetaljniPregledRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 778);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.btnPDFpregled);
            this.Controls.Add(this.txtFakturirao);
            this.Controls.Add(this.labelFakturirao);
            this.Controls.Add(this.txtVrijeme);
            this.Controls.Add(this.labelVrijeme);
            this.Controls.Add(this.txtDatumIzdavanja);
            this.Controls.Add(this.labelDatumIzdavanja);
            this.Controls.Add(this.lblBrojRacuna);
            this.Controls.Add(this.labelRacunBroj);
            this.Controls.Add(this.labelPDV);
            this.Controls.Add(this.labelUkupniIznos);
            this.Controls.Add(this.labelUkupno);
            this.Controls.Add(this.labelRokPlacanja);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUkupniIznos);
            this.Controls.Add(this.txtPDV);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.txtRokPlacanja);
            this.Controls.Add(this.labelNacinPlacanja);
            this.Controls.Add(this.txtNacinPlacanja);
            this.Controls.Add(this.dgvStavke);
            this.Name = "FrmDetaljniPregledRacun";
            this.Text = "Detaljni pregled računa";
            this.Load += new System.EventHandler(this.FrmDetaljniPregledRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.Label labelObrtniRegistar;
        private System.Windows.Forms.Label labelBrojObrtnice;
        private System.Windows.Forms.Label labelOIB;
        private System.Windows.Forms.Label labelPoslovnica;
        private System.Windows.Forms.Label labelUlica;
        private System.Windows.Forms.TextBox txtP_ObrtniRegistar;
        private System.Windows.Forms.TextBox txtP_BrObrtnice;
        private System.Windows.Forms.TextBox txtP_OIB;
        private System.Windows.Forms.TextBox txtP_Poslovnica;
        private System.Windows.Forms.TextBox txtP_Ulica;
        private System.Windows.Forms.Label labelNazivKlijenta;
        private System.Windows.Forms.Label labelAdresaKlijenta;
        private System.Windows.Forms.Label labelOIBKlijenta;
        private System.Windows.Forms.TextBox txtK_Naziv;
        private System.Windows.Forms.TextBox txtK_Adresa;
        private System.Windows.Forms.TextBox txtK_OIB;
        private System.Windows.Forms.TextBox txtNacinPlacanja;
        private System.Windows.Forms.Label labelNacinPlacanja;
        private System.Windows.Forms.TextBox txtRokPlacanja;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.TextBox txtPDV;
        private System.Windows.Forms.TextBox txtUkupniIznos;
        private System.Windows.Forms.Label labelMjesto;
        private System.Windows.Forms.TextBox txtP_Mjesto;
        private System.Windows.Forms.TextBox txtP_Drzava;
        private System.Windows.Forms.Label labelDrzava;
        private System.Windows.Forms.Label labelBanka;
        private System.Windows.Forms.TextBox txtP_Banka;
        private System.Windows.Forms.Label labelIBAN;
        private System.Windows.Forms.TextBox txtP_IBAN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtP_BrojMobitela;
        private System.Windows.Forms.Label labelBrojMobitela;
        private System.Windows.Forms.TextBox txtP_TELFAX;
        private System.Windows.Forms.Label labelTelFax;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelRokPlacanja;
        private System.Windows.Forms.Label labelUkupno;
        private System.Windows.Forms.Label labelUkupniIznos;
        private System.Windows.Forms.Label labelPDV;
        private System.Windows.Forms.Label labelRacunBroj;
        private System.Windows.Forms.Label lblBrojRacuna;
        private System.Windows.Forms.TextBox txtK_TEL;
        private System.Windows.Forms.Label labelTelKlijent;
        private System.Windows.Forms.TextBox txtK_IBAN;
        private System.Windows.Forms.Label labelIBANKlijenta;
        private System.Windows.Forms.TextBox txtK_Email;
        private System.Windows.Forms.Label labelKIme;
        private System.Windows.Forms.TextBox txtK_Mjesto;
        private System.Windows.Forms.Label labelMjestoKlijenta;
        private System.Windows.Forms.TextBox txtDatumIzdavanja;
        private System.Windows.Forms.Label labelDatumIzdavanja;
        private System.Windows.Forms.TextBox txtVrijeme;
        private System.Windows.Forms.Label labelVrijeme;
        private System.Windows.Forms.TextBox txtFakturirao;
        private System.Windows.Forms.Label labelFakturirao;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.TextBox txtP_Naziv;
        private System.Windows.Forms.Button btnPDFpregled;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnNatrag;
    }
}