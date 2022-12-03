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
            this.dgvIzvjestaji.Location = new System.Drawing.Point(9, 39);
            this.dgvIzvjestaji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvIzvjestaji.Name = "dgvIzvjestaji";
            this.dgvIzvjestaji.RowHeadersWidth = 51;
            this.dgvIzvjestaji.RowTemplate.Height = 24;
            this.dgvIzvjestaji.Size = new System.Drawing.Size(434, 289);
            this.dgvIzvjestaji.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis izvještaja";
            // 
            // btnIzvjestajRadnihNaloga
            // 
            this.btnIzvjestajRadnihNaloga.Location = new System.Drawing.Point(469, 39);
            this.btnIzvjestajRadnihNaloga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzvjestajRadnihNaloga.Name = "btnIzvjestajRadnihNaloga";
            this.btnIzvjestajRadnihNaloga.Size = new System.Drawing.Size(112, 37);
            this.btnIzvjestajRadnihNaloga.TabIndex = 3;
            this.btnIzvjestajRadnihNaloga.Text = "Izrada izvještaja radnih naloga";
            this.btnIzvjestajRadnihNaloga.UseVisualStyleBackColor = true;
            // 
            // btnIzvjestajKlijenata
            // 
            this.btnIzvjestajKlijenata.Location = new System.Drawing.Point(469, 99);
            this.btnIzvjestajKlijenata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzvjestajKlijenata.Name = "btnIzvjestajKlijenata";
            this.btnIzvjestajKlijenata.Size = new System.Drawing.Size(112, 37);
            this.btnIzvjestajKlijenata.TabIndex = 4;
            this.btnIzvjestajKlijenata.Text = "Izrada klijentskih izvještaja";
            this.btnIzvjestajKlijenata.UseVisualStyleBackColor = true;
            // 
            // btnDetaljiIzvjestaja
            // 
            this.btnDetaljiIzvjestaja.Location = new System.Drawing.Point(469, 158);
            this.btnDetaljiIzvjestaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDetaljiIzvjestaja.Name = "btnDetaljiIzvjestaja";
            this.btnDetaljiIzvjestaja.Size = new System.Drawing.Size(112, 37);
            this.btnDetaljiIzvjestaja.TabIndex = 5;
            this.btnDetaljiIzvjestaja.Text = "Detalji";
            this.btnDetaljiIzvjestaja.UseVisualStyleBackColor = true;
            // 
            // btbBrisanje
            // 
            this.btbBrisanje.Location = new System.Drawing.Point(469, 215);
            this.btbBrisanje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btbBrisanje.Name = "btbBrisanje";
            this.btbBrisanje.Size = new System.Drawing.Size(112, 37);
            this.btbBrisanje.TabIndex = 6;
            this.btbBrisanje.Text = "Brisanje";
            this.btbBrisanje.UseVisualStyleBackColor = true;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(469, 319);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(112, 37);
            this.btnNatrag.TabIndex = 7;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            // 
            // FrmPopisIzvjestaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btbBrisanje);
            this.Controls.Add(this.btnDetaljiIzvjestaja);
            this.Controls.Add(this.btnIzvjestajKlijenata);
            this.Controls.Add(this.btnIzvjestajRadnihNaloga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIzvjestaji);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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