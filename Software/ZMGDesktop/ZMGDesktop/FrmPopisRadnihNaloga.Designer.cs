﻿namespace ZMGDesktop
{
    partial class FrmPopisRadnihNaloga
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
            this.dgvPopisRadnihNaloga = new System.Windows.Forms.DataGridView();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnNoviRadniNalog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisRadnihNaloga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popis radnih naloga";
            // 
            // dgvPopisRadnihNaloga
            // 
            this.dgvPopisRadnihNaloga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisRadnihNaloga.Location = new System.Drawing.Point(13, 46);
            this.dgvPopisRadnihNaloga.Name = "dgvPopisRadnihNaloga";
            this.dgvPopisRadnihNaloga.Size = new System.Drawing.Size(622, 338);
            this.dgvPopisRadnihNaloga.TabIndex = 1;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(677, 402);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(112, 37);
            this.btnNatrag.TabIndex = 8;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(677, 179);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(112, 37);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(677, 112);
            this.btnDetalji.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(112, 37);
            this.btnDetalji.TabIndex = 10;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            // 
            // btnNoviRadniNalog
            // 
            this.btnNoviRadniNalog.Location = new System.Drawing.Point(677, 46);
            this.btnNoviRadniNalog.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoviRadniNalog.Name = "btnNoviRadniNalog";
            this.btnNoviRadniNalog.Size = new System.Drawing.Size(112, 37);
            this.btnNoviRadniNalog.TabIndex = 11;
            this.btnNoviRadniNalog.Text = "Novi radni nalog";
            this.btnNoviRadniNalog.UseVisualStyleBackColor = true;
            // 
            // FrmPopisRadnihNaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNoviRadniNalog);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.dgvPopisRadnihNaloga);
            this.Controls.Add(this.label1);
            this.Name = "FrmPopisRadnihNaloga";
            this.Text = "Radni nalozi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisRadnihNaloga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPopisRadnihNaloga;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnNoviRadniNalog;
    }
}