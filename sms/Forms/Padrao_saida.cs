using Atencao_Assistida.Classes.Mysql;
using Atencao_Assistida.Pesquisas;
using System;
using System.Windows.Forms;

namespace Atencao_Assistida.Forms
{
    public partial class Padrao_saida : Form
    {
        public Padrao_saida()
        {
            InitializeComponent();
        }

        private void btnBuscaSaidaPadrao_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaPadraoSaida")
                {
                    if (form is PesquisaPadraoSaida)
                    {
                        form.BringToFront();
                        open = true;
                    }
                }
            }

            if (!open)
            {
                Form tela = new PesquisaPadraoSaida();

                tela.ShowDialog();
                RetornoPesquisabtnBuscaSaidaPadrao();
            }
        }

        private void RetornoPesquisabtnBuscaSaidaPadrao()
        {
            if (Parametros.Valor != "")
            {
                txtcodigo.Text = Parametros.Valor;

                BuscaPadraoSaida();
            }

        }

        public void BuscaPadraoSaida()
        {
            //txtcodigo.Text = "0";

            var dr = Saida_Padrao.Select(int.Parse(txtcodigo.Text.Trim()));
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtcodigo.Text = dr.GetInt32(dr.GetOrdinal("CODSAIDAPADRAO")).ToString();
                    txtdataCadastro.Text = dr.GetString(dr.GetOrdinal("DATACADASTRO")).ToString();
                    txtCodUnidade.Text = dr.GetInt32(dr.GetOrdinal("CODUNIDADE")).ToString();

                    BuscaUnidades();

                }
            }
            dr.Dispose();
            dr.Close();

            CarregaGrid(int.Parse(txtcodigo.Text));

        }

        private void txtCodUnidade_Leave(object sender, EventArgs e)
        {
            if (txtCodUnidade.Text.Trim() != "")
            {
                BuscaUnidades();
            }
        }

        private void btnBuscaUnidade_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaUnidade")
                {
                    if (form is PesquisaUnidade)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {

                Form tela = new PesquisaUnidade();

                tela.ShowDialog();
                RetornoPesquisaUnidade();

            }
        }

        private void RetornoPesquisaUnidade()
        {
            if (Parametros.Valor != "")
            {
                txtCodUnidade.Text = Parametros.Valor;
                BuscaUnidades();
            }

        }

        private void BuscaUnidades()
        {
            var dr = Unidade.Select(int.Parse(txtCodUnidade.Text));

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtCodUnidade.Text = dr.GetString(dr.GetOrdinal("CODUNIDADE"));
                    txtNomeUnidade.Text = dr.GetString(dr.GetOrdinal("NOME"));

                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            if (txtCodProduto.Text != "")
            {
                BuscaProduto(int.Parse(txtCodProduto.Text));

            }
            else { btnGravar.Focus(); }
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

                    if (!dr.IsDBNull(dr.GetOrdinal("NOME")))
                    { txtNomeProduto.Text = dr.GetString(dr.GetOrdinal("NOME")); }
                    else { txtNomeProduto.Text = dr.GetString(dr.GetOrdinal("DESCRICAO")); }

                    txtQuantidade.Focus();
                }
            }

            dr.Close();
            dr.Dispose();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;

            this.txtdataCadastro.Text = date.ToString("dd/MM/yyyy");
        }

        public void BuscaNovoPadraoSaida()
        {
            var m = new Saida_Padrao();
            var numero = m.BuscaUltimoSaidaPadrao(int.Parse(Usuario.Codempresa), int.Parse(Usuario.Coddepartamento));

            try
            {
                var ultimo = numero;

                ultimo = (ultimo + 1);

                txtcodigo.Text = ultimo.ToString();
            }
            catch
            {
                txtcodigo.Text = "1";
            }

        }

        private void CarregaGrid(int codigo)
        {


            //define um array de strings com nCOlunas
            string[] linhaDados = new string[4];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Saida_Padrao_Item.Select(codigo, int.Parse(Usuario.Codempresa), int.Parse(Usuario.Coddepartamento));

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NOMEPRODUTO"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("QUANTIDADE"));

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void GridAdd()
        {
            Grid.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[6];

            linhaDados[0] = txtCodProduto.Text;
            linhaDados[1] = txtNomeProduto.Text;
            linhaDados[2] = txtQuantidade.Text;

            Grid.Rows.Add(linhaDados);

            txtCodProduto.Text = "";
            txtNomeProduto.Text = "";
            txtQuantidade.Text = "";


            txtCodProduto.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            if (txtcodigo.Text.Trim() != "")
            {

                Gravar(true, int.Parse(txtcodigo.Text.Trim()));

            }

        }

        private void Gravar(bool novo, int codigo)
        {

            var hoje = DateTime.Now;
            var empresa = Usuario.Codempresa.ToString();
            var id = 0;
            //codigo = txtcodigo.Text.Trim();
            var datacadastro = txtdataCadastro.Text.Trim();
            var codUnidade = txtCodUnidade.Text.Trim();
            var coddepartamento = Usuario.Coddepartamento.ToString();
                      

            var respinclusao = Usuario.Nomeusuario.ToString();
            var datainclusao = hoje.ToString();
            var respalteracao = Usuario.Nomeusuario.ToString();
            
            var excluido = "N";

            var numero = 0;

            try
            {
                

                var dr = Saida_Padrao.Select(codigo, int.Parse(Usuario.Codempresa), int.Parse(Usuario.Coddepartamento));
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id = dr.GetInt32(dr.GetOrdinal("CODSAIDAPADRAO"));
                    }
                    var m = new Saida_Padrao(id, int.Parse(empresa), int.Parse(coddepartamento), int.Parse(codUnidade), datacadastro);
                    m.Update();
                    numero = id;
                }
                else
                {
                    var m = new Saida_Padrao(id, int.Parse(empresa), int.Parse(coddepartamento), int.Parse(codUnidade), datacadastro);
                    numero = m.Insert();
                    id = numero;
                }

                dr.Dispose();
                dr.Close();


                #region Itens


                int total = Grid.Rows.Count;
                int i;
                var Produto = "";
                var nome = "";
                var qt = "";
                var estUBS = "";

                var Del_item = new Saida_Padrao_Item();
                Del_item.Delete(numero);

                var Linhas = Grid.Rows.Count;

                foreach (DataGridViewRow linha1 in Grid.Rows)
                {

                    Produto = linha1.Cells[0].Value.ToString();
                    nome = linha1.Cells[1].Value.ToString();
                    qt = linha1.Cells[2].Value.ToString();
                                      

                    var item = new Saida_Padrao_Item(numero, int.Parse(Usuario.Codempresa), int.Parse(Usuario.Coddepartamento), int.Parse(Produto), qt);

                    item.Insert();

                }


                #endregion

                //Relatorio();
                MessageBox.Show("Registro Gravado com Sucesso !");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Persistência");
            }

            LimpaTela();

        }

        private void LimpaTela()
        {

            txtcodigo.Text = "";

            txtcodigo.Text = "";
            txtCodUnidade.Text = "";
            txtNomeUnidade.Text = "";
            txtCodProduto.Text = "";
            txtNomeProduto.Text = "";
            txtQuantidade.Text = "";

            txtdataCadastro.Text = "  /  /    ";


            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            txtdataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            BuscaNovoPadraoSaida();
            btnGravar.Enabled = true;

            txtcodigo.Focus();

        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult result = MessageBox.Show("Deseja alterar este item da Requisição ?", "Atenção !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var RowsIndex = Grid.CurrentRow.Index;

                try
                {
                    txtCodProduto.Text = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                    txtNomeProduto.Text = Grid.Rows[RowsIndex].Cells[1].Value.ToString();
                    txtQuantidade.Text = Grid.Rows[RowsIndex].Cells[2].Value.ToString();
                    //txtestoqueubs.Text = Grid.Rows[RowsIndex].Cells[3].Value.ToString();

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

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            LimpaTela();

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Trim() == "")
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
            //var cria = new Classes.Funcoes.CriaArquivo();
            //cria.Cria_PadraoSaida();

            //// BUSCA E GRAVA NO REPOSITORIO
            //var dr = PadraoSaida.SelectRel(txtcodigo.Text.Trim());

            //if (dr.HasRows)
            //{
            //    while (dr.Read())
            //    {

            //        var codPadraoSaida = dr.GetInt32(dr.GetOrdinal("CODPadraoSaida"));
            //        var codempresa = dr.GetInt32(dr.GetOrdinal("CODEMPRESA"));
            //        var coddepartamento = dr.GetInt32(dr.GetOrdinal("CODDEPARTAMENTO"));
            //        var nomedepartamento = dr.GetString(dr.GetOrdinal("NOMEDEPARTAMENTO"));
            //        var codunidade = dr.GetInt32(dr.GetOrdinal("CODUNIDADE"));
            //        var nomeunidade = dr.GetString(dr.GetOrdinal("NOMEUNIDADE"));
            //        var solicitante = dr.GetString(dr.GetOrdinal("SOLICITANTE"));
            //        var codigo = dr.GetString(dr.GetOrdinal("codigo"));
            //        var dataPadraoSaida = dr.GetString(dr.GetOrdinal("DATAPadraoSaida"));
            //        var status = dr.GetString(dr.GetOrdinal("STATUS"));

            //        var codproduto = dr.GetInt32(dr.GetOrdinal("CODPRODUTO"));
            //        var nomeproduto = dr.GetString(dr.GetOrdinal("NOMEPRODUTO"));
            //        var quantidade = dr.GetString(dr.GetOrdinal("QUANTIDADE"));
            //        var estoqueubs = dr.GetString(dr.GetOrdinal("ESTOQUEUBS"));

            //        var respinclusao = "";
            //        var datainclusao = "";
            //        var respalteracao = "";
            //        var dataalteracao = "";

            //        try
            //        {
            //            var m = new PadraoSaida();

            //            m.InsertAccess(codPadraoSaida, codempresa, coddepartamento, nomedepartamento, codunidade, nomeunidade,
            //                solicitante, codigo, dataPadraoSaida, status, codproduto, nomeproduto, quantidade, estoqueubs);
            //        }
            //        catch (Exception erro)
            //        {

            //        }

            //    }

            //}

            //dr.Close();
            //dr.Dispose();

            ////CHAMA A TELA DE RELATORIO
            //bool open = false;
            //foreach (Form form in this.MdiChildren)
            //{
            //    if (form is RelPadraoSaida)
            //    {
            //        form.BringToFront();
            //        open = true;
            //    }
            //}
            //if (!open)
            //{
            //    Form tela = new RelPadraoSaida();
            //    tela.ShowDialog();
            //}

        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {

            if (txtcodigo.Text != "")
            {
                BuscaPadraoSaida();
            }
        }

        private void txtCodUnidade_Enter(object sender, EventArgs e)
        {
            //if (txtnomeSolicitante.Text.Trim() == "") { MessageBox.Show("Favor informar o Nome do Solicitante !"); txtnomeSolicitante.Focus(); return; }
        }

        private void txtCodProduto_Enter(object sender, EventArgs e)
        {
            if (txtCodUnidade.Text.Trim() == "") { MessageBox.Show("Favor informar a Unidade !"); txtCodUnidade.Focus(); return; }
        }

        private void txtQuantidade_Enter(object sender, EventArgs e)
        {
            if (txtCodProduto.Text.Trim() == "") { MessageBox.Show("Favor informar o Produto !"); txtCodProduto.Focus(); return; }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnAddGrid_Click(object sender, EventArgs e)
        {
            GridAdd();
            txtCodProduto.Focus();
        }

        private void Padrao_saida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }
    }

}
