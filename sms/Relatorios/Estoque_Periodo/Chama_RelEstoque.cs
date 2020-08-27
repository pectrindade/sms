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

namespace Atencao_Assistida.Relatorios.Estoque_Periodo
{
    public partial class Chama_RelEstoque : Form
    {
        public Chama_RelEstoque()
        {
            InitializeComponent();
        }

        private void Chama_RelEstoque_Load(object sender, EventArgs e)
        {
            CarregaCmbEmpresa();
            CarregaCmbDepartamento();
            CarregaCmbGrupo();
            cmbEmpresa.SelectedIndex = 1;

            if (RbCodigo.Checked == true)
            {
                PnlPorNome.Visible = false;
            }
        }

        private void Chama_RelEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                if (ActiveControl.Name == "txtCodigo") { btnBuscaProduto.PerformClick(); return; }
            }
        }

        private void Chama_RelEstoque_KeyPress(object sender, KeyPressEventArgs e)
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
            var data = txtDataInicial.Text.Trim();

            if (Classes.Funcoes.Funcoes.CheckDate(data) == false)
            {
                MessageBox.Show("Data é campo Obrigatório !");
                txtDataInicial.Focus();

                return;
            }
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
            DateTime dtInicial;
            var mes = "";
            var ano = "";

            try
            {
                dtInicial = Convert.ToDateTime(txtDataInicial.Text.Trim());
                mes = dtInicial.Month.ToString();
                ano = dtInicial.Year.ToString();
            }
            catch
            {
                Application.OpenForms["Espera"].Close();
                MessageBox.Show("Data é campo Obrigatório !");
                txtDataInicial.Focus();
                
                return;
            }

            var codempresa = cmbEmpresa.SelectedIndex;

            var nomeempresa = "";
            var coddepartamento = cmbDepartamento.SelectedIndex;
            var nomedepartamento = "";
            //mes = dtInicial.Month.ToString();
            //ano = dtInicial.Year.ToString();
            var codgrupo = cmbGrupo.SelectedIndex;
            var nomegrupo = "";
            var codproduto = 0;
            var buscaNome = "";
            if (txtcodigo.Text.Trim() != "") { codproduto = int.Parse(txtcodigo.Text.Trim()); }
            if (txtBuscaNome.Text.Trim() != "") { buscaNome = txtBuscaNome.Text.Trim(); }
            var nomeproduto = "";

            var qtanterior = "";
            var entrada = "";
            var saida = "";
            var qtatual = "";
            var negativo = false;

            if (codempresa == -1) { codempresa = 0; }
            if (coddepartamento == -1) { coddepartamento = 0; }
            if (codgrupo == -1) { codgrupo = 0; }
            if (chkNegativo.Checked == true) { negativo = true; }


            var cria = new Classes.Funcoes.CriaArquivo();
            cria.Cria_EstoquePeriodo();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Estoque.Estoque_Periodo(codempresa, coddepartamento, codgrupo, codproduto, buscaNome, mes, ano, negativo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (!dr.IsDBNull(dr.GetOrdinal("CODEMPRESA"))) { codempresa = dr.GetInt32(dr.GetOrdinal("CODEMPRESA")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEEMPRESA"))) { nomeempresa = dr.GetString(dr.GetOrdinal("NOMEEMPRESA")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("CODDEPARTAMENTO"))) { coddepartamento = dr.GetInt32(dr.GetOrdinal("CODDEPARTAMENTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEDEPARTAMENTO"))) { nomedepartamento = dr.GetString(dr.GetOrdinal("NOMEDEPARTAMENTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("MES"))) { mes = dr.GetString(dr.GetOrdinal("MES")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("ANO"))) { ano = dr.GetString(dr.GetOrdinal("ANO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("CODGRUPO"))) { codgrupo = dr.GetInt32(dr.GetOrdinal("CODGRUPO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEGRUPO"))) { nomegrupo = dr.GetString(dr.GetOrdinal("NOMEGRUPO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("CODPRODUTO"))) { codproduto = dr.GetInt32(dr.GetOrdinal("CODPRODUTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEPRODUTO"))) { nomeproduto = dr.GetString(dr.GetOrdinal("NOMEPRODUTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("QTANTERIOR"))) { qtanterior = dr.GetString(dr.GetOrdinal("QTANTERIOR")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("ENTRADA"))) { entrada = dr.GetString(dr.GetOrdinal("ENTRADA")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("SAIDA"))) { saida = dr.GetString(dr.GetOrdinal("SAIDA")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("QTATUAL"))) { qtatual = dr.GetString(dr.GetOrdinal("QTATUAL")); }

                    try
                    {
                        var m = new Classes.Mysql.Estoque();

                        m.InsertAccess_Estoque_Periodo(codempresa, nomeempresa, coddepartamento, nomedepartamento, mes, ano, codgrupo, nomegrupo,
                            codproduto, nomeproduto, qtanterior, entrada, saida, qtatual);
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
                if (form is RelEstoquePeriodo)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelEstoquePeriodo();
                tela.ShowDialog();
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;

            this.txtDataInicial.Text = date.ToString("dd/MM/yyyy");
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
                txtBuscaNome.Text = "";
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
            txtBuscaNome.Text = "";

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
            txtBuscaNome.Text = "";
            txtDataInicial.Text = "";
            chkNegativo.Checked = false;

            RbCodigo.Checked = true;
            RbNome.Checked = false;

            cmbEmpresa.Focus();
        }

        private void btnDesfaz_Click(object sender, EventArgs e)
        {
            LimpraTela();
        }

        private void btnBuscaProduto_Click_1(object sender, EventArgs e)
        {

            txtcodigo.Text = "";
            txtNome.Text = "";
            txtBuscaNome.Text = "";

            Parametros.Form = "Produtos";
            Parametros.Valor = "";

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaProdutos")
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

        private void RbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (RbCodigo.Checked == true)
            {
                PnlPorNome.Visible = false;
                PnlPorCodigo.Visible = true;

                txtcodigo.Text = "";
                txtNome.Text = "";
                txtBuscaNome.Text = "";
            }
        }

        private void RbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (RbNome.Checked == true)
            {
                PnlPorCodigo.Visible = false;
                PnlPorNome.Visible = true;

                txtcodigo.Text = "";
                txtNome.Text = "";
                txtBuscaNome.Text = "";
            }
        }
    }
}
