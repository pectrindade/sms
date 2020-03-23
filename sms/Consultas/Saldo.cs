using Atencao_Assistida.Classes.Mysql;
using Atencao_Assistida.Pesquisas;
using Atencao_Assistida.Relatorios.Estoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Consultas
{
    public partial class Saldo : Form
    {
        public Saldo()
        {
            InitializeComponent();
        }

        private void Saldo_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            this.txtDataEstoque.Text = date.ToString("dd/MM/yyyy");

            CarregaCmbEmpresa();
            CarregaCmbDepartamento();
            CarregaCmbGrupo();

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

            var dr = Departamento.SelectTudo();

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

            var dr = Grupo.SelectTudo();

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

        private void CarregaGrid()
        {
            DateTime data = Convert.ToDateTime(txtDataEstoque.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);

            var vcodgrupo = 0;
            vcodgrupo = cmbGrupo.SelectedIndex;

            if (vcodgrupo == -1) { vcodgrupo = 0; }

            var cod = "0";
            if (txtcodigo.Text != "")
            {
                cod = txtcodigo.Text.Trim();

            }

            var valor = txtNome.Text.Trim();

            Grid.Columns["qtanterior"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns["entrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns["saida"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns["qtatual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[8];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();
            var linha = 0;

            var dr = Classes.Mysql.Estoque.BuscaEstoqueNome(cmbEmpresa.SelectedIndex, cmbDepartamento.SelectedIndex, vmes, vano, valor, vcodgrupo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    var vTotal = "";
                    var prevSaida = "";
                    var qtatual = "";
                    var result = decimal.Parse("1") / decimal.Parse("1");

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NOMEPRODUTO"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("QTANTERIOR"));
                    linhaDados[3] = dr.GetString(dr.GetOrdinal("ENTRADA"));
                    linhaDados[4] = dr.GetString(dr.GetOrdinal("SAIDA"));
                    linhaDados[5] = dr.GetString(dr.GetOrdinal("QTATUAL"));
                    linhaDados[6] = ""; ;
                    linhaDados[7] = "";

                    if (!dr.IsDBNull(dr.GetOrdinal("SAIDAPADRAO")))
                    {
                        if (dr.GetString(dr.GetOrdinal("SAIDAPADRAO")) != "0")
                        {
                            prevSaida = dr.GetString(dr.GetOrdinal("SAIDAPADRAO"));
                            qtatual = dr.GetString(dr.GetOrdinal("QTATUAL"));
                            result = decimal.Parse(qtatual) / decimal.Parse(prevSaida);

                            linhaDados[6] = dr.GetString(dr.GetOrdinal("SAIDAPADRAO"));

                            var somatorio = "";
                            somatorio = String.Format("{0:0.0}", result);

                            linhaDados[7] = somatorio;

                        }
                    }
                   

                    Grid.Rows.Add(linhaDados);

                    if (prevSaida != "")
                    {
                        var somatorio = "";
                        somatorio = String.Format("{0:N}", result);

                        result = decimal.Parse(somatorio);
                       
                        somatorio = String.Format("{0:0.0}", result);

                        float comparaAmarelo = float.Parse("2,5");

                        float comparaVermelho = float.Parse("1,5");

                        if (float.Parse(result.ToString()) <= comparaAmarelo)
                        {
                            PintaAmarelo(linha, 6);
                        }

                        if (float.Parse(result.ToString()) <= comparaVermelho)
                        {
                            PintaVermelho(linha, 6);
                        }
                    }

                    linha++;
                }

            }

            dr.Close();
            dr.Dispose();

        }



        private void Relatorio()
        {
            var cria = new Classes.Funcoes.CriaArquivo();
            cria.Cria_Estoque();

            DateTime data = Convert.ToDateTime(txtDataEstoque.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);

            var vcodgrupo = 0;
            vcodgrupo = cmbGrupo.SelectedIndex;

            if (vcodgrupo == -1) { vcodgrupo = 0; }

            var cod = "0";
            if (txtcodigo.Text != "")
            {
                cod = txtcodigo.Text.Trim();

            }

            int progresso1 = 0;
            progressBar1.Value = 0;
            progressBar1.Visible = true;

            var dr = Classes.Mysql.Estoque.BuscaEstoque(cmbEmpresa.SelectedIndex, cmbDepartamento.SelectedIndex, vmes, vano, int.Parse(cod), vcodgrupo);
            var drcont = Classes.Mysql.Estoque.BuscaEstoque(cmbEmpresa.SelectedIndex, cmbDepartamento.SelectedIndex, vmes, vano, int.Parse(cod), vcodgrupo);



            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(drcont);
                int numRows = dt.Rows.Count;
                progressBar1.Maximum = numRows;

                while (dr.Read())
                {


                    var codempresa = dr.GetInt32(dr.GetOrdinal("CODEMPRESA"));
                    var coddepartamento = dr.GetInt32(dr.GetOrdinal("CODDEPARTAMENTO"));
                    var nomedepartamento = dr.GetString(dr.GetOrdinal("NOMEDEPARTAMENTO"));
                    var varmes = dr.GetInt32(dr.GetOrdinal("MES"));
                    var varano = dr.GetString(dr.GetOrdinal("ANO"));

                    var codproduto = dr.GetInt32(dr.GetOrdinal("CODPRODUTO"));
                    var nomeproduto = dr.GetString(dr.GetOrdinal("NOMEPRODUTO"));

                    var qtanterior = dr.GetString(dr.GetOrdinal("QTANTERIOR"));
                    var entrada = dr.GetString(dr.GetOrdinal("ENTRADA"));
                    var saida = dr.GetString(dr.GetOrdinal("SAIDA"));
                    var qtatual = dr.GetString(dr.GetOrdinal("QTATUAL"));

                    var usuario = Usuario.Nomeusuario;
                    var funcao = Usuario.Funcao;



                    try
                    {
                        var m = new Classes.Mysql.Estoque();

                        m.InsertAccess(codempresa, coddepartamento, nomedepartamento, varmes.ToString(), varano, codproduto, nomeproduto, qtanterior, entrada, saida, qtatual);
                    }
                    catch (Exception erro)
                    {

                    }

                    progresso1 = progresso1 + 1;
                    progressBar1.Value = progresso1;

                }

            }

            dr.Close();
            dr.Dispose();
            progressBar1.Visible = false;

            MessageBox.Show("Relatório Pronto !");

            //CHAMA A TELA DE RELATORIO
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is RelEstoque)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelEstoque();
                tela.ShowDialog();
            }

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;

            this.txtDataEstoque.Text = date.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void BuscaProduto(string cod)
        {

            DateTime data = Convert.ToDateTime(txtDataEstoque.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);

            if (txtcodigo.Text != "")
            {
                cod = txtcodigo.Text.Trim();

            }
            //define um array de strings com nCOlunas
            string[] linhaDados = new string[6];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.Estoque.BuscaEstoque(cmbEmpresa.SelectedIndex, cmbDepartamento.SelectedIndex, vmes, vano, int.Parse(cod));

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtcodigo.Text = dr.GetInt32(dr.GetOrdinal("CODPRODUTO")).ToString();
                    txtNome.Text = dr.GetString(dr.GetOrdinal("NOMEPRODUTO"));
                }
            }
            dr.Dispose();
            dr.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Relatorio();
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {

            if (txtcodigo.Text.Trim() == "")
            {
                txtNome.Text = "";

                //LIMPAR GRID
                Grid.Rows.Clear();
                Grid.Refresh();
                return;
            }

            if (cmbEmpresa.Text.Trim() == "") { MessageBox.Show("Favor informar a Empresa !"); return; }
            if (cmbDepartamento.Text.Trim() == "") { MessageBox.Show("Favor informar o Departamento !"); return; }
            if (cmbEmpresa.Text.Trim() == "--SELECIONE--") { MessageBox.Show("Favor informar a Empresa !"); return; }
            if (cmbDepartamento.Text.Trim() == "--SELECIONE--") { MessageBox.Show("Favor informar o Departamento !"); return; }



            if (txtcodigo.Text.Trim() != "")
            {
                BuscaProduto(txtcodigo.Text);
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (cmbEmpresa.Text.Trim() == "") { cmbEmpresa.Focus(); return; }
            if (cmbDepartamento.Text.Trim() == "") { cmbDepartamento.Focus(); return; }
            if (cmbEmpresa.Text.Trim() == "--SELECIONE--") { cmbEmpresa.Focus(); return; }
            if (cmbDepartamento.Text.Trim() == "--SELECIONE--") { cmbDepartamento.Focus(); return; }

        }

        private void LimpaTela()
        {
            DateTime date = DateTime.Now;
            this.txtDataEstoque.Text = date.ToString("dd/MM/yyyy");

            CarregaCmbEmpresa();
            CarregaCmbDepartamento();
            CarregaCmbGrupo();
            txtcodigo.Text = "";
            txtNome.Text = "";

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            cmbEmpresa.Focus();

        }

        private void BtnDesfaz_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnBuscaProduto_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtNome.Text = "";

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
                BuscaProduto(Parametros.Valor);
            }
        }

        private void Saldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Saldo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                if (ActiveControl.Name == "txtcodigo") { btnBuscaProduto.PerformClick(); return; }
            }
        }


        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            Parametros.Codigo = "";
            Parametros.Nome = "";

            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                Parametros.Codigo = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                Parametros.Nome = Grid.Rows[RowsIndex].Cells[1].Value.ToString();

            }
            catch
            {
                return;
            }


            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "Detalhe_saida")
                {
                    if (form is Detalhe_saida)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {

                Form tela = new Detalhe_saida();

                tela.ShowDialog();
                //RetornoPesquisaProdutos();

            }

            Parametros.Codigo = "";
            Parametros.Nome = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PintaVermelho(3, 2);
        }

        private void PintaVermelho(int linha, int coluna)
        {
            Grid.Rows[linha].Cells[coluna].Style.BackColor = Color.Red;
        }

        private void PintaAmarelo(int linha, int coluna)
        {
            Grid.Rows[linha].Cells[coluna].Style.BackColor = Color.Yellow;
        }
    }
}

