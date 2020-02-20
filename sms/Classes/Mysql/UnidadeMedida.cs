using System;
using System.ComponentModel;
using System.Data;
using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;

namespace Atencao_Assistida.Classes.Mysql
{
    public class UnidadeMedida
    {
        public UnidadeMedida(int codunidademedida, string descricao)
        {
            Codunidademedida = codunidademedida;
            Descricao = descricao;

        }

        public UnidadeMedida(int codunidademedida)
        {
            Codunidademedida = codunidademedida;
        }
        public UnidadeMedida()
        {

        }

        private int Codunidademedida { get; set; }
        private string Descricao { get; set; }


        public int Insert()
        {
            var db = new DBAcess();
            const string insert = " INSERT INTO UnidadeMedida (DESCRICAO) ";
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
            const string update = " UPDATE `UnidadeMedida` ";
            const string set = " SET DESCRICAO = @DESCRICAO ";
            const string where = " WHERE CODUNIDADEMEDIDA = @CODUNIDADEMEDIDA;";
            db.CommandText = update + set + where;
            db.AddParameter("@CODUNIDADEMEDIDA", Codunidademedida);
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
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM UnidadeMedida ";
            Mysql = Mysql + " WHERE CODUNIDADEMEDIDA = @CODUNIDADEMEDIDA ";
            Mysql = Mysql + " AND EXCLUIDO = 'N' ";

            db.CommandText = Mysql;
            db.AddParameter("@CODUNIDADEMEDIDA", Codunidademedida);

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
            Mysql = Mysql + " FROM UnidadeMedida ";
            Mysql = Mysql + " WHERE EXCLUIDO = 'N' ";

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


        public static bool Delete(int Codunidademedida)
        {
            var db = new DBAcess();
            const string delete = " DELETE FROM UnidadeMedida ";
            const string where = "WHERE CODUNIDADEMEDIDA = @CODUNIDADEMEDIDA";
            db.CommandText = delete + where;
            db.AddParameter("@CODUNIDADEMEDIDA", Codunidademedida);
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


        public bool UpdateExclusao()
        {
            var db = new DBAcess();
            const string update = " UPDATE UnidadeMedida ";
            const string set = " SET EXCLUIDO = 'S'";
            const string where = " WHERE CODUNIDADEMEDIDA = @CODUNIDADEMEDIDA;";
            db.CommandText = update + set + where;
            db.AddParameter("@CODUNIDADEMEDIDA", Codunidademedida);


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
        public static MySqlDataReader Select(int Codunidademedida)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM UnidadeMedida ";
            Mysql = Mysql + " WHERE CODUNIDADEMEDIDA = @CODUNIDADEMEDIDA ";
            Mysql = Mysql + " AND EXCLUIDO = 'N' ";

            db.CommandText = Mysql;
            db.AddParameter("@CODUNIDADEMEDIDA", Codunidademedida);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet Select(bool todas)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM UnidadeMedida ";
            Mysql = Mysql + " WHERE EXCLUIDO = 'N' ";

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
            const string select = " SELECT * ";
            const string from = " FROM UnidadeMedida ";
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
