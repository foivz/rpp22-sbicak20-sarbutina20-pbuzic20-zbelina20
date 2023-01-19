namespace ZMGDesktop
{
    partial class FrmPopisIzvjestaja
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
            this.dgvIzvjestaji = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzvjestajRadnihNaloga = new System.Windows.Forms.Button();
            this.btnIzvjestajKlijenata = new System.Windows.Forms.Button();
            this.btnDetaljiIzvjestaja = new System.Windows.Forms.Button();
            this.btbBrisanje = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaji)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIzvjestaji
            // 
            this.dgvIzvjestaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestaji.Location = new System.Drawing.Point(12, 48);
            this.dgvIzvjestaji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvIzvjestaji.Name = "dgvIzvjestaji";
            this.dgvIzvjestaji.RowHeadersWidth = 51;
            this.dgvIzvjestaji.RowTemplate.Height = 24;
            this.dgvIzvjestaji.Size = new System.Drawing.Size(579, 356);
            this.dgvIzvjestaji.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis izvještaja";
            // 
            // btnIzvjestajRadnihNaloga
            // 
            this.btnIzvjestajRadnihNaloga.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzvjestajRadnihNaloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzvjestajRadnihNaloga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzvjestajRadnihNaloga.Location = new System.Drawing.Point(625, 48);
            this.btnIzvjestajRadnihNaloga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzvjestajRadnihNaloga.Name = "btnIzvjestajRadnihNaloga";
            this.btnIzvjestajRadnihNaloga.Size = new System.Drawing.Size(149, 46);
            this.btnIzvjestajRadnihNaloga.TabIndex = 3;
            this.btnIzvjestajRadnihNaloga.Text = "Izrada izvještaja radnih naloga";
            this.btnIzvjestajRadnihNaloga.UseVisualStyleBackColor = false;
            // 
            // btnIzvjestajKlijenata
            // 
            this.btnIzvjestajKlijenata.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzvjestajKlijenata.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzvjestajKlijenata.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzvjestajKlijenata.Location = new System.Drawing.Point(625, 122);
            this.btnIzvjestajKlijenata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzvjestajKlijenata.Name = "btnIzvjestajKlijenata";
            this.btnIzvjestajKlijenata.Size = new System.Drawing.Size(149, 46);
            this.btnIzvjestajKlijenata.TabIndex = 4;
            this.btnIzvjestajKlijenata.Text = "Izrada klijentskih izvještaja";
            this.btnIzvjestajKlijenata.UseVisualStyleBackColor = false;
            this.btnIzvjestajKlijenata.Click += new System.EventHandler(this.btnIzvjestajKlijenata_Click);
            // 
            // btnDetaljiIzvjestaja
            // 
            this.btnDetaljiIzvjestaja.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDetaljiIzvjestaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetaljiIzvjestaja.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDetaljiIzvjestaja.Location = new System.Drawing.Point(625, 194);
            this.btnDetaljiIzvjestaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetaljiIzvjestaja.Name = "btnDetaljiIzvjestaja";
            this.btnDetaljiIzvjestaja.Size = new System.Drawing.Size(149, 46);
            this.btnDetaljiIzvjestaja.TabIndex = 5;
            this.btnDetaljiIzvjestaja.Text = "Detalji";
            this.btnDetaljiIzvjestaja.UseVisualStyleBackColor = false;
            // 
            // btbBrisanje
            // 
            this.btbBrisanje.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btbBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btbBrisanje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btbBrisanje.Location = new System.Drawing.Point(625, 265);
            this.btbBrisanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btbBrisanje.Name = "btbBrisanje";
            this.btbBrisanje.Size = new System.Drawing.Size(149, 46);
            this.btbBrisanje.TabIndex = 6;
            this.btbBrisanje.Text = "Brisanje";
            this.btbBrisanje.UseVisualStyleBackColor = false;
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNatrag.Location = new System.Drawing.Point(625, 393);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(149, 46);
            this.btnNatrag.TabIndex = 7;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            // 
            // FrmPopisIzvjestaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btbBrisanje);
            this.Controls.Add(this.btnDetaljiIzvjestaja);
            this.Controls.Add(this.btnIzvjestajKlijenata);
            this.Controls.Add(this.btnIzvjestajRadnihNaloga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIzvjestaji);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPopisIzvjestaja";
            this.Text = "Izvještaji";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIzvjestaji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzvjestajRadnihNaloga;
        private System.Windows.Forms.Button btnIzvjestajKlijenata;
        private System.Windows.Forms.Button btnDetaljiIzvjestaja;
        private System.Windows.Forms.Button btbBrisanje;
        private System.Windows.Forms.Button btnNatrag;
    }
}