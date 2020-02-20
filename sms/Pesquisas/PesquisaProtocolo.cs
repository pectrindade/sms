using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Pesquisas
{
    public partial class PesquisaProtocolo : Form
    {
        public PesquisaProtocolo()
        {
            InitializeComponent();
        }

        private void PesquisaProtocolo_Load(object sender, EventArgs e)
        {
            Carrega("", txtpesquisa.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Carrega( string por, string valor)
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[3];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.Protocolo.Select(por, valor);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    
                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODPROTOCOLO"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NUMEROPROTOCOLO"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("NOME"));

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
           

            if (RbBusca1.Checked)
            {
               
                Carrega("NOME", txtpesquisa.Text);

            }
            if (RbBusca2.Checked)
            {
               
                Carrega("SUS", txtpesquisa.Text);

            }
            //if (RbBusca3.Checked)
            //{
               
            //    Carrega("CPF", txtpesquisa.Text);

            //}

        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                var Codigo = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                var Descricao = Grid.Rows[RowsIndex].Cells[1].Value.ToString();

                Parametros.Valor = Grid.Rows[RowsIndex].Cells[0].Value.ToString();

                                             


                if (Parametros.Form == "Processo")
                {




                }

                Close();
            }
            catch
            {

            }
        }

        private void PesquisaProtocolo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Close(); }
        }
    }
}
