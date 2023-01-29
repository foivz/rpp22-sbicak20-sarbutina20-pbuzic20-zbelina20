namespace ZMGDesktop
{
    partial class FrmDodajMaterijal
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cmbMjernaJedinica = new System.Windows.Forms.ComboBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.labelKolicina = new System.Windows.Forms.Label();
            this.labelCijenaPoJedinici = new System.Windows.Forms.Label();
            this.labelOpasnoPoZivot = new System.Windows.Forms.Label();
            this.labelOpisMaterijala = new System.Windows.Forms.Label();
            this.btnDodajMaterijal = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.NumericUpDown();
            this.txtCijena = new System.Windows.Forms.NumericUpDown();
            this.txtOpasno = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(27, 43);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(128, 23);
            this.txtNaziv.TabIndex = 0;
            // 
            // cmbMjernaJedinica
            // 
            this.cmbMjernaJedinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMjernaJedinica.FormattingEnabled = true;
            this.cmbMjernaJedinica.Location = new System.Drawing.Point(185, 114);
            this.cmbMjernaJedinica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMjernaJedinica.Name = "cmbMjernaJedinica";
            this.cmbMjernaJedinica.Size = new System.Drawing.Size(92, 24);
            this.cmbMjernaJedinica.TabIndex = 3;
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpis.Location = new System.Drawing.Point(328, 43);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(233, 89);
            this.txtOpis.TabIndex = 4;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(24, 17);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(43, 17);
            this.lblNaziv.TabIndex = 6;
            this.lblNaziv.Text = "Naziv";
            // 
            // labelKolicina
            // 
            this.labelKolicina.AutoSize = true;
            this.labelKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKolicina.Location = new System.Drawing.Point(24, 79);
            this.labelKolicina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKolicina.Name = "labelKolicina";
            this.labelKolicina.Size = new System.Drawing.Size(57, 17);
            this.labelKolicina.TabIndex = 7;
            this.labelKolicina.Text = "Količina";
            // 
            // labelCijenaPoJedinici
            // 
            this.labelCijenaPoJedinici.AutoSize = true;
            this.labelCijenaPoJedinici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCijenaPoJedinici.Location = new System.Drawing.Point(24, 151);
            this.labelCijenaPoJedinici.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCijenaPoJedinici.Name = "labelCijenaPoJedinici";
            this.labelCijenaPoJedinici.Size = new System.Drawing.Size(114, 17);
            this.labelCijenaPoJedinici.TabIndex = 8;
            this.labelCijenaPoJedinici.Text = "Cijena po jedinici";
            // 
            // labelOpasnoPoZivot
            // 
            this.labelOpasnoPoZivot.AutoSize = true;
            this.labelOpasnoPoZivot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpasnoPoZivot.Location = new System.Drawing.Point(326, 151);
            this.labelOpasnoPoZivot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOpasnoPoZivot.Name = "labelOpasnoPoZivot";
            this.labelOpasnoPoZivot.Size = new System.Drawing.Size(184, 17);
            this.labelOpasnoPoZivot.TabIndex = 9;
            this.labelOpasnoPoZivot.Text = "Opasno po život (true/false)";
            // 
            // labelOpisMaterijala
            // 
            this.labelOpisMaterijala.AutoSize = true;
            this.labelOpisMaterijala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpisMaterijala.Location = new System.Drawing.Point(326, 17);
            this.labelOpisMaterijala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOpisMaterijala.Name = "labelOpisMaterijala";
            this.labelOpisMaterijala.Size = new System.Drawing.Size(102, 17);
            this.labelOpisMaterijala.TabIndex = 10;
            this.labelOpisMaterijala.Text = "Opis materijala";
            // 
            // btnDodajMaterijal
            // 
            this.btnDodajMaterijal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodajMaterijal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajMaterijal.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDodajMaterijal.Location = new System.Drawing.Point(185, 301);
            this.btnDodajMaterijal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajMaterijal.Name = "btnDodajMaterijal";
            this.btnDodajMaterijal.Size = new System.Drawing.Size(127, 45);
            this.btnDodajMaterijal.TabIndex = 14;
            this.btnDodajMaterijal.Text = "Dodaj materijal";
            this.btnDodajMaterijal.UseVisualStyleBackColor = false;
            this.btnDodajMaterijal.Click += new System.EventHandler(this.btnDodajMaterijal_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNatrag.Location = new System.Drawing.Point(27, 301);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(127, 45);
            this.btnNatrag.TabIndex = 15;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(27, 114);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKolicina.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(127, 20);
            this.txtKolicina.TabIndex = 16;
            this.txtKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(27, 188);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCijena.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtCijena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(127, 20);
            this.txtCijena.TabIndex = 17;
            this.txtCijena.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtOpasno
            // 
            this.txtOpasno.AutoSize = true;
            this.txtOpasno.Location = new System.Drawing.Point(328, 188);
            this.txtOpasno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpasno.Name = "txtOpasno";
            this.txtOpasno.Size = new System.Drawing.Size(129, 17);
            this.txtOpasno.TabIndex = 18;
            this.txtOpasno.Text = "Označi ako je opasno";
            this.txtOpasno.UseVisualStyleBackColor = true;
            // 
            // FrmDodajMaterijal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtOpasno);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnDodajMaterijal);
            this.Controls.Add(this.labelOpisMaterijala);
            this.Controls.Add(this.labelOpasnoPoZivot);
            this.Controls.Add(this.labelCijenaPoJedinici);
            this.Controls.Add(this.labelKolicina);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.cmbMjernaJedinica);
            this.Controls.Add(this.txtNaziv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDodajMaterijal";
            this.Text = "FrmDodaj";
            this.Load += new System.EventHandler(this.FrmDodajMaterijal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCijena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cmbMjernaJedinica;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label labelKolicina;
        private System.Windows.Forms.Label labelCijenaPoJedinici;
        private System.Windows.Forms.Label labelOpasnoPoZivot;
        private System.Windows.Forms.Label labelOpisMaterijala;
        private System.Windows.Forms.Button btnDodajMaterijal;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.NumericUpDown txtKolicina;
        private System.Windows.Forms.NumericUpDown txtCijena;
        private System.Windows.Forms.CheckBox txtOpasno;
    }
}