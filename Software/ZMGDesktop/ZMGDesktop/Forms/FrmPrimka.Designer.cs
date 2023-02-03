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
            this.btnPohrani = new System.Windows.Forms.Button();
            this.txtMjernaJedinica = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelKolicnaZaprimljenogMaterijala = new System.Windows.Forms.Label();
            this.labelNazivZaprimljenogMaterijala = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatvori.ForeColor = System.Drawing.Color.White;
            this.btnZatvori.Location = new System.Drawing.Point(56, 359);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(104, 46);
            this.btnZatvori.TabIndex = 0;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnPohrani
            // 
            this.btnPohrani.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPohrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPohrani.ForeColor = System.Drawing.Color.White;
            this.btnPohrani.Location = new System.Drawing.Point(212, 359);
            this.btnPohrani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPohrani.Name = "btnPohrani";
            this.btnPohrani.Size = new System.Drawing.Size(237, 46);
            this.btnPohrani.TabIndex = 8;
            this.btnPohrani.Text = "Pohrani datoteku lokalno";
            this.btnPohrani.UseVisualStyleBackColor = false;
            this.btnPohrani.Click += new System.EventHandler(this.btnPohrani_Click);
            // 
            // txtMjernaJedinica
            // 
            this.txtMjernaJedinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMjernaJedinica.Location = new System.Drawing.Point(563, 105);
            this.txtMjernaJedinica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMjernaJedinica.Name = "txtMjernaJedinica";
            this.txtMjernaJedinica.ReadOnly = true;
            this.txtMjernaJedinica.Size = new System.Drawing.Size(79, 26);
            this.txtMjernaJedinica.TabIndex = 6;
            // 
            // txtDatum
            // 
            this.txtDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatum.Location = new System.Drawing.Point(389, 177);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(195, 26);
            this.txtDatum.TabIndex = 7;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKolicina.Location = new System.Drawing.Point(389, 105);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.ReadOnly = true;
            this.txtKolicina.Size = new System.Drawing.Size(159, 26);
            this.txtKolicina.TabIndex = 5;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(389, 42);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.Size = new System.Drawing.Size(195, 26);
            this.txtNaziv.TabIndex = 4;
            this.txtNaziv.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatum.Location = new System.Drawing.Point(53, 177);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(59, 20);
            this.labelDatum.TabIndex = 3;
            this.labelDatum.Text = "Datum";
            // 
            // labelKolicnaZaprimljenogMaterijala
            // 
            this.labelKolicnaZaprimljenogMaterijala.AutoSize = true;
            this.labelKolicnaZaprimljenogMaterijala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKolicnaZaprimljenogMaterijala.Location = new System.Drawing.Point(53, 105);
            this.labelKolicnaZaprimljenogMaterijala.Name = "labelKolicnaZaprimljenogMaterijala";
            this.labelKolicnaZaprimljenogMaterijala.Size = new System.Drawing.Size(246, 20);
            this.labelKolicnaZaprimljenogMaterijala.TabIndex = 2;
            this.labelKolicnaZaprimljenogMaterijala.Text = "Količina zaprimljenog materijala";
            // 
            // labelNazivZaprimljenogMaterijala
            // 
            this.labelNazivZaprimljenogMaterijala.AutoSize = true;
            this.labelNazivZaprimljenogMaterijala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazivZaprimljenogMaterijala.Location = new System.Drawing.Point(53, 42);
            this.labelNazivZaprimljenogMaterijala.Name = "labelNazivZaprimljenogMaterijala";
            this.labelNazivZaprimljenogMaterijala.Size = new System.Drawing.Size(229, 20);
            this.labelNazivZaprimljenogMaterijala.TabIndex = 1;
            this.labelNazivZaprimljenogMaterijala.Text = "Naziv zaprimljenog materijala";
            // 
            // FrmPrimka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPohrani);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtMjernaJedinica);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelKolicnaZaprimljenogMaterijala);
            this.Controls.Add(this.labelNazivZaprimljenogMaterijala);
            this.Controls.Add(this.btnZatvori);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrimka";
            this.Text = "FrmPrimka";
            this.Load += new System.EventHandler(this.FrmPrimka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnPohrani;
        private System.Windows.Forms.TextBox txtMjernaJedinica;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelKolicnaZaprimljenogMaterijala;
        private System.Windows.Forms.Label labelNazivZaprimljenogMaterijala;
    }
}