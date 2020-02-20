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
    public class Entrada_item
    {
        private int Codentrada { get; set; }
        private string Numeronota { get; set; }
        private string Serie { get; set; }
        private int Codproduto { get; set; }
        private string Lote { get; set; }
        private string Validade { get; set; }
        private string Quantidade { get; set; }
        private int Mes { get; set; }
        private int Ano { get; set; }

        public Entrada_item(int codentrada, string numeronota, string serie, int codproduto, string lote, string validade, string quantidade, int mes, int ano)
        {
            Codentrada = codentrada;
            Numeronota = numeronota;
            Serie = serie;
            Codproduto = codproduto;
            Lote = lote;
            Validade = validade;
            Quantidade = quantidade;
            Mes = mes;
            Ano = ano;

        }

        public Entrada_item(int codentrada, string numeronota, string serie)
        {
            Codentrada = codentrada;
            Numeronota = numeronota;
            Serie = serie;

        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO Entrada_item(";
            Mysql = Mysql + " CODENTRADA, NUMERONOTA, SERIE, CODPRODUTO, LOTE, VALIDADE, QUANTIDADE, MES, ANO ";
            Mysql = Mysql + ") ";

            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODENTRADA, @NUMERONOTA, @SERIE, @CODPRODUTO, @LOTE, @VALIDADE, @QUANTIDADE, @MES, @ANO ";
            Mysql = Mysql + "); ";

            //Mysql = Mysql + " SELECT MAX(CODENTRADA) FROM Entrada_item ";

            db.CommandText = Mysql;

            db.AddParameter("@CODENTRADA", Codentrada);
            db.AddParameter("@NUMERONOTA", Numeronota);
            db.AddParameter("@SERIE", Serie);
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@LOTE", Lote);
            db.AddParameter("@VALIDADE", Validade);
            db.AddParameter("@QUANTIDADE", Convert.ToDecimal(Quantidade));
            db.AddParameter("@MES", Mes);
            db.AddParameter("@ANO", Ano);


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
            var Mysql = " UPDATE Entrada_item ";
            Mysql = Mysql + " SET";
            Mysql = Mysql + " NUMERONOTA = @NUMERONOTA, SERIE = @SERIE, CODPRODUTO = @CODPRODUTO, LOTE = @LOTE, VALIDADE = @VALIDADE, QUANTIDADE = @QUANTIDADE ";

            Mysql = Mysql + " WHERE CODENTRADA = @CODENTRADA ";
            Mysql = Mysql + " AND NUMERONOTA = @NUMERONOTA ";
            Mysql = Mysql + " AND SERIE = @SERIE ";
            Mysql = Mysql + " AND CODPRODUTO = @CODPRODUTO ";

            db.CommandText = Mysql;

            db.AddParameter("@CODENTRADA", Codentrada);
            db.AddParameter("@NUMERONOTA", Numeronota);
            db.AddParameter("@SERIE", Serie);
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@LOTE", Lote);
            db.AddParameter("@VALIDADE", Validade);
            db.AddParameter("@QUANTIDADE", Convert.ToDecimal(Quantidade));

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

        public bool UpdateNumero()
        {
            var db = new DBAcess();
            var Mysql = " UPDATE Entrada_item ";
            Mysql = Mysql + " SET";
            Mysql = Mysql + " CODENTRADA = @CODENTRADA ";
            Mysql = Mysql + " WHERE NUMERONOTA = @NUMERONOTA";

            db.CommandText = Mysql;

            db.AddParameter("@CODENTRADA", Codentrada);
            db.AddParameter("@NUMERONOTA", Numeronota);

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

        public void Delete(string Numeronota, int Codproduto, int Mes, int Ano)
        {
            var db = new DBAcess();
            var Mysql = " DELETE FROM Entrada_item ";
            Mysql = Mysql + " WHERE NUMERONOTA = @NUMERONOTA ";
            Mysql = Mysql + " AND CODPRODUTO = @CODPRODUTO ";
            Mysql = Mysql + " AND ANO = @ANO ";
            Mysql = Mysql + " AND MES = @MES ";

            db.CommandText = Mysql;

            db.AddParameter("@NUMERONOTA", Numeronota);
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@MES", Mes);
            db.AddParameter("@ANO", Ano);

            try
            {
                db.ExecuteNonQuery();
            }
            catch
            {

            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(string Numero)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Entrada_item ";
            Mysql = Mysql + " WHERE NUMERONOTA = @NUMERONOTA ";


            db.CommandText = Mysql;
            db.AddParameter("@NUMERONOTA", Numero);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(int codentrada, string numero)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";

            const string from = " FROM Entrada_item ";
            const string where = " WHERE CODENTRADA = @CODENTRADA ";
            const string and = " AND NUMERONOTA = @NUMERONOTA ";

            db.CommandText = select + from + where + and;
            db.AddParameter("@CODENTRADA", codentrada);
            db.AddParameter("@NUMERONOTA", numero);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader BuscaItem(int codentrada, string numero, int codproduto)
        {
            var db = new DBAcess();
            var Mysql = " SELECT CODPRODUTO ";

            Mysql = Mysql + " FROM Entrada_item ";
            Mysql = Mysql + " WHERE CODENTRADA = @CODENTRADA ";
            Mysql = Mysql + " AND NUMERONOTA = @NUMERONOTA ";
            Mysql = Mysql + " AND CODPRODUTO = @CODPRODUTO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODENTRADA", codentrada);
            db.AddParameter("@NUMERONOTA", numero);
            db.AddParameter("@CODPRODUTO", codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectItem(int codentrada, string numero, string serie, int codproduto)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";

            Mysql = Mysql + " FROM Entrada_item ";
            Mysql = Mysql + " WHERE CODENTRADA = @CODENTRADA ";
            Mysql = Mysql + " AND NUMERONOTA = @NUMERONOTA ";
            Mysql = Mysql + " AND SERIE = @SERIE ";
            Mysql = Mysql + " AND CODPRODUTO = @CODPRODUTO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODENTRADA", codentrada);
            db.AddParameter("@NUMERONOTA", numero);
            db.AddParameter("@SERIE", serie);
            db.AddParameter("@CODPRODUTO", codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet SelectTodos()
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Entrega ";
            const string where = "  ";
            const string order = " ORDER BY DATAENTREGA ASC; ";
            db.CommandText = select + from + where + order;
            var ds = db.ExecuteDataSet();
            return ds;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectN(string Numero, string serie, string fornecedor)
        {
            var db = new DBAcess();

            var Mysql = " SELECT E.CODPRODUTO, P.NOME, P.DESCRICAO, E.QUANTIDADE, I.CODPRODUTOFORNECEDOR, I.NOMEPRODUTOFORNECEDOR ";
            Mysql = Mysql + " FROM entrada_item AS E ";
            Mysql = Mysql + " INNER JOIN produtos AS  P ON P.CODPRODUTO = E.CODPRODUTO ";
            Mysql = Mysql + " INNER JOIN entrada_item_vinculo AS I ON I.CODPRODUTO = P.CODPRODUTO ";

            Mysql = Mysql + " WHERE E.NUMERONOTA = @NUMERONOTA ";
            Mysql = Mysql + " AND E.SERIE = @SERIE ";
            Mysql = Mysql + " AND I.CODFORNECEDOR = @CODFORNECEDOR ";

            Mysql = Mysql + " ORDER BY E.CODPRODUTO ";

            db.CommandText = Mysql;
            db.AddParameter("@NUMERONOTA", Numero);
            db.AddParameter("@SERIE", serie);
            db.AddParameter("@CODFORNECEDOR", fornecedor);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

    }
}