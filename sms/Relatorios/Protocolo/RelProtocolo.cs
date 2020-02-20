using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.Protocolo
{
    public partial class RelProtocolo : Form
    {
        public RelProtocolo()
        {
            InitializeComponent();
        }

        private void RelProtocolo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DsProtocolo1.Protocolo_item'. Você pode movê-la ou removê-la conforme necessário.
            this.Protocolo_itemTableAdapter.Fill(this.DsProtocolo1.Protocolo_item);

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer1.ZoomPercent = 100;

            // TODO: esta linha de código carrega dados na tabela 'DsProtocolo.Protocolo'. Você pode movê-la ou removê-la conforme necessário.
            ProtocoloTableAdapter.Fill(this.DsProtocolo1.Protocolo);

            this.reportViewer1.RefreshReport();
        }
    }
}
