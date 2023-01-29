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
            this.labelUsluga = new System.Windows.Forms.Label();
            this.labelRoba = new System.Windows.Forms.Label();
            this.labelDatumIzrade = new System.Windows.Forms.Label();
            this.labelKolicina = new System.Windows.Forms.Label();
            this.labelJedinicnaCijena = new System.Windows.Forms.Label();
            this.cmbUsluge = new System.Windows.Forms.ComboBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtJedinicnaCijena = new System.Windows.Forms.TextBox();
            this.dtpDatumIzrade = new System.Windows.Forms.DateTimePicker();
            this.cmbRoba = new System.Windows.Forms.ComboBox();
            this.txtKolikoRobePoJedinici = new System.Windows.Forms.TextBox();
            this.labelRobaPoJedinici = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtJedinicaMjere = new System.Windows.Forms.TextBox();
            this.labelJedinicaMjere = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDodaj)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStavkeDodaj
            // 
            this.dgvStavkeDodaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeDodaj.Location = new System.Drawing.Point(536, 47);
            this.dgvStavkeDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStavkeDodaj.Name = "dgvStavkeDodaj";
            this.dgvStavkeDodaj.ReadOnly = true;
            this.dgvStavkeDodaj.RowHeadersWidth = 51;
            this.dgvStavkeDodaj.Size = new System.Drawing.Size(1196, 324);
            this.dgvStavkeDodaj.TabIndex = 0;
            // 
            // labelUsluga
            // 
            this.labelUsluga.AutoSize = true;
            this.labelUsluga.Location = new System.Drawing.Point(121, 50);
            this.labelUsluga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsluga.Name = "labelUsluga";
            this.labelUsluga.Size = new System.Drawing.Size(53, 16);
            this.labelUsluga.TabIndex = 3;
            this.labelUsluga.Text = "Usluga:";
            // 
            // labelRoba
            // 
            this.labelRoba.AutoSize = true;
            this.labelRoba.Location = new System.Drawing.Point(129, 122);
            this.labelRoba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoba.Name = "labelRoba";
            this.labelRoba.Size = new System.Drawing.Size(44, 16);
            this.labelRoba.TabIndex = 4;
            this.labelRoba.Text = "Roba:";
            // 
            // labelDatumIzrade
            // 
            this.labelDatumIzrade.AutoSize = true;
            this.labelDatumIzrade.Location = new System.Drawing.Point(83, 187);
            this.labelDatumIzrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDatumIzrade.Name = "labelDatumIzrade";
            this.labelDatumIzrade.Size = new System.Drawing.Size(89, 16);
            this.labelDatumIzrade.TabIndex = 5;
            this.labelDatumIzrade.Text = "Datum izrade:";
            // 
            // labelKolicina
            // 
            this.labelKolicina.AutoSize = true;
            this.labelKolicina.Location = new System.Drawing.Point(84, 250);
            this.labelKolicina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKolicina.Name = "labelKolicina";
            this.labelKolicina.Size = new System.Drawing.Size(85, 16);
            this.labelKolicina.TabIndex = 6;
            this.labelKolicina.Text = "Količina u kg:";
            // 
            // labelJedinicnaCijena
            // 
            this.labelJedinicnaCijena.AutoSize = true;
            this.labelJedinicnaCijena.Location = new System.Drawing.Point(64, 281);
            this.labelJedinicnaCijena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJedinicnaCijena.Name = "labelJedinicnaCijena";
            this.labelJedinicnaCijena.Size = new System.Drawing.Size(107, 16);
            this.labelJedinicnaCijena.TabIndex = 7;
            this.labelJedinicnaCijena.Text = "Jedinična cijena:";
            // 
            // cmbUsluge
            // 
            this.cmbUsluge.FormattingEnabled = true;
            this.cmbUsluge.Location = new System.Drawing.Point(187, 47);
            this.cmbUsluge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUsluge.Name = "cmbUsluge";
            this.cmbUsluge.Size = new System.Drawing.Size(320, 24);
            this.cmbUsluge.TabIndex = 9;
            this.cmbUsluge.SelectedIndexChanged += new System.EventHandler(this.cmbUsluge_SelectedIndexChanged);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(185, 246);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(320, 22);
            this.txtKolicina.TabIndex = 12;
            // 
            // txtJedinicnaCijena
            // 
            this.txtJedinicnaCijena.Location = new System.Drawing.Point(185, 277);
            this.txtJedinicnaCijena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJedinicnaCijena.Name = "txtJedinicnaCijena";
            this.txtJedinicnaCijena.Size = new System.Drawing.Size(321, 22);
            this.txtJedinicnaCijena.TabIndex = 13;
            // 
            // dtpDatumIzrade
            // 
            this.dtpDatumIzrade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDatumIzrade.Location = new System.Drawing.Point(187, 183);
            this.dtpDatumIzrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDatumIzrade.Name = "dtpDatumIzrade";
            this.dtpDatumIzrade.Size = new System.Drawing.Size(319, 22);
            this.dtpDatumIzrade.TabIndex = 16;
            // 
            // cmbRoba
            // 
            this.cmbRoba.FormattingEnabled = true;
            this.cmbRoba.Location = new System.Drawing.Point(185, 118);
            this.cmbRoba.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRoba.Name = "cmbRoba";
            this.cmbRoba.Size = new System.Drawing.Size(320, 24);
            this.cmbRoba.TabIndex = 17;
            this.cmbRoba.SelectedIndexChanged += new System.EventHandler(this.cmbRoba_SelectedIndexChanged);
            // 
            // txtKolikoRobePoJedinici
            // 
            this.txtKolikoRobePoJedinici.Location = new System.Drawing.Point(185, 151);
            this.txtKolikoRobePoJedinici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKolikoRobePoJedinici.Name = "txtKolikoRobePoJedinici";
            this.txtKolikoRobePoJedinici.Size = new System.Drawing.Size(320, 22);
            this.txtKolikoRobePoJedinici.TabIndex = 19;
            // 
            // labelRobaPoJedinici
            // 
            this.labelRobaPoJedinici.AutoSize = true;
            this.labelRobaPoJedinici.Location = new System.Drawing.Point(29, 155);
            this.labelRobaPoJedinici.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRobaPoJedinici.Name = "labelRobaPoJedinici";
            this.labelRobaPoJedinici.Size = new System.Drawing.Size(142, 16);
            this.labelRobaPoJedinici.TabIndex = 18;
            this.labelRobaPoJedinici.Text = "Koliko robe po jedinici:";
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNatrag.Location = new System.Drawing.Point(1584, 530);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(196, 49);
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
            this.btnDodaj.Location = new System.Drawing.Point(240, 309);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(196, 49);
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
            this.btnObrisi.Location = new System.Drawing.Point(1536, 379);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(196, 49);
            this.btnObrisi.TabIndex = 22;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // txtJedinicaMjere
            // 
            this.txtJedinicaMjere.Location = new System.Drawing.Point(185, 215);
            this.txtJedinicaMjere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJedinicaMjere.Name = "txtJedinicaMjere";
            this.txtJedinicaMjere.ReadOnly = true;
            this.txtJedinicaMjere.Size = new System.Drawing.Size(320, 22);
            this.txtJedinicaMjere.TabIndex = 24;
            // 
            // labelJedinicaMjere
            // 
            this.labelJedinicaMjere.AutoSize = true;
            this.labelJedinicaMjere.Location = new System.Drawing.Point(76, 219);
            this.labelJedinicaMjere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJedinicaMjere.Name = "labelJedinicaMjere";
            this.labelJedinicaMjere.Size = new System.Drawing.Size(98, 16);
            this.labelJedinicaMjere.TabIndex = 23;
            this.labelJedinicaMjere.Text = "Jedinica mjere:";
            // 
            // FrmDodajStavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1796, 594);
            this.Controls.Add(this.txtJedinicaMjere);
            this.Controls.Add(this.labelJedinicaMjere);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.txtKolikoRobePoJedinici);
            this.Controls.Add(this.labelRobaPoJedinici);
            this.Controls.Add(this.cmbRoba);
            this.Controls.Add(this.dtpDatumIzrade);
            this.Controls.Add(this.txtJedinicnaCijena);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.cmbUsluge);
            this.Controls.Add(this.labelJedinicnaCijena);
            this.Controls.Add(this.labelKolicina);
            this.Controls.Add(this.labelDatumIzrade);
            this.Controls.Add(this.labelRoba);
            this.Controls.Add(this.labelUsluga);
            this.Controls.Add(this.dgvStavkeDodaj);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDodajStavke";
            this.Text = "Dodavanje stavki na račun";
            this.Load += new System.EventHandler(this.FrmDodajStavke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeDodaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStavkeDodaj;
        private System.Windows.Forms.Label labelUsluga;
        private System.Windows.Forms.Label labelRoba;
        private System.Windows.Forms.Label labelDatumIzrade;
        private System.Windows.Forms.Label labelKolicina;
        private System.Windows.Forms.Label labelJedinicnaCijena;
        private System.Windows.Forms.ComboBox cmbUsluge;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtJedinicnaCijena;
        private System.Windows.Forms.DateTimePicker dtpDatumIzrade;
        private System.Windows.Forms.ComboBox cmbRoba;
        private System.Windows.Forms.TextBox txtKolikoRobePoJedinici;
        private System.Windows.Forms.Label labelRobaPoJedinici;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtJedinicaMjere;
        private System.Windows.Forms.Label labelJedinicaMjere;
    }
}