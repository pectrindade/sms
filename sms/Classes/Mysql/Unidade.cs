using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;

namespace Atencao_Assistida.Classes.Mysql
{
    [DataObject(true)]
    public class Unidade
    {

        private int Codunidade { get; set; }
        private string Nome { get; set; }
        private string Telefone { get; set; }
        private string Email { get; set; }
        private string Endereco { get; set; }
        private string Bairro { get; set; }
        private string Ativa { get; set; }
        private string Respinclusao { get; set; }
        private string Datainclusao { get; set; }
        private string Respalteracao { get; set; }
        private string Dataalteracao { get; set; }
        private string Excluido { get; set; }


        public Unidade(int codunidade, string nome, string telefone, string email,
            string endereco, string bairro,
            string ativa,
            string respinclusao, string datainclusao, string respalteracao,
            string dataalteracao, string excluido)
        {
            Codunidade = codunidade;
            Nome = nome;
            Endereco = endereco;
            Bairro = bairro;
            Telefone = telefone;
            Email = email;
            Ativa = ativa;
            Respinclusao = respinclusao;
            Datainclusao = datainclusao;
            Respalteracao = respalteracao;
            Dataalteracao = dataalteracao;
            Excluido = excluido;

        }

        public Unidade(int codunidade)
        {
            Codunidade = codunidade;
        }

        public Unidade()
        {

        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO Unidade(";
            Mysql = Mysql + " NOME, TELEFONE, EMAIL, ENDERECO, BAIRRO, ";
            Mysql = Mysql + " ATIVA, RESPINCLUSAO, DATAINCLUSAO, ";
            Mysql = Mysql + " EXCLUIDO";
            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @NOME, @TELEFONE, @EMAIL, @ENDERECO, @BAIRRO, ";
            Mysql = Mysql + " @ATIVA, @RESPINCLUSAO, @DATAINCLUSAO, ";
            Mysql = Mysql + " @EXCLUIDO";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@NOME", Nome);
            db.AddParameter("@TELEFONE", Telefone);
            db.AddParameter("@EMAIL", Email);
            db.AddParameter("@ENDERECO", Endereco);
            db.AddParameter("@BAIRRO", Bairro);
            db.AddParameter("@ATIVA", Ativa);
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
            var Mysql = " UPDATE Unidade ";
            Mysql = Mysql + " SET";
            Mysql = Mysql + " NOME = @NOME, TELEFONE = @TELEFONE, EMAIL = @EMAIL, ";
            Mysql = Mysql + " ENDERECO = @ENDERECO, BAIRRO = @BAIRRO, ";
            Mysql = Mysql + " ATIVA = @ATIVA, ";
            Mysql = Mysql + " RESPALTERACAO = @RESPALTERACAO, DATAALTERACAO = @DATAALTERACAO, EXCLUIDO = @EXCLUIDO";
            Mysql = Mysql + " WHERE codUnidade = @CODUnidade;";

            db.CommandText = Mysql;

            db.AddParameter("@CODUNIDADE", Codunidade);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@TELEFONE", Telefone);
            db.AddParameter("@EMAIL", Email);
            db.AddParameter("@ENDERECO", Endereco);
            db.AddParameter("@BAIRRO", Bairro);

            db.AddParameter("@ATIVA", Ativa);
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

        public int InsertAccess(int codunidade, string nome, string telefone, string email,
            string endereco, string bairro,
            string respinclusao, string datainclusao, string respalteracao,
            string dataalteracao)

        {
            var db = new DBAcessOleDB();

            var Mysql = " INSERT INTO Unidade(";
            Mysql = Mysql + " CODUNIDADE, NOME, TELEFONE, EMAIL, ENDERECO, BAIRRO, ";
            Mysql = Mysql + " RESPINCLUSAO, DATAHORAINCLUSAO, RESPALTERACAO, DATAHORAALTERACAO ";
            Mysql = Mysql + ") ";

            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODUNIDADE, @NOME, @TELEFONE, @EMAIL, @ENDERECO, @BAIRRO, ";
            Mysql = Mysql + " @RESPINCLUSAO, @DATAHORAINCLUSAO, @RESPALTERACAO, @DATAHORAALTERACAO ";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODUNIDADE", codunidade);
            db.AddParameter("@NOME", nome);
            db.AddParameter("@TELEFONE", telefone);
            db.AddParameter("@EMAIL", email);
            db.AddParameter("@ENDERECO", endereco);
            db.AddParameter("@BAIRRO", bairro);
            db.AddParameter("@RESPINCLUSAO", respinclusao);
            db.AddParameter("@DATAHORAINCLUSAO", Convert.ToDateTime(datainclusao));
            db.AddParameter("@RESPALTERACAO", respalteracao);
            db.AddParameter("@DATAHORAALTERACAO", Convert.ToDateTime(dataalteracao));

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
        public static MySqlDataReader Select(int codUnidade)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Unidade ";
            const string where = " WHERE CODUNIDADE = @CODUNIDADE ";
            db.CommandText = select + from + where;
            db.AddParameter("@CODUNIDADE", codUnidade);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectTudo()
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Unidade ";

            db.CommandText = select + from;


            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet SelectTodos()
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Unidade ";
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
            const string from = " FROM Unidade ";
            var where = "  ";
            switch (por)
            {
                case "nome":
                    {
                        where = "WHERE Nome LIKE @valor";
                        valor = '%' + valor + "%";
                    }
                    break;

                case "cnpj_cpf":
                    {
                        where = "WHERE CNPJ LIKE @valor";
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
        public static MySqlDataReader Selectdr(string valor)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Unidade ";


            Mysql = Mysql + "WHERE Nome LIKE @valor";
            valor = '%' + valor + "%";

            Mysql = Mysql + " ORDER BY Nome ASC; ";

            db.CommandText = Mysql;

            db.AddParameter("@valor", valor);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }


        public static bool Delete(int codUnidade)
        {
            var db = new DBAcess();
            const string delete = " DELETE FROM Unidade ";
            const string where = "WHERE CODUNIDADE = @CODUNIDADE";
            db.CommandText = delete + where;
            db.AddParameter("@CODUNIDADE", codUnidade);
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
