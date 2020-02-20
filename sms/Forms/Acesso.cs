using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atencao_Assistida.Classes.Mysql;

namespace Atencao_Assistida.Forms
{
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private void Acesso_Load(object sender, EventArgs e)
        {
            CarregaCmbEmpresa();
            CarregaCmbDepartamento();
           
            cmbEmpresa.Focus();

            cmbEmpresa.SelectedIndex = 1;
            cmbDepartamento.SelectedIndex = 3;

        }

        private void btnsai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntra_Click(object sender, EventArgs e)
        {

            Usuario.Codempresa = "";
            Usuario.Coddepartamento = "";
            Usuario.Codunidade = "";

            Usuario.Codusuario = "";
            Usuario.Nomeusuario = "";
            Usuario.Cpf = "";
            Usuario.Login = "";
            Usuario.Email = "";
            Usuario.Funcao = "";
            Usuario.Lotado = "";

            if (cmbUsuario.Text.Trim() == "")
            {

                cmbUsuario.Focus();
                return;
            }
            if (txtsenha.Text.Trim() == "")
            {
              
                cmbUsuario.Focus();
                txtsenha.Focus();
                return;
            }
                       

            var codigo = Acessos.Acessar(cmbEmpresa.SelectedIndex, cmbDepartamento.SelectedIndex, cmbUsuario.Text, txtsenha.Text);
            if (codigo.Trim() != "")
            {
               
                var dr = new Acessos(int.Parse(codigo)).Select();

                var primeiroacesso = "";
               


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        // Recolhe as Informações do Usuario

                        var codEmpresa = dr.GetInt32(dr.GetOrdinal("CODEMPRESA")).ToString();
                        var codDepartamento = dr.GetInt32(dr.GetOrdinal("CODDEPARTAMENTO")).ToString();
                        var codUnidade = dr.GetInt32(dr.GetOrdinal("CODUNIDADE")).ToString();

                        var codUsuario = dr.GetInt32(dr.GetOrdinal("CODUSUARIO")).ToString();
                        var nome = dr.GetString(dr.GetOrdinal("NOME"));
                        var cpf = dr.GetString(dr.GetOrdinal("CPF"));
                        var login = dr.GetString(dr.GetOrdinal("login"));
                        var email = dr.GetString(dr.GetOrdinal("EMAIL"));
                        var funcao = dr.GetString(dr.GetOrdinal("FUNCAO"));
                        var lotado = dr.GetString(dr.GetOrdinal("LOTACAO"));

                        if (login == cpf)
                        {
                            primeiroacesso = "S";

                            Usuario.Codempresa = codEmpresa;
                            Usuario.Coddepartamento = codDepartamento;
                            Usuario.Codunidade = codUnidade;

                            Usuario.Codusuario = codUsuario;
                            Usuario.Nomeusuario = nome;
                            Usuario.Cpf = cpf;
                            Usuario.Login = login;
                            Usuario.Email = email;
                            Usuario.Funcao = funcao;
                            Usuario.Lotado = lotado;


                            bool open = false;
                            foreach (Form form in Application.OpenForms)
                            {

                                // Verifica se o form esta aberto
                                if (form.Name == "PesquisaPaciente")
                                {
                                    if (form is AtualizaAcesso)
                                    {
                                        form.BringToFront();
                                        open = true;
                                    }

                                }
                            }

                            if (!open)
                            {
                                Form tela = new AtualizaAcesso();
                                tela.ShowDialog();
                                RetornoAtualizaAcesso();
                            }
                            return;

                        }

                        Usuario.Codempresa = codEmpresa;
                        Usuario.Coddepartamento = codDepartamento;
                        Usuario.Codunidade = codUnidade;

                        Usuario.Codusuario = codUsuario;
                        Usuario.Nomeusuario = nome;
                        Usuario.Cpf = cpf;
                        Usuario.Login = login;
                        Usuario.Email = email;
                        Usuario.Funcao = funcao;
                        Usuario.Lotado = lotado;

                       
                        this.Close();

                    }
                }
                dr.Dispose();
                dr.Close();

               

              
            }
            else
            {
                lblmensagem.Visible = true;
                cmbUsuario.Text = "";
                txtsenha.Text = "";

                cmbUsuario.Focus();
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

        private void CarregaCmbUsuario(int cod)
        {

            int codigo;
            string nome;

            cmbUsuario.Items.Clear();

            cmbUsuario.Items.Insert(0, "--SELECIONE--");

            //var dr = Acessos.SelectTudo();

            var dr = Acessos.SelectDepartamento(cod);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    codigo = int.Parse(dr.GetString(dr.GetOrdinal("CODUSUARIO")));
                    nome = dr.GetString(dr.GetOrdinal("LOGIN"));

                    //cmbUsuario.Items.Insert(codigo, nome);
                    cmbUsuario.Items.Add(nome);
                }

            }

            dr.Close();
            dr.Dispose();

        }

       private void RetornoAtualizaAcesso()
        {
            //CarregaCmbUsuario();
            txtsenha.Text = "";
            cmbUsuario.Focus();
            lblAltera.Visible = true;
        }

        private void Acesso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void btnsai_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbDepartamento_TextChanged(object sender, EventArgs e)
        {
            var cod = cmbDepartamento.SelectedIndex.ToString();

            CarregaCmbUsuario(int.Parse(cod));
        }
    }
}
