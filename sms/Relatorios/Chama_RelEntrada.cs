using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios
{
    public partial class Chama_RelEntrada : Form
    {
        public Chama_RelEntrada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Relatorio()
        {
            var cria = new Classes.Funcoes.CriaArquivo();
            cria.Cria_Entrada();

            // BUSCA E GRAVA NO REPOSITORIO
            //var dr = Entrada.SelectRel("nota", txtnumeronota.Text.Trim(), txtserienota.Text.Trim());

            //if (dr.HasRows)
            //{
            //    while (dr.Read())
            //    {

            //        var codentrada = dr.GetInt32(dr.GetOrdinal("CODENTRADA"));
            //        var codempresa = dr.GetInt32(dr.GetOrdinal("CODEMPRESA"));
            //        var nomeempresa = dr.GetString(dr.GetOrdinal("NOMEEMPRESA"));
            //        var coddepartamento = dr.GetInt32(dr.GetOrdinal("CODDEPARTAMENTO"));
            //        var nomedepartamento = dr.GetString(dr.GetOrdinal("NOMEDEPARTAMENTO"));
            //        var numeronota = dr.GetString(dr.GetOrdinal("NUMERONOTA"));
            //        var serie = dr.GetString(dr.GetOrdinal("SERIE"));
            //        var cfop = dr.GetString(dr.GetOrdinal("CFOP"));
            //        var codfornecedor = dr.GetInt32(dr.GetOrdinal("CODFORNECEDOR"));
            //        var nomefornecedor = dr.GetString(dr.GetOrdinal("NOMEFORNECEDOR"));
            //        var emissao = dr.GetString(dr.GetOrdinal("EMISSAO"));
            //        var recebimento = dr.GetString(dr.GetOrdinal("RECEBIMENTO"));
            //        var codproduto = dr.GetInt32(dr.GetOrdinal("CODPRODUTO"));
            //        var nomeproduto = dr.GetString(dr.GetOrdinal("NOMEPRODUTO"));
            //        var quantidade = dr.GetString(dr.GetOrdinal("QUANTIDADE"));

            //        var respinclusao = "";
            //        var datainclusao = "";
            //        var respalteracao = "";
            //        var dataalteracao = "";

            //        try
            //        {
            //            //var m = new Entrada();

            //            //m.InsertAccess(codentrada, codempresa, nomeempresa, coddepartamento, nomedepartamento, numeronota, serie, cfop, codfornecedor, nomefornecedor, emissao, recebimento,
            //            //    codproduto, nomeproduto, quantidade);
            //        }
            //        catch (Exception erro)
            //        {

            //        }

            //    }

            //}

            //dr.Close();
            //dr.Dispose();

            //CHAMA A TELA DE RELATORIO
            //bool open = false;
            //foreach (Form form in this.MdiChildren)
            //{
            //    if (form is RelEntrada)
            //    {
            //        form.BringToFront();
            //        open = true;
            //    }
            //}
            //if (!open)
            //{
            //    Form tela = new RelEntrada();
            //    tela.ShowDialog();
            //}

        }
    }
}
