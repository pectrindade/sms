using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.Marca
{
    public partial class RelMarca : Form
    {
        public RelMarca()
        {
            InitializeComponent();
        }

        private void RelMarca_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.ZoomPercent = 100;

            // TODO: esta linha de código carrega dados na tabela 'DsMarca.Marca'. Você pode movê-la ou removê-la conforme necessário.
            this.MarcaTableAdapter.Fill(this.DsMarca.Marca);

            this.reportViewer1.RefreshReport();
        }
    }
}
