using System;
using System.ComponentModel;
using System.Data;
using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;

namespace Atencao_Assistida.Classes.Mysql
{

    public class Grupo
    {
        public Grupo(int codgrupo, string descricao)
        {
            CodGrupo = codgrupo;
            Descricao = descricao;

        }

        public Grupo(int codgrupo)
        {
            CodGrupo = codgrupo;
        }
        public Grupo()
        {
            
        }

        private int CodGrupo { get; set; }
        private string Descricao { get; set; }


        public int Insert()
        {
            var db = new DBAcess();
            const string insert = " INSERT INTO `Grupo`(`DESCRICAO`) ";
            const string values = " VALUES (@Descricao);";
            const string select = " ";
            db.CommandText = insert + values + select;
            db.AddParameter("@Descricao", Descricao);


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
            const string update = " UPDATE `Grupo` ";
            const string set = " SET DESCRICAO = @Descricao ";
            const string where = " WHERE CODGRUPO = @CodGrupo;";
            db.CommandText = update + set + where;
            db.AddParameter("@CodGrupo", CodGrupo);
            db.AddParameter("@Descricao", Descricao);



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
            const string insert = " INSERT INTO Grupo (CODGRUPO, DESCRICAO) ";
            const string values = " VALUES (@CODGRUPO, @Descricao);";
            const string select = " ";
            db.CommandText = insert + values + select;
            db.AddParameter("@CODGRUPO", CodGrupo);
            db.AddParameter("@Descricao", Descricao);


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
            const string update = " UPDATE `Grupo` ";
            const string set = " SET DESCRICAO = @Descricao ";
            const string where = " WHERE CODGRUPO = @CodGrupo;";
            db.CommandText = update + set + where;
            db.AddParameter("@CodGrupo", CodGrupo);
            db.AddParameter("@Descricao", Descricao);



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
            const string from = " FROM Grupo ";
            const string where = " WHERE CODGRUPO = @CodGrupo ";
            db.CommandText = select + from + where;
            db.AddParameter("@CodGrupo", CodGrupo);

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
            Mysql = Mysql + " FROM Grupo ";
           
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
            const string delete = " DELETE FROM grupo ";

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

        public bool UpdateExclusao()
        {
            var db = new DBAcess();
            const string update = " UPDATE `Grupo` ";
            const string set = " SET EXCLUIDO = @Excluido, DATAHORAEXCLUSAO = @DataHoraExclusao, EXCLUIDOPOR = @ExcluidoPor";
            const string where = " WHERE CODCURSO = @CodCurso;";
            db.CommandText = update + set + where;
            db.AddParameter("@CodCurso", CodGrupo);


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
        public static MySqlDataReader Select(int Codgrupo)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM grupo ";
            const string where = " WHERE codgrupo = @codgrupo ";
            db.CommandText = select + from + where;
            db.AddParameter("@codgrupo", Codgrupo);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet Select(bool todas)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM grupo ";

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
            const string from = " FROM Grupo ";
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
    }
}
