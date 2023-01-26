namespace ZMGDesktop
{
    partial class FrmDodajStavke
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
            this.dgvStavkeDodaj = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUsluge = new System.Windows.Forms.ComboBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtJedinicnaCijena = new System.Windows.Forms.TextBox();
            this.dtpDatumIzrade = new System.Windows.Forms.DateTimePicker();
            this.cmbRoba = new System.Windows.Forms.ComboBox();
            this.txtKolikoRobePoJedinici = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtJedinicaMjere = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDodaj)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStavkeDodaj
            // 
            this.dgvStavkeDodaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeDodaj.Location = new System.Drawing.Point(402, 39);
            this.dgvStavkeDodaj.Name = "dgvStavkeDodaj";
            this.dgvStavkeDodaj.Size = new System.Drawing.Size(897, 263);
            this.dgvStavkeDodaj.TabIndex = 0;
            this.dgvStavkeDodaj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStavkeDodaj_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usluga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Roba:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum izrade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Količina u kg:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Jedinična cijena:";
            // 
            // cmbUsluge
            // 
            this.cmbUsluge.FormattingEnabled = true;
            this.cmbUsluge.Location = new System.Drawing.Point(140, 38);
            this.cmbUsluge.Name = "cmbUsluge";
            this.cmbUsluge.Size = new System.Drawing.Size(241, 21);
            this.cmbUsluge.TabIndex = 9;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(139, 200);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(241, 20);
            this.txtKolicina.TabIndex = 12;
            // 
            // txtJedinicnaCijena
            // 
            this.txtJedinicnaCijena.Location = new System.Drawing.Point(139, 223);
            this.txtJedinicnaCijena.Name = "txtJedinicnaCijena";
            this.txtJedinicnaCijena.Size = new System.Drawing.Size(240, 20);
            this.txtJedinicnaCijena.TabIndex = 13;
            // 
            // dtpDatumIzrade
            // 
            this.dtpDatumIzrade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDatumIzrade.Location = new System.Drawing.Point(140, 149);
            this.dtpDatumIzrade.Name = "dtpDatumIzrade";
            this.dtpDatumIzrade.Size = new System.Drawing.Size(240, 20);
            this.dtpDatumIzrade.TabIndex = 16;
            // 
            // cmbRoba
            // 
            this.cmbRoba.FormattingEnabled = true;
            this.cmbRoba.Location = new System.Drawing.Point(139, 96);
            this.cmbRoba.Name = "cmbRoba";
            this.cmbRoba.Size = new System.Drawing.Size(241, 21);
            this.cmbRoba.TabIndex = 17;
            // 
            // txtKolikoRobePoJedinici
            // 
            this.txtKolikoRobePoJedinici.Location = new System.Drawing.Point(139, 123);
            this.txtKolikoRobePoJedinici.Name = "txtKolikoRobePoJedinici";
            this.txtKolikoRobePoJedinici.Size = new System.Drawing.Size(241, 20);
            this.txtKolikoRobePoJedinici.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Koliko robe po jedinici:";
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNatrag.Location = new System.Drawing.Point(1188, 431);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(147, 40);
            this.btnNatrag.TabIndex = 20;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click_1);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodaj.Location = new System.Drawing.Point(168, 287);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(147, 40);
            this.btnDodaj.TabIndex = 21;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnObrisi.Location = new System.Drawing.Point(1152, 308);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(147, 40);
            this.btnObrisi.TabIndex = 22;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // txtJedinicaMjere
            // 
            this.txtJedinicaMjere.Location = new System.Drawing.Point(139, 175);
            this.txtJedinicaMjere.Name = "txtJedinicaMjere";
            this.txtJedinicaMjere.Size = new System.Drawing.Size(241, 20);
            this.txtJedinicaMjere.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Jedinica mjere:";
            // 
            // FrmDodajStavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 483);
            this.Controls.Add(this.txtJedinicaMjere);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.txtKolikoRobePoJedinici);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbRoba);
            this.Controls.Add(this.dtpDatumIzrade);
            this.Controls.Add(this.txtJedinicnaCijena);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.cmbUsluge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStavkeDodaj);
            this.Name = "FrmDodajStavke";
            this.Text = "Dodavanje stavki na račun";
            this.Load += new System.EventHandler(this.FrmDodajStavke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDodaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStavkeDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUsluge;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtJedinicnaCijena;
        private System.Windows.Forms.DateTimePicker dtpDatumIzrade;
        private System.Windows.Forms.ComboBox cmbRoba;
        private System.Windows.Forms.TextBox txtKolikoRobePoJedinici;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtJedinicaMjere;
        private System.Windows.Forms.Label label8;
    }
}