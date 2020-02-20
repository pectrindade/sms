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

namespace Atencao_Assistida.Relatorios.Previsao_entrega
{
    public partial class Previsao_Entrega : Form
    {
        public Previsao_Entrega()
        {
            InitializeComponent();
        }

        private void Previsao_Entrega_Load(object sender, EventArgs e)
        {
            CarregaCmbEspecialidade();
        }

        private void Previsao_Entrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscaProduto_Click(object sender, EventArgs e)
        {
            Parametros.Form = "Previsao_Entrega";
            Parametros.Valor = "";

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "Previsao_Entrega")
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

        private void BuscaProduto(int codigo)
        {

            var dr = Classes.Mysql.Produto.Select(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtcodigo.Text = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    txtNome.Text = dr.GetString(dr.GetOrdinal("DESCRICAO"));

                }

            }

            dr.Close();
            dr.Dispose();

            txtNome.Focus();
        }

        private void CarregaCmbEspecialidade()
        {
            int codigo;
            string nome;


            cmbEspecialidade.Items.Clear();

            cmbEspecialidade.Items.Insert(0, "--SELECIONE--");

            var dr = Classes.Mysql.Especialidade.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    codigo = int.Parse(dr.GetString(dr.GetOrdinal("CODESPECIALIDADE")));
                    nome = dr.GetString(dr.GetOrdinal("DESCRICAO"));

                    cmbEspecialidade.Items.Insert(codigo, nome);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Relatorio();
        }

        private void Relatorio()
        {
           
            int count = 0;

            // ESVAZIA O REPOSITORIO
            var d = new Classes.Mysql.Produto();
            d.DeletePrevisao_Entrega();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Produto.SelectPrevisao_Entrega("","","");
            var dr1 = Classes.Mysql.Produto.SelectPrevisao_Entrega("", "", "");


            if (dr.HasRows)
            {

                while (dr1.Read())
                {
                    count ++;
                }

                progressBar.Maximum = count;
                progressBar.Value = 0;

                while (dr.Read())
                {

                    var hoje = DateTime.Now;

                    var codproduto = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    var descricao = dr.GetString(dr.GetOrdinal("DESCRICAO"));
                    var und = dr.GetString(dr.GetOrdinal("UND"));
                    var quantidade = dr.GetString(dr.GetOrdinal("QUANTIDADE"));

                    try
                    {
                        var m = new Classes.Mysql.Produto();

                        m.InsertPrevisao_Entrega(int.Parse(codproduto), descricao, und, int.Parse(quantidade));

                        progressBar.Value = progressBar.Value + 1;

                    }
                    catch (Exception erro)
                    {

                    }

                }

            }

            dr.Close();
            dr.Dispose();
            progressBar.Value = 0;

            //CHAMA A TELA DE RELATORIO
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is RelPrevisaoEntrega2)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelPrevisaoEntrega2();
                tela.ShowDialog();
            }

        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
