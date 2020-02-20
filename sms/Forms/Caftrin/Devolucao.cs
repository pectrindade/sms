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

                    var Del_saida = new Classes.Mysql.Saida();
                    Del_saida.DeleteSaida(codsaida);
                }
            }

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
