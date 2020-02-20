using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.Previsao_entrega
{
    public partial class RelPrevisaoEntrega : Form
    {
        public RelPrevisaoEntrega()
        {
            InitializeComponent();
        }

        private void RelPrevisaoEntrega_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.ZoomPercent = 100;

            // TODO: esta linha de código carrega dados na tabela 'DsPrevisaoEntrega.Previsao_Entrega'. Você pode movê-la ou removê-la conforme necessário.
            this.Previsao_EntregaTableAdapter.Fill(this.DsPrevisaoEntrega.Previsao_Entrega);

            this.reportViewer1.RefreshReport();
        }
    }
}
