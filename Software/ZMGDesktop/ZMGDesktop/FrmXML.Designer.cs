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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.dgvKlijentiXML = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijentiXML)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberi XML datoteku:";
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(178, 24);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(101, 23);
            this.btnOdaberi.TabIndex = 1;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(285, 24);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(85, 23);
            this.btnUnesi.TabIndex = 2;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.label1);
            this.Name = "FrmXML";
            this.Text = "FrmXML";
            this.Load += new System.EventHandler(this.FrmXML_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijentiXML)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.DataGridView dgvKlijentiXML;
    }
}