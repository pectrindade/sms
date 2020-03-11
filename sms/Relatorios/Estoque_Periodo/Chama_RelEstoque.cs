using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.Estoque_Periodo
{
    public partial class Chama_RelEstoque : Form
    {
        public Chama_RelEstoque()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            Relatorio();
        }

        private void Relatorio()
        {

            DateTime dtInicial = Convert.ToDateTime(txtDataInicial.Text.Trim());
            string DataInicial = dtInicial.Year.ToString() + "-" + dtInicial.Month.ToString() + "-" + dtInicial.Day.ToString();

            DateTime dtFinal = Convert.ToDateTime(txtDataFinal.Text.Trim());
            string DataFinal = dtFinal.Year.ToString() + "-" + dtFinal.Month.ToString() + "-" + dtFinal.Day.ToString();



            var codempresa = 0;
            var nomeempresa = "";
            var coddepartamento = 0;
            var nomedepartamento = "";
            var codsaida = 0;
            var dataentrega = "";
            var codunidade = 0;
            if (txtCodUnidade.Text.Trim() != "") { codunidade = int.Parse(txtCodUnidade.Text.Trim()); }

            var nomeunidade = "";
            var solicitante = "";
            var numeropedido = "";
            var codproduto = 0;
            if (txtcodigo.Text.Trim() != "") { codproduto = int.Parse(txtcodigo.Text.Trim()); }

            var nomeproduto = "";
            var quantidade = "";


            var cria = new Classes.Funcoes.CriaArquivo();
            cria.Cria_SaidaPeriodo();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Saida.Saida_Periodo(cmbEmpresa.SelectedIndex, cmbDepartamento.SelectedIndex, codunidade, codproduto, DataInicial, DataFinal);

            if (dr.HasRows)
            {
                while (dr.Read())
                {


                    if (!dr.IsDBNull(dr.GetOrdinal("CODEMPRESA"))) { codempresa = dr.GetInt32(dr.GetOrdinal("CODEMPRESA")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEEMPRESA"))) { nomeempresa = dr.GetString(dr.GetOrdinal("NOMEEMPRESA")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("CODDEPARTAMENTO"))) { coddepartamento = dr.GetInt32(dr.GetOrdinal("CODDEPARTAMENTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEDEPARTAMENTO"))) { nomedepartamento = dr.GetString(dr.GetOrdinal("NOMEDEPARTAMENTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("CODSAIDA"))) { codsaida = dr.GetInt32(dr.GetOrdinal("CODSAIDA")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("DATASAIDA"))) { dataentrega = dr.GetString(dr.GetOrdinal("DATASAIDA")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("CODUNIDADE"))) { codunidade = dr.GetInt32(dr.GetOrdinal("CODUNIDADE")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEUNIDADE"))) { nomeunidade = dr.GetString(dr.GetOrdinal("NOMEUNIDADE")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("SOLICITANTE"))) { solicitante = dr.GetString(dr.GetOrdinal("SOLICITANTE")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NUMEROPEDIDO"))) { numeropedido = dr.GetString(dr.GetOrdinal("NUMEROPEDIDO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("CODPRODUTO"))) { codproduto = dr.GetInt32(dr.GetOrdinal("CODPRODUTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEPRODUTO"))) { nomeproduto = dr.GetString(dr.GetOrdinal("NOMEPRODUTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("QUANTIDADE"))) { quantidade = dr.GetString(dr.GetOrdinal("QUANTIDADE")); }


                    try
                    {
                        var m = new Classes.Mysql.Saida();

                        m.InsertAccessSaidaPeriodo(codempresa, nomeempresa, coddepartamento, nomedepartamento, codsaida, dataentrega, codunidade, nomeunidade,
                            solicitante, numeropedido, codproduto, nomeproduto, quantidade);
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
                if (form is RelEstoquePeriodo)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelEstoquePeriodo();
                tela.ShowDialog();
            }

        }

    }
}
