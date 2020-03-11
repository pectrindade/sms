namespace Atencao_Assistida.Relatorios.Estoque_Periodo
{
    partial class RelEstoquePeriodo
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
            this.DsEstoquePeriodo = new Atencao_Assistida.Relatorios.Estoque_Periodo.DsEstoquePeriodo();
            this.EstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EstoqueTableAdapter = new Atencao_Assistida.Relatorios.Estoque_Periodo.DsEstoquePeriodoTableAdapters.EstoqueTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsEstoquePeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DsEstoquePeriodo";
            reportDataSource2.Value = this.EstoqueBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Estoque_Periodo.RelEstoquePeriodo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsEstoquePeriodo
            // 
            this.DsEstoquePeriodo.DataSetName = "DsEstoquePeriodo";
            this.DsEstoquePeriodo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EstoqueBindingSource
            // 
            this.EstoqueBindingSource.DataMember = "Estoque";
            this.EstoqueBindingSource.DataSource = this.DsEstoquePeriodo;
            // 
            // EstoqueTableAdapter
            // 
            this.EstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // RelEstoquePeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RelEstoquePeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelEstoquePeriodo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelEstoquePeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsEstoquePeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EstoqueBindingSource;
        private DsEstoquePeriodo DsEstoquePeriodo;
        private DsEstoquePeriodoTableAdapters.EstoqueTableAdapter EstoqueTableAdapter;
    }
}