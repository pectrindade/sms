using System;
using System.ComponentModel;
using System.Data;
using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;

namespace Atencao_Assistida.Classes.Mysql
{
    public class Visitas
    {
        private int Codvisita { get; set; }
        private int Codprotocolo { get; set; }
        private int Numerovisita { get; set; }
        private string Numeroprotocolo { get; set; }
        private int Codpaciente { get; set; }
        private string Datavisita { get; set; }
        private int Codagente { get; set; }
        private string Statuspaciente { get; set; }
        private string Obs { get; set; }


        public Visitas(int codvisita, int codprotocolo, int numerovisita, string numeroprotocolo, int codpaciente, string datavisita, int codagente, string statuspaciente, string obs)
        {
            Codvisita = codvisita;
            Codprotocolo = codprotocolo;
            Numerovisita = numerovisita;
            Numeroprotocolo = numeroprotocolo;
            Codpaciente = codpaciente;
            Datavisita = datavisita;
            Codagente = codagente;
            Statuspaciente = statuspaciente;
            Obs = obs;
        }

        public Visitas(int codvisita)
        {
            Codvisita = codvisita;

        }


        public Visitas()
        {

        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO visitas (";
            Mysql = Mysql + " CODPROTOCOLO, NUMEROVISITA, NUMEROPROTOCOLO, CODPACIENTE, DATAVISITA, CODAGENTE, STATUSPACIENTE, OBS ";
            Mysql = Mysql + " ) ";
            Mysql = Mysql + "  VALUES (";
            Mysql = Mysql + " @CODPROTOCOLO, @NUMEROVISITA, @NUMEROPROTOCOLO, @CODPACIENTE, @DATAVISITA, @CODAGENTE, @STATUSPACIENTE, @OBS";
            Mysql = Mysql + " );";
            
            db.CommandText = Mysql;

            db.AddParameter("@CODPROTOCOLO", Codprotocolo);
            db.AddParameter("@NUMEROVISITA", Numerovisita);
            db.AddParameter("@NUMEROPROTOCOLO", Numeroprotocolo);
            db.AddParameter("@CODPACIENTE", Codpaciente);
            db.AddParameter("@DATAVISITA", Convert.ToDateTime(Datavisita));
            db.AddParameter("@CODAGENTE", Codagente);
            db.AddParameter("@STATUSPACIENTE", Statuspaciente);
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
            var Mysql = " UPDATE visitas SET";
            Mysql = Mysql + " CODVISITA = @CODVISITA, CODPROTOCOLO = @CODPROTOCOLO, NUMEROVISITA = @NUMEROVISITA, ";
            Mysql = Mysql + " NUMEROPROTOCOLO = @NUMEROPROTOCOLO, CODPACIENTE = @CODPACIENTE, DATAVISITA = @DATAVISITA, ";
            Mysql = Mysql + " CODAGENTE = @CODAGENTE, STATUSPACIENTE = @STATUSPACIENTE, OBS = @OBS ";

            Mysql = Mysql + " WHERE CODVISITA = @CODVISITA;";

            db.CommandText = Mysql;

            db.AddParameter("@CODVISITA", Codvisita);
            db.AddParameter("@CODPROTOCOLO", Codprotocolo);
            db.AddParameter("@NUMEROVISITA", Numerovisita);
            db.AddParameter("@NUMEROPROTOCOLO", Numeroprotocolo);
            db.AddParameter("@CODPACIENTE", Codpaciente);
            db.AddParameter("@DATAVISITA", Datavisita);
            db.AddParameter("@CODAGENTE", Codagente);
            db.AddParameter("@STATUSPACIENTE", Statuspaciente);
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

        public bool DeleteAccess()
        {
            var db = new DBAcessOleDB();
            const string delete = " DELETE FROM visitas ";

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
            var Mysql = " INSERT INTO visitas (";
            Mysql = Mysql + " CODVISITA, CODPROTOCOLO, NUMEROVISITA, NUMEROPROTOCOLO, CODPACIENTE, DATAVISITA, CODAGENTE, STATUSPACIENTE, OBS ";
            Mysql = Mysql + " ) ";
            Mysql = Mysql + "  VALUES (";
            Mysql = Mysql + " @CODVISITA, @CODPROTOCOLO, @NUMEROVISITA, @NUMEROPROTOCOLO, @CODPACIENTE, @DATAVISITA, @CODAGENTE, @STATUSPACIENTE, @OBS";
            Mysql = Mysql + " );";

            db.CommandText = Mysql;

            db.AddParameter("@CODVISITA", Codvisita);
            db.AddParameter("@CODPROTOCOLO", Codprotocolo);
            db.AddParameter("@NUMEROVISITA", Numerovisita);
            db.AddParameter("@NUMEROPROTOCOLO", Numeroprotocolo);
            db.AddParameter("@CODPACIENTE", Codpaciente);
            db.AddParameter("@DATAVISITA", Datavisita);
            db.AddParameter("@CODAGENTE", Codagente);
            db.AddParameter("@STATUSPACIENTE", Statuspaciente);
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader BuscaUm(string Codprotocolo)
        {
            var db = new DBAcess();
            string Mysql = " SELECT V.CODVISITA, V.CODPROTOCOLO, V.NUMEROPROTOCOLO, V.NUMEROVISITA, V.CODPACIENTE, P.NOME AS NOMEPACIENTE,  ";
            Mysql = Mysql + " V.CODAGENTE, A.NOME AS NOMEAGENTE, V.STATUSPACIENTE, DATE_FORMAT(V.DATAVISITA,'%d/%m/%Y') AS DATAVISITA, V.OBS ";

            Mysql = Mysql + " FROM visitas AS V ";

            Mysql = Mysql + " INNER JOIN paciente AS P ON P.CODPACIENTE = V.CODPACIENTE ";
            Mysql = Mysql + " INNER JOIN agente AS A ON A.CODAGENTE = V.CODAGENTE ";

            Mysql = Mysql + " WHERE V.CODPROTOCOLO = @CODPROTOCOLO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODPROTOCOLO", Codprotocolo);

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
            string Mysql = " SELECT V.CODVISITA, V.NUMEROVISITA, V.NUMEROPROTOCOLO, DATE_FORMAT(V.DATAVISITA,'%d/%m/%Y') AS DATAVISITA, ";
            Mysql = Mysql + "  V.CODPACIENTE, V.CODAGENTE, A.NOME AS NOMEAGENTE, V.STATUSPACIENTE, V.OBS ";

            Mysql = Mysql + " FROM visitas AS V ";

            Mysql = Mysql + " INNER JOIN agente AS A ON V.CODAGENTE = A.CODAGENTE ";
           

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

        public static MySqlDataReader BuscaVisitaUm(string valor)
        {
            var db = new DBAcess();
            string Mysql = " SELECT V.CODVISITA, V.NUMEROVISITA, V.NUMEROPROTOCOLO, DATE_FORMAT(V.DATAVISITA,'%d/%m/%Y') AS DATAVISITA, ";
            Mysql = Mysql + "  V.CODPACIENTE, V.CODAGENTE, A.NOME AS NOMEAGENTE, V.STATUSPACIENTE, V.OBS ";

            Mysql = Mysql + " FROM visitas AS V ";

            Mysql = Mysql + " INNER JOIN agente AS A ON V.CODAGENTE = A.CODAGENTE ";


            Mysql = Mysql + " WHERE V.CODPROTOCOLO = @CODPROTOCOLO ";

            db.CommandText = Mysql;
            db.AddParameter("@CODPROTOCOLO", valor);

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
            const string update = " UPDATE visitas ";
            const string set = " SET EXCLUIDO = 'S'";
            const string where = " WHERE CODVISITA = @CODVISITA;";
            db.CommandText = update + set + where;
            //db.AddParameter("@CODVISITA", Codmarca);


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
        public static MySqlDataReader Select(int codvisita)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM visitas ";
            const string where = " WHERE CODVISITA = @CODVISITA ";
            db.CommandText = select + from + where;
            db.AddParameter("@CODVISITA", codvisita);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet Select(bool todas)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM visitas ";

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
            const string from = " FROM visitas ";
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
