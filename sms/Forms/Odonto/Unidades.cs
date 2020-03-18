using Atencao_Assistida.Classes.Funcoes;
using Atencao_Assistida.Relatorios.Unidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Forms.Odonto
{
    public partial class Unidades : Form
    {
        public Unidades()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Unidades_Load(object sender, EventArgs e)
        {
            BuscaUnidades();
        }

        private void Unidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void BuscaUnidades()
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[6];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.Unidade.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODUNIDADE"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NOME"));


                    if (!dr.IsDBNull(dr.GetOrdinal("TELEFONE")))
                    {
                        linhaDados[2] = dr.GetString(dr.GetOrdinal("TELEFONE"));
                    }
                    else
                    {
                        linhaDados[2] = "";
                    }

                    if (!dr.IsDBNull(dr.GetOrdinal("EMAIL")))
                    { 
                        linhaDados[3] = dr.GetString(dr.GetOrdinal("EMAIL"));
                    }
                    else
                    {
                        linhaDados[3] = "";
                    }

                    if (!dr.IsDBNull(dr.GetOrdinal("ENDERECO")))
                    { 
                        linhaDados[4] = dr.GetString(dr.GetOrdinal("ENDERECO"));
                    }
                    else
                    {
                        linhaDados[4] = "";
                    }

                    if (!dr.IsDBNull(dr.GetOrdinal("BAIRRO")))
                    { 
                        linhaDados[5] = dr.GetString(dr.GetOrdinal("BAIRRO"));
                    }
                    else
                    {
                        linhaDados[5] = "";
                    }

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void btnDesfaz_Click(object sender, EventArgs e)
        {
            Limpatela();
        }

        private void Limpatela()
        {
            txtCodigo.Text = "0";
            txtDescricao.Text = "";
            txttelefone.Text = "";
            txtemail.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";

            BuscaUnidades();
            txtDescricao.Focus();

        }

        private void Gravar(bool novo, int codigo)
        {
            if (txtDescricao.Text.Trim() == "") { MessageBox.Show("Nome é campo Obrigatório"); txtDescricao.Focus(); return; }

            var hoje = DateTime.Now;
            var descricao = txtDescricao.Text.Trim();
            var ativo = "S";// cmbativo.SelectedValue.ToString();
            var telefone = txttelefone.Text;
            var email = txtemail.Text;
            var endereco = txtEndereco.Text;
            var bairro = txtBairro.Text;

            var respinclusao = Usuario.Nomeusuario.ToString();
            var datainclusao = hoje.ToString();
            var respalteracao = Usuario.Nomeusuario.ToString();
            var dataalteracao = hoje.ToString();
            var excluido = "N";

            try
            {
                var m = new Classes.Mysql.Unidade(codigo, descricao, telefone, email, endereco, bairro, ativo,
                     respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao, excluido);
                if (novo)
                    m.Insert();
                else
                    m.Update();

                MessageBox.Show("Registro Gravado com Sucesso !");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Persistência");
            }

            Limpatela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "0")
            {

                Gravar(true, 0);

            }
            else
            {

                Gravar(false, int.Parse(txtCodigo.Text.Trim()));

            }
        }

        private void Relatorio()
        {
            string telefone = "";
            var email = "";
            var endereco = "";
            var bairro = "";

            var respinclusao = "";
            var datahorainclusao = "0000-00-00 00:00:00";
            var respalteracao = "";
            var datahoraalteracao = "0000-00-00 00:00:00";

            var cria = new CriaArquivo();
            cria.Cria_Unidade();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Unidade.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    respinclusao = "";
                    datahorainclusao = "0000-00-00 00:00:00";
                    respalteracao = "";
                    datahoraalteracao = "0000-00-00 00:00:00";


                    var cod = dr.GetString(dr.GetOrdinal("CODUNIDADE"));
                    var nome = dr.GetString(dr.GetOrdinal("NOME"));



                    if (!dr.IsDBNull(dr.GetOrdinal("TELEFONE"))) { telefone = dr.GetString(dr.GetOrdinal("TELEFONE")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("EMAIL"))) { email = dr.GetString(dr.GetOrdinal("EMAIL")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("ENDERECO"))) { endereco = dr.GetString(dr.GetOrdinal("ENDERECO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("BAIRRO"))) { bairro = dr.GetString(dr.GetOrdinal("BAIRRO")); }

                    if (!dr.IsDBNull(dr.GetOrdinal("RESPINCLUSAO"))) { respinclusao = dr.GetString(dr.GetOrdinal("RESPINCLUSAO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("DATAINCLUSAO"))) { datahorainclusao = dr.GetString(dr.GetOrdinal("DATAINCLUSAO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("RESPALTERACAO"))) { respalteracao = dr.GetString(dr.GetOrdinal("RESPALTERACAO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("DATAALTERACAO"))) { datahoraalteracao = dr.GetString(dr.GetOrdinal("DATAALTERACAO")); }

                    try
                    {
                        var m = new Classes.Mysql.Unidade();

                        m.InsertAccess(int.Parse(cod), nome, telefone, email, endereco, bairro, respinclusao, datahorainclusao, respalteracao, datahoraalteracao );
                    }
                    catch (Exception erro)
                    {

                    }

                }

            }

            dr.Close();
            dr.Dispose();

            //CHAMA A TELA DE RELATORIO
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is RelUnidade)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelUnidade();
                tela.ShowDialog();
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Relatorio();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                txtCodigo.Text = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                txtDescricao.Text = Grid.Rows[RowsIndex].Cells[1].Value.ToString();
                txttelefone.Text = Grid.Rows[RowsIndex].Cells[2].Value.ToString();
                txtemail.Text = Grid.Rows[RowsIndex].Cells[3].Value.ToString();
                txtEndereco.Text = Grid.Rows[RowsIndex].Cells[4].Value.ToString();
                txtBairro.Text = Grid.Rows[RowsIndex].Cells[5].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
