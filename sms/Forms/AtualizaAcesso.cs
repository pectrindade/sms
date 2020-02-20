using Atencao_Assistida.Classes.Mysql;
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
    public partial class AtualizaAcesso : Form
    {
        public AtualizaAcesso()
        {
            InitializeComponent();
        }

        private void btnsalva_Click(object sender, EventArgs e)
        {
            GravaAtualizacao();

        }

        private void GravaAtualizacao()
        {
            if (txtusuario.Text.Trim() == "")
            {
                MessageBox.Show("Login é campo Obrigatório !");
                txtusuario.Focus();
                return;
            }
            if (txtsenha1.Text.Trim() == "")
            {
                MessageBox.Show("Senha é campo Obrigatório !");
                txtsenha1.Focus();
                return;
            }
            if (txtsenha2.Text.Trim() == "")
            {
                MessageBox.Show("Senha é campo Obrigatório !");
                txtsenha2.Focus();
                return;
            }

            var hoje = DateTime.Now;

            var novo = false;

            var codigo = lblcodigo.Text;

            var login = txtusuario.Text;

            var senha1 = txtsenha1.Text;
            var senha2 = txtsenha2.Text;
            var senha = "";

            if (senha1 == senha2)
            {
                senha = senha1;
            }
            else
            {

                MessageBox.Show("Senhas não correspondem !");
                txtsenha1.Focus();
                return;
            }

            var respalteracao = Usuario.Nomeusuario.ToString();
            var dataalteracao = hoje.ToString();
            var excluido = "N";

            try
            {

                var m = new Acessos(int.Parse(codigo), login, senha);


                m.UpdateSenha();
                Close();
            }
            catch
            {
                MessageBox.Show("Erro na Persistência");
            }



        }

        private void AtualizaAcesso_Load(object sender, EventArgs e)
        {
            lblcodigo.Text = Usuario.Codusuario.ToString();
            lblNome.Text = Usuario.Nomeusuario.ToString();

            Usuario.Codempresa = "";
            Usuario.Codusuario = "";
            Usuario.Nomeusuario = "";
            Usuario.Cpf = "";
            Usuario.Login = "";
            Usuario.Email = "";

        }
    }
}
