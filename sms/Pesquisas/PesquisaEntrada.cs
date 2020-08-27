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
    public partial class PesquisaEntrada : Form
    {
        public PesquisaEntrada()
        {
            InitializeComponent();
        }

        private void PesquisaEntrada_Load(object sender, EventArgs e)
        {
            Carrega("", "");
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {

            if (Rb1.Checked == true)
            {
                Carrega("nota", txtpesquisa.Text);
            }
            else if (Rb2.Checked == true)
            {
                Carrega("fornecedor", txtpesquisa.Text);
            }
            //else if (Rb3.Checked == true)
            //{
            //    Carrega("recebimento", txtpesquisa.Text);
            //}
        }

        private void Carrega(string por, string valor)
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[7];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.Entrada.PesquisaNota(por, valor);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODEMPRESA"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("CFOP"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("NUMERONOTA"));
                    linhaDados[3] = dr.GetString(dr.GetOrdinal("SERIE"));
                    linhaDados[4] = dr.GetString(dr.GetOrdinal("CODFORNECEDOR"));
                    linhaDados[5] = dr.GetString(dr.GetOrdinal("NOMEFORNECEDOR"));
                    linhaDados[6] = dr.GetString(dr.GetOrdinal("DATARECEBIMENTO"));

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                var Codigo = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                var Descricao = Grid.Rows[RowsIndex].Cells[1].Value.ToString();

                Parametros.Valor = Grid.Rows[RowsIndex].Cells[2].Value.ToString();
                Parametros.Nome = Grid.Rows[RowsIndex].Cells[3].Value.ToString();

                Close();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Rb1_Click(object sender, EventArgs e)
        {
            txtpesquisa.Text = "";
        }

       
    }
}
