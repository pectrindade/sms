﻿namespace Atencao_Assistida.Relatorios.Saida_Periodo
{
    partial class RelSaidaPeriodo
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
            this.SaidaPeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsSaidaPeriodo = new Atencao_Assistida.Relatorios.Saida_Periodo.DsSaidaPeriodo();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SaidaPeriodoTableAdapter = new Atencao_Assistida.Relatorios.Saida_Periodo.DsSaidaPeriodoTableAdapters.SaidaPeriodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SaidaPeriodoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsSaidaPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // SaidaPeriodoBindingSource
            // 
            this.SaidaPeriodoBindingSource.DataMember = "SaidaPeriodo";
            this.SaidaPeriodoBindingSource.DataSource = this.DsSaidaPeriodo;
            // 
            // DsSaidaPeriodo
            // 
            this.DsSaidaPeriodo.DataSetName = "DsSaidaPeriodo";
            this.DsSaidaPeriodo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsSaidaPeriodo";
            reportDataSource1.Value = this.SaidaPeriodoBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Atencao_Assistida.Relatorios.Saida_Periodo.RelSaidaPeriodo.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(800, 450);
            this.reportViewer2.TabIndex = 1;
            // 
            // SaidaPeriodoTableAdapter
            // 
            this.SaidaPeriodoTableAdapter.ClearBeforeFill = true;
            // 
            // RelSaidaPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RelSaidaPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saída Por Período";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelSaidaPeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaidaPeriodoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsSaidaPeriodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource SaidaPeriodoBindingSource;
        private DsSaidaPeriodo DsSaidaPeriodo;
        private DsSaidaPeriodoTableAdapters.SaidaPeriodoTableAdapter SaidaPeriodoTableAdapter;
    }
}