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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnObrisiRobuSRadnogNaloga = new System.Windows.Forms.Button();
            this.btnDodajNovuRobu = new System.Windows.Forms.Button();
            this.btnDodajRobuNaRadniNalog = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvKlijentovaRoba = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvRobaRadnogNaloga = new System.Windows.Forms.DataGridView();
            this.txtKolicinaRobe = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNazivRobe = new System.Windows.Forms.TextBox();
            this.pbQRKod = new System.Windows.Forms.PictureBox();
            this.btnGenerirajQRKod = new System.Windows.Forms.Button();
            this.btnDodajMaterijal = new System.Windows.Forms.Button();
            this.cmbMaterijali = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvMaterijali = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRadnik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatumStvaranja = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzmijeni);
            this.groupBox1.Controls.Add(this.btnObrisiRobuSRadnogNaloga);
            this.groupBox1.Controls.Add(this.btnSpremi);
            this.groupBox1.Controls.Add(this.btnOdustani);
            this.groupBox1.Controls.Add(this.btnDodajNovuRobu);
            this.groupBox1.Controls.Add(this.btnDodajRobuNaRadniNalog);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dgvKlijentovaRoba);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dgvRobaRadnogNaloga);
            this.groupBox1.Controls.Add(this.txtKolicinaRobe);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtNazivRobe);
            this.groupBox1.Controls.Add(this.pbQRKod);
            this.groupBox1.Controls.Add(this.btnGenerirajQRKod);
            this.groupBox1.Controls.Add(this.btnDodajMaterijal);
            this.groupBox1.Controls.Add(this.cmbMaterijali);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dgvMaterijali);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.cmbKlijent);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRadnik);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpDatumStvaranja);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKolicina);
            this.groupBox1.Location = new System.Drawing.Point(13, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 673);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije";
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
            this.btnObrisiRobuSRadnogNaloga.Click += new System.EventHandler(this.btnObrisiRobuSRadnogNaloga_Click);
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
            this.btnDodajRobuNaRadniNalog.Click += new System.EventHandler(this.btnDodajRobuNaRadniNalog_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(358, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Klijentova roba:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(355, 571);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Kolicina robe:";
            // 
            // dgvKlijentovaRoba
            // 
            this.dgvKlijentovaRoba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijentovaRoba.Location = new System.Drawing.Point(358, 372);
            this.dgvKlijentovaRoba.Name = "dgvKlijentovaRoba";
            this.dgvKlijentovaRoba.Size = new System.Drawing.Size(286, 150);
            this.dgvKlijentovaRoba.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Roba radnog naloga:";
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(355, 529);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Naziv robe:";
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
            this.btnDodajMaterijal.Click += new System.EventHandler(this.btnDodajMaterijal_Click);
            // 
            // cmbMaterijali
            // 
            this.cmbMaterijali.FormattingEnabled = true;
            this.cmbMaterijali.Location = new System.Drawing.Point(36, 302);
            this.cmbMaterijali.Name = "cmbMaterijali";
            this.cmbMaterijali.Size = new System.Drawing.Size(120, 21);
            this.cmbMaterijali.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Materijali:";
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
            "U izradi",
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Klijent:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Radnik:";
            // 
            // txtRadnik
            // 
            this.txtRadnik.Location = new System.Drawing.Point(232, 81);
            this.txtRadnik.Name = "txtRadnik";
            this.txtRadnik.ReadOnly = true;
            this.txtRadnik.Size = new System.Drawing.Size(168, 20);
            this.txtRadnik.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Status:";
            // 
            // dtpDatumStvaranja
            // 
            this.dtpDatumStvaranja.Location = new System.Drawing.Point(232, 42);
            this.dtpDatumStvaranja.Name = "dtpDatumStvaranja";
            this.dtpDatumStvaranja.Size = new System.Drawing.Size(168, 20);
            this.dtpDatumStvaranja.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Datum stvaranja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(36, 81);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(168, 20);
            this.txtOpis.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Količina (kg):";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Radni nalog #";
            // 
            // FrmDetaljiRadnogNaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetaljiRadnogNaloga";
            this.Text = "Detalji radnog naloga";
            this.Load += new System.EventHandler(this.FrmDetaljiRadnogNaloga_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnGenerirajQRKod;
        private System.Windows.Forms.Button btnDodajMaterijal;
        private System.Windows.Forms.ComboBox cmbMaterijali;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvMaterijali;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRadnik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatumStvaranja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.PictureBox pbQRKod;
        private System.Windows.Forms.Button btnObrisiRobuSRadnogNaloga;
        private System.Windows.Forms.Button btnDodajNovuRobu;
        private System.Windows.Forms.Button btnDodajRobuNaRadniNalog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvKlijentovaRoba;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvRobaRadnogNaloga;
        private System.Windows.Forms.TextBox txtKolicinaRobe;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNazivRobe;
    }
}