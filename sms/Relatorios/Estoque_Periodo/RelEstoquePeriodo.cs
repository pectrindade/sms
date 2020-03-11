using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // TODO: esta linha de código carrega dados na tabela 'DsEstoquePeriodo.Estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.EstoqueTableAdapter.Fill(this.DsEstoquePeriodo.Estoque);

            this.reportViewer1.RefreshReport();
        }
    }
}
