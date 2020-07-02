using System;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.Requisicao_Periodo
{
    public partial class RelRequisicaoPeriodo : Form
    {
        public RelRequisicaoPeriodo()
        {
            InitializeComponent();
        }

        private void RelRequisicaoPeriodo_Load(object sender, EventArgs e)
        {

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.ZoomPercent = 100;

            // TODO: esta linha de código carrega dados na tabela 'DsRequisicaoPeriodo.PedidoPeriodo'. Você pode movê-la ou removê-la conforme necessário.
            this.PedidoPeriodoTableAdapter.Fill(this.DsRequisicaoPeriodo.PedidoPeriodo);

            this.reportViewer1.RefreshReport();

            

           
                if (Application.OpenForms["Espera"] != null)
                   
                    Application.OpenForms["Espera"].Close();
           
        }


    }
}
