using Atencao_Assistida.Classes.Mysql;
using Atencao_Assistida.Pesquisas;
using System;
using System.Text.RegularExpressions;
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

            txtdtAjuste.Focus();


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
            txtdtAjuste.Text = "";

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            dateTimePicker1.Value = DateTime.Now;

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
                if (NumLetras < 27) { MessageBox.Show("Quantidade caracteres insuficientes na descrição de Motivo "); txtMotivo.Focus(); return; }

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
                var qt = "0";
                var motivo = "";
                var qtestava = "0";
                var qtajustada = "0";
                var acao = "";

                DialogResult result = MessageBox.Show("Deseja Realmente Ajustar o Estoque Desses Itens ?", "Atenção !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var Linhas = Grid.Rows.Count;

                    foreach (DataGridViewRow linha1 in Grid.Rows)
                    {
                        Produto = linha1.Cells[0].Value.ToString();
                        nome = linha1.Cells[1].Value.ToString();
                        qt = linha1.Cells[2].Value.ToString();
                        qtajustada = qt;
                        motivo = linha1.Cells[3].Value.ToString();

                        int NumLetras = motivo.Trim().Length;
                        if (NumLetras < 27) { MessageBox.Show("Quantidade caracteres insuficientes na descrição de Motivo "); txtMotivo.Focus(); return; }

                        var item = new Ajuste(int.Parse(codempresa), int.Parse(coddepartamento), dataajuste, int.Parse(Produto), int.Parse(qt), motivo, respinclusao.ToString(), datainclusao);

                        var dr_i = Ajuste.SelectAjuste(int.Parse(codempresa), int.Parse(coddepartamento), dataajuste, int.Parse(Produto));
                        if (dr_i.HasRows)
                        {
                            while (dr_i.Read())
                            {
                                qtestava = dr_i.GetString(dr_i.GetOrdinal("QUANTIDADE"));
                                var autorizado = dr_i.GetString(dr_i.GetOrdinal("AUTORIZADO"));

                                if (autorizado == "S")
                                {
                                    acao = "ALTERAÇÃO";
                                }
                                else
                                {
                                    acao = "INCLUSÃO";
                                }
                                
                                if (int.Parse(qtestava) != int.Parse(qtajustada))
                                {
                                    var Log = new Ajuste_Log(int.Parse(codempresa), dataajuste, int.Parse(Produto), int.Parse(coddepartamento), qtestava, qtajustada, motivo, acao, respinclusao, datainclusao);
                                    Log.Insert();
                                }
                                item.Update();
                            }
                        }
                        else
                        {
                            acao = "INCLUSÃO";
                            var Log = new Ajuste_Log(int.Parse(codempresa), dataajuste, int.Parse(Produto), int.Parse(coddepartamento), qtestava, qtajustada, motivo, acao, respinclusao, datainclusao);
                           
                            Log.Insert();
                            item.Insert();
                        }

                        dr_i.Dispose();
                        dr_i.Close();

                        FechaEstoque(Produto);

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

        private void Grid_DoubleClick(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Deseja alterar este item ?", "Atenção !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var RowsIndex = Grid.CurrentRow.Index;

                try
                {
                    txtCodProduto.Text = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                    txtNomeProduto.Text = Grid.Rows[RowsIndex].Cells[1].Value.ToString();
                    txtQuantidade.Text = Grid.Rows[RowsIndex].Cells[2].Value.ToString();
                    txtMotivo.Text = Grid.Rows[RowsIndex].Cells[3].Value.ToString();

                }
                catch
                {

                }


                if (Grid.CurrentRow == null) return;
                Grid.Rows.RemoveAt(Grid.CurrentRow.Index);
            }
            else if (result == DialogResult.No)
            {
                //code for No

                txtCodProduto.Focus();

            }

        }



        public void FechaEstoque( string codproduto)
        {
            var codempresa = Usuario.Codempresa.ToString();
            var coddepartamento = cmbDepartamento.SelectedIndex.ToString();
            var grupo = "";

           

            DateTime data = Convert.ToDateTime(txtdtAjuste.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);


            //PRIMEIRO PEGA O PRIMEIRO E O ULTIMO DIA DO MES 
            //DateTime com o primeiro dia do mês
            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);
            var dtinicial = primeiroDiaDoMes.ToString("dd/MM/yyyy");

            //DateTime com o último dia do mês
            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
            var dtfinal = ultimoDiaDoMes.ToString("dd/MM/yyyy");
            var UltimoDia = ultimoDiaDoMes.ToString("dd");

            var Est = new Estoque();

            var retorno = Est.DeleteMesAno(int.Parse(codempresa), int.Parse(coddepartamento), mes, ano, codproduto, grupo);

            //SEGUNDO PEGA OS PRODUTOS
            var dr = Produto.Select(codproduto, int.Parse(coddepartamento), grupo);

            var cont = new Produto();
            var Cont = cont.SelectCount();

           

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    SaldoAnterior(int.Parse(codempresa), int.Parse(dr.GetString(dr.GetOrdinal("CODPRODUTO"))));

                    var cod = int.Parse(dr.GetString(dr.GetOrdinal("CODPRODUTO")));

                    DateTime totalDeDias = primeiroDiaDoMes;
                    for (int i = 0; i < int.Parse(UltimoDia); i++)
                    {
                        EntradaProduto(int.Parse(codempresa), int.Parse(coddepartamento), totalDeDias.ToString("dd/MM/yyyy"), int.Parse(dr.GetString(dr.GetOrdinal("CODPRODUTO"))));

                        SaidaProduto(int.Parse(codempresa), int.Parse(coddepartamento), totalDeDias.ToString("dd/MM/yyyy"), int.Parse(dr.GetString(dr.GetOrdinal("CODPRODUTO"))));

                        var Adiciona = totalDeDias.AddDays(1).ToString("dd/MM/yyyy");
                        totalDeDias = Convert.ToDateTime(Adiciona);

                       
                    }

                    SaldoAtual(int.Parse(codempresa), int.Parse(dr.GetString(dr.GetOrdinal("CODPRODUTO"))));
                   
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void SaldoAnterior(int codempresa, int codproduto)
        {

            DateTime data = Convert.ToDateTime(txtdtAjuste.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);
            var coddepartamento = Usuario.Coddepartamento.ToString();

            var Est = new Estoque();

            #region Quantidade Mes Anterior

            var mesanterior = Est.BuscaMesAnterior(mes, ano);
            vmes = mesanterior.Substring(0, 2);
            vano = mesanterior.Substring(2, 4);

            #region Verrificação de Balanco

            //DateTime com o primeiro dia do mês
            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);
            var dtinicial = primeiroDiaDoMes.ToString("dd/MM/yyyy");

            //DateTime com o último dia do mês
            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
            var dtfinal = ultimoDiaDoMes.ToString("dd/MM/yyyy");

            var temBalanco = Est.TemBalanco(codempresa, int.Parse(coddepartamento), dtinicial, dtfinal, codproduto);
            var QtAnterior = "0";

            #endregion
            if (temBalanco == true)
            {
                QtAnterior = "0";
            }
            else
            {
                //-> Buscando a quantidade do mes anterior 
                QtAnterior = Est.Anterior(codempresa, int.Parse(coddepartamento), int.Parse(vmes), int.Parse(vano), codproduto).ToString();
            }
           
            // id, codempresa, mes, ano,codproduto, qtanterior, entrada, saida , qtatual 
            var m = new Estoque(0, codempresa, int.Parse(coddepartamento), mes, ano, codproduto, QtAnterior.ToString(), "0", "0", "0");

            m.GravaAnterior();

            #endregion;

        }

        private void EntradaProduto(int codempresa, int coddepartamento, string dia, int codproduto)
        {

            DateTime data = Convert.ToDateTime(txtdtAjuste.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);


            var ent = new Estoque(codempresa, coddepartamento, mes, ano, codproduto);

            ent.Fecha_Entradas(codempresa, coddepartamento, dia, codproduto);


        }

        private void SaidaProduto(int codempresa, int coddepartamento, string dia, int codproduto)
        {
            DateTime data = Convert.ToDateTime(txtdtAjuste.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);


            var ent = new Estoque(codempresa, coddepartamento, mes, ano, codproduto);

            ent.Fecha_Saida(codempresa, coddepartamento, dia, codproduto);

        }

        private void SaldoAtual(int codempresa, int codproduto)
        {
            DateTime data = Convert.ToDateTime(txtdtAjuste.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);
            var coddepartamento = Usuario.Coddepartamento.ToString();

            #region Quantidade Atual

            var atual = new Estoque(0, codempresa, int.Parse(coddepartamento), mes, ano, codproduto, "0", "0", "0", "0");

            atual.AtualizaQtAtual();

            #endregion

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "AutorizaAjuste")
                {
                    if (form is AutorizaAjuste)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {
                Parametros.Valor = "";
                Parametros.Nome = "";

                Form tela = new AutorizaAjuste();
                tela.ShowDialog();
                Retorno();
            }


        }

        public void Retorno()
        {
            var nomeautoriza = Parametros.Nome.ToString();
            var senha = "";
            var autorizado = "N";
            var codempresa = Usuario.Codempresa;
            var coddepartamento = Usuario.Coddepartamento;
            var dataajuste = txtdtAjuste.Text;
            var dataautoriza = DateTime.Now.ToString();

            autorizado = Parametros.Valor.ToString();


            if (autorizado == "S")
            {
                var aj = new Ajuste();
                aj.AutorizaAjuste(int.Parse(codempresa), int.Parse(coddepartamento), dataajuste, autorizado, nomeautoriza, dataautoriza);

                Gravar();
            }

        }

        

    }
}
