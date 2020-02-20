namespace Atencao_Assistida.Relatorios.Entrada
{
    partial class RelEntrada
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
            this.DsEntrada = new Atencao_Assistida.Relatorios.Entrada.DsEntrada();
            this.EntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EntradaTableAdapter = new Atencao_Assistida.Relatorios.Entrada.DsEntradaTableAdapters.EntradaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsEntrada";
            reportDataSource1.Value = this.EntradaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Entrada.RelEntrada.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsEntrada
            // 
            this.DsEntrada.DataSetName = "DsEntrada";
            this.DsEntrada.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EntradaBindingSource
            // 
            this.EntradaBindingSource.DataMember = "Entrada";
            this.EntradaBindingSource.DataSource = this.DsEntrada;
            // 
            // EntradaTableAdapter
            // 
            this.EntradaTableAdapter.ClearBeforeFill = true;
            // 
            // RelEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelEntrada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EntradaBindingSource;
        private DsEntrada DsEntrada;
        private DsEntradaTableAdapters.EntradaTableAdapter EntradaTableAdapter;
    }
}