namespace Atencao_Assistida.Relatorios.Saldo
{
    partial class RelSaldo
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsSaldo = new Atencao_Assistida.Relatorios.Saldo.DsSaldo();
            this.SaldoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaldoTableAdapter = new Atencao_Assistida.Relatorios.Saldo.DsSaldoTableAdapters.SaldoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaldoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsSaldo";
            reportDataSource1.Value = this.SaldoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Saldo.RelSaldo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsSaldo
            // 
            this.DsSaldo.DataSetName = "DsSaldo";
            this.DsSaldo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaldoBindingSource
            // 
            this.SaldoBindingSource.DataMember = "Saldo";
            this.SaldoBindingSource.DataSource = this.DsSaldo;
            // 
            // SaldoTableAdapter
            // 
            this.SaldoTableAdapter.ClearBeforeFill = true;
            // 
            // RelSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelSaldo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelSaldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaldoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SaldoBindingSource;
        private DsSaldo DsSaldo;
        private DsSaldoTableAdapters.SaldoTableAdapter SaldoTableAdapter;
    }
}