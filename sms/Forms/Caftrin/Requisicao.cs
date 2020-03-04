using Atencao_Assistida.Classes.Mysql;
using Atencao_Assistida.Pesquisas;
using Atencao_Assistida.Relatorios.Pedido;
using Atencao_Assistida.Classes.Funcoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Forms.Caftrin
{
    public partial class Requisicao : Form
    {
        int loopestubs = 0;

        public Requisicao()
        {
            InitializeComponent();
        }

        private void Requisicao_Load(object sender, EventArgs e)
        {
            txtdataPedido.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtNumeroPedido.KeyPress += new KeyPressEventHandler(bloqueiaLetras);

            txtCodUnidade.KeyPress += new KeyPressEventHandler(bloqueiaLetras);
            txtCodProduto.KeyPress += new KeyPressEventHandler(bloqueiaLetras);
            txtQuantidade.KeyPress += new KeyPressEventHandler(bloqueiaLetras);
            txtestoqueubs.KeyPress += new KeyPressEventHandler(bloqueiaLetras);

            BuscaNovoPedido();
        }

        void bloqueiaLetras(object sender, KeyPressEventArgs e)

        {

            if (e.KeyChar > 20 && (e.KeyChar < 48 || e.KeyChar > 57)) // teclas menor q 20 (TAB, DEL..) Maior q 48 e menor q 57 (1,2,3...9)

            {

                e.Handled = true; // Bloqueia tecla

            }

        }

        private void Requisicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {

                if (ActiveControl.Name == "txtNumeroPedido") { btnBuscaRequisicao.PerformClick(); return; }

                if (ActiveControl.Name == "txtCodUnidade") { btnBuscaUnidade.PerformClick(); return; }
                if (ActiveControl.Name == "txtCodProduto") { btnBuscaProduto.PerformClick(); return; }


            }
        }

        private void btnBuscaRequisicao_Click(object sender, EventArgs e)
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

                tela.ShowDialog();
                RetornoPesquisaRequisicao();

            }
        }

        private void RetornoPesquisaRequisicao()
        {
            if (Parametros.Valor != "")
            {
                txtNumeroPedido.Text = Parametros.Valor;

                BuscaPedido();
            }

        }

        public void BuscaPedido()
        {
            txtCodigo.Text = "0";

            var dr = Pedido.SelectPedidoN(txtNumeroPedido.Text, 0, int.Parse(Usuario.Coddepartamento));
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr.GetString(dr.GetOrdinal("STATUS")) == "FECHADO")
                    {
                        MessageBox.Show("PEDIDO FECHADO ");
                        btnGravar.Enabled = false;
                    }

                    txtCodigo.Text = dr.GetInt32(dr.GetOrdinal("CODPEDIDO")).ToString();
                    txtNumeroPedido.Text = dr.GetString(dr.GetOrdinal("NUMEROPEDIDO"));
                    txtdataPedido.Text = dr.GetString(dr.GetOrdinal("DATAPEDIDO")).ToString();
                    txtnomeSolicitante.Text = dr.GetString(dr.GetOrdinal("SOLICITANTE")).ToString();
                    txtCodUnidade.Text = dr.GetInt32(dr.GetOrdinal("CODUNIDADE")).ToString();

                    BuscaUnidades();

                }
            }
            dr.Dispose();
            dr.Close();

            CarregaGrid();

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
                loopestubs = 0;
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

        private void Requisicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;

            this.txtdataPedido.Text = date.ToString("dd/MM/yyyy");
        }

        public void BuscaNovoPedido()
        {
            var m = new Pedido();
            var numero = m.BuscaUltimoPedido(0, int.Parse(Usuario.Coddepartamento));

            var dr = Pedido.NovoPedido(0,int.Parse(Usuario.Coddepartamento), numero);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    try
                    {
                        var ultimo = dr.GetString(dr.GetOrdinal("ULTIMO"));

                        ultimo = (int.Parse(ultimo) + 1).ToString();

                        txtNumeroPedido.Text = ultimo;
                    }
                    catch
                    {
                        txtNumeroPedido.Text = "1";
                    }

                }
            }
            dr.Dispose();
            dr.Close();
        }

        private void CarregaGrid()
        {


            //define um array de strings com nCOlunas
            string[] linhaDados = new string[4];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Pedido_item.SelectPC(int.Parse(txtCodigo.Text));

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NOME"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("QUANTIDADE"));
                    linhaDados[3] = dr.GetString(dr.GetOrdinal("ESTOQUEUBS"));


                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtnomeSolicitante.Text.Trim() == "") { MessageBox.Show("Favor informar o Nome do Solicitante !"); txtnomeSolicitante.Focus(); return; }
            if (txtnomeSolicitante.Text.Trim() == ".") { MessageBox.Show("Favor informar o Nome do Solicitante !"); txtnomeSolicitante.Focus(); return; }

            if (txtNumeroPedido.Text.Trim() != "")
            {

                Gravar(true, int.Parse(txtNumeroPedido.Text.Trim()));

            }
            
        }

        private void Gravar(bool novo, int codigo)
        {

            var hoje = DateTime.Now;
            var empresa = Usuario.Codempresa.ToString();
            var id = 0;
            var numeroPedido = txtNumeroPedido.Text.Trim();
            var dataentrega = txtdataPedido.Text.Trim();
            var codUnidade = txtCodUnidade.Text.Trim();
            var coddepartamento = Usuario.Coddepartamento.ToString();
            var solicitante = txtnomeSolicitante.Text;

            var status = "ABERTO";

            var respinclusao = Usuario.Nomeusuario.ToString();
            var datainclusao = hoje.ToString();
            var respalteracao = Usuario.Nomeusuario.ToString();
            var dataalteracao = hoje.ToString();
            var excluido = "N";


            var numero = 0;

            try
            {

                var dr = Pedido.SelectPedidoN(numeroPedido, 0, int.Parse(Usuario.Coddepartamento));
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id = dr.GetInt32(dr.GetOrdinal("CODPEDIDO"));
                    }
                    var m = new Pedido(id, int.Parse(empresa), int.Parse(codUnidade), 0, 1, int.Parse(coddepartamento), solicitante, numeroPedido, dataentrega, status, respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao, "N");
                    m.Update();
                    numero = id;
                }
                else
                {
                    var m = new Pedido(id, int.Parse(empresa), int.Parse(codUnidade), 0, 1, int.Parse(coddepartamento), solicitante, numeroPedido, dataentrega, status, respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao, "N");
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

                var Del_item = new Pedido_item(numero);
                Del_item.Delete(numero);

                var Linhas = Grid.Rows.Count;

                foreach (DataGridViewRow linha1 in Grid.Rows)
                {

                    Produto = linha1.Cells[0].Value.ToString();
                    nome = linha1.Cells[1].Value.ToString();
                    qt = linha1.Cells[2].Value.ToString();
                    estUBS = linha1.Cells[3].Value.ToString(); ;

                    var Lote = "0";
                    var Validade = "";

                    var item = new Pedido_item(numero, numeroPedido, int.Parse(Produto), Lote, Validade, qt, estUBS);

                    item.Insert();

                }


                #endregion

                Relatorio();
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

            txtNumeroPedido.Text = "";
            txtnomeSolicitante.Text = "";
            txtCodigo.Text = "";
            txtCodUnidade.Text = "";
            txtNomeUnidade.Text = "";
            txtCodProduto.Text = "";
            txtNomeProduto.Text = "";
            txtQuantidade.Text = "";
            txtestoqueubs.Text = "";
            txtdataPedido.Text = "  /  /    ";
            loopestubs = 0;

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            txtdataPedido.Text = DateTime.Now.ToString("dd/MM/yyyy");
            BuscaNovoPedido();
            btnGravar.Enabled = true;

            txtNumeroPedido.Focus();

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
                    txtestoqueubs.Text = Grid.Rows[RowsIndex].Cells[3].Value.ToString();

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

        private void GridAdd()
        {
           


            //define um array de strings com nCOlunas
            string[] linhaDados = new string[6];

            linhaDados[0] = txtCodProduto.Text;
            linhaDados[1] = txtNomeProduto.Text;
            linhaDados[2] = txtQuantidade.Text;
            linhaDados[3] = txtestoqueubs.Text;

            Grid.Rows.Add(linhaDados);

            txtCodProduto.Text = "";
            txtNomeProduto.Text = "";
            txtQuantidade.Text = "";
            txtestoqueubs.Text = "";

            txtCodProduto.Focus();
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {

        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            LimpaTela();


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
            cria.Cria_Pedido();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Pedido.SelectRel(txtNumeroPedido.Text.Trim());

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    var codpedido = dr.GetInt32(dr.GetOrdinal("CODPEDIDO"));
                    var codempresa = dr.GetInt32(dr.GetOrdinal("CODEMPRESA"));
                    var coddepartamento = dr.GetInt32(dr.GetOrdinal("CODDEPARTAMENTO"));
                    var nomedepartamento = dr.GetString(dr.GetOrdinal("NOMEDEPARTAMENTO"));
                    var codunidade = dr.GetInt32(dr.GetOrdinal("CODUNIDADE"));
                    var nomeunidade = dr.GetString(dr.GetOrdinal("NOMEUNIDADE"));
                    var solicitante = dr.GetString(dr.GetOrdinal("SOLICITANTE"));
                    var numeropedido = dr.GetString(dr.GetOrdinal("NUMEROPEDIDO"));
                    var datapedido = dr.GetString(dr.GetOrdinal("DATAPEDIDO"));
                    var status = dr.GetString(dr.GetOrdinal("STATUS"));

                    var codproduto = dr.GetInt32(dr.GetOrdinal("CODPRODUTO"));
                    var nomeproduto = dr.GetString(dr.GetOrdinal("NOMEPRODUTO"));
                    var quantidade = dr.GetString(dr.GetOrdinal("QUANTIDADE"));
                    var estoqueubs = dr.GetString(dr.GetOrdinal("ESTOQUEUBS"));

                    var respinclusao = "";
                    var datainclusao = "";
                    var respalteracao = "";
                    var dataalteracao = "";

                    try
                    {
                        var m = new Pedido();

                        m.InsertAccess(codpedido, codempresa, coddepartamento, nomedepartamento, codunidade, nomeunidade,
                            solicitante, numeropedido, datapedido, status, codproduto, nomeproduto, quantidade, estoqueubs);
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
                if (form is RelPedido)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelPedido();
                tela.ShowDialog();
            }

        }

        private void txtNumeroPedido_Leave(object sender, EventArgs e)
        {
            
            if (txtNumeroPedido.Text != "")
            {
                BuscaPedido();
            }
        }

        private void txtestoqueubs_Leave(object sender, EventArgs e)
        {
           

            if (txtestoqueubs.Text.Trim() != "")
            {
                GridAdd();
            }
            if ((txtestoqueubs.Text.Trim() == "") && (txtQuantidade.Text.Trim() != "") && (txtCodProduto.Text.Trim() != ""))
            {
                MessageBox.Show("Favor Informar o estoque !! - se vazio Informe Zero ");
               
                txtestoqueubs.Focus();
                return;
            }
           
        }

        private void txtnomeSolicitante_Enter(object sender, EventArgs e)
        {
            if (txtNumeroPedido.Text.Trim() == "") { MessageBox.Show("Favor informar o Número do Pedido !"); txtNumeroPedido.Focus();  return; }
        }

        private void txtCodUnidade_Enter(object sender, EventArgs e)
        {
            if (txtnomeSolicitante.Text.Trim() == "") { MessageBox.Show("Favor informar o Nome do Solicitante !"); txtnomeSolicitante.Focus(); return; }
        }

        private void txtCodProduto_Enter(object sender, EventArgs e)
        {
            if (txtCodUnidade.Text.Trim() == "") { MessageBox.Show("Favor informar a Unidade !"); txtCodUnidade.Focus(); return; }
        }

        private void txtQuantidade_Enter(object sender, EventArgs e)
        {
            if (txtCodProduto.Text.Trim() == "") { MessageBox.Show("Favor informar o Produto !"); txtCodProduto.Focus(); return; }
        }
    }

}
