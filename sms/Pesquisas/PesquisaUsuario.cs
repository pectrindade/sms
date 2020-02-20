using Atencao_Assistida.Forms;
using System;
using System.Windows.Forms;

namespace Atencao_Assistida.Pesquisas
{
    public partial class PesquisaUsuario : Form
    {
        public PesquisaUsuario()
        {
            InitializeComponent();
        }

        private void PesquisaUsuario_Load(object sender, EventArgs e)
        {
            Carrega("");

        }

        private void Carrega(string valor)
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[2];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.Acessos.Selectdr(valor);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODUSUARIO"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NOME"));

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void txtpesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {

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

                if (Parametros.Form == "Usuario")
                {
                   
                }

                if (Parametros.Form == "Processo")
                {
                    
                }


                Close();
            }
            catch
            {

            }
        }

        private void PesquisaUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastraUsuario_Click(object sender, EventArgs e)
        {
            Parametros.Form = "Usuario";
            Parametros.Valor = "";

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "Usuario")
                {
                    if (form is Acesso)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {

                Form tela = new Acesso();
               
                tela.ShowDialog();
                RetornoPesquisaUsuario();


            }
        }

        public void RetornoPesquisaUsuario()
        {
            if (Parametros.Valor != "")
            {
                Close();
            }
        }


    }
}
