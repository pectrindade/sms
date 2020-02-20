using System;
using System.ComponentModel;
using System.Data;
using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;

namespace Atencao_Assistida.Classes.Mysql.clinica
{
    public class Arquivos
    {


        private string Codigo { get; set; }
        private string Nome { get; set; }
        private int Descricao { get; set; }
        private int Tamanho { get; set; }

        public Arquivos(string codigo, string nome, int descricao, int tamanho)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Tamanho = tamanho;

        }

        public Arquivos()
        {

        }



        public int Insert()
        {
            var db = new DBAcess();
            string Mysql = " INSERT INTO Arquivos( ";
            Mysql = Mysql + " CODIGO, NOME, DESCRICAO, TAMANHO ";
            Mysql = Mysql + " ) ";
            Mysql = Mysql + " VALUES ( ";
            Mysql = Mysql + " CODIGO, NOME, DESCRICAO, TAMANHO ";
            Mysql = Mysql + ");";

            db.CommandText = Mysql;

            db.AddParameter("@CODIGO", Codigo);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@DESCRICAO", Descricao);
            db.AddParameter("@TAMANHO", Tamanho);


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
            string Mysql = " UPDATE Arquivos SET ";
            Mysql = Mysql + " DATA = @DATA, CODIGO_DENTISTA = @CODIGO_DENTISTA, ";
            Mysql = Mysql + " OBS = @OBS ";

            Mysql = Mysql + " WHERE DATA = @DATA;";
            Mysql = Mysql + " AND CODIGO_DENTISTA = @CODIGO_DENTISTA;";

            db.CommandText = Mysql;

            db.AddParameter("@CODIGO", Codigo);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@DESCRICAO", Descricao);
            db.AddParameter("@TAMANHO", Tamanho);



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
            string Mysql = " INSERT INTO Arquivos( ";
            Mysql = Mysql + " CODIGO, NOME, DESCRICAO, TAMANHO ";
            Mysql = Mysql + " ) ";
            Mysql = Mysql + " VALUES ( ";
            Mysql = Mysql + " CODIGO, NOME, DESCRICAO, TAMANHO ";
            Mysql = Mysql + ");";

            db.CommandText = Mysql;

            db.AddParameter("@CODIGO", Codigo);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@DESCRICAO", Descricao);
            db.AddParameter("@TAMANHO", Tamanho);

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
            string Mysql = " UPDATE Arquivos SET ";
            Mysql = Mysql + " DATA = @DATA, CODIGO_DENTISTA = @CODIGO_DENTISTA, ";
            Mysql = Mysql + " OBS = @OBS ";

            Mysql = Mysql + " WHERE DATA = @DATA;";
            Mysql = Mysql + " AND CODIGO_DENTISTA = @CODIGO_DENTISTA;";

            db.CommandText = Mysql;

            db.AddParameter("@CODIGO", Codigo);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@DESCRICAO", Descricao);
            db.AddParameter("@TAMANHO", Tamanho);

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
        public MySqlDataReader Select()
        {
            var db = new DBAcess();
            string Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Arquivos ";

            Mysql = Mysql + " WHERE CODIGO = @CODIGO ";

            db.CommandText = Mysql;

            db.AddParameter("@CODIGO", Codigo);



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
        public static MySqlDataReader SelectTudo()
        {
            var db = new DBAcess();
            string Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Arquivos ";

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

        public bool DeleteAccess()
        {
            var db = new DBAcessOleDB();
            const string delete = " DELETE FROM Arquivos ";

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
        public static MySqlDataReader Select(int CodArquivos)
        {
            var db = new DBAcess();
            string Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Arquivos ";
            Mysql = Mysql + " WHERE codArquivos = @codArquivos ";

            db.CommandText = Mysql;

            db.AddParameter("@codArquivos", CodArquivos);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet Select(bool todas)
        {
            var db = new DBAcess();
            string Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Arquivos ";

            db.CommandText = Mysql;

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
            string Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Arquivos ";

            switch (por)
            {
                case "descricao":
                    {
                        Mysql = Mysql + " WHERE descricao LIKE CONCAT(@valor)";
                        valor = '%' + valor + "%";
                    }
                    break;


            }
            Mysql = Mysql + " ORDER BY descricao ASC; ";

            db.CommandText = Mysql;

            db.AddParameter("@valor", valor);
            var ds = db.ExecuteDataSet();
            return ds;
        }
    }
}
