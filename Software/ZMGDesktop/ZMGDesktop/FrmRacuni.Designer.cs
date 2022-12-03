namespace ZMGDesktop
{
    partial class FrmRacuni
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
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.btnIzdajNoviRacun = new System.Windows.Forms.Button();
            this.btnDetaljniPregled = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Location = new System.Drawing.Point(128, 85);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.Size = new System.Drawing.Size(1053, 277);
            this.dgvRacuni.TabIndex = 0;
            // 
            // btnIzdajNoviRacun
            // 
            this.btnIzdajNoviRacun.Location = new System.Drawing.Point(128, 369);
            this.btnIzdajNoviRacun.Name = "btnIzdajNoviRacun";
            this.btnIzdajNoviRacun.Size = new System.Drawing.Size(147, 40);
            this.btnIzdajNoviRacun.TabIndex = 1;
            this.btnIzdajNoviRacun.Text = "Izdaj novi račun";
            this.btnIzdajNoviRacun.UseVisualStyleBackColor = true;
            // 
            // btnDetaljniPregled
            // 
            this.btnDetaljniPregled.Location = new System.Drawing.Point(291, 369);
            this.btnDetaljniPregled.Name = "btnDetaljniPregled";
            this.btnDetaljniPregled.Size = new System.Drawing.Size(147, 40);
            this.btnDetaljniPregled.TabIndex = 2;
            this.btnDetaljniPregled.Text = "Detaljni pregled računa";
            this.btnDetaljniPregled.UseVisualStyleBackColor = true;
            this.btnDetaljniPregled.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(1034, 369);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(147, 40);
            this.btnNatrag.TabIndex = 3;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            // 
            // FrmRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 609);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnDetaljniPregled);
            this.Controls.Add(this.btnIzdajNoviRacun);
            this.Controls.Add(this.dgvRacuni);
            this.Name = "FrmRacuni";
            this.Text = "Računi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.Button btnIzdajNoviRacun;
        private System.Windows.Forms.Button btnDetaljniPregled;
        private System.Windows.Forms.Button btnNatrag;
    }
}