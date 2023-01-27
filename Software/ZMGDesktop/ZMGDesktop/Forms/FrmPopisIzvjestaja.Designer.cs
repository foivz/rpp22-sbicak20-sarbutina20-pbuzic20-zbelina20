namespace ZMGDesktop
{
    partial class FrmPopisIzvjestaja
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
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.labelDesetNajvecihKlijenata = new System.Windows.Forms.Label();
            this.btnIzvjestajRadnihNaloga = new System.Windows.Forms.Button();
            this.btnIzvjestajKlijenata = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.dgvRadniNalozi = new System.Windows.Forms.DataGridView();
            this.labelRadniNaloziPoStatusu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadniNalozi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Location = new System.Drawing.Point(9, 39);
            this.dgvKlijenti.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.RowHeadersWidth = 51;
            this.dgvKlijenti.RowTemplate.Height = 24;
            this.dgvKlijenti.Size = new System.Drawing.Size(649, 196);
            this.dgvKlijenti.TabIndex = 0;
            // 
            // labelDesetNajvecihKlijenata
            // 
            this.labelDesetNajvecihKlijenata.AutoSize = true;
            this.labelDesetNajvecihKlijenata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDesetNajvecihKlijenata.Location = new System.Drawing.Point(9, 15);
            this.labelDesetNajvecihKlijenata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDesetNajvecihKlijenata.Name = "labelDesetNajvecihKlijenata";
            this.labelDesetNajvecihKlijenata.Size = new System.Drawing.Size(157, 17);
            this.labelDesetNajvecihKlijenata.TabIndex = 1;
            this.labelDesetNajvecihKlijenata.Text = "10 najvećih klijenata";
            // 
            // btnIzvjestajRadnihNaloga
            // 
            this.btnIzvjestajRadnihNaloga.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzvjestajRadnihNaloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzvjestajRadnihNaloga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzvjestajRadnihNaloga.Location = new System.Drawing.Point(670, 279);
            this.btnIzvjestajRadnihNaloga.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzvjestajRadnihNaloga.Name = "btnIzvjestajRadnihNaloga";
            this.btnIzvjestajRadnihNaloga.Size = new System.Drawing.Size(112, 64);
            this.btnIzvjestajRadnihNaloga.TabIndex = 3;
            this.btnIzvjestajRadnihNaloga.Text = "Izrada izvještaja radnih naloga";
            this.btnIzvjestajRadnihNaloga.UseVisualStyleBackColor = false;
            this.btnIzvjestajRadnihNaloga.Click += new System.EventHandler(this.btnIzvjestajRadnihNaloga_Click);
            // 
            // btnIzvjestajKlijenata
            // 
            this.btnIzvjestajKlijenata.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzvjestajKlijenata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzvjestajKlijenata.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzvjestajKlijenata.Location = new System.Drawing.Point(670, 39);
            this.btnIzvjestajKlijenata.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzvjestajKlijenata.Name = "btnIzvjestajKlijenata";
            this.btnIzvjestajKlijenata.Size = new System.Drawing.Size(112, 63);
            this.btnIzvjestajKlijenata.TabIndex = 4;
            this.btnIzvjestajKlijenata.Text = "Izrada klijentskih izvještaja";
            this.btnIzvjestajKlijenata.UseVisualStyleBackColor = false;
            this.btnIzvjestajKlijenata.Click += new System.EventHandler(this.btnIzvjestajKlijenata_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNatrag.Location = new System.Drawing.Point(670, 431);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(112, 42);
            this.btnNatrag.TabIndex = 7;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // dgvRadniNalozi
            // 
            this.dgvRadniNalozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadniNalozi.Location = new System.Drawing.Point(9, 279);
            this.dgvRadniNalozi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRadniNalozi.Name = "dgvRadniNalozi";
            this.dgvRadniNalozi.RowHeadersWidth = 51;
            this.dgvRadniNalozi.RowTemplate.Height = 24;
            this.dgvRadniNalozi.Size = new System.Drawing.Size(649, 195);
            this.dgvRadniNalozi.TabIndex = 8;
            // 
            // labelRadniNaloziPoStatusu
            // 
            this.labelRadniNaloziPoStatusu.AutoSize = true;
            this.labelRadniNaloziPoStatusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRadniNaloziPoStatusu.Location = new System.Drawing.Point(9, 254);
            this.labelRadniNaloziPoStatusu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRadniNaloziPoStatusu.Name = "labelRadniNaloziPoStatusu";
            this.labelRadniNaloziPoStatusu.Size = new System.Drawing.Size(179, 17);
            this.labelRadniNaloziPoStatusu.TabIndex = 9;
            this.labelRadniNaloziPoStatusu.Text = "Radni nalozi po statusu";
            // 
            // FrmPopisIzvjestaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 483);
            this.Controls.Add(this.labelRadniNaloziPoStatusu);
            this.Controls.Add(this.dgvRadniNalozi);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnIzvjestajKlijenata);
            this.Controls.Add(this.btnIzvjestajRadnihNaloga);
            this.Controls.Add(this.labelDesetNajvecihKlijenata);
            this.Controls.Add(this.dgvKlijenti);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPopisIzvjestaja";
            this.Text = "Izvještaji";
            this.Load += new System.EventHandler(this.FrmPopisIzvjestaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadniNalozi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.Label labelDesetNajvecihKlijenata;
        private System.Windows.Forms.Button btnIzvjestajRadnihNaloga;
        private System.Windows.Forms.Button btnIzvjestajKlijenata;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.DataGridView dgvRadniNalozi;
        private System.Windows.Forms.Label labelRadniNaloziPoStatusu;
    }
}