using System;
using System.ComponentModel;
using System.Data;
using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;

namespace Atencao_Assistida.Classes.Mysql
{

    [DataObject(true)]
    public class Empresa
    {

        private int Codempresa { get; set; }
        private string Nome { get; set; }
        private string Endereco { get; set; }
        private string Bairro { get; set; }
        private int Codcidade { get; set; }
        private int Codestado { get; set; }
        private string Telefone { get; set; }
        private string Email { get; set; }
        private string Caminhologo { get; set; }
        private string Obs { get; set; }
        private string Ativa { get; set; }
        private string Respinclusao { get; set; }
        private string Datahorainclusao { get; set; }
        private string Respalteracao { get; set; }
        private string Datahoraalteracao { get; set; }
        private string Excluido { get; set; }


        public Empresa(int codempresa, string nome, string endereco, string bairro,
            int codcidade, int codestado, string telefone, string email,
            string caminhologo, string obs, string ativa,
            string respinclusao, string datahorainclusao, string respalteracao,
            string datahoraalteracao, string excluido)
        {
            Codempresa = codempresa;
            Nome = nome;
            Endereco = endereco;
            Bairro = bairro;
            Codestado = codestado;
            Codcidade = codcidade;
            Telefone = telefone;
            Email = email;
            Caminhologo = caminhologo;
            Obs = obs;
            Ativa = ativa;
            Respinclusao = respinclusao;
            Datahorainclusao = datahorainclusao;
            Respalteracao = respalteracao;
            Datahoraalteracao = datahoraalteracao;
            Excluido = excluido;

        }

        public Empresa(int codempresa)
        {
            Codempresa = codempresa;
        }

        public Empresa()
        {

        }

        public int Insert()
        {
            var db = new DBAcess();
            const string insert = " INSERT INTO Empresa(" +
                                  " NOME, ENDERECO, BAIRRO, CODESTADO, CODCIDADE, TELEFONE, " +
                                  " EMAIL, CAMINHOLOGO, OBS, ATIVA, RESPINCLUSAO, DATAHORAINCLUSAO, " +
                                  " EXCLUIDO" +

                                  ") ";
            const string values = " VALUES(" +
                                  " @NOME, @ENDERECO, @BAIRRO, @CODESTADO, @CODCIDADE, @TELEFONE, " +
                                  " @EMAIL, @CAMINHOLOGO, @OBS, @ATIVA, @RESPINCLUSAO, @DATAHORAINCLUSAO, " +
                                  " @EXCLUIDO" +
                                  "); ";
            const string select = " ";
            db.CommandText = insert + values + select;

            db.AddParameter("@NOME", Nome);
            db.AddParameter("@ENDERECO", Endereco);
            db.AddParameter("@BAIRRO", Bairro);
            db.AddParameter("@CODESTADO", Codestado);
            db.AddParameter("@CODCIDADE", Codcidade);
            db.AddParameter("@TELEFONE", Telefone);
            db.AddParameter("@EMAIL", Email);
            db.AddParameter("@CAMINHOLOGO", Caminhologo);
            db.AddParameter("@OBS", Obs);
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
            const string update = " UPDATE Empresa ";
            const string set = " SET" +
                               " NOME = @NOME, ENDERECO = @ENDERECO, " +
                               " BAIRRO = @BAIRRO, CODESTADO = @CODESTADO, CODCIDADE = @CODCIDADE, TELEFONE = @TELEFONE, " +
                               " EMAIL = @EMAIL, " +
                               " CAMINHOLOGO = @CAMINHOLOGO, OBS = @OBS, ATIVA = @ATIVA, " +
                               " RESPALTERACAO = @RESPALTERACAO, DATAHORAALTERACAO = @DATAHORAALTERACAO, EXCLUIDO = @EXCLUIDO";
            const string where = " WHERE CODEMPRESA = @CODEMPRESA;";
            db.CommandText = update + set + where;
            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@ENDERECO", Endereco);
            db.AddParameter("@BAIRRO", Bairro);
            db.AddParameter("@CODESTADO", Codestado);
            db.AddParameter("@CODCIDADE", Codcidade);
            db.AddParameter("@TELEFONE", Telefone);
            db.AddParameter("@EMAIL", Email);
            db.AddParameter("@CAMINHOLOGO", Caminhologo);
            db.AddParameter("@OBS", Obs);
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(int codEmpresa)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Empresa ";
            const string where = " WHERE codEmpresa = @codEmpresa ";
            db.CommandText = select + from + where;
            db.AddParameter("@codEmpresa", codEmpresa);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectTudo()
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Empresa ";
           
            db.CommandText = select + from;
           
            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet SelectTodos()
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Empresa ";
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
            const string from = " FROM empresa ";
            var where = "  ";
            switch (por)
            {
                case "Empresa":
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

        public static bool Delete(int codEmpresa)
        {
            var db = new DBAcess();
            const string delete = " DELETE FROM Empresa ";
            const string where = "WHERE codEmpresa = @codEmpresa";
            db.CommandText = delete + where;
            db.AddParameter("@codEmpresa", codEmpresa);
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
