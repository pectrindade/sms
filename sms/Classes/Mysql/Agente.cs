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
    public class Agente
    {


        private int Codagente { get; set; }
        private string Nome { get; set; }
        private string Endereco { get; set; }
        private string Bairro { get; set; }
        private string Telefone { get; set; }
        private string Cell { get; set; }
        private string Respinclusao { get; set; }
        private string Datainclusao { get; set; }
        private string Respalteracao { get; set; }
        private string Dataalteracao { get; set; }
        private string Excluido { get; set; }

        public Agente()
        {

        }

        public Agente(int codagente)
        {
            Codagente = codagente;
        }

        public Agente(int codagente, string nome, string endereco, string bairro, string telefone, string cell, string respinclusao, string datainclusao, string respalteracao, string dataalteracao, string excluido
    )
        {
            Codagente = codagente;
            Nome = nome;
            
            Endereco = endereco;
            Bairro = bairro;
            Telefone = telefone;
            Cell = cell;
            Respinclusao = respinclusao;
            Datainclusao = datainclusao;
            Respalteracao = respalteracao;
            Dataalteracao = dataalteracao;
            Excluido = excluido;

        }


        public int Insert()
        {
            var db = new DBAcess();
            const string insert = " INSERT INTO Agente (NOME, ENDERECO, BAIRRO, TELEFONE, CELL, RESPINCLUSAO, DATAINCLUSAO, EXCLUIDO) ";
            const string values = " VALUES (@NOME, @ENDERECO, @BAIRRO, @TELEFONE, @CELL, @RESPINCLUSAO, @DATAINCLUSAO, @EXCLUIDO " +
                "); ";

            const string select = " SELECT MAX(CODAGENTE) As CODAGENTE FROM agente;  ";

            db.CommandText = insert + values + select;
            db.AddParameter("@CODAGENTE", Codagente);
            db.AddParameter("@NOME", Nome);
            
            db.AddParameter("@ENDERECO", Endereco);
            db.AddParameter("@BAIRRO", Bairro);
            db.AddParameter("@TELEFONE", Telefone);
            db.AddParameter("@CELL", Cell);
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
            const string update = " UPDATE Agente ";
            const string set = " SET NOME = @NOME, ENDERECO = @ENDERECO, BAIRRO = @BAIRRO, TELEFONE = @TELEFONE, CELL = @CELL , " +
                               " RESPALTERACAO = @RESPALTERACAO, DATAALTERACAO = @DATAALTERACAO, EXCLUIDO = @EXCLUIDO ";

            const string where = " WHERE CODAGENTE = @CODAGENTE;";

            db.CommandText = update + set + where;
            db.AddParameter("@CODAGENTE", Codagente);
            db.AddParameter("@NOME", Nome);
           
            db.AddParameter("@ENDERECO", Endereco);
            db.AddParameter("@BAIRRO", Bairro);
            db.AddParameter("@TELEFONE", Telefone);
            db.AddParameter("@CELL", Cell);
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

        public int InsertAccess()
        {
            var db = new DBAcessOleDB();
            const string insert = " INSERT INTO Agente (CODAGENTE, NOME, ENDERECO, BAIRRO, TELEFONE, CELL) ";
            const string values = " VALUES (@CODagente, @NOME, @ENDERECO, @BAIRRO, @TELEFONE, @CELL" +
                                  "); ";

            const string select = " ";

            db.CommandText = insert + values + select;
            db.AddParameter("@CODAGENTE", Codagente);
            db.AddParameter("@NOME", Nome);
            
            db.AddParameter("@ENDERECO", Endereco);
            db.AddParameter("@BAIRRO", Bairro);
            db.AddParameter("@TELEFONE", Telefone);
            db.AddParameter("@CELL", Cell);


            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }

        public bool UpdateAccess()
        {
            var db = new DBAcessOleDB();
            const string update = " UPDATE Agente ";
            const string set = " SET NOME = @NOME, ENDERECO = @ENDERECO, BAIRRO = @BAIRRO, TELEFONE = @TELEFONE, CELL = @CELL , " +
                               " RESPALTERACAO = @RESPALTERACAO, DATAALTERACAO = @DATAALTERACAO, EXCLUIDO = @EXCLUIDO ";

            const string where = " WHERE CODAGENTE = @CODAGENTE;";

            db.CommandText = update + set + where;
            db.AddParameter("@CODAGENTE", Codagente);
            db.AddParameter("@NOME", Nome);
           
            db.AddParameter("@ENDERECO", Endereco);
            db.AddParameter("@BAIRRO", Bairro);
            db.AddParameter("@TELEFONE", Telefone);
            db.AddParameter("@CELL", Cell);
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

        public bool DeleteAccess()
        {
            var db = new DBAcessOleDB();
            const string delete = " DELETE FROM Agente ";

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
        public static MySqlDataReader BuscaUm(int codigo)
        {
            var db = new DBAcess();
            string Mysql = " SELECT CODAGENTE, NOME, ENDERECO, ";
            Mysql = Mysql + " BAIRRO, TELEFONE, CELL, ";
            Mysql = Mysql + " RESPINCLUSAO, DATAINCLUSAO, RESPALTERACAO, DATAALTERACAO, EXCLUIDO ";

            Mysql = Mysql + " FROM Agente ";
            Mysql = Mysql + " WHERE CODAGENTE = @CODAGENTE ";

            db.CommandText = Mysql;
            db.AddParameter("@CODAGENTE", codigo);

            try
            {
                var dr = (MySqlDataReader)db.ExecuteReader();
                return dr;
            }
            finally
            {
                db.Dispose();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]

        public static MySqlDataReader BuscaTudo()
        {
            var db = new DBAcess();
            string Mysql = " SELECT CODAGENTE, NOME, ENDERECO, ";
            Mysql = Mysql + " BAIRRO, TELEFONE, CELL, ";
            Mysql = Mysql + " RESPINCLUSAO, DATAINCLUSAO, RESPALTERACAO, DATAALTERACAO, EXCLUIDO ";

            Mysql = Mysql + " FROM Agente ";

            db.CommandText = Mysql;

            try
            {
                var dr = (MySqlDataReader)db.ExecuteReader();
                return dr;
            }
            finally
            {
                db.Dispose();
            }
        }
        public bool UpdateExclusao()
        {
            var db = new DBAcess();
            const string update = " UPDATE Agente ";
            const string set = " SET EXCLUIDO = 'S'";
            const string where = " WHERE CODAGENTE = @CODAGENTE;";
            db.CommandText = update + set + where;
            db.AddParameter("@CODagente", Codagente);


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
        public static DataSet Select(bool todas)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Agente ";

            db.CommandText = select + from;

            try
            {
                var ds = db.ExecuteDataSet();
                return ds;
            }
            finally
            {
                db.Dispose();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet Select(string por, string valor)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Agente ";
            var where = " ";
            switch (por)
            {
                case "descricao":
                    {
                        where = "WHERE descricao LIKE CONCAT(@valor)";
                        valor = '%' + valor + "%";
                    }
                    break;


            }
            const string order = " ORDER BY descricao ASC; ";
            db.CommandText = select + from + where + order;
            db.AddParameter("@valor", valor);
            var ds = db.ExecuteDataSet();
            return ds;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Selectdr(string valor)
        {
            var db = new DBAcess();
            string Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Agente ";

            if (valor != "")
            {

                {
                    Mysql = Mysql + "WHERE NOME LIKE CONCAT(@valor)";
                    valor = '%' + valor + "%";
                }


            }

            db.CommandText = Mysql;
            db.AddParameter("@valor", valor);
            try
            {
                var dr = (MySqlDataReader)db.ExecuteReader();
                return dr;
            }
            finally
            {
                db.Dispose();
            }
        }
    }
}
