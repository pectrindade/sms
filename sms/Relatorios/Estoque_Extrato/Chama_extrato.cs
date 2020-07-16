using Atencao_Assistida.Classes.Mysql;
using Atencao_Assistida.Pesquisas;
using Atencao_Assistida.Relatorios.Estoque_Periodo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.Estoque_Extrato
{
    public partial class Chama_extrato : Form
    {
        public Chama_extrato()
        {
            InitializeComponent();
        }

        private void Chama_extrato_Load(object sender, EventArgs e)
        {
            CarregaCmbEmpresa();
            CarregaCmbDepartamento();
            CarregaCmbGrupo();

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

        private void CarregaCmbGrupo()
        {
            int codigo;
            string nome;

            cmbGrupo.Items.Clear();

            cmbGrupo.Items.Insert(0, "--SELECIONE--");

            var dr = Classes.Mysql.Grupo.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    codigo = int.Parse(dr.GetString(dr.GetOrdinal("CODGRUPO")));
                    nome = dr.GetString(dr.GetOrdinal("DESCRICAO"));
                    cmbGrupo.Items.Insert(codigo, nome);
                }
            }
            dr.Close();
            dr.Dispose();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            CarregarRelatorio();
        }

        private void CarregarRelatorio()
        {
            try
            {
                //System.Threading.Thread tFormAguarde = new System.Threading.Thread(new System.Threading.ThreadStart(CarregaFormAguarde));
                //tFormAguarde.Start();

                Relatorio();

                //tFormAguarde.Abort();
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
            var cria = new Classes.Funcoes.CriaArquivo();
            cria.Cria_Temp();
            cria.Cria_EstoqueExtrato();

            var codempresa = cmbEmpresa.SelectedIndex;
            var nomeempresa = cmbEmpresa.Text;
            var coddepartamento = cmbDepartamento.SelectedIndex;
            var nomedepartamento = cmbDepartamento.Text;
            var codgrupo = cmbGrupo.SelectedIndex;
            var nomegrupo = cmbGrupo.Text;
            var dtinicial = txtDataInicial.Text.Trim();
            var dtfinal = txtDataFinal.Text.Trim();
            var codproduto = 0;
            if (txtcodigo.Text.Trim() != "") { codproduto = int.Parse(txtcodigo.Text.Trim()); }
            var nomeproduto = "";

            var datamovimento = "";
            var codmovimento = 0;
            var tipomovimento = "";
            var quantidade = "";

            if (codempresa == -1) { codempresa = 0; }
            if (coddepartamento == -1) { coddepartamento = 0; }
            if (codgrupo == -1) { codgrupo = 0; }

            var saldo = "0";

            float qtanterior = 0;

            DateTime data = Convert.ToDateTime(txtDataInicial.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);

            var Est = new Classes.Mysql.Estoque();

            var mesanterior = Est.BuscaMesAnterior(mes, ano);
            vmes = mesanterior.Substring(0, 2);
            vano = mesanterior.Substring(2, 4);


            //DateTime com o primeiro dia do mês
            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);
            var dta = primeiroDiaDoMes.ToString("dd/MM/yyyy");
            datamovimento = dta;

            // BUSCA SALDO ANTERIOR E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Estoque.BuscaAnterior(codempresa, coddepartamento, int.Parse(vmes), int.Parse(vano), codproduto);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    qtanterior = dr.GetFloat(dr.GetOrdinal("QTATUAL"));
                }
            }

            try
            {

                tipomovimento = "QUANTIDADE ANTERIOR";
                quantidade = qtanterior.ToString();
                saldo = qtanterior.ToString();
                nomeproduto = " XXXXXXXXXXXXXXXXX";

                var m = new Classes.Mysql.Estoque();

                m.InsertAccessExtrato(codempresa, nomeempresa, coddepartamento, nomedepartamento, codgrupo, nomegrupo, dtinicial, dtfinal, codproduto, nomeproduto,
                datamovimento, codmovimento, tipomovimento, quantidade, saldo);
            }
            catch (Exception erro)
            {

            }

            dr.Dispose();
            dr.Close();


            // BUSCA BALANCO E GRAVA NO REPOSITORIO
            dr = Classes.Mysql.Estoque.BuscaBalancoMes(codempresa, coddepartamento, dtinicial, dtfinal, codproduto);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    if (!dr.IsDBNull(dr.GetOrdinal("CODPRODUTO"))) { codproduto = dr.GetInt32(dr.GetOrdinal("CODPRODUTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEPRODUTO"))) { nomeproduto = dr.GetString(dr.GetOrdinal("NOMEPRODUTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("DATABALANCO"))) { datamovimento = dr.GetString(dr.GetOrdinal("DATABALANCO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("QUANTIDADE"))) { quantidade = dr.GetString(dr.GetOrdinal("QUANTIDADE")); }

                    tipomovimento = "BALANÇO";
                    saldo = quantidade ;
                    nomeproduto = " XXXXXXXXXXXXXXXXX";

                    try
                    {
                        var m = new Classes.Mysql.Estoque();

                        m.InsertAccessExtrato(codempresa, nomeempresa, coddepartamento, nomedepartamento, codgrupo, nomegrupo, dtinicial, dtfinal, codproduto, nomeproduto,
                        datamovimento, codmovimento, tipomovimento, quantidade, saldo);
                    }
                    catch (Exception erro)
                    {
                    }
                }
            }

            dr.Close();
            dr.Dispose();

            // BUSCA ENTRADA E GRAVA NO REPOSITORIO
            dr = Classes.Mysql.Estoque.BuscaEntradaMes(codempresa, coddepartamento, dtinicial, dtfinal, codproduto);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    if (!dr.IsDBNull(dr.GetOrdinal("CODPRODUTO"))) { codproduto = dr.GetInt32(dr.GetOrdinal("CODPRODUTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("DESCRICAO"))) { nomeproduto = dr.GetString(dr.GetOrdinal("DESCRICAO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("DATARECEBIMENTO"))) { datamovimento = dr.GetString(dr.GetOrdinal("DATARECEBIMENTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("QUANTIDADE"))) { quantidade = dr.GetString(dr.GetOrdinal("QUANTIDADE")); }

                    if (!dr.IsDBNull(dr.GetOrdinal("CODENTRADA"))) { codmovimento = dr.GetInt32(dr.GetOrdinal("CODENTRADA")); }

                    tipomovimento = "ENTRADA";
                    //qtanterior = float.Parse(quantidade) + float.Parse(quantidade);
                    //saldo = qtanterior.ToString();

                    try
                    {
                        var m = new Classes.Mysql.Estoque();

                        m.InsertAccessExtrato(codempresa, nomeempresa, coddepartamento, nomedepartamento, codgrupo, nomegrupo, dtinicial, dtfinal, codproduto, nomeproduto,
                        datamovimento, codmovimento, tipomovimento, quantidade, saldo);
                    }
                    catch (Exception erro)
                    {

                    }

                }

            }

            dr.Close();
            dr.Dispose();

            // BUSCA SAIDAS E GRAVA NO REPOSITORIO
            dr = Classes.Mysql.Estoque.BuscaSaidaMes(codempresa, coddepartamento, dtinicial, dtfinal, codproduto);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    if (!dr.IsDBNull(dr.GetOrdinal("CODPRODUTO"))) { codproduto = dr.GetInt32(dr.GetOrdinal("CODPRODUTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("DESCRICAO"))) { nomeproduto = dr.GetString(dr.GetOrdinal("DESCRICAO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("DATAENTREGA"))) { datamovimento = dr.GetString(dr.GetOrdinal("DATAENTREGA")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("ENTREGUE"))) { quantidade = dr.GetString(dr.GetOrdinal("ENTREGUE")); }

                    if (!dr.IsDBNull(dr.GetOrdinal("CODSAIDA"))) { codmovimento = dr.GetInt32(dr.GetOrdinal("CODSAIDA")); }

                    tipomovimento = "SAIDA";
                    //qtanterior = float.Parse(quantidade) - float.Parse(quantidade);
                    //saldo = qtanterior.ToString();

                    try
                    {
                        var m = new Classes.Mysql.Estoque();

                        m.InsertAccessExtrato(codempresa, nomeempresa, coddepartamento, nomedepartamento, codgrupo, nomegrupo, dtinicial, dtfinal, codproduto, nomeproduto,
                        datamovimento, codmovimento, tipomovimento, quantidade, saldo);
                    }
                    catch (Exception erro)
                    {

                    }

                }

            }

            dr.Close();
            dr.Dispose();


            // BUSCA NO REPOSITORIO E ORGANIZA O SALDO
            var dr1 = Classes.Mysql.Estoque.BuscaExtratoAccess();
            
            int Ucodproduto = 0;
            string unomeproduto = "";
            string Udatamovimento = "";
            int Ucodmovimento = 0;
            string Utipomovimento = "";
            string Uquantidade = "0";
            saldo = "0";

            if (dr1.HasRows)
            {
                while (dr1.Read())
                {

                    if (!dr1.IsDBNull(dr1.GetOrdinal("CODPRODUTO"))) { Ucodproduto = dr1.GetInt32(dr1.GetOrdinal("CODPRODUTO")); }
                    if (!dr1.IsDBNull(dr1.GetOrdinal("NOMEPRODUTO"))) { unomeproduto = dr1.GetString(dr1.GetOrdinal("NOMEPRODUTO")); }
                    if (!dr1.IsDBNull(dr1.GetOrdinal("CODMOVIMENTO"))) { Ucodmovimento = dr1.GetInt32(dr1.GetOrdinal("CODMOVIMENTO")); }
                    if (!dr1.IsDBNull(dr1.GetOrdinal("TIPOMOVIMENTO"))) { Utipomovimento = dr1.GetString(dr1.GetOrdinal("TIPOMOVIMENTO")); }
                    if (!dr1.IsDBNull(dr1.GetOrdinal("QUANTIDADE"))) { Uquantidade = dr1.GetString(dr1.GetOrdinal("QUANTIDADE")); }
                    Udatamovimento = dr1.GetDateTime(dr1.GetOrdinal("DATAMOVIMENTO")).ToString();

                    if (Utipomovimento == "QUANTIDADE ANTERIOR")
                    {
                        saldo = Uquantidade;
                    }

                    if (Utipomovimento == "BALANÇO")
                    {
                        saldo = Uquantidade;
                    }

                    if (Utipomovimento == "ENTRADA")
                    {
                        saldo = (float.Parse(saldo) + float.Parse(Uquantidade)).ToString();
                    }

                    if (Utipomovimento == "SAIDA")
                    {
                        saldo = (float.Parse(saldo) - float.Parse(Uquantidade)).ToString();
                    }

                    try
                    {
                        var m = new Classes.Mysql.Estoque();

                        m.InsertAccessExtrato1(codempresa, nomeempresa, coddepartamento, nomedepartamento, codgrupo, nomegrupo, dtinicial, dtfinal, codproduto, unomeproduto,
                        Udatamovimento, Ucodmovimento, Utipomovimento, Uquantidade, saldo);
                    }
                    catch (Exception erro)
                    {

                    }

                }

            }

            dr1.Close();
            dr1.Dispose();


            //CHAMA A TELA DE RELATORIO
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Rel_Extrato)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Rel_Extrato();
                tela.ShowDialog();
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

            txtNome.Focus();
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
            CarregaCmbGrupo();
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

        private void dtpInicial_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dtpfinal.Value;

            this.txtDataInicial.Text = date.ToString("dd/MM/yyyy");
        }

        private void dtpfinal_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dtpfinal.Value;

            this.txtDataFinal.Text = date.ToString("dd/MM/yyyy");
        }

        private void Chama_extrato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                //if (ActiveControl.Name == "txtcodigo") { btnBuscaProduto.PerformClick(); return; }
            }
        }

        private void Chama_extrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
