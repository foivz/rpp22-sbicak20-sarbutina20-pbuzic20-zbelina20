namespace ZMGDesktop
{
    partial class FrmIzdajNoviRacun
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
            this.chkAutoEmail = new System.Windows.Forms.CheckBox();
            this.labelObrtniRegistar = new System.Windows.Forms.Label();
            this.labelBrojObrtnice = new System.Windows.Forms.Label();
            this.labelOIB = new System.Windows.Forms.Label();
            this.labelPoslovnica = new System.Windows.Forms.Label();
            this.cmbKlijenti = new System.Windows.Forms.ComboBox();
            this.labelUlica = new System.Windows.Forms.Label();
            this.txtP_ObrtniRegistar = new System.Windows.Forms.TextBox();
            this.txtP_BrObrtnice = new System.Windows.Forms.TextBox();
            this.txtP_OIB = new System.Windows.Forms.TextBox();
            this.txtP_Poslovnica = new System.Windows.Forms.TextBox();
            this.txtP_Ulica = new System.Windows.Forms.TextBox();
            this.labelOdabirKlijenta = new System.Windows.Forms.Label();
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
            this.txtP_Naziv = new System.Windows.Forms.TextBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.txtP_BrojMobitela = new System.Windows.Forms.TextBox();
            this.labelBrojMobitela = new System.Windows.Forms.Label();
            this.txtP_TELFAX = new System.Windows.Forms.TextBox();
            this.labelTelFax = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelEmailKlijenta = new System.Windows.Forms.Label();
            this.txtK_Email = new System.Windows.Forms.TextBox();
            this.labelRokPlacanja = new System.Windows.Forms.Label();
            this.labelUkupno = new System.Windows.Forms.Label();
            this.labelUkupniIznos = new System.Windows.Forms.Label();
            this.labelPDV = new System.Windows.Forms.Label();
            this.labelRacunBroj = new System.Windows.Forms.Label();
            this.lblBrojRacuna = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnPDFpregled = new System.Windows.Forms.Button();
            this.btnIzdajRacun = new System.Windows.Forms.Button();
            this.btnDodajStavke = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStavke
            // 
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(241, 383);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.ReadOnly = true;
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.Size = new System.Drawing.Size(841, 196);
            this.dgvStavke.TabIndex = 3;
            // 
            // chkAutoEmail
            // 
            this.chkAutoEmail.AutoSize = true;
            this.chkAutoEmail.Location = new System.Drawing.Point(12, 707);
            this.chkAutoEmail.Name = "chkAutoEmail";
            this.chkAutoEmail.Size = new System.Drawing.Size(190, 17);
            this.chkAutoEmail.TabIndex = 5;
            this.chkAutoEmail.Text = "Automatsko slanje na email klijentu";
            this.chkAutoEmail.UseVisualStyleBackColor = true;
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
            // cmbKlijenti
            // 
            this.cmbKlijenti.FormattingEnabled = true;
            this.cmbKlijenti.Location = new System.Drawing.Point(903, 173);
            this.cmbKlijenti.Name = "cmbKlijenti";
            this.cmbKlijenti.Size = new System.Drawing.Size(179, 21);
            this.cmbKlijenti.TabIndex = 10;
            this.cmbKlijenti.SelectedIndexChanged += new System.EventHandler(this.cmbKlijenti_SelectedIndexChanged);
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
            // labelOdabirKlijenta
            // 
            this.labelOdabirKlijenta.AutoSize = true;
            this.labelOdabirKlijenta.Location = new System.Drawing.Point(814, 176);
            this.labelOdabirKlijenta.Name = "labelOdabirKlijenta";
            this.labelOdabirKlijenta.Size = new System.Drawing.Size(83, 13);
            this.labelOdabirKlijenta.TabIndex = 17;
            this.labelOdabirKlijenta.Text = "Odabir klijenata:";
            // 
            // labelNazivKlijenta
            // 
            this.labelNazivKlijenta.AutoSize = true;
            this.labelNazivKlijenta.Location = new System.Drawing.Point(19, 31);
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
            this.labelOIBKlijenta.Location = new System.Drawing.Point(26, 82);
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
            this.txtK_OIB.Location = new System.Drawing.Point(60, 79);
            this.txtK_OIB.Name = "txtK_OIB";
            this.txtK_OIB.ReadOnly = true;
            this.txtK_OIB.Size = new System.Drawing.Size(179, 20);
            this.txtK_OIB.TabIndex = 25;
            // 
            // txtNacinPlacanja
            // 
            this.txtNacinPlacanja.Location = new System.Drawing.Point(325, 592);
            this.txtNacinPlacanja.Name = "txtNacinPlacanja";
            this.txtNacinPlacanja.ReadOnly = true;
            this.txtNacinPlacanja.Size = new System.Drawing.Size(179, 20);
            this.txtNacinPlacanja.TabIndex = 28;
            // 
            // labelNacinPlacanja
            // 
            this.labelNacinPlacanja.AutoSize = true;
            this.labelNacinPlacanja.Location = new System.Drawing.Point(238, 595);
            this.labelNacinPlacanja.Name = "labelNacinPlacanja";
            this.labelNacinPlacanja.Size = new System.Drawing.Size(81, 13);
            this.labelNacinPlacanja.TabIndex = 29;
            this.labelNacinPlacanja.Text = "Način plaćanja:";
            // 
            // txtRokPlacanja
            // 
            this.txtRokPlacanja.Location = new System.Drawing.Point(325, 618);
            this.txtRokPlacanja.Name = "txtRokPlacanja";
            this.txtRokPlacanja.ReadOnly = true;
            this.txtRokPlacanja.Size = new System.Drawing.Size(179, 20);
            this.txtRokPlacanja.TabIndex = 30;
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(903, 592);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.ReadOnly = true;
            this.txtUkupno.Size = new System.Drawing.Size(179, 20);
            this.txtUkupno.TabIndex = 31;
            // 
            // txtPDV
            // 
            this.txtPDV.Location = new System.Drawing.Point(903, 618);
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.ReadOnly = true;
            this.txtPDV.Size = new System.Drawing.Size(179, 20);
            this.txtPDV.TabIndex = 32;
            // 
            // txtUkupniIznos
            // 
            this.txtUkupniIznos.Location = new System.Drawing.Point(903, 644);
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
            this.groupBox1.Controls.Add(this.txtP_Naziv);
            this.groupBox1.Controls.Add(this.labelNaziv);
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
            // txtP_Naziv
            // 
            this.txtP_Naziv.Location = new System.Drawing.Point(129, 14);
            this.txtP_Naziv.Name = "txtP_Naziv";
            this.txtP_Naziv.ReadOnly = true;
            this.txtP_Naziv.Size = new System.Drawing.Size(260, 20);
            this.txtP_Naziv.TabIndex = 29;
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(83, 17);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(37, 13);
            this.labelNaziv.TabIndex = 28;
            this.labelNaziv.Text = "Naziv:";
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
            this.groupBox2.Controls.Add(this.labelEmailKlijenta);
            this.groupBox2.Controls.Add(this.txtK_Email);
            this.groupBox2.Controls.Add(this.txtK_Naziv);
            this.groupBox2.Controls.Add(this.labelNazivKlijenta);
            this.groupBox2.Controls.Add(this.labelAdresaKlijenta);
            this.groupBox2.Controls.Add(this.labelOIBKlijenta);
            this.groupBox2.Controls.Add(this.txtK_Adresa);
            this.groupBox2.Controls.Add(this.txtK_OIB);
            this.groupBox2.Location = new System.Drawing.Point(815, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 144);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Klijent";
            // 
            // labelEmailKlijenta
            // 
            this.labelEmailKlijenta.AutoSize = true;
            this.labelEmailKlijenta.Location = new System.Drawing.Point(19, 108);
            this.labelEmailKlijenta.Name = "labelEmailKlijenta";
            this.labelEmailKlijenta.Size = new System.Drawing.Size(35, 13);
            this.labelEmailKlijenta.TabIndex = 26;
            this.labelEmailKlijenta.Text = "Email:";
            // 
            // txtK_Email
            // 
            this.txtK_Email.Location = new System.Drawing.Point(60, 105);
            this.txtK_Email.Name = "txtK_Email";
            this.txtK_Email.ReadOnly = true;
            this.txtK_Email.Size = new System.Drawing.Size(179, 20);
            this.txtK_Email.TabIndex = 27;
            // 
            // labelRokPlacanja
            // 
            this.labelRokPlacanja.AutoSize = true;
            this.labelRokPlacanja.Location = new System.Drawing.Point(246, 618);
            this.labelRokPlacanja.Name = "labelRokPlacanja";
            this.labelRokPlacanja.Size = new System.Drawing.Size(73, 13);
            this.labelRokPlacanja.TabIndex = 44;
            this.labelRokPlacanja.Text = "Rok plaćanja:";
            // 
            // labelUkupno
            // 
            this.labelUkupno.AutoSize = true;
            this.labelUkupno.Location = new System.Drawing.Point(849, 595);
            this.labelUkupno.Name = "labelUkupno";
            this.labelUkupno.Size = new System.Drawing.Size(48, 13);
            this.labelUkupno.TabIndex = 45;
            this.labelUkupno.Text = "Ukupno:";
            // 
            // labelUkupniIznos
            // 
            this.labelUkupniIznos.AutoSize = true;
            this.labelUkupniIznos.Location = new System.Drawing.Point(826, 647);
            this.labelUkupniIznos.Name = "labelUkupniIznos";
            this.labelUkupniIznos.Size = new System.Drawing.Size(71, 13);
            this.labelUkupniIznos.TabIndex = 46;
            this.labelUkupniIznos.Text = "Ukupni iznos:";
            // 
            // labelPDV
            // 
            this.labelPDV.AutoSize = true;
            this.labelPDV.Location = new System.Drawing.Point(842, 621);
            this.labelPDV.Name = "labelPDV";
            this.labelPDV.Size = new System.Drawing.Size(55, 13);
            this.labelPDV.TabIndex = 47;
            this.labelPDV.Text = "PDV 25%:";
            // 
            // labelRacunBroj
            // 
            this.labelRacunBroj.AutoSize = true;
            this.labelRacunBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRacunBroj.Location = new System.Drawing.Point(810, 77);
            this.labelRacunBroj.Name = "labelRacunBroj";
            this.labelRacunBroj.Size = new System.Drawing.Size(181, 37);
            this.labelRacunBroj.TabIndex = 48;
            this.labelRacunBroj.Text = "Račun broj:";
            // 
            // lblBrojRacuna
            // 
            this.lblBrojRacuna.AutoSize = true;
            this.lblBrojRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojRacuna.Location = new System.Drawing.Point(984, 78);
            this.lblBrojRacuna.Name = "lblBrojRacuna";
            this.lblBrojRacuna.Size = new System.Drawing.Size(171, 37);
            this.lblBrojRacuna.TabIndex = 49;
            this.lblBrojRacuna.Text = "Novi račun";
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNatrag.Location = new System.Drawing.Point(1171, 730);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(147, 40);
            this.btnNatrag.TabIndex = 50;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPDFpregled
            // 
            this.btnPDFpregled.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPDFpregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPDFpregled.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPDFpregled.Location = new System.Drawing.Point(172, 730);
            this.btnPDFpregled.Name = "btnPDFpregled";
            this.btnPDFpregled.Size = new System.Drawing.Size(147, 40);
            this.btnPDFpregled.TabIndex = 51;
            this.btnPDFpregled.Text = "Pregled PDF-a";
            this.btnPDFpregled.UseVisualStyleBackColor = false;
            this.btnPDFpregled.Click += new System.EventHandler(this.btnPDFpregled_Click);
            // 
            // btnIzdajRacun
            // 
            this.btnIzdajRacun.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzdajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzdajRacun.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzdajRacun.Location = new System.Drawing.Point(12, 730);
            this.btnIzdajRacun.Name = "btnIzdajRacun";
            this.btnIzdajRacun.Size = new System.Drawing.Size(147, 40);
            this.btnIzdajRacun.TabIndex = 52;
            this.btnIzdajRacun.Text = "Izdaj račun";
            this.btnIzdajRacun.UseVisualStyleBackColor = false;
            this.btnIzdajRacun.Click += new System.EventHandler(this.btnIzdajRacun_Click);
            // 
            // btnDodajStavke
            // 
            this.btnDodajStavke.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodajStavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajStavke.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajStavke.Location = new System.Drawing.Point(1088, 383);
            this.btnDodajStavke.Name = "btnDodajStavke";
            this.btnDodajStavke.Size = new System.Drawing.Size(147, 196);
            this.btnDodajStavke.TabIndex = 53;
            this.btnDodajStavke.Text = "Upravljanje stavkama";
            this.btnDodajStavke.UseVisualStyleBackColor = false;
            this.btnDodajStavke.Click += new System.EventHandler(this.btnDodajStavke_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(284, 647);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 13);
            this.label24.TabIndex = 55;
            this.label24.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(325, 647);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(179, 65);
            this.txtOpis.TabIndex = 54;
            // 
            // FrmIzdajNoviRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 775);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.btnDodajStavke);
            this.Controls.Add(this.btnIzdajRacun);
            this.Controls.Add(this.btnPDFpregled);
            this.Controls.Add(this.btnNatrag);
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
            this.Controls.Add(this.labelOdabirKlijenta);
            this.Controls.Add(this.cmbKlijenti);
            this.Controls.Add(this.chkAutoEmail);
            this.Controls.Add(this.dgvStavke);
            this.Name = "FrmIzdajNoviRacun";
            this.Load += new System.EventHandler(this.FrmIzdajNoviRacun_Load);
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
        private System.Windows.Forms.CheckBox chkAutoEmail;
        private System.Windows.Forms.Label labelObrtniRegistar;
        private System.Windows.Forms.Label labelBrojObrtnice;
        private System.Windows.Forms.Label labelOIB;
        private System.Windows.Forms.Label labelPoslovnica;
        private System.Windows.Forms.ComboBox cmbKlijenti;
        private System.Windows.Forms.Label labelUlica;
        private System.Windows.Forms.TextBox txtP_ObrtniRegistar;
        private System.Windows.Forms.TextBox txtP_BrObrtnice;
        private System.Windows.Forms.TextBox txtP_OIB;
        private System.Windows.Forms.TextBox txtP_Poslovnica;
        private System.Windows.Forms.TextBox txtP_Ulica;
        private System.Windows.Forms.Label labelOdabirKlijenta;
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
        private System.Windows.Forms.Label labelEmailKlijenta;
        private System.Windows.Forms.TextBox txtK_Email;
        private System.Windows.Forms.TextBox txtP_Naziv;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnPDFpregled;
        private System.Windows.Forms.Button btnIzdajRacun;
        private System.Windows.Forms.Button btnDodajStavke;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtOpis;
    }
}