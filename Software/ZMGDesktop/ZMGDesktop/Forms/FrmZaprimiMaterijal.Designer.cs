namespace ZMGDesktop
{
    partial class FrmZaprimiMaterijal
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
            this.lblSkeniraj = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnProba = new System.Windows.Forms.Button();
            this.btnZaprimi = new System.Windows.Forms.Button();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.lblKolicina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSkeniraj
            // 
            this.lblSkeniraj.AutoSize = true;
            this.lblSkeniraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkeniraj.Location = new System.Drawing.Point(193, 141);
            this.lblSkeniraj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSkeniraj.Name = "lblSkeniraj";
            this.lblSkeniraj.Size = new System.Drawing.Size(286, 25);
            this.lblSkeniraj.TabIndex = 0;
            this.lblSkeniraj.Text = "Skenirajte QR kod materijala";
            this.lblSkeniraj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNatrag.Location = new System.Drawing.Point(477, 301);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(102, 46);
            this.btnNatrag.TabIndex = 1;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnProba
            // 
            this.btnProba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnProba.Location = new System.Drawing.Point(22, 301);
            this.btnProba.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProba.Name = "btnProba";
            this.btnProba.Size = new System.Drawing.Size(142, 46);
            this.btnProba.TabIndex = 2;
            this.btnProba.Text = "Isprobaj uspješno skeniranje materijala";
            this.btnProba.UseVisualStyleBackColor = true;
            this.btnProba.Click += new System.EventHandler(this.btnProba_Click);
            // 
            // btnZaprimi
            // 
            this.btnZaprimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnZaprimi.Location = new System.Drawing.Point(28, 141);
            this.btnZaprimi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZaprimi.Name = "btnZaprimi";
            this.btnZaprimi.Size = new System.Drawing.Size(137, 50);
            this.btnZaprimi.TabIndex = 3;
            this.btnZaprimi.Text = "Ažuriraj količinu";
            this.btnZaprimi.UseVisualStyleBackColor = true;
            this.btnZaprimi.Click += new System.EventHandler(this.btnZaprimi_Click);
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(28, 95);
            this.numKolicina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numKolicina.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(137, 20);
            this.numKolicina.TabIndex = 4;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblKolicina.Location = new System.Drawing.Point(24, 39);
            this.lblKolicina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(209, 26);
            this.lblKolicina.TabIndex = 5;
            this.lblKolicina.Text = "Količina materijala";
            // 
            // FrmZaprimiMaterijal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.btnZaprimi);
            this.Controls.Add(this.btnProba);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.lblSkeniraj);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmZaprimiMaterijal";
            this.Text = "Zaprimi materijal";
            this.Load += new System.EventHandler(this.FrmZaprimiMaterijal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSkeniraj;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnProba;
        private System.Windows.Forms.Button btnZaprimi;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.Label lblKolicina;
    }
}