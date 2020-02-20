namespace Atencao_Assistida.Relatorios.Marca
{
    partial class RelMarca
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
            this.MarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsMarca = new Atencao_Assistida.Relatorios.Marca.DsMarca();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MarcaTableAdapter = new Atencao_Assistida.Relatorios.Marca.DsMarcaTableAdapters.MarcaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // MarcaBindingSource
            // 
            this.MarcaBindingSource.DataMember = "Marca";
            this.MarcaBindingSource.DataSource = this.DsMarca;
            // 
            // DsMarca
            // 
            this.DsMarca.DataSetName = "DsMarca";
            this.DsMarca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsMarca";
            reportDataSource1.Value = this.MarcaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Marca.RelMarca.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // MarcaTableAdapter
            // 
            this.MarcaTableAdapter.ClearBeforeFill = true;
            // 
            // RelMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelMarca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MarcaBindingSource;
        private DsMarca DsMarca;
        private DsMarcaTableAdapters.MarcaTableAdapter MarcaTableAdapter;
    }
}