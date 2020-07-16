using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.Estoque_Extrato
{
    public partial class Rel_Extrato : Form
    {
        public Rel_Extrato()
        {
            InitializeComponent();
        }

        private void Rel_Extrato_Load(object sender, EventArgs e)
        {

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.ZoomPercent = 100;

            // TODO: esta linha de código carrega dados na tabela 'DsExtrato.Extrato'. Você pode movê-la ou removê-la conforme necessário.
            this.ExtratoTableAdapter.Fill(this.DsExtrato.Extrato);

            this.reportViewer1.RefreshReport();
        }
    }
}
