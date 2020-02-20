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
    public class Entrada
    {

        private int Codentrada { get; set; }
        private int Codempresa { get; set; }
        private int Coddepartamento { get; set; }
        private string Numeronota { get; set; }
        private string Serie { get; set; }
        private string Cfop { get; set; }
        private int Codfornecedor { get; set; }
        private string Dataemissao { get; set; }
        private string Datarecebimento { get; set; }
        private string Tipoentrega { get; set; }

        private string Respinclusao { get; set; }
        private string Datahorainclusao { get; set; }
        private string Respalteracao { get; set; }
        private string Datahoraalteracao { get; set; }
        private string Excluido { get; set; }


        public Entrada(int codentrada, int codempresa, int coddepartamento, string numeronota, string serie, string cfop, 
            int codfornecedor, string dataemissao, string datarecebimento, string tipoentrega)
        {
            Codentrada = codentrada;
            Codempresa = codempresa;
            Coddepartamento = coddepartamento;
            Numeronota = numeronota;
            Serie = serie;
            Cfop = cfop;
            Codfornecedor = codfornecedor;
            Dataemissao = dataemissao;
            Datarecebimento = datarecebimento;
            Tipoentrega = tipoentrega;

            //Respinclusao = respinclusao;
            //Datahorainclusao = datahorainclusao;
            //Respalteracao = respalteracao;
            //Datahoraalteracao = datahoraalteracao;
            //Excluido = excluido;

        }

        public Entrada()
        {
            

        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO Entrada(";
            Mysql = Mysql + " CODEMPRESA, CODDEPARTAMENTO, NUMERONOTA, SERIE, CFOP, CODFORNECEDOR, DATAEMISSAO, DATARECEBIMENTO, TIPOENTREGA ";
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODEMPRESA, @CODDEPARTAMENTO, @NUMERONOTA, @SERIE, @CFOP, @CODFORNECEDOR, @DATAEMISSAO, @DATARECEBIMENTO, @TIPOENTREGA ";
            Mysql = Mysql + "); ";
                        
            Mysql = Mysql + " SELECT MAX(CODENTRADA) FROM Entrada ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@NUMERONOTA", Numeronota);
            db.AddParameter("@SERIE", Serie);
            db.AddParameter("@CFOP", Cfop);
            db.AddParameter("@CODFORNECEDOR", Codfornecedor);
            db.AddParameter("@DATAEMISSAO", Convert.ToDateTime(Dataemissao));
            db.AddParameter("@DATARECEBIMENTO", Convert.ToDateTime(Datarecebimento));
            db.AddParameter("@TIPOENTREGA", Tipoentrega);


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
            var Mysql = " UPDATE Entrada ";
            Mysql = Mysql + " SET";
            Mysql = Mysql + " CODEMPRESA = @CODEMPRESA, CODDEPARTAMENTO = @CODDEPARTAMENTO, NUMERONOTA = @NUMERONOTA, SERIE = @SERIE, CFOP = @CFOP, ";
            Mysql = Mysql + " CODFORNECEDOR = @CODFORNECEDOR, DATAEMISSAO = @DATAEMISSAO, DATARECEBIMENTO = @DATARECEBIMENTO, TIPOENTREGA = @TIPOENTREGA ";

            Mysql = Mysql + " WHERE CODENTRADA = @ID;";

            db.CommandText = Mysql;
            db.AddParameter("@ID", Codentrada);
            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@NUMERONOTA", Numeronota);
            db.AddParameter("@SERIE", Serie);
            db.AddParameter("@CFOP", Cfop);
            db.AddParameter("@CODFORNECEDOR", Codfornecedor);
            db.AddParameter("@DATAEMISSAO", Convert.ToDateTime(Dataemissao));
            db.AddParameter("@DATARECEBIMENTO", Convert.ToDateTime(Datarecebimento));
            db.AddParameter("@TIPOENTREGA", Tipoentrega);

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

        public int InsertAccess(int codentrada, int codempresa, string nomeempresa, int coddepartamento, string nomedepartamento, string numeronota, 
            string serie, string cfop, int codfornecedor, string nomefornecedor, string emissao, string recebimento, int codproduto, string nomeproduto, string quantidade)
        {
            var db = new DBAcessOleDB();

            var Mysql = " INSERT INTO Entrada(";
            Mysql = Mysql + " CODENTRADA, CODEMPRESA, NOMEEMPRESA, CODDEPARTAMENTO, NOMEDEPARTAMENTO, NUMERONOTA, SERIE, CFOP,  ";
            Mysql = Mysql + " CODFORNECEDOR, NOMEFORNECEDOR, EMISSAO, RECEBIMENTO, CODPRODUTO, NOMEPRODUTO, QUANTIDADE   ";
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODENTRADA, @CODEMPRESA, @NOMEEMPRESA, @CODDEPARTAMENTO, @NOMEDEPARTAMENTO, @NUMERONOTA, @SERIE, @CFOP,  ";
            Mysql = Mysql + " @CODFORNECEDOR, @NOMEFORNECEDOR, @EMISSAO, @RECEBIMENTO, @CODPRODUTO, @NOMEPRODUTO, @QUANTIDADE   ";
            Mysql = Mysql + "); ";
                        
            db.CommandText = Mysql;

            db.AddParameter("@CODENTRADA", codentrada);
            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@NOMEEMPRESA", nomeempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@NOMEDEPARTAMENTO", nomedepartamento);
            db.AddParameter("@NUMERONOTA", numeronota);
            db.AddParameter("@SERIE", serie);
            db.AddParameter("@CFOP", cfop);
            db.AddParameter("@CODFORNECEDOR", codfornecedor);
            db.AddParameter("@NOMEFORNECEDOR", nomefornecedor);

            db.AddParameter("@EMISSAO", emissao);
            db.AddParameter("@RECEBIMENTO", recebimento);

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
            const string from = " FROM Entrada ";
            const string where = " WHERE CODENTRADA = @id ";
            db.CommandText = select + from + where;
            db.AddParameter("@id", id);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader BuscaNota(string Numero)
        {
            var db = new DBAcess();
            var Mysql = " SELECT CODENTRADA ";
            Mysql = Mysql + " FROM Entrada ";
            Mysql = Mysql + " WHERE NUMERONOTA = @NUMERONOTA ";
            db.CommandText = Mysql;

            db.AddParameter("@NUMERONOTA", Numero);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectNota(string numero, string serie)
        {
            var db = new DBAcess();
            var Mysql = " SELECT CODENTRADA, NUMERONOTA, SERIE, CFOP, DATE_FORMAT(DATAEMISSAO, '%d/%m/%Y') AS DATAEMISSAO, ";
            Mysql = Mysql + " DATE_FORMAT(DATARECEBIMENTO, '%d/%m/%Y') AS DATAENTREGA, CODFORNECEDOR, TIPOENTREGA ";


            Mysql = Mysql + " FROM Entrada ";
            Mysql = Mysql + " WHERE NUMERONOTA = @NUMERONOTA ";
            Mysql = Mysql + " AND SERIE = @SERIE ";

            db.CommandText = Mysql;
            db.AddParameter("@NUMERONOTA", numero);
            db.AddParameter("@SERIE", serie);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader PesquisaNota(string por, string valor)
        {

            var db = new DBAcess();
            string Mysql = " SELECT E.CODENTRADA, E.CODEMPRESA, E.CFOP, E.NUMERONOTA, E.SERIE, ";
            Mysql = Mysql + " E.CODFORNECEDOR, F.NOME AS NOMEFORNECEDOR, ";
            Mysql = Mysql + " DATE_FORMAT(E.DATARECEBIMENTO,'%d/%m/%Y') AS DATARECEBIMENTO ";
            Mysql = Mysql + " FROM ENTRADA  AS E  ";
            Mysql = Mysql + " INNER JOIN FORNECEDOR as F on F.CODFORNECEDOR = E.CODFORNECEDOR ";


            switch (por)
            {
                case "nota":
                    {
                        Mysql = Mysql + " WHERE E.NUMERONOTA LIKE CONCAT(@valor)";
                        valor = '%' + valor + "%";
                    }
                    break;
                case "fornecedor":
                    {
                        Mysql = Mysql + " WHERE F.NOME LIKE CONCAT(@valor)";
                        valor = '%' + valor + "%";
                    }
                    break;
                case "recebimento":
                    {
                        Mysql = Mysql + " WHERE E.DATARECEBIMENTO = @valor";
                    }
                    break;

            }
            Mysql = Mysql + " ORDER BY E.DATARECEBIMENTO ASC; ";
            db.CommandText = Mysql;
            db.AddParameter("@valor", valor);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectRel(string por, string nota, string serie)
        {

            var db = new DBAcess();
            string Mysql = " SELECT E.CODENTRADA, E.CODEMPRESA, EM.NOME AS NOMEEMPRESA, E.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, E.NUMERONOTA, E.SERIE, E.CFOP,  ";
            Mysql = Mysql + " E.CODFORNECEDOR, F.NOME AS NOMEFORNECEDOR, ";
            Mysql = Mysql + " DATE_FORMAT(E.DATAEMISSAO,'%d/%m/%Y') AS EMISSAO, DATE_FORMAT(E.DATARECEBIMENTO,'%d/%m/%Y') AS RECEBIMENTO, ";
            Mysql = Mysql + " I.CODPRODUTO, P.NOME AS NOMEPRODUTO, I.QUANTIDADE ";
            Mysql = Mysql + " FROM entrada E ";
            Mysql = Mysql + " INNER JOIN entrada_item I ON I.CODENTRADA = E.CODENTRADA ";
            Mysql = Mysql + " INNER JOIN produtos P ON P.CODPRODUTO = I.CODPRODUTO ";
            Mysql = Mysql + " INNER JOIN empresa EM ON EM.CODEMPRESA = E.CODEMPRESA ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = E.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN fornecedor F ON F.CODFORNECEDOR = E.CODFORNECEDOR ";
           

            switch (por)
            {
                case "nota":
                    {
                        Mysql = Mysql + " WHERE E.NUMERONOTA = @NOTA";
                        Mysql = Mysql + " AND E.SERIE = @SERIE";
                    }
                    break;
                case "fornecedor":
                    {
                        //Mysql = Mysql + " WHERE F.NOME LIKE CONCAT(@valor)";
                        //valor = '%' + valor + "%";
                    }
                    break;
                case "recebimento":
                    {
                        //Mysql = Mysql + " WHERE E.DATARECEBIMENTO = @valor";
                    }
                    break;

            }
            Mysql = Mysql + " ORDER BY I.CODPRODUTO ASC; ";
            db.CommandText = Mysql;
            db.AddParameter("@NOTA", nota);
            db.AddParameter("@SERIE", serie);

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
            const string order = " ORDER BY DATARECEBIMENTO ASC; ";
            db.CommandText = select + from + where + order;
            var ds = db.ExecuteDataSet();
            return ds;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet BuscaNota(string por, string valor)
        {

            var db = new DBAcess();
            string Mysql = " SELECT E.CODENTRADA, E.NUMERONOTA, DATE_FORMAT(E.DATARECEBIMENTO,'%d/%m/%Y') AS DATAENTREGA, E.CODFORNECEDOR, F.DESCRICAO AS NOMEFORNECEDOR, E.TIPOENTREGA ";
            Mysql = Mysql + " FROM ENTRADA  AS E  ";
            Mysql = Mysql + "INNER JOIN FORNECEDORES as F on F.CODFORNECEDOR  = E.CODFORNECEDOR   ";


            switch (por)
            {
                case "1":
                    {
                        Mysql = Mysql + " WHERE F.DESCRICAO LIKE CONCAT(@valor)";
                        valor = '%' + valor + "%";
                    }
                    break;
                case "2":
                    {
                        Mysql = Mysql + " WHERE E.DATAENTREGA = @valor";
                    }
                    break;
                case "3":
                    {
                        Mysql = Mysql + " WHERE E.NUMERONOTA = @valor";
                    }
                    break;

            }
            Mysql = Mysql + " ORDER BY F.DESCRICAO ASC; ";
            db.CommandText = Mysql;
            db.AddParameter("@valor", valor);
            var ds = db.ExecuteDataSet();
            return ds;
        }

    }
}
