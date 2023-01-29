namespace ZMGDesktop
{
    partial class FrmPrimka
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
            this.btnZatvori = new System.Windows.Forms.Button();
            this.labelNazivZaprimljenogMaterijala = new System.Windows.Forms.Label();
            this.labelKolicnaZaprimljenogMaterijala = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtMjernaJedinica = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.labelDatum = new System.Windows.Forms.Label();
            this.btnPohrani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatvori.ForeColor = System.Drawing.Color.White;
            this.btnZatvori.Location = new System.Drawing.Point(42, 292);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(78, 37);
            this.btnZatvori.TabIndex = 0;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // labelNazivZaprimljenogMaterijala
            // 
            this.labelNazivZaprimljenogMaterijala.AutoSize = true;
            this.labelNazivZaprimljenogMaterijala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazivZaprimljenogMaterijala.Location = new System.Drawing.Point(40, 34);
            this.labelNazivZaprimljenogMaterijala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNazivZaprimljenogMaterijala.Name = "labelNazivZaprimljenogMaterijala";
            this.labelNazivZaprimljenogMaterijala.Size = new System.Drawing.Size(192, 17);
            this.labelNazivZaprimljenogMaterijala.TabIndex = 1;
            this.labelNazivZaprimljenogMaterijala.Text = "Naziv zaprimljenog materijala";
            // 
            // labelKolicnaZaprimljenogMaterijala
            // 
            this.labelKolicnaZaprimljenogMaterijala.AutoSize = true;
            this.labelKolicnaZaprimljenogMaterijala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKolicnaZaprimljenogMaterijala.Location = new System.Drawing.Point(40, 85);
            this.labelKolicnaZaprimljenogMaterijala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKolicnaZaprimljenogMaterijala.Name = "labelKolicnaZaprimljenogMaterijala";
            this.labelKolicnaZaprimljenogMaterijala.Size = new System.Drawing.Size(206, 17);
            this.labelKolicnaZaprimljenogMaterijala.TabIndex = 2;
            this.labelKolicnaZaprimljenogMaterijala.Text = "Količina zaprimljenog materijala";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(292, 34);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.Size = new System.Drawing.Size(147, 23);
            this.txtNaziv.TabIndex = 4;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKolicina.Location = new System.Drawing.Point(292, 85);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.ReadOnly = true;
            this.txtKolicina.Size = new System.Drawing.Size(120, 23);
            this.txtKolicina.TabIndex = 5;
            // 
            // txtMjernaJedinica
            // 
            this.txtMjernaJedinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMjernaJedinica.Location = new System.Drawing.Point(422, 85);
            this.txtMjernaJedinica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMjernaJedinica.Name = "txtMjernaJedinica";
            this.txtMjernaJedinica.ReadOnly = true;
            this.txtMjernaJedinica.Size = new System.Drawing.Size(60, 23);
            this.txtMjernaJedinica.TabIndex = 6;
            // 
            // txtDatum
            // 
            this.txtDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatum.Location = new System.Drawing.Point(292, 144);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(147, 23);
            this.txtDatum.TabIndex = 7;
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatum.Location = new System.Drawing.Point(40, 144);
            this.labelDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(49, 17);
            this.labelDatum.TabIndex = 3;
            this.labelDatum.Text = "Datum";
            // 
            // btnPohrani
            // 
            this.btnPohrani.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPohrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPohrani.ForeColor = System.Drawing.Color.White;
            this.btnPohrani.Location = new System.Drawing.Point(159, 292);
            this.btnPohrani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPohrani.Name = "btnPohrani";
            this.btnPohrani.Size = new System.Drawing.Size(178, 37);
            this.btnPohrani.TabIndex = 8;
            this.btnPohrani.Text = "Pohrani datoteku lokalno";
            this.btnPohrani.UseVisualStyleBackColor = false;
            this.btnPohrani.Click += new System.EventHandler(this.btnPohrani_Click);
            // 
            // FrmPrimka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnPohrani);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtMjernaJedinica);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelKolicnaZaprimljenogMaterijala);
            this.Controls.Add(this.labelNazivZaprimljenogMaterijala);
            this.Controls.Add(this.btnZatvori);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPrimka";
            this.Text = "FrmPrimka";
            this.Load += new System.EventHandler(this.FrmPrimka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label labelNazivZaprimljenogMaterijala;
        private System.Windows.Forms.Label labelKolicnaZaprimljenogMaterijala;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtMjernaJedinica;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Button btnPohrani;
    }
}