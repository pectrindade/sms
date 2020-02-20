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
    public partial class PesquisaOficio : Form
    {
        public PesquisaOficio()
        {
            InitializeComponent();
        }

        private void PesquisaOficio_Load(object sender, EventArgs e)
        {
            Carrega();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Carrega()
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[5];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();
            MySql.Data.MySqlClient.MySqlDataReader dr = null;


            if (Parametros.Pesq == "Devolve")
            {
                dr = Classes.Mysql.Pedido.PesqSaidaOficio("FECHADO", int.Parse(Usuario.Coddepartamento.ToString()), 1, 1);
            }
            else
            {
                dr = Classes.Mysql.Pedido.PesqSaidaOficio(int.Parse(Usuario.Coddepartamento.ToString()));
            }

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("NUMEROPEDIDO"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("DATAPEDIDO"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("CODUNIDADE"));
                    linhaDados[3] = dr.GetString(dr.GetOrdinal("UNIDADE"));
                    linhaDados[4] = dr.GetString(dr.GetOrdinal("CODPEDIDO"));

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();



        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {






        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                var Codigo = Grid.Rows[RowsIndex].Cells[4].Value.ToString();
                var Descricao = Grid.Rows[RowsIndex].Cells[1].Value.ToString();

                Parametros.Valor = Grid.Rows[RowsIndex].Cells[4].Value.ToString();

                Close();
            }
            catch
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
