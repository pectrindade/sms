using System;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using Atencao_Assistida.Classes.DAL;

namespace Atencao_Assistida.Classes.Mysql
{
    [DataObject(true)]
    public class Saida
    {

        private int Codsaida { get; set; }
        private int Codempresa { get; set; }
        private int Coddepartamento { get; set; }
        private int Codunidade { get; set; }
        private string Numeropedido { get; set; }
        private string Dataentrega { get; set; }
        private string Respinclusao { get; set; }
        private string Datainclusao { get; set; }
        private string Respalteracao { get; set; }
        private string Dataalteracao { get; set; }
        private string Excluido { get; set; }


        public Saida(int codsaida, int codempresa, int coddepartamento, int codunidade, string numeropedido, string dataentrega, string respinclusao,
            string datainclusao, string respalteracao, string dataalteracao, string excluido)
        {

            Codsaida = codsaida;
            Codempresa = codempresa;
            Coddepartamento = coddepartamento;
            Codunidade = codunidade;
            Numeropedido = numeropedido;
            Dataentrega = dataentrega;
            Respinclusao = respinclusao;
            Datainclusao = datainclusao;
            Respalteracao = respalteracao;
            Dataalteracao = dataalteracao;
            Excluido = excluido;

        }

        public Saida()
        {

        }

        public int Insert()
        {
            var db = new DBAcess();
            const string insert = " INSERT INTO Saida(" +
                                  " CODEMPRESA, CODDEPARTAMENTO, CODUNIDADE, NUMEROPEDIDO, DATAENTREGA, RESPINCLUSAO, DATAINCLUSAO, EXCLUIDO " +

                                  ") ";
            const string values = " VALUES(" +
                                  " @CODEMPRESA, @CODDEPARTAMENTO, @CODUNIDADE, @NUMEROPEDIDO, @DATAENTREGA, @RESPINCLUSAO, @DATAINCLUSAO, @EXCLUIDO " +
                                  "); ";

            const string select = " SELECT MAX(CODSAIDA) FROM Saida ";
            db.CommandText = insert + values + select;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@CODUNIDADE", Codunidade);
            db.AddParameter("@NUMEROPEDIDO", Numeropedido);
            db.AddParameter("@DATAENTREGA", Convert.ToDateTime(Dataentrega));
            db.AddParameter("@RESPINCLUSAO", Respinclusao);
            db.AddParameter("@DATAINCLUSAO", Convert.ToDateTime(Datainclusao));
            db.AddParameter("@EXCLUIDO", Excluido);


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
            const string update = " UPDATE Saida ";
            const string set = " SET" +
                               " CODEMPRESA = @CODEMPRESA, CODDEPARTAMENTO = @CODDEPARTAMENTO, CODUNIDADE = @CODUNIDADE, NUMEROPEDIDO = @NUMEROPEDIDO," +
                               " DATAENTREGA = @DATAENTREGA, RESPALTERACAO = @RESPALTERACAO, DATAALTERACAO = @DATAALTERACAO, EXCLUIDO = @EXCLUIDO";
            const string where = " WHERE CODSAIDA = @CODSAIDA;";
            db.CommandText = update + set + where;

            db.AddParameter("@CODSAIDA", Codsaida);
            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@CODUNIDADE", Codunidade);
            db.AddParameter("@NUMEROPEDIDO", Numeropedido);
            db.AddParameter("@DATAENTREGA", Convert.ToDateTime(Dataentrega));
            db.AddParameter("@RESPALTERACAO", Respalteracao);
            db.AddParameter("@DATAALTERACAO", Convert.ToDateTime(Dataalteracao));
            db.AddParameter("@EXCLUIDO", Excluido);

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

        public int InsertAccess(int codsaida, int codempresa, int coddepartamento, string nomedepartamento, int codunidade, string nomeunidade,
        string solicitante, string numeropedido, string dataentrega, int codproduto, string nomeproduto, string solicitado,
        string entregue, string respinclusao, string datainclusao)
        {
            var db = new DBAcessOleDB();
            var Mysql = " INSERT INTO Saida(";
            Mysql = Mysql + " CODSAIDA, CODEMPRESA, CODDEPARTAMENTO, NOMEDEPARTAMENTO, CODUNIDADE, NOMEUNIDADE, SOLICITANTE, NUMEROPEDIDO, DATAENTREGA, ";
            Mysql = Mysql + " CODPRODUTO, NOMEPRODUTO, SOLICITADO, ENTREGUE, RESPINCLUSAO, DATAINCLUSAO ";
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODSAIDA, @CODEMPRESA, @CODDEPARTAMENTO, @NOMEDEPARTAMENTO, @CODUNIDADE, @NOMEUNIDADE, @SOLICITANTE, @NUMEROPEDIDO, @DATAENTREGA, ";
            Mysql = Mysql + " @CODPRODUTO, @NOMEPRODUTO, @SOLICITADO, @ENTREGUE, @RESPINCLUSAO, @DATAINCLUSAO ";
            Mysql = Mysql + "); ";


            db.CommandText = Mysql;

            db.AddParameter("@CODSAIDA", codsaida);
            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@NOMEDEPARTAMENTO", nomedepartamento);
            db.AddParameter("@CODUNIDADE", codunidade);
            db.AddParameter("@NOMEUNIDADE", nomeunidade);
            db.AddParameter("@SOLICITANTE", solicitante);
            db.AddParameter("@NUMEROPEDIDO", numeropedido);
            db.AddParameter("@DATAENTREGA", dataentrega);
            db.AddParameter("@CODPRODUTO", codproduto);
            db.AddParameter("@NOMEPRODUTO", nomeproduto);
            db.AddParameter("@SOLICITADO", solicitado);
            db.AddParameter("@ENTREGUE", entregue);
            db.AddParameter("@RESPINCLUSAO", respinclusao);
            db.AddParameter("@DATAINCLUSAO", datainclusao);




            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }

        public int InsertAccessSaidaPeriodo(int codempresa, string nomedeempresa, int coddepartamento, string nomedepartamento, int codsaida, string dataentrega, 
        int codunidade, string nomeunidade, string solicitante, string numeropedido, int codproduto, string nomeproduto, string quantidade)
        {
            var db = new DBAcessOleDB();
            var Mysql = " INSERT INTO SaidaPeriodo(";
            Mysql = Mysql + " CODEMPRESA, NOMEEMPRESA, CODDEPARTAMENTO, NOMEDEPARTAMENTO, CODSAIDA, DATASAIDA, CODUNIDADE, NOMEUNIDADE, SOLICITANTE, ";
            Mysql = Mysql + " NUMEROPEDIDO, CODPRODUTO, NOMEPRODUTO, QUANTIDADE ";
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODEMPRESA, @NOMEEMPRESA, @CODDEPARTAMENTO, @NOMEDEPARTAMENTO, @CODSAIDA, @DATASAIDA, @CODUNIDADE, @NOMEUNIDADE, @SOLICITANTE, ";
            Mysql = Mysql + " @NUMEROPEDIDO, @CODPRODUTO, @NOMEPRODUTO, @QUANTIDADE ";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@NOMEEMPRESA", nomedeempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@NOMEDEPARTAMENTO", nomedepartamento);
            db.AddParameter("@CODSAIDA", codsaida);
            db.AddParameter("@DATASAIDA", dataentrega);
            db.AddParameter("@CODUNIDADE", codunidade);
            db.AddParameter("@NOMEUNIDADE", nomeunidade);
            db.AddParameter("@SOLICITANTE", solicitante);
            db.AddParameter("@NUMEROPEDIDO", numeropedido);
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


        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(int id)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Saida ";
            const string where = " WHERE CODSAIDA = @CODSAIDA ";
            db.CommandText = select + from + where;
            db.AddParameter("@CODSAIDA", id);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        public void DeleteSaida(int codsaida)
        {
            var db = new DBAcess();
            var Mysql = " DELETE FROM Saida ";
            Mysql = Mysql + " WHERE CODSAIDA = @CODSAIDA ";

            db.CommandText = Mysql;
            db.AddParameter("@CODSAIDA", codsaida);

            try
            {
                db.ExecuteNonQuery();
                //return true;
            }
            catch
            {
               // return false;
            }
        }

        public void DeleteSaidaItens(int codsaida)
        {
            var db = new DBAcess();
            var Mysql = " DELETE FROM saida_item ";
            Mysql = Mysql + " WHERE CODSAIDA = @CODSAIDA ";

            db.CommandText = Mysql;
            db.AddParameter("@CODSAIDA", codsaida);

            try
            {
                db.ExecuteNonQuery();
                //return true;
            }
            catch
            {
                //return false;
            }
        }

        //ver se tem 
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader BuscaNota(string Numero, int coddepartamento)
        {
            var db = new DBAcess();
            var Mysql = " SELECT CODSAIDA ";

            Mysql = Mysql +" FROM Saida ";
            Mysql = Mysql + " WHERE NUMEROPEDIDO = @NUMEROPEDIDO ";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO ";

            db.CommandText = Mysql;
            db.AddParameter("@NUMEROPEDIDO", Numero);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectNota(string Numero)
        {
            var db = new DBAcess();
            const string select = " SELECT CODSAIDA, NUMEROPEDIDO, DATE_FORMAT(DATAENTREGA, '%d/%m/%Y') AS DATAENTREGA ";

            const string from = " FROM Saida ";
            const string where = " WHERE NUMEROPEDIDO = @NUMEROPEDIDO ";
            db.CommandText = select + from + where;
            db.AddParameter("@NUMEROPEDIDO", Numero);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectRel(string pedido, string departamento)
        {
            var db = new DBAcess();
            var Mysql = " SELECT S.CODSAIDA, S.CODEMPRESA, S.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, S.CODUNIDADE, U.NOME AS NOMEUNIDADE, PE.SOLICITANTE, ";
            Mysql = Mysql + " S.NUMEROPEDIDO, DATE_FORMAT(S.DATAENTREGA, '%d/%m/%Y') AS DATAENTREGA,  ";
            Mysql = Mysql + " SI.CODPRODUTO, P.NOME AS NOMEPRODUTO, SI.SOLICITADO, SI.ENTREGUE, ";
            Mysql = Mysql + " S.RESPINCLUSAO, DATE_FORMAT(S.DATAINCLUSAO, '%d/%m/%Y') AS DATAINCLUSAO ";
            Mysql = Mysql + " FROM saida S ";
            Mysql = Mysql + " INNER JOIN saida_item SI ON SI.CODSAIDA = S.CODSAIDA ";
            Mysql = Mysql + " INNER JOIN produtos P ON P.CODPRODUTO = SI.CODPRODUTO ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = S.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN unidade U ON U.CODUNIDADE = S.CODUNIDADE ";
            Mysql = Mysql + " INNER JOIN pedido PE ON PE.NUMEROPEDIDO = S.NUMEROPEDIDO AND PE.CODDEPARTAMENTO = S.CODDEPARTAMENTO ";

            Mysql = Mysql + " WHERE S.NUMEROPEDIDO = @NUMEROPEDIDO ";
            Mysql = Mysql + " AND S.CODDEPARTAMENTO = @CODDEPARTAMENTO ";

            db.CommandText = Mysql;
            db.AddParameter("@NUMEROPEDIDO", pedido);
            db.AddParameter("@CODDEPARTAMENTO", departamento);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Saida_Periodo(int codempresa, int coddepartamento, int codunidade, int codproduto, string dtinicial, string dtfinal)
        {
            var db = new DBAcess();
            var Mysql = " SELECT S.CODEMPRESA, E.NOME AS NOMEEMPRESA, S.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, S.CODSAIDA,  ";
            Mysql = Mysql + " DATE_FORMAT(S.DATAENTREGA, '%d/%m/%Y') AS DATASAIDA, S.CODUNIDADE, U.NOME AS NOMEUNIDADE, PE.SOLICITANTE,  ";
            Mysql = Mysql + " S.NUMEROPEDIDO, SI.CODPRODUTO, P.NOME AS NOMEPRODUTO, SI.ENTREGUE AS QUANTIDADE ";

            Mysql = Mysql + " FROM saida S ";
            Mysql = Mysql + " INNER JOIN empresa E ON S.CODEMPRESA = E.CODEMPRESA ";
            Mysql = Mysql + " INNER JOIN departamento D ON S.CODDEPARTAMENTO = D.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN unidade U ON S.CODUNIDADE = U.CODUNIDADE ";
            Mysql = Mysql + " INNER JOIN pedido PE ON S.NUMEROPEDIDO = PE.NUMEROPEDIDO ";
            Mysql = Mysql + " INNER JOIN saida_item SI ON S.CODSAIDA = SI.CODSAIDA ";
            Mysql = Mysql + " INNER JOIN produtos P ON SI.CODPRODUTO = P.CODPRODUTO ";

            Mysql = Mysql + " WHERE S.DATAENTREGA BETWEEN @DATAINICIAL AND @DATAFINAL ";
            Mysql = Mysql + " AND S.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND S.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND PE.TIPO = 0 ";

            if (codunidade != 0) { Mysql = Mysql + " AND S.CODUNIDADE = @CODUNIDADE "; }
            if (codproduto != 0) { Mysql = Mysql + " AND SI.CODPRODUTO = @CODPRODUTO "; }

            Mysql = Mysql + " ORDER BY S.NUMEROPEDIDO ";

            db.CommandText = Mysql;
            db.AddParameter("@DATAINICIAL", Convert.ToDateTime(dtinicial));
            db.AddParameter("@DATAFINAL", Convert.ToDateTime(dtfinal));
            db.AddParameter("@CODUNIDADE", codunidade);
            db.AddParameter("@CODPRODUTO", codproduto);
            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);

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

      

    }
}
