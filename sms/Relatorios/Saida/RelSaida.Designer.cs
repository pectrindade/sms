namespace Atencao_Assistida.Relatorios.Saida
{
    partial class RelSaida
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
            this.DsSaida = new Atencao_Assistida.Relatorios.Saida.DsSaida();
            this.SaidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaidaTableAdapter = new Atencao_Assistida.Relatorios.Saida.DsSaidaTableAdapters.SaidaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsSaida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsSaida";
            reportDataSource1.Value = this.SaidaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Saida.RelSaida.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsSaida
            // 
            this.DsSaida.DataSetName = "DsSaida";
            this.DsSaida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaidaBindingSource
            // 
            this.SaidaBindingSource.DataMember = "Saida";
            this.SaidaBindingSource.DataSource = this.DsSaida;
            // 
            // SaidaTableAdapter
            // 
            this.SaidaTableAdapter.ClearBeforeFill = true;
            // 
            // RelSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelSaida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelSaida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsSaida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaidaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SaidaBindingSource;
        private DsSaida DsSaida;
        private DsSaidaTableAdapters.SaidaTableAdapter SaidaTableAdapter;
    }
}