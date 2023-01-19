namespace ZMGDesktop
{
    partial class FrmPopisRadnihNaloga
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
            this.dgvPopisRadnihNaloga = new System.Windows.Forms.DataGridView();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnNoviRadniNalog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisRadnihNaloga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popis radnih naloga";
            // 
            // dgvPopisRadnihNaloga
            // 
            this.dgvPopisRadnihNaloga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisRadnihNaloga.Location = new System.Drawing.Point(17, 57);
            this.dgvPopisRadnihNaloga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPopisRadnihNaloga.Name = "dgvPopisRadnihNaloga";
            this.dgvPopisRadnihNaloga.RowHeadersWidth = 51;
            this.dgvPopisRadnihNaloga.Size = new System.Drawing.Size(829, 416);
            this.dgvPopisRadnihNaloga.TabIndex = 1;
            this.dgvPopisRadnihNaloga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPopisRadnihNaloga_CellContentClick);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNatrag.Location = new System.Drawing.Point(903, 495);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(149, 46);
            this.btnNatrag.TabIndex = 8;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnObrisi.Location = new System.Drawing.Point(903, 220);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(149, 46);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDetalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetalji.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDetalji.Location = new System.Drawing.Point(903, 138);
            this.btnDetalji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(149, 46);
            this.btnDetalji.TabIndex = 10;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = false;
            // 
            // btnNoviRadniNalog
            // 
            this.btnNoviRadniNalog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNoviRadniNalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNoviRadniNalog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNoviRadniNalog.Location = new System.Drawing.Point(903, 57);
            this.btnNoviRadniNalog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNoviRadniNalog.Name = "btnNoviRadniNalog";
            this.btnNoviRadniNalog.Size = new System.Drawing.Size(149, 46);
            this.btnNoviRadniNalog.TabIndex = 11;
            this.btnNoviRadniNalog.Text = "Novi radni nalog";
            this.btnNoviRadniNalog.UseVisualStyleBackColor = false;
            this.btnNoviRadniNalog.Click += new System.EventHandler(this.btnNoviRadniNalog_Click);
            // 
            // FrmPopisRadnihNaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNoviRadniNalog);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.dgvPopisRadnihNaloga);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPopisRadnihNaloga";
            this.Text = "Radni nalozi";
            this.Load += new System.EventHandler(this.FrmPopisRadnihNaloga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisRadnihNaloga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPopisRadnihNaloga;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnNoviRadniNalog;
    }
}