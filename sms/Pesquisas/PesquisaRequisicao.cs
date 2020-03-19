using Atencao_Assistida.Classes.Mysql;
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
    public partial class PesquisaRequisicao : Form
    {
        public PesquisaRequisicao()
        {
            InitializeComponent();
        }

        private void PesquisaRequisicao_Load(object sender, EventArgs e)
        {
            var pesquisa = Parametros.Pesq;

            if (pesquisa == "Devolve") { CarregaEstorno(); return; }
            Carrega();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Carrega()
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[6];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();
            var tipo = 0;
            var aprovado = 1;
            // tem campos globais 

            var dr = Pedido.SelectTudo(int.Parse(Usuario.Coddepartamento.ToString()), tipo, aprovado);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODPEDIDO"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NUMEROPEDIDO"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("DATAPEDIDO"));
                    linhaDados[3] = dr.GetString(dr.GetOrdinal("CODUNIDADE"));
                    linhaDados[4] = dr.GetString(dr.GetOrdinal("UNIDADE"));
                    linhaDados[5] = dr.GetString(dr.GetOrdinal("STATUS"));

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

           

        }

        private void CarregaEstorno()
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[6];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.Pedido.SelectTudoOfcReq(0,int.Parse(Usuario.Coddepartamento.ToString()), "FECHADO");

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODPEDIDO"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NUMEROPEDIDO"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("DATAPEDIDO"));
                    linhaDados[3] = dr.GetString(dr.GetOrdinal("CODUNIDADE"));
                    linhaDados[4] = dr.GetString(dr.GetOrdinal("UNIDADE"));
                    linhaDados[5] = dr.GetString(dr.GetOrdinal("STATUS"));

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
                var Codigo = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                var Descricao = Grid.Rows[RowsIndex].Cells[1].Value.ToString();

                Parametros.Valor = Grid.Rows[RowsIndex].Cells[1].Value.ToString();

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
