
using Atencao_Assistida.Pesquisas;
using System;
using System.Windows.Forms;

namespace Atencao_Assistida.Forms
{
    public partial class Visitas : Form
    {

        public string glbCodVisitas;

        public Visitas()
        {
            InitializeComponent();
            CarregacmbAgenteSaude();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            Close();
        }

        private void Visitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Visitas_Load(object sender, EventArgs e)
        {
            CarregacmbAgenteSaude();

        }

        public void RetornoPesquisaVisitas()
        {
            if (Parametros.Valor != "")
            {
                BuscaVisitas(Parametros.Valor);
            }
        }

        private void txtNumeroProtocolo_Leave(object sender, EventArgs e)
        {
            if (txtNumeroProtocolo.Text.Trim() != "")
            {
                BuscaVisitas(txtNumeroProtocolo.Text);
            }
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void LimpaTela()
        {
            txtNumeroProtocolo.Text = "";
            txtnumerovisita.Text = "";
            txtcodvisitas.Text = "0";
            txtcodprotocolo.Text = "";
            txtcodigo.Text = "";
            txtNome.Text = "";
            mskDataVisita.Text = "  /  /    ";
            mskDtCadastro.Text = "  /  /    ";
            cmbAgenteSaude.Text = "";
            cmbStatus.Text = "";
            txtObs.Text = "";

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            Parametros.Form = "Visitas";
            txtNumeroProtocolo.Focus();

        }

        private void Gravar(bool novo, int codigo)
        {

            var hoje = DateTime.Now;

            var codVisitas = txtcodvisitas.Text.Trim();
            var codprotocolo = txtcodprotocolo.Text.Trim();

            var numerovisita = txtnumerovisita.Text.Trim();

            var numeroprotocolo = txtNumeroProtocolo.Text.Trim();
            var codpaciente = txtcodigo.Text;
            var datavisita = mskDataVisita.Text.Trim();
            var codagente = cmbAgenteSaude.SelectedIndex.ToString();
            var statuspaciente = cmbStatus.Text.Trim();
            var obs = txtObs.Text.Trim();

            try
            {
                var m = new Classes.Mysql.Visitas(int.Parse(codVisitas), int.Parse(codprotocolo), int.Parse(numerovisita), numeroprotocolo, int.Parse(codpaciente), datavisita, int.Parse(codagente), statuspaciente, obs);
                if (novo)
                {
                    m.Insert();

                }
                else
                {
                    m.Update();
                   
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
            //if (txtNumeroProtocolo.Text.Trim() == "0")
            //{

                Gravar(true, 0);

            //}
            //else
            //{

            //    Gravar(false, int.Parse(txtNumeroProtocolo.Text.Trim()));

            //}
        }

        private void Relatorio(string codigo)
        {
            // ESVAZIA O REPOSITORIO
            var d = new Classes.Mysql.Visitas();
            d.DeleteAccess();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Visitas.BuscaUm(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    var hoje = DateTime.Now;
                    var codVisitas = txtNumeroProtocolo.Text.Trim();
                    //var nome = txtNome.Text.Trim();
                    //var datanascimento = dtnascimento.Text.Trim();
                    //var sexo = cmbsexo.Text;
                    //var numerosus = txtNumerosus.Text.Trim();
                    //var nomemae = txtNomemae.Text.Trim();
                    //var endereco = txtendereco.Text.Trim();
                    //var bairro = txtbairro.Text.Trim();
                    //var telefone = txtfone.Text.Trim();
                    //var cell = txtcell.Text.Trim();

                    var respinclusao = Usuario.Nomeusuario.ToString();
                    var datainclusao = hoje.ToString();
                    var respalteracao = Usuario.Nomeusuario.ToString();
                    var dataalteracao = hoje.ToString();
                    var excluido = "N";

                    try
                    {
                    //    var m = new Classes.Mysql.Visitass(int.Parse(codVisitas), nome, datanascimento, sexo.ToString(), numerosus, nomemae, endereco, bairro, telefone, cell,
                    //respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao, excluido);

                        //m.InsertAccess();
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
                //if (form is RelVisitas)
                //{
                //    form.BringToFront();
                //    open = true;
                //}
            }
            if (!open)
            {
                //Form tela = new RelVisitas();
                //tela.ShowDialog();
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            if (txtNumeroProtocolo.Text.Trim() != "")
            {
                Relatorio(txtNumeroProtocolo.Text.Trim());

            }
            else
            {
                MessageBox.Show("Sem Visitas Selecionado");
                txtNumeroProtocolo.Focus();

            }

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
                BuscaVisitas(txtNumeroProtocolo.Text);
            }
        }

        private void BuscaProtocolo(string por, string codigo)
        {
            var codProtocolo = "";
            var dr = Classes.Mysql.Protocolo.Select(por, codigo.ToString());

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    codProtocolo = dr.GetString(dr.GetOrdinal("CODPROTOCOLO"));
                    txtcodprotocolo.Text = dr.GetString(dr.GetOrdinal("CODPROTOCOLO"));

                    txtNumeroProtocolo.Text = dr.GetString(dr.GetOrdinal("NUMEROPROTOCOLO"));

                    txtcodigo.Text = dr.GetString(dr.GetOrdinal("CODPACIENTE"));
                    txtNome.Text = dr.GetString(dr.GetOrdinal("NOME"));

                    mskDtCadastro.Text = dr.GetString(dr.GetOrdinal("DATAINCLUSAO"));

                }

                dr.Close();
                dr.Dispose();

                //LIMPAR GRID
                Grid.Rows.Clear();
                Grid.Refresh();

                CarregaGrid(codProtocolo);

                

            }
            else
            {

                dr.Close();
                dr.Dispose();

                //LimpaTela1();

                
            }



        }

        private void BuscaVisitas(string Protocolo)
        {
            if (Parametros.Valor != "")
            {
                Protocolo = Parametros.Valor;
            }

            txtnumerovisita.Text = "1";

            var dr = Classes.Mysql.Visitas.BuscaUm(Protocolo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtcodvisitas.Text = dr.GetString(dr.GetOrdinal("CODVISITA"));

                    var numVisita = dr.GetString(dr.GetOrdinal("NUMEROVISITA"));
                    var numeroVisita = int.Parse(numVisita) + 1;

                    txtnumerovisita.Text = numeroVisita.ToString();

                    //txtcodigo.Text = dr.GetString(dr.GetOrdinal("CODPACIENTE"));

                    //txtNome.Text = dr.GetString(dr.GetOrdinal("NOMEPACIENTE"));

                    //mskDtCadastro.Text = dr.GetString(dr.GetOrdinal("DATAVISITA"));

                }

            }

            dr.Close();
            dr.Dispose();

            mskDataVisita.Focus();

        }

        private void CarregaGrid(string valor)
        {


            //define um array de strings com nCOlunas
            string[] linhaDados = new string[3];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.Visitas.BuscaVisitaUm(valor);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("DATAVISITA"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NOMEAGENTE"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("STATUSPACIENTE"));
                   
                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }
        
        private void CarregacmbAgenteSaude()
        {
            int codigo;
            string nome;

            cmbAgenteSaude.Items.Clear();

            cmbAgenteSaude.Items.Insert(0, "--SELECIONE--");

            var dr = Classes.Mysql.Agente.BuscaTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    codigo = int.Parse(dr.GetString(dr.GetOrdinal("CODAGENTE")));
                    nome = dr.GetString(dr.GetOrdinal("NOME"));

                    cmbAgenteSaude.Items.Insert(codigo, nome);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text != "Ativo")
            {
                txtObs.Focus();

            }
        }
    }
}
