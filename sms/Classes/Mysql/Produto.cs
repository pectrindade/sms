using System;
using System.ComponentModel;
using System.Data;
using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;

namespace Atencao_Assistida.Classes.Mysql
{
    public class Produto
    {

        private int Codproduto { get; set; }
        private string Nome { get; set; }
        private string Descricao { get; set; }
        private string Codgrupo { get; set; }
        private string Codmarca { get; set; }
        private string Unidade { get; set; }
        private string Ativo { get; set; }
        private string Respinclusao { get; set; }
        private string Datainclusao { get; set; }
        private string Respalteracao { get; set; }
        private string Dataalteracao { get; set; }
        private string Excluido { get; set; }
        private int CodDepartamento { get; set; }


        public Produto(int codproduto, string nome, string descricao, string codgrupo, string codmarca, string unidade,
        string ativo, string respinclusao, string datainclusao, string respalteracao, string dataalteracao,
        string excluido, int coddepartamento)
        {
            Codproduto = codproduto;

            Nome = nome;
            Descricao = descricao;
            Codgrupo = codgrupo;
            Codmarca = codmarca;
            Unidade = unidade;
            Ativo = ativo;
            Respinclusao = respinclusao;
            Datainclusao = datainclusao;
            Respalteracao = respalteracao;
            Dataalteracao = dataalteracao;
            Excluido = excluido;
            CodDepartamento = coddepartamento;

        }

        public Produto()
        {

        }

        public int Insert()
        {
            var db = new DBAcess();
            const string insert = " INSERT INTO produtos( " +
                                " NOME, DESCRICAO, CODGRUPO, CODMARCA, UNIDADE, ATIVO, RESPINCLUSAO, DATAINCLUSAO, " +
                                " RESPALTERACAO, DATAALTERACAO, EXCLUIDO, CODDEPARTAMENTO " +
                                ") ";
            const string values = " VALUES(" +
                                " @NOME, @DESCRICAO, @CODGRUPO, @CODMARCA, @UNIDADE, @ATIVO, @RESPINCLUSAO, " +
                                " @DATAINCLUSAO, @RESPALTERACAO, @DATAALTERACAO, @EXCLUIDO, @CODDEPARTAMENTO " +
                                "); ";
            const string select = " ";
            db.CommandText = insert + values + select;
                        
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@DESCRICAO", Descricao);
            db.AddParameter("@CODGRUPO", Codgrupo);
            db.AddParameter("@CODMARCA", Codmarca);
            db.AddParameter("@UNIDADE", Unidade);
            db.AddParameter("@ATIVO", Ativo);
            db.AddParameter("@RESPINCLUSAO", Respinclusao);
            db.AddParameter("@DATAINCLUSAO", Convert.ToDateTime(Datainclusao));
            db.AddParameter("@RESPALTERACAO", Respalteracao);
            db.AddParameter("@DATAALTERACAO", Convert.ToDateTime(Dataalteracao));
            db.AddParameter("@EXCLUIDO", Excluido);
            db.AddParameter("@CODDEPARTAMENTO", CodDepartamento);

            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }

        public int InsertAccess(int codproduto, string nome, string descricao, int coddepartamento, string nomedepartamento, int codgrupo, string grupo, int codmarca, string marca, string unidade,
        string respinclusao, string datainclusao, string respalteracao, string dataalteracao)
        {
            var db = new DBAcessOleDB();

            var Mysql = " INSERT INTO produtos( ";
            Mysql = Mysql + " CODPRODUTO, NOME, DESCRICAO, CODDEPARTAMENTO , NOMEDEPARTAMENTO, CODGRUPO, NOMEGRUPO, CODMARCA, NOMEMARCA, UNIDADE ";
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODPRODUTO, @NOME, @DESCRICAO, @CODDEPARTAMENTO, @NOMEDEPARTAMENTO, @CODGRUPO, @NOMEGRUPO, @CODMARCA, @NOMEMARCA, @UNIDADE ";
            Mysql = Mysql + "); ";
            
            db.CommandText = Mysql;

            db.AddParameter("@CODPRODUTO", codproduto);
            db.AddParameter("@NOME", nome);
            db.AddParameter("@DESCRICAO", descricao);
            
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@NOMEDEPARTAMENTO", nomedepartamento);

            db.AddParameter("@CODGRUPO", codgrupo);
            db.AddParameter("@NOMEGRUPO", grupo);

            db.AddParameter("@CODMARCA", codmarca);
            db.AddParameter("@NOMEMARCA", marca);
            db.AddParameter("@UNIDADE", unidade);

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
            const string update = " UPDATE produtos ";
            const string set = " SET " +
                               " NOME = @NOME, DESCRICAO = @DESCRICAO, CODGRUPO = @CODGRUPO, " +
                               " CODMARCA = @CODMARCA, UNIDADE = @UNIDADE, ATIVO = @ATIVO, RESPINCLUSAO = @RESPINCLUSAO, " +
                               " DATAINCLUSAO = @DATAINCLUSAO, RESPALTERACAO = @RESPALTERACAO, DATAALTERACAO = @DATAALTERACAO, " +
                               " EXCLUIDO = @EXCLUIDO, CODDEPARTAMENTO = @CODDEPARTAMENTO ";

            const string where = " WHERE CODPRODUTO = @CODPRODUTO;";
            db.CommandText = update + set + where;
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@DESCRICAO", Descricao);
            db.AddParameter("@CODGRUPO", Codgrupo);
            db.AddParameter("@CODMARCA", Codmarca);
            db.AddParameter("@UNIDADE", Unidade);
            db.AddParameter("@ATIVO", Ativo);
            db.AddParameter("@RESPINCLUSAO", Respinclusao);
            db.AddParameter("@DATAINCLUSAO", Convert.ToDateTime(Datainclusao));
            db.AddParameter("@RESPALTERACAO", Respalteracao);
            db.AddParameter("@DATAALTERACAO", Convert.ToDateTime(Dataalteracao));
            db.AddParameter("@EXCLUIDO", Excluido);
            db.AddParameter("@CODDEPARTAMENTO", CodDepartamento);

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

        public bool UpdateAccess()
        {
            var db = new DBAcessOleDB();
            const string update = " UPDATE produtos ";
            const string set = " SET " +
                               " NOME = @NOME, DESCRICAO = @DESCRICAO, CODGRUPO = @CODGRUPO, " +
                               " CODMARCA = @CODMARCA, UNIDADE = @UNIDADE, ATIVO = @ATIVO, RESPINCLUSAO = @RESPINCLUSAO, " +
                               " DATAINCLUSAO = @DATAINCLUSAO, RESPALTERACAO = @RESPALTERACAO, DATAALTERACAO = @DATAALTERACAO, " +
                               " EXCLUIDO = @EXCLUIDO ";

            const string where = " WHERE CODPRODUTO = @CODPRODUTO;";
            db.CommandText = update + set + where;
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@DESCRICAO", Descricao);
            db.AddParameter("@CODGRUPO", Codgrupo);
            db.AddParameter("@CODMARCA", Codmarca);
            db.AddParameter("@UNIDADE", Unidade);
            db.AddParameter("@ATIVO", Ativo);
            db.AddParameter("@RESPINCLUSAO", Respinclusao);
            db.AddParameter("@DATAINCLUSAO", Convert.ToDateTime(Datainclusao));
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(int Codproduto)
        {
            var db = new DBAcess();
            var Mysql = " SELECT P.CODPRODUTO, P.NOME, P.DESCRICAO, P.CODGRUPO, P.CODMARCA, P.UNIDADE AS CODUNIDADE, U.DESCRICAO AS NOMEUNIDADE, P.ATIVO, P.CODDEPARTAMENTO ";
            Mysql = Mysql + " FROM produtos AS P ";
            Mysql = Mysql + " INNER JOIN unidademedida AS U ON U.DESCRICAO = P.UNIDADE ";

            Mysql = Mysql + " WHERE P.CODPRODUTO = @CODPRODUTO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODPRODUTO", Codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(int Codproduto, int coddepartamento)
        {
            var db = new DBAcess();
            var Mysql = " SELECT P.CODPRODUTO, P.NOME, P.DESCRICAO, P.CODGRUPO, P.CODMARCA, P.UNIDADE AS CODUNIDADE, U.DESCRICAO AS NOMEUNIDADE, P.ATIVO ";
            Mysql = Mysql + " FROM produtos AS P ";
            Mysql = Mysql + " INNER JOIN unidademedida AS U ON U.DESCRICAO = P.UNIDADE ";

            Mysql = Mysql + " WHERE P.CODPRODUTO = @CODPRODUTO ";
            Mysql = Mysql + " AND P.CODDEPARTAMENTO = @CODDEPARTAMENTO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(string valor)
        {
            var db = new DBAcess();
            var select = " select p.* ";
            var from = " from produtos AS p ";
            var where = "  ";

            if (valor != "")
            {
                where = "WHERE p.NOME LIKE @valor";
                valor = '%' + valor + "%";

            }  

           
            const string order = " ORDER BY p.NOME ASC; ";
            db.CommandText = select + from + where + order;
            db.AddParameter("@valor", valor);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectRel()
        {
            var db = new DBAcess();

            var Mysql = " SELECT P.CODPRODUTO, P.NOME, P.DESCRICAO, P.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO,  ";
            Mysql = Mysql + " P.CODGRUPO, G.DESCRICAO AS NOMEGRUPO, ";
            Mysql = Mysql + " P.CODMARCA, M.DESCRICAO AS NOMEMARCA, ";
            Mysql = Mysql + " P.UNIDADE ";
            Mysql = Mysql + " FROM produtos P ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = P.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN grupo G ON G.CODGRUPO = P.CODGRUPO ";
            Mysql = Mysql + " INNER JOIN marca M ON M.CODMARCA = P.CODMARCA ";
           
            Mysql = Mysql + " ORDER BY p.NOME ASC; ";
            db.CommandText = Mysql;
            //db.AddParameter("@valor", valor);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        public int SelectCount()
        {
            int retorno = 0;

            var db = new DBAcess();
            var Mysql = " SELECT COUNT(CODPRODUTO) AS PRODUTOS  ";
            Mysql = Mysql + " FROM produtos ";
            Mysql = Mysql + "  ";

            db.CommandText = Mysql;
           

            var dr = (MySqlDataReader)db.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    retorno = dr.GetInt32(dr.GetOrdinal("PRODUTOS"));

                }
            }

            dr.Dispose();
            dr.Close();

            return retorno;
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(string codproduto, int coddepartamento, string codgrupo)
        {
            var db = new DBAcess();
            var Mysql = " select p.* ";
            Mysql = Mysql + " from produtos AS p ";
            Mysql = Mysql + " WHERE p.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND p.ATIVO = 1 ";

            if (codproduto != "") { Mysql = Mysql + " AND p.CODPRODUTO = @CODPRODUTO "; }
            if (codgrupo != "") { Mysql = Mysql + " AND p.CODGRUPO = @CODGRUPO "; }

            db.CommandText = Mysql;
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);

            if (codproduto == "") { codproduto = "0"; }
            if (codgrupo == "") { codgrupo = "0"; }

            db.AddParameter("@CODPRODUTO", int.Parse(codproduto));
            db.AddParameter("@CODGRUPO", int.Parse(codgrupo));
                       

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectPorNome(string valor, int coddepartamento)
        {
            var db = new DBAcess();
            var Mysql = " select p.* ";
            Mysql = Mysql + " from produtos AS p ";
            Mysql = Mysql + " WHERE p.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND p.ATIVO = 1 ";

            if (valor != "")
            {
                Mysql = Mysql + " AND p.NOME LIKE @valor ";
                valor = '%' + valor + "%";
            }

            Mysql = Mysql + " ORDER BY p.NOME ASC; ";
            db.CommandText = Mysql;
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@valor", valor);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet SelectTodos()
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM produtos ";
            //Mysql = Mysql + " WHERE CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " ORDER BY NOME ASC; ";
            db.CommandText = Mysql;
            //db.AddParameter("@CODDEPARTAMENTO", coddepartamento);

            var ds = db.ExecuteDataSet();
            return ds;
        }
                
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectTodos(int coddepartamento)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM produtos ";
            Mysql = Mysql + " WHERE CODDEPARTAMENTO = @CODDEPARTAMENTO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        public static bool Delete(int Codproduto)
        {
            var db = new DBAcess();
            const string delete = " DELETE FROM produtos ";
            const string where = "WHERE CODPRODUTO = @CODPRODUTO";
            db.CommandText = delete + where;
            db.AddParameter("@CODPRODUTO", Codproduto);
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

        public bool DeleteAccess()
        {
            var db = new DBAcessOleDB();
            const string delete = " DELETE FROM produtos ";
           
            db.CommandText = delete;
           
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet Select(string por, string valor)
        {
            var db = new DBAcess();
            var select = " select p.CODPRODUTO,  p.NOME, p.NOME, g.DESCRICAO as GRUPO, m.DESCRICAO as MARCA, '' as LOTE, '' as VALIDADE, '' as QUANTIDADE ";
            var from = " from produtos AS p ";
            from = from + " inner join grupo as g on p.CODGRUPO = g.CODGRUPO ";
            from = from + " inner join marca as m on p.CODMARCA = m.CODMARCA ";

            var where = "  ";
            switch (por)
            {
                case "Nome":
                    {
                        where = "WHERE p.NOME LIKE @valor";
                        valor = '%' + valor + "%";
                    }
                    break;
                case "Grupo":
                    {
                        where = "WHERE g.DESCRICAO LIKE @valor";
                        valor = '%' + valor + "%";
                    }
                    break;

                case "Codigo":
                    {
                        where = "WHERE p.CODPRODUTO = @valor";
                    }
                    break;

            }
            const string order = " ORDER BY p.DESCRICAO ASC; ";
            db.CommandText = select + from + where + order;
            db.AddParameter("@valor", valor);
            var ds = db.ExecuteDataSet();
            return ds;
        }

        public bool DeletePrevisao_Entrega()
        {
            var db = new DBAcessOleDB();
            const string delete = " DELETE FROM Previsao_Entrega ";

            db.CommandText = delete;

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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectPrevisao_Entrega(string data, string codigoproduto, string especialidade)
        {
            var parametro = "N";

            if (data.Trim() != "") { parametro = "S"; }
            if (codigoproduto.Trim() != "") { parametro = "S"; }
            if (especialidade.Trim() != "") { parametro = "S"; }

            var db = new DBAcess();
            var Mysql = " SELECT P.CODPRODUTO, P.NOME, UM.DESCRICAO AS UND, SUM(PI.QUANTIDADE) AS QUANTIDADE ";
            Mysql = Mysql + " FROM produtos AS P ";
            Mysql = Mysql + " INNER JOIN protocolo_item AS PI ON P.CODPRODUTO = PI.CODPRODUTO ";
            Mysql = Mysql + " INNER JOIN unidademedida AS UM ON P.UNIDADE = UM.CODUNIDADEMEDIDA ";

            if (parametro == "N")
            {
                Mysql = Mysql + " GROUP BY P.NOME ";
                Mysql = Mysql + " ORDER BY P.CODPRODUTO ";
            }
            else
            { 
                Mysql = Mysql + " WHERE P.CODPRODUTO = @CODPRODUTO ";

            }


            db.CommandText = Mysql;
            db.AddParameter("@CODPRODUTO", codigoproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet CountPrevisao_Entrega(string valor)
        {
            var db = new DBAcess();
            var Mysql = " SELECT P.CODPRODUTO, P.NOME, UM.DESCRICAO AS UND, SUM(PI.QUANTIDADE) AS QUANTIDADE ";
            Mysql = Mysql + " FROM produtos AS P ";
            Mysql = Mysql + " INNER JOIN protocolo_item AS PI ON P.CODPRODUTO = PI.CODPRODUTO ";
            Mysql = Mysql + " INNER JOIN unidademedida AS UM ON P.UNIDADE = UM.CODUNIDADEMEDIDA ";

            Mysql = Mysql + " GROUP BY P.NOME ";
            Mysql = Mysql + " ORDER BY P.CODPRODUTO ";

            db.CommandText = Mysql;
            db.AddParameter("@valor", valor);
            var ds = db.ExecuteDataSet();
            return ds;
        }

        public int InsertPrevisao_Entrega(int codproduto, string descricao, string und, int quantidade)
        {
            var db = new DBAcessOleDB();
            const string insert = " INSERT INTO Previsao_Entrega( " +
                                " CODPRODUTO, DESCRICAO, UND, QUANTIDADE " +
                                ") ";
            const string values = " VALUES(" +
                                " @CODPRODUTO, @DESCRICAO, @UND, @QUANTIDADE " +
                                "); ";
            const string select = " ";
            db.CommandText = insert + values + select;

            db.AddParameter("@CODPRODUTO", codproduto);
            db.AddParameter("@DESCRICAO", descricao);
            db.AddParameter("@UND", und);
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