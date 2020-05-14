using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;

namespace Atencao_Assistida.Classes.Mysql
{
    [DataObject(true)]
    public class Saida_Padrao
    {

        private int Codsaidapadrao { get; set; }
        private int Codempresa { get; set; }
        private int Coddepartamento { get; set; }
        private int Codunidade { get; set; }
        private string Datacadastro { get; set; }
        

        public Saida_Padrao(int codsaidapadrao, int codempresa, int coddepartamento, int codunidade, string datacadastro)
        {

            Codsaidapadrao = codsaidapadrao;
            Codempresa = codempresa;
            Coddepartamento = coddepartamento;
            Codunidade = codunidade;
            Datacadastro = datacadastro;

        }

        public Saida_Padrao()
        {

        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO saida_padrao(";
            Mysql = Mysql + " CODEMPRESA, CODDEPARTAMENTO, CODUNIDADE, DATACADASTRO ";

            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODEMPRESA, @CODDEPARTAMENTO, @CODUNIDADE, @DATACADASTRO ";
            Mysql = Mysql + "); ";

            Mysql = Mysql + " SELECT MAX(CODSAIDAPADRAO) FROM saida_padrao ";
            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@CODUNIDADE", Codunidade);
            db.AddParameter("@DATACADASTRO", Convert.ToDateTime(Datacadastro));
           


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
            const string update = " UPDATE saida_padrao ";
            const string set = " SET" +
                               " CODEMPRESA = @CODEMPRESA, CODDEPARTAMENTO = @CODDEPARTAMENTO, CODUNIDADE = @CODUNIDADE, DATACADASTRO = @DATACADASTRO";
            const string where = " WHERE CODSAIDAPADRAO = @CODSAIDAPADRAO;";
            db.CommandText = update + set + where;

            db.AddParameter("@CODSAIDAPADRAO", Codsaidapadrao);
            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@CODUNIDADE", Codunidade);
            db.AddParameter("@DATACADASTRO", Convert.ToDateTime(Datacadastro));

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

        public int InsertAccess(int codsaidapadrao, int codempresa, int coddepartamento, int codunidade, string datacadastro)
        {
            var db = new DBAcessOleDB();
            var Mysql = " INSERT INTO saida_padrao(";
            Mysql = Mysql + " CODEMPRESA, CODDEPARTAMENTO, CODUNIDADE, DATACADASTRO ";
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODEMPRESA, @CODDEPARTAMENTO, @CODUNIDADE, @DATACADASTRO ";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODSAIDAPADRAO", Codsaidapadrao);
            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@CODUNIDADE", Codunidade);
            db.AddParameter("@DATACADASTRO", Convert.ToDateTime(Datacadastro));

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
            var Mysql = " SELECT SP.CODSAIDAPADRAO, SP.CODEMPRESA, E.NOME AS NOMEEMPRESA, SP.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, SP.CODUNIDADE, U.NOME AS NOMEUNIDADE, DATE_FORMAT(SP.DATACADASTRO, '%d/%m/%Y') AS DATACADASTRO ";
            Mysql = Mysql + " FROM saida_padrao SP ";
            Mysql = Mysql + " INNER JOIN empresa E ON E.CODEMPRESA = SP.CODEMPRESA ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = SP.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN unidade U ON U.CODUNIDADE = SP.CODUNIDADE ";


            Mysql = Mysql + " WHERE CODSAIDAPADRAO = @CODSAIDAPADRAO ";
            db.CommandText = Mysql;
            db.AddParameter("@CODSAIDAPADRAO", id);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        public void DeleteSaida(int id)
        {
            var db = new DBAcess();
            var Mysql = " DELETE FROM saida_padrao ";
            Mysql = Mysql + " WHERE CODSAIDAPADRAO = @CODSAIDAPADRAO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODSAIDAPADRAO", id);

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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectRel(string pedido, string departamento)
        {
            var db = new DBAcess();
            var Mysql = " SELECT S.CODSAIDA, S.CODEMPRESA, S.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, S.CODUNIDADE, U.NOME AS NOMEUNIDADE, PE.SOLICITANTE, ";
            Mysql = Mysql + " S.NUMEROPEDIDO, DATE_FORMAT(S.DATAENTREGA, '%d/%m/%Y') AS DATAENTREGA,  ";
            Mysql = Mysql + " SI.CODPRODUTO, P.NOME AS NOMEPRODUTO, SI.SOLICITADO, SI.ENTREGUE, ";
            Mysql = Mysql + " S.RESPINCLUSAO, DATE_FORMAT(S.DATAINCLUSAO, '%d/%m/%Y') AS DATAINCLUSAO ";
            Mysql = Mysql + " FROM saida_padrao S ";
            Mysql = Mysql + " INNER JOIN saida_padrao_item SI ON SI.CODSAIDA = S.CODSAIDA ";
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
        public static MySqlDataReader Select(int codempresa, int coddepartamento)
        {
            var db = new DBAcess();
            var Mysql = " SELECT SP.CODSAIDAPADRAO, SP.CODEMPRESA, E.NOME AS NOMEEMPRESA, SP.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, SP.CODUNIDADE, U.NOME AS NOMEUNIDADE, SP.DATACADASTRO ";
            Mysql = Mysql + " FROM saida_padrao SP ";
            Mysql = Mysql + " INNER JOIN empresa E ON E.CODEMPRESA = SP.CODEMPRESA ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = SP.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN unidade U ON U.CODUNIDADE = SP.CODUNIDADE ";

            Mysql = Mysql + " WHERE SP.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND SP.CODDEPARTAMENTO = @CODDEPARTAMENTO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(int codigo, int codempresa, int coddepartamento)
        {
            var db = new DBAcess();
            var Mysql = " SELECT SP.CODSAIDAPADRAO, SP.CODEMPRESA, E.NOME AS NOMEEMPRESA, SP.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, SP.CODUNIDADE, U.NOME AS NOMEUNIDADE, SP.DATACADASTRO ";
            Mysql = Mysql + " FROM saida_padrao SP ";
            Mysql = Mysql + " INNER JOIN empresa E ON E.CODEMPRESA = SP.CODEMPRESA ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = SP.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN unidade U ON U.CODUNIDADE = SP.CODUNIDADE ";

            Mysql = Mysql + " WHERE SP.CODSAIDAPADRAO = @CODSAIDAPADRAO ";
            Mysql = Mysql + " AND SP.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND SP.CODDEPARTAMENTO = @CODDEPARTAMENTO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODSAIDAPADRAO", codigo);
            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(int codempresa, int coddepartamento, string valor)
        {
            var db = new DBAcess();
            var Mysql = " SELECT SP.CODSAIDAPADRAO, SP.CODEMPRESA, E.NOME AS NOMEEMPRESA, SP.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, SP.CODUNIDADE, U.NOME AS NOMEUNIDADE, DATE_FORMAT(SP.DATACADASTRO, '%d/%m/%Y') AS DATACADASTRO ";
            Mysql = Mysql + " FROM saida_padrao SP ";
            Mysql = Mysql + " INNER JOIN empresa E ON E.CODEMPRESA = SP.CODEMPRESA ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = SP.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN unidade U ON U.CODUNIDADE = SP.CODUNIDADE ";

            Mysql = Mysql + " WHERE SP.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND SP.CODDEPARTAMENTO = @CODDEPARTAMENTO ";

            if (valor != "")
            {
                Mysql = Mysql + " AND U.NOME LIKE @valor ";
                valor = '%' + valor + "%";
            }

            Mysql = Mysql + " ORDER BY U.NOME ASC; ";

            db.CommandText = Mysql;
            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@valor", valor);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        public int BuscaUltimoSaidaPadrao(int codempresa, int coddepartamento)
        {
            var db = new DBAcess();
            var Mysql = " SELECT MAX(CODSAIDAPADRAO) AS ULTIMO ";

            Mysql = Mysql + " FROM saida_padrao ";
            Mysql = Mysql + " WHERE CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);

            try
            {
                if (db.ExecuteScalar().ToString() != "")
                {
                    return Convert.ToInt32(db.ExecuteScalar());
                }
                else
                {
                    return 0;
                }

            }
            finally
            {
                db.Dispose();
            }
        }



    }
}
