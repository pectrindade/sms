using System;
using System.ComponentModel;
using System.Data;
using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;

namespace Atencao_Assistida.Classes.Mysql
{
    [DataObject(true)]
    public class Fornecedor
    {

        private int CodFornecedor { get; set; }
        private string Nome { get; set; }
        private string Cnpj { get; set; }
        private string Telefone { get; set; }
        private string Email { get; set; }
        private string Caminhologo { get; set; }
        private string Ativa { get; set; }
        private string Respinclusao { get; set; }
        private string Datahorainclusao { get; set; }
        private string Respalteracao { get; set; }
        private string Datahoraalteracao { get; set; }
        private string Excluido { get; set; }
        private int CodDepartamento { get; set; }


        public Fornecedor(int codFornecedor, string nome, string cnpj, string telefone, string email, string ativa,
            string respinclusao, string datahorainclusao, string respalteracao,
            string datahoraalteracao, string excluido, int coddepartamento)
        {
            CodFornecedor = codFornecedor;
            Nome = nome;
            Cnpj = cnpj;
            Telefone = telefone;
            Email = email;
            Ativa = ativa;
            Respinclusao = respinclusao;
            Datahorainclusao = datahorainclusao;
            Respalteracao = respalteracao;
            Datahoraalteracao = datahoraalteracao;
            Excluido = excluido;
            CodDepartamento = coddepartamento;

        }
              

        public Fornecedor(int codFornecedor)
        {
            CodFornecedor = codFornecedor;
        }

        public Fornecedor()
        {

        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO Fornecedor(";
            Mysql = Mysql + " NOME, CNPJ, TELEFONE, ";
            Mysql = Mysql + " EMAIL, ATIVA, RESPINCLUSAO, DATAINCLUSAO, ";
            Mysql = Mysql + " EXCLUIDO, CODDEPARTAMENTO ";

            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @NOME, @CNPJ, @TELEFONE, ";
            Mysql = Mysql + " @EMAIL, @ATIVA, @RESPINCLUSAO, @DATAINCLUSAO, ";
            Mysql = Mysql + " @EXCLUIDO, @CODDEPARTAMENTO ";
            Mysql = Mysql + "); ";
            
            db.CommandText = Mysql;

            db.AddParameter("@NOME", Nome);
            db.AddParameter("@CNPJ", Cnpj);
            db.AddParameter("@TELEFONE", Telefone);
            db.AddParameter("@EMAIL", Email);
            db.AddParameter("@ATIVA", Ativa);
            db.AddParameter("@RESPINCLUSAO", Respinclusao);
            db.AddParameter("@DATAINCLUSAO", Convert.ToDateTime(Datahorainclusao));
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

        public bool Update()
        {
            var db = new DBAcess();
            const string update = " UPDATE Fornecedor ";
            const string set = " SET" +
                               " NOME = @NOME, CNPJ = @CNPJ, TELEFONE = @TELEFONE, " +
                               " EMAIL = @EMAIL, " +
                               " ATIVA = @ATIVA, " +
                               " RESPALTERACAO = @RESPALTERACAO, DATAALTERACAO = @DATAALTERACAO, EXCLUIDO = @EXCLUIDO, CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            const string where = " WHERE CODFORNECEDOR = @CODFORNECEDOR;";
            db.CommandText = update + set + where;
            db.AddParameter("@CODFORNECEDOR", CodFornecedor);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@CNPJ", Cnpj);
            db.AddParameter("@TELEFONE", Telefone);
            db.AddParameter("@EMAIL", Email);

            db.AddParameter("@ATIVA", Ativa);
            db.AddParameter("@RESPALTERACAO", Respalteracao);
            db.AddParameter("@DATAALTERACAO", Convert.ToDateTime(Datahoraalteracao));
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

        public int InsertAccess(int codFornecedor, string nomefornecedor, int coddepartamento, string nomedepartamento, 
            string cnpj, string telefone, string email, 
            string respinclusao, string datahorainclusao, string respalteracao, string datahoraalteracao)
        {
            var db = new DBAcessOleDB();

            var Mysql = " INSERT INTO Fornecedor(";
            Mysql = Mysql + " CODFORNECEDOR, NOMEFORNECEDOR, CODDEPARTAMENTO, NOMEDEPARTAMENTO, ";
            Mysql = Mysql + " CNPJ, TELEFONE, EMAIL, ";
            Mysql = Mysql + " RESPINCLUSAO, DATAHORAINCLUSAO, RESPALTERACAO, DATAHORAALTERACAO  ";

            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODFORNECEDOR, @NOMEFORNECEDOR, @CODDEPARTAMENTO, @NOMEDEPARTAMENTO, ";
            Mysql = Mysql + " @CNPJ, @TELEFONE, @EMAIL, ";
            Mysql = Mysql + " @RESPINCLUSAO, @DATAHORAINCLUSAO, @RESPALTERACAO, @DATAHORAALTERACAO  ";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODFORNECEDOR", codFornecedor);
            db.AddParameter("@NOMEFORNECEDOR", nomefornecedor);

            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@NOMEDEPARTAMENTO", nomedepartamento);

            db.AddParameter("@CNPJ", cnpj);
            db.AddParameter("@TELEFONE", telefone);
            db.AddParameter("@EMAIL", email);
           
            db.AddParameter("@RESPINCLUSAO", respinclusao);
            db.AddParameter("@DATAHORAINCLUSAO", Convert.ToDateTime(datahorainclusao));
            db.AddParameter("@RESPALTERACAO", respalteracao);
            db.AddParameter("@DATAHORAALTERACAO", Convert.ToDateTime(datahoraalteracao));

            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }

        public bool DeleteAccess()
        {
            var db = new DBAcessOleDB();
            var Mysql = " DELETE FROM Fornecedor ";
            //Mysql = Mysql + "WHERE codFornecedor = @codFornecedor";
            db.CommandText = Mysql;

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
        public static MySqlDataReader Select(int codFornecedor)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Fornecedor ";
            Mysql = Mysql + " WHERE codFornecedor = @codFornecedor ";
            db.CommandText = Mysql;
            db.AddParameter("@codFornecedor", codFornecedor);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectTudoRel()
        {
            var db = new DBAcess();
            var Mysql = " SELECT F.CODFORNECEDOR, F.NOME AS NOMEFORNECEDOR, F.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, ";
            Mysql = Mysql + " F.CNPJ, F.TELEFONE, F.EMAIL, ";
            Mysql = Mysql + " F.RESPINCLUSAO, F.DATAINCLUSAO AS DATAHORAINCLUSAO, F.RESPALTERACAO, F.DATAALTERACAO AS DATAHORAALTERACAO ";
            Mysql = Mysql + " FROM fornecedor F ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = F.CODDEPARTAMENTO ";

            db.CommandText = Mysql;

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectTudo()
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Fornecedor ";

            db.CommandText = Mysql;

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectTudo(int departamento)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Fornecedor ";
            Mysql = Mysql + " WHERE CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            db.CommandText = Mysql;
            db.AddParameter("@CODDEPARTAMENTO", departamento);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectCnpj(string cnpj)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Fornecedor ";
            Mysql = Mysql + " WHERE CNPJ = @CNPJ ";
            db.CommandText = Mysql;
            db.AddParameter("@CNPJ", cnpj);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectNome(string nome)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Fornecedor ";
            Mysql = Mysql + "WHERE Nome LIKE CONCAT(@NOME)";
            nome = '%' + nome + "%";
            db.CommandText = Mysql;
            db.AddParameter("@NOME", nome);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet SelectTodos()
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Fornecedor ";
            const string where = "  ";
            const string order = " ORDER BY Nome ASC; ";
            db.CommandText = select + from + where + order;
            var ds = db.ExecuteDataSet();
            return ds;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet Select(string por, string valor)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Fornecedor ";
            var where = "  ";
            switch (por)
            {
                case "Fornecedor":
                    {
                        where = "WHERE Nome LIKE CONCAT(@valor)";
                        valor = '%' + valor + "%";
                    }
                    break;

                case "cnpj_cpf":
                    {
                        where = "WHERE CNPJ LIKE CONCAT(@valor)";
                        valor = '%' + valor + "%";
                    }
                    break;

            }
            const string order = " ORDER BY Nome ASC; ";
            db.CommandText = select + from + where + order;
            db.AddParameter("@valor", valor);
            var ds = db.ExecuteDataSet();
            return ds;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectLista(string campo, string valor)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Fornecedor ";
            
            switch (campo)
            {
                case "nome":
                    {
                        Mysql = Mysql + " WHERE NOME LIKE CONCAT(@valor) ";
                        valor = '%' + valor + "%";
                    }
                    break;

                case "cnpj":
                    {
                        Mysql = Mysql + " WHERE CNPJ LIKE CONCAT(@valor) ";
                        //valor = '%' + valor + "%";
                    }
                    break;
                case "codigo":
                    {
                        Mysql = Mysql + " WHERE CODFORNECEDOR LIKE CONCAT(@valor) ";
                        valor = '%' + valor + "%";
                    }
                    break;
            }

            Mysql = Mysql + " ORDER BY Nome ASC; ";

            db.CommandText = Mysql;

            db.AddParameter("@valor", valor);


            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        public static bool Delete(int codFornecedor)
        {
            var db = new DBAcess();
            const string delete = " DELETE FROM Fornecedor ";
            const string where = "WHERE codFornecedor = @codFornecedor";
            db.CommandText = delete + where;
            db.AddParameter("@codFornecedor", codFornecedor);
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


    }
}
