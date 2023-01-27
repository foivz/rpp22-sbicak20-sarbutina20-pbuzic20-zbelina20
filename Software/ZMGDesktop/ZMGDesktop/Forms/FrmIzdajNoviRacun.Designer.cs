namespace ZMGDesktop
{
    partial class FrmIzdajNoviRacun
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
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.chkAutoEmail = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKlijenti = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtP_ObrtniRegistar = new System.Windows.Forms.TextBox();
            this.txtP_BrObrtnice = new System.Windows.Forms.TextBox();
            this.txtP_OIB = new System.Windows.Forms.TextBox();
            this.txtP_Poslovnica = new System.Windows.Forms.TextBox();
            this.txtP_Ulica = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtK_Naziv = new System.Windows.Forms.TextBox();
            this.txtK_Adresa = new System.Windows.Forms.TextBox();
            this.txtK_OIB = new System.Windows.Forms.TextBox();
            this.txtNacinPlacanja = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRokPlacanja = new System.Windows.Forms.TextBox();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.txtPDV = new System.Windows.Forms.TextBox();
            this.txtUkupniIznos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtP_Mjesto = new System.Windows.Forms.TextBox();
            this.txtP_Drzava = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtP_Banka = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtP_IBAN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtP_Naziv = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtP_BrojMobitela = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtP_TELFAX = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtK_Email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblBrojRacuna = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPDFpregled = new System.Windows.Forms.Button();
            this.btnIzdajRacun = new System.Windows.Forms.Button();
            this.btnDodajStavke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStavke
            // 
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(241, 383);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.Size = new System.Drawing.Size(841, 196);
            this.dgvStavke.TabIndex = 3;
            // 
            // chkAutoEmail
            // 
            this.chkAutoEmail.AutoSize = true;
            this.chkAutoEmail.Location = new System.Drawing.Point(12, 707);
            this.chkAutoEmail.Name = "chkAutoEmail";
            this.chkAutoEmail.Size = new System.Drawing.Size(190, 17);
            this.chkAutoEmail.TabIndex = 5;
            this.chkAutoEmail.Text = "Automatsko slanje na email klijentu";
            this.chkAutoEmail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Upis u obrtni registar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Br. OBRTNICE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "OIB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Poslovnica:";
            // 
            // cmbKlijenti
            // 
            this.cmbKlijenti.FormattingEnabled = true;
            this.cmbKlijenti.Location = new System.Drawing.Point(903, 173);
            this.cmbKlijenti.Name = "cmbKlijenti";
            this.cmbKlijenti.Size = new System.Drawing.Size(179, 21);
            this.cmbKlijenti.TabIndex = 10;
            this.cmbKlijenti.SelectedIndexChanged += new System.EventHandler(this.cmbKlijenti_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ulica:";
            // 
            // txtP_ObrtniRegistar
            // 
            this.txtP_ObrtniRegistar.Location = new System.Drawing.Point(129, 40);
            this.txtP_ObrtniRegistar.Name = "txtP_ObrtniRegistar";
            this.txtP_ObrtniRegistar.ReadOnly = true;
            this.txtP_ObrtniRegistar.Size = new System.Drawing.Size(260, 20);
            this.txtP_ObrtniRegistar.TabIndex = 12;
            // 
            // txtP_BrObrtnice
            // 
            this.txtP_BrObrtnice.Location = new System.Drawing.Point(129, 67);
            this.txtP_BrObrtnice.Name = "txtP_BrObrtnice";
            this.txtP_BrObrtnice.ReadOnly = true;
            this.txtP_BrObrtnice.Size = new System.Drawing.Size(260, 20);
            this.txtP_BrObrtnice.TabIndex = 13;
            // 
            // txtP_OIB
            // 
            this.txtP_OIB.Location = new System.Drawing.Point(129, 93);
            this.txtP_OIB.Name = "txtP_OIB";
            this.txtP_OIB.ReadOnly = true;
            this.txtP_OIB.Size = new System.Drawing.Size(260, 20);
            this.txtP_OIB.TabIndex = 14;
            // 
            // txtP_Poslovnica
            // 
            this.txtP_Poslovnica.Location = new System.Drawing.Point(129, 122);
            this.txtP_Poslovnica.Name = "txtP_Poslovnica";
            this.txtP_Poslovnica.ReadOnly = true;
            this.txtP_Poslovnica.Size = new System.Drawing.Size(260, 20);
            this.txtP_Poslovnica.TabIndex = 15;
            // 
            // txtP_Ulica
            // 
            this.txtP_Ulica.Location = new System.Drawing.Point(129, 148);
            this.txtP_Ulica.Name = "txtP_Ulica";
            this.txtP_Ulica.ReadOnly = true;
            this.txtP_Ulica.Size = new System.Drawing.Size(260, 20);
            this.txtP_Ulica.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(814, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Odabir klijenata:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Naziv:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Adresa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "OIB:";
            // 
            // txtK_Naziv
            // 
            this.txtK_Naziv.Location = new System.Drawing.Point(60, 28);
            this.txtK_Naziv.Name = "txtK_Naziv";
            this.txtK_Naziv.ReadOnly = true;
            this.txtK_Naziv.Size = new System.Drawing.Size(179, 20);
            this.txtK_Naziv.TabIndex = 23;
            // 
            // txtK_Adresa
            // 
            this.txtK_Adresa.Location = new System.Drawing.Point(60, 54);
            this.txtK_Adresa.Name = "txtK_Adresa";
            this.txtK_Adresa.ReadOnly = true;
            this.txtK_Adresa.Size = new System.Drawing.Size(179, 20);
            this.txtK_Adresa.TabIndex = 24;
            // 
            // txtK_OIB
            // 
            this.txtK_OIB.Location = new System.Drawing.Point(60, 79);
            this.txtK_OIB.Name = "txtK_OIB";
            this.txtK_OIB.ReadOnly = true;
            this.txtK_OIB.Size = new System.Drawing.Size(179, 20);
            this.txtK_OIB.TabIndex = 25;
            // 
            // txtNacinPlacanja
            // 
            this.txtNacinPlacanja.Location = new System.Drawing.Point(325, 592);
            this.txtNacinPlacanja.Name = "txtNacinPlacanja";
            this.txtNacinPlacanja.ReadOnly = true;
            this.txtNacinPlacanja.Size = new System.Drawing.Size(179, 20);
            this.txtNacinPlacanja.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(238, 595);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Način plaćanja:";
            // 
            // txtRokPlacanja
            // 
            this.txtRokPlacanja.Location = new System.Drawing.Point(325, 618);
            this.txtRokPlacanja.Name = "txtRokPlacanja";
            this.txtRokPlacanja.ReadOnly = true;
            this.txtRokPlacanja.Size = new System.Drawing.Size(179, 20);
            this.txtRokPlacanja.TabIndex = 30;
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(903, 592);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.ReadOnly = true;
            this.txtUkupno.Size = new System.Drawing.Size(179, 20);
            this.txtUkupno.TabIndex = 31;
            // 
            // txtPDV
            // 
            this.txtPDV.Location = new System.Drawing.Point(903, 618);
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.ReadOnly = true;
            this.txtPDV.Size = new System.Drawing.Size(179, 20);
            this.txtPDV.TabIndex = 32;
            // 
            // txtUkupniIznos
            // 
            this.txtUkupniIznos.Location = new System.Drawing.Point(903, 644);
            this.txtUkupniIznos.Name = "txtUkupniIznos";
            this.txtUkupniIznos.ReadOnly = true;
            this.txtUkupniIznos.Size = new System.Drawing.Size(179, 20);
            this.txtUkupniIznos.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(85, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Mjesto:";
            // 
            // txtP_Mjesto
            // 
            this.txtP_Mjesto.Location = new System.Drawing.Point(129, 177);
            this.txtP_Mjesto.Name = "txtP_Mjesto";
            this.txtP_Mjesto.ReadOnly = true;
            this.txtP_Mjesto.Size = new System.Drawing.Size(260, 20);
            this.txtP_Mjesto.TabIndex = 35;
            // 
            // txtP_Drzava
            // 
            this.txtP_Drzava.Location = new System.Drawing.Point(129, 205);
            this.txtP_Drzava.Name = "txtP_Drzava";
            this.txtP_Drzava.ReadOnly = true;
            this.txtP_Drzava.Size = new System.Drawing.Size(260, 20);
            this.txtP_Drzava.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(85, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Država:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(85, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Banka:";
            // 
            // txtP_Banka
            // 
            this.txtP_Banka.Location = new System.Drawing.Point(129, 235);
            this.txtP_Banka.Name = "txtP_Banka";
            this.txtP_Banka.ReadOnly = true;
            this.txtP_Banka.Size = new System.Drawing.Size(260, 20);
            this.txtP_Banka.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(88, 263);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "IBAN:";
            // 
            // txtP_IBAN
            // 
            this.txtP_IBAN.Location = new System.Drawing.Point(129, 263);
            this.txtP_IBAN.Name = "txtP_IBAN";
            this.txtP_IBAN.ReadOnly = true;
            this.txtP_IBAN.Size = new System.Drawing.Size(260, 20);
            this.txtP_IBAN.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtP_Naziv);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txtP_BrojMobitela);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtP_TELFAX);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtP_Banka);
            this.groupBox1.Controls.Add(this.txtP_IBAN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtP_Drzava);
            this.groupBox1.Controls.Add(this.txtP_ObrtniRegistar);
            this.groupBox1.Controls.Add(this.txtP_Mjesto);
            this.groupBox1.Controls.Add(this.txtP_BrObrtnice);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtP_OIB);
            this.groupBox1.Controls.Add(this.txtP_Poslovnica);
            this.groupBox1.Controls.Add(this.txtP_Ulica);
            this.groupBox1.Location = new System.Drawing.Point(241, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 352);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Poslodavac";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtP_Naziv
            // 
            this.txtP_Naziv.Location = new System.Drawing.Point(129, 14);
            this.txtP_Naziv.Name = "txtP_Naziv";
            this.txtP_Naziv.ReadOnly = true;
            this.txtP_Naziv.Size = new System.Drawing.Size(260, 20);
            this.txtP_Naziv.TabIndex = 29;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(83, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 13);
            this.label23.TabIndex = 28;
            this.label23.Text = "Naziv:";
            // 
            // txtP_BrojMobitela
            // 
            this.txtP_BrojMobitela.Location = new System.Drawing.Point(129, 318);
            this.txtP_BrojMobitela.Name = "txtP_BrojMobitela";
            this.txtP_BrojMobitela.ReadOnly = true;
            this.txtP_BrojMobitela.Size = new System.Drawing.Size(260, 20);
            this.txtP_BrojMobitela.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(53, 321);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "Broj mobitela:";
            // 
            // txtP_TELFAX
            // 
            this.txtP_TELFAX.Location = new System.Drawing.Point(129, 290);
            this.txtP_TELFAX.Name = "txtP_TELFAX";
            this.txtP_TELFAX.ReadOnly = true;
            this.txtP_TELFAX.Size = new System.Drawing.Size(260, 20);
            this.txtP_TELFAX.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(68, 293);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "TEL/FAX:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtK_Email);
            this.groupBox2.Controls.Add(this.txtK_Naziv);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtK_Adresa);
            this.groupBox2.Controls.Add(this.txtK_OIB);
            this.groupBox2.Location = new System.Drawing.Point(815, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 144);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Klijent";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 26;
            this.label22.Text = "Email:";
            // 
            // txtK_Email
            // 
            this.txtK_Email.Location = new System.Drawing.Point(60, 105);
            this.txtK_Email.Name = "txtK_Email";
            this.txtK_Email.ReadOnly = true;
            this.txtK_Email.Size = new System.Drawing.Size(179, 20);
            this.txtK_Email.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(246, 618);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Rok plaćanja:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(849, 595);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Ukupno:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(826, 647);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "Ukupni iznos:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(842, 621);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "PDV 25%:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(810, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(181, 37);
            this.label21.TabIndex = 48;
            this.label21.Text = "Račun broj:";
            // 
            // lblBrojRacuna
            // 
            this.lblBrojRacuna.AutoSize = true;
            this.lblBrojRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojRacuna.Location = new System.Drawing.Point(984, 78);
            this.lblBrojRacuna.Name = "lblBrojRacuna";
            this.lblBrojRacuna.Size = new System.Drawing.Size(171, 37);
            this.lblBrojRacuna.TabIndex = 49;
            this.lblBrojRacuna.Text = "Novi račun";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(1171, 730);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 40);
            this.button1.TabIndex = 50;
            this.button1.Text = "Natrag";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPDFpregled
            // 
            this.btnPDFpregled.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPDFpregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPDFpregled.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPDFpregled.Location = new System.Drawing.Point(172, 730);
            this.btnPDFpregled.Name = "btnPDFpregled";
            this.btnPDFpregled.Size = new System.Drawing.Size(147, 40);
            this.btnPDFpregled.TabIndex = 51;
            this.btnPDFpregled.Text = "Pregled PDF-a";
            this.btnPDFpregled.UseVisualStyleBackColor = false;
            this.btnPDFpregled.Click += new System.EventHandler(this.btnPDFpregled_Click);
            // 
            // btnIzdajRacun
            // 
            this.btnIzdajRacun.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzdajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzdajRacun.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzdajRacun.Location = new System.Drawing.Point(12, 730);
            this.btnIzdajRacun.Name = "btnIzdajRacun";
            this.btnIzdajRacun.Size = new System.Drawing.Size(147, 40);
            this.btnIzdajRacun.TabIndex = 52;
            this.btnIzdajRacun.Text = "Izdaj račun";
            this.btnIzdajRacun.UseVisualStyleBackColor = false;
            this.btnIzdajRacun.Click += new System.EventHandler(this.btnIzdajRacun_Click);
            // 
            // btnDodajStavke
            // 
            this.btnDodajStavke.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodajStavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajStavke.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajStavke.Location = new System.Drawing.Point(1088, 383);
            this.btnDodajStavke.Name = "btnDodajStavke";
            this.btnDodajStavke.Size = new System.Drawing.Size(147, 196);
            this.btnDodajStavke.TabIndex = 53;
            this.btnDodajStavke.Text = "Upravljanje stavkama";
            this.btnDodajStavke.UseVisualStyleBackColor = false;
            this.btnDodajStavke.Click += new System.EventHandler(this.btnDodajStavke_Click);
            // 
            // FrmIzdajNoviRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 777);
            this.Controls.Add(this.btnDodajStavke);
            this.Controls.Add(this.btnIzdajRacun);
            this.Controls.Add(this.btnPDFpregled);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBrojRacuna);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUkupniIznos);
            this.Controls.Add(this.txtPDV);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.txtRokPlacanja);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNacinPlacanja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbKlijenti);
            this.Controls.Add(this.chkAutoEmail);
            this.Controls.Add(this.dgvStavke);
            this.Name = "FrmIzdajNoviRacun";
            this.Text = "Izdavanje novog računa";
            this.Load += new System.EventHandler(this.FrmIzdajNoviRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.CheckBox chkAutoEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKlijenti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtP_ObrtniRegistar;
        private System.Windows.Forms.TextBox txtP_BrObrtnice;
        private System.Windows.Forms.TextBox txtP_OIB;
        private System.Windows.Forms.TextBox txtP_Poslovnica;
        private System.Windows.Forms.TextBox txtP_Ulica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtK_Naziv;
        private System.Windows.Forms.TextBox txtK_Adresa;
        private System.Windows.Forms.TextBox txtK_OIB;
        private System.Windows.Forms.TextBox txtNacinPlacanja;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRokPlacanja;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.TextBox txtPDV;
        private System.Windows.Forms.TextBox txtUkupniIznos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtP_Mjesto;
        private System.Windows.Forms.TextBox txtP_Drzava;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtP_Banka;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtP_IBAN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtP_BrojMobitela;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtP_TELFAX;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblBrojRacuna;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtK_Email;
        private System.Windows.Forms.TextBox txtP_Naziv;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPDFpregled;
        private System.Windows.Forms.Button btnIzdajRacun;
        private System.Windows.Forms.Button btnDodajStavke;
    }
}