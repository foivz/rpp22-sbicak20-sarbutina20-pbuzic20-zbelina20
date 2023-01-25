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
            this.rbtnVašiRačuni = new System.Windows.Forms.RadioButton();
            this.rbtnUkupniIznos = new System.Windows.Forms.RadioButton();
            this.rbtnDatumIzdaje = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnSilazno = new System.Windows.Forms.RadioButton();
            this.rbtnUzlazno = new System.Windows.Forms.RadioButton();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.btnDetaljniPregled = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Location = new System.Drawing.Point(126, 204);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.RowHeadersWidth = 51;
            this.dgvRacuni.Size = new System.Drawing.Size(1053, 277);
            this.dgvRacuni.TabIndex = 0;
            // 
            // btnIzdajNoviRacun
            // 
            this.btnIzdajNoviRacun.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzdajNoviRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzdajNoviRacun.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzdajNoviRacun.Location = new System.Drawing.Point(126, 488);
            this.btnIzdajNoviRacun.Name = "btnIzdajNoviRacun";
            this.btnIzdajNoviRacun.Size = new System.Drawing.Size(147, 40);
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
            this.btnNatrag.Location = new System.Drawing.Point(1032, 488);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(147, 40);
            this.btnNatrag.TabIndex = 3;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnVašiRačuni);
            this.groupBox1.Controls.Add(this.rbtnUkupniIznos);
            this.groupBox1.Controls.Add(this.rbtnDatumIzdaje);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbKlijent);
            this.groupBox1.Location = new System.Drawing.Point(126, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraživanje";
            // 
            // rbtnVašiRačuni
            // 
            this.rbtnVašiRačuni.AutoSize = true;
            this.rbtnVašiRačuni.Location = new System.Drawing.Point(333, 78);
            this.rbtnVašiRačuni.Name = "rbtnVašiRačuni";
            this.rbtnVašiRačuni.Size = new System.Drawing.Size(77, 17);
            this.rbtnVašiRačuni.TabIndex = 4;
            this.rbtnVašiRačuni.TabStop = true;
            this.rbtnVašiRačuni.Text = "Vaši računi";
            this.rbtnVašiRačuni.UseVisualStyleBackColor = true;
            // 
            // rbtnUkupniIznos
            // 
            this.rbtnUkupniIznos.AutoSize = true;
            this.rbtnUkupniIznos.Location = new System.Drawing.Point(333, 55);
            this.rbtnUkupniIznos.Name = "rbtnUkupniIznos";
            this.rbtnUkupniIznos.Size = new System.Drawing.Size(122, 17);
            this.rbtnUkupniIznos.TabIndex = 3;
            this.rbtnUkupniIznos.TabStop = true;
            this.rbtnUkupniIznos.Text = "Ukupni iznos računa";
            this.rbtnUkupniIznos.UseVisualStyleBackColor = true;
            // 
            // rbtnDatumIzdaje
            // 
            this.rbtnDatumIzdaje.AutoSize = true;
            this.rbtnDatumIzdaje.Location = new System.Drawing.Point(333, 32);
            this.rbtnDatumIzdaje.Name = "rbtnDatumIzdaje";
            this.rbtnDatumIzdaje.Size = new System.Drawing.Size(122, 17);
            this.rbtnDatumIzdaje.TabIndex = 2;
            this.rbtnDatumIzdaje.TabStop = true;
            this.rbtnDatumIzdaje.Text = "Datum izdaje računa";
            this.rbtnDatumIzdaje.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Klijent:";
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(61, 52);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(196, 21);
            this.cmbKlijent.TabIndex = 0;
            this.cmbKlijent.SelectedIndexChanged += new System.EventHandler(this.cmbKlijent_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnSilazno);
            this.groupBox2.Controls.Add(this.rbtnUzlazno);
            this.groupBox2.Location = new System.Drawing.Point(725, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sortiranje";
            // 
            // rbtnSilazno
            // 
            this.rbtnSilazno.AutoSize = true;
            this.rbtnSilazno.Location = new System.Drawing.Point(26, 51);
            this.rbtnSilazno.Name = "rbtnSilazno";
            this.rbtnSilazno.Size = new System.Drawing.Size(59, 17);
            this.rbtnSilazno.TabIndex = 1;
            this.rbtnSilazno.TabStop = true;
            this.rbtnSilazno.Text = "Silazno";
            this.rbtnSilazno.UseVisualStyleBackColor = true;
            // 
            // rbtnUzlazno
            // 
            this.rbtnUzlazno.AutoSize = true;
            this.rbtnUzlazno.Location = new System.Drawing.Point(26, 28);
            this.rbtnUzlazno.Name = "rbtnUzlazno";
            this.rbtnUzlazno.Size = new System.Drawing.Size(63, 17);
            this.rbtnUzlazno.TabIndex = 0;
            this.rbtnUzlazno.TabStop = true;
            this.rbtnUzlazno.Text = "Uzlazno";
            this.rbtnUzlazno.UseVisualStyleBackColor = true;
            // 
            // btnOcisti
            // 
            this.btnOcisti.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOcisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOcisti.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOcisti.Location = new System.Drawing.Point(941, 125);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(105, 49);
            this.btnOcisti.TabIndex = 6;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = false;
            // 
            // btnDetaljniPregled
            // 
            this.btnDetaljniPregled.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDetaljniPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetaljniPregled.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDetaljniPregled.Location = new System.Drawing.Point(279, 488);
            this.btnDetaljniPregled.Name = "btnDetaljniPregled";
            this.btnDetaljniPregled.Size = new System.Drawing.Size(147, 40);
            this.btnDetaljniPregled.TabIndex = 7;
            this.btnDetaljniPregled.Text = "Detaljni pregled";
            this.btnDetaljniPregled.UseVisualStyleBackColor = false;
            // 
            // FrmRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 609);
            this.Controls.Add(this.btnDetaljniPregled);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnIzdajNoviRacun);
            this.Controls.Add(this.dgvRacuni);
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
        private System.Windows.Forms.RadioButton rbtnVašiRačuni;
        private System.Windows.Forms.RadioButton rbtnUkupniIznos;
        private System.Windows.Forms.RadioButton rbtnDatumIzdaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnSilazno;
        private System.Windows.Forms.RadioButton rbtnUzlazno;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button btnDetaljniPregled;
    }
}