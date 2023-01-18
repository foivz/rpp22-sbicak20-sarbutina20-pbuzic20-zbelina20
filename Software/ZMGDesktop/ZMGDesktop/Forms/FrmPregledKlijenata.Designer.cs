namespace ZMGDesktop
{
    partial class FrmPregledKlijenata
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
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajKlijenta = new System.Windows.Forms.Button();
            this.btnIzbrisiKlijenta = new System.Windows.Forms.Button();
            this.btnUrediKlijenta = new System.Windows.Forms.Button();
            this.btnDetaljiKlijenta = new System.Windows.Forms.Button();
            this.btnUveziKlijenta = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Location = new System.Drawing.Point(12, 58);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.RowHeadersWidth = 51;
            this.dgvKlijenti.RowTemplate.Height = 24;
            this.dgvKlijenti.Size = new System.Drawing.Size(552, 362);
            this.dgvKlijenti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregled klijenata:";
            // 
            // btnDodajKlijenta
            // 
            this.btnDodajKlijenta.Location = new System.Drawing.Point(642, 58);
            this.btnDodajKlijenta.Name = "btnDodajKlijenta";
            this.btnDodajKlijenta.Size = new System.Drawing.Size(108, 35);
            this.btnDodajKlijenta.TabIndex = 2;
            this.btnDodajKlijenta.Text = "Dodaj klijenta";
            this.btnDodajKlijenta.UseVisualStyleBackColor = true;
            this.btnDodajKlijenta.Click += new System.EventHandler(this.btnDodajKlijenta_Click);
            // 
            // btnIzbrisiKlijenta
            // 
            this.btnIzbrisiKlijenta.Location = new System.Drawing.Point(642, 117);
            this.btnIzbrisiKlijenta.Name = "btnIzbrisiKlijenta";
            this.btnIzbrisiKlijenta.Size = new System.Drawing.Size(108, 35);
            this.btnIzbrisiKlijenta.TabIndex = 3;
            this.btnIzbrisiKlijenta.Text = "Izbriši klijenta";
            this.btnIzbrisiKlijenta.UseVisualStyleBackColor = true;
            this.btnIzbrisiKlijenta.Click += new System.EventHandler(this.btnIzbrisiKlijenta_Click);
            // 
            // btnUrediKlijenta
            // 
            this.btnUrediKlijenta.Location = new System.Drawing.Point(642, 177);
            this.btnUrediKlijenta.Name = "btnUrediKlijenta";
            this.btnUrediKlijenta.Size = new System.Drawing.Size(108, 35);
            this.btnUrediKlijenta.TabIndex = 4;
            this.btnUrediKlijenta.Text = "Uredi klijenta";
            this.btnUrediKlijenta.UseVisualStyleBackColor = true;
            this.btnUrediKlijenta.Click += new System.EventHandler(this.btnUrediKlijenta_Click);
            // 
            // btnDetaljiKlijenta
            // 
            this.btnDetaljiKlijenta.Location = new System.Drawing.Point(642, 235);
            this.btnDetaljiKlijenta.Name = "btnDetaljiKlijenta";
            this.btnDetaljiKlijenta.Size = new System.Drawing.Size(108, 35);
            this.btnDetaljiKlijenta.TabIndex = 5;
            this.btnDetaljiKlijenta.Text = "Detalji klijenta";
            this.btnDetaljiKlijenta.UseVisualStyleBackColor = true;
            this.btnDetaljiKlijenta.Click += new System.EventHandler(this.btnDetaljiKlijenta_Click);
            // 
            // btnUveziKlijenta
            // 
            this.btnUveziKlijenta.Location = new System.Drawing.Point(642, 293);
            this.btnUveziKlijenta.Name = "btnUveziKlijenta";
            this.btnUveziKlijenta.Size = new System.Drawing.Size(108, 50);
            this.btnUveziKlijenta.TabIndex = 6;
            this.btnUveziKlijenta.Text = "Uvezi klijenta (XML)";
            this.btnUveziKlijenta.UseVisualStyleBackColor = true;
            this.btnUveziKlijenta.Click += new System.EventHandler(this.btnUveziKlijenta_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(642, 403);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(108, 35);
            this.btnNatrag.TabIndex = 7;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // FrmPregledKlijenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnUveziKlijenta);
            this.Controls.Add(this.btnDetaljiKlijenta);
            this.Controls.Add(this.btnUrediKlijenta);
            this.Controls.Add(this.btnIzbrisiKlijenta);
            this.Controls.Add(this.btnDodajKlijenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKlijenti);
            this.Name = "FrmPregledKlijenata";
            this.Text = "Pregled klijenata";
            this.Load += new System.EventHandler(this.FrmPregledKlijenata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajKlijenta;
        private System.Windows.Forms.Button btnIzbrisiKlijenta;
        private System.Windows.Forms.Button btnUrediKlijenta;
        private System.Windows.Forms.Button btnDetaljiKlijenta;
        private System.Windows.Forms.Button btnUveziKlijenta;
        private System.Windows.Forms.Button btnNatrag;
    }
}

