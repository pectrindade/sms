namespace Atencao_Assistida.Relatorios.Oficio
{
    partial class RelOficio
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
            this.OficioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsOficio = new Atencao_Assistida.Relatorios.Oficio.DsOficio();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OficioTableAdapter = new Atencao_Assistida.Relatorios.Oficio.DsOficioTableAdapters.OficioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OficioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsOficio)).BeginInit();
            this.SuspendLayout();
            // 
            // OficioBindingSource
            // 
            this.OficioBindingSource.DataMember = "Oficio";
            this.OficioBindingSource.DataSource = this.DsOficio;
            // 
            // DsOficio
            // 
            this.DsOficio.DataSetName = "DsOficio";
            this.DsOficio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsOficio";
            reportDataSource1.Value = this.OficioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Oficio.RelOficio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // OficioTableAdapter
            // 
            this.OficioTableAdapter.ClearBeforeFill = true;
            // 
            // RelOficio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RelOficio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelOficio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelOficio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OficioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsOficio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OficioBindingSource;
        private DsOficio DsOficio;
        private DsOficioTableAdapters.OficioTableAdapter OficioTableAdapter;
    }
}