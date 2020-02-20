using Atencao_Assistida.Pesquisas;
using Atencao_Assistida.Relatorios.EntregaMercadoria;
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
    public partial class EntregaMedicamentos : Form
    {
        public EntregaMedicamentos()
        {
            InitializeComponent();
        }

        private void EntregaMedicamentos_Load(object sender, EventArgs e)
        {
            mskDtEntrega.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Entrega_de_Medicamentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void btnBuscaProtocolo_Click(object sender, EventArgs e)
        {

            Parametros.Form = "EntregaMedicamentos";
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

            var codProtocolo = "";

            var dr = Classes.Mysql.Protocolo.Select(por, codigo.ToString());

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    codProtocolo = dr.GetString(dr.GetOrdinal("CODPROTOCOLO"));
                    txtNumeroProtocolo.Text = dr.GetString(dr.GetOrdinal("NUMEROPROTOCOLO"));
                    txtcodigo.Text = dr.GetString(dr.GetOrdinal("CODPACIENTE"));
                   

                }

                dr.Close();
                dr.Dispose();

                BuscaPaciente(int.Parse(txtcodigo.Text));
                //Ppaciente.Enabled = false;
                //Pprodutos.Enabled = false;
                CarregaGrid(codProtocolo);

                //Ppaciente.Enabled = true;
                //Pprodutos.Enabled = true;

            }
            else
            {

                dr.Close();
                dr.Dispose();

                //LimpaTela1();

                //txtcodigo.Focus();
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
                   


                }

            }


            dr.Close();
            dr.Dispose();

            CarregaGrid(codigo.ToString());
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
        
        private void Gravar(bool novo, int codigo)
        {

            var hoje = DateTime.Now;

            var codentregamercadoria = txtCodEntregaMercadoria.Text;
            var numeroprotocolo = txtNumeroProtocolo.Text;
            var codempresa = "1";
            var codpaciente = txtcodigo.Text;
           
            var dataentrega = mskDtEntrega.Text;

            var observacao = "";

            var respinclusao = Usuario.Nomeusuario.ToString();
            var datainclusao = hoje.ToString();
            var respalteracao = Usuario.Nomeusuario.ToString();
            var dataalteracao = hoje.ToString();
            var excluido = "N";
            int numero = 0;

            if (codentregamercadoria == "") { codentregamercadoria = "0"; }

            try
            {
                var m = new Classes.Mysql.EntregaMercadoria(int.Parse(codentregamercadoria), numeroprotocolo, codempresa, codpaciente, dataentrega,
                    observacao, respinclusao, datainclusao, respalteracao, dataalteracao, excluido);
                if (novo)
                {
                    numero = m.Insert();
                }
                else
                {
                    m.Update();
                    numero = int.Parse(codentregamercadoria);
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

        private void Gravar_Item(string codentregamercadoria)
        {

            var d = new Classes.Mysql.EntregaMercadoria();

            d.Delete_Item(int.Parse(codentregamercadoria));

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

                        var mi = new Classes.Mysql.EntregaMercadoria();

                        mi.Insert_Item(int.Parse(codentregamercadoria), codproduto, especialidade, quantidadeproduto);
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodEntregaMercadoria.Text.Trim() == "")
            {

                Gravar(true, 0);

            }
            else
            {

                Gravar(false, int.Parse(txtCodEntregaMercadoria.Text.Trim()));

            }
        }



        private void LimpaTelaTudo()
        {

            //txtcodProtocolo.Text = "";
            txtNumeroProtocolo.Text = "";
            txtcodigo.Text = "";
            txtnome.Text = "";
          
           
            //txtDtSituacao.Text = "  /  /    ";
           

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();
           
            txtNumeroProtocolo.Focus();

        }

        private void LimpaTela1()
        {
            txtcodigo.Text = "";
            txtnome.Text = "";
            //dtnascimento.Text = "";

            


            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();
            

            //txtcodProtocolo.Focus();
        }

        private void LimpaTela2()
        {

            txtnome.Text = "";
            //dtnascimento.Text = "";

            


            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();
           
        }


        private void Relatorio(string por, string codigo)
        {
            // ESVAZIA O REPOSITORIO
            var d = new Classes.Mysql.EntregaMercadoria();
            d.DeleteAccess();
            d.DeleteAccess_Item();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.EntregaMercadoria.SelectRel(por, codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    var hoje = DateTime.Now;

                    var codprotocolo = dr.GetString(dr.GetOrdinal("CODENTREGAMERCADORIA"));
                    var numeroprocotolo = dr.GetString(dr.GetOrdinal("NUMEROPROTOCOLO"));
                    var dataentrega = dr.GetString(dr.GetOrdinal("DATAENTREGA"));
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
                        var m = new Classes.Mysql.EntregaMercadoria(int.Parse(codprotocolo), numeroprocotolo, dataentrega, observacao,
                            codpaciente, nome, datanascimento, sexo.ToString(), numerosus, nomemae,
                            endereco, bairro, telefone);

                        m.InsertAccess();

                        foreach (DataGridViewRow linha in Grid.Rows)
                        {
                            var codproduto = linha.Cells[0].Value.ToString();
                            var nomeproduto = linha.Cells[1].Value.ToString();
                            var especialidade = linha.Cells[3].Value.ToString();
                            var Unidade = linha.Cells[4].Value.ToString();
                            var quantidadeproduto = linha.Cells[5].Value.ToString();

                            var mi = new Classes.Mysql.EntregaMercadoria();

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
                if (form is RelEntregaMercadoria)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelEntregaMercadoria();
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

        private void txtNumeroProtocolo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
