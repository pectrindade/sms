namespace Atencao_Assistida.Relatorios.EntregaMercadoria
{
    partial class RelEntregaMercadoria
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EntregaMercadoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsEntregaMercadoria = new Atencao_Assistida.Relatorios.EntregaMercadoria.DsEntregaMercadoria();
            this.EntregaMercadoria_itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EntregaMercadoriaTableAdapter = new Atencao_Assistida.Relatorios.EntregaMercadoria.DsEntregaMercadoriaTableAdapters.EntregaMercadoriaTableAdapter();
            this.EntregaMercadoria_itemTableAdapter = new Atencao_Assistida.Relatorios.EntregaMercadoria.DsEntregaMercadoriaTableAdapters.EntregaMercadoria_itemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EntregaMercadoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsEntregaMercadoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntregaMercadoria_itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EntregaMercadoriaBindingSource
            // 
            this.EntregaMercadoriaBindingSource.DataMember = "EntregaMercadoria";
            this.EntregaMercadoriaBindingSource.DataSource = this.DsEntregaMercadoria;
            // 
            // DsEntregaMercadoria
            // 
            this.DsEntregaMercadoria.DataSetName = "DsEntregaMercadoria";
            this.DsEntregaMercadoria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EntregaMercadoria_itemBindingSource
            // 
            this.EntregaMercadoria_itemBindingSource.DataMember = "EntregaMercadoria_item";
            this.EntregaMercadoria_itemBindingSource.DataSource = this.DsEntregaMercadoria;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.EntregaMercadoriaBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.EntregaMercadoria_itemBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.EntregaMercadoria.RelEntregaMercadoria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // EntregaMercadoriaTableAdapter
            // 
            this.EntregaMercadoriaTableAdapter.ClearBeforeFill = true;
            // 
            // EntregaMercadoria_itemTableAdapter
            // 
            this.EntregaMercadoria_itemTableAdapter.ClearBeforeFill = true;
            // 
            // RelEntregaMercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelEntregaMercadoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelEntregaMercadoria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelEntregaMercadoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EntregaMercadoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsEntregaMercadoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntregaMercadoria_itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EntregaMercadoriaBindingSource;
        private DsEntregaMercadoria DsEntregaMercadoria;
        private DsEntregaMercadoriaTableAdapters.EntregaMercadoriaTableAdapter EntregaMercadoriaTableAdapter;
        private System.Windows.Forms.BindingSource EntregaMercadoria_itemBindingSource;
        private DsEntregaMercadoriaTableAdapters.EntregaMercadoria_itemTableAdapter EntregaMercadoria_itemTableAdapter;
    }
}