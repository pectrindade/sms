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
    public partial class Cfop : Form
    {
        public Cfop()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cfop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Cfop_Load(object sender, EventArgs e)
        {
            BuscaCfop();


        }

        private void BuscaCfop()
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[3];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.Cfop.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODCFOP"));

                    if (!dr.IsDBNull(dr.GetOrdinal("DESCRICAO")))
                    {
                        linhaDados[1] = dr.GetString(dr.GetOrdinal("DESCRICAO"));
                    }
                    else
                    {
                        linhaDados[1] = "";
                    }

                    if (!dr.IsDBNull(dr.GetOrdinal("APLICACAO")))
                    {
                        linhaDados[2] = dr.GetString(dr.GetOrdinal("APLICACAO"));
                    }
                    else
                    {
                        linhaDados[2] = "";
                    }

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                txtCodigo.Text = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                txtDescricao.Text = Grid.Rows[RowsIndex].Cells[1].Value.ToString();
                txtAplicacao.Text = Grid.Rows[RowsIndex].Cells[2].Value.ToString();
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
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            txtAplicacao.Text = "";

            BuscaCfop();
            txtCodigo.Focus();

        }
      
        private void Gravar(bool novo, int codigo)
        {
            //var codempresa = codigo;
            //var nome = txtDescricao.Text.Trim();
            //var endereco = ""; // txtEndereco.Text.Trim();
            //var bairro = ""; // txtBairro.Text.Trim();
            //var codestado = 1;
            //var codcidade = ""; // ddlCidade.SelectedValue;
            //var telefone = ""; // txtTelefone.Text.Trim();
            //var caminhologo = ""; // "a";
            //var obs = ""; // "a";
            //var ativa = "S";
            //var email = ""; // "";
            //var hoje = DateTime.Now;
            //var respinclusao = ""; // Session["nome"];
            //var datahorainclusao = hoje.ToString();
            //var respalteracao = ""; // Session["nome"];
            //var datahoraalteracao = hoje.ToString();
            //var excluido = "N";


            //var m = new Classes.Mysql.Empresa(codempresa, nome, endereco, bairro, codestado, int.Parse(codcidade), telefone, caminhologo, obs, ativa, email, respinclusao.ToString(), datahorainclusao, respalteracao.ToString(), datahoraalteracao, excluido);
            //if (novo)
            //    m.Insert();
            //else
            //    m.Update();


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
            //// ESVAZIA O REPOSITORIO
            //var d = new Classes.Mysql.Empresa();
            ////d.DeleteAccess();

            //// BUSCA E GRAVA NO REPOSITORIO
            //var dr = Classes.Mysql.Empresa.SelectTudo();

            //if (dr.HasRows)
            //{
            //    while (dr.Read())
            //    {
            //        var cod = dr.GetString(dr.GetOrdinal("CODCfop"));
            //        var nome = dr.GetString(dr.GetOrdinal("DESCRICAO"));

            //        try
            //        {
            //            var m = new Classes.Mysql.Empresa(int.Parse(cod), nome);

            //            m.InsertAccess();
            //        }
            //        catch (Exception erro)
            //        {

            //        }

            //    }

            //}

            //dr.Close();
            //dr.Dispose();

            ////CHAMA A TELA DE RELATORIO
            //bool open = false;
            //foreach (Form form in this.MdiChildren)
            //{
            //    if (form is RelCfop)
            //    {
            //        form.BringToFront();
            //        open = true;
            //    }
            //}
            //if (!open)
            //{
            //    Form tela = new RelCfop();
            //    tela.ShowDialog();
            //}

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Relatorio();
        }

        private void btnBuscaCfop_Click(object sender, EventArgs e)
        {
            Parametros.Form = "";
            Parametros.Valor = "";

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaCfop")
                {
                    if (form is PesquisaCfop)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {

                Form tela = new PesquisaCfop();
                tela.ShowDialog();
                //RetornoPesquisaProtocolo();


            }
        }
    }
}
