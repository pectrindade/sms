using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.Produto
{
    public partial class RelProdutos : Form
    {
        public RelProdutos()
        {
            InitializeComponent();
        }

        private void RelProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DsProdutos.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.ZoomPercent = 100;

            this.ProdutosTableAdapter.Fill(this.DsProdutos.Produtos);

            this.reportViewer1.RefreshReport();
        }
    }
}
