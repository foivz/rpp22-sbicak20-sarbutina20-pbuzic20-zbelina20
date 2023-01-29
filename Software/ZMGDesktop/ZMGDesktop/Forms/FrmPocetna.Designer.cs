namespace ZMGDesktop
{
    partial class FrmPocetna
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
            this.btnKlijenti = new System.Windows.Forms.Button();
            this.btnRacuni = new System.Windows.Forms.Button();
            this.btnStanjeSkladista = new System.Windows.Forms.Button();
            this.pictureBoxZMG = new System.Windows.Forms.PictureBox();
            this.btnRadniNalozi = new System.Windows.Forms.Button();
            this.btnIzvjestaji = new System.Windows.Forms.Button();
            this.labelDobrodosli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZMG)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKlijenti
            // 
            this.btnKlijenti.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKlijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKlijenti.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKlijenti.Location = new System.Drawing.Point(35, 82);
            this.btnKlijenti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKlijenti.Name = "btnKlijenti";
            this.btnKlijenti.Size = new System.Drawing.Size(112, 37);
            this.btnKlijenti.TabIndex = 13;
            this.btnKlijenti.Text = "Klijenti";
            this.btnKlijenti.UseVisualStyleBackColor = false;
            this.btnKlijenti.Click += new System.EventHandler(this.btnKlijenti_Click);
            // 
            // btnRacuni
            // 
            this.btnRacuni.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRacuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRacuni.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRacuni.Location = new System.Drawing.Point(35, 150);
            this.btnRacuni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRacuni.Name = "btnRacuni";
            this.btnRacuni.Size = new System.Drawing.Size(112, 37);
            this.btnRacuni.TabIndex = 14;
            this.btnRacuni.Text = "Računi";
            this.btnRacuni.UseVisualStyleBackColor = false;
            this.btnRacuni.Click += new System.EventHandler(this.btnRacuni_Click);
            // 
            // btnStanjeSkladista
            // 
            this.btnStanjeSkladista.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStanjeSkladista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStanjeSkladista.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStanjeSkladista.Location = new System.Drawing.Point(35, 215);
            this.btnStanjeSkladista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStanjeSkladista.Name = "btnStanjeSkladista";
            this.btnStanjeSkladista.Size = new System.Drawing.Size(112, 37);
            this.btnStanjeSkladista.TabIndex = 15;
            this.btnStanjeSkladista.Text = "Stanje skladišta";
            this.btnStanjeSkladista.UseVisualStyleBackColor = false;
            this.btnStanjeSkladista.Click += new System.EventHandler(this.btnStanjeSkladista_Click);
            // 
            // pictureBoxZMG
            // 
            this.pictureBoxZMG.Image = global::ZMGDesktop.Properties.Resources.ZMG;
            this.pictureBoxZMG.Location = new System.Drawing.Point(178, 79);
            this.pictureBoxZMG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxZMG.Name = "pictureBoxZMG";
            this.pictureBoxZMG.Size = new System.Drawing.Size(179, 174);
            this.pictureBoxZMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxZMG.TabIndex = 16;
            this.pictureBoxZMG.TabStop = false;
            // 
            // btnRadniNalozi
            // 
            this.btnRadniNalozi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRadniNalozi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRadniNalozi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRadniNalozi.Location = new System.Drawing.Point(374, 183);
            this.btnRadniNalozi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRadniNalozi.Name = "btnRadniNalozi";
            this.btnRadniNalozi.Size = new System.Drawing.Size(112, 37);
            this.btnRadniNalozi.TabIndex = 18;
            this.btnRadniNalozi.Text = "Radni nalozi";
            this.btnRadniNalozi.UseVisualStyleBackColor = false;
            this.btnRadniNalozi.Click += new System.EventHandler(this.btnRadniNalozi_Click);
            // 
            // btnIzvjestaji
            // 
            this.btnIzvjestaji.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzvjestaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzvjestaji.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIzvjestaji.Location = new System.Drawing.Point(374, 115);
            this.btnIzvjestaji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzvjestaji.Name = "btnIzvjestaji";
            this.btnIzvjestaji.Size = new System.Drawing.Size(112, 37);
            this.btnIzvjestaji.TabIndex = 17;
            this.btnIzvjestaji.Text = "Izvještaji";
            this.btnIzvjestaji.UseVisualStyleBackColor = false;
            this.btnIzvjestaji.Click += new System.EventHandler(this.btnIzvjestaji_Click);
            // 
            // labelDobrodosli
            // 
            this.labelDobrodosli.AutoSize = true;
            this.labelDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDobrodosli.Location = new System.Drawing.Point(192, 20);
            this.labelDobrodosli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDobrodosli.Name = "labelDobrodosli";
            this.labelDobrodosli.Size = new System.Drawing.Size(163, 31);
            this.labelDobrodosli.TabIndex = 20;
            this.labelDobrodosli.Text = "Dobrodošli!";
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 299);
            this.Controls.Add(this.labelDobrodosli);
            this.Controls.Add(this.btnRadniNalozi);
            this.Controls.Add(this.btnIzvjestaji);
            this.Controls.Add(this.pictureBoxZMG);
            this.Controls.Add(this.btnStanjeSkladista);
            this.Controls.Add(this.btnRacuni);
            this.Controls.Add(this.btnKlijenti);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni izbornik";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKlijenti;
        private System.Windows.Forms.Button btnRacuni;
        private System.Windows.Forms.Button btnStanjeSkladista;
        private System.Windows.Forms.PictureBox pictureBoxZMG;
        private System.Windows.Forms.Button btnRadniNalozi;
        private System.Windows.Forms.Button btnIzvjestaji;
        private System.Windows.Forms.Label labelDobrodosli;
    }
}