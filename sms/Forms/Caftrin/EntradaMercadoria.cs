using Atencao_Assistida.Classes.Mysql;
using Atencao_Assistida.ModelSerialization;
using Atencao_Assistida.Pesquisas;
using Atencao_Assistida.Relatorios.Entrada;
using Atencao_Assistida.Serializable;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Atencao_Assistida.Forms.Caftrin
{
    public partial class EntradaMercadoria : Form
    {
        public EntradaMercadoria()
        {
            InitializeComponent();
        }

        private void EntradaMercadoria_Load(object sender, EventArgs e)
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void EntradaMercadoria_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            LerXml();
            PainelMercadoria.Visible = false;
        }

        private void LerXml()
        {
            try
            {
                if (openFileXml.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtpathXml.Text = openFileXml.FileName;

                    NFeSerialization serializable = new NFeSerialization();
                    var nfe = serializable.GetObjectFromFile<NFeProc>(txtpathXml.Text);

                    if (nfe == null)
                    {
                        MessageBox.Show("Falha ao ler o arquivo xml. Verifique se o arquivo é de uma NF-e/NFC-e autorizada!", "Aviso - Leitura do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        popularForm(nfe);
                        MessageBox.Show("Arquivo xml da Nota Fiscal lido com Sucesso!", "Aviso - Leitura do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Falha no processo de leitura do arquivo xml da Nota Fiscal.", "Aviso - Leitura do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void popularForm(NFeProc nfe)
        {
            // Limpa o grid
            Grid.Rows.Clear();

            /* Populando tab Identificação */
            txtnometipooperacao.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.natOp;
            txtnumeronota.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF;
            //txtModelo.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.mod;
            txtserienota.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.serie.ToString();
            txtdtemissao.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString();

            /* Populando tab Emitente */
            txtnomefornecedor.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.xNome;
            //txtnomefornecedor.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.xFant;
            txtCpfCnpjEmitente.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.CNPJ;
            //txtInscricaoEstadual.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.IE;
            //txtLogradouroEmitente.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.xLgr;
            //txtNroEmitente.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.nro;
            //txtMunicipioEmitente.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.xMun;
            //txtUFEmitente.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.UF;

            /* Populando tab Destinatário */
            //txtDestNomeFantasia.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.xNome;
            //txtDestCpfCnpj.Text = string.IsNullOrEmpty(nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ) ? nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CPF : nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ;
            //txtDestEmail.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.email;
            //txtDestLogradouro.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.xLgr;
            //txtDestNumero.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.nro;
            //txtDestMunicipio.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.xMun;
            //txtDestUF.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.UF;
            //txtDestCEP.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.CEP;
            //txtDestBairro.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.xBairro;


            int num = nfe.NotaFiscalEletronica.InformacoesNFe.Detalhe.Count();
            string teste = "";

            for (int i = 0; i < num; i++)
            {

                //define um array de strings com nCOlunas
                string[] linhaDados = new string[6];

                linhaDados[0] = nfe.NotaFiscalEletronica.InformacoesNFe.Detalhe[i].Produtos.cProd;
                linhaDados[1] = nfe.NotaFiscalEletronica.InformacoesNFe.Detalhe[i].Produtos.xProd;
                linhaDados[2] = nfe.NotaFiscalEletronica.InformacoesNFe.Detalhe[i].Produtos.qCom.ToString();
                linhaDados[3] = nfe.NotaFiscalEletronica.InformacoesNFe.Detalhe[i].Produtos.vUnCom.ToString();
                linhaDados[4] = "";
                linhaDados[5] = "";


                Grid.Rows.Add(linhaDados);


            }

        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult result = MessageBox.Show("Deseja alterar este item da Entrada ?", "Atenção !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var RowsIndex = Grid.CurrentRow.Index;

                try
                {
                    txtcodigomercadoria.Text = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                    txtnomemercadoria.Text = Grid.Rows[RowsIndex].Cells[1].Value.ToString();
                    
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

                txtcodigomercadoria.Focus();

            }

            //if (Grid.CurrentRow == null) return;

            //if (Grid.CurrentRow.Cells[4].Value != "") return;

            //bool open = false;
            //foreach (Form form in Application.OpenForms)
            //{

            //    // Verifica se o form esta aberto
            //    if (form.Name == "PesquisaProdutos")
            //    {
            //        if (form is PesquisaProdutos)
            //        {
            //            form.BringToFront();
            //            open = true;
            //        }

            //    }
            //}

            //if (!open)
            //{
            //    Parametros.Valor = "";
            //    Parametros.Nome = "";

            //    Form tela = new PesquisaProdutos();
            //    tela.ShowDialog();

            //}

            //Grid.CurrentRow.Cells[4].Value = Grid.CurrentRow.Cells[0].Value;
            //Grid.CurrentRow.Cells[5].Value = Grid.CurrentRow.Cells[1].Value;

            //Grid.CurrentRow.Cells[0].Value = Parametros.Valor;
            //Grid.CurrentRow.Cells[1].Value = Parametros.Nome;
        }

        private void Grid_MouseDown(object sender, MouseEventArgs e)
        {

            if (Grid.CurrentRow.Cells[4].Value == "") return;

            // verifica se é com o botão equerdo
            if (e.Button == MouseButtons.Right)
            {
                Parametros.Valor = "";
                Parametros.Nome = "";

                if (Grid.CurrentRow == null) return;

                bool open = false;
                foreach (Form form in Application.OpenForms)
                {

                    // Verifica se o form esta aberto
                    if (form.Name == "PesquisaProdutos")
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
                    Parametros.Valor = "";
                    Parametros.Nome = "";

                    Form tela = new PesquisaProdutos();
                    tela.ShowDialog();

                }

                Grid.CurrentRow.Cells[0].Value = Parametros.Valor;
                Grid.CurrentRow.Cells[1].Value = Parametros.Nome;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaProdutos")
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
                Parametros.Valor = "";
                Parametros.Nome = "";

                Form tela = new PesquisaProdutos();
                tela.ShowDialog();
                RetornoPesquisaProdutos();
            }
        }

        private void btnBuscaNota_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaEntrada")
                {
                    if (form is PesquisaEntrada)
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

                Form tela = new PesquisaEntrada();
                tela.ShowDialog();
                RetornoPesquisaNota();
            }
        }

        public void RetornoPesquisaNota()
        {
            if (Parametros.Valor != "")
            {
                txtnumeronota.Text = Parametros.Valor;
                txtserienota.Text = Parametros.Nome;
                BuscaNota();
            }
        }

        private void btnProcuratipooperacao_Click(object sender, EventArgs e)
        {

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
                Parametros.Valor = "";
                Parametros.Nome = "";

                Form tela = new PesquisaCfop();
                tela.ShowDialog();
                RetornoPesquisaCfop();
            }
        }

        public void RetornoPesquisaCfop()
        {
            if (Parametros.Valor != "")
            {
                BuscaCfop("codigo", Parametros.Valor);
            }
        }

        private void BuscaCfop(string campo, string valor)
        {

            var dr = Classes.Mysql.Cfop.Select(campo, valor);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtcodigotipooperacao.Text = dr.GetString(dr.GetOrdinal("CODCFOP"));
                    txtnometipooperacao.Text = dr.GetString(dr.GetOrdinal("DESCRICAO"));
                }

            }
            else
            {
                btnSalvar.Focus();
            }

            dr.Close();
            dr.Dispose();

        }

        private void txtcodigotipooperacao_Leave(object sender, EventArgs e)
        {
            if (txtcodigotipooperacao.Text.Trim() != "")
                BuscaCfop("codigo", txtcodigotipooperacao.Text);
        }

        private void btnProcurafornecedor_Click(object sender, EventArgs e)
        {

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaFornecedor")
                {
                    if (form is PesquisaFornecedor)
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

                Form tela = new PesquisaFornecedor();
                tela.ShowDialog();
                RetornoPesquisaFornecedor();
            }
        }

        public void RetornoPesquisaFornecedor()
        {
            if (Parametros.Valor != "")
            {
                BuscaFornecedor("codigo", Parametros.Valor);
            }
        }

        private void BuscaFornecedor(string campo, string codigo)
        {
            var dr = Fornecedor.SelectLista(campo, codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtcodigofornecedor.Text = dr.GetString(dr.GetOrdinal("CODFORNECEDOR"));
                    txtnomefornecedor.Text = dr.GetString(dr.GetOrdinal("NOME"));

                    if (!dr.IsDBNull(dr.GetOrdinal("CNPJ")))
                    { txtCpfCnpjEmitente.Text = dr.GetString(dr.GetOrdinal("CNPJ")); }
                    else { txtCpfCnpjEmitente.Text = ""; }

                }
            }
            else
            {
                btnSalvar.Focus();
            }

            dr.Close();
            dr.Dispose();
        }

        private void txtcodigofornecedor_Leave(object sender, EventArgs e)
        {
            if (txtcodigofornecedor.Text.Trim() != "")
                BuscaFornecedor("codigo", txtcodigofornecedor.Text.Trim());
        }

        private void txtCpfCnpjEmitente_Leave(object sender, EventArgs e)
        {
            if (txtCpfCnpjEmitente.Text.Trim() != "")
                BuscaFornecedor("cnpj", txtCpfCnpjEmitente.Text.Trim());
        }

        private void btnProcuramercadoria_Click(object sender, EventArgs e)
        {

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaProdutos")
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
                Parametros.Valor = "";
                Parametros.Nome = "";

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

            var dr = Classes.Mysql.Produto.Select(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtcodigomercadoria.Text = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    txtnomemercadoria.Text = dr.GetString(dr.GetOrdinal("DESCRICAO"));
                }
            }
            else
            {
                btnSalvar.Focus();
            }

            dr.Close();
            dr.Dispose();

        }

        private void txtcodigomercadoria_Leave(object sender, EventArgs e)
        {
            if (txtcodigomercadoria.Text.Trim() != "")
                BuscaProduto(int.Parse(txtcodigomercadoria.Text));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;

            this.txtdtrecebimento.Text = date.ToString("dd/MM/yyyy");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtcodigotipooperacao.Text.Trim() == "") { MessageBox.Show("Favor Informar o Tipo de Opração !", "Aviso - Tipo de Opração", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (txtcodigofornecedor.Text.Trim() == "") { MessageBox.Show("Favor Informar o código do Fornecedor !", "Aviso - código do Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (txtnumeronota.Text.Trim() == "") { MessageBox.Show("Favor Informar o Numero da Nota !", "Aviso - Numero da Nota", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (txtserienota.Text.Trim() == "") { MessageBox.Show("Favor Informar a Série !", "Aviso - Série", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (txtdtrecebimento.Text == "  /  /") { MessageBox.Show("Favor Informar a data da Entrega !", "Aviso - Data da Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            var codigo = "";

            foreach (DataGridViewRow linha in Grid.Rows)
            {
                var cod = linha.Cells[0].Value.ToString().Trim();
                if (cod != "")
                {
                    codigo = linha.Cells[4].Value.ToString().Trim();

                    if (codigo == "") { MessageBox.Show("Favor Informar o código da Mercadoria !", "Aviso - Mercadoria", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                }
            }
            if (codigo == "") { MessageBox.Show("Sem Mercadoria !", "Aviso - Mercadoria", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            Gravar(true, int.Parse(txtnumeronota.Text.Trim()));
        }

        private void Gravar(bool novo, int codigo)
        {

            var hoje = DateTime.Now;

            var id = 0;
            var codempresa = Usuario.Codempresa.ToString();
            var coddepartamento = Usuario.Coddepartamento.ToString();
            var numeronota = txtnumeronota.Text.Trim();
            var serie = txtserienota.Text.Trim();
            var cfop = txtcodigotipooperacao.Text.Trim();
            var codfornecedor = txtcodigofornecedor.Text.Trim();
            var dataemissao = txtdtemissao.Text.Trim();
            var datarecebimento = txtdtrecebimento.Text.Trim();
            var tipoentrega = "0";

            var numero = 0;

            try
            {

                var dr = Entrada.BuscaNota(numeronota);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        id = dr.GetInt32(dr.GetOrdinal("CODENTRADA"));
                    }
                    var m = new Entrada(id, int.Parse(codempresa), int.Parse(coddepartamento), numeronota, serie, cfop, int.Parse(codfornecedor), dataemissao, datarecebimento, tipoentrega);
                    m.Update();
                    numero = id;

                }
                else
                {
                    var m = new Entrada(id, int.Parse(codempresa), int.Parse(coddepartamento), numeronota, serie, cfop, int.Parse(codfornecedor), dataemissao, datarecebimento, tipoentrega);
                    numero = m.Insert();
                    id = numero;

                }

                dr.Dispose();
                dr.Close();

                GravaItens(id.ToString());

                LimpaTela();
                MessageBox.Show("Registro Gravado com Sucesso !");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Persistência");
            }

        }

        private void GravaItens(string codentrada)
        {
            DateTime data = Convert.ToDateTime(txtdtrecebimento.Text);
            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);


            foreach (DataGridViewRow linha in Grid.Rows)
            {
                var Nota = txtnumeronota.Text.Trim();
                var Serie = txtserienota.Text.Trim();
                var fornecedor = txtcodigofornecedor.Text.Trim();

                var codinterno = linha.Cells[0].Value.ToString().Trim();
                var nomeinterno = linha.Cells[1].Value.ToString().Trim();
                var quantidade = linha.Cells[2].Value.ToString().Trim();
                var valor = "0";

                if (linha.Cells[3].Value != null)
                {
                    valor = linha.Cells[3].Value.ToString().Trim();
                }

                var codexterno = linha.Cells[4].Value.ToString().Trim();
                var nomeexterno = linha.Cells[5].Value.ToString().Trim();

                if (codinterno == "") { return; }

                var item = new Entrada_item(int.Parse(codentrada), Nota, Serie, int.Parse(codinterno), "", "", quantidade, mes, ano);


                var dr = Entrada_item.SelectItem(int.Parse(codentrada), Nota, Serie, int.Parse(codinterno));
                if (dr.HasRows)
                {
                    item.Update();
                }
                else
                {
                    item.Insert();

                }

                dr.Dispose();
                dr.Close();

                var item1 = new Entrada_item_vinculo(int.Parse(codinterno), int.Parse(fornecedor), codexterno, nomeexterno);

                dr = Entrada_item_vinculo.SelectItem(int.Parse(codinterno), int.Parse(fornecedor));
                if (dr.HasRows)
                {
                    item1.Update();
                }
                else
                {
                    item1.Insert();

                }

                dr.Dispose();
                dr.Close();

                var codempresa = Usuario.Codempresa.ToString();

                ControlaEstoque(int.Parse(codempresa), int.Parse(codinterno), quantidade, "0");


            }


        }


        private void ControlaEstoque(int codempresa, int codproduto, string QtEntrada, string QtSaida)
        {

            SaldoAnterior(codempresa, codproduto);

            SaldoAtual(codempresa, codproduto);

        }

        private void SaldoAnterior(int codempresa, int codproduto)
        {

            DateTime data = Convert.ToDateTime(txtdtrecebimento.Text.Trim());

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

            //-> Buscando a quantidade do mes anterior 
            var QtAnterior = Est.Anterior(codempresa, int.Parse(coddepartamento), int.Parse(vmes), int.Parse(vano), codproduto);

            // id, codempresa, mes, ano,codproduto, qtanterior, entrada, saida , qtatual 
            var m = new Estoque(0, codempresa, int.Parse(coddepartamento), mes, ano, codproduto, QtAnterior.ToString(), "0", "0", "0");

            m.GravaAnterior();

            #endregion;

        }
        private void EntradaProduto(int codempresa, int codproduto, string QtEntrada)
        {
            DateTime data = Convert.ToDateTime(txtdtrecebimento.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);
            var coddepartamento = Usuario.Coddepartamento.ToString();


            #region Entrada

            var ent = new Estoque(0, codempresa, int.Parse(coddepartamento), mes, ano, codproduto, "0", QtEntrada, "0", "0");

            ent.GravaEntradaUnica();

            #endregion
        }
        private void SaidaProduto(int codempresa, int codproduto, string QtSaida)
        {
            DateTime data = Convert.ToDateTime(txtdtrecebimento.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);
            var coddepartamento = Usuario.Coddepartamento.ToString();


            #region Saida

            var sai = new Estoque(0, codempresa, int.Parse(coddepartamento), mes, ano, codproduto, "0", "0", QtSaida, "0");

            sai.GravaSaidaUnica();


            #endregion

        }
        private void SaldoAtual(int codempresa, int codproduto)
        {
            DateTime data = Convert.ToDateTime(txtdtrecebimento.Text.Trim());

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



        private void EntradaMercadoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H)
            {
                if (ActiveControl.Name == "txtdtrecebimento") { txtdtrecebimento.Text = DateTime.Now.ToString("dd/MM/yyyy"); ; return; }

            }

            if (e.KeyCode == Keys.F8)
            {

                if (ActiveControl.Name == "txtnumeronota") { btnBuscaNota.PerformClick(); return; }

                if (ActiveControl.Name == "txtcodigotipooperacao") { btnProcuratipooperacao.PerformClick(); return; }
                if (ActiveControl.Name == "txtcodigofornecedor") { btnProcurafornecedor.PerformClick(); return; }
                if (ActiveControl.Name == "txtcodigomercadoria") { btnProcuramercadoria.PerformClick(); return; }



            }


        }

        private void txtvalor_Leave(object sender, EventArgs e)
        {

            if (txtcodigomercadoria.Text.Trim() != "")
            {

                string[] linhaDados = new string[6];

                linhaDados[0] = txtcodigomercadoria.Text;
                linhaDados[1] = txtnomemercadoria.Text;
                linhaDados[2] = txtquantidade.Text;
                linhaDados[3] = txtvalor.Text;
                linhaDados[4] = txtcodigomercadoria.Text;
                linhaDados[5] = txtnomemercadoria.Text;

                Grid.Rows.Add(linhaDados);

                txtcodigomercadoria.Text = "";
                txtnomemercadoria.Text = "";
                txtquantidade.Text = "";
                txtvalor.Text = "";
            }
            txtcodigomercadoria.Focus();
        }

        private void txtnomemercadoria_Enter(object sender, EventArgs e)
        {
            if (txtcodigomercadoria.Text.Trim() == "")
            {
                btnSalvar.Focus();
                //return;
            }
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void LimpaTela()
        {
            PainelMercadoria.Visible = true;
            txtnumeronota.Text = "";
            txtserienota.Text = "";
            txtcodigotipooperacao.Text = "";
            txtnometipooperacao.Text = "";
            txtcodigofornecedor.Text = "";
            txtnomefornecedor.Text = "";
            txtCpfCnpjEmitente.Text = "";
            txtdtemissao.Text = "";
            txtdtrecebimento.Text = "";
            txtpathXml.Text = "";
            txtcodigomercadoria.Text = "";
            txtnomemercadoria.Text = "";
            txtquantidade.Text = "";
            txtvalor.Text = "";
            Grid.Rows.Clear();

            txtnumeronota.Focus();
        }

        private void txtserienota_Leave(object sender, EventArgs e)
        {
            BuscaNota();
        }

        public void BuscaNota()
        {

            var dr = Entrada.SelectNota(txtnumeronota.Text, txtserienota.Text);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtCodigo.Text = dr.GetInt32(dr.GetOrdinal("CODENTRADA")).ToString();
                    txtnumeronota.Text = dr.GetString(dr.GetOrdinal("NUMERONOTA"));
                    txtserienota.Text = dr.GetString(dr.GetOrdinal("SERIE"));
                    txtcodigotipooperacao.Text = dr.GetString(dr.GetOrdinal("CFOP"));
                    BuscaCfop("codigo", txtcodigotipooperacao.Text);
                    txtdtemissao.Text = dr.GetString(dr.GetOrdinal("DATAEMISSAO")).ToString();
                    txtdtrecebimento.Text = dr.GetString(dr.GetOrdinal("DATAENTREGA")).ToString();

                    txtcodigofornecedor.Text = dr.GetInt32(dr.GetOrdinal("CODFORNECEDOR")).ToString();
                    BuscaFornecedor("codigo", txtcodigofornecedor.Text.Trim());

                }
            }
            dr.Dispose();
            dr.Close();

            BuscaItensNota(txtnumeronota.Text, txtserienota.Text, txtcodigofornecedor.Text);
        }

        private void BuscaItensNota(string numero, string serie, string fornecedor)
        {

            //define um array de strings com numero de colunas
            string[] linhaDados = new string[6];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Entrada_item.SelectN(numero, serie, fornecedor);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    var indice = dr.GetString(dr.GetOrdinal("CODPRODUTO"));

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NOME"));

                    linhaDados[2] = dr.GetString(dr.GetOrdinal("QUANTIDADE"));
                    //linhaDados[3] = dr.GetString(dr.GetOrdinal("CODCFOP"));
                    linhaDados[4] = dr.GetString(dr.GetOrdinal("CODPRODUTOFORNECEDOR"));
                    linhaDados[5] = dr.GetString(dr.GetOrdinal("NOMEPRODUTOFORNECEDOR"));

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            if (txtnumeronota.Text.Trim() == "")
            {
                return;
            }
            else
            {
                Relatorio();
            }
        }

        private void Relatorio()
        {
            var cria = new Classes.Funcoes.CriaArquivo();
            cria.Cria_Entrada();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Entrada.SelectRel("nota", txtnumeronota.Text.Trim(), txtserienota.Text.Trim());

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    var codentrada = dr.GetInt32(dr.GetOrdinal("CODENTRADA"));
                    var codempresa = dr.GetInt32(dr.GetOrdinal("CODEMPRESA"));
                    var nomeempresa = dr.GetString(dr.GetOrdinal("NOMEEMPRESA"));
                    var coddepartamento = dr.GetInt32(dr.GetOrdinal("CODDEPARTAMENTO"));
                    var nomedepartamento = dr.GetString(dr.GetOrdinal("NOMEDEPARTAMENTO"));
                    var numeronota = dr.GetString(dr.GetOrdinal("NUMERONOTA"));
                    var serie = dr.GetString(dr.GetOrdinal("SERIE"));
                    var cfop = dr.GetString(dr.GetOrdinal("CFOP"));
                    var codfornecedor = dr.GetInt32(dr.GetOrdinal("CODFORNECEDOR"));
                    var nomefornecedor = dr.GetString(dr.GetOrdinal("NOMEFORNECEDOR"));
                    var emissao = dr.GetString(dr.GetOrdinal("EMISSAO"));
                    var recebimento = dr.GetString(dr.GetOrdinal("RECEBIMENTO"));
                    var codproduto = dr.GetInt32(dr.GetOrdinal("CODPRODUTO"));
                    var nomeproduto = dr.GetString(dr.GetOrdinal("NOMEPRODUTO"));
                    var quantidade = dr.GetString(dr.GetOrdinal("QUANTIDADE"));

                    var respinclusao = "";
                    var datainclusao = "";
                    var respalteracao = "";
                    var dataalteracao = "";

                    try
                    {
                        var m = new Entrada();

                        m.InsertAccess(codentrada, codempresa, nomeempresa, coddepartamento, nomedepartamento, numeronota, serie, cfop, codfornecedor, nomefornecedor, emissao, recebimento,
                            codproduto, nomeproduto, quantidade);
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
                if (form is RelEntrada)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelEntrada();
                tela.ShowDialog();
            }

        }

        private void txtnumeronota_Leave(object sender, EventArgs e)
        {
            if (txtnumeronota.Text.Trim() != "")
            {
                //BuscaNota();
            }
        }

        private void txtdtrecebimento_Leave(object sender, EventArgs e)
        {
            txtcodigomercadoria.Focus();
        }
    }





}
