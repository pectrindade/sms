using Atencao_Assistida.Forms;
using Atencao_Assistida.Pesquisas;
using Atencao_Assistida.Relatorios.Protocolo;
using System;
using System.Windows.Forms;


namespace Atencao_Assistida
{
    public partial class Processo : Form
    {
        public Processo()
        {
            InitializeComponent();


        }

        private void Processo_Activated(object sender, EventArgs e)
        {
            txtNumeroProtocolo.Focus();
        }

        private void Processo_Load(object sender, EventArgs e)
        {
            BuscaProtocolo();
            CarregaCmbEspecialidade();
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

        private void Gravar(bool novo, int codigo)
        {

            var hoje = DateTime.Now;

            var codprotocolo = txtcodProtocolo.Text;
            var numeroprotocolo = txtNumeroProtocolo.Text;
            var codempresa = "1";
            var codpaciente = txtcodigo.Text;

            var situacao = cmbsituacao.Text;
            var datasituacao = txtDtSituacao.Text;

            var observacao = "";

            var respinclusao = Usuario.Nomeusuario.ToString();
            var datainclusao = hoje.ToString();
            var respalteracao = Usuario.Nomeusuario.ToString();
            var dataalteracao = hoje.ToString();
            var excluido = "N";
            int numero = 0;

            if (codprotocolo == "") { codprotocolo = "0"; }

            try
            {
                var m = new Classes.Mysql.Protocolo(int.Parse(codprotocolo), numeroprotocolo, codempresa, codpaciente, situacao, datasituacao,
                    observacao, respinclusao, datainclusao, respalteracao, dataalteracao, excluido);
                if (novo)
                {
                    numero = m.Insert();
                }
                else
                {
                    m.Update();
                    numero = int.Parse(codprotocolo);
                }

                Gravar_Item(numero.ToString());

                MessageBox.Show("Registro Gravado com Sucesso !");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Persistência");
            }

            LimpaTelaTudo();
        }

        private void Gravar_Item( string codprotocolo)
        {

            var d = new Classes.Mysql.Protocolo();
           
            d.Delete_Item(int.Parse(codprotocolo));

            var Linhas = Grid.Rows.Count;
            if (Linhas != 1)
            {
                foreach (DataGridViewRow linha1 in Grid.Rows)
                {
                    try
                    {
                        var codproduto = linha1.Cells[0].Value.ToString();
                        var especialidade = linha1.Cells[2].Value.ToString();
                        var quantidadeproduto = linha1.Cells[5].Value.ToString();

                        var mi = new Classes.Mysql.Protocolo();

                        mi.Insert_Item(int.Parse(codprotocolo), codproduto, especialidade, quantidadeproduto);
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtcodProtocolo.Text.Trim() == "")
            {

                Gravar(true, 0);

            }
            else
            {

                Gravar(false, int.Parse(txtcodProtocolo.Text.Trim()));

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Processo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }

        }

        private void Processo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {

                if (ActiveControl.Name == "txtNumeroProtocolo") { btnBuscaProtocolo.PerformClick(); return; }
                if (ActiveControl.Name == "txtcodigo") { btnBuscaPaciente.PerformClick(); return; }
                if (ActiveControl.Name == "txtcodigoPr") { btnBuscaProduto.PerformClick(); return; }

            }

        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            if (txtNumeroProtocolo.Text.Trim() == "")
            {
                //MessageBox.Show("Favor Inserir Numero de Protocolo !");
                //txtNumeroProtocolo.Focus();
                return;
            }

            if (txtcodigo.Text.Trim() != "")
            {

                BuscaPaciente(int.Parse(txtcodigo.Text));

                CarregaGrid(txtcodProtocolo.Text);

            }
        }
               
        private void btnBuscaPaciente_Click(object sender, EventArgs e)
        {

            Parametros.Form = "Processo";
            Parametros.Valor = "";

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaPaciente")
                {
                    if (form is PesquisaPaciente)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {
                Form tela = new PesquisaPaciente();
                tela.ShowDialog();
                RetornoPesquisaPaciente();
            }
        }

        private void btnCadastraPaciente_Click(object sender, EventArgs e)
        {
            Parametros.Form = "Processo";
            Parametros.Valor = "";

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "Paciente")
                {
                    if (form is Paciente)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {

                Form tela = new Paciente();
                // tela.MdiParent = MdiParent;
                tela.ShowDialog();
                RetornoPesquisaPaciente();


            }
        }

        private void BuscaPaciente(int codigo)
        {

            var dr = Classes.Mysql.Pacientes.BuscaUm(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtcodigo.Text = dr.GetString(dr.GetOrdinal("CODPACIENTE"));
                    txtnome.Text = dr.GetString(dr.GetOrdinal("NOME"));
                    dtnascimento.Text = dr.GetString(dr.GetOrdinal("DATANASCIMENTO"));
                    txtNumerosus.Text = dr.GetString(dr.GetOrdinal("NUMEROSUS"));
                    txtNomemae.Text = dr.GetString(dr.GetOrdinal("NOMEMAE"));
                    txtendereco.Text = dr.GetString(dr.GetOrdinal("ENDERECO"));
                    txtbairro.Text = dr.GetString(dr.GetOrdinal("BAIRRO"));
                    txtfone.Text = dr.GetString(dr.GetOrdinal("TELEFONE"));
                    txtcell.Text = dr.GetString(dr.GetOrdinal("CELL"));


                }

            }


            dr.Close();
            dr.Dispose();

            CarregaGrid(txtcodProtocolo.Text);
        }

        public void RetornoPesquisaPaciente()
        {
            if (Parametros.Valor != "")
            {
                BuscaPaciente(int.Parse(Parametros.Valor));
            }
        }
        
        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            LimpaTelaTudo();
        }

        private void LimpaTelaTudo()
        {

            txtcodProtocolo.Text = "";
            txtNumeroProtocolo.Text = "";
            txtcodigo.Text = "";
            txtnome.Text = "";
            dtnascimento.Text = "";

            txtNumerosus.Text = "";
            txtNomemae.Text = "";
            txtendereco.Text = "";
            txtbairro.Text = "";
            txtfone.Text = "";
            txtcell.Text = "";
            txtDtSituacao.Text = "  /  /    ";
            cmbsituacao.Text = "";


            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();
            Ppaciente.Enabled = true;
            Pprodutos.Enabled = true;
            BuscaProtocolo();
            txtNumeroProtocolo.Focus();

        }

        private void LimpaTela1()
        {
            txtcodigo.Text = "";
            txtnome.Text = "";
            dtnascimento.Text = "";

            txtNumerosus.Text = "";
            txtNomemae.Text = "";
            txtendereco.Text = "";
            txtbairro.Text = "";
            txtfone.Text = "";
            txtcell.Text = "";
           

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();
            Ppaciente.Enabled = true;
            Pprodutos.Enabled = true;

            //txtcodProtocolo.Focus();
        }

        private void LimpaTela2()
        {

            txtnome.Text = "";
            dtnascimento.Text = "";

            txtNumerosus.Text = "";
            txtNomemae.Text = "";
            txtendereco.Text = "";
            txtbairro.Text = "";
            txtfone.Text = "";
            txtcell.Text = "";
          

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();
            Ppaciente.Enabled = true;
            Pprodutos.Enabled = true;

            //txtcodProtocolo.Focus();
        }

        private void btnBuscaProduto_Click(object sender, EventArgs e)
        {


            Parametros.Form = "Processo";
            Parametros.Valor = "";

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

                Form tela = new PesquisaProdutos();
                // tela.MdiParent = MdiParent;
                tela.ShowDialog();
                RetornoPesquisaProdutos();


            }
        }

        private void txtcodigoPr_Leave(object sender, EventArgs e)
        {
            if (txtcodigoPr.Text != "")
            {
                BuscaProduto(int.Parse(txtcodigoPr.Text));
            }
            else if (txtcodigoPr.Text == "")
            {
                btnSalvar.Focus();
                return;
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


                    txtcodigoPr.Text = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    txtnomePr.Text = dr.GetString(dr.GetOrdinal("DESCRICAO"));
                    txtUnidade.Text = dr.GetString(dr.GetOrdinal("NOMEUNIDADE"));
                   
                    cmbEspecialidade.Focus();

                }

            }
            else
            {
                btnSalvar.Focus();
            }

            dr.Close();
            dr.Dispose();

        }

        private void btnBuscaProtocolo_Click(object sender, EventArgs e)
        {

            Parametros.Form = "Processo";
            Parametros.Valor = "";

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaProtocolo")
                {
                    if (form is PesquisaProtocolo)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {

                Form tela = new PesquisaProtocolo();
                // tela.MdiParent = MdiParent;
                tela.ShowDialog();
                RetornoPesquisaProtocolo();


            }
        }

        public void RetornoPesquisaProtocolo()
        {
            if (Parametros.Valor != "")
            {
                BuscaProtocolo("CODIGO", Parametros.Valor);
            }
        }

        private void BuscaProtocolo(string por, string codigo)
        {

            var dr = Classes.Mysql.Protocolo.Select(por, codigo.ToString());

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtcodProtocolo.Text = dr.GetString(dr.GetOrdinal("CODPROTOCOLO"));
                    txtNumeroProtocolo.Text = dr.GetString(dr.GetOrdinal("NUMEROPROTOCOLO"));
                    txtcodigo.Text = dr.GetString(dr.GetOrdinal("CODPACIENTE"));
                    cmbsituacao.Text = dr.GetString(dr.GetOrdinal("SITUACAO"));
                    txtDtSituacao.Text = dr.GetString(dr.GetOrdinal("DATASITUACAO"));

                }

                dr.Close();
                dr.Dispose();

                BuscaPaciente(int.Parse(txtcodigo.Text));
                Ppaciente.Enabled = false;
                Pprodutos.Enabled = false;
                CarregaGrid(txtcodProtocolo.Text);

                Ppaciente.Enabled = true;
                Pprodutos.Enabled = true;

            }
            else
            {

                dr.Close();
                dr.Dispose();

                LimpaTela1();

                //txtcodigo.Focus();
            }



        }
               
        private void GridAdd()
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[6];

            linhaDados[0] = txtcodigoPr.Text;
            linhaDados[1] = txtnomePr.Text;

            linhaDados[2] = cmbEspecialidade.SelectedIndex.ToString();
            linhaDados[3] = cmbEspecialidade.Text;

            linhaDados[4] = txtUnidade.Text;
            linhaDados[5] = txtQuantidade.Text;

            Grid.Rows.Add(linhaDados);

            txtcodigoPr.Text = "";
            txtnomePr.Text = "";
            cmbEspecialidade.Text = "";
            txtUnidade.Text = "";
            txtQuantidade.Text = "";
            txtcodigoPr.Focus();
        }

        private void CarregaGrid(string valor)
        {


            //define um array de strings com nCOlunas
            string[] linhaDados = new string[6];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.Protocolo.SelectProdutos(valor);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("PRODUTO"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("CODESPECIALIDADE"));
                    linhaDados[3] = dr.GetString(dr.GetOrdinal("ESPECIALIDADE"));
                    linhaDados[4] = dr.GetString(dr.GetOrdinal("NOMEUNIDADE"));
                    linhaDados[5] = dr.GetString(dr.GetOrdinal("QUANTIDADE"));

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {

            if (txtQuantidade.Text.Trim() != "")
            {
                GridAdd();
            }

        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid.CurrentRow == null) return;
            Grid.Rows.RemoveAt(Grid.CurrentRow.Index);
        }

        private void txtcodProtocolo_Leave(object sender, EventArgs e)
        {

        }

        private void txtcell_Leave(object sender, EventArgs e)
        {
            txtcodigoPr.Focus();
        }

        private void txtNumeroProtocolo_Leave(object sender, EventArgs e)
        {
            if (txtNumeroProtocolo.Text.Trim() != "")
            {

                BuscaProtocolo("NUMERO", txtNumeroProtocolo.Text);
            }
            else
            {
                //MessageBox.Show("Numero Inválido !");

            }
        }

        private void BuscaProtocolo()
        {
            var ultimo = "";
            string fmt = "00000.##";

            if (txtNumeroProtocolo.Text.Trim() == "")
            {
                var dr = Classes.Mysql.Protocolo.BuscaCodigo();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ultimo = dr.GetString(dr.GetOrdinal("ULTIMO"));
                    }
                }

                string sequencial = ultimo.Substring(0, 5);
                var hoje = DateTime.Now.ToString("yyyy");
                var proximo = int.Parse(sequencial) + 1;
                var procotolo = proximo.ToString(fmt);

                dr.Close();
                dr.Dispose();

                txtNumeroProtocolo.Text = procotolo + hoje;
            }

        }

        private void Relatorio(string por, string codigo)
        {
            // ESVAZIA O REPOSITORIO
            var d = new Classes.Mysql.Protocolo();
            d.DeleteAccess();
            d.DeleteAccess_Item();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Protocolo.SelectRel(por, codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    var hoje = DateTime.Now;

                    var codprotocolo = dr.GetString(dr.GetOrdinal("CODPROTOCOLO"));
                    var numeroprocotolo = dr.GetString(dr.GetOrdinal("NUMEROPROTOCOLO"));
                    var situacao = dr.GetString(dr.GetOrdinal("SITUACAO"));
                    var datasituacao = dr.GetString(dr.GetOrdinal("DATASITUACAO"));
                    var observacao = dr.GetString(dr.GetOrdinal("OBSERVACAO"));

                    var codpaciente = dr.GetString(dr.GetOrdinal("CODPACIENTE"));
                    var nome = dr.GetString(dr.GetOrdinal("NOME"));
                    var datanascimento = dr.GetString(dr.GetOrdinal("DATANASCIMENTO"));
                    var sexo = dr.GetString(dr.GetOrdinal("SEXO"));
                    var numerosus = dr.GetString(dr.GetOrdinal("NUMEROSUS"));
                    var nomemae = dr.GetString(dr.GetOrdinal("NOMEMAE"));
                    var endereco = dr.GetString(dr.GetOrdinal("ENDERECO"));
                    var bairro = dr.GetString(dr.GetOrdinal("BAIRRO"));
                    var telefone = dr.GetString(dr.GetOrdinal("TELEFONE"));
                    

                    

                    try
                    {
                        var m = new Classes.Mysql.Protocolo(int.Parse(codprotocolo), numeroprocotolo, situacao, datasituacao, observacao,
                            codpaciente, nome, datanascimento, sexo.ToString(), numerosus, nomemae, 
                            endereco, bairro, telefone );

                        m.InsertAccess();

                        foreach (DataGridViewRow linha in Grid.Rows)
                        {
                            var codproduto = linha.Cells[0].Value.ToString(); 
                            var nomeproduto = linha.Cells[1].Value.ToString();
                            var especialidade = linha.Cells[3].Value.ToString();
                            var Unidade = linha.Cells[4].Value.ToString();
                            var quantidadeproduto = linha.Cells[5].Value.ToString();

                            var mi = new Classes.Mysql.Protocolo();

                            mi.InsertAccess_Item(int.Parse(codprotocolo), codproduto, nomeproduto, especialidade, Unidade, quantidadeproduto);
                        }
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
                if (form is RelProtocolo)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelProtocolo();
                tela.ShowDialog();
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            if (txtcodigo.Text.Trim() != "")
            {
                Relatorio("NUMERO", txtNumeroProtocolo.Text.Trim());

            }
            else
            {
                MessageBox.Show("Sem Processo Selecionado");
                txtcodigo.Focus();

            }

        }

        private void cmbsexo_Leave(object sender, EventArgs e)
        {
            txtDtSituacao.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void txtDtSituacao_Leave(object sender, EventArgs e)
        {
            txtcodigo.Focus();
        }
    }
}
