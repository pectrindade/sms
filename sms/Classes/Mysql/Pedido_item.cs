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
    public class Pedido_item
    {
        private int Codpedido { get; set; }
        private string Numeropedido { get; set; }
        private int Codproduto { get; set; }
        private string Lote { get; set; }
        private string Validade { get; set; }
        private string Quantidade { get; set; }
        private string EstoqueUbs { get; set; }
        private string Paraquem { get; set; }

        public Pedido_item(int codpedido, string numeropedido, int codproduto, string lote, string validade, string quantidade, string estoqueubs)
        {
            Codpedido = codpedido;
            Numeropedido = numeropedido;
            Codproduto = codproduto;
            Lote = lote;
            Validade = validade;
            Quantidade = quantidade;
            EstoqueUbs = estoqueubs;

        }

        public Pedido_item(int codpedido, string numeropedido, int codproduto, string lote, string validade, string quantidade, string estoqueubs, string paraquem)
        {
            Codpedido = codpedido;
            Numeropedido = numeropedido;
            Codproduto = codproduto;
            Lote = lote;
            Validade = validade;
            Quantidade = quantidade;
            EstoqueUbs = estoqueubs;
            Paraquem = paraquem;
        }

        public Pedido_item(int codpedido, string numeropedido)
        {
            Codpedido = codpedido;
            Numeropedido = numeropedido;

        }

        public Pedido_item(int codpedido)
        {
            Codpedido = codpedido;
           
        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO pedido_item(";
            Mysql = Mysql + " CODPEDIDO, NUMEROPEDIDO, CODPRODUTO, LOTE, QUANTIDADE, ESTOQUEUBS ";
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODPEDIDO, @NUMEROPEDIDO, @CODPRODUTO, @LOTE, @QUANTIDADE, @ESTOQUEUBS ";
            Mysql = Mysql + "); ";
                       
            db.CommandText = Mysql;

            db.AddParameter("@CODPEDIDO", Codpedido);
            db.AddParameter("@NUMEROPEDIDO", Numeropedido);
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@LOTE", Lote);
            db.AddParameter("@QUANTIDADE", Convert.ToDecimal(Quantidade));
            db.AddParameter("@ESTOQUEUBS", EstoqueUbs);


            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }


        public int InsertOficio()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO pedido_item(";
            Mysql = Mysql + " CODPEDIDO, NUMEROPEDIDO, CODPRODUTO, LOTE, QUANTIDADE, ESTOQUEUBS, PARAQUEM ";
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODPEDIDO, @NUMEROPEDIDO, @CODPRODUTO, @LOTE, @QUANTIDADE, @ESTOQUEUBS, @PARAQUEM ";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODPEDIDO", Codpedido);
            db.AddParameter("@NUMEROPEDIDO", Numeropedido);
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@LOTE", Lote);
            db.AddParameter("@QUANTIDADE", Convert.ToDecimal(Quantidade));
            db.AddParameter("@ESTOQUEUBS", EstoqueUbs);
            db.AddParameter("@PARAQUEM", Paraquem);


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
            var Mysql = " UPDATE pedido_item ";
            Mysql = Mysql + " SET";
            Mysql = Mysql + " NUMERONOTA = @NUMERONOTA, CODPRODUTO = @CODPRODUTO, LOTE = @LOTE, VALIDADE = @VALIDADE, QUANTIDADE = @QUANTIDADE, ESTOQUEUBS = @ESTOQUEUBS ";
            Mysql = Mysql + " WHERE CODPEDIDO = @CODPEDIDO";
            Mysql = Mysql + " AND NUMERONOTA = @NUMERONOTA";
            Mysql = Mysql + " AND CODPRODUTO = @CODPRODUTO";

            db.CommandText = Mysql;

            db.AddParameter("@CODPEDIDO", Codpedido);
            db.AddParameter("@NUMERONOTA", Numeropedido);
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@LOTE", Lote);
            db.AddParameter("@VALIDADE", Validade);
            db.AddParameter("@QUANTIDADE", Convert.ToDecimal(Quantidade));
            db.AddParameter("@ESTOQUEUBS", EstoqueUbs);

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

        public bool UpdatePedido_item()
        {
            var db = new DBAcess();
            const string update = " UPDATE pedido_item ";
            const string set = " SET" +
                               " CODPEDIDO = @CODPEDIDO, NUMEROPEDIDO = @NUMEROPEDIDO ";
            const string where = " WHERE CODPEDIDO = 0 ";
            var and = " AND NUMEROPEDIDO = @NUMEROPEDIDO";

            db.CommandText = update + set + where + and;

            db.AddParameter("@CODPEDIDO", Codpedido);
            db.AddParameter("@NUMEROPEDIDO", Numeropedido);


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

        public void Delete(int codpedido)//, int Codproduto)
        {
            var db = new DBAcess();
            var Mysql = " DELETE FROM pedido_item ";
            Mysql = Mysql + " WHERE CODPEDIDO = @CODPEDIDO ";
           // Mysql = Mysql + " AND CODPRODUTO = @CODPRODUTO ";
            db.CommandText = Mysql;

            db.AddParameter("@CODPEDIDO", codpedido);
            //db.AddParameter("@CODPRODUTO", Codproduto);

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
            Mysql = Mysql + " FROM pedido_item ";
            Mysql = Mysql + " WHERE NUMEROPEDIDO = @NUMEROPEDIDO ";


            db.CommandText = Mysql;
            db.AddParameter("@NUMEROPEDIDO", Numero);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(int codPedido, string numero)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";

            const string from = " FROM pedido_item ";
            const string where = " WHERE CODPEDIDO = @CODPEDIDO ";
            const string and = " AND NUMEROPEDIDO = @NUMEROPEDIDO ";

            db.CommandText = select + from + where + and;
            db.AddParameter("@CODPEDIDO", codPedido);
            db.AddParameter("@NUMEROPEDIDO", numero);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectItem(int codPedido, string numero, int codproduto)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";

            Mysql = Mysql + " FROM pedido_item ";
            Mysql = Mysql + " WHERE CODPEDIDO = @CODPedido ";
            Mysql = Mysql + " AND NUMEROPEDIDO = @NUMEROPEDIDO ";
            Mysql = Mysql + " AND CODPRODUTO = @CODPRODUTO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODPEDIDO", codPedido);
            db.AddParameter("@NUMEROPEDIDO", numero);
            db.AddParameter("@CODPRODUTO", codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet SelectTodos()
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM pedido ";
            const string where = "  ";
            const string order = " ORDER BY DATAENTREGA ASC; ";
            db.CommandText = select + from + where + order;
            var ds = db.ExecuteDataSet();
            return ds;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectP(string Numero)
        {
            var db = new DBAcess();
            var Mysql = " SELECT E.CODPRODUTO, P.NOME, E.LOTE, E.QUANTIDADE, P.UNIDADE, NULL AS ENTREGUE, E.ESTOQUEUBS ";
            Mysql = Mysql + " FROM Pedido_item AS E ";
            Mysql = Mysql + " INNER JOIN produtos AS  P ON P.CODPRODUTO = E.CODPRODUTO ";
            Mysql = Mysql + " WHERE E.NUMEROPEDIDO = @NUMEROPEDIDO ";

            db.CommandText = Mysql;
            db.AddParameter("@NUMEROPEDIDO", Numero);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectPC(int Numero)
        {
            var db = new DBAcess();
            var Mysql = " SELECT E.CODPRODUTO, P.NOME, E.LOTE, E.QUANTIDADE, P.UNIDADE, NULL AS ENTREGUE, E.ESTOQUEUBS ";
            Mysql = Mysql + " FROM Pedido_item AS E ";
            Mysql = Mysql + " INNER JOIN produtos AS  P ON P.CODPRODUTO = E.CODPRODUTO ";
            Mysql = Mysql + " WHERE E.CODPEDIDO = @CODPEDIDO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODPEDIDO", Numero);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectOficio(int codigo)
        {
            var db = new DBAcess();
            var Mysql = " SELECT E.CODPRODUTO, P.NOME, E.LOTE, E.QUANTIDADE, P.UNIDADE, NULL AS ENTREGUE, E.ESTOQUEUBS, E.PARAQUEM ";
            Mysql = Mysql + " FROM Pedido_item AS E ";
            Mysql = Mysql + " INNER JOIN produtos AS  P ON P.CODPRODUTO = E.CODPRODUTO ";
            Mysql = Mysql + " WHERE E.CODPEDIDO = @CODPEDIDO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODPEDIDO", codigo);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

    }
}