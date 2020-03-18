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

namespace Atencao_Assistida.Forms.Caftrin
{
    public partial class TrocaDevolucao : Form
    {
        public TrocaDevolucao()
        {
            InitializeComponent();
        }

        private void TrocaDevolucao_Load(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;

            this.txtdtdevolucao.Text = date.ToString("dd/MM/yyyy");

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;

            this.txtdtdevolucao.Text = date.ToString("dd/MM/yyyy");
        }

        private void btnProcurapedido_Click(object sender, EventArgs e)
        {
            Parametros.Pesq = "Devolve";

            if (RbOficio.Checked == true)
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
                    // RetornoPesquisaOficio();

                }
                Parametros.Pesq = "";
            }
            else if (RbOficio.Checked == false)
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
            Parametros.Pesq = "";
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
                    txtCodigo.Text = dr.GetInt32(dr.GetOrdinal("CODPEDIDO")).ToString();
                    txtNumeroPedido.Text = dr.GetString(dr.GetOrdinal("NUMEROPEDIDO"));
                }
            }
            dr.Dispose();
            dr.Close();

            CarregaGrid();

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
                    //linhaDados[3] = dr.GetString(dr.GetOrdinal("ESTOQUEUBS"));


                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() != "0")
            {

                Gravar(true, 0);

            }
            else
            {

                Gravar(false, int.Parse(txtCodigo.Text.Trim()));

            }
        }

        private void Gravar(bool novo, int codigo)
        {

            if (txtNumeroPedido.Text.Trim() == "") { MessageBox.Show("Código é campo Obrigatório !"); txtNumeroPedido.Focus(); return; }
            if (txtdtdevolucao.Text.Trim() == "/  /") { MessageBox.Show("Data é campo Obrigatório !"); txtdtdevolucao.Focus(); return; }
            if (txtMotivo.Text.Trim() == "") { MessageBox.Show("Motivo é campo Obrigatório !"); txtMotivo.Focus(); return; }

            var hoje = DateTime.Now;
            var ofcreq = "";

            if (RbOficio.Checked == true)
            {
                ofcreq = "O";
            }
            else if (RbOficio.Checked == false)
            {
                ofcreq = "R";
            }

            var vcodigo = txtCodigo.Text.Trim();
            var vnumofcreq = txtNumeroPedido.Text.Trim();
            var vdtdevolucao = hoje.ToString();
            var vquenfez = Usuario.Nomeusuario.ToString();
            var vmotivo = txtMotivo.Text.Trim();

            try
            {
                var m = new Estorno(ofcreq, int.Parse(vcodigo), vnumofcreq, vdtdevolucao, vquenfez, vmotivo);
                if (novo)
                {
                    m.Insert();
                }
                
                    LimpaSaida(0);
                    AbrePedido(int.Parse(vcodigo));

                    MessageBox.Show("Registro Gravado com Sucesso !");
                Limpatela();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Persistência");
            }

        }

        private void LimpaSaida(int codsaida)
        {

            var dr = Classes.Mysql.Saida.BuscaNota(txtNumeroPedido.Text.Trim(), int.Parse(Usuario.Coddepartamento));
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    codsaida = dr.GetInt32(dr.GetOrdinal("CODSAIDA"));
                }

                if (codsaida != 0)
                {
                    var Del_saidaitem = new Classes.Mysql.Saida();
                    Del_saidaitem.DeleteSaidaItens(codsaida);

                    // AQUI TEM DE COLOCAR UM FECHAMENTO DE ESTOQUE 
                    FechaItens(codsaida.ToString());

                    var Del_saida = new Classes.Mysql.Saida();
                    Del_saida.DeleteSaida(codsaida);
                }
            }

        }


        private void FechaItens(string codigo)
        {
            
            var dr = Pedido_item.SelectPC(int.Parse(txtCodigo.Text));

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    var item = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    FechaEstoque(item);
                }
            }

            dr.Close();
            dr.Dispose();

        }


        public void FechaEstoque(string codproduto)
        {
            var codempresa = Usuario.Codempresa.ToString();
            var coddepartamento = Usuario.Coddepartamento.ToString();
            var grupo = "";

            DateTime data = Convert.ToDateTime(txtdtdevolucao.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);


            //PRIMEIRO PEGA O PRIMEIRO E O ULTIMO DIA DO MES 
            //DateTime com o primeiro dia do mês
            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);
            var dtinicial = primeiroDiaDoMes.ToString("dd/MM/yyyy");

            //DateTime com o último dia do mês
            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
            var dtfinal = ultimoDiaDoMes.ToString("dd/MM/yyyy");
            var UltimoDia = ultimoDiaDoMes.ToString("dd");

            var Est = new Estoque();

            var retorno = Est.DeleteMesAno(int.Parse(codempresa), int.Parse(coddepartamento), mes, ano, codproduto, grupo);

            //SEGUNDO PEGA OS PRODUTOS
            var dr = Produto.Select(codproduto, int.Parse(coddepartamento), grupo);

            var cont = new Produto();
            var Cont = cont.SelectCount();



            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    SaldoAnterior(int.Parse(codempresa), int.Parse(dr.GetString(dr.GetOrdinal("CODPRODUTO"))));

                    var cod = int.Parse(dr.GetString(dr.GetOrdinal("CODPRODUTO")));

                    DateTime totalDeDias = primeiroDiaDoMes;
                    for (int i = 0; i < int.Parse(UltimoDia); i++)
                    {
                        EntradaProduto(int.Parse(codempresa), int.Parse(coddepartamento), totalDeDias.ToString("dd/MM/yyyy"), int.Parse(dr.GetString(dr.GetOrdinal("CODPRODUTO"))));

                        SaidaProduto(int.Parse(codempresa), int.Parse(coddepartamento), totalDeDias.ToString("dd/MM/yyyy"), int.Parse(dr.GetString(dr.GetOrdinal("CODPRODUTO"))));

                        var Adiciona = totalDeDias.AddDays(1).ToString("dd/MM/yyyy");
                        totalDeDias = Convert.ToDateTime(Adiciona);


                    }

                    SaldoAtual(int.Parse(codempresa), int.Parse(dr.GetString(dr.GetOrdinal("CODPRODUTO"))));

                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void SaldoAnterior(int codempresa, int codproduto)
        {

            DateTime data = Convert.ToDateTime(txtdtdevolucao.Text.Trim());

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

            #region Verrificação de Balanco

            //DateTime com o primeiro dia do mês
            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);
            var dtinicial = primeiroDiaDoMes.ToString("dd/MM/yyyy");

            //DateTime com o último dia do mês
            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
            var dtfinal = ultimoDiaDoMes.ToString("dd/MM/yyyy");

            var temBalanco = Est.TemBalanco(codempresa, int.Parse(coddepartamento), dtinicial, dtfinal, codproduto);
            var QtAnterior = "0";

            #endregion
            if (temBalanco == true)
            {
                QtAnterior = "0";
            }
            else
            {
                //-> Buscando a quantidade do mes anterior 
                QtAnterior = Est.Anterior(codempresa, int.Parse(coddepartamento), int.Parse(vmes), int.Parse(vano), codproduto).ToString();
            }

            // id, codempresa, mes, ano,codproduto, qtanterior, entrada, saida , qtatual 
            var m = new Estoque(0, codempresa, int.Parse(coddepartamento), mes, ano, codproduto, QtAnterior.ToString(), "0", "0", "0");

            m.GravaAnterior();

            #endregion;

        }

        private void EntradaProduto(int codempresa, int coddepartamento, string dia, int codproduto)
        {

            DateTime data = Convert.ToDateTime(txtdtdevolucao.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);


            var ent = new Estoque(codempresa, coddepartamento, mes, ano, codproduto);

            ent.Fecha_Entradas(codempresa, coddepartamento, dia, codproduto);


        }

        private void SaidaProduto(int codempresa, int coddepartamento, string dia, int codproduto)
        {
            DateTime data = Convert.ToDateTime(txtdtdevolucao.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);


            var ent = new Estoque(codempresa, coddepartamento, mes, ano, codproduto);

            ent.Fecha_Saida(codempresa, coddepartamento, dia, codproduto);

        }

        private void SaldoAtual(int codempresa, int codproduto)
        {
            DateTime data = Convert.ToDateTime(txtdtdevolucao.Text.Trim());

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


        private void AbrePedido(int codpedido)
        {
            var U = new Pedido();
            U.UpdateStatus(codpedido, "ABERTO");
        }

        private void Limpatela()
        {
            txtNumeroPedido.Text = "";
            txtdtdevolucao.Text = "";
            txtCodigo.Text = "";
            txtMotivo.Text = "";

            DateTime date = this.dateTimePicker1.Value;
            this.txtdtdevolucao.Text = date.ToString("dd/MM/yyyy");

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            btnSalvar.Enabled = true;

        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            Limpatela();
        }
    }
}
