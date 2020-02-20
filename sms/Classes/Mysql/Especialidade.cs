using System;
using System.ComponentModel;
using System.Data;
using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;

namespace Atencao_Assistida.Classes.Mysql
{
    public class Especialidade
    {
        public Especialidade(int codespecialidade, string descricao)
        {
            Codespecialidade = codespecialidade;
            Descricao = descricao;

        }

        public Especialidade(int codespecialidade)
        {
            Codespecialidade = codespecialidade;
        }
        public Especialidade()
        {

        }

        private int Codespecialidade { get; set; }
        private string Descricao { get; set; }


        public int Insert()
        {
            var db = new DBAcess();
            const string insert = " INSERT INTO Especialidade (DESCRICAO) ";
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
            const string update = " UPDATE `Especialidade` ";
            const string set = " SET DESCRICAO = @DESCRICAO ";
            const string where = " WHERE CODEspecialidade = @CODESPECIALIDADE;";
            db.CommandText = update + set + where;
            db.AddParameter("@CODESPECIALIDADE", Codespecialidade);
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
            const string delete = " DELETE FROM Especialidade ";

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
            const string insert = " INSERT INTO Especialidade (CODESPECIALIDADE, DESCRICAO) ";
            const string values = " VALUES (@CODESPECIALIDADE, @DESCRICAO);";

            db.CommandText = insert + values;
            db.AddParameter("@CODESPECIALIDADE", Codespecialidade);
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
            const string update = " UPDATE `Especialidade` ";
            const string set = " SET DESCRICAO = @DESCRICAO ";
            const string where = " WHERE CODESPECIALIDADE = @CODESPECIALIDADE;";
            db.CommandText = update + set + where;
            db.AddParameter("@CODESPECIALIDADE", Codespecialidade);
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
            const string from = " FROM Especialidade ";
            const string where = " WHERE CODESPECIALIDADE = @CODESPECIALIDADE ";
            db.CommandText = select + from + where;
            db.AddParameter("@CODESPECIALIDADE", Codespecialidade);

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
            Mysql = Mysql + " FROM Especialidade ";

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
            const string update = " UPDATE `Especialidade` ";
            const string set = " SET EXCLUIDO = 'S'";
            const string where = " WHERE CODESPECIALIDADE = @CODESPECIALIDADE;";
            db.CommandText = update + set + where;
            db.AddParameter("@CODESPECIALIDADE", Codespecialidade);


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
        public static MySqlDataReader Select(int codespecialidade)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Especialidade ";
            const string where = " WHERE CODESPECIALIDADE = @CODESPECIALIDADE ";
            db.CommandText = select + from + where;
            db.AddParameter("@CODESPECIALIDADE", codespecialidade);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet Select(bool todas)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Especialidade ";

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
            const string from = " FROM Especialidade ";
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
