using Atencao_Assistida.Classes.Mysql;
using Atencao_Assistida.Pesquisas;
using System;
using System.Windows.Forms;

namespace Atencao_Assistida.Forms
{
    public partial class AjusteEstoque : Form
    {
        public AjusteEstoque()
        {
            InitializeComponent();
        }

        private void AjusteEstoque_Load(object sender, EventArgs e)
        {
            CarregaCmbDepartamento();
            txtdtAjuste.Text = DateTime.Now.ToString("dd/MM/yyyy");

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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;

            this.txtdtAjuste.Text = date.ToString("dd/MM/yyyy");

        }

        private void btnBuscaProduto_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaRequisicao")
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
                RetornoPesquisaProdutos();

            }
        }

        public void RetornoPesquisaProdutos()
        {
            if (Parametros.Valor != "")
            {
                BuscaProduto(int.Parse(Parametros.Valor));
            }
        }

        private void BuscaProduto(int codigo)
        {
            var dr = Produto.Select(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtCodProduto.Text = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    txtNomeProduto.Text = dr.GetString(dr.GetOrdinal("NOME"));

                    if (!dr.IsDBNull(dr.GetOrdinal("NOME")))
                    {
                        txtNomeProduto.Text = dr.GetString(dr.GetOrdinal("NOME"));
                    }
                    else
                    {
                        txtNomeProduto.Text = dr.GetString(dr.GetOrdinal("DESCRICAO"));
                    }

                    txtQuantidade.Focus();
                }
            }

            dr.Close();
            dr.Dispose();
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            if (txtCodProduto.Text != "")
            {
                BuscaProduto(int.Parse(txtCodProduto.Text));
            }
            else { btnGravar.Focus(); }
        }

        private void AjusteEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void AjusteEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                if (ActiveControl.Name == "txtCodProduto") { btnBuscaProduto.PerformClick(); return; }

            }
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void LimpaTela()
        {
            CarregaCmbDepartamento();

            txtdtAjuste.Text = "";
            txtCodProduto.Text = "";
            txtNomeProduto.Text = "";
            txtQuantidade.Text = "";
            txtMotivo.Text = "";

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            txtdtAjuste.Text = DateTime.Now.ToString("dd/MM/yyyy");

            cmbDepartamento.Focus();

        }

    }
}
