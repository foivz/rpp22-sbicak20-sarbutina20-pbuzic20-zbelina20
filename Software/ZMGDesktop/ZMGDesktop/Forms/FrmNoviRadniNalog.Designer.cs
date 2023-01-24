namespace ZMGDesktop
{
    partial class FrmNoviRadniNalog
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRadnik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatumStvaranja = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQRKod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPodnesi = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dgvMaterijali = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMaterijali = new System.Windows.Forms.ComboBox();
            this.btnDodajMaterijal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radni nalog";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtQRKod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKolicina);
            this.groupBox1.Location = new System.Drawing.Point(13, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 357);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije";
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(194, 307);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(168, 21);
            this.cmbKlijent.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Klijent:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Radnik:";
            // 
            // txtRadnik
            // 
            this.txtRadnik.Location = new System.Drawing.Point(194, 259);
            this.txtRadnik.Name = "txtRadnik";
            this.txtRadnik.ReadOnly = true;
            this.txtRadnik.Size = new System.Drawing.Size(168, 20);
            this.txtRadnik.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // dtpDatumStvaranja
            // 
            this.dtpDatumStvaranja.Location = new System.Drawing.Point(194, 171);
            this.dtpDatumStvaranja.Name = "dtpDatumStvaranja";
            this.dtpDatumStvaranja.Size = new System.Drawing.Size(168, 20);
            this.dtpDatumStvaranja.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Datum stvaranja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "QR Kod:";
            // 
            // txtQRKod
            // 
            this.txtQRKod.Location = new System.Drawing.Point(194, 123);
            this.txtQRKod.Name = "txtQRKod";
            this.txtQRKod.Size = new System.Drawing.Size(168, 20);
            this.txtQRKod.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(194, 78);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(168, 20);
            this.txtOpis.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Količina:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(194, 31);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(168, 20);
            this.txtKolicina.TabIndex = 0;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOdustani.Location = new System.Drawing.Point(676, 402);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(112, 37);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPodnesi
            // 
            this.btnPodnesi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPodnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPodnesi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPodnesi.Location = new System.Drawing.Point(560, 402);
            this.btnPodnesi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPodnesi.Name = "btnPodnesi";
            this.btnPodnesi.Size = new System.Drawing.Size(112, 37);
            this.btnPodnesi.TabIndex = 10;
            this.btnPodnesi.Text = "Podnesi";
            this.btnPodnesi.UseVisualStyleBackColor = false;
            this.btnPodnesi.Click += new System.EventHandler(this.btnPodnesi_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Napravljen",
            "U izradi",
            "Dovršen"});
            this.cmbStatus.Location = new System.Drawing.Point(194, 216);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(168, 21);
            this.cmbStatus.TabIndex = 16;
            // 
            // dgvMaterijali
            // 
            this.dgvMaterijali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterijali.Location = new System.Drawing.Point(419, 78);
            this.dgvMaterijali.Name = "dgvMaterijali";
            this.dgvMaterijali.Size = new System.Drawing.Size(240, 150);
            this.dgvMaterijali.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Materijali:";
            // 
            // cmbMaterijali
            // 
            this.cmbMaterijali.FormattingEnabled = true;
            this.cmbMaterijali.Location = new System.Drawing.Point(419, 235);
            this.cmbMaterijali.Name = "cmbMaterijali";
            this.cmbMaterijali.Size = new System.Drawing.Size(159, 21);
            this.cmbMaterijali.TabIndex = 19;
            // 
            // btnDodajMaterijal
            // 
            this.btnDodajMaterijal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodajMaterijal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajMaterijal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajMaterijal.Location = new System.Drawing.Point(584, 234);
            this.btnDodajMaterijal.Name = "btnDodajMaterijal";
            this.btnDodajMaterijal.Size = new System.Drawing.Size(75, 47);
            this.btnDodajMaterijal.TabIndex = 20;
            this.btnDodajMaterijal.Text = "Dodaj materijal";
            this.btnDodajMaterijal.UseVisualStyleBackColor = false;
            this.btnDodajMaterijal.Click += new System.EventHandler(this.btnDodajMaterijal_Click);
            // 
            // FrmNoviRadniNalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPodnesi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmNoviRadniNalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi radni nalog";
            this.Load += new System.EventHandler(this.FrmNoviRadniNalog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPodnesi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQRKod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.DateTimePicker dtpDatumStvaranja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRadnik;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvMaterijali;
        private System.Windows.Forms.Button btnDodajMaterijal;
        private System.Windows.Forms.ComboBox cmbMaterijali;
    }
}