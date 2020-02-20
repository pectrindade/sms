using System;
using System.ComponentModel;
using System.Data;
using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;

namespace Atencao_Assistida.Classes.Mysql.clinica
{
    public class Agenda_obs
    {


        private string Data { get; set; }
        private int Codigo_Dentista { get; set; }
        private string Obs { get; set; }


        public Agenda_obs(string data, int codigo_dentista, string obs)
        {
            Data = data;
            Codigo_Dentista = codigo_dentista;
            Obs = Obs;

        }

        public Agenda_obs()
        {

        }



        public int Insert()
        {
            var db = new DBAcess();
            string Mysql = " INSERT INTO Agenda_obs( ";
            Mysql = Mysql + " DATA, CODIGO_DENTISTA, OBS ";
            Mysql = Mysql + " ) ";
            Mysql = Mysql + " VALUES ( ";
            Mysql = Mysql + " @DATA, @CODIGO_DENTISTA, @OBS ";
            Mysql = Mysql + ");";

            db.CommandText = Mysql;

            db.AddParameter("@DATA", Convert.ToDateTime(Data));
            db.AddParameter("@CODIGO_DENTISTA", Codigo_Dentista);
            db.AddParameter("@OBS", Obs);

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
            string Mysql = " UPDATE Agenda_obs SET ";
            Mysql = Mysql + " DATA = @DATA, CODIGO_DENTISTA = @CODIGO_DENTISTA, ";
            Mysql = Mysql + " OBS = @OBS ";

            Mysql = Mysql + " WHERE DATA = @DATA;";
            Mysql = Mysql + " AND CODIGO_DENTISTA = @CODIGO_DENTISTA;";

            db.CommandText = Mysql;

            db.AddParameter("@DATA", Convert.ToDateTime(Data));
            db.AddParameter("@CODIGO_DENTISTA", Codigo_Dentista);
            db.AddParameter("@OBS", Obs);


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
            string Mysql = " INSERT INTO Agenda_obs( ";
            Mysql = Mysql + " DATA, CODIGO_DENTISTA, OBS ";
            Mysql = Mysql + " ) ";
            Mysql = Mysql + " VALUES ( ";
            Mysql = Mysql + " @DATA, @CODIGO_DENTISTA, @OBS ";
            Mysql = Mysql + ");";

            db.CommandText = Mysql;

            db.AddParameter("@DATA", Convert.ToDateTime(Data));
            db.AddParameter("@CODIGO_DENTISTA", Codigo_Dentista);
            db.AddParameter("@OBS", Obs);

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
            string Mysql = " UPDATE Agenda_obs SET ";
            Mysql = Mysql + " DATA = @DATA, CODIGO_DENTISTA = @CODIGO_DENTISTA, ";
            Mysql = Mysql + " OBS = @OBS ";

            Mysql = Mysql + " WHERE DATA = @DATA;";
            Mysql = Mysql + " AND CODIGO_DENTISTA = @CODIGO_DENTISTA;";

            db.CommandText = Mysql;

            db.AddParameter("@DATA", Convert.ToDateTime(Data));
            db.AddParameter("@CODIGO_DENTISTA", Codigo_Dentista);
            db.AddParameter("@OBS", Obs);

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
            Mysql = Mysql + " FROM Agenda_obs ";

            Mysql = Mysql + " WHERE DATA = @DATA ";
            Mysql = Mysql + " AND CODIGO_DENTISTA = @CODIGO_DENTISTA ";

            db.CommandText = Mysql;

            db.AddParameter("@DATA", Convert.ToDateTime(Data));
            db.AddParameter("@CODIGO_DENTISTA", Codigo_Dentista);
          
            

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
            Mysql = Mysql + " FROM Agenda_obs ";

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
            const string delete = " DELETE FROM Agenda_obs ";

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
        public static MySqlDataReader Select(int CodAgenda_obs)
        {
            var db = new DBAcess();
            string Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Agenda_obs ";
            Mysql = Mysql + " WHERE codAgenda_obs = @codAgenda_obs ";

            db.CommandText = Mysql;

            db.AddParameter("@codAgenda_obs", CodAgenda_obs);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet Select(bool todas)
        {
            var db = new DBAcess();
            string Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Agenda_obs ";

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
            Mysql = Mysql + " FROM Agenda_obs ";

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
