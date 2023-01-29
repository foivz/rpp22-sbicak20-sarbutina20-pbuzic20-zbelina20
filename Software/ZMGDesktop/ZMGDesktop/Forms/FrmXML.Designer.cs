namespace ZMGDesktop
{
    partial class FrmXML
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
            this.labelOdaberiDatoteku = new System.Windows.Forms.Label();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.dgvKlijentiXML = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijentiXML)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOdaberiDatoteku
            // 
            this.labelOdaberiDatoteku.AutoSize = true;
            this.labelOdaberiDatoteku.Location = new System.Drawing.Point(29, 27);
            this.labelOdaberiDatoteku.Name = "labelOdaberiDatoteku";
            this.labelOdaberiDatoteku.Size = new System.Drawing.Size(143, 16);
            this.labelOdaberiDatoteku.TabIndex = 0;
            this.labelOdaberiDatoteku.Text = "Odaberi XML datoteku:";
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOdaberi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdaberi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOdaberi.Location = new System.Drawing.Point(178, 12);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(101, 43);
            this.btnOdaberi.TabIndex = 1;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = false;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnesi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUnesi.Location = new System.Drawing.Point(285, 12);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(98, 43);
            this.btnUnesi.TabIndex = 2;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = false;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // dgvKlijentiXML
            // 
            this.dgvKlijentiXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijentiXML.Location = new System.Drawing.Point(12, 74);
            this.dgvKlijentiXML.Name = "dgvKlijentiXML";
            this.dgvKlijentiXML.RowHeadersWidth = 51;
            this.dgvKlijentiXML.RowTemplate.Height = 24;
            this.dgvKlijentiXML.Size = new System.Drawing.Size(785, 341);
            this.dgvKlijentiXML.TabIndex = 3;
            // 
            // FrmXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 427);
            this.Controls.Add(this.dgvKlijentiXML);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.labelOdaberiDatoteku);
            this.Name = "FrmXML";
            this.Text = "FrmXML";
            this.Load += new System.EventHandler(this.FrmXML_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijentiXML)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOdaberiDatoteku;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.DataGridView dgvKlijentiXML;
    }
}