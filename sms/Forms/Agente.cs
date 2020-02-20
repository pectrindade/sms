using Atencao_Assistida.Pesquisas;
using Atencao_Assistida.Relatorios.Agente;
//using Atencao_Assistida.Relatorios.Agente;
using System;
using System.Windows.Forms;

namespace Atencao_Assistida.Forms
{
    public partial class Agente : Form
    {

        public string glbCodAgente;

        public Agente()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            Close();
        }

        private void Agente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Agente_Load(object sender, EventArgs e)
        {


        }


        private void BuscaAgente(int codigo)
        {
            if (Parametros.Valor != "")
            {
                codigo = int.Parse(Parametros.Valor);
            }


            var dr = Classes.Mysql.Agente.BuscaUm(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtcodigo.Text = dr.GetString(dr.GetOrdinal("CODAgente"));
                    txtNome.Text = dr.GetString(dr.GetOrdinal("NOME"));
                   
                    txtendereco.Text = dr.GetString(dr.GetOrdinal("ENDERECO"));
                    txtbairro.Text = dr.GetString(dr.GetOrdinal("BAIRRO"));
                    txtfone.Text = dr.GetString(dr.GetOrdinal("TELEFONE"));
                    txtcell.Text = dr.GetString(dr.GetOrdinal("CELL"));
                    //cmbativo.Text = dr.GetString(dr.GetOrdinal("NOME"));

                }

            }

            dr.Close();
            dr.Dispose();

        }


        public void RetornoPesquisaAgente()
        {
            if (Parametros.Valor != "")
            {
                BuscaAgente(int.Parse(Parametros.Valor));
            }
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Trim() != "")
            {
                BuscaAgente(int.Parse(txtcodigo.Text));
            }
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void LimpaTela()
        {
           
            txtNome.Text = "";
           
            txtendereco.Text = "";
            txtbairro.Text = "";
            txtfone.Text = "";
            txtcell.Text = "";
            Parametros.Form = "Agente";
            txtcodigo.Focus();
            txtcodigo.Text = "0";

        }


        private void Gravar(bool novo, int codigo)
        {

            var hoje = DateTime.Now;

            var codAgente = txtcodigo.Text.Trim();
            var nome = txtNome.Text.Trim();
           
            var endereco = txtendereco.Text.Trim();
            var bairro = txtbairro.Text.Trim();
            var telefone = txtfone.Text.Trim();
            var cell = txtcell.Text.Trim();

            var respinclusao = Usuario.Nomeusuario.ToString();
            var datainclusao = hoje.ToString();
            var respalteracao = Usuario.Nomeusuario.ToString();
            var dataalteracao = hoje.ToString();
            var excluido = "N";
            int numero = 0;


            try
            {
                var m = new Classes.Mysql.Agente(int.Parse(codAgente), nome, endereco, bairro, telefone, cell,
                    respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao, excluido);
                if (novo)
                {
                    numero = m.Insert();

                    if (Parametros.Form == "Processo")
                    {
                        Parametros.Valor = numero.ToString();
                        LimpaTela();
                        Close();

                    }

                }
                else
                {
                    m.Update();

                    if (Parametros.Form == "Processo")
                    {
                        Parametros.Valor = codAgente;
                        LimpaTela();
                        Close();

                    }
                }


                MessageBox.Show("Registro Gravado com Sucesso !");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Persistência");
            }

            LimpaTela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Trim() == "0")
            {

                Gravar(true, 0);

            }
            else
            {

                Gravar(false, int.Parse(txtcodigo.Text.Trim()));

            }
        }

        private void Relatorio(int codigo)
        {
            // ESVAZIA O REPOSITORIO
            var d = new Classes.Mysql.Agente();
            d.DeleteAccess();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Agente.BuscaUm(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    var hoje = DateTime.Now;
                    var codAgente = txtcodigo.Text.Trim();
                    var nome = txtNome.Text.Trim();
                    
                    var endereco = txtendereco.Text.Trim();
                    var bairro = txtbairro.Text.Trim();
                    var telefone = txtfone.Text.Trim();
                    var cell = txtcell.Text.Trim();

                    var respinclusao = Usuario.Nomeusuario.ToString();
                    var datainclusao = hoje.ToString();
                    var respalteracao = Usuario.Nomeusuario.ToString();
                    var dataalteracao = hoje.ToString();
                    var excluido = "N";

                    try
                    {
                        var m = new Classes.Mysql.Agente(int.Parse(codAgente), nome, endereco, bairro, telefone, cell,
                    respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao, excluido);

                        m.InsertAccess();
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
                if (form is RelAgente)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelAgente();
                tela.ShowDialog();
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            if (txtcodigo.Text.Trim() != "")
            {
                Relatorio(int.Parse(txtcodigo.Text.Trim()));

            }
            else
            {
                MessageBox.Show("Sem Agente Selecionado");
                txtcodigo.Focus();

            }

        }

        private void Agente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {

                if (ActiveControl.Name == "txtcodigo") { btnProcuraAgente.PerformClick(); return; }
               

            }

        }

        private void btnProcuraAgente_Click(object sender, EventArgs e)
        {
            Parametros.Form = "Agente";
            Parametros.Valor = "";

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaAgente")
                {
                    if (form is PesquisaAgente)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {
                Form tela = new PesquisaAgente();
                tela.ShowDialog();
                RetornoPesquisaAgente();

            }
        }
    }
}
