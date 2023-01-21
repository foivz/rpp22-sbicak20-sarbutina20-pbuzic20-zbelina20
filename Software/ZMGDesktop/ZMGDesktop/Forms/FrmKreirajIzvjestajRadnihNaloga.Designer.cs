namespace ZMGDesktop
{
    partial class FrmKreirajIzvjestajRadnihNaloga
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbGraf = new System.Windows.Forms.PictureBox();
            this.dgvIzvjestajRadnihNaloga = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestajRadnihNaloga)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOdustani.Location = new System.Drawing.Point(901, 494);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(149, 46);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSpremi.Location = new System.Drawing.Point(747, 494);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(149, 46);
            this.btnSpremi.TabIndex = 12;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Izvještaj radnih naloga #";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbGraf);
            this.groupBox1.Controls.Add(this.dgvIzvjestajRadnihNaloga);
            this.groupBox1.Location = new System.Drawing.Point(17, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1033, 426);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izvještaj";
            // 
            // pbGraf
            // 
            this.pbGraf.Location = new System.Drawing.Point(616, 25);
            this.pbGraf.Margin = new System.Windows.Forms.Padding(4);
            this.pbGraf.Name = "pbGraf";
            this.pbGraf.Size = new System.Drawing.Size(409, 394);
            this.pbGraf.TabIndex = 1;
            this.pbGraf.TabStop = false;
            // 
            // dgvIzvjestajRadnihNaloga
            // 
            this.dgvIzvjestajRadnihNaloga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestajRadnihNaloga.Location = new System.Drawing.Point(9, 25);
            this.dgvIzvjestajRadnihNaloga.Margin = new System.Windows.Forms.Padding(4);
            this.dgvIzvjestajRadnihNaloga.Name = "dgvIzvjestajRadnihNaloga";
            this.dgvIzvjestajRadnihNaloga.RowHeadersWidth = 51;
            this.dgvIzvjestajRadnihNaloga.Size = new System.Drawing.Size(585, 394);
            this.dgvIzvjestajRadnihNaloga.TabIndex = 0;
            // 
            // FrmKreirajIzvjestajRadnihNaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKreirajIzvjestajRadnihNaloga";
            this.Text = "FrmKreirajIzvjestajRadnihNaloga";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGraf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestajRadnihNaloga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbGraf;
        private System.Windows.Forms.DataGridView dgvIzvjestajRadnihNaloga;
    }
}