using Atencao_Assistida.Pesquisas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.PacienteProduto
{
    public partial class PacienteProduto : Form
    {
        public PacienteProduto()
        {
            InitializeComponent();
        }

        private void btnProcuraPaciente_Click(object sender, EventArgs e)
        {
            Parametros.Form = "Paciente";
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
                if (txtcodigo.Text.Trim() != "")
                {
                    BuscaPaciente(int.Parse(txtcodigo.Text));
                }

            }

        }

        public void RetornoPesquisaPaciente()
        {
            if (Parametros.Valor != "")
            {
                BuscaPaciente(int.Parse(Parametros.Valor));
            }
        }


        private void BuscaPaciente(int codigo)
        {
            if (Parametros.Valor != "")
            {
                codigo = int.Parse(Parametros.Valor);
            }

            var dr = Classes.Mysql.Pacientes.BuscaUm(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtcodigo.Text = dr.GetString(dr.GetOrdinal("CODPACIENTE"));
                    txtNome.Text = dr.GetString(dr.GetOrdinal("NOME"));
                   
                }

            }

            dr.Close();
            dr.Dispose();
                        
        }


        private void Relatorio(int codigo)
        {
            //CRIA A TABELA NO REPOSITORIO
            var cria = new Classes.Mysql.CriaArquivo();
            try
            {
                cria.Create_PacienteProdutos();
            }
            catch
            {

            }
            // ESVAZIA O REPOSITORIO
            //var c = new Classes.Mysql.CriaArquivo();
            //c.Create_PacienteProdutos();


            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Relatorios.SelectPacienteProduto(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    var hoje = DateTime.Now;

                    var codprotocolo = dr.GetString(dr.GetOrdinal("CODPROTOCOLO"));
                    var numeroprotocolo = dr.GetString(dr.GetOrdinal("NUMEROPROTOCOLO"));
                    var codpaciente = dr.GetString(dr.GetOrdinal("CODPACIENTE"));
                    var nomepaciente = dr.GetString(dr.GetOrdinal("NOMEPACIENTE"));
                    var codproduto = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    var nomeproduto = dr.GetString(dr.GetOrdinal("NOMEPRODUTO"));
                    var quantidade = dr.GetString(dr.GetOrdinal("QUANTIDADE"));

                    try
                    {
                        var m = new Classes.Mysql.CriaArquivo();

                        m.Insert_PacienteProdutos(codprotocolo, numeroprotocolo, codpaciente, nomepaciente, codproduto, nomeproduto, quantidade);
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
                if (form is RelPacienteProduto)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelPacienteProduto();
                tela.ShowDialog();
            }

        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            var cria = new Classes.Mysql.CriaArquivo();
            cria.Create_PacienteProdutos();
                 
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            Relatorio(0);

        }
    }
}
