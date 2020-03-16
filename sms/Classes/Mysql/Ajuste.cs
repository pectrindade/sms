using Atencao_Assistida.Classes.DAL;
using System;
using MySql.Data.MySqlClient;
using System.ComponentModel;

namespace Atencao_Assistida.Classes.Mysql
{
    [DataObject(true)]
    public class Ajuste
    {

        private int Codempresa { get; set; }
        private int Coddepartamento { get; set; }
        private string Dataajuste { get; set; }
        private int Codproduto { get; set; }
        private int Quantidade { get; set; }
        private string Motivo { get; set; }
        private string Respinclusao { get; set; }
        private string Datainclusao { get; set; }


        public Ajuste(int codempresa, int coddepartamento, string dataajuste, int codproduto, int quantidade, string motivo, string respinclusao, string datainclusao)  
        {
            Codempresa = codempresa;
            Coddepartamento = coddepartamento;
            Dataajuste = dataajuste;
            Codproduto = codproduto;
            Quantidade = quantidade;
            Motivo = motivo;
            Respinclusao = respinclusao;
            Datainclusao = datainclusao;

        }

        public Ajuste()
        {


        }
      
        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO ajuste_estoque( ";
            Mysql = Mysql + " CODEMPRESA, CODDEPARTAMENTO, DATAAJUSTE, CODPRODUTO, QUANTIDADE, MOTIVO, RESPINCLUSAO, DATAINCLUSAO ";
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODEMPRESA, @CODDEPARTAMENTO, @DATAAJUSTE, @CODPRODUTO, @QUANTIDADE, @MOTIVO, @RESPINCLUSAO, @DATAINCLUSAO ";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@DATAAJUSTE", Convert.ToDateTime(Dataajuste));
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@QUANTIDADE", Convert.ToDecimal(Quantidade));
            db.AddParameter("@MOTIVO", Motivo);
            db.AddParameter("@RESPINCLUSAO", Respinclusao);
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

        public bool Update()
        {
            var db = new DBAcess();
            var Mysql = " UPDATE ajuste_estoque ";
            Mysql = Mysql + " SET ";
            Mysql = Mysql + " CODEMPRESA = @CODEMPRESA, CODDEPARTAMENTO = @CODDEPARTAMENTO, DATAAJUSTE = @DATAAJUSTE, CODPRODUTO = @CODPRODUTO, ";
            Mysql = Mysql + " QUANTIDADE = @QUANTIDADE, MOTIVO = @MOTIVO, RESPINCLUSAO = @RESPINCLUSAO, DATAINCLUSAO = @DATAINCLUSAO ";

            Mysql = Mysql + " WHERE CODEMPRESA = @CODEMPRESA";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO";
            Mysql = Mysql + " AND DATAAJUSTE = @DATAAJUSTE";
            Mysql = Mysql + " AND CODPRODUTO = @CODPRODUTO;";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@DATAAJUSTE", Convert.ToDateTime(Dataajuste));
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@QUANTIDADE", Convert.ToDecimal(Quantidade));
            db.AddParameter("@MOTIVO", Motivo);
            db.AddParameter("@RESPINCLUSAO", Respinclusao);
            db.AddParameter("@DATAINCLUSAO", Convert.ToDateTime(Datainclusao));

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            finally
            {
                db.Dispose();
            }
        }

        public bool AutorizaAjuste(int codempresa, int coddepartamento, string dataajuste, string Autorizado, string Nomeautoriza, string Dataautoriza)
        {
            var db = new DBAcess();
            var Mysql = " UPDATE ajuste_estoque ";
            Mysql = Mysql + " SET ";
            Mysql = Mysql + " AUTORIZADO = @AUTORIZADO, NOMEAUTORIZA = @NOMEAUTORIZA, DATAAUTORIZA = @DATAAUTORIZA ";

            Mysql = Mysql + " WHERE CODEMPRESA = @CODEMPRESA";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO";
            Mysql = Mysql + " AND DATAAJUSTE = @DATAAJUSTE;";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATAAJUSTE", Convert.ToDateTime(dataajuste));

            db.AddParameter("@AUTORIZADO", Autorizado);
            db.AddParameter("@NOMEAUTORIZA", Nomeautoriza);
            db.AddParameter("@DATAAUTORIZA", Convert.ToDateTime(Dataautoriza));

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            finally
            {
                db.Dispose();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectAjuste(int codempresa, int coddepartamento, int codproduto)
        {
            var db = new DBAcess();
            var Mysql = " SELECT AJ.CODEMPRESA, AJ.CODDEPARTAMENTO, DATE_FORMAT(AJ.DATAAJUSTE,'%d/%m/%Y') AS DATAAJUSTE, ";
            Mysql = Mysql + " AJ.CODPRODUTO, P.NOME AS NOMEPRODUTO, AJ.QUANTIDADE, AJ.MOTIVO, AJ.AUTORIZADO  ";

            Mysql = Mysql + " FROM ajuste_estoque AJ ";
            Mysql = Mysql + " INNER JOIN produtos P ON AJ.CODPRODUTO = P.CODPRODUTO ";

            Mysql = Mysql + " WHERE AJ.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND AJ.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND AJ.CODPRODUTO = @CODPRODUTO ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@CODPRODUTO", codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectAjuste(int codempresa, int coddepartamento, string dataajuste)
        {
            var db = new DBAcess();
            var Mysql = " SELECT AJ.CODEMPRESA, AJ.CODDEPARTAMENTO, DATE_FORMAT(AJ.DATAAJUSTE,'%d/%m/%Y') AS DATAAJUSTE, ";
            Mysql = Mysql + " AJ.CODPRODUTO, P.NOME AS NOMEPRODUTO, AJ.QUANTIDADE, AJ.MOTIVO, AJ.AUTORIZADO  ";

            Mysql = Mysql + " FROM ajuste_estoque AJ ";
            Mysql = Mysql + " INNER JOIN produtos P ON AJ.CODPRODUTO = P.CODPRODUTO ";

            Mysql = Mysql + " WHERE AJ.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND AJ.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND AJ.DATAAJUSTE = @DATAAJUSTE ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATAAJUSTE", Convert.ToDateTime(dataajuste));

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectAjuste(int codempresa, int coddepartamento, string dataajuste, int codproduto)
        {
            var db = new DBAcess();
            var Mysql = " SELECT AJ.CODEMPRESA, AJ.CODDEPARTAMENTO, DATE_FORMAT(AJ.DATAAJUSTE,'%d/%m/%Y') AS DATAAJUSTE, ";
            Mysql = Mysql + " AJ.CODPRODUTO, P.NOME AS NOMEPRODUTO, AJ.QUANTIDADE, AJ.MOTIVO, AJ.AUTORIZADO  ";

            Mysql = Mysql + " FROM ajuste_estoque AJ ";
            Mysql = Mysql + " INNER JOIN produtos P ON AJ.CODPRODUTO = P.CODPRODUTO ";

            Mysql = Mysql + " WHERE AJ.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND AJ.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND AJ.DATAAJUSTE = @DATAAJUSTE ";
            Mysql = Mysql + " AND AJ.CODPRODUTO = @CODPRODUTO ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATAAJUSTE", Convert.ToDateTime(dataajuste));
            db.AddParameter("@CODPRODUTO", codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectRel(int codempresa, int coddepartamento, string dataajuste)
        {
            var db = new DBAcess();
            var Mysql = " SELECT B.CODEMPRESA, B.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, DATE_FORMAT(B.DATAAjuste,'%d/%m/%Y') AS DATAAjuste, ";
            Mysql = Mysql + " B.CODPRODUTO, P.NOME AS NOMEPRODUTO, B.QUANTIDADE ";
            Mysql = Mysql + " FROM ajuste_estoque AS B ";
            Mysql = Mysql + " INNER JOIN produtos AS P ON B.CODPRODUTO = P.CODPRODUTO ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = B.CODDEPARTAMENTO ";

            Mysql = Mysql + " WHERE B.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND B.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND B.DATAAJUSTE = @DATAAJUSTE ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATAAJUSTE", Convert.ToDateTime(dataajuste));

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        public int InsertAccess(int codempresa, int coddepartamento, string nomedepartamento, string dataajuste, int codproduto, string nomeproduto, string quantidade)
        {
            var db = new DBAcessOleDB();
            var Mysql = " INSERT INTO ajuste_estoque( ";
            Mysql = Mysql + "CODEMPRESA, CODDEPARTAMENTO, NOMEDEPARTAMENTO, DATAAJUSTE, CODPRODUTO, NOMEPRODUTO, QUANTIDADE ";

            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + "@CODEMPRESA, @CODDEPARTAMENTO, @NOMEDEPARTAMENTO, @DATAAJUSTE, @CODPRODUTO, @NOMEPRODUTO, @QUANTIDADE ";

            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@NOMEDEPARTAMENTO", nomedepartamento);
            db.AddParameter("@DATAAJUSTE", dataajuste);
            db.AddParameter("@CODPRODUTO", codproduto);
            db.AddParameter("@NOMEPRODUTO", nomeproduto);
            db.AddParameter("@QUANTIDADE", quantidade);

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
