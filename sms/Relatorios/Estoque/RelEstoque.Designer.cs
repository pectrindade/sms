namespace Atencao_Assistida.Relatorios.Estoque
{
    partial class RelEstoque
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
            this.DsEstoque = new Atencao_Assistida.Relatorios.Estoque.DsEstoque();
            this.EstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EstoqueTableAdapter = new Atencao_Assistida.Relatorios.Estoque.DsEstoqueTableAdapters.EstoqueTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DsEstoque";
            reportDataSource2.Value = this.EstoqueBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Estoque.RelEstoque.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsEstoque
            // 
            this.DsEstoque.DataSetName = "DsEstoque";
            this.DsEstoque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EstoqueBindingSource
            // 
            this.EstoqueBindingSource.DataMember = "Estoque";
            this.EstoqueBindingSource.DataSource = this.DsEstoque;
            // 
            // EstoqueTableAdapter
            // 
            this.EstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // RelEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelEstoque";
            this.Text = "RelEstoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EstoqueBindingSource;
        private DsEstoque DsEstoque;
        private DsEstoqueTableAdapters.EstoqueTableAdapter EstoqueTableAdapter;
    }
}