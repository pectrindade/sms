using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.Saida_Periodo
{
    public partial class RelSaidaPeriodo : Form
    {
        public RelSaidaPeriodo()
        {
            InitializeComponent();
        }

        

        private void RelSaidaPeriodo_Load(object sender, EventArgs e)
        {


            reportViewer2.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer2.ZoomPercent = 100;

            // TODO: esta linha de código carrega dados na tabela 'DsSaidaPeriodo.SaidaPeriodo'. Você pode movê-la ou removê-la conforme necessário.
            this.SaidaPeriodoTableAdapter.Fill(this.DsSaidaPeriodo.SaidaPeriodo);

            
            this.reportViewer2.RefreshReport();

            if (Application.OpenForms["Espera"] != null)
                Application.OpenForms["Espera"].Close();
        }

       
    }
}
