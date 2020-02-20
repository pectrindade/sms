namespace Atencao_Assistida.Relatorios.Protocolo
{
    partial class RelProtocolo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsProtocolo1 = new Atencao_Assistida.Relatorios.Protocolo.DsProtocolo1();
            this.ProtocoloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProtocoloTableAdapter = new Atencao_Assistida.Relatorios.Protocolo.DsProtocolo1TableAdapters.ProtocoloTableAdapter();
            this.Protocolo_itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Protocolo_itemTableAdapter = new Atencao_Assistida.Relatorios.Protocolo.DsProtocolo1TableAdapters.Protocolo_itemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsProtocolo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProtocoloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Protocolo_itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProtocoloBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.Protocolo_itemBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Protocolo.RelProtocolo1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsProtocolo1
            // 
            this.DsProtocolo1.DataSetName = "DsProtocolo1";
            this.DsProtocolo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProtocoloBindingSource
            // 
            this.ProtocoloBindingSource.DataMember = "Protocolo";
            this.ProtocoloBindingSource.DataSource = this.DsProtocolo1;
            // 
            // ProtocoloTableAdapter
            // 
            this.ProtocoloTableAdapter.ClearBeforeFill = true;
            // 
            // Protocolo_itemBindingSource
            // 
            this.Protocolo_itemBindingSource.DataMember = "Protocolo_item";
            this.Protocolo_itemBindingSource.DataSource = this.DsProtocolo1;
            // 
            // Protocolo_itemTableAdapter
            // 
            this.Protocolo_itemTableAdapter.ClearBeforeFill = true;
            // 
            // RelProtocolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelProtocolo";
            this.Text = "RelProtocolo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelProtocolo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsProtocolo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProtocoloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Protocolo_itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProtocoloBindingSource;
        private DsProtocolo1 DsProtocolo1;
        private System.Windows.Forms.BindingSource Protocolo_itemBindingSource;
        private DsProtocolo1TableAdapters.ProtocoloTableAdapter ProtocoloTableAdapter;
        private DsProtocolo1TableAdapters.Protocolo_itemTableAdapter Protocolo_itemTableAdapter;
    }
}