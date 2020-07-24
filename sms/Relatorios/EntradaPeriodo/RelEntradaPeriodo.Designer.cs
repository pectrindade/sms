namespace Atencao_Assistida.Relatorios.EntradaPeriodo
{
    partial class RelEntradaPeriodo
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
            this.DsEntradaPeriodo = new Atencao_Assistida.Relatorios.EntradaPeriodo.DsEntradaPeriodo();
            this.EntradaPeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EntradaPeriodoTableAdapter = new Atencao_Assistida.Relatorios.EntradaPeriodo.DsEntradaPeriodoTableAdapters.EntradaPeriodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsEntradaPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaPeriodoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DsEntradaPeriodo";
            reportDataSource2.Value = this.EntradaPeriodoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.EntradaPeriodo.RelEntradaPeriodo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsEntradaPeriodo
            // 
            this.DsEntradaPeriodo.DataSetName = "DsEntradaPeriodo";
            this.DsEntradaPeriodo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EntradaPeriodoBindingSource
            // 
            this.EntradaPeriodoBindingSource.DataMember = "EntradaPeriodo";
            this.EntradaPeriodoBindingSource.DataSource = this.DsEntradaPeriodo;
            // 
            // EntradaPeriodoTableAdapter
            // 
            this.EntradaPeriodoTableAdapter.ClearBeforeFill = true;
            // 
            // RelEntradaPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelEntradaPeriodo";
            this.Text = "RelEntradaPeriodo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelEntradaPeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsEntradaPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaPeriodoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EntradaPeriodoBindingSource;
        private DsEntradaPeriodo DsEntradaPeriodo;
        private DsEntradaPeriodoTableAdapters.EntradaPeriodoTableAdapter EntradaPeriodoTableAdapter;
    }
}