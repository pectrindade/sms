namespace Atencao_Assistida.Relatorios.Estoque_Extrato
{
    partial class Rel_Extrato
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
            this.DsExtrato = new Atencao_Assistida.Relatorios.Estoque_Extrato.DsExtrato();
            this.ExtratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExtratoTableAdapter = new Atencao_Assistida.Relatorios.Estoque_Extrato.DsExtratoTableAdapters.ExtratoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsExtrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtratoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DsExtrato";
            reportDataSource2.Value = this.ExtratoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Estoque_Extrato.RelExtrato.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsExtrato
            // 
            this.DsExtrato.DataSetName = "DsExtrato";
            this.DsExtrato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExtratoBindingSource
            // 
            this.ExtratoBindingSource.DataMember = "Extrato";
            this.ExtratoBindingSource.DataSource = this.DsExtrato;
            // 
            // ExtratoTableAdapter
            // 
            this.ExtratoTableAdapter.ClearBeforeFill = true;
            // 
            // Rel_Extrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rel_Extrato";
            this.Text = "Rel_Extrato";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rel_Extrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsExtrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtratoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ExtratoBindingSource;
        private DsExtrato DsExtrato;
        private DsExtratoTableAdapters.ExtratoTableAdapter ExtratoTableAdapter;
    }
}