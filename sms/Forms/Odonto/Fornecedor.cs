using Atencao_Assistida.Classes.Funcoes;
using Atencao_Assistida.Relatorios.Fornecedor;
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
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {
            BuscaFornecedor();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Fornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void BuscaFornecedor()
        {

            var departamento = Usuario.Coddepartamento.ToString();

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[5];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.Fornecedor.SelectTudo(int.Parse(departamento));

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODFORNECEDOR"));


                    if (!dr.IsDBNull(dr.GetOrdinal("CNPJ")))
                    {
                        linhaDados[1] = dr.GetString(dr.GetOrdinal("CNPJ"));
                    }
                    else
                    {
                        linhaDados[1] = "";
                    }

                    linhaDados[2] = dr.GetString(dr.GetOrdinal("NOME"));
                    linhaDados[3] = dr.GetString(dr.GetOrdinal("TELEFONE"));
                    linhaDados[4] = dr.GetString(dr.GetOrdinal("EMAIL"));

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
            txtCnjp.Text = "";
            txtDescricao.Text = "";
            txttelefone.Text = "";
            txtemail.Text = "";

            BuscaFornecedor();
            txtDescricao.Focus();

        }

        private void Gravar(bool novo, int codigo)
        {

            var hoje = DateTime.Now;
            var descricao = txtDescricao.Text.Trim();

            var cnpj = Funcoes.RetiraAcentos(txtCnjp.Text.Trim());
            var ativo = "S";// cmbativo.SelectedValue.ToString();
            var telefone = txttelefone.Text;
            var email = txtemail.Text;

            var respinclusao = Usuario.Nomeusuario.ToString();
            var datainclusao = hoje.ToString();
            var respalteracao = Usuario.Nomeusuario.ToString();
            var dataalteracao = hoje.ToString();
            var excluido = "N";
            var departamento = Usuario.Coddepartamento.ToString();

            try
            {
                var m = new Classes.Mysql.Fornecedor(codigo, descricao, cnpj, telefone, email, ativo,
                     respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao, excluido, int.Parse(departamento));
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
       
        private void btnListar_Click(object sender, EventArgs e)
        {
            Relatorio();
        }

        private void Relatorio()
        {
            var cria = new CriaArquivo();
            cria.Cria_Fornecedor();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Fornecedor.SelectTudoRel();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    var codfornecedor = dr.GetString(dr.GetOrdinal("CODFORNECEDOR"));
                    var nomefornecedor = dr.GetString(dr.GetOrdinal("NOMEFORNECEDOR"));

                    var coddepartamento = dr.GetString(dr.GetOrdinal("CODDEPARTAMENTO"));
                    var nomedepartamento = dr.GetString(dr.GetOrdinal("NOMEDEPARTAMENTO"));

                    var cnpj = dr.GetString(dr.GetOrdinal("CNPJ"));
                    var telefone = dr.GetString(dr.GetOrdinal("TELEFONE"));
                    var email = dr.GetString(dr.GetOrdinal("EMAIL"));

                    var respinclusao = dr.GetString(dr.GetOrdinal("RESPINCLUSAO"));
                    var datahorainclusao = dr.GetString(dr.GetOrdinal("DATAHORAINCLUSAO"));
                    var respalteracao = dr.GetString(dr.GetOrdinal("RESPALTERACAO"));
                    var datahoraalteracao = dr.GetString(dr.GetOrdinal("DATAHORAALTERACAO"));


                    try
                    {
                        var m = new Classes.Mysql.Fornecedor();

                        m.InsertAccess(int.Parse(codfornecedor), nomefornecedor, int.Parse(coddepartamento), nomedepartamento,
                            cnpj, telefone, email, respinclusao, datahorainclusao, respalteracao, datahoraalteracao);
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
                if (form is RelFornecedor)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelFornecedor();
                tela.ShowDialog();
            }

        }


        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                txtCodigo.Text = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                txtCnjp.Text = Grid.Rows[RowsIndex].Cells[1].Value.ToString();
                txtDescricao.Text = Grid.Rows[RowsIndex].Cells[2].Value.ToString();
                txttelefone.Text = Grid.Rows[RowsIndex].Cells[3].Value.ToString();
                txtemail.Text = Grid.Rows[RowsIndex].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
