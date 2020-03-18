namespace Atencao_Assistida.Relatorios.Requisicao_Periodo
{
    partial class RelRequisicaoPeriodo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    //if (disposing && (components != null))
        //    //{
        //    //    components.Dispose();
        //    //}
        //    //base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PedidoPeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsRequisicaoPeriodo = new Atencao_Assistida.Relatorios.Requisicao_Periodo.DsRequisicaoPeriodo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PedidoPeriodoTableAdapter = new Atencao_Assistida.Relatorios.Requisicao_Periodo.DsRequisicaoPeriodoTableAdapters.PedidoPeriodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PedidoPeriodoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsRequisicaoPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // PedidoPeriodoBindingSource
            // 
            this.PedidoPeriodoBindingSource.DataMember = "PedidoPeriodo";
            this.PedidoPeriodoBindingSource.DataSource = this.DsRequisicaoPeriodo;
            // 
            // DsRequisicaoPeriodo
            // 
            this.DsRequisicaoPeriodo.DataSetName = "DsRequisicaoPeriodo";
            this.DsRequisicaoPeriodo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsRequisicaoPeriodo";
            reportDataSource1.Value = this.PedidoPeriodoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Requisicao_Periodo.RelRequisicaoPeriodo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(848, 489);
            this.reportViewer1.TabIndex = 0;
            // 
            // PedidoPeriodoTableAdapter
            // 
            this.PedidoPeriodoTableAdapter.ClearBeforeFill = true;
            // 
            // RelRequisicaoPeriodo
            // 
            this.ClientSize = new System.Drawing.Size(848, 489);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelRequisicaoPeriodo";
            this.Text = "Pdidos por Período";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelRequisicaoPeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidoPeriodoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsRequisicaoPeriodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PedidoPeriodoBindingSource;
        private DsRequisicaoPeriodo DsRequisicaoPeriodo;
        private DsRequisicaoPeriodoTableAdapters.PedidoPeriodoTableAdapter PedidoPeriodoTableAdapter;
    }
}