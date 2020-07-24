using Atencao_Assistida.Classes.Mysql;
using Atencao_Assistida.Pesquisas;
using Atencao_Assistida.Relatorios.Saida_Periodo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.EntradaPeriodo
{
    public partial class ChamaRelEntrada : Form
    {
        public ChamaRelEntrada()
        {
            InitializeComponent();
        }

        private void ChamaRelEntrada_Load(object sender, EventArgs e)
        {
            CarregaCmbEmpresa();
            cmbEmpresa.SelectedIndex = 1;
            CarregaCmbDepartamento();
        }



        private void ChamaRelEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                if (ActiveControl.Name == "txtCodUnidade") { btnBuscaFornecedor.PerformClick(); return; }
            }
        }

        private void ChamaRelEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }


        private void CarregaCmbEmpresa()
        {
            int codigo;
            string nome;


            cmbEmpresa.Items.Clear();

            cmbEmpresa.Items.Insert(0, "--SELECIONE--");

            var dr = Empresa.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    codigo = int.Parse(dr.GetString(dr.GetOrdinal("CODEMPRESA")));
                    nome = dr.GetString(dr.GetOrdinal("NOME"));

                    cmbEmpresa.Items.Insert(codigo, nome);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void CarregaCmbDepartamento()
        {
            int codigo;
            string nome;

            cmbDepartamento.Items.Clear();

            cmbDepartamento.Items.Insert(0, "--SELECIONE--");

            var dr = Classes.Mysql.Departamento.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    codigo = int.Parse(dr.GetString(dr.GetOrdinal("CODDEPARTAMENTO")));
                    nome = dr.GetString(dr.GetOrdinal("NOME"));

                    cmbDepartamento.Items.Insert(codigo, nome);
                }

            }

            dr.Close();
            dr.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarRelatorio();
        }

        private void CarregarRelatorio()
        {
            try
            {
                System.Threading.Thread tFormAguarde = new System.Threading.Thread(new System.Threading.ThreadStart(CarregaFormAguarde));
                tFormAguarde.Start();

                Relatorio();

                tFormAguarde.Abort();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CarregaFormAguarde()
        {
            Form f = new Forms.Espera();
            f.ShowDialog();
        }

        private void Relatorio()
        {

            DateTime dtInicial = Convert.ToDateTime(txtDataInicial.Text.Trim());
            string DataInicial = dtInicial.Year.ToString() + "-" + dtInicial.Month.ToString() + "-" + dtInicial.Day.ToString();

            DateTime dtFinal = Convert.ToDateTime(txtDataFinal.Text.Trim());
            string DataFinal = dtFinal.Year.ToString() + "-" + dtFinal.Month.ToString() + "-" + dtFinal.Day.ToString();



            var codempresa = 0;
            var nomeempresa = "";
            var coddepartamento = 0;
            var nomedepartamento = "";
            var codentrada = 0;
            var dataentrada = "";
            var codfornecedor = 0;
            if (txtCodFornecedor.Text.Trim() != "") { codfornecedor = int.Parse(txtCodFornecedor.Text.Trim()); }

            var nomefornecedor = "";
            var solicitante = "";
            var numeronf = "";
            var codproduto = 0;
            if (txtcodigo.Text.Trim() != "") { codproduto = int.Parse(txtcodigo.Text.Trim()); }

            var nomeproduto = "";
            var quantidade = "";


            var cria = new Classes.Funcoes.CriaArquivo();
            cria.Cria_EntradaPeriodo();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Entrada.Entrada_Periodo(cmbEmpresa.SelectedIndex, cmbDepartamento.SelectedIndex, codfornecedor, codproduto, DataInicial, DataFinal);

            if (dr.HasRows)
            {
                while (dr.Read())
                {


                    if (!dr.IsDBNull(dr.GetOrdinal("CODEMPRESA"))) { codempresa = dr.GetInt32(dr.GetOrdinal("CODEMPRESA")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEEMPRESA"))) { nomeempresa = dr.GetString(dr.GetOrdinal("NOMEEMPRESA")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("CODDEPARTAMENTO"))) { coddepartamento = dr.GetInt32(dr.GetOrdinal("CODDEPARTAMENTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEDEPARTAMENTO"))) { nomedepartamento = dr.GetString(dr.GetOrdinal("NOMEDEPARTAMENTO")); }

                    if (!dr.IsDBNull(dr.GetOrdinal("CODENTRADA"))) { codentrada = dr.GetInt32(dr.GetOrdinal("CODENTRADA")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NUMERONOTA"))) { numeronf = dr.GetString(dr.GetOrdinal("NUMERONOTA")) + "/" + dr.GetString(dr.GetOrdinal("SERIE")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("CODFORNECEDOR"))) { codfornecedor = dr.GetInt32(dr.GetOrdinal("CODFORNECEDOR")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEFORNECEDOR"))) { nomefornecedor = dr.GetString(dr.GetOrdinal("NOMEFORNECEDOR")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("DATAENTRADA"))) { dataentrada = dr.GetString(dr.GetOrdinal("DATAENTRADA")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("CODPRODUTO"))) { codproduto = dr.GetInt32(dr.GetOrdinal("CODPRODUTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEPRODUTO"))) { nomeproduto = dr.GetString(dr.GetOrdinal("NOMEPRODUTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("QUANTIDADE"))) { quantidade = dr.GetString(dr.GetOrdinal("QUANTIDADE")); }


                    try
                    {
                        var m = new Classes.Mysql.Entrada();

                        m.InsertAccessEntradaPeriodo(codempresa, nomeempresa, coddepartamento, nomedepartamento, codentrada, numeronf, codfornecedor, nomefornecedor,
                            dataentrada, codproduto, nomeproduto, quantidade);
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
                if (form is RelEntradaPeriodo)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelEntradaPeriodo();
                tela.ShowDialog();
            }

        }

        private void txtCodUnidade_Leave(object sender, EventArgs e)
        {
            if (txtCodFornecedor.Text.Trim() != "")
            {
                BuscaFornecedor();
            }
            else
            {
                txtNomeFornecedor.Text = "";
            }
        }

        private void btnBuscaFornecedor_Click(object sender, EventArgs e)
        {

            txtCodFornecedor.Text = "";
            txtNomeFornecedor.Text = "";
            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaUnidade")
                {
                    if (form is PesquisaFornecedor)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {

                Form tela = new PesquisaFornecedor();

                tela.ShowDialog();
                RetornoPesquisaFornecedor();

            }
        }

        private void RetornoPesquisaFornecedor()
        {
            if (Parametros.Valor != "")
            {
                txtCodFornecedor.Text = Parametros.Valor;
                BuscaFornecedor();
            }

        }

        private void BuscaFornecedor()
        {
            var dr = Classes.Mysql.Fornecedor.Select(int.Parse(txtCodFornecedor.Text));

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtCodFornecedor.Text = dr.GetString(dr.GetOrdinal("CODFORNECEDOR"));
                    txtNomeFornecedor.Text = dr.GetString(dr.GetOrdinal("NOME"));
                }
            }
            dr.Close();
            dr.Dispose();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;

            this.txtDataInicial.Text = date.ToString("dd/MM/yyyy");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker2.Value;

            this.txtDataFinal.Text = date.ToString("dd/MM/yyyy");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Trim() != "")
            {
                BuscaProduto(int.Parse(txtcodigo.Text));
            }
            else
            {
                txtNome.Text = "";
            }
        }

        private void BuscaProduto(int codigo)
        {
            var cod1 = Usuario.Coddepartamento;

            var dr = Classes.Mysql.Produto.Select(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtcodigo.Text = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    txtNome.Text = dr.GetString(dr.GetOrdinal("NOME"));
                }

            }

            dr.Close();
            dr.Dispose();

            txtDataInicial.Focus();
        }

        private void btnBuscaProduto_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtNome.Text = "";

            Parametros.Form = "Produtos";
            Parametros.Valor = "";

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaPaciente")
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
                //tela.MdiParent = this.MdiParent;
                tela.ShowDialog();
                RetornoPesquisaMedicamento();
            }
        }

        public void RetornoPesquisaMedicamento()
        {
            if (Parametros.Valor != "")
            {
                BuscaProduto(int.Parse(Parametros.Valor));
            }
        }

        private void LimpraTela()
        {
            CarregaCmbEmpresa();
            CarregaCmbDepartamento();
            txtCodFornecedor.Text = "";
            txtNomeFornecedor.Text = "";
            txtcodigo.Text = "";
            txtNome.Text = "";
            txtDataInicial.Text = "";
            txtDataFinal.Text = "";

            cmbEmpresa.Focus();
        }

        private void btnDesfaz_Click(object sender, EventArgs e)
        {
            LimpraTela();
        }

        private void txtCodFornecedor_Leave(object sender, EventArgs e)
        {
            if (txtCodFornecedor.Text.Trim() != "")
            {
                BuscaFornecedor();
            }
        }
    }
}
