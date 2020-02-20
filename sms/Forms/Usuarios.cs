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

namespace Atencao_Assistida.Forms
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CarregaCmbEmpresa();
            CarregaCmbDepartamento();
            CarregaCmbUnidade();
            CarregaAtivo();
        }

        private void CarregaCmbEmpresa()
        {
            int codigo;
            string nome;


            CmbEmpresa.Items.Clear();

            CmbEmpresa.Items.Insert(0, "--SELECIONE--");

            var dr = Empresa.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    codigo = int.Parse(dr.GetString(dr.GetOrdinal("CODEMPRESA")));
                    nome = dr.GetString(dr.GetOrdinal("NOME"));

                    CmbEmpresa.Items.Insert(codigo, nome);
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

        private void CarregaCmbUnidade()
        {
            int codigo;
            string nome;


            CmbUnidade.Items.Clear();

            CmbUnidade.Items.Insert(0, "--SELECIONE--");

            var dr = Classes.Mysql.Unidade.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    codigo = int.Parse(dr.GetString(dr.GetOrdinal("CODUNIDADE")));
                    nome = dr.GetString(dr.GetOrdinal("NOME"));

                    CmbUnidade.Items.Insert(codigo, nome);
                }

            }

            dr.Close();
            dr.Dispose();

        }



        private void Usuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void CarregaAtivo()
        {
            cmbativo.Items.Clear();
            cmbativo.Items.Insert(0, "--SELECIONE--");
            cmbativo.Items.Insert(1, "Ativo");
            cmbativo.Items.Insert(2, "Inativo");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void BtnGravarClick(object sender, EventArgs e)
        {
            var hoje = DateTime.Now;

            var novo = false;

            var codigo = txtcodigo.Text;
            var codEmpresa = CmbEmpresa.SelectedIndex.ToString();
            var coddepartamento = cmbDepartamento.SelectedIndex.ToString();
            var codunidade = CmbUnidade.SelectedIndex.ToString();
            var nome = txtnome.Text;
            var cpf = Classes.Funcoes.Utilidades.RemoveFormatacao(mskCpf.Text);
            var email = txtemail.Text;
            var telefone = txttelefone.Text;
            var login = Classes.Funcoes.Utilidades.RemoveFormatacao(mskCpf.Text);
            var senha = "123456";
            var ativo = cmbativo.SelectedIndex.ToString();

            var respinclusao = Usuario.Nomeusuario.ToString();
            var datainclusao = hoje.ToString();
            var respalteracao = Usuario.Nomeusuario.ToString();
            var dataalteracao = hoje.ToString();
            var excluido = "N";


            if (txtcodigo.Text == "0")
                novo = true;
            else
                codigo = txtcodigo.Text.Trim();
            try
            {

                var m = new Acessos(int.Parse(codigo), int.Parse(codEmpresa), int.Parse(coddepartamento), int.Parse(codunidade), 0, nome, cpf, email, telefone, login, senha, int.Parse(ativo), respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao, excluido);

                if (novo)
                    m.Insert();
                else
                    m.Update();

                MessageBox.Show("Registro Gravado com Sucesso !");

                LimpaTela();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Persistência");
            }

        }

        private void btnProcuraUsuario_Click(object sender, EventArgs e)
        {
            Parametros.Form = "Usuario";
            Parametros.Valor = "";

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaUsuario")
                {
                    if (form is PesquisaUsuario)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {
                Form tela = new PesquisaUsuario();
                tela.ShowDialog();
                RetornoPesquisaUsuario();

            }
        }

        public void RetornoPesquisaUsuario()
        {
            if (Parametros.Valor != "")
            {
                BuscaUsuario(int.Parse(Parametros.Valor));
            }
        }

        private void BuscaUsuario(int codigo)
        {
            if (Parametros.Valor != "")
            {
                codigo = int.Parse(Parametros.Valor);
            }


            var dr = Acessos.Select(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtcodigo.Text = dr.GetInt32(dr.GetOrdinal("CODUSUARIO")).ToString();
                    txtnome.Text = dr.GetString(dr.GetOrdinal("NOME"));
                    mskCpf.Text = dr.GetString(dr.GetOrdinal("CPF"));
                    txtemail.Text = dr.GetString(dr.GetOrdinal("EMAIL"));
                    txttelefone.Text = dr.GetString(dr.GetOrdinal("TELEFONE"));

                    CarregaCmbEmpresa();
                    CmbEmpresa.SelectedIndex = dr.GetInt32(dr.GetOrdinal("CODEMPRESA"));

                    CarregaCmbDepartamento();
                    cmbDepartamento.SelectedIndex = dr.GetInt32(dr.GetOrdinal("CODDEPARTAMENTO"));

                    CarregaCmbUnidade();
                    CmbUnidade.SelectedIndex = dr.GetInt32(dr.GetOrdinal("CODUNIDADE"));

                    CarregaAtivo();
                    cmbativo.SelectedIndex = dr.GetInt32(dr.GetOrdinal("ATIVO"));


                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            { return; }

            if (txtcodigo.Text != "0")
            {
                BuscaUsuario(int.Parse(txtcodigo.Text));
            }
        }

        private void LimpaTela()
        {
            txtcodigo.Text = "0";
            txtnome.Text = "";
            mskCpf.Text = "";
            txtemail.Text = "";
            txttelefone.Text = "";
            CmbEmpresa.SelectedIndex = 0;
            cmbDepartamento.SelectedIndex = 0;
            CmbUnidade.SelectedIndex = 0;
            cmbativo.SelectedIndex = 0;

            Parametros.Form = "Usuario";
            txtcodigo.Focus();

        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void txtnome_Leave(object sender, EventArgs e)
        {
            if (txtnome.Text.Trim() == "")
            {
                MessageBox.Show("Campo Obrigatório !");
                txtnome.Focus();
            }
        }

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            if (mskCpf.Text.Trim() == "")
            {
                MessageBox.Show("Campo Obrigatório !");
                mskCpf.Focus();
            }
            else
            {
                var cpf = Classes.Funcoes.Utilidades.RemoveFormatacao(mskCpf.Text);

                if (Classes.Funcoes.Utilidades.ValidaCpf(cpf))
                {

                }
                else
                {
                    MessageBox.Show("O número é um CPF Inválido !");
                }

            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text.Trim() == "")
            {
                MessageBox.Show("Campo Obrigatório !");
                txtemail.Focus();
            }
        }

        private void txttelefone_Leave(object sender, EventArgs e)
        {
            if (txttelefone.Text.Trim() == "")
            {
                MessageBox.Show("Campo Obrigatório !");
                txttelefone.Focus();
            }
        }

        private void cmbativo_Leave(object sender, EventArgs e)
        {
            if (cmbativo.Text.Trim() == "--SELECIONE--")
            {
                MessageBox.Show("Campo Obrigatório !");
                cmbativo.Focus();
            }
        }
    }
}
