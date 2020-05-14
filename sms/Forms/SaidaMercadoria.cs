using Atencao_Assistida.Classes.DAL;
using Atencao_Assistida.Classes.Mysql;
using Atencao_Assistida.Pesquisas;
using Atencao_Assistida.Relatorios.Saida;
using System;
using System.Data;
using System.Windows.Forms;

namespace Atencao_Assistida.Forms
{
    public partial class SaidaMercadoria : Form
    {
        public SaidaMercadoria()
        {
            InitializeComponent();
        }

        private void btnBuscaProtocolo_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaRequisicao")
                {
                    if (form is PesquisaRequisicao)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {

                Form tela = new PesquisaRequisicao();
                // tela.MdiParent = MdiParent;
                tela.ShowDialog();
                RetornoPesquisa();

            }
        }

        private void RetornoPesquisa()
        {
            if (Parametros.Valor != "")
            {
                txtNumeroPedido.Text = Parametros.Valor;
                BuscaPedido();
                CarregaGrid();

                Parametros.Valor = "";
            }

        }

        public void BuscaPedido()
        {
            var aprovado = 1;

            var dr = Pedido.SelectPedidoN(txtNumeroPedido.Text, 0, int.Parse(Usuario.Coddepartamento), aprovado);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr.GetString(dr.GetOrdinal("STATUS")) == "FECHADO")
                    {
                        MessageBox.Show("Pedido Já fechado ", "Aviso Importante",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                        //txtCodigo.Text = "";

                        //return;

                        btnSalvar.Enabled = false;
                    }

                    txtCodigo.Text = dr.GetInt32(dr.GetOrdinal("CODPEDIDO")).ToString();
                    txtNumeroPedido.Text = dr.GetString(dr.GetOrdinal("NUMEROPEDIDO"));
                    txtdatapedido.Text = dr.GetString(dr.GetOrdinal("DATAPEDIDO")).ToString();
                    txtCodigoUnidade.Text = dr.GetInt32(dr.GetOrdinal("CODUNIDADE")).ToString().Trim();
                    txtcoddepartamento.Text = dr.GetInt32(dr.GetOrdinal("CODDEPARTAMENTO")).ToString().Trim();

                }
            }
            dr.Dispose();
            dr.Close();
            if (txtCodigoUnidade.Text.Trim() != "")
            {
                BuscaUnidade(int.Parse(txtCodigoUnidade.Text));
            }
        }

        private void CarregaGrid()
        {
            if (txtCodigo.Text == "") { return; }

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[6];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Pedido.Select(int.Parse(txtCodigo.Text), txtNumeroPedido.Text);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NOME"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("LOTE"));
                    linhaDados[3] = dr.GetString(dr.GetOrdinal("QUANTIDADE"));
                    //linhaDados[4] = dr.GetString(dr.GetOrdinal("ENTREGUE"));


                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void BuscaUnidade(int codigo)
        {

            var dr = Unidade.Select(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtCodigoUnidade.Text = dr.GetInt32(dr.GetOrdinal("CODUNIDADE")).ToString().Trim();
                    txtNomeUnidade.Text = dr.GetString(dr.GetOrdinal("NOME")).Trim();

                }
            }
            dr.Close();

        }

        private void txtNumeroPedido_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNumeroPedido.Text.Trim() != "")
            {
                var entregue = "";
                var produto = "";

                foreach (DataGridViewRow linha1 in Grid.Rows)
                {
                    try
                    {
                        produto = linha1.Cells[1].Value.ToString();
                        entregue = linha1.Cells[4].Value.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Produto " + produto + "sem informação, favor proceder a correção ", "Aviso Importante",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                        return;
                    }
                }

                VerificaProduto();

                Gravar(true, int.Parse(txtNumeroPedido.Text.Trim()));
                Limpatela();
            }
        }

        private void Gravar(bool novo, int codigo)
        {

            var hoje = DateTime.Now;

            var codsaida = 0;
            var codempresa = Usuario.Codempresa.ToString();
            var coddepartamento = Usuario.Coddepartamento.ToString();
            var codunidade = txtCodigoUnidade.Text.Trim();
            var numeropedido = txtNumeroPedido.Text.Trim();
            var dataentrega = txtdatasaida.Text.Trim();

            var respinclusao = Usuario.Nomeusuario.ToString();
            var datainclusao = hoje.ToString();
            var respalteracao = Usuario.Nomeusuario.ToString();
            var dataalteracao = hoje.ToString();
            var excluido = "N";

            var numero = 0;

            try
            {

                var dr = Saida.BuscaNota(numeropedido, int.Parse(Usuario.Coddepartamento));
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        codsaida = dr.GetInt32(dr.GetOrdinal("CODSAIDA"));
                    }
                    var m = new Saida(codsaida, int.Parse(codempresa), int.Parse(coddepartamento), int.Parse(codunidade), numeropedido, dataentrega, respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao, excluido);
                    m.Update();
                    numero = codsaida;
                }
                else
                {
                    var m = new Saida(codsaida, int.Parse(codempresa), int.Parse(coddepartamento), int.Parse(codunidade), numeropedido, dataentrega, respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao, excluido);
                    numero = m.Insert();
                    codsaida = numero;
                }

                dr.Dispose();
                dr.Close();


                #region Itens


                int total = Grid.Rows.Count;
                int i;
                var Produto = "";
                var Lote = "";
                var Validade = "";
                var solicitado = "";
                var entregue = "";


                DateTime data = Convert.ToDateTime(txtdatapedido.Text);
                var vmes = data.ToString("MM");
                int mes = int.Parse(vmes);

                var vano = data.ToString("yyyy");
                int ano = int.Parse(vano);

                DBAcess db = new DBAcess(CommandType.StoredProcedure);

                var Linhas = Grid.Rows.Count;

                foreach (DataGridViewRow linha1 in Grid.Rows)
                {

                    Produto = linha1.Cells[0].Value.ToString();
                    solicitado = linha1.Cells[3].Value.ToString();
                    entregue = linha1.Cells[4].Value.ToString(); ;


                    db.CommandText = "Sp_Add_ItemSaida";

                    db.AddParameter("@CODSAIDA", numero);
                    db.AddParameter("@NUMEROPEDIDO", numeropedido);
                    db.AddParameter("@CODPRODUTO", int.Parse(Produto));
                    db.AddParameter("@LOTE", Lote);
                    db.AddParameter("@VALIDADE", Validade);
                    db.AddParameter("@SOLICITADO", solicitado);
                    db.AddParameter("@ENTREGUE", entregue);
                    db.AddParameter("@MES", mes);
                    db.AddParameter("@ANO", ano);

                    try
                    {
                        db.ExecuteScalar();
                    }
                    finally
                    {
                        db.Dispose();
                    }

                    ControlaEstoque(int.Parse(codempresa), int.Parse(Produto), "", entregue);
                }


                #endregion

                var p = new Pedido(int.Parse(numeropedido), "FECHADO");
                p.UpdateStatus();

            }
            catch (Exception erro)
            {

            }



            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

        }

        private void VerificaProduto()
        {




            DateTime data = Convert.ToDateTime(txtdatasaida.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);
            var coddepartamento = Usuario.Coddepartamento.ToString();
            var codempresa = Usuario.Codempresa.ToString();

            foreach (DataGridViewRow linha1 in Grid.Rows)
            {

                var Produto = linha1.Cells[0].Value.ToString();
                var nome = linha1.Cells[1].Value.ToString();
                var entregue = linha1.Cells[4].Value.ToString();



                var atual = new Estoque(int.Parse(codempresa), int.Parse(coddepartamento), mes, ano, int.Parse(Produto));

                var estoque = atual.VerQtAtual();

                //if (int.Parse(estoque) < 0)
                //{
                //    MessageBox.Show("Mercadoria " + nome + " com estoque Negativo, favor Conferir Entradas e Saidas desta Mercadoria !");

                //}
                //else
                //{
                //    //MessageBox.Show("Mercadoria " + nome + " com falha no estoque, favor Conferir Entradas e Saidas desta Mercadoria !");
                //}

                if (decimal.Parse(estoque) < decimal.Parse(entregue))
                {
                    MessageBox.Show("Mercadoria " + nome + " com falha no estoque, favor Conferir Entradas e Saidas desta Mercadoria !");
                }
                else
                {
                    //MessageBox.Show("Mercadoria " + nome + " com falha no estoque, favor Conferir Entradas e Saidas desta Mercadoria !");
                }

            }


        }

        private void ControlaEstoque(int codempresa, int codproduto, string QtEntrada, string QtSaida)
        {

            //SaldoAnterior(codempresa, codproduto);

            SaidaProduto(codempresa, codproduto, QtSaida);
            SaldoAtual(codempresa, codproduto);

        }

        private void SaldoAnterior(int codempresa, int codproduto)
        {

            DateTime data = Convert.ToDateTime(txtdatasaida.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);
            var coddepartamento = Usuario.Coddepartamento.ToString();

            var Est = new Estoque();

            #region Quantidade Mes Anterior

            var mesanterior = Est.BuscaMesAnterior(mes, ano);
            vmes = mesanterior.Substring(0, 2);
            vano = mesanterior.Substring(2, 4);



            //-> Buscando a quantidade do mes anterior 
            var QtAnterior = Est.Anterior(codempresa, int.Parse(coddepartamento), int.Parse(vmes), int.Parse(vano), codproduto);

            // id, codempresa, mes, ano,codproduto, qtanterior, entrada, saida , qtatual 
            var m = new Estoque(0, codempresa, int.Parse(coddepartamento), mes, ano, codproduto, QtAnterior.ToString(), "0", "0", "0");

            //m.GravaAnterior();

            #endregion;

        }
        private void SaidaProduto(int codempresa, int codproduto, string QtSaida)
        {
            DateTime data = Convert.ToDateTime(txtdatasaida.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);
            var coddepartamento = Usuario.Coddepartamento.ToString();


            #region Saida

            var sai = new Estoque(0, codempresa, int.Parse(coddepartamento), mes, ano, codproduto, "0", "0", QtSaida, "0");

            sai.GravaSaidaUnica();


            #endregion

        }
        private void SaldoAtual(int codempresa, int codproduto)
        {
            DateTime data = Convert.ToDateTime(txtdatasaida.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);
            var coddepartamento = Usuario.Coddepartamento.ToString();

            #region Quantidade Atual

            var atual = new Estoque(0, codempresa, int.Parse(coddepartamento), mes, ano, codproduto, "0", "0", "0", "0");

            atual.AtualizaQtAtual();

            #endregion

        }

        private void SaidaMercadoria_Load(object sender, EventArgs e)
        {
            txtdatasaida.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpatela()
        {
            txtNumeroPedido.Text = "";
            txtdatapedido.Text = "";
            txtCodigo.Text = "";
            txtCodigoUnidade.Text = "";
            txtcoddepartamento.Text = "";
            txtNomeUnidade.Text = "";
            txtCodigoProduto.Text = "";
            txtnome.Text = "";
            txtlote.Text = "";
            txtsolicitado.Text = "";
            txtentregue.Text = "";

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            btnSalvar.Enabled = true;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DateTime date = this.dateTimePicker1.Value;

            this.txtdatapedido.Text = date.ToString("dd/MM/yyyy");
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            Limpatela();
        }

        private void txtNumeroPedido_Leave(object sender, EventArgs e)
        {
            if (txtNumeroPedido.Text.Trim() != "")
            {
                BuscaPedido();
                CarregaGrid();
            }
        }

        private void SaidaMercadoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void SaidaMercadoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {

                if (ActiveControl.Name == "txtNumeroPedido") { btnBuscaProtocolo.PerformClick(); return; }
                if (ActiveControl.Name == "txtCodigoProduto") { button1.PerformClick(); return; }


            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (txtNumeroPedido.Text.Trim() == "")
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
            cria.Cria_Saida();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Saida.SelectRel(txtNumeroPedido.Text.Trim(), txtcoddepartamento.Text.Trim());

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    var codsaida = dr.GetInt32(dr.GetOrdinal("CODSAIDA"));
                    var codempresa = dr.GetInt32(dr.GetOrdinal("CODEMPRESA"));
                    var coddepartamento = dr.GetInt32(dr.GetOrdinal("CODDEPARTAMENTO"));
                    var nomedepartamento = dr.GetString(dr.GetOrdinal("NOMEDEPARTAMENTO"));
                    var codunidade = dr.GetInt32(dr.GetOrdinal("CODUNIDADE"));
                    var nomeunidade = dr.GetString(dr.GetOrdinal("NOMEUNIDADE"));
                    var solicitante = dr.GetString(dr.GetOrdinal("SOLICITANTE"));
                    var numeropedido = dr.GetString(dr.GetOrdinal("NUMEROPEDIDO"));
                    var dataentrega = dr.GetString(dr.GetOrdinal("DATAENTREGA"));
                    var codproduto = dr.GetInt32(dr.GetOrdinal("CODPRODUTO"));
                    var nomeproduto = dr.GetString(dr.GetOrdinal("NOMEPRODUTO"));
                    var solicitado = dr.GetString(dr.GetOrdinal("SOLICITADO"));
                    var entregue = dr.GetString(dr.GetOrdinal("ENTREGUE"));
                    var respinclusao = dr.GetString(dr.GetOrdinal("RESPINCLUSAO"));
                    var datainclusao = dr.GetString(dr.GetOrdinal("DATAINCLUSAO"));

                    var respalteracao = "";
                    var dataalteracao = "";

                    try
                    {
                        var m = new Saida();

                        m.InsertAccess(codsaida, codempresa, coddepartamento, nomedepartamento, codunidade, nomeunidade, solicitante, numeropedido, dataentrega,
                                       codproduto, nomeproduto, solicitado, entregue, respinclusao, datainclusao);
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
                if (form is RelSaida)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelSaida();
                tela.ShowDialog();
            }

        }
    }
}
