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
            this.btnNatrag = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnVasiRacuni = new System.Windows.Forms.RadioButton();
            this.rbtnUkupniIznos = new System.Windows.Forms.RadioButton();
            this.rbtnDatumIzdaje = new System.Windows.Forms.RadioButton();
            this.labelKlijent = new System.Windows.Forms.Label();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnSilazno = new System.Windows.Forms.RadioButton();
            this.rbtnUzlazno = new System.Windows.Forms.RadioButton();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.btnDetaljniPregled = new System.Windows.Forms.Button();
            this.btnPretrazivanje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Location = new System.Drawing.Point(168, 251);
            this.dgvRacuni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.RowHeadersWidth = 51;
            this.dgvRacuni.Size = new System.Drawing.Size(1404, 341);
            this.dgvRacuni.TabIndex = 0;
            // 
            // btnIzdajNoviRacun
            // 
            this.btnIzdajNoviRacun.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzdajNoviRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzdajNoviRacun.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzdajNoviRacun.Location = new System.Drawing.Point(168, 601);
            this.btnIzdajNoviRacun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzdajNoviRacun.Name = "btnIzdajNoviRacun";
            this.btnIzdajNoviRacun.Size = new System.Drawing.Size(196, 49);
            this.btnIzdajNoviRacun.TabIndex = 1;
            this.btnIzdajNoviRacun.Text = "Izdaj novi račun";
            this.btnIzdajNoviRacun.UseVisualStyleBackColor = false;
            this.btnIzdajNoviRacun.Click += new System.EventHandler(this.btnIzdajNoviRacun_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNatrag.Location = new System.Drawing.Point(1376, 601);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(196, 49);
            this.btnNatrag.TabIndex = 3;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnVasiRacuni);
            this.groupBox1.Controls.Add(this.rbtnUkupniIznos);
            this.groupBox1.Controls.Add(this.rbtnDatumIzdaje);
            this.groupBox1.Controls.Add(this.labelKlijent);
            this.groupBox1.Controls.Add(this.cmbKlijent);
            this.groupBox1.Location = new System.Drawing.Point(168, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(760, 171);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraživanje";
            // 
            // rbtnVasiRacuni
            // 
            this.rbtnVasiRacuni.AutoSize = true;
            this.rbtnVasiRacuni.Location = new System.Drawing.Point(444, 96);
            this.rbtnVasiRacuni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnVasiRacuni.Name = "rbtnVasiRacuni";
            this.rbtnVasiRacuni.Size = new System.Drawing.Size(94, 20);
            this.rbtnVasiRacuni.TabIndex = 4;
            this.rbtnVasiRacuni.TabStop = true;
            this.rbtnVasiRacuni.Text = "Vaši računi";
            this.rbtnVasiRacuni.UseVisualStyleBackColor = true;
            this.rbtnVasiRacuni.CheckedChanged += new System.EventHandler(this.rbtnVasiRacuni_CheckedChanged);
            // 
            // rbtnUkupniIznos
            // 
            this.rbtnUkupniIznos.AutoSize = true;
            this.rbtnUkupniIznos.Location = new System.Drawing.Point(444, 68);
            this.rbtnUkupniIznos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnUkupniIznos.Name = "rbtnUkupniIznos";
            this.rbtnUkupniIznos.Size = new System.Drawing.Size(148, 20);
            this.rbtnUkupniIznos.TabIndex = 3;
            this.rbtnUkupniIznos.TabStop = true;
            this.rbtnUkupniIznos.Text = "Ukupni iznos računa";
            this.rbtnUkupniIznos.UseVisualStyleBackColor = true;
            this.rbtnUkupniIznos.CheckedChanged += new System.EventHandler(this.rbtnUkupniIznos_CheckedChanged);
            // 
            // rbtnDatumIzdaje
            // 
            this.rbtnDatumIzdaje.AutoSize = true;
            this.rbtnDatumIzdaje.Location = new System.Drawing.Point(444, 39);
            this.rbtnDatumIzdaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnDatumIzdaje.Name = "rbtnDatumIzdaje";
            this.rbtnDatumIzdaje.Size = new System.Drawing.Size(150, 20);
            this.rbtnDatumIzdaje.TabIndex = 2;
            this.rbtnDatumIzdaje.TabStop = true;
            this.rbtnDatumIzdaje.Text = "Datum izdaje računa";
            this.rbtnDatumIzdaje.UseVisualStyleBackColor = true;
            this.rbtnDatumIzdaje.CheckedChanged += new System.EventHandler(this.rbtnDatumIzdaje_CheckedChanged);
            // 
            // labelKlijent
            // 
            this.labelKlijent.AutoSize = true;
            this.labelKlijent.Location = new System.Drawing.Point(23, 68);
            this.labelKlijent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKlijent.Name = "labelKlijent";
            this.labelKlijent.Size = new System.Drawing.Size(45, 16);
            this.labelKlijent.TabIndex = 1;
            this.labelKlijent.Text = "Klijent:";
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(81, 64);
            this.cmbKlijent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(260, 24);
            this.cmbKlijent.TabIndex = 0;
            this.cmbKlijent.SelectedIndexChanged += new System.EventHandler(this.cmbKlijent_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnSilazno);
            this.groupBox2.Controls.Add(this.rbtnUzlazno);
            this.groupBox2.Location = new System.Drawing.Point(936, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(267, 129);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sortiranje";
            // 
            // rbtnSilazno
            // 
            this.rbtnSilazno.AutoSize = true;
            this.rbtnSilazno.Location = new System.Drawing.Point(35, 63);
            this.rbtnSilazno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnSilazno.Name = "rbtnSilazno";
            this.rbtnSilazno.Size = new System.Drawing.Size(72, 20);
            this.rbtnSilazno.TabIndex = 1;
            this.rbtnSilazno.TabStop = true;
            this.rbtnSilazno.Text = "Silazno";
            this.rbtnSilazno.UseVisualStyleBackColor = true;
            this.rbtnSilazno.CheckedChanged += new System.EventHandler(this.rbtnSilazno_CheckedChanged);
            // 
            // rbtnUzlazno
            // 
            this.rbtnUzlazno.AutoSize = true;
            this.rbtnUzlazno.Location = new System.Drawing.Point(35, 34);
            this.rbtnUzlazno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnUzlazno.Name = "rbtnUzlazno";
            this.rbtnUzlazno.Size = new System.Drawing.Size(76, 20);
            this.rbtnUzlazno.TabIndex = 0;
            this.rbtnUzlazno.TabStop = true;
            this.rbtnUzlazno.Text = "Uzlazno";
            this.rbtnUzlazno.UseVisualStyleBackColor = true;
            this.rbtnUzlazno.CheckedChanged += new System.EventHandler(this.rbtnUzlazno_CheckedChanged);
            // 
            // btnOcisti
            // 
            this.btnOcisti.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOcisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOcisti.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOcisti.Location = new System.Drawing.Point(1211, 89);
            this.btnOcisti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(140, 60);
            this.btnOcisti.TabIndex = 6;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = false;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // btnDetaljniPregled
            // 
            this.btnDetaljniPregled.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDetaljniPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetaljniPregled.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDetaljniPregled.Location = new System.Drawing.Point(372, 601);
            this.btnDetaljniPregled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetaljniPregled.Name = "btnDetaljniPregled";
            this.btnDetaljniPregled.Size = new System.Drawing.Size(196, 49);
            this.btnDetaljniPregled.TabIndex = 7;
            this.btnDetaljniPregled.Text = "Detaljni pregled";
            this.btnDetaljniPregled.UseVisualStyleBackColor = false;
            this.btnDetaljniPregled.Click += new System.EventHandler(this.btnDetaljniPregled_Click);
            // 
            // btnPretrazivanje
            // 
            this.btnPretrazivanje.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPretrazivanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazivanje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPretrazivanje.Location = new System.Drawing.Point(1211, 151);
            this.btnPretrazivanje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPretrazivanje.Name = "btnPretrazivanje";
            this.btnPretrazivanje.Size = new System.Drawing.Size(331, 60);
            this.btnPretrazivanje.TabIndex = 8;
            this.btnPretrazivanje.Text = "Pretraživanje";
            this.btnPretrazivanje.UseVisualStyleBackColor = false;
            this.btnPretrazivanje.Click += new System.EventHandler(this.btnPretrazivanje_Click);
            // 
            // FrmRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1763, 750);
            this.Controls.Add(this.btnPretrazivanje);
            this.Controls.Add(this.btnDetaljniPregled);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnIzdajNoviRacun);
            this.Controls.Add(this.dgvRacuni);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRacuni";
            this.Text = "Računi";
            this.Load += new System.EventHandler(this.FrmRacuni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.Button btnIzdajNoviRacun;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnVasiRacuni;
        private System.Windows.Forms.RadioButton rbtnUkupniIznos;
        private System.Windows.Forms.RadioButton rbtnDatumIzdaje;
        private System.Windows.Forms.Label labelKlijent;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnSilazno;
        private System.Windows.Forms.RadioButton rbtnUzlazno;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button btnDetaljniPregled;
        private System.Windows.Forms.Button btnPretrazivanje;
    }
}