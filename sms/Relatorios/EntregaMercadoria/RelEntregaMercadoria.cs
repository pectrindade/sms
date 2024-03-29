﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.EntregaMercadoria
{
    public partial class RelEntregaMercadoria : Form
    {
        public RelEntregaMercadoria()
        {
            InitializeComponent();
        }

        private void RelEntregaMercadoria_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.ZoomPercent = 100;

            // TODO: esta linha de código carrega dados na tabela 'DsEntregaMercadoria.EntregaMercadoria_item'. Você pode movê-la ou removê-la conforme necessário.
            this.EntregaMercadoria_itemTableAdapter.Fill(this.DsEntregaMercadoria.EntregaMercadoria_item);
            // TODO: esta linha de código carrega dados na tabela 'DsEntregaMercadoria.EntregaMercadoria'. Você pode movê-la ou removê-la conforme necessário.
            this.EntregaMercadoriaTableAdapter.Fill(this.DsEntregaMercadoria.EntregaMercadoria);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
