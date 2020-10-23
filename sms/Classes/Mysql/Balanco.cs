using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencao_Assistida.Classes.Mysql
{
    [DataObject(true)]
    public class Balanco
    {

        private int Codempresa { get; set; }
        private int Coddepartamento { get; set; }
        private string Databalanco { get; set; }
        private int Codproduto { get; set; }
        private string Lote { get; set; }
        private string Validade { get; set; }
        private int Quantidade { get; set; }
        private string Respinclusao { get; set; }
        private string Datainclusao { get; set; }
        private string Respalteracao { get; set; }
        private string Dataalteracao { get; set; }


        public Balanco(int codempresa, int coddepartamento, string databalanco, int codproduto, string lote, string validade, int quantidade, string respinclusao, string datainclusao, string respalteracao, string dataalteracao)
        {
            Codempresa = codempresa;
            Coddepartamento = coddepartamento;
            Databalanco = databalanco;
            Codproduto = codproduto;
            Lote = lote;
            Validade = validade;
            Quantidade = quantidade;
            Respinclusao = respinclusao;
            Datainclusao = datainclusao;
            Respalteracao = respalteracao;
            Dataalteracao = dataalteracao;

        }


        public Balanco()
        {
  

        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet BuscaBalanco(int codempresa, int coddepartamento, string databalanco)
        {
            var db = new DBAcess();
            var Mysql = " SELECT B.CODEMPRESA, B.CODDEPARTAMENTO, DATE_FORMAT(B.DATABALANCO,'%d/%m/%Y') AS DATABALANCO, ";
            Mysql = Mysql + " B.CODPRODUTO, P.NOME AS DESCRICAO, B.LOTE, DATE_FORMAT(B.VALIDADE,'%d/%m/%Y') AS VALIDADE, B.QUANTIDADE ";
            Mysql = Mysql + " FROM balanco AS B ";
            Mysql = Mysql + " INNER JOIN produtos AS P ON B.CODPRODUTO = P.CODPRODUTO ";

            Mysql = Mysql + " WHERE B.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND B.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND B.DATABALANCO = @DATABALANCO ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATABALANCO", Convert.ToDateTime(databalanco));


            var ds = db.ExecuteDataSet();
            return ds;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectBalanco(int codempresa, int coddepartamento, string databalanco)
        {
            var db = new DBAcess();
            var Mysql = " SELECT B.CODEMPRESA, B.CODDEPARTAMENTO, DATE_FORMAT(B.DATABALANCO,'%d/%m/%Y') AS DATABALANCO, ";
            Mysql = Mysql + " B.CODPRODUTO, P.NOME AS NOMEPRODUTO, P.UNIDADE, B.LOTE, DATE_FORMAT(B.VALIDADE,'%d/%m/%Y') AS VALIDADE, B.QUANTIDADE ";
            Mysql = Mysql + " FROM balanco AS B ";
            Mysql = Mysql + " INNER JOIN produtos AS P ON B.CODPRODUTO = P.CODPRODUTO ";

            Mysql = Mysql + " WHERE B.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND B.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND B.DATABALANCO = @DATABALANCO ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATABALANCO", Convert.ToDateTime(databalanco));

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectRel(int codempresa, int coddepartamento, string databalanco)
        {
            var db = new DBAcess();
            var Mysql = " SELECT B.CODEMPRESA, B.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, DATE_FORMAT(B.DATABALANCO,'%d/%m/%Y') AS DATABALANCO, ";
            Mysql = Mysql + " B.CODPRODUTO, P.NOME AS NOMEPRODUTO, B.QUANTIDADE ";
            Mysql = Mysql + " FROM balanco AS B ";
            Mysql = Mysql + " INNER JOIN produtos AS P ON B.CODPRODUTO = P.CODPRODUTO ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = B.CODDEPARTAMENTO ";

            Mysql = Mysql + " WHERE B.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND B.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND B.DATABALANCO = @DATABALANCO ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATABALANCO", Convert.ToDateTime(databalanco));

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(int codempresa, int coddepartamento, string databalanco, int codproduto)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Balanco ";
            Mysql = Mysql + " WHERE CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND DATABALANCO = @DATABALANCO ";
            Mysql = Mysql + " AND CODPRODUTO = @CODPRODUTO;";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATABALANCO", Convert.ToDateTime(databalanco));
            db.AddParameter("@CODPRODUTO", codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO Balanco( " +
                                     " CODEMPRESA, CODDEPARTAMENTO, DATABALANCO, CODPRODUTO, QUANTIDADE, RESPINCLUSAO,  " +
                                     " DATAINCLUSAO " +
                 ") ";
            Mysql = Mysql + " VALUES(" +
                                    " @CODEMPRESA, @CODDEPARTAMENTO, @DATABALANCO, @CODPRODUTO, @QUANTIDADE,  " +
                                    " @RESPINCLUSAO, @DATAINCLUSAO " +
                "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@DATABALANCO", Convert.ToDateTime(Databalanco));
            db.AddParameter("@CODPRODUTO", Codproduto);
            //db.AddParameter("@LOTE", Lote);
            //db.AddParameter("@VALIDADE", Convert.ToDateTime(Validade));
            db.AddParameter("@QUANTIDADE", Quantidade);
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
            var Mysql = " UPDATE Balanco ";
            Mysql = Mysql + " SET " +
                               " CODEMPRESA = @CODEMPRESA, CODDEPARTAMENTO = @CODDEPARTAMENTO, DATABALANCO = @DATABALANCO, CODPRODUTO = @CODPRODUTO, " +
                               " QUANTIDADE = @QUANTIDADE, " +
                               " RESPALTERACAO = @RESPALTERACAO, DATAALTERACAO = @DATAALTERACAO ";

            Mysql = Mysql + " WHERE CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND DATABALANCO = @DATABALANCO ";
            Mysql = Mysql + " AND CODPRODUTO = @CODPRODUTO;";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@DATABALANCO", Convert.ToDateTime(Databalanco));
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@LOTE", Lote);
            
            db.AddParameter("@QUANTIDADE", Quantidade);
            db.AddParameter("@RESPALTERACAO", Respinclusao);
            db.AddParameter("@DATAALTERACAO", Convert.ToDateTime(Datainclusao));

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

        public bool Delete(int codempresa, int coddepartamento, string databalanco, int codproduto)
        {
            var db = new DBAcess();
            var Mysql = " DELETE FROM Balanco ";

            Mysql = Mysql + " WHERE CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND DATABALANCO = @DATABALANCO ";
            Mysql = Mysql + " AND CODPRODUTO = @CODPRODUTO";

            db.CommandText = Mysql;
            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATABALANCO", Convert.ToDateTime(databalanco));
            db.AddParameter("@CODPRODUTO", codproduto);

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int InsertAccess(int codempresa, int coddepartamento, string nomedepartamento, string databalanco, int codproduto, string nomeproduto, string quantidade)
        {
            var db = new DBAcessOleDB();
            var Mysql = " INSERT INTO Balanco( ";
            Mysql = Mysql + "CODEMPRESA, CODDEPARTAMENTO, NOMEDEPARTAMENTO, DATABALANCO, CODPRODUTO, NOMEPRODUTO, QUANTIDADE ";
           
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + "@CODEMPRESA, @CODDEPARTAMENTO, @NOMEDEPARTAMENTO, @DATABALANCO, @CODPRODUTO, @NOMEPRODUTO, @QUANTIDADE ";
           
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@NOMEDEPARTAMENTO", nomedepartamento);
            db.AddParameter("@DATABALANCO", databalanco);
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
