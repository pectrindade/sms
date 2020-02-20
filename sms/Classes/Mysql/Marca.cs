using System;
using System.ComponentModel;
using System.Data;
using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;

namespace Atencao_Assistida.Classes.Mysql
{
    public class Marca
    {
        public Marca(int codmarca, string descricao)
        {
            Codmarca = codmarca;
            Descricao = descricao;

        }

        public Marca(int codmarca)
        {
            Codmarca = codmarca;
        }
        public Marca()
        {

        }

        private int Codmarca { get; set; }
        private string Descricao { get; set; }


        public int Insert()
        {
            var db = new DBAcess();
            const string insert = " INSERT INTO Marca (DESCRICAO) ";
            const string values = " VALUES (@DESCRICAO);";
            const string select = " ";
            db.CommandText = insert + values + select;
            db.AddParameter("@DESCRICAO", Descricao);


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
            const string update = " UPDATE `Marca` ";
            const string set = " SET DESCRICAO = @DESCRICAO ";
            const string where = " WHERE CODMARCA = @CODMARCA;";
            db.CommandText = update + set + where;
            db.AddParameter("@CODMARCA", Codmarca);
            db.AddParameter("@DESCRICAO", Descricao);



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
            const string delete = " DELETE FROM marca ";

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

        public int InsertAccess()
        {
            var db = new DBAcessOleDB();
            const string insert = " INSERT INTO Marca (CODMARCA, DESCRICAO) ";
            const string values = " VALUES (@CODMARCA, @DESCRICAO);";
            
            db.CommandText = insert + values;
            db.AddParameter("@CODMARCA", Codmarca);
            db.AddParameter("@DESCRICAO", Descricao);


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
            const string update = " UPDATE `Marca` ";
            const string set = " SET DESCRICAO = @DESCRICAO ";
            const string where = " WHERE CODMARCA = @CODMARCA;";
            db.CommandText = update + set + where;
            db.AddParameter("@CODMARCA", Codmarca);
            db.AddParameter("@DESCRICAO", Descricao);



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
            const string select = " SELECT * ";
            const string from = " FROM Marca ";
            const string where = " WHERE CODMARCA = @CODMARCA ";
            db.CommandText = select + from + where;
            db.AddParameter("@CODMARCA", Codmarca);

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
            Mysql = Mysql + " FROM Marca ";

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
            const string update = " UPDATE `Marca` ";
            const string set = " SET EXCLUIDO = 'S'";
            const string where = " WHERE CODMARCA = @CODMARCA;";
            db.CommandText = update + set + where;
            db.AddParameter("@CODMARCA", Codmarca);


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
        public static MySqlDataReader Select(int codmarca)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Marca ";
            const string where = " WHERE CODMARCA = @CODMARCA ";
            db.CommandText = select + from + where;
            db.AddParameter("@CODMARCA", codmarca);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet Select(bool todas)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Marca ";

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
            const string from = " FROM Marca ";
            var where = " ";
            switch (por)
            {
                case "descricao":
                    {
                        where = "WHERE DESCRICAO LIKE CONCAT(@valor)";
                        valor = '%' + valor + "%";
                    }
                    break;


            }
            const string order = " ORDER BY DESCRICAO ASC; ";
            db.CommandText = select + from + where + order;
            db.AddParameter("@valor", valor);
            var ds = db.ExecuteDataSet();
            return ds;
        }
    }
}
