namespace ZMGDesktop
{
    partial class FrmDetaljiIzvjestajaRadnihNaloga
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.dgvIzvjestajRadnihNaloga = new System.Windows.Forms.DataGridView();
            this.pbGraf = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestajRadnihNaloga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izvještaj radnih naloga #";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbGraf);
            this.groupBox1.Controls.Add(this.dgvIzvjestajRadnihNaloga);
            this.groupBox1.Location = new System.Drawing.Point(13, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 346);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izvještaj";
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(676, 402);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(112, 37);
            this.btnNatrag.TabIndex = 8;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            // 
            // dgvIzvjestajRadnihNaloga
            // 
            this.dgvIzvjestajRadnihNaloga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestajRadnihNaloga.Location = new System.Drawing.Point(7, 20);
            this.dgvIzvjestajRadnihNaloga.Name = "dgvIzvjestajRadnihNaloga";
            this.dgvIzvjestajRadnihNaloga.Size = new System.Drawing.Size(439, 320);
            this.dgvIzvjestajRadnihNaloga.TabIndex = 0;
            // 
            // pbGraf
            // 
            this.pbGraf.Location = new System.Drawing.Point(462, 20);
            this.pbGraf.Name = "pbGraf";
            this.pbGraf.Size = new System.Drawing.Size(307, 320);
            this.pbGraf.TabIndex = 1;
            this.pbGraf.TabStop = false;
            // 
            // FrmDetaljiIzvjestajaRadnihNaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetaljiIzvjestajaRadnihNaloga";
            this.Text = "Detalji izvještaja radnih naloga";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestajRadnihNaloga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.DataGridView dgvIzvjestajRadnihNaloga;
        private System.Windows.Forms.PictureBox pbGraf;
    }
}