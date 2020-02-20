namespace Atencao_Assistida.Relatorios.Grupo
{
    partial class RelGrupo
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
            this.GrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsGrupo = new Atencao_Assistida.Relatorios.Grupo.DsGrupo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GrupoTableAdapter = new Atencao_Assistida.Relatorios.Grupo.DsGrupoTableAdapters.GrupoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupoBindingSource
            // 
            this.GrupoBindingSource.DataMember = "Grupo";
            this.GrupoBindingSource.DataSource = this.DsGrupo;
            // 
            // DsGrupo
            // 
            this.DsGrupo.DataSetName = "DsGrupo";
            this.DsGrupo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsGrupo";
            reportDataSource1.Value = this.GrupoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Grupo.RelGrupo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // GrupoTableAdapter
            // 
            this.GrupoTableAdapter.ClearBeforeFill = true;
            // 
            // RelGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelGrupo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsGrupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GrupoBindingSource;
        private DsGrupo DsGrupo;
        private DsGrupoTableAdapters.GrupoTableAdapter GrupoTableAdapter;
    }
}