using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;

namespace Atencao_Assistida.Classes.Mysql
{
    [DataObject(true)]
    public class Pedido
    {

        private int Codpedido { get; set; }
        private int Codempresa { get; set; }
        private int Tipo { get; set; }
        private int Aprovado { get; set; }
        private int Codunidade { get; set; }
        private int Coddepartamento { get; set; }
        private string Solicitante { get; set; }
        private string Numeropedido { get; set; }
        private string DataPedido { get; set; }
        private string Status { get; set; }
        private string Respinclusao { get; set; }
        private string Datainclusao { get; set; }
        private string Respalteracao { get; set; }
        private string Dataalteracao { get; set; }
        private string Excluido { get; set; }



        public Pedido(int codpedido, int codempresa, int codunidade, int tipo, int aprovado, int coddepartamento, string solicitante, string numeropedido, string datapedido, string status, string respinclusao,
            string datainclusao, string respalteracao, string dataalteracao, string excluido)
        {
            Codpedido = codpedido;
            Codempresa = codempresa;
            Tipo = tipo;
            Aprovado = aprovado;
            Codunidade = codunidade;
            Coddepartamento = coddepartamento;
            Solicitante = solicitante;
            Numeropedido = numeropedido;
            DataPedido = datapedido;
            Status = status;
            Respinclusao = respinclusao;
            Datainclusao = datainclusao;
            Respalteracao = respalteracao;
            Dataalteracao = dataalteracao;
            Excluido = excluido;


        }

        public Pedido(int codpedido, string status)
        {
            Codpedido = codpedido;
            Status = status;
        }

        public Pedido()
        {
         
        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO pedido(";
            Mysql = Mysql + " CODEMPRESA, TIPO, APROVADO, CODUNIDADE, CODDEPARTAMENTO, SOLICITANTE, NUMEROPEDIDO, DATAPEDIDO, STATUS, RESPINCLUSAO, DATAINCLUSAO, EXCLUIDO ";
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODEMPRESA, @TIPO, @APROVADO, @CODUNIDADE, @CODDEPARTAMENTO, @SOLICITANTE, @NUMEROPEDIDO, @DATAPEDIDO, @STATUS, @RESPINCLUSAO, @DATAINCLUSAO, @EXCLUIDO";
            Mysql = Mysql + "); ";

            Mysql = Mysql + " SELECT MAX(CODPEDIDO) FROM pedido ";
            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@TIPO", Tipo);
            db.AddParameter("@APROVADO", Aprovado);
            db.AddParameter("@CODUNIDADE", Codunidade);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@SOLICITANTE", Solicitante);
            db.AddParameter("@NUMEROPEDIDO", Numeropedido);
            db.AddParameter("@DATAPEDIDO", Convert.ToDateTime(DataPedido));
            db.AddParameter("@STATUS", Status);
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

        public int InsertAccess(int codpedido, int codempresa, int coddepartamento, string nomedepartamento, int codunidade, string nomeunidade,
                            string solicitante, string numeropedido, string datapedido, string status, int codproduto, string nomeproduto, string quantidade, string estoqueubs)
        {
            var db = new DBAcessOleDB();
            var Mysql = " INSERT INTO Pedido(";
            Mysql = Mysql + " CODPEDIDO, CODEMPRESA, CODDEPARTAMENTO, NOMEDEPARTAMENTO, CODUNIDADE, NOMEUNIDADE, SOLICITANTE, NUMEROPEDIDO, DATAPEDIDO, STATUS, CODPRODUTO, NOMEPRODUTO, QUANTIDADE, ESTOQUEUBS ";
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODPEDIDO, @CODEMPRESA, @CODDEPARTAMENTO, @NOMEDEPARTAMENTO, @CODUNIDADE, @NOMEUNIDADE, @SOLICITANTE, @NUMEROPEDIDO, @DATAPEDIDO, @STATUS, @CODPRODUTO, @NOMEPRODUTO, @QUANTIDADE, ESTOQUEUBS ";
            Mysql = Mysql + "); ";
            
            db.CommandText = Mysql;

            db.AddParameter("@CODPEDIDO", codpedido);
            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@NOMEDEPARTAMENTO", nomedepartamento);
            db.AddParameter("@CODUNIDADE", codunidade);
            db.AddParameter("@NOMEUNIDADE", nomeunidade);

            db.AddParameter("@SOLICITANTE", solicitante);
            db.AddParameter("@NUMEROPEDIDO", numeropedido);
            db.AddParameter("@DATAPEDIDO", datapedido);
            db.AddParameter("@STATUS", status);
            db.AddParameter("@CODPRODUTO", codproduto);
            db.AddParameter("@NOMEPRODUTO", nomeproduto);
            db.AddParameter("@QUANTIDADE", quantidade);
            db.AddParameter("@ESTOQUEUBS", estoqueubs);


            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }


        public int InsertAccessOficio(int codpedido, int codempresa, int coddepartamento, string nomedepartamento, int codunidade, string nomeunidade,
                                      string solicitante, string numeropedido, string datapedido, string status, int codproduto, string nomeproduto, 
                                      string quantidade, string estoqueubs, string paraquem)
        {
            var db = new DBAcessOleDB();
            var Mysql = " INSERT INTO Oficio(";
            Mysql = Mysql + " CODOFICIO, CODEMPRESA, CODDEPARTAMENTO, NOMEDEPARTAMENTO, CODUNIDADE, NOMEUNIDADE, ";
            Mysql = Mysql + " SOLICITANTE, NUMEROPEDIDO, DATAPEDIDO, STATUS, CODPRODUTO, NOMEPRODUTO, QUANTIDADE, PARAQUEM ";
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODOFICIO, @CODEMPRESA, @CODDEPARTAMENTO, @NOMEDEPARTAMENTO, @CODUNIDADE, @NOMEUNIDADE, ";
            Mysql = Mysql + " @SOLICITANTE, @NUMEROPEDIDO, @DATAPEDIDO, @STATUS, @CODPRODUTO, @NOMEPRODUTO, @QUANTIDADE, PARAQUEM ";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODOFICIO", codpedido);
            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@NOMEDEPARTAMENTO", nomedepartamento);
            db.AddParameter("@CODUNIDADE", codunidade);
            db.AddParameter("@NOMEUNIDADE", nomeunidade);

            db.AddParameter("@SOLICITANTE", solicitante);
            db.AddParameter("@NUMEROPEDIDO", numeropedido);
            db.AddParameter("@DATAPEDIDO", datapedido);
            db.AddParameter("@STATUS", status);
            db.AddParameter("@CODPRODUTO", codproduto);
            db.AddParameter("@NOMEPRODUTO", nomeproduto);
            db.AddParameter("@QUANTIDADE", quantidade);
            db.AddParameter("@PARAQUEM", paraquem);



            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }


        public int InsertAccessPedidoPeriodo(int codempresa, string nomeempresa, int coddepartamento, string nomedepartamento, int codunidade, string nomeunidade,
        int tipo, int codpedido,  string solicitante, string numeropedido, int codproduto, string nomeproduto, string quantidade, string datapedido, string status )
        {
            var db = new DBAcessOleDB();
            var Mysql = " INSERT INTO PedidoPeriodo(";
            Mysql = Mysql + " CODEMPRESA, NOMEEMPRESA, CODDEPARTAMENTO, NOMEDEPARTAMENTO, CODUNIDADE, NOMEUNIDADE, TIPO, CODPEDIDO, SOLICITANTE, ";
            Mysql = Mysql + " NUMEROPEDIDO, CODPRODUTO, NOMEPRODUTO, QUANTIDADE, DATAPEDIDO, STATUS ";
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODEMPRESA, @NOMEEMPRESA, @CODDEPARTAMENTO, @NOMEDEPARTAMENTO, @CODUNIDADE, @NOMEUNIDADE, @TIPO, @CODPEDIDO, @SOLICITANTE, ";
            Mysql = Mysql + " @NUMEROPEDIDO, @CODPRODUTO, @NOMEPRODUTO, @QUANTIDADE, @DATAPEDIDO, @STATUS ";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@NOMEEMPRESA", nomeempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@NOMEDEPARTAMENTO", nomedepartamento);
            db.AddParameter("@CODUNIDADE", codunidade);
            db.AddParameter("@NOMEUNIDADE", nomeunidade);
            db.AddParameter("@TIPO", tipo);
            db.AddParameter("@CODPEDIDO", codpedido);
            db.AddParameter("@SOLICITANTE", solicitante);
            db.AddParameter("@NUMEROPEDIDO", numeropedido);
            db.AddParameter("@CODPRODUTO", codproduto);
            db.AddParameter("@NOMEPRODUTO", nomeproduto);
            db.AddParameter("@QUANTIDADE", quantidade);
            db.AddParameter("@DATAPEDIDO", datapedido);
            db.AddParameter("@STATUS", status);


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
            var Mysql = " UPDATE pedido ";
            Mysql = Mysql + " SET";
            Mysql = Mysql + " CODEMPRESA = @CODEMPRESA, TIPO = @TIPO, APROVADO = @APROVADO, CODUNIDADE = @CODUNIDADE, CODDEPARTAMENTO = @CODDEPARTAMENTO, SOLICITANTE = @SOLICITANTE, ";
            Mysql = Mysql + " NUMEROPEDIDO = @NUMEROPEDIDO, DATAPEDIDO = @DATAPEDIDO, ";
            Mysql = Mysql + " STATUS = @STATUS, RESPALTERACAO = @RESPALTERACAO, DATAALTERACAO = @DATAALTERACAO, EXCLUIDO = @EXCLUIDO";

            Mysql = Mysql + " WHERE CODPEDIDO = @ID;";

            db.CommandText = Mysql;
            db.AddParameter("@ID", Codpedido);
            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@TIPO", Tipo);
            db.AddParameter("@APROVADO", Aprovado);
            db.AddParameter("@CODUNIDADE", Codunidade);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@SOLICITANTE", Solicitante);
            db.AddParameter("@NUMEROPEDIDO", Numeropedido);
            db.AddParameter("@DATAPEDIDO", Convert.ToDateTime(DataPedido));
            db.AddParameter("@STATUS", Status);
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

        public bool UpdateStatus()
        {
            var db = new DBAcess();
            const string update = " UPDATE pedido ";
            const string set = " SET" +
                               " STATUS = @STATUS ";

            const string where = " WHERE NUMEROPEDIDO = @NUMEROPEDIDO;";
            db.CommandText = update + set + where;
            db.AddParameter("@NUMEROPEDIDO", Codpedido);
            db.AddParameter("@STATUS", Status);

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

        public bool UpdateStatus(int Codpedido, string Status)
        {
            var db = new DBAcess();
            const string update = " UPDATE pedido ";
            const string set = " SET" +
                               " STATUS = @STATUS ";

            const string where = " WHERE CODPEDIDO = @CODPEDIDO;";
            db.CommandText = update + set + where;
            db.AddParameter("@CODPEDIDO", Codpedido);
            db.AddParameter("@STATUS", Status);

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

        public bool AprovaOficio(int cod)
        {
            var db = new DBAcess();
            var Mysql = " UPDATE pedido ";
            Mysql = Mysql + " SET";
            Mysql = Mysql + " APROVADO = @APROVADO ";

            Mysql = Mysql + " WHERE CODPEDIDO = @CODPEDIDO;";

            db.CommandText = Mysql;
            db.AddParameter("@CODPEDIDO", cod);
            db.AddParameter("@APROVADO", "1");

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

        public bool RetornaAprovaOficio(int cod)
        {
            var db = new DBAcess();
            var Mysql = " UPDATE pedido ";
            Mysql = Mysql + " SET";
            Mysql = Mysql + " APROVADO = @APROVADO ";

            Mysql = Mysql + " WHERE CODPEDIDO = @CODPEDIDO;";

            db.CommandText = Mysql;
            db.AddParameter("@CODPEDIDO", cod);
            db.AddParameter("@APROVADO", "0");

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

       
        public int BuscaUltimoPedido(int tipo, int coddepartamento)
        {
            var db = new DBAcess();
            var Mysql = " SELECT MAX(CODPEDIDO) AS ULTIMO ";

            Mysql = Mysql + " FROM pedido ";
            Mysql = Mysql + " WHERE TIPO = @TIPO ";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO ";

            db.CommandText = Mysql;
            db.AddParameter("@TIPO", tipo);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);

            try
            {
               if(db.ExecuteScalar().ToString() !=  "")
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


        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader NovoPedido(int tipo, int coddepartamento, int CodigoPedido)
        {
            var db = new DBAcess();
            var Mysql = " SELECT MAX(NUMEROPEDIDO) AS ULTIMO ";

            Mysql = Mysql + " FROM pedido ";
            Mysql = Mysql + " WHERE TIPO = @TIPO ";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND CODPEDIDO = @CODPEDIDO ";

            db.CommandText = Mysql;
            db.AddParameter("@TIPO", tipo);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@CODPEDIDO", CodigoPedido);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(int id)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM pedido ";
            Mysql = Mysql + " WHERE CODPEDIDO = @id ";
            Mysql = Mysql + " AND TIPO = 0 ";
            db.CommandText = Mysql;
            db.AddParameter("@id", id);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectPedido(int Codempresa, int coddepartamento, int codunidade, int codproduto, int tipo, string DataInicial, string DataFinal)
        {
            var db = new DBAcess();
            string Mysql = " SELECT P.CODEMPRESA, E.NOME AS NOMEEMPRESA, P.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, P.CODUNIDADE, U.NOME AS NOMEUNIDADE, P.TIPO, ";
            Mysql = Mysql + " P.CODPEDIDO, P.SOLICITANTE, P.NUMEROPEDIDO, PI.CODPRODUTO, PR.NOME AS NOMEPRODUTO, PI.QUANTIDADE, DATE_FORMAT(P.DATAPEDIDO,'%d/%m/%Y') AS DATAPEDIDO, P.`STATUS` ";

            Mysql = Mysql + " FROM pedido P ";

            Mysql = Mysql + " INNER JOIN empresa E ON E.CODEMPRESA = P.CODEMPRESA ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = P.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN unidade U ON U.CODUNIDADE = P.CODUNIDADE ";
            Mysql = Mysql + " INNER JOIN pedido_item PI ON PI.CODPEDIDO = P.CODPEDIDO ";
            Mysql = Mysql + " INNER JOIN produtos PR ON PR.CODPRODUTO = PI.CODPRODUTO ";

            Mysql = Mysql + " WHERE P.DATAPEDIDO BETWEEN @DATAINICIAL AND @DATAFINAL ";
            Mysql = Mysql + " AND P.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND P.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND P.TIPO = @TIPO ";

            if (codunidade != 0) { Mysql = Mysql + " AND P.CODUNIDADE = @CODUNIDADE "; }
            if (codproduto != 0) { Mysql = Mysql + " AND PR.CODPRODUTO = @CODPRODUTO "; }

            db.CommandText = Mysql;
            db.AddParameter("@DATAINICIAL", Convert.ToDateTime(DataInicial));
            db.AddParameter("@DATAFINAL", Convert.ToDateTime(DataFinal));
            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@TIPO", tipo);

            db.AddParameter("@CODUNIDADE", codunidade);
            db.AddParameter("@CODPRODUTO", codproduto);


            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectPedidoN(string Numero, int tipo, int coddepartamento)
        {
            var db = new DBAcess();
            string Mysql = " SELECT CODPEDIDO, NUMEROPEDIDO, DATE_FORMAT(DATAPEDIDO, '%d/%m/%Y') AS DATAPEDIDO, SOLICITANTE, ";
            Mysql = Mysql + " CODEMPRESA, CODUNIDADE, STATUS, CODDEPARTAMENTO, TIPO, APROVADO ";

            Mysql = Mysql + " FROM pedido ";
            Mysql = Mysql + " WHERE NUMEROPEDIDO = @NUMEROPEDIDO ";
            Mysql = Mysql + " AND TIPO = @TIPO ";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO ";

            db.CommandText = Mysql;
            db.AddParameter("@NUMEROPEDIDO", Numero);
            db.AddParameter("@TIPO", tipo);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectPedidoC(string Codigo, int tipo, int coddepartamento)
        {
            var db = new DBAcess();
            string Mysql = " SELECT CODPEDIDO, NUMEROPEDIDO, DATE_FORMAT(DATAPEDIDO, '%d/%m/%Y') AS DATAPEDIDO, SOLICITANTE, ";
            Mysql = Mysql + " CODEMPRESA, CODUNIDADE, STATUS, CODDEPARTAMENTO, TIPO, APROVADO ";

            Mysql = Mysql + " FROM pedido ";
            Mysql = Mysql + " WHERE CODPEDIDO = @CODPEDIDO ";
            Mysql = Mysql + " AND TIPO = @TIPO ";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODPEDIDO", Codigo);
            db.AddParameter("@TIPO", tipo);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectPedidoC(int Numero)
        {
            var db = new DBAcess();
            string Mysql = " SELECT CODPEDIDO, NUMEROPEDIDO, DATE_FORMAT(DATAPEDIDO, '%d/%m/%Y') AS DATAPEDIDO, SOLICITANTE, ";
            Mysql = Mysql + " CODEMPRESA, CODUNIDADE, STATUS, CODDEPARTAMENTO, TIPO, APROVADO ";

            Mysql = Mysql + " FROM pedido ";
            Mysql = Mysql + " WHERE CODPEDIDO = @CODPEDIDO ";
            Mysql = Mysql + " AND TIPO = 0 ";


            db.CommandText = Mysql;
            db.AddParameter("@CODPEDIDO", Numero);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectRel(string Numero)
        {
            var db = new DBAcess();
            string Mysql = " SELECT P.CODPEDIDO, P.NUMEROPEDIDO, P.CODEMPRESA, P.TIPO, P.APROVADO, P.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, P.CODUNIDADE, U.NOME AS NOMEUNIDADE,  ";
            Mysql = Mysql + " P.SOLICITANTE, P.NUMEROPEDIDO,  DATE_FORMAT(P.DATAPEDIDO,'%d/%m/%Y') AS DATAPEDIDO, P.STATUS, PI.CODPRODUTO, PR.NOME AS NOMEPRODUTO, PI.QUANTIDADE, PI.ESTOQUEUBS ";
            Mysql = Mysql + " FROM PEDIDO P ";
            Mysql = Mysql + " INNER JOIN pedido_item PI ON PI.CODPEDIDO = P.CODPEDIDO ";
            Mysql = Mysql + " INNER JOIN produtos PR ON PR.CODPRODUTO = PI.CODPRODUTO ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = P.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN unidade U ON U.CODUNIDADE = P.CODUNIDADE ";

            Mysql = Mysql + " WHERE P.NUMEROPEDIDO = @NUMEROPEDIDO ";
            Mysql = Mysql + " AND TIPO = 0 ";


            db.CommandText = Mysql;
            db.AddParameter("@NUMEROPEDIDO", Numero);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectTudo()
        {
            var db = new DBAcess();
            string Mysql = " SELECT P.CODPEDIDO,  P.TIPO, P.APROVADO, P.NUMEROPEDIDO, DATE_FORMAT(P.DATAPEDIDO,'%d/%m/%Y') AS DATAPEDIDO, P.SOLICITANTE, P.CODUNIDADE, U.NOME AS UNIDADE  ";
            Mysql = Mysql + " FROM pedido  AS P  ";
            Mysql = Mysql + " INNER JOIN unidade AS U ON U.CODUNIDADE = P.CODUNIDADE ";

            Mysql = Mysql + " WHERE P.STATUS = 'ABERTO' ";
            Mysql = Mysql + " AND TIPO = 0 ";

            db.CommandText = Mysql;
           
            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectTudo(int coddepartamento)
        {
            var db = new DBAcess();
            string Mysql = " SELECT P.CODPEDIDO,  P.TIPO, P.APROVADO, P.NUMEROPEDIDO, DATE_FORMAT(P.DATAPEDIDO,'%d/%m/%Y') AS DATAPEDIDO, P.SOLICITANTE, P.CODUNIDADE, U.NOME AS UNIDADE, P.STATUS  ";
            Mysql = Mysql + " FROM pedido  AS P  ";
            Mysql = Mysql + " INNER JOIN unidade AS U ON U.CODUNIDADE = P.CODUNIDADE ";

            Mysql = Mysql + " WHERE P.STATUS = 'ABERTO' ";
            Mysql = Mysql + " AND P.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND TIPO = 0 ";

            db.CommandText = Mysql;
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet SelectTodos()
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM pedido ";
            Mysql = Mysql + " WHERE TIPO = 0 ";

            Mysql = Mysql + " ORDER BY DATAPEDIDO ASC; ";
            db.CommandText = Mysql;
            var ds = db.ExecuteDataSet();
            return ds;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet BuscaPedido(string por, string valor)
        {

            var db = new DBAcess();
            string Mysql = " SELECT P.CODPEDIDO,  P.TIPO, P.APROVADO, P.NUMEROPEDIDO, DATE_FORMAT(P.DATAPEDIDO,'%d/%m/%Y') AS DATAPEDIDO, P.CODUNIDADE, U.NOME AS UNIDADE  ";
            Mysql = Mysql + " FROM pedido  AS P  ";
            Mysql = Mysql + " INNER JOIN unidade AS U ON U.CODUNIDADE = P.CODUNIDADE ";

            Mysql = Mysql + " WHERE P.STATUS = 'ABERTO' ";
            Mysql = Mysql + " AND TIPO = 0 ";


            switch (por)
            {
                case "1":
                    {
                        //Mysql = Mysql + " WHERE F.DESCRICAO LIKE CONCAT(@valor)";
                        //valor = '%' + valor + "%";
                    }
                    break;
                case "2":
                    {
                        Mysql = Mysql + " AND P.DATAPEDIDO = @valor";
                    }
                    break;
                case "3":
                    {
                        Mysql = Mysql + " AND P.NUMEROPEDIDO = @valor";
                    }
                    break;

            }
            //Mysql = Mysql + " ORDER BY F.DESCRICAO ASC; ";
            db.CommandText = Mysql;
            db.AddParameter("@valor", valor);
            var ds = db.ExecuteDataSet();
            return ds;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(int codPedido, string numero)
        {
            var db = new DBAcess();
            var Mysql = " SELECT E.CODPRODUTO, P.NOME, E.LOTE, E.QUANTIDADE, P.UNIDADE, NULL AS ENTREGUE ";
            Mysql = Mysql + " FROM Pedido_item AS E ";
            Mysql = Mysql + " INNER JOIN produtos AS  P ON P.CODPRODUTO = E.CODPRODUTO ";

            Mysql = Mysql + " WHERE CODPEDIDO = @CODPEDIDO ";
            Mysql = Mysql + " AND NUMEROPEDIDO = @NUMEROPEDIDO ";
            

            db.CommandText = Mysql;
            db.AddParameter("@CODPEDIDO", codPedido);
            db.AddParameter("@NUMEROPEDIDO", numero);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectTudoOfcReq(int tipo, int coddepartamento, string Status)
        {
            var db = new DBAcess();
            string Mysql = " SELECT P.CODPEDIDO,  P.TIPO, P.APROVADO, P.NUMEROPEDIDO, DATE_FORMAT(P.DATAPEDIDO,'%d/%m/%Y') AS DATAPEDIDO, P.SOLICITANTE, P.CODUNIDADE, U.NOME AS UNIDADE, P.STATUS  ";
            Mysql = Mysql + " FROM pedido  AS P  ";
            Mysql = Mysql + " INNER JOIN unidade AS U ON U.CODUNIDADE = P.CODUNIDADE ";
                       
            Mysql = Mysql + " WHERE P.TIPO = @TIPO ";
            Mysql = Mysql + " AND P.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND P.STATUS = @STATUS ";
           
            db.CommandText = Mysql;
            db.AddParameter("@TIPO", tipo);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@STATUS", Status);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }




        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader NovoOficio()
        {
            var db = new DBAcess();
            var Mysql = " SELECT MAX(NUMEROPEDIDO) AS ULTIMO ";

            Mysql = Mysql + " FROM pedido ";
            Mysql = Mysql + " WHERE TIPO = 1 ";

            db.CommandText = Mysql;

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectOficio(int id)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM pedido ";
            Mysql = Mysql + " WHERE CODPEDIDO = @id ";
            Mysql = Mysql + " AND TIPO = 1 ";
            db.CommandText = Mysql;
            db.AddParameter("@id", id);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectOficioN(string Numero, int tipo, int coddepartamento)
        {
            var db = new DBAcess();
            string Mysql = " SELECT CODPEDIDO, NUMEROPEDIDO, DATE_FORMAT(DATAPEDIDO, '%d/%m/%Y') AS DATAPEDIDO, SOLICITANTE, ";
            Mysql = Mysql + " CODEMPRESA, CODUNIDADE, STATUS, CODDEPARTAMENTO, TIPO, APROVADO ";

            Mysql = Mysql + " FROM pedido ";
            Mysql = Mysql + " WHERE NUMEROPEDIDO = @NUMEROPEDIDO ";
            Mysql = Mysql + " AND TIPO = @TIPO ";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO ";

            db.CommandText = Mysql;
            db.AddParameter("@NUMEROPEDIDO", Numero);
            db.AddParameter("@TIPO", tipo);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

       

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectOficioC(int Numero)
        {
            var db = new DBAcess();
            string Mysql = " SELECT CODPEDIDO, NUMEROPEDIDO, DATE_FORMAT(DATAPEDIDO, '%d/%m/%Y') AS DATAPEDIDO, SOLICITANTE, ";
            Mysql = Mysql + " CODEMPRESA, CODUNIDADE, STATUS, CODDEPARTAMENTO, TIPO, APROVADO ";

            Mysql = Mysql + " FROM pedido ";
            Mysql = Mysql + " WHERE CODPEDIDO = @CODPEDIDO ";
            Mysql = Mysql + " AND TIPO = 1 ";


            db.CommandText = Mysql;
            db.AddParameter("@CODPEDIDO", Numero);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectOficioRel(string Numero)
        {
            var db = new DBAcess();
            string Mysql = " SELECT P.CODPEDIDO, P.NUMEROPEDIDO, P.CODEMPRESA, P.TIPO, P.APROVADO, P.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, P.CODUNIDADE, U.NOME AS NOMEUNIDADE,  ";
            Mysql = Mysql + " P.SOLICITANTE, P.NUMEROPEDIDO,  DATE_FORMAT(P.DATAPEDIDO,'%d/%m/%Y') AS DATAPEDIDO, P.STATUS, PI.CODPRODUTO, PR.NOME AS NOMEPRODUTO, PI.QUANTIDADE, PI.ESTOQUEUBS, PI.PARAQUEM ";
            Mysql = Mysql + " FROM PEDIDO P ";
            Mysql = Mysql + " INNER JOIN pedido_item PI ON PI.CODPEDIDO = P.CODPEDIDO ";
            Mysql = Mysql + " INNER JOIN produtos PR ON PR.CODPRODUTO = PI.CODPRODUTO ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = P.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN unidade U ON U.CODUNIDADE = P.CODUNIDADE ";

            Mysql = Mysql + " WHERE P.NUMEROPEDIDO = @NUMEROPEDIDO ";
            Mysql = Mysql + " AND TIPO = 1 ";


            db.CommandText = Mysql;
            db.AddParameter("@NUMEROPEDIDO", Numero);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectOficioTudo()
        {
            var db = new DBAcess();
            string Mysql = " SELECT P.CODPEDIDO,  P.TIPO, P.APROVADO, P.NUMEROPEDIDO, DATE_FORMAT(P.DATAPEDIDO,'%d/%m/%Y') AS DATAPEDIDO, P.SOLICITANTE, P.CODUNIDADE, U.NOME AS UNIDADE  ";
            Mysql = Mysql + " FROM pedido  AS P  ";
            Mysql = Mysql + " INNER JOIN unidade AS U ON U.CODUNIDADE = P.CODUNIDADE ";

            Mysql = Mysql + " WHERE P.STATUS = 'ABERTO' ";
            Mysql = Mysql + " AND TIPO = 1 ";

            db.CommandText = Mysql;

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectOficioTudo(int coddepartamento)
        {
            var db = new DBAcess();
            string Mysql = " SELECT P.CODPEDIDO,  P.TIPO, P.APROVADO, P.NUMEROPEDIDO, DATE_FORMAT(P.DATAPEDIDO,'%d/%m/%Y') AS DATAPEDIDO, P.SOLICITANTE, P.CODUNIDADE, U.NOME AS UNIDADE  ";
            Mysql = Mysql + " FROM pedido  AS P  ";
            Mysql = Mysql + " INNER JOIN unidade AS U ON U.CODUNIDADE = P.CODUNIDADE ";

            Mysql = Mysql + " WHERE P.STATUS = 'ABERTO' ";
            Mysql = Mysql + " AND P.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND TIPO = 1 ";
           
            db.CommandText = Mysql;
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet SelectOficioTodos()
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM pedido ";
            Mysql = Mysql + " WHERE TIPO = 1 ";

            Mysql = Mysql + " ORDER BY DATAPEDIDO ASC; ";
            db.CommandText = Mysql;
            var ds = db.ExecuteDataSet();
            return ds;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet BuscaOficio(string por, string valor)
        {

            var db = new DBAcess();
            string Mysql = " SELECT P.CODPEDIDO,  P.TIPO, P.APROVADO, P.NUMEROPEDIDO, DATE_FORMAT(P.DATAPEDIDO,'%d/%m/%Y') AS DATAPEDIDO, P.CODUNIDADE, U.NOME AS UNIDADE  ";
            Mysql = Mysql + " FROM pedido  AS P  ";
            Mysql = Mysql + " INNER JOIN unidade AS U ON U.CODUNIDADE = P.CODUNIDADE ";

            Mysql = Mysql + " WHERE P.STATUS = 'ABERTO' ";
            Mysql = Mysql + " AND TIPO = 1 ";


            switch (por)
            {
                case "1":
                    {
                        //Mysql = Mysql + " WHERE F.DESCRICAO LIKE CONCAT(@valor)";
                        //valor = '%' + valor + "%";
                    }
                    break;
                case "2":
                    {
                        Mysql = Mysql + " AND P.DATAPEDIDO = @valor";
                    }
                    break;
                case "3":
                    {
                        Mysql = Mysql + " AND P.NUMEROPEDIDO = @valor";
                    }
                    break;

            }
            //Mysql = Mysql + " ORDER BY F.DESCRICAO ASC; ";
            db.CommandText = Mysql;
            db.AddParameter("@valor", valor);
            var ds = db.ExecuteDataSet();
            return ds;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectOficio(int codPedido, string numero)
        {
            var db = new DBAcess();
            var Mysql = " SELECT E.CODPRODUTO, P.NOME, E.LOTE, E.QUANTIDADE, P.UNIDADE, NULL AS ENTREGUE, E.PARAQUEM ";
            Mysql = Mysql + " FROM Pedido_item AS E ";
            Mysql = Mysql + " INNER JOIN produtos AS  P ON P.CODPRODUTO = E.CODPRODUTO ";

            Mysql = Mysql + " WHERE CODPEDIDO = @CODPEDIDO ";
            Mysql = Mysql + " AND NUMEROPEDIDO = @NUMEROPEDIDO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODPEDIDO", codPedido);
            db.AddParameter("@NUMEROPEDIDO", numero);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectAutorizaAberto(int tipo)
        {
            var db = new DBAcess();
            string Mysql = " SELECT P.CODPEDIDO, P.CODEMPRESA, P.TIPO, P.APROVADO, P.CODDEPARTAMENTO, P.SOLICITANTE,D.NOME AS LOTACAO, ";
            Mysql = Mysql + " P.NUMEROPEDIDO, DATE_FORMAT(P.DATAPEDIDO, '%d/%m/%Y') AS DATAPEDIDO, P.`STATUS` ";
            Mysql = Mysql + " FROM pedido P ";
            //Mysql = Mysql + " INNER JOIN usuarios U ON U.NOME = P.SOLICITANTE AND U.CODDEPARTAMENTO = P.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN departamento D ON P.CODDEPARTAMENTO = D.CODDEPARTAMENTO ";

            Mysql = Mysql + " WHERE P.STATUS = 'ABERTO' ";
            Mysql = Mysql + " AND TIPO = @TIPO ";
            Mysql = Mysql + " ORDER BY P.DATAPEDIDO DESC ";

            db.CommandText = Mysql;
            db.AddParameter("@TIPO", tipo);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }
                

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader PesqSaidaOficio(int coddepartamento)
        {
            var db = new DBAcess();
            string Mysql = " SELECT P.CODPEDIDO,  P.TIPO, P.APROVADO, P.NUMEROPEDIDO, DATE_FORMAT(P.DATAPEDIDO,'%d/%m/%Y') AS DATAPEDIDO, P.SOLICITANTE, P.CODUNIDADE, U.NOME AS UNIDADE  ";
            Mysql = Mysql + " FROM pedido  AS P  ";
            Mysql = Mysql + " INNER JOIN unidade AS U ON U.CODUNIDADE = P.CODUNIDADE ";

            Mysql = Mysql + " WHERE P.STATUS = 'ABERTO' ";
            Mysql = Mysql + " AND P.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND TIPO = 1 ";
            Mysql = Mysql + " AND APROVADO = 1 ";

            db.CommandText = Mysql;
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader PesqSaidaOficio(string status, int coddepartamento, int tipo, int aprovado)
        {
            var db = new DBAcess();
            string Mysql = " SELECT P.CODPEDIDO,  P.TIPO, P.APROVADO, P.NUMEROPEDIDO, DATE_FORMAT(P.DATAPEDIDO,'%d/%m/%Y') AS DATAPEDIDO, P.SOLICITANTE, P.CODUNIDADE, U.NOME AS UNIDADE  ";
            Mysql = Mysql + " FROM pedido  AS P  ";
            Mysql = Mysql + " INNER JOIN unidade AS U ON U.CODUNIDADE = P.CODUNIDADE ";

            Mysql = Mysql + " WHERE P.STATUS = @STATUS ";
            Mysql = Mysql + " AND P.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND TIPO = @TIPO ";
            Mysql = Mysql + " AND APROVADO = @APROVADO ";

            db.CommandText = Mysql;

            db.AddParameter("@STATUS", status);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@TIPO", tipo);
            db.AddParameter("@APROVADO", aprovado);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }
    }
}
