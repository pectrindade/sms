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

        private void txtdtAjuste_Leave(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            DateTime data = Convert.ToDateTime(txtdtAjuste.Text.Trim());
            var dia = data.ToString("dd/MM/yyyy");


            Grid.Columns["QUANTIDADE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[4];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Ajuste.SelectAjuste(int.Parse(Usuario.Codempresa), cmbDepartamento.SelectedIndex, dia);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NOMEPRODUTO"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("QUANTIDADE"));
                    linhaDados[3] = dr.GetString(dr.GetOrdinal("MOTIVO"));

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void btnAddGrid_Click(object sender, EventArgs e)
        {
            if (txtQuantidade.Text.Trim() != "")              
            {
                int NumLetras = txtMotivo.Text.Trim().Length;
                if (NumLetras < 38) { MessageBox.Show("Quantidade caracteres insuficientes na descrição de Motivo "); txtMotivo.Focus(); return; }

                GridAdd();

                txtCodProduto.Focus();

            }
        }

        private void GridAdd()
        {
            Grid.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[6];

            linhaDados[0] = txtCodProduto.Text.Trim();
            linhaDados[1] = txtNomeProduto.Text.Trim();
            linhaDados[2] = txtQuantidade.Text.Trim();
            linhaDados[3] = txtMotivo.Text.Trim();

            Grid.Rows.Add(linhaDados);

            txtCodProduto.Text = "";
            txtNomeProduto.Text = "";
            txtQuantidade.Text = "";
            txtMotivo.Text = "";

            txtCodProduto.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtdtAjuste.Text.Trim() != "")
            {
               

                Gravar();
            }
        }

        private void Gravar()
        {
            var hoje = DateTime.Now;
            var codempresa = Usuario.Codempresa.ToString();
            var dataajuste = txtdtAjuste.Text.Trim();
            var coddepartamento = Usuario.Coddepartamento.ToString();
            var respinclusao = Usuario.Nomeusuario.ToString();
            var datainclusao = hoje.ToString();

            try
            {

                int total = Grid.Rows.Count;
                int i;
                var Produto = "";
                var nome = "";
                var qt = "";
                var motivo = "";

                DialogResult result = MessageBox.Show("Deseja Realmente Ajustar o Estoque Desses Itens ?", "Atenção !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var Linhas = Grid.Rows.Count;

                    foreach (DataGridViewRow linha1 in Grid.Rows)
                    {
                        Produto = linha1.Cells[0].Value.ToString();
                        nome = linha1.Cells[1].Value.ToString();
                        qt = linha1.Cells[2].Value.ToString();
                        motivo = linha1.Cells[3].Value.ToString();

                        int NumLetras = motivo.Trim().Length;
                        if (NumLetras < 38) { MessageBox.Show("Quantidade caracteres insuficientes na descrição de Motivo "); txtMotivo.Focus(); return; }

                        //var item = new Ajuste(int.Parse(codempresa), int.Parse(coddepartamento), dataajuste, int.Parse(Produto), int.Parse(qt), motivo, respinclusao.ToString(), datainclusao);

                        //item.Insert();

                        var dr_i = Ajuste.SelectAjuste(int.Parse(codempresa), int.Parse(coddepartamento), dataajuste, int.Parse(Produto));
                        if (dr_i.HasRows)
                        {
                            item.Update();
                        }
                        else
                        {
                            item.Insert();
                        }

                        dr_i.Dispose();
                        dr_i.Close();

                    }

                }
                //MessageBox.Show("Registro Gravado com Sucesso !");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Persistência");
            }

            LimpaTela();

        }

    }
}
