using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencao_Assistida.Classes.Mysql
{
    [DataObject(true)]
    public class Saida_Padrao_Item
    {

        private int Codsaidapadrao { get; set; }
        private int Codempresa { get; set; }
        private int Coddepartamento { get; set; }
        private int Codproduto { get; set; }
        private string Quantidade { get; set; }


        public Saida_Padrao_Item(int codsaidapadrao, int codempresa, int coddepartamento, int codproduto, string quantidade)
        {

            Codsaidapadrao = codsaidapadrao;
            Codempresa = codempresa;
            Coddepartamento = coddepartamento;
            Codproduto = codproduto;
            Quantidade = quantidade;

        }

        public Saida_Padrao_Item()
        {

        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO saida_padrao_item(";
            Mysql = Mysql + " CODSAIDAPADRAO, CODEMPRESA, CODDEPARTAMENTO, CODPRODUTO, QUANTIDADE ";

            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODSAIDAPADRAO, @CODEMPRESA, @CODDEPARTAMENTO, @CODPRODUTO, @QUANTIDADE ";
            Mysql = Mysql + "); ";

           
            db.CommandText = Mysql;

            db.AddParameter("@CODSAIDAPADRAO", Codsaidapadrao);
            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@QUANTIDADE", Quantidade);



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
            const string update = " UPDATE saida_padrao_item ";
            const string set = " SET" +
                               " CODEMPRESA = @CODEMPRESA, CODDEPARTAMENTO = @CODDEPARTAMENTO, CODPRODUTO = @CODPRODUTO, QUANTIDADE = @QUANTIDADE";
            const string where = " WHERE CODSAIDAPADRAO = @CODSAIDAPADRAO;";
            db.CommandText = update + set + where;

            db.AddParameter("@CODSAIDAPADRAO", Codsaidapadrao);
            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@QUANTIDADE", Convert.ToDateTime(Quantidade));

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

        public int InsertAccess(int codsaidapadrao, int codempresa, int coddepartamento, int Codproduto, string Quantidade)
        {
            var db = new DBAcessOleDB();
            var Mysql = " INSERT INTO saida_padrao(";
            Mysql = Mysql + " CODEMPRESA, CODDEPARTAMENTO, CODPRODUTO, Quantidade ";
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODEMPRESA, @CODDEPARTAMENTO, @CODPRODUTO, @Quantidade ";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODSAIDAPADRAO", Codsaidapadrao);
            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@Codproduto", Codproduto);
            db.AddParameter("@Quantidade", Convert.ToDateTime(Quantidade));

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
        public static MySqlDataReader Select(int codigo)
        {
            var db = new DBAcess();
            var Mysql = " SPI.CODSAIDAPADRAO, SPI.CODEMPRESA, E.NOME AS NOMEEMPRESA, SPI.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, ";
            Mysql = Mysql + " SPI.CODPRODUTO, P.NOME AS NOMEPRODUTO, SPI.QUANTIDADE ";
            Mysql = Mysql + " FROM saida_padrao_item SPI ";
            Mysql = Mysql + " INNER JOIN empresa E ON E.CODEMPRESA = SPI.CODEMPRESA ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = SPI.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN produtos P ON P.CODPRODUTO = SPI.CODPRODUTO AND P.CODDEPARTAMENTO = SPI.CODDEPARTAMENTO ";

            Mysql = Mysql + " WHERE CODSAIDAPADRAO = @CODSAIDAPADRAO ";
            db.CommandText = Mysql;
            db.AddParameter("@CODSAIDAPADRAO", codigo);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        public void Delete(int codigo)
        {
            var db = new DBAcess();
            var Mysql = " DELETE FROM saida_padrao_item ";
            Mysql = Mysql + " WHERE CODSAIDAPADRAO = @CODSAIDAPADRAO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODSAIDAPADRAO", codigo);

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
            var Mysql = " SELECT S.CODSAIDA, S.CODEMPRESA, S.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, S.Codproduto, U.NOME AS NOMEUNIDADE, PE.SOLICITANTE, ";
            Mysql = Mysql + " S.NUMEROPEDIDO, DATE_FORMAT(S.DATAENTREGA, '%d/%m/%Y') AS DATAENTREGA,  ";
            Mysql = Mysql + " SI.CODPRODUTO, P.NOME AS NOMEPRODUTO, SI.SOLICITADO, SI.ENTREGUE, ";
            Mysql = Mysql + " S.RESPINCLUSAO, DATE_FORMAT(S.DATAINCLUSAO, '%d/%m/%Y') AS DATAINCLUSAO ";
            Mysql = Mysql + " FROM saida_padrao S ";
            Mysql = Mysql + " INNER JOIN saida_padrao_item SI ON SI.CODSAIDA = S.CODSAIDA ";
            Mysql = Mysql + " INNER JOIN produtos P ON P.CODPRODUTO = SI.CODPRODUTO ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = S.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN unidade U ON U.Codproduto = S.Codproduto ";
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
        public static MySqlDataReader Select(int codigo, int codempresa, int coddepartamento)
        {
            var db = new DBAcess();
            var Mysql = " SELECT SPI.CODSAIDAPADRAO, SPI.CODEMPRESA, E.NOME AS NOMEEMPRESA, SPI.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, ";
            Mysql = Mysql + " SPI.CODPRODUTO, P.NOME AS NOMEPRODUTO, SPI.QUANTIDADE ";
            Mysql = Mysql + " FROM saida_padrao_item SPI ";
            Mysql = Mysql + " INNER JOIN empresa E ON E.CODEMPRESA = SPI.CODEMPRESA ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = SPI.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN produtos P ON P.CODPRODUTO = SPI.CODPRODUTO AND P.CODDEPARTAMENTO = SPI.CODDEPARTAMENTO ";

            Mysql = Mysql + " WHERE SPI.CODSAIDAPADRAO = @CODSAIDAPADRAO ";
            Mysql = Mysql + " AND SPI.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND SPI.CODDEPARTAMENTO = @CODDEPARTAMENTO ";

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
            var Mysql = " SELECT SP.CODSAIDAPADRAO, SP.CODEMPRESA, E.NOME AS NOMEEMPRESA, SP.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, SP.Codproduto, U.NOME AS NOMEUNIDADE, DATE_FORMAT(SP.Quantidade, '%d/%m/%Y') AS Quantidade ";
            Mysql = Mysql + " FROM saida_padrao SP ";
            Mysql = Mysql + " INNER JOIN empresa E ON E.CODEMPRESA = SP.CODEMPRESA ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = SP.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN unidade U ON U.Codproduto = SP.Codproduto ";

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
            var Mysql = " SELECT MAX(CODPEDIDO) AS ULTIMO ";

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
