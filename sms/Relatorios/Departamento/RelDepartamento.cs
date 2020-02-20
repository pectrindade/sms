using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.Departamento
{
    public partial class RelDepartamento : Form
    {
        public RelDepartamento()
        {
            InitializeComponent();
        }

        private void RelDepartamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DsDepartamento.Departamento'. Você pode movê-la ou removê-la conforme necessário.
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.ZoomPercent = 100;

           
            this.DepartamentoTableAdapter.Fill(this.DsDepartamento.Departamento);

            this.reportViewer1.RefreshReport();
                                              
        }
    }
}
