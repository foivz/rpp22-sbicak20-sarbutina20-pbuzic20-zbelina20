namespace ZMGDesktop
{
    partial class FrmKatalog
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
            this.dgvMaterijali = new System.Windows.Forms.DataGridView();
            this.dgvUsluge = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnZaprimi = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.labelMaterijali = new System.Windows.Forms.Label();
            this.labelUsluge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaterijali
            // 
            this.dgvMaterijali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterijali.Location = new System.Drawing.Point(26, 20);
            this.dgvMaterijali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMaterijali.Name = "dgvMaterijali";
            this.dgvMaterijali.RowHeadersWidth = 51;
            this.dgvMaterijali.RowTemplate.Height = 24;
            this.dgvMaterijali.Size = new System.Drawing.Size(419, 188);
            this.dgvMaterijali.TabIndex = 0;
            // 
            // dgvUsluge
            // 
            this.dgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsluge.Location = new System.Drawing.Point(26, 233);
            this.dgvUsluge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUsluge.Name = "dgvUsluge";
            this.dgvUsluge.RowHeadersWidth = 51;
            this.dgvUsluge.RowTemplate.Height = 24;
            this.dgvUsluge.Size = new System.Drawing.Size(419, 122);
            this.dgvUsluge.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDodaj.Location = new System.Drawing.Point(472, 28);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(109, 54);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj materijal";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnObrisi.Location = new System.Drawing.Point(472, 97);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(109, 54);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši materijal";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnZaprimi
            // 
            this.btnZaprimi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZaprimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaprimi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnZaprimi.Location = new System.Drawing.Point(472, 169);
            this.btnZaprimi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZaprimi.Name = "btnZaprimi";
            this.btnZaprimi.Size = new System.Drawing.Size(109, 54);
            this.btnZaprimi.TabIndex = 4;
            this.btnZaprimi.Text = "Zaprimi materijal";
            this.btnZaprimi.UseVisualStyleBackColor = false;
            this.btnZaprimi.Click += new System.EventHandler(this.btnZaprimi_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNatrag.Location = new System.Drawing.Point(482, 310);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(88, 37);
            this.btnNatrag.TabIndex = 5;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // labelMaterijali
            // 
            this.labelMaterijali.AutoSize = true;
            this.labelMaterijali.Location = new System.Drawing.Point(26, 2);
            this.labelMaterijali.Name = "labelMaterijali";
            this.labelMaterijali.Size = new System.Drawing.Size(51, 13);
            this.labelMaterijali.TabIndex = 6;
            this.labelMaterijali.Text = "Materijali:";
            // 
            // labelUsluge
            // 
            this.labelUsluge.AutoSize = true;
            this.labelUsluge.Location = new System.Drawing.Point(29, 214);
            this.labelUsluge.Name = "labelUsluge";
            this.labelUsluge.Size = new System.Drawing.Size(43, 13);
            this.labelUsluge.TabIndex = 7;
            this.labelUsluge.Text = "Usluge:";
            // 
            // FrmKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.labelUsluge);
            this.Controls.Add(this.labelMaterijali);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnZaprimi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvUsluge);
            this.Controls.Add(this.dgvMaterijali);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmKatalog";
            this.Text = "FrmKatalog";
            this.Load += new System.EventHandler(this.FrmKatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterijali;
        private System.Windows.Forms.DataGridView dgvUsluge;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnZaprimi;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label labelMaterijali;
        private System.Windows.Forms.Label labelUsluge;
    }
}