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
            this.components = new System.ComponentModel.Container();
            this.lblSkeniraj = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnProba = new System.Windows.Forms.Button();
            this.btnZaprimi = new System.Windows.Forms.Button();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKreni = new System.Windows.Forms.Button();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSkeniraj
            // 
            this.lblSkeniraj.AutoSize = true;
            this.lblSkeniraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkeniraj.Location = new System.Drawing.Point(408, 20);
            this.lblSkeniraj.Name = "lblSkeniraj";
            this.lblSkeniraj.Size = new System.Drawing.Size(364, 29);
            this.lblSkeniraj.TabIndex = 0;
            this.lblSkeniraj.Text = "Skenirajte QR kod materijala";
            this.lblSkeniraj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNatrag.Location = new System.Drawing.Point(12, 634);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(136, 57);
            this.btnNatrag.TabIndex = 1;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnProba
            // 
            this.btnProba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnProba.Location = new System.Drawing.Point(12, 547);
            this.btnProba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProba.Name = "btnProba";
            this.btnProba.Size = new System.Drawing.Size(189, 57);
            this.btnProba.TabIndex = 2;
            this.btnProba.Text = "Isprobaj uspješno skeniranje materijala";
            this.btnProba.UseVisualStyleBackColor = true;
            this.btnProba.Click += new System.EventHandler(this.btnProba_Click);
            // 
            // btnZaprimi
            // 
            this.btnZaprimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnZaprimi.Location = new System.Drawing.Point(37, 174);
            this.btnZaprimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZaprimi.Name = "btnZaprimi";
            this.btnZaprimi.Size = new System.Drawing.Size(183, 62);
            this.btnZaprimi.TabIndex = 3;
            this.btnZaprimi.Text = "Ažuriraj količinu";
            this.btnZaprimi.UseVisualStyleBackColor = true;
            this.btnZaprimi.Click += new System.EventHandler(this.btnZaprimi_Click);
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(37, 117);
            this.numKolicina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.numKolicina.Size = new System.Drawing.Size(183, 22);
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
            this.lblKolicina.Location = new System.Drawing.Point(32, 48);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(252, 31);
            this.lblKolicina.TabIndex = 5;
            this.lblKolicina.Text = "Količina materijala";
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(552, 75);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(220, 24);
            this.cboDevice.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Odaberi uređaj skeniranja";
            // 
            // btnKreni
            // 
            this.btnKreni.Location = new System.Drawing.Point(614, 117);
            this.btnKreni.Name = "btnKreni";
            this.btnKreni.Size = new System.Drawing.Size(158, 31);
            this.btnKreni.TabIndex = 8;
            this.btnKreni.Text = "Kreni s skeniranjem";
            this.btnKreni.UseVisualStyleBackColor = true;
            this.btnKreni.Click += new System.EventHandler(this.btnKreni_Click);
            // 
            // picQR
            // 
            this.picQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picQR.Location = new System.Drawing.Point(333, 154);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(895, 537);
            this.picQR.TabIndex = 9;
            this.picQR.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmZaprimiMaterijal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 718);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.btnKreni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.btnZaprimi);
            this.Controls.Add(this.btnProba);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.lblSkeniraj);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmZaprimiMaterijal";
            this.Text = "Zaprimi materijal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmZaprimiMaterijal_FormClosing);
            this.Load += new System.EventHandler(this.FrmZaprimiMaterijal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
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
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKreni;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Timer timer1;
    }
}