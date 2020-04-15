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
    public partial class Detalhe_saida : Form
    {
        public Detalhe_saida()
        {
            InitializeComponent();
        }

        private void Detalhe_saida_Load(object sender, EventArgs e)
        {
            
            lblNome.Text = Parametros.Nome;
            Relatorio();

        }


        private void Relatorio()
        {
            Grid.Columns["numpedido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           
            //define um array de strings com nCOlunas
            string[] linhaDados = new string[6];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            DateTime date2 = DateTime.Now;
            var vData = date2.ToString("dd/MM/yyyy");

            DateTime data = Convert.ToDateTime(DateTime.Now);

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


           

            DateTime dtInicial = Convert.ToDateTime(dtinicial);
            string DataInicial = dtInicial.Year.ToString() + "-" + dtInicial.Month.ToString() + "-" + dtInicial.Day.ToString();

            DateTime dtFinal = Convert.ToDateTime(dtfinal);
            string DataFinal = dtFinal.Year.ToString() + "-" + dtFinal.Month.ToString() + "-" + dtFinal.Day.ToString();
           
            var codunidade = 0;
            var codproduto = 0;
            

            if (Parametros.Codigo != "") { codproduto = int.Parse(Parametros.Codigo); }


            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Saida.Saida_Periodo(int.Parse(Usuario.Codempresa), int.Parse(Parametros.Coddepartamento), codunidade, codproduto, DataInicial, DataFinal);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                   
                    if (!dr.IsDBNull(dr.GetOrdinal("CODUNIDADE"))) { linhaDados[0] = dr.GetString(dr.GetOrdinal("CODUNIDADE")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEUNIDADE"))) { linhaDados[1] = dr.GetString(dr.GetOrdinal("NOMEUNIDADE")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("SOLICITANTE"))) { linhaDados[2] = dr.GetString(dr.GetOrdinal("SOLICITANTE")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NUMEROPEDIDO"))) { linhaDados[3] = dr.GetString(dr.GetOrdinal("NUMEROPEDIDO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("QUANTIDADE"))) { linhaDados[4] = dr.GetString(dr.GetOrdinal("QUANTIDADE")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("DATASAIDA"))) { linhaDados[5] = dr.GetString(dr.GetOrdinal("DATASAIDA")); }

                    Grid.Rows.Add(linhaDados);

                    try
                    {
                        
                    }
                    catch (Exception erro)
                    {

                    }

                }

            }

            dr.Close();
            dr.Dispose();

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
