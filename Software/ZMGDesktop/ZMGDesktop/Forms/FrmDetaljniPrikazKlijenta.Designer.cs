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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.lblImeiPrezime = new System.Windows.Forms.Label();
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
            this.dgvRadniNalozi.Size = new System.Drawing.Size(776, 164);
            this.dgvRadniNalozi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis radnih naloga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Popis računa:";
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Location = new System.Drawing.Point(12, 316);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.RowHeadersWidth = 51;
            this.dgvRacuni.RowTemplate.Height = 24;
            this.dgvRacuni.Size = new System.Drawing.Size(776, 164);
            this.dgvRacuni.TabIndex = 2;
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.Color.OldLace;
            this.btnNatrag.Location = new System.Drawing.Point(680, 489);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(108, 35);
            this.btnNatrag.TabIndex = 4;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // lblImeiPrezime
            // 
            this.lblImeiPrezime.AutoSize = true;
            this.lblImeiPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImeiPrezime.Location = new System.Drawing.Point(307, 22);
            this.lblImeiPrezime.Name = "lblImeiPrezime";
            this.lblImeiPrezime.Size = new System.Drawing.Size(131, 25);
            this.lblImeiPrezime.TabIndex = 5;
            this.lblImeiPrezime.Text = "Ime Prezime";
            // 
            // FrmDetaljniPrikazKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 532);
            this.Controls.Add(this.lblImeiPrezime);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRacuni);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label lblImeiPrezime;
    }
}