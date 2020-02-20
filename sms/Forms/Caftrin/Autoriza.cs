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
using Atencao_Assistida.Forms.Odonto;

namespace Atencao_Assistida.Forms.Caftrin
{
    public partial class Autoriza : Form
    {

        public Autoriza()
        {
            InitializeComponent();

        }

        private void Autoriza_Load(object sender, EventArgs e)
        {
            CarregaGrid();


        }

        private void CarregaGrid()
        {


            //define um array de strings com nCOlunas
            string[] linhaDados = new string[6];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            // parametro = 0, é Requisição
            // parametro = 1, é Oficio
            var dr = Pedido.SelectAutorizaAberto(0);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr.GetString(dr.GetOrdinal("APROVADO")) == "0")
                    {
                        linhaDados[0] = dr.GetString(dr.GetOrdinal("NUMEROPEDIDO"));
                        linhaDados[1] = dr.GetString(dr.GetOrdinal("CODEMPRESA"));
                        linhaDados[2] = dr.GetString(dr.GetOrdinal("CODDEPARTAMENTO"));
                        linhaDados[3] = dr.GetString(dr.GetOrdinal("CODPEDIDO"));
                        linhaDados[4] = dr.GetString(dr.GetOrdinal("LOTACAO"));
                        linhaDados[5] = dr.GetString(dr.GetOrdinal("DATAPEDIDO"));


                        Grid.Rows.Add(linhaDados);
                    }
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
                var codpedido = Grid.Rows[RowsIndex].Cells[3].Value.ToString();

                Parametros.Valor = Grid.Rows[RowsIndex].Cells[3].Value.ToString();

            }
            catch
            {

            }

            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Autoriza_Oficio)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Autoriza_Oficio();
                //tela.MdiParent = this;
                tela.ShowDialog();
                //tela.Show();

                RetornoPesquisaOficio();





            }
        }
        public void RetornoPesquisaOficio()
        {
            CarregaGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
