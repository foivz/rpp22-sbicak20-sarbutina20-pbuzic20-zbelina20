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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.radniNalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewRadniNalozi = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.radniNalogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radniNalogBindingSource
            // 
            this.radniNalogBindingSource.DataSource = typeof(EntitiesLayer.Entities.RadniNalog);
            // 
            // reportViewRadniNalozi
            // 
            this.reportViewRadniNalozi.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.radniNalogBindingSource;
            this.reportViewRadniNalozi.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewRadniNalozi.LocalReport.ReportEmbeddedResource = "ZMGDesktop.rptRadniNalozi.rdlc";
            this.reportViewRadniNalozi.Location = new System.Drawing.Point(0, 0);
            this.reportViewRadniNalozi.Name = "reportViewRadniNalozi";
            this.reportViewRadniNalozi.ServerReport.BearerToken = null;
            this.reportViewRadniNalozi.Size = new System.Drawing.Size(1051, 450);
            this.reportViewRadniNalozi.TabIndex = 0;
            // 
            // FrmKreirajIzvjestajRadnihNaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.reportViewRadniNalozi);
            this.Name = "FrmKreirajIzvjestajRadnihNaloga";
            this.Text = "Izvještaj radnih naloga";
            this.Load += new System.EventHandler(this.FrmKreirajIzvjestajRadnihNaloga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radniNalogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewRadniNalozi;
        private System.Windows.Forms.BindingSource radniNalogBindingSource;
    }
}