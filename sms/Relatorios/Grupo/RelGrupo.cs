using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.Grupo
{
    public partial class RelGrupo : Form
    {
        public RelGrupo()
        {
            InitializeComponent();
        }

        private void RelGrupo_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.ZoomPercent = 100;

            // TODO: esta linha de código carrega dados na tabela 'DsGrupo.Grupo'. Você pode movê-la ou removê-la conforme necessário.
            this.GrupoTableAdapter.Fill(this.DsGrupo.Grupo);

            this.reportViewer1.RefreshReport();
        }
    }
}
