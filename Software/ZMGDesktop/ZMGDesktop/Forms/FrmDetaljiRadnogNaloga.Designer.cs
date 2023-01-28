namespace ZMGDesktop
{
    partial class FrmDetaljiRadnogNaloga
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.groupBoxInformacije = new System.Windows.Forms.GroupBox();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnObrisiRobuSRadnogNaloga = new System.Windows.Forms.Button();
            this.btnDodajNovuRobu = new System.Windows.Forms.Button();
            this.btnDodajRobuNaRadniNalog = new System.Windows.Forms.Button();
            this.labelKlijentovaRoba = new System.Windows.Forms.Label();
            this.labelKolicinaRobe = new System.Windows.Forms.Label();
            this.dgvKlijentovaRoba = new System.Windows.Forms.DataGridView();
            this.labelRobaRadnogNaloga = new System.Windows.Forms.Label();
            this.dgvRobaRadnogNaloga = new System.Windows.Forms.DataGridView();
            this.txtKolicinaRobe = new System.Windows.Forms.TextBox();
            this.labelNazivRobe = new System.Windows.Forms.Label();
            this.txtNazivRobe = new System.Windows.Forms.TextBox();
            this.pbQRKod = new System.Windows.Forms.PictureBox();
            this.btnGenerirajQRKod = new System.Windows.Forms.Button();
            this.btnDodajMaterijal = new System.Windows.Forms.Button();
            this.cmbMaterijali = new System.Windows.Forms.ComboBox();
            this.labelMaterijali = new System.Windows.Forms.Label();
            this.dgvMaterijali = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.labelKlijent = new System.Windows.Forms.Label();
            this.labelRadnik = new System.Windows.Forms.Label();
            this.txtRadnik = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.dtpDatumStvaranja = new System.Windows.Forms.DateTimePicker();
            this.labelDatumStvaranja = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.labelKolicina = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelRadniNalog = new System.Windows.Forms.Label();
            this.groupBoxInformacije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijentovaRoba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRobaRadnogNaloga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRKod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSpremi.Location = new System.Drawing.Point(670, 590);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(112, 37);
            this.btnSpremi.TabIndex = 15;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOdustani.Location = new System.Drawing.Point(670, 631);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(112, 37);
            this.btnOdustani.TabIndex = 14;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // groupBoxInformacije
            // 
            this.groupBoxInformacije.Controls.Add(this.btnIzmijeni);
            this.groupBoxInformacije.Controls.Add(this.btnObrisiRobuSRadnogNaloga);
            this.groupBoxInformacije.Controls.Add(this.btnSpremi);
            this.groupBoxInformacije.Controls.Add(this.btnOdustani);
            this.groupBoxInformacije.Controls.Add(this.btnDodajNovuRobu);
            this.groupBoxInformacije.Controls.Add(this.btnDodajRobuNaRadniNalog);
            this.groupBoxInformacije.Controls.Add(this.labelKlijentovaRoba);
            this.groupBoxInformacije.Controls.Add(this.labelKolicinaRobe);
            this.groupBoxInformacije.Controls.Add(this.dgvKlijentovaRoba);
            this.groupBoxInformacije.Controls.Add(this.labelRobaRadnogNaloga);
            this.groupBoxInformacije.Controls.Add(this.dgvRobaRadnogNaloga);
            this.groupBoxInformacije.Controls.Add(this.txtKolicinaRobe);
            this.groupBoxInformacije.Controls.Add(this.labelNazivRobe);
            this.groupBoxInformacije.Controls.Add(this.txtNazivRobe);
            this.groupBoxInformacije.Controls.Add(this.pbQRKod);
            this.groupBoxInformacije.Controls.Add(this.btnGenerirajQRKod);
            this.groupBoxInformacije.Controls.Add(this.btnDodajMaterijal);
            this.groupBoxInformacije.Controls.Add(this.cmbMaterijali);
            this.groupBoxInformacije.Controls.Add(this.labelMaterijali);
            this.groupBoxInformacije.Controls.Add(this.dgvMaterijali);
            this.groupBoxInformacije.Controls.Add(this.cmbStatus);
            this.groupBoxInformacije.Controls.Add(this.cmbKlijent);
            this.groupBoxInformacije.Controls.Add(this.labelKlijent);
            this.groupBoxInformacije.Controls.Add(this.labelRadnik);
            this.groupBoxInformacije.Controls.Add(this.txtRadnik);
            this.groupBoxInformacije.Controls.Add(this.labelStatus);
            this.groupBoxInformacije.Controls.Add(this.dtpDatumStvaranja);
            this.groupBoxInformacije.Controls.Add(this.labelDatumStvaranja);
            this.groupBoxInformacije.Controls.Add(this.labelOpis);
            this.groupBoxInformacije.Controls.Add(this.txtOpis);
            this.groupBoxInformacije.Controls.Add(this.labelKolicina);
            this.groupBoxInformacije.Controls.Add(this.txtKolicina);
            this.groupBoxInformacije.Location = new System.Drawing.Point(13, 40);
            this.groupBoxInformacije.Name = "groupBoxInformacije";
            this.groupBoxInformacije.Size = new System.Drawing.Size(788, 673);
            this.groupBoxInformacije.TabIndex = 13;
            this.groupBoxInformacije.TabStop = false;
            this.groupBoxInformacije.Text = "Informacije";
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzmijeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmijeni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzmijeni.Location = new System.Drawing.Point(670, 549);
            this.btnIzmijeni.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(112, 37);
            this.btnIzmijeni.TabIndex = 16;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = false;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnObrisiRobuSRadnogNaloga
            // 
            this.btnObrisiRobuSRadnogNaloga.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnObrisiRobuSRadnogNaloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiRobuSRadnogNaloga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnObrisiRobuSRadnogNaloga.Location = new System.Drawing.Point(143, 529);
            this.btnObrisiRobuSRadnogNaloga.Name = "btnObrisiRobuSRadnogNaloga";
            this.btnObrisiRobuSRadnogNaloga.Size = new System.Drawing.Size(108, 47);
            this.btnObrisiRobuSRadnogNaloga.TabIndex = 54;
            this.btnObrisiRobuSRadnogNaloga.Text = "Obrisi s radnog naloga";
            this.btnObrisiRobuSRadnogNaloga.UseVisualStyleBackColor = false;
            // 
            // btnDodajNovuRobu
            // 
            this.btnDodajNovuRobu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodajNovuRobu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNovuRobu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajNovuRobu.Location = new System.Drawing.Point(557, 528);
            this.btnDodajNovuRobu.Name = "btnDodajNovuRobu";
            this.btnDodajNovuRobu.Size = new System.Drawing.Size(85, 47);
            this.btnDodajNovuRobu.TabIndex = 48;
            this.btnDodajNovuRobu.Text = "Dodaj novu robu";
            this.btnDodajNovuRobu.UseVisualStyleBackColor = false;
            this.btnDodajNovuRobu.Click += new System.EventHandler(this.btnDodajNovuRobu_Click);
            // 
            // btnDodajRobuNaRadniNalog
            // 
            this.btnDodajRobuNaRadniNalog.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDodajRobuNaRadniNalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRobuNaRadniNalog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajRobuNaRadniNalog.Location = new System.Drawing.Point(39, 529);
            this.btnDodajRobuNaRadniNalog.Name = "btnDodajRobuNaRadniNalog";
            this.btnDodajRobuNaRadniNalog.Size = new System.Drawing.Size(98, 47);
            this.btnDodajRobuNaRadniNalog.TabIndex = 50;
            this.btnDodajRobuNaRadniNalog.Text = "Dodaj na radni nalog";
            this.btnDodajRobuNaRadniNalog.UseVisualStyleBackColor = false;
            // 
            // labelKlijentovaRoba
            // 
            this.labelKlijentovaRoba.AutoSize = true;
            this.labelKlijentovaRoba.Location = new System.Drawing.Point(358, 353);
            this.labelKlijentovaRoba.Name = "labelKlijentovaRoba";
            this.labelKlijentovaRoba.Size = new System.Drawing.Size(80, 13);
            this.labelKlijentovaRoba.TabIndex = 45;
            this.labelKlijentovaRoba.Text = "Klijentova roba:";
            // 
            // labelKolicinaRobe
            // 
            this.labelKolicinaRobe.AutoSize = true;
            this.labelKolicinaRobe.Location = new System.Drawing.Point(355, 571);
            this.labelKolicinaRobe.Name = "labelKolicinaRobe";
            this.labelKolicinaRobe.Size = new System.Drawing.Size(71, 13);
            this.labelKolicinaRobe.TabIndex = 53;
            this.labelKolicinaRobe.Text = "Kolicina robe:";
            // 
            // dgvKlijentovaRoba
            // 
            this.dgvKlijentovaRoba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijentovaRoba.Location = new System.Drawing.Point(358, 372);
            this.dgvKlijentovaRoba.Name = "dgvKlijentovaRoba";
            this.dgvKlijentovaRoba.Size = new System.Drawing.Size(286, 150);
            this.dgvKlijentovaRoba.TabIndex = 44;
            // 
            // labelRobaRadnogNaloga
            // 
            this.labelRobaRadnogNaloga.AutoSize = true;
            this.labelRobaRadnogNaloga.Location = new System.Drawing.Point(44, 356);
            this.labelRobaRadnogNaloga.Name = "labelRobaRadnogNaloga";
            this.labelRobaRadnogNaloga.Size = new System.Drawing.Size(107, 13);
            this.labelRobaRadnogNaloga.TabIndex = 47;
            this.labelRobaRadnogNaloga.Text = "Roba radnog naloga:";
            // 
            // dgvRobaRadnogNaloga
            // 
            this.dgvRobaRadnogNaloga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRobaRadnogNaloga.Location = new System.Drawing.Point(39, 372);
            this.dgvRobaRadnogNaloga.Name = "dgvRobaRadnogNaloga";
            this.dgvRobaRadnogNaloga.Size = new System.Drawing.Size(280, 150);
            this.dgvRobaRadnogNaloga.TabIndex = 46;
            // 
            // txtKolicinaRobe
            // 
            this.txtKolicinaRobe.Location = new System.Drawing.Point(358, 587);
            this.txtKolicinaRobe.Name = "txtKolicinaRobe";
            this.txtKolicinaRobe.Size = new System.Drawing.Size(153, 20);
            this.txtKolicinaRobe.TabIndex = 52;
            // 
            // labelNazivRobe
            // 
            this.labelNazivRobe.AutoSize = true;
            this.labelNazivRobe.Location = new System.Drawing.Point(355, 529);
            this.labelNazivRobe.Name = "labelNazivRobe";
            this.labelNazivRobe.Size = new System.Drawing.Size(61, 13);
            this.labelNazivRobe.TabIndex = 51;
            this.labelNazivRobe.Text = "Naziv robe:";
            // 
            // txtNazivRobe
            // 
            this.txtNazivRobe.Location = new System.Drawing.Point(358, 545);
            this.txtNazivRobe.Name = "txtNazivRobe";
            this.txtNazivRobe.Size = new System.Drawing.Size(153, 20);
            this.txtNazivRobe.TabIndex = 49;
            // 
            // pbQRKod
            // 
            this.pbQRKod.Location = new System.Drawing.Point(480, 46);
            this.pbQRKod.MaximumSize = new System.Drawing.Size(244, 244);
            this.pbQRKod.MinimumSize = new System.Drawing.Size(244, 244);
            this.pbQRKod.Name = "pbQRKod";
            this.pbQRKod.Size = new System.Drawing.Size(244, 244);
            this.pbQRKod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbQRKod.TabIndex = 43;
            this.pbQRKod.TabStop = false;
            // 
            // btnGenerirajQRKod
            // 
            this.btnGenerirajQRKod.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerirajQRKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerirajQRKod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerirajQRKod.Location = new System.Drawing.Point(322, 292);
            this.btnGenerirajQRKod.Name = "btnGenerirajQRKod";
            this.btnGenerirajQRKod.Size = new System.Drawing.Size(75, 47);
            this.btnGenerirajQRKod.TabIndex = 42;
            this.btnGenerirajQRKod.Text = "Generiraj QR kod";
            this.btnGenerirajQRKod.UseVisualStyleBackColor = false;
            this.btnGenerirajQRKod.Click += new System.EventHandler(this.btnGenerirajQRKod_Click);
            // 
            // btnDodajMaterijal
            // 
            this.btnDodajMaterijal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDodajMaterijal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajMaterijal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajMaterijal.Location = new System.Drawing.Point(241, 292);
            this.btnDodajMaterijal.Name = "btnDodajMaterijal";
            this.btnDodajMaterijal.Size = new System.Drawing.Size(75, 47);
            this.btnDodajMaterijal.TabIndex = 40;
            this.btnDodajMaterijal.Text = "Dodaj materijal";
            this.btnDodajMaterijal.UseVisualStyleBackColor = false;
            // 
            // cmbMaterijali
            // 
            this.cmbMaterijali.FormattingEnabled = true;
            this.cmbMaterijali.Location = new System.Drawing.Point(36, 302);
            this.cmbMaterijali.Name = "cmbMaterijali";
            this.cmbMaterijali.Size = new System.Drawing.Size(120, 21);
            this.cmbMaterijali.TabIndex = 39;
            // 
            // labelMaterijali
            // 
            this.labelMaterijali.AutoSize = true;
            this.labelMaterijali.Location = new System.Drawing.Point(36, 159);
            this.labelMaterijali.Name = "labelMaterijali";
            this.labelMaterijali.Size = new System.Drawing.Size(51, 13);
            this.labelMaterijali.TabIndex = 38;
            this.labelMaterijali.Text = "Materijali:";
            // 
            // dgvMaterijali
            // 
            this.dgvMaterijali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterijali.Location = new System.Drawing.Point(36, 178);
            this.dgvMaterijali.Name = "dgvMaterijali";
            this.dgvMaterijali.Size = new System.Drawing.Size(364, 112);
            this.dgvMaterijali.TabIndex = 37;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Napravljen",
            "U obradi",
            "Dovršen"});
            this.cmbStatus.Location = new System.Drawing.Point(36, 129);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(168, 21);
            this.cmbStatus.TabIndex = 36;
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(232, 129);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(168, 21);
            this.cmbKlijent.TabIndex = 35;
            this.cmbKlijent.SelectedIndexChanged += new System.EventHandler(this.cmbKlijent_SelectedIndexChanged);
            // 
            // labelKlijent
            // 
            this.labelKlijent.AutoSize = true;
            this.labelKlijent.Location = new System.Drawing.Point(229, 112);
            this.labelKlijent.Name = "labelKlijent";
            this.labelKlijent.Size = new System.Drawing.Size(38, 13);
            this.labelKlijent.TabIndex = 34;
            this.labelKlijent.Text = "Klijent:";
            // 
            // labelRadnik
            // 
            this.labelRadnik.AutoSize = true;
            this.labelRadnik.Location = new System.Drawing.Point(229, 65);
            this.labelRadnik.Name = "labelRadnik";
            this.labelRadnik.Size = new System.Drawing.Size(44, 13);
            this.labelRadnik.TabIndex = 33;
            this.labelRadnik.Text = "Radnik:";
            // 
            // txtRadnik
            // 
            this.txtRadnik.Location = new System.Drawing.Point(232, 81);
            this.txtRadnik.Name = "txtRadnik";
            this.txtRadnik.ReadOnly = true;
            this.txtRadnik.Size = new System.Drawing.Size(168, 20);
            this.txtRadnik.TabIndex = 32;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(33, 113);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 31;
            this.labelStatus.Text = "Status:";
            // 
            // dtpDatumStvaranja
            // 
            this.dtpDatumStvaranja.Location = new System.Drawing.Point(232, 34);
            this.dtpDatumStvaranja.Name = "dtpDatumStvaranja";
            this.dtpDatumStvaranja.Size = new System.Drawing.Size(168, 20);
            this.dtpDatumStvaranja.TabIndex = 30;
            // 
            // labelDatumStvaranja
            // 
            this.labelDatumStvaranja.AutoSize = true;
            this.labelDatumStvaranja.Location = new System.Drawing.Point(229, 18);
            this.labelDatumStvaranja.Name = "labelDatumStvaranja";
            this.labelDatumStvaranja.Size = new System.Drawing.Size(87, 13);
            this.labelDatumStvaranja.TabIndex = 29;
            this.labelDatumStvaranja.Text = "Datum stvaranja:";
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(33, 65);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(31, 13);
            this.labelOpis.TabIndex = 26;
            this.labelOpis.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(36, 81);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(168, 20);
            this.txtOpis.TabIndex = 25;
            // 
            // labelKolicina
            // 
            this.labelKolicina.AutoSize = true;
            this.labelKolicina.Location = new System.Drawing.Point(33, 18);
            this.labelKolicina.Name = "labelKolicina";
            this.labelKolicina.Size = new System.Drawing.Size(68, 13);
            this.labelKolicina.TabIndex = 24;
            this.labelKolicina.Text = "Količina (kg):";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(36, 34);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(168, 20);
            this.txtKolicina.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // labelRadniNalog
            // 
            this.labelRadniNalog.AutoSize = true;
            this.labelRadniNalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRadniNalog.Location = new System.Drawing.Point(309, 10);
            this.labelRadniNalog.Name = "labelRadniNalog";
            this.labelRadniNalog.Size = new System.Drawing.Size(161, 29);
            this.labelRadniNalog.TabIndex = 11;
            this.labelRadniNalog.Text = "Radni nalog #";
            // 
            // FrmDetaljiRadnogNaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.groupBoxInformacije);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelRadniNalog);
            this.Name = "FrmDetaljiRadnogNaloga";
            this.Text = "Detalji radnog naloga";
            this.Load += new System.EventHandler(this.FrmDetaljiRadnogNaloga_Load);
            this.groupBoxInformacije.ResumeLayout(false);
            this.groupBoxInformacije.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijentovaRoba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRobaRadnogNaloga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRKod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.GroupBox groupBoxInformacije;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelRadniNalog;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnGenerirajQRKod;
        private System.Windows.Forms.Button btnDodajMaterijal;
        private System.Windows.Forms.ComboBox cmbMaterijali;
        private System.Windows.Forms.Label labelMaterijali;
        private System.Windows.Forms.DataGridView dgvMaterijali;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.Label labelKlijent;
        private System.Windows.Forms.Label labelRadnik;
        private System.Windows.Forms.TextBox txtRadnik;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.DateTimePicker dtpDatumStvaranja;
        private System.Windows.Forms.Label labelDatumStvaranja;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label labelKolicina;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.PictureBox pbQRKod;
        private System.Windows.Forms.Button btnObrisiRobuSRadnogNaloga;
        private System.Windows.Forms.Button btnDodajNovuRobu;
        private System.Windows.Forms.Button btnDodajRobuNaRadniNalog;
        private System.Windows.Forms.Label labelKlijentovaRoba;
        private System.Windows.Forms.Label labelKolicinaRobe;
        private System.Windows.Forms.DataGridView dgvKlijentovaRoba;
        private System.Windows.Forms.Label labelRobaRadnogNaloga;
        private System.Windows.Forms.DataGridView dgvRobaRadnogNaloga;
        private System.Windows.Forms.TextBox txtKolicinaRobe;
        private System.Windows.Forms.Label labelNazivRobe;
        private System.Windows.Forms.TextBox txtNazivRobe;
    }
}