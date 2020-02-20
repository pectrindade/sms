namespace Atencao_Assistida.Relatorios.Agente
{
    partial class RelAgente
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
            this.AgenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsAgente = new Atencao_Assistida.Relatorios.Agente.DsAgente();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AgenteTableAdapter = new Atencao_Assistida.Relatorios.Agente.DsAgenteTableAdapters.AgenteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AgenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsAgente)).BeginInit();
            this.SuspendLayout();
            // 
            // AgenteBindingSource
            // 
            this.AgenteBindingSource.DataMember = "Agente";
            this.AgenteBindingSource.DataSource = this.DsAgente;
            // 
            // DsAgente
            // 
            this.DsAgente.DataSetName = "DsAgente";
            this.DsAgente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AgenteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Agente.RelAgente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // AgenteTableAdapter
            // 
            this.AgenteTableAdapter.ClearBeforeFill = true;
            // 
            // RelAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelAgente";
            this.Text = "RelAgente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelAgente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsAgente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AgenteBindingSource;
        private DsAgente DsAgente;
        private DsAgenteTableAdapters.AgenteTableAdapter AgenteTableAdapter;
    }
}