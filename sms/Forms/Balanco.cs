using Atencao_Assistida.Classes.Mysql;
using Atencao_Assistida.Pesquisas;
using Atencao_Assistida.Relatorios.Balanco;
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
    public partial class Balanço : Form
    {
        public Balanço()
        {
            InitializeComponent();
        }

        private void Balanço_Load(object sender, EventArgs e)
        {
            txtdtBalanco.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DateTime date = this.dateTimePicker1.Value;

            this.txtdtBalanco.Text = date.ToString("dd/MM/yyyy");
            BuscaBalanco();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            if (txtCodProduto.Text != "")
            {
                BuscaProduto(int.Parse(txtCodProduto.Text));
            }
            else { btnGravar.Focus(); }
        }

        public void RetornoPesquisaProdutos()
        {
            if (Parametros.Valor != "")
            {
                BuscaProduto(int.Parse(Parametros.Valor));
            }
        }

        private void BuscaProduto(int codigo)
        {
            var dr = Produto.Select(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtCodProduto.Text = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    txtNomeProduto.Text = dr.GetString(dr.GetOrdinal("NOME"));

                    txtunidade.Text = dr.GetString(dr.GetOrdinal("CODUNIDADE"));


                    if (!dr.IsDBNull(dr.GetOrdinal("NOME")))
                    { txtNomeProduto.Text = dr.GetString(dr.GetOrdinal("NOME")); }
                    else { txtNomeProduto.Text = dr.GetString(dr.GetOrdinal("DESCRICAO")); }

                    txtQuantidade.Focus();
                }
            }

            dr.Close();
            dr.Dispose();
        }

        private void BuscaBalanco()
        {

            var empresa = Usuario.Codempresa.ToString();
            var coddepartamento = Usuario.Coddepartamento.ToString();
            var databalanco = txtdtBalanco.Text.Trim();

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[4];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Balanco.SelectBalanco(int.Parse(empresa), int.Parse(coddepartamento), databalanco);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Grid.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NOMEPRODUTO"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("UNIDADE"));
                    linhaDados[3] = dr.GetString(dr.GetOrdinal("QUANTIDADE"));


                    Grid.Rows.Add(linhaDados);
                }
            }

            dr.Close();
            dr.Dispose();
        }

        private void txtdtBalanco_Leave(object sender, EventArgs e)
        {


            BuscaBalanco();
        }

        private void GridAdd()
        {
            Grid.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[6];

            linhaDados[0] = txtCodProduto.Text;
            linhaDados[1] = txtNomeProduto.Text;
            linhaDados[2] = txtunidade.Text;
            linhaDados[3] = txtQuantidade.Text;


            Grid.Rows.Add(linhaDados);

            txtCodProduto.Text = "";
            txtNomeProduto.Text = "";
            txtQuantidade.Text = "";

            txtCodProduto.Focus();
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if (txtQuantidade.Text.Trim() != "")
            {
                GridAdd();
            }
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            LimpaTela();

        }
        private void LimpaTela()
        {


            txtdtBalanco.Text = "  /  /    ";
            txtCodProduto.Text = "";
            txtNomeProduto.Text = "";
            txtQuantidade.Text = "";

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            txtdtBalanco.Text = DateTime.Now.ToString("dd/MM/yyyy");


            txtdtBalanco.Focus();

        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult result = MessageBox.Show("Deseja alterar este item da Balanço ?", "Atenção !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var RowsIndex = Grid.CurrentRow.Index;

                try
                {
                    txtCodProduto.Text = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                    txtNomeProduto.Text = Grid.Rows[RowsIndex].Cells[1].Value.ToString();
                    txtQuantidade.Text = Grid.Rows[RowsIndex].Cells[2].Value.ToString();

                }
                catch
                {

                }


                if (Grid.CurrentRow == null) return;
                Grid.Rows.RemoveAt(Grid.CurrentRow.Index);
            }
            else if (result == DialogResult.No)
            {
                //code for No

                txtCodProduto.Focus();

            }



        }

        private void Balanço_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Balanço_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                if (ActiveControl.Name == "txtCodProduto") { btnBuscaProduto.PerformClick(); return; }

            }
        }

        private void btnBuscaProduto_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaRequisicao")
                {
                    if (form is PesquisaProdutos)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {

                Form tela = new PesquisaProdutos();

                tela.ShowDialog();
                RetornoPesquisaProdutos();

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtdtBalanco.Text.Trim() != "")
            {

                Gravar();

            }
        }

        private void Gravar()
        {

            var hoje = DateTime.Now;
            var codempresa = Usuario.Codempresa.ToString();

            var databalanco = txtdtBalanco.Text.Trim();


            var coddepartamento = Usuario.Coddepartamento.ToString();


            var status = "ABERTO";

            var respinclusao = Usuario.Nomeusuario.ToString();
            var datainclusao = hoje.ToString();
            var respalteracao = Usuario.Nomeusuario.ToString();
            var dataalteracao = hoje.ToString();
            var excluido = "N";

            try
            {

                int total = Grid.Rows.Count;
                int i;
                var Produto = "";
                var nome = "";
                var qt = "";
                var Lote = "0";
                var Validade = "";

                DialogResult result = MessageBox.Show("Deseja Incluir este item ?", "Atenção !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    var Linhas = Grid.Rows.Count;

                    foreach (DataGridViewRow linha1 in Grid.Rows)
                    {

                        Produto = linha1.Cells[0].Value.ToString();
                        nome = linha1.Cells[1].Value.ToString();
                        qt = linha1.Cells[3].Value.ToString();
                       
                        var item = new Balanco(int.Parse(codempresa), int.Parse(coddepartamento), databalanco, int.Parse(Produto), Lote, Validade, int.Parse(qt), respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao);

                        var dr_i = Balanco.Select(int.Parse(codempresa), int.Parse(coddepartamento), databalanco, int.Parse(Produto));
                        if (dr_i.HasRows)
                        {
                            item.Update();
                        }
                        else
                        {
                            item.Insert();
                        }

                        dr_i.Dispose();
                        dr_i.Close();

                    }

                }
                //MessageBox.Show("Registro Gravado com Sucesso !");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Persistência");
            }

            LimpaTela();

        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            if (txtdtBalanco.Text.Trim() == "")
            {
                return;
            }
            else
            {
                Relatorio();
            }
        }

        private void Relatorio()
        {
            var cria = new Classes.Funcoes.CriaArquivo();
            cria.Cria_Balanco();

            var emp = Usuario.Codempresa;
            var dep = Usuario.Coddepartamento;



            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Balanco.SelectRel(int.Parse(emp), int.Parse(dep), txtdtBalanco.Text.Trim());

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    var codempresa = dr.GetInt32(dr.GetOrdinal("CODEMPRESA"));
                    var coddepartamento = dr.GetInt32(dr.GetOrdinal("CODDEPARTAMENTO"));
                    var nomedepartamento = dr.GetString(dr.GetOrdinal("NOMEDEPARTAMENTO"));
                    var databalanco = dr.GetString(dr.GetOrdinal("DATABALANCO"));
                    var codproduto = dr.GetInt32(dr.GetOrdinal("CODPRODUTO"));
                    var nomeproduto = dr.GetString(dr.GetOrdinal("NOMEPRODUTO"));
                    var quantidade = dr.GetString(dr.GetOrdinal("QUANTIDADE"));

                    var respinclusao = "";
                    var datainclusao = "";
                    var respalteracao = "";
                    var dataalteracao = "";

                    try
                    {
                        var m = new Balanco();

                        m.InsertAccess(codempresa, coddepartamento, nomedepartamento, databalanco,
                                       codproduto, nomeproduto, quantidade);
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
                if (form is RelBalanco)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelBalanco();
                tela.ShowDialog();
            }

        }


    }
}
