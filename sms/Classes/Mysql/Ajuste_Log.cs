using Atencao_Assistida.Classes.DAL;
using System;
using MySql.Data.MySqlClient;
using System.ComponentModel;

namespace Atencao_Assistida.Classes.Mysql
{
    [DataObject(true)]
    public class Ajuste_Log
    {
        private int Codempresa { get; set; }
        private string Dataajuste { get; set; }
        private int Codproduto { get; set; }
        private int Coddepartamento { get; set; }
        private string Quantidadequeestava { get; set; }
        private string Quantidadeajustada { get; set; }
        private string Motivo { get; set; }
        private string Acao { get; set; }
        private string Responsavel { get; set; }
        private string Datainclusao { get; set; }
        

        public Ajuste_Log(int codempresa, string dataajuste, int codproduto, int coddepartamento, string quantidadequeestava, string quantidadeajustada,
                          string motivo, string acao, string responsavel, string datainclusao)
        {
            Codempresa = codempresa;
            Dataajuste = dataajuste;
            Codproduto = codproduto;
            Coddepartamento = coddepartamento;
            Quantidadequeestava = quantidadequeestava;
            Quantidadeajustada = quantidadeajustada;
            Motivo = motivo;
            Acao = acao;
            Responsavel = responsavel;
            Datainclusao = datainclusao;

        }

        public Ajuste_Log()
        {

        }



        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO ajuste_estoque_log( ";
            Mysql = Mysql + " CODEMPRESA, DATAAJUSTE, CODPRODUTO, CODDEPARTAMENTO, QUANTIDADEQUEESTAVA, QUANTIDADEAJUSTADA, MOTIVO, ";
            Mysql = Mysql + " ACAO, RESPONSAVEL, DATAINCLUSAO ";
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODEMPRESA, @DATAAJUSTE, @CODPRODUTO, @CODDEPARTAMENTO, @QUANTIDADEQUEESTAVA, @QUANTIDADEAJUSTADA, @MOTIVO, ";
            Mysql = Mysql + " @ACAO, @RESPONSAVEL, @DATAINCLUSAO ";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@DATAAJUSTE", Convert.ToDateTime(Dataajuste));
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@QUANTIDADEQUEESTAVA", Convert.ToDecimal(Quantidadequeestava));
            db.AddParameter("@QUANTIDADEAJUSTADA", Convert.ToDecimal(Quantidadeajustada));
            db.AddParameter("@MOTIVO", Motivo);
            db.AddParameter("@ACAO", Acao);
            db.AddParameter("@RESPONSAVEL", Responsavel);
            db.AddParameter("@DATAINCLUSAO", Convert.ToDateTime(Datainclusao));

            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }



    }
}
