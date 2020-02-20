namespace Atencao_Assistida.Relatorios.Unidades
{
    partial class RelUnidade
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
            this.DsUnidade = new Atencao_Assistida.Relatorios.Unidades.DsUnidade();
            this.UnidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UnidadeTableAdapter = new Atencao_Assistida.Relatorios.Unidades.DsUnidadeTableAdapters.UnidadeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsUnidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsUnidade";
            reportDataSource1.Value = this.UnidadeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Unidades.RelUnidade.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsUnidade
            // 
            this.DsUnidade.DataSetName = "DsUnidade";
            this.DsUnidade.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UnidadeBindingSource
            // 
            this.UnidadeBindingSource.DataMember = "Unidade";
            this.UnidadeBindingSource.DataSource = this.DsUnidade;
            // 
            // UnidadeTableAdapter
            // 
            this.UnidadeTableAdapter.ClearBeforeFill = true;
            // 
            // RelUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelUnidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelUnidade";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelUnidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsUnidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UnidadeBindingSource;
        private DsUnidade DsUnidade;
        private DsUnidadeTableAdapters.UnidadeTableAdapter UnidadeTableAdapter;
    }
}