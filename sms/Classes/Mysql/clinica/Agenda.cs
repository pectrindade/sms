using System;
using System.ComponentModel;
using System.Data;
using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;

namespace Atencao_Assistida.Classes.Mysql.clinica
{
    public class Agenda
    {


        private string Data { get; set; }
        private string Hora { get; set; }
        private int Codigo_Dentista { get; set; }
        private int Codigo_Paciente { get; set; }
        private string Descricao { get; set; }
        private string Procedimento { get; set; }
        private string Faltou { get; set; }


        public Agenda(string data, string hora, int codigo_dentista, int codigo_paciente, string descricao, string procedimento, string faltou)
        {
            Data = data;
            Hora = hora;
            Codigo_Dentista = codigo_dentista;
            Codigo_Paciente = codigo_paciente;
            Descricao = descricao;
            Procedimento = procedimento;
            Faltou = faltou;

        }

        public Agenda(string data, string hora, int codigo_dentista, int codigo_paciente)
        {
            Data = data;
            Hora = hora;
            Codigo_Dentista = codigo_dentista;
            Codigo_Paciente = codigo_paciente;

        }

        public Agenda()
        {

        }



        public int Insert()
        {
            var db = new DBAcess();
            string Mysql = " INSERT INTO Agenda( ";
            Mysql = Mysql + " DATA, HORA, CODIGO_DENTISTA, CODIGO_PACIENTE, DESCRICAO, PROCEDIMENTO, FALTOU ";
            Mysql = Mysql + " ) ";
            Mysql = Mysql + " VALUES ( ";
            Mysql = Mysql + " @DATA, @HORA, @CODIGO_DENTISTA, @CODIGO_PACIENTE, @DESCRICAO, @PROCEDIMENTO, @FALTOU ";
            Mysql = Mysql + ");";
            
            db.CommandText = Mysql;

            db.AddParameter("@DATA", Convert.ToDateTime(Data));
            db.AddParameter("@HORA", Convert.ToDateTime(Hora));
            db.AddParameter("@CODIGO_DENTISTA", Codigo_Dentista);
            db.AddParameter("@CODIGO_PACIENTE", Codigo_Paciente);
            db.AddParameter("@DESCRICAO", Descricao);
            db.AddParameter("@PROCEDIMENTO", Procedimento);
            db.AddParameter("@FALTOU", Faltou);

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
            string Mysql = " UPDATE Agenda SET ";
            Mysql = Mysql + " DATA = @DATA, HORA = @HORA, CODIGO_DENTISTA = @CODIGO_DENTISTA, ";
            Mysql = Mysql + " CODIGO_PACIENTE = @CODIGO_PACIENTE, DESCRICAO = @DESCRICAO, ";
            Mysql = Mysql + " PROCEDIMENTO = @PROCEDIMENTO, FALTOU = @FALTOU ";

            Mysql = Mysql + " WHERE DATA = @DATA;";
            Mysql = Mysql + " AND HORA = @HORA;";
            Mysql = Mysql + " AND CODIGO_DENTISTA = @CODIGO_DENTISTA;";
            Mysql = Mysql + " AND CODIGO_PACIENTE = @CODIGO_PACIENTE;";

            db.CommandText = Mysql;

            db.AddParameter("@DATA", Convert.ToDateTime(Data));
            db.AddParameter("@HORA", Convert.ToDateTime(Hora));
            db.AddParameter("@CODIGO_DENTISTA", Codigo_Dentista);
            db.AddParameter("@CODIGO_PACIENTE", Codigo_Paciente);
            db.AddParameter("@DESCRICAO", Descricao);
            db.AddParameter("@PROCEDIMENTO", Procedimento);
            db.AddParameter("@FALTOU", Faltou);


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
            string Mysql = " INSERT INTO Agenda( ";
            Mysql = Mysql + " DATA, HORA, CODIGO_DENTISTA, CODIGO_PACIENTE, DESCRICAO, PROCEDIMENTO, FALTOU ";
            Mysql = Mysql + " ) ";
            Mysql = Mysql + " VALUES ( ";
            Mysql = Mysql + " @DATA, @HORA, @CODIGO_DENTISTA, @CODIGO_PACIENTE, @DESCRICAO, @PROCEDIMENTO, @FALTOU ";
            Mysql = Mysql + ");";

            db.CommandText = Mysql;

            db.AddParameter("@DATA", Convert.ToDateTime(Data));
            db.AddParameter("@HORA", Convert.ToDateTime(Hora));
            db.AddParameter("@CODIGO_DENTISTA", Codigo_Dentista);
            db.AddParameter("@CODIGO_PACIENTE", Codigo_Paciente);
            db.AddParameter("@DESCRICAO", Descricao);
            db.AddParameter("@PROCEDIMENTO", Procedimento);
            db.AddParameter("@FALTOU", Faltou);

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
            string Mysql = " UPDATE Agenda SET ";
            Mysql = Mysql + " DATA = @DATA, HORA = @HORA, CODIGO_DENTISTA = @CODIGO_DENTISTA, ";
            Mysql = Mysql + " CODIGO_PACIENTE = @CODIGO_PACIENTE, DESCRICAO = @DESCRICAO, ";
            Mysql = Mysql + " PROCEDIMENTO = @PROCEDIMENTO, FALTOU = @FALTOU ";

            Mysql = Mysql + " WHERE DATA = @DATA ";
            Mysql = Mysql + " AND HORA = @HORA ";
            Mysql = Mysql + " AND CODIGO_DENTISTA = @CODIGO_DENTISTA ";
            Mysql = Mysql + " AND CODIGO_PACIENTE = @CODIGO_PACIENTE ";

            db.CommandText = Mysql;

            db.AddParameter("@DATA", Convert.ToDateTime(Data));
            db.AddParameter("@HORA", Convert.ToDateTime(Hora));
            db.AddParameter("@CODIGO_DENTISTA", Codigo_Dentista);
            db.AddParameter("@CODIGO_PACIENTE", Codigo_Paciente);
            db.AddParameter("@DESCRICAO", Descricao);
            db.AddParameter("@PROCEDIMENTO", Procedimento);
            db.AddParameter("@FALTOU", Faltou);

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
            Mysql = Mysql + " FROM Agenda ";

            Mysql = Mysql + " WHERE DATA = @DATA ";
            Mysql = Mysql + " AND HORA = @HORA ";
            Mysql = Mysql + " AND CODIGO_DENTISTA = @CODIGO_DENTISTA ";
            Mysql = Mysql + " AND CODIGO_PACIENTE = @CODIGO_PACIENTE ";

            db.CommandText = Mysql;

            db.AddParameter("@DATA", Convert.ToDateTime(Data));
            db.AddParameter("@HORA", Convert.ToDateTime(Hora));
            db.AddParameter("@CODIGO_DENTISTA", Codigo_Dentista);
            db.AddParameter("@CODIGO_PACIENTE", Codigo_Paciente);

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
            Mysql = Mysql + " FROM Agenda ";

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
            const string delete = " DELETE FROM Agenda ";

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
        public static MySqlDataReader Select(int CodAgenda)
        {
            var db = new DBAcess();
            string Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Agenda ";
            Mysql = Mysql + " WHERE codAgenda = @codAgenda ";

            db.CommandText = Mysql;

            db.AddParameter("@codAgenda", CodAgenda);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet Select(bool todas)
        {
            var db = new DBAcess();
            string Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Agenda ";

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
            Mysql = Mysql + " FROM Agenda ";
            
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
