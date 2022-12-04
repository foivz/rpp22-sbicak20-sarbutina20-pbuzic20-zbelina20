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
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbUsluge = new System.Windows.Forms.ComboBox();
            this.txtRoba = new System.Windows.Forms.TextBox();
            this.txtDatumIzrade = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtJedinicnaCijena = new System.Windows.Forms.TextBox();
            this.txtUkupnaCijena = new System.Windows.Forms.TextBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStavke
            // 
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(363, 39);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.Size = new System.Drawing.Size(936, 263);
            this.dgvStavke.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(133, 254);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(125, 52);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(1174, 308);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(125, 52);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usluga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Roba:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum izrade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Količina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Jedinična cijena:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ukupna cijena:";
            // 
            // cmbUsluge
            // 
            this.cmbUsluge.FormattingEnabled = true;
            this.cmbUsluge.Location = new System.Drawing.Point(103, 39);
            this.cmbUsluge.Name = "cmbUsluge";
            this.cmbUsluge.Size = new System.Drawing.Size(241, 21);
            this.cmbUsluge.TabIndex = 9;
            // 
            // txtRoba
            // 
            this.txtRoba.Location = new System.Drawing.Point(103, 124);
            this.txtRoba.Name = "txtRoba";
            this.txtRoba.Size = new System.Drawing.Size(241, 20);
            this.txtRoba.TabIndex = 10;
            // 
            // txtDatumIzrade
            // 
            this.txtDatumIzrade.Location = new System.Drawing.Point(103, 150);
            this.txtDatumIzrade.Name = "txtDatumIzrade";
            this.txtDatumIzrade.Size = new System.Drawing.Size(241, 20);
            this.txtDatumIzrade.TabIndex = 11;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(103, 176);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(241, 20);
            this.txtKolicina.TabIndex = 12;
            // 
            // txtJedinicnaCijena
            // 
            this.txtJedinicnaCijena.Location = new System.Drawing.Point(103, 199);
            this.txtJedinicnaCijena.Name = "txtJedinicnaCijena";
            this.txtJedinicnaCijena.Size = new System.Drawing.Size(240, 20);
            this.txtJedinicnaCijena.TabIndex = 13;
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.Location = new System.Drawing.Point(102, 225);
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.Size = new System.Drawing.Size(241, 20);
            this.txtUkupnaCijena.TabIndex = 14;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(1146, 419);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(189, 52);
            this.btnNatrag.TabIndex = 15;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            // 
            // FrmDodajStavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 483);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.txtUkupnaCijena);
            this.Controls.Add(this.txtJedinicnaCijena);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtDatumIzrade);
            this.Controls.Add(this.txtRoba);
            this.Controls.Add(this.cmbUsluge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvStavke);
            this.Name = "FrmDodajStavke";
            this.Text = "Dodavanje stavki na račun";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbUsluge;
        private System.Windows.Forms.TextBox txtRoba;
        private System.Windows.Forms.TextBox txtDatumIzrade;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtJedinicnaCijena;
        private System.Windows.Forms.TextBox txtUkupnaCijena;
        private System.Windows.Forms.Button btnNatrag;
    }
}