using System;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.Estoque_Periodo
{
    public partial class RelEstoquePeriodo : Form
    {
        public RelEstoquePeriodo()
        {
            InitializeComponent();
        }

        private void RelEstoquePeriodo_Load(object sender, EventArgs e)
        {

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.ZoomPercent = 100;

            // TODO: esta linha de código carrega dados na tabela 'DsEstoquePeriodo.Estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.EstoqueTableAdapter.Fill(this.DsEstoquePeriodo.Estoque);

            this.reportViewer1.RefreshReport();

            if (Application.OpenForms["Espera"] != null)
                Application.OpenForms["Espera"].Close();

        }
    }
}
