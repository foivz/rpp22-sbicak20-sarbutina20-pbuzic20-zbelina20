namespace ZMGDesktop
{
    partial class FrmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblZMGDesktop = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(164, 233);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 41);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Prijava";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.Login);
            // 
            // lblZMGDesktop
            // 
            this.lblZMGDesktop.AutoSize = true;
            this.lblZMGDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZMGDesktop.Location = new System.Drawing.Point(142, 37);
            this.lblZMGDesktop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZMGDesktop.Name = "lblZMGDesktop";
            this.lblZMGDesktop.Size = new System.Drawing.Size(187, 32);
            this.lblZMGDesktop.TabIndex = 3;
            this.lblZMGDesktop.Text = "ZMG Desktop";
            this.lblZMGDesktop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLozinka.Location = new System.Drawing.Point(212, 165);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(188, 35);
            this.txtLozinka.TabIndex = 2;
            this.txtLozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLozinka.UseSystemPasswordChar = true;
            // 
            // txtKorIme
            // 
            this.txtKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorIme.Location = new System.Drawing.Point(212, 116);
            this.txtKorIme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(188, 35);
            this.txtKorIme.TabIndex = 1;
            this.txtKorIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorisnickoIme.Location = new System.Drawing.Point(16, 116);
            this.labelKorisnickoIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(172, 29);
            this.labelKorisnickoIme.TabIndex = 4;
            this.labelKorisnickoIme.Text = "Korisničko ime";
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLozinka.Location = new System.Drawing.Point(46, 169);
            this.labelLozinka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(95, 29);
            this.labelLozinka.TabIndex = 5;
            this.labelLozinka.Text = "Lozinka";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 302);
            this.Controls.Add(this.labelLozinka);
            this.Controls.Add(this.labelKorisnickoIme);
            this.Controls.Add(this.lblZMGDesktop);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.btnLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblZMGDesktop;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.Label labelLozinka;
    }
}