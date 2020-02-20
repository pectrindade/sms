namespace Atencao_Assistida.Relatorios.Previsao_entrega
{
    partial class RelPrevisaoEntrega
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsPrevisaoEntrega = new Atencao_Assistida.Relatorios.Previsao_entrega.DsPrevisaoEntrega();
            this.Previsao_EntregaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Previsao_EntregaTableAdapter = new Atencao_Assistida.Relatorios.Previsao_entrega.DsPrevisaoEntregaTableAdapters.Previsao_EntregaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsPrevisaoEntrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previsao_EntregaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Previsao_EntregaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Previsao_entrega.RelPrevisaoEntrega.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 360);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsPrevisaoEntrega
            // 
            this.DsPrevisaoEntrega.DataSetName = "DsPrevisaoEntrega";
            this.DsPrevisaoEntrega.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Previsao_EntregaBindingSource
            // 
            this.Previsao_EntregaBindingSource.DataMember = "Previsao_Entrega";
            this.Previsao_EntregaBindingSource.DataSource = this.DsPrevisaoEntrega;
            // 
            // Previsao_EntregaTableAdapter
            // 
            this.Previsao_EntregaTableAdapter.ClearBeforeFill = true;
            // 
            // RelPrevisaoEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelPrevisaoEntrega";
            this.Text = "RelPrevisaoEntrega";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelPrevisaoEntrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsPrevisaoEntrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previsao_EntregaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Previsao_EntregaBindingSource;
        private DsPrevisaoEntrega DsPrevisaoEntrega;
        private DsPrevisaoEntregaTableAdapters.Previsao_EntregaTableAdapter Previsao_EntregaTableAdapter;
    }
}