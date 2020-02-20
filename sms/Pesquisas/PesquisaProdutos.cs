using Atencao_Assistida.Forms;
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
    public partial class PesquisaProdutos : Form
    {


        public PesquisaProdutos()
        {
            InitializeComponent();
        }

        private void PesquisaProdutos_Load(object sender, EventArgs e)
        {
            Carrega("");
        }


        private void Carrega(string valor)
        {

            DateTime data = DateTime.Now;
           // DateTime data = Convert.ToDateTime(txtDataEstoque.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[3];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var coddepartamento = Usuario.Coddepartamento.ToString();
            var codempresa = Usuario.Codempresa.ToString();

            var dr = Classes.Mysql.Produto.SelectPorNome(valor, int.Parse(coddepartamento));

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    var codproduto = dr.GetString(dr.GetOrdinal("CODPRODUTO"));

                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NOME"));
                    linhaDados[2] = "0";

                    //var dr1 = Classes.Mysql.Estoque.BuscaEstoque(int.Parse(codempresa), int.Parse(coddepartamento), vmes, vano, int.Parse(codproduto));

                    //if (dr1.HasRows)
                    //{
                    //    while (dr1.Read())
                    //    {
                    //        linhaDados[2] = dr1.GetString(dr1.GetOrdinal("QTATUAL"));
                    //    }

                    //}

                    //dr1.Close();
                    //dr1.Dispose();

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            Carrega(txtpesquisa.Text);
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                var Codigo = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                var Descricao = Grid.Rows[RowsIndex].Cells[1].Value.ToString();

                Parametros.Valor = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                Parametros.Nome = Grid.Rows[RowsIndex].Cells[1].Value.ToString();



                if (Parametros.Form == "Medicamentos")
                {
                    Form tela = new Medicamentos();
                    tela.MdiParent = MdiParent;
                    tela.Show();
                }




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

        private void PesquisaProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void PesquisaProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Close(); }
        }

        private void PesquisaProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }
    }
}

