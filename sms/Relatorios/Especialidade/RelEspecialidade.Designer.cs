namespace Atencao_Assistida.Relatorios.Especialidade
{
    partial class RelEspecialidade
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
            this.EspecialidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsEspecialidade = new Atencao_Assistida.Relatorios.Especialidade.DsEspecialidade();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EspecialidadeTableAdapter = new Atencao_Assistida.Relatorios.Especialidade.DsEspecialidadeTableAdapters.EspecialidadeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EspecialidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsEspecialidade)).BeginInit();
            this.SuspendLayout();
            // 
            // EspecialidadeBindingSource
            // 
            this.EspecialidadeBindingSource.DataMember = "Especialidade";
            this.EspecialidadeBindingSource.DataSource = this.DsEspecialidade;
            // 
            // DsEspecialidade
            // 
            this.DsEspecialidade.DataSetName = "DsEspecialidade";
            this.DsEspecialidade.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EspecialidadeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Especialidade.RelEspecialidade.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // EspecialidadeTableAdapter
            // 
            this.EspecialidadeTableAdapter.ClearBeforeFill = true;
            // 
            // RelEspecialidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelEspecialidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelEspecialidade";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelEspecialidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EspecialidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsEspecialidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EspecialidadeBindingSource;
        private DsEspecialidade DsEspecialidade;
        private DsEspecialidadeTableAdapters.EspecialidadeTableAdapter EspecialidadeTableAdapter;
    }
}