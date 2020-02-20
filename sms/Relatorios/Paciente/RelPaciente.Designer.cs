namespace Atencao_Assistida.Relatorios.Paciente
{
    partial class RelPaciente
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
            this.DsPaciente = new Atencao_Assistida.Relatorios.Paciente.DsPaciente();
            this.PacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PacienteTableAdapter = new Atencao_Assistida.Relatorios.Paciente.DsPacienteTableAdapters.PacienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPaciente";
            reportDataSource1.Value = this.PacienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Paciente.RelPaciente1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsPaciente
            // 
            this.DsPaciente.DataSetName = "DsPaciente";
            this.DsPaciente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PacienteBindingSource
            // 
            this.PacienteBindingSource.DataMember = "Paciente";
            this.PacienteBindingSource.DataSource = this.DsPaciente;
            // 
            // PacienteTableAdapter
            // 
            this.PacienteTableAdapter.ClearBeforeFill = true;
            // 
            // RelPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelPaciente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PacienteBindingSource;
        private DsPaciente DsPaciente;
        private DsPacienteTableAdapters.PacienteTableAdapter PacienteTableAdapter;
    }
}