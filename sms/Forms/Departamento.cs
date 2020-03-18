using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Atencao_Assistida.Forms
{
    public partial class Departamento : Form
    {
        public Departamento()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Departamento_Load(object sender, EventArgs e)
        {
            BuscaDepartamento();


        }

        private void BuscaDepartamento()
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[5];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.Departamento.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODDEPARTAMENTO"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NOME"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("TELEFONE"));
                    linhaDados[3] = dr.GetString(dr.GetOrdinal("EMAIL"));
                    //linhaDados[4] = dr.GetString(dr.GetOrdinal("ATIVO"));

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void Grid_Departamento_DoubleClick(object sender, EventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                txtCodigo.Text = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                txtDescricao.Text = Grid.Rows[RowsIndex].Cells[1].Value.ToString();
                txttelefone.Text = Grid.Rows[RowsIndex].Cells[2].Value.ToString();
                txtemail.Text = Grid.Rows[RowsIndex].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDesfaz_Click(object sender, EventArgs e)
        {
            Limpatela();
        }

        private void Limpatela()
        {
            txtCodigo.Text = "0";
            txtDescricao.Text = "";
            txttelefone.Text = "";
            txtemail.Text = "";

            BuscaDepartamento();
            txtDescricao.Focus();

        }

        private void Gravar(bool novo, int codigo)
        {
            if (txtDescricao.Text.Trim() == "") { MessageBox.Show("Nome é campo Obrigatório"); txtDescricao.Focus(); return; }

            var hoje = DateTime.Now;
            var descricao = txtDescricao.Text.Trim();
            var ativo = "S";// cmbativo.SelectedValue.ToString();
            var telefone = txttelefone.Text;
            var email = txtemail.Text;

            var respinclusao = Usuario.Nomeusuario.ToString();
            var datainclusao = hoje.ToString();
            var respalteracao = Usuario.Nomeusuario.ToString();
            var dataalteracao = hoje.ToString();
            var excluido = "N";

            try
            {
                var m = new Classes.Mysql.Departamento(codigo, descricao, telefone, email, ativo,
                     respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao, excluido);
                if (novo)
                    m.Insert();
                else
                    m.Update();

                MessageBox.Show("Registro Gravado com Sucesso !");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Persistência");
            }

            Limpatela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "0")
            {

                Gravar(true, 0);

            }
            else
            {

                Gravar(false, int.Parse(txtCodigo.Text.Trim()));

            }
        }

        private void Relatorio()
        {

            var cria = new Classes.Funcoes.CriaArquivo();
            cria.Cria_Departamento();

            
            var hoje = DateTime.Now;
            var respinclusao = Usuario.Nomeusuario.ToString();
            var datainclusao = hoje.ToString();
            var respalteracao = Usuario.Nomeusuario.ToString();
            var dataalteracao = hoje.ToString();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Departamento.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    var cod = dr.GetString(dr.GetOrdinal("CODDEPARTAMENTO"));
                    var nome = dr.GetString(dr.GetOrdinal("NOME"));
                    var fone = dr.GetString(dr.GetOrdinal("TELEFONE"));
                    var email = dr.GetString(dr.GetOrdinal("EMAIL"));

                    try
                    {
                        var m = new Classes.Mysql.Departamento();

                        m.InsertAccess(int.Parse(cod), nome, fone, email, respinclusao, datainclusao, respalteracao, dataalteracao);
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
                if (form is Relatorios.Departamento.RelDepartamento)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Relatorios.Departamento.RelDepartamento();
                tela.ShowDialog();
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Relatorio();
        }

        

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var m = new Classes.Funcoes.CriaArquivo();

            m.Cria_Departamento();


        }


    }
}
