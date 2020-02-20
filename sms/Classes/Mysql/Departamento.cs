using System;
using System.ComponentModel;
using System.Data;
using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;

namespace Atencao_Assistida.Classes.Mysql
{
    [DataObject(true)]
    public class Departamento
    {

        private int CodDepartamento { get; set; }
        private string Nome { get; set; }
        private string Telefone { get; set; }
        private string Email { get; set; }
        private string Caminhologo { get; set; }
        private string Ativa { get; set; }
        private string Respinclusao { get; set; }
        private string Datahorainclusao { get; set; }
        private string Respalteracao { get; set; }
        private string Datahoraalteracao { get; set; }
        private string Excluido { get; set; }


        public Departamento(int codDepartamento, string nome, string telefone, string email, string ativa,
            string respinclusao, string datahorainclusao, string respalteracao,
            string datahoraalteracao, string excluido)
        {
            CodDepartamento = codDepartamento;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Ativa = ativa;
            Respinclusao = respinclusao;
            Datahorainclusao = datahorainclusao;
            Respalteracao = respalteracao;
            Datahoraalteracao = datahoraalteracao;
            Excluido = excluido;

        }

        public Departamento(int codDepartamento)
        {
            CodDepartamento = codDepartamento;
        }

        public Departamento()
        {

        }

        public int Insert()
        {
            var db = new DBAcess();
            const string insert = " INSERT INTO Departamento(" +
                                  " NOME, TELEFONE, " +
                                  " EMAIL, ATIVA, RESPINCLUSAO, DATAHORAINCLUSAO, " +
                                  " EXCLUIDO" +

                                  ") ";
            const string values = " VALUES(" +
                                  " @NOME, @TELEFONE, " +
                                  " @EMAIL, @ATIVA, @RESPINCLUSAO, @DATAHORAINCLUSAO, " +
                                  " @EXCLUIDO" +
                                  "); ";
            const string select = " ";
            db.CommandText = insert + values + select;
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@TELEFONE", Telefone);
            db.AddParameter("@EMAIL", Email);
            db.AddParameter("@CAMINHOLOGO", Caminhologo);
            db.AddParameter("@ATIVA", Ativa);
            db.AddParameter("@RESPINCLUSAO", Respinclusao);
            db.AddParameter("@DATAHORAINCLUSAO", Convert.ToDateTime(Datahorainclusao));
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
            const string update = " UPDATE Departamento ";
            const string set = " SET" +
                               " NOME = @NOME, TELEFONE = @TELEFONE, " +
                               " EMAIL = @EMAIL, " +
                               " ATIVA = @ATIVA, " +
                               " RESPALTERACAO = @RESPALTERACAO, DATAHORAALTERACAO = @DATAHORAALTERACAO, EXCLUIDO = @EXCLUIDO";
            const string where = " WHERE CODDEPARTAMENTO = @CODDEPARTAMENTO;";
            db.CommandText = update + set + where;
            db.AddParameter("@CODDEPARTAMENTO", CodDepartamento);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@TELEFONE", Telefone);
            db.AddParameter("@EMAIL", Email);
           
            db.AddParameter("@ATIVA", Ativa);
            db.AddParameter("@RESPALTERACAO", Respalteracao);
            db.AddParameter("@DATAHORAALTERACAO", Convert.ToDateTime(Datahoraalteracao));
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

        public int InsertAccess(int Coddepartamento, string Nome, string Telefone, string Email, string Respinclusao, string Datahorainclusao, string Respalteracao, string Datahoraalteracao)
        {
            var db = new DBAcessOleDB();
            var Mysql = " INSERT INTO Departamento(";
            Mysql = Mysql + " CODDEPARTAMENTO, NOME, TELEFONE, ";
            Mysql = Mysql + " EMAIL, RESPINCLUSAO, DATAHORAINCLUSAO, RESPALTERACAO , DATAHORAALTERACAO ";
            Mysql = Mysql + ") ";

            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODDEPARTAMENTO, @NOME, @TELEFONE, ";
            Mysql = Mysql + " @EMAIL, @RESPINCLUSAO, @DATAHORAINCLUSAO, @RESPALTERACAO , @DATAHORAALTERACAO ";
            Mysql = Mysql + "); ";
            
            db.CommandText = Mysql;

            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@TELEFONE", Telefone);
            db.AddParameter("@EMAIL", Email);
            db.AddParameter("@RESPINCLUSAO", Respinclusao);
            db.AddParameter("@DATAHORAINCLUSAO", Convert.ToDateTime(Datahorainclusao));
            db.AddParameter("@RESPALTERACAO", Respalteracao);
            db.AddParameter("@DATAHORAALTERACAO", Convert.ToDateTime(Datahoraalteracao));

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
            var Mysql = " DELETE FROM Departamento ";
            
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
        public static MySqlDataReader Select(int codDepartamento)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Departamento ";
            const string where = " WHERE codDepartamento = @codDepartamento ";
            db.CommandText = select + from + where;
            db.AddParameter("@codDepartamento", codDepartamento);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectTudo()
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Departamento ";

            db.CommandText = select + from;

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet SelectTodos()
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Departamento ";
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
            const string from = " FROM Departamento ";
            var where = "  ";
            switch (por)
            {
                case "Departamento":
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

        public static bool Delete(int codDepartamento)
        {
            var db = new DBAcess();
            const string delete = " DELETE FROM Departamento ";
            const string where = "WHERE codDepartamento = @codDepartamento";
            db.CommandText = delete + where;
            db.AddParameter("@codDepartamento", codDepartamento);
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
