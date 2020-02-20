using Atencao_Assistida.Classes.Mysql;
using Atencao_Assistida.Pesquisas;
using Atencao_Assistida.Relatorios.Oficio;
using Atencao_Assistida.Relatorios.Pedido;
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
    public partial class Oficio : Form
    {
        int loopestubs = 0;

        public Oficio()
        {
            InitializeComponent();
        }

        private void Oficio_Load(object sender, EventArgs e)
        {
            txtdataPedido.Text = DateTime.Now.ToString("dd/MM/yyyy");

            LblCargo.Text = Usuario.Funcao;
            lblUsuario.Text = Usuario.Nomeusuario;
            lblLotado.Text = Usuario.Lotado;

            BuscaNovoOficio();
        }

        private void Oficio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {

                if (ActiveControl.Name == "txtNumeroPedido") { btnBuscaOficio.PerformClick(); return; }

                //if (ActiveControl.Name == "txtCodUnidade") { btnBuscaUnidade.PerformClick(); return; }
                if (ActiveControl.Name == "txtCodProduto") { btnBuscaProduto.PerformClick(); return; }


            }
        }

        private void Oficio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void btnBuscaOficio_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaOficio")
                {
                    if (form is PesquisaOficio)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {

                Form tela = new PesquisaOficio();

                tela.ShowDialog();
                RetornoPesquisaOficio();

            }
        }

        private void RetornoPesquisaOficio()
        {
            if (Parametros.Valor != "")
            {
                BuscaOficio(int.Parse(Parametros.Valor));
            }

        }

        public void RetornoPesquisaOficio(int cod)
        {
            if (cod != 0)
            {
                BuscaOficio(cod);
            }

        }

        public void BuscaOficio()
        {

            var dr = Pedido.SelectOficioN(txtNumeroPedido.Text,1,int.Parse(Usuario.Coddepartamento));
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr.GetString(dr.GetOrdinal("STATUS")) == "FECHADO")
                    {
                        MessageBox.Show("OFICIO FECHADO ");
                        btnGravar.Enabled = false;
                    }

                    txtCodigo.Text = dr.GetInt32(dr.GetOrdinal("CODPEDIDO")).ToString();
                    txtNumeroPedido.Text = dr.GetString(dr.GetOrdinal("NUMEROPEDIDO"));
                    txtdataPedido.Text = dr.GetString(dr.GetOrdinal("DATAPEDIDO")).ToString();

                    lblstatus.Text = dr.GetString(dr.GetOrdinal("STATUS")).ToString();
                }
            }
            dr.Dispose();
            dr.Close();

            CarregaGrid();

        }

        public void BuscaOficio(int cod)
        {

            var dr = Pedido.SelectOficioC(cod);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr.GetString(dr.GetOrdinal("STATUS")) == "FECHADO")
                    {
                        MessageBox.Show("OFICIO FECHADO ");
                        btnGravar.Enabled = false;
                    }

                    txtCodigo.Text = dr.GetInt32(dr.GetOrdinal("CODPEDIDO")).ToString();
                    txtNumeroPedido.Text = dr.GetString(dr.GetOrdinal("NUMEROPEDIDO"));
                    txtdataPedido.Text = dr.GetString(dr.GetOrdinal("DATAPEDIDO")).ToString();

                    lblstatus.Text = dr.GetString(dr.GetOrdinal("STATUS")).ToString();
                }
            }
            dr.Dispose();
            dr.Close();

            CarregaGrid();

        }

        private void btnBuscaUnidade_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaOficio")
                {
                    if (form is PesquisaOficio)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {

                Form tela = new PesquisaOficio();

                tela.ShowDialog();
                RetornoPesquisaUnidade();

            }
        }

        private void RetornoPesquisaUnidade()
        {
            if (Parametros.Valor != "")
            {
                //txtCodUnidade.Text = Parametros.Valor;
                //BuscaUnidades();
            }

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
                if (form.Name == "PesquisaOficio")
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

                    txtparaquem.Focus();
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

            this.txtdataPedido.Text = date.ToString("dd/MM/yyyy");
        }

        public void BuscaNovoOficio()
        {
            var m = new Pedido();
            var numero = m.BuscaUltimoPedido(0, 1);

            var dr = Pedido.NovoPedido(1, int.Parse(Usuario.Coddepartamento), numero);
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

            if (int.Parse(txtCodigo.Text) == 0) return;

            var dr = Pedido_item.SelectOficio(int.Parse(txtCodigo.Text));

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NOME"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("PARAQUEM"));
                    linhaDados[3] = dr.GetString(dr.GetOrdinal("QUANTIDADE"));

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
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
            var codUnidade = Usuario.Codunidade;
            var coddepartamento = Usuario.Coddepartamento.ToString();
            var solicitante = Usuario.Nomeusuario.ToString();

            var status = "ABERTO";

            var respinclusao = Usuario.Nomeusuario.ToString();
            var datainclusao = hoje.ToString();
            var respalteracao = Usuario.Nomeusuario.ToString();
            var dataalteracao = hoje.ToString();
            var excluido = "N";

            var numero = 0;

            try
            {

                var dr = Pedido.SelectOficioN(numeroPedido, 1, int.Parse(Usuario.Coddepartamento));
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id = dr.GetInt32(dr.GetOrdinal("CODPEDIDO"));
                    }
                    var m = new Pedido(id, int.Parse(empresa), int.Parse(codUnidade), 1, 0, int.Parse(coddepartamento), solicitante, numeroPedido, dataentrega, status, respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao, "N");
                    m.Update();
                    numero = id;
                }
                else
                {
                    var m = new Pedido(id, int.Parse(empresa), int.Parse(codUnidade), 1, 0,  int.Parse(coddepartamento), solicitante, numeroPedido, dataentrega, status, respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao, "N");
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
                var paraquem = "";

                var Del_item = new Pedido_item(numero);
                Del_item.Delete(numero);

                var Linhas = Grid.Rows.Count;

                foreach (DataGridViewRow linha1 in Grid.Rows)
                {

                    Produto = linha1.Cells[0].Value.ToString();
                    nome = linha1.Cells[1].Value.ToString();
                    paraquem = linha1.Cells[2].Value.ToString();
                    qt = linha1.Cells[3].Value.ToString();
                    estUBS = "";

                    var Lote = "0";
                    var Validade = "";

                    var item = new Pedido_item(numero, numeroPedido, int.Parse(Produto), Lote, Validade, qt, estUBS, paraquem);

                    item.InsertOficio();

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

            txtNumeroPedido.Text = "";
           
            txtCodigo.Text = "0";
            
            txtCodProduto.Text = "";
            txtNomeProduto.Text = "";
            txtparaquem.Text = "";
            txtQuantidade.Text = "";
            lblstatus.Text = "";

            txtdataPedido.Text = "  /  /    ";
            loopestubs = 0;
            comboBox1.Text = "";

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            txtdataPedido.Text = DateTime.Now.ToString("dd/MM/yyyy");
            BuscaNovoOficio();
            btnGravar.Enabled = true;

            txtNumeroPedido.Focus();

        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult result = MessageBox.Show("Deseja alterar este item do Oficio ?", "Atenção !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var RowsIndex = Grid.CurrentRow.Index;

                try
                {
                    txtCodProduto.Text = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                    txtNomeProduto.Text = Grid.Rows[RowsIndex].Cells[1].Value.ToString();
                    txtparaquem.Text = Grid.Rows[RowsIndex].Cells[2].Value.ToString();
                    txtQuantidade.Text = Grid.Rows[RowsIndex].Cells[3].Value.ToString();


                }
                catch
                {

                }

                if (Grid.CurrentRow == null) return;
                Grid.Rows.RemoveAt(Grid.CurrentRow.Index);
            }
            else if (result == DialogResult.No)
            {
                
                txtCodProduto.Focus();

            }

        }

        private void GridAdd()
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[6];

            linhaDados[0] = txtCodProduto.Text;
            linhaDados[1] = txtNomeProduto.Text;
            linhaDados[2] = txtparaquem.Text;
            linhaDados[3] = txtQuantidade.Text;

            Grid.Rows.Add(linhaDados);

            txtCodProduto.Text = "";
            txtNomeProduto.Text = "";
            txtQuantidade.Text = "";
            txtparaquem.Text = "";

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
            cria.Cria_Oficio();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Pedido.SelectOficioRel(txtNumeroPedido.Text.Trim());

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
                    var paraquem = dr.GetString(dr.GetOrdinal("PARAQUEM"));

                    var respinclusao = "";
                    var datainclusao = "";
                    var respalteracao = "";
                    var dataalteracao = "";

                    try
                    {
                        var m = new Pedido();

                        m.InsertAccessOficio(codpedido, codempresa, coddepartamento, nomedepartamento, codunidade, nomeunidade,
                            solicitante, numeropedido, datapedido, status, codproduto, nomeproduto, quantidade, estoqueubs, paraquem);
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
                if (form is RelOficio)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelOficio();
                tela.ShowDialog();
            }

        }

        private void txtNumeroPedido_Leave(object sender, EventArgs e)
        {
            if (txtNumeroPedido.Text.Trim() != "")
            {
                BuscaOficio();
            }
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            Relatorio();
        }
    }

}
