using Atencao_Assistida.Classes.Mysql;
using Atencao_Assistida.Pesquisas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Forms
{
    public partial class AcessoUsuarios : Form
    {
        public AcessoUsuarios()
        {
            InitializeComponent();
        }

        private void AcessoUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void AcessoUsuarios_Load(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProcuraUsuario_Click(object sender, EventArgs e)
        {
            Parametros.Form = "Usuario";
            Parametros.Valor = "";

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaUsuario")
                {
                    if (form is PesquisaUsuario)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {
                Form tela = new PesquisaUsuario();
                tela.ShowDialog();
                RetornoPesquisaUsuario();

            }
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "")
            {
                BuscaUsuario(int.Parse(txtcodigo.Text));
            }
        }

        public void RetornoPesquisaUsuario()
        {
            if (Parametros.Valor != "")
            {
                BuscaUsuario(int.Parse(Parametros.Valor));
            }
        }

        private void BuscaUsuario(int codigo)
        {
            if (Parametros.Valor != "")
            {
                codigo = int.Parse(Parametros.Valor);
            }

            txtcodigo.Text = "";
            txtnome.Text = "";

    var dr = Acessos.Select(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtcodigo.Text = dr.GetInt32(dr.GetOrdinal("CODUSUARIO")).ToString();
                    txtnome.Text = dr.GetString(dr.GetOrdinal("NOME"));

                }

            }

            dr.Close();
            dr.Dispose();


            if (txtcodigo.Text != "")
            {
                CarregaGrid(int.Parse(txtcodigo.Text));
            }
           
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            GridAdd();
        }

        private void GridAdd()
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[7];

            linhaDados[0] = txtcodigoTela.Text;
            linhaDados[1] = txtmenu.Text;

            linhaDados[2] = txtTela.Text;
            linhaDados[3] = cmbGravar.Text;

            linhaDados[4] = CmbEditar.Text;
            linhaDados[5] = CmbExcuir.Text;
            linhaDados[6] = CmbListar.Text;

            Grid.Rows.Add(linhaDados);

            txtcodigoTela.Text = "";
            txtmenu.Text = "";
            txtTela.Text = "";
            cmbGravar.Text = "";
            CmbEditar.Text = "";
            CmbExcuir.Text = "";
            CmbListar.Text = "";
            txtcodigoTela.Focus();
        }

        private void CarregaGrid(int valor)
        {
            
            //define um array de strings com nColunas
            string[] linhaDados = new string[7];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Acessos.BuscaAcessos(valor);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODFORM"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("REFERENTE"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("NOME"));
                    linhaDados[3] = dr.GetString(dr.GetOrdinal("GRAVAR"));
                    linhaDados[4] = dr.GetString(dr.GetOrdinal("EDITAR"));
                    linhaDados[5] = dr.GetString(dr.GetOrdinal("EXCLUIR"));
                    linhaDados[6] = dr.GetString(dr.GetOrdinal("IMPRIMIR"));

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid.CurrentRow == null) return;
            Grid.Rows.RemoveAt(Grid.CurrentRow.Index);
        }

        private void btnBuscaTela_Click(object sender, EventArgs e)
        {
            Parametros.Form = "Usuario";
            Parametros.Valor = "";

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaUsuario")
                {
                    if (form is PesquisaTela)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {
                Form tela = new PesquisaTela();
                tela.ShowDialog();
                RetornoPesquisaTela();

            }
        }

        private void txtcodigoTela_Leave(object sender, EventArgs e)
        {
            RetornoPesquisaTela();
        }

        public void RetornoPesquisaTela()
        {
            int codigo = 0;
            if (Parametros.Valor != "")
            {
                txtcodigoTela.Text = Parametros.Valor;

                codigo = int.Parse(txtcodigoTela.Text);
            }

            if (txtcodigoTela.Text.Trim() != "")
            {                
                codigo = int.Parse(txtcodigoTela.Text);
            }

            var dr = Acessos.BuscaForm(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtcodigoTela.Text = dr.GetInt32(dr.GetOrdinal("CODFORM")).ToString();
                    txtTela.Text = dr.GetString(dr.GetOrdinal("NOMEMENU"));
                    txtmenu.Text = dr.GetString(dr.GetOrdinal("LOCAL"));
                    //CmbEditar.Text = dr.GetString(dr.GetOrdinal("EDITAR"));
                    //CmbExcuir.Text = dr.GetString(dr.GetOrdinal("EXCLUIR"));
                    //CmbListar.Text = dr.GetString(dr.GetOrdinal("IMPRIMIR"));

                }

            }

            dr.Close();
            dr.Dispose();
        }

        private void BuscaTela(int codigo)
        {
            if (Parametros.Valor != "")
            {
                codigo = int.Parse(Parametros.Valor);
            }


            var dr = Acessos.Select(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtcodigo.Text = dr.GetInt32(dr.GetOrdinal("CODUSUARIO")).ToString();
                    txtnome.Text = dr.GetString(dr.GetOrdinal("NOME"));

                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void Gravar_Acessos(string codUsuario)
        {

            var d = new Acessos();

            d.Delete_Item(int.Parse(codUsuario));

            var Linhas = Grid.Rows.Count;
            if (Linhas != 1)
            {
                foreach (DataGridViewRow linha1 in Grid.Rows)
                {
                    try
                    {   
                        var codform = linha1.Cells[0].Value.ToString();
                        var gravar = linha1.Cells[3].Value.ToString();
                        var editar = linha1.Cells[4].Value.ToString();
                        var excluir = linha1.Cells[5].Value.ToString();
                        var listar = linha1.Cells[6].Value.ToString();

                        var mi = new Acessos();

                        mi.GravaPermissao(int.Parse(codUsuario), int.Parse(codform), gravar, editar, excluir, listar);
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtcodigo.Text.Trim() != "")
            {
                Gravar_Acessos(txtcodigo.Text.Trim());
            }
            LimpaTela();
        }

        private void LimpaTela()
        {
            txtcodigo.Text = "";
            txtnome.Text = "";
            txtmenu.Text = "";
            txtcodigoTela.Text = "";
            txtTela.Text = "";
            cmbGravar.Text = "";
            CmbEditar.Text = "";
            CmbExcuir.Text = "";
            CmbListar.Text = "";
            Grid.Rows.Clear();
            Grid.Refresh();
            txtcodigo.Focus();
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }
    }
}
