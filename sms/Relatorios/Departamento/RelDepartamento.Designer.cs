namespace Atencao_Assistida.Relatorios.Departamento
{
    partial class RelDepartamento
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
            this.DsDepartamento = new Atencao_Assistida.Relatorios.Departamento.DsDepartamento();
            this.DepartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DepartamentoTableAdapter = new Atencao_Assistida.Relatorios.Departamento.DsDepartamentoTableAdapters.DepartamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsDepartamento";
            reportDataSource1.Value = this.DepartamentoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Departamento.RelDepartamento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsDepartamento
            // 
            this.DsDepartamento.DataSetName = "DsDepartamento";
            this.DsDepartamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DepartamentoBindingSource
            // 
            this.DepartamentoBindingSource.DataMember = "Departamento";
            this.DepartamentoBindingSource.DataSource = this.DsDepartamento;
            // 
            // DepartamentoTableAdapter
            // 
            this.DepartamentoTableAdapter.ClearBeforeFill = true;
            // 
            // RelDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelDepartamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DepartamentoBindingSource;
        private DsDepartamento DsDepartamento;
        private DsDepartamentoTableAdapters.DepartamentoTableAdapter DepartamentoTableAdapter;
    }
}