using Atencao_Assistida.Classes.Mysql;
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
    public partial class FechamentoEstoque : Form
    {
        public FechamentoEstoque()
        {
            InitializeComponent();
        }

        private void FechamentoEstoque_Load(object sender, EventArgs e)
        {
            CarregaCmbDepartamento();
            CarregaCmbGrupo();
        }

        private void FechamentoEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void FechamentoEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H)
            {
                if (ActiveControl.Name == "txtdtprocesso") { txtdtprocesso.Text = DateTime.Now.ToString("dd/MM/yyyy"); ; return; }

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;

            this.txtdtprocesso.Text = date.ToString("dd/MM/yyyy");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void CarregaCmbGrupo()
        {
            int codigo;
            string nome;


            cmbgrupo.Items.Clear();


            cmbgrupo.Items.Insert(0, "--SELECIONE--");

            var dr = Classes.Mysql.Grupo.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    codigo = int.Parse(dr.GetString(dr.GetOrdinal("CODGRUPO")));
                    nome = dr.GetString(dr.GetOrdinal("DESCRICAO"));

                    cmbgrupo.Items.Insert(codigo, nome);
                }

            }

            dr.Close();
            dr.Dispose();

        }


        private void btnExecutar_Click(object sender, EventArgs e)
        {
            FechaEstoque();
        }

        public void FechaEstoque()
        {
            var codempresa = Usuario.Codempresa.ToString();
            var coddepartamento = cmbDepartamento.SelectedIndex.ToString();
            var grupo = "";

            if (cmbgrupo.SelectedIndex.ToString() != "") { grupo = cmbgrupo.SelectedIndex.ToString(); }
            if (grupo == "-1") { grupo = ""; }

            var codproduto = "";

            if (txtcodigo.Text.Trim() != "") { codproduto = txtcodigo.Text.Trim(); }

            DateTime data = Convert.ToDateTime(txtdtprocesso.Text.Trim());

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

            var cont = new Produto() ;
            var Cont = cont.SelectCount();

            int progresso1 = 0;
            int progresso2 = 0;
            progressBar1.Value = progresso1;
            progressBar2.Value = progresso2;
            progressBar1.Maximum = Cont;
            progressBar2.Maximum = 31;

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

                        progresso2 = progresso2 + 1;
                        progressBar2.Value = i;
                    }

                    SaldoAtual(int.Parse(codempresa), int.Parse(dr.GetString(dr.GetOrdinal("CODPRODUTO"))));

                    progresso1 = progresso1 + 1;
                    progressBar1.Value = progresso1;

                }

            }

            dr.Close();
            dr.Dispose();


            MessageBox.Show("Fim do Processo !");

        }

        private void ControlaEstoque(int codempresa, int codproduto, string QtEntrada, string QtSaida)
        {

            
           
            //SaidaProduto(codempresa, codproduto, QtSaida);
            //SaldoAtual(codempresa, codproduto);

        }

        private void SaldoAnterior(int codempresa, int codproduto)
        {

            DateTime data = Convert.ToDateTime(txtdtprocesso.Text.Trim());

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

            DateTime data = Convert.ToDateTime(txtdtprocesso.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);


            var ent = new Estoque(codempresa, coddepartamento, mes, ano, codproduto);

            ent.Fecha_Entradas(codempresa, coddepartamento, dia, codproduto);

           
        }

        private void SaidaProduto(int codempresa, int coddepartamento, string dia, int codproduto)
        {
            DateTime data = Convert.ToDateTime(txtdtprocesso.Text.Trim());

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);


            var ent = new Estoque(codempresa, coddepartamento, mes, ano, codproduto);

            ent.Fecha_Saida(codempresa, coddepartamento, dia, codproduto);

        }

        private void SaldoAtual(int codempresa, int codproduto)
        {
            DateTime data = Convert.ToDateTime(txtdtprocesso.Text.Trim());

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

    }
}
