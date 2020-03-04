using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.Saida_Periodo
{
    public partial class Chama_RelSaida : Form
    {
        public Chama_RelSaida()
        {
            InitializeComponent();
        }

        private void Chama_RelSaida_Load(object sender, EventArgs e)
        {

        }


        private void Relatorio()
        {
            var cria = new Classes.Funcoes.CriaArquivo();
            cria.Cria_SaidaPeriodo();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Saida.Saida_Periodo("", "");

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                                       
                    var codempresa = dr.GetInt32(dr.GetOrdinal("CODEMPRESA"));
                    var nomeempresa = dr.GetString(dr.GetOrdinal("NOMEEMPRESA"));
                    var coddepartamento = dr.GetInt32(dr.GetOrdinal("CODDEPARTAMENTO"));
                    var nomedepartamento = dr.GetString(dr.GetOrdinal("NOMEDEPARTAMENTO"));
                    var codsaida = dr.GetInt32(dr.GetOrdinal("CODSAIDA"));
                    var dataentrega = dr.GetString(dr.GetOrdinal("DATAENTREGA"));
                    var codunidade = dr.GetInt32(dr.GetOrdinal("CODUNIDADE"));
                    var nomeunidade = dr.GetString(dr.GetOrdinal("NOMEUNIDADE"));
                    var solicitante = dr.GetString(dr.GetOrdinal("SOLICITANTE"));
                    var numeropedido = dr.GetString(dr.GetOrdinal("NUMEROPEDIDO"));
                    var codproduto = dr.GetInt32(dr.GetOrdinal("CODPRODUTO"));
                    var nomeproduto = dr.GetString(dr.GetOrdinal("NOMEPRODUTO"));
                    var quantidade = dr.GetString(dr.GetOrdinal("QUANTIDADE"));

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
                if (form is RelSaidaPeriodo)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelSaidaPeriodo();
                tela.ShowDialog();
            }

        }


    }
}
