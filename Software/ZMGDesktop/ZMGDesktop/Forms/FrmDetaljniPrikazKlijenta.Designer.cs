namespace ZMGDesktop
{
    partial class FrmDetaljniPrikazKlijenta
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
            this.dgvRadniNalozi = new System.Windows.Forms.DataGridView();
            this.labelRadniNalozi = new System.Windows.Forms.Label();
            this.labelRacuni = new System.Windows.Forms.Label();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.labelImePrezime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadniNalozi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRadniNalozi
            // 
            this.dgvRadniNalozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadniNalozi.Location = new System.Drawing.Point(12, 110);
            this.dgvRadniNalozi.Name = "dgvRadniNalozi";
            this.dgvRadniNalozi.RowHeadersWidth = 51;
            this.dgvRadniNalozi.RowTemplate.Height = 24;
            this.dgvRadniNalozi.Size = new System.Drawing.Size(955, 164);
            this.dgvRadniNalozi.TabIndex = 0;
            // 
            // labelRadniNalozi
            // 
            this.labelRadniNalozi.AutoSize = true;
            this.labelRadniNalozi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRadniNalozi.Location = new System.Drawing.Point(12, 81);
            this.labelRadniNalozi.Name = "labelRadniNalozi";
            this.labelRadniNalozi.Size = new System.Drawing.Size(156, 20);
            this.labelRadniNalozi.TabIndex = 1;
            this.labelRadniNalozi.Text = "Popis radnih naloga";
            // 
            // labelRacuni
            // 
            this.labelRacuni.AutoSize = true;
            this.labelRacuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRacuni.Location = new System.Drawing.Point(12, 287);
            this.labelRacuni.Name = "labelRacuni";
            this.labelRacuni.Size = new System.Drawing.Size(112, 20);
            this.labelRacuni.TabIndex = 3;
            this.labelRacuni.Text = "Popis računa:";
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Location = new System.Drawing.Point(12, 316);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.RowHeadersWidth = 51;
            this.dgvRacuni.RowTemplate.Height = 24;
            this.dgvRacuni.Size = new System.Drawing.Size(955, 164);
            this.dgvRacuni.TabIndex = 2;
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.Color.OldLace;
            this.btnNatrag.Location = new System.Drawing.Point(859, 494);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(108, 35);
            this.btnNatrag.TabIndex = 4;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // labelImePrezime
            // 
            this.labelImePrezime.AutoSize = true;
            this.labelImePrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImePrezime.Location = new System.Drawing.Point(448, 19);
            this.labelImePrezime.Name = "labelImePrezime";
            this.labelImePrezime.Size = new System.Drawing.Size(131, 25);
            this.labelImePrezime.TabIndex = 5;
            this.labelImePrezime.Text = "Ime Prezime";
            // 
            // FrmDetaljniPrikazKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 532);
            this.Controls.Add(this.labelImePrezime);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.labelRacuni);
            this.Controls.Add(this.dgvRacuni);
            this.Controls.Add(this.labelRadniNalozi);
            this.Controls.Add(this.dgvRadniNalozi);
            this.Name = "FrmDetaljniPrikazKlijenta";
            this.Text = "FrmDetaljniPrikazKlijenta";
            this.Load += new System.EventHandler(this.FrmDetaljniPrikazKlijenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadniNalozi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRadniNalozi;
        private System.Windows.Forms.Label labelRadniNalozi;
        private System.Windows.Forms.Label labelRacuni;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label labelImePrezime;
    }
}