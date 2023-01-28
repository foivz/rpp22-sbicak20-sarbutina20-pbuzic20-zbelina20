namespace ZMGDesktop
{
    partial class FrmPregledRacunaPDF
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
            this.wbPregledPDF = new System.Windows.Forms.WebBrowser();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.chkAutoEmail = new System.Windows.Forms.CheckBox();
            this.chkSpremiNaDisk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // wbPregledPDF
            // 
            this.wbPregledPDF.Location = new System.Drawing.Point(3, 5);
            this.wbPregledPDF.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPregledPDF.Name = "wbPregledPDF";
            this.wbPregledPDF.Size = new System.Drawing.Size(1338, 563);
            this.wbPregledPDF.TabIndex = 0;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(1181, 597);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(160, 50);
            this.btnNatrag.TabIndex = 1;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            // 
            // chkAutoEmail
            // 
            this.chkAutoEmail.AutoSize = true;
            this.chkAutoEmail.Location = new System.Drawing.Point(939, 592);
            this.chkAutoEmail.Name = "chkAutoEmail";
            this.chkAutoEmail.Size = new System.Drawing.Size(226, 17);
            this.chkAutoEmail.TabIndex = 2;
            this.chkAutoEmail.Text = "Automatsko slanje računa na email klijentu";
            this.chkAutoEmail.UseVisualStyleBackColor = true;
            // 
            // chkSpremiNaDisk
            // 
            this.chkSpremiNaDisk.AutoSize = true;
            this.chkSpremiNaDisk.Location = new System.Drawing.Point(939, 615);
            this.chkSpremiNaDisk.Name = "chkSpremiNaDisk";
            this.chkSpremiNaDisk.Size = new System.Drawing.Size(95, 17);
            this.chkSpremiNaDisk.TabIndex = 3;
            this.chkSpremiNaDisk.Text = "Spremi na disk";
            this.chkSpremiNaDisk.UseVisualStyleBackColor = true;
            // 
            // FrmPregledRacunaPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 653);
            this.Controls.Add(this.chkSpremiNaDisk);
            this.Controls.Add(this.chkAutoEmail);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.wbPregledPDF);
            this.Name = "FrmPregledRacunaPDF";
            this.Text = "Pregled računa u PDF obliku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbPregledPDF;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.CheckBox chkAutoEmail;
        private System.Windows.Forms.CheckBox chkSpremiNaDisk;
    }
}