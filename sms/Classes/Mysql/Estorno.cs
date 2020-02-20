using System;
using System.ComponentModel;
using System.Data;
using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;

namespace Atencao_Assistida.Classes.Mysql
{

    [DataObject(true)]
    public class Estorno
    {
        private string Ofiiorequisicao { get; set; }
        private int Codigo { get; set; }
        private string Numofcreq { get; set; }
        private string Dataestorno { get; set; }
        private string Quemfez { get; set; }
        private string Motivo { get; set; }

        public Estorno(string oficiorequisicao, int codigo, string numofcreq, string dataestorno,
           string quenfez, string motivo)
        {
            Ofiiorequisicao = oficiorequisicao;
            Codigo = codigo;
            Numofcreq = numofcreq;
            Dataestorno = dataestorno;
            Quemfez = quenfez;
            Motivo = motivo;
           
        }

        public int Insert()
        {
            var db = new DBAcess();
            const string insert = " INSERT INTO Estorno(" +
                                  " OFICIOREQUISICAO, CODIGO, NUMOFCREQ, DATAESTORNO, QUEMFEZ, MOTIVO" +
                                  ") ";
            const string values = " VALUES(" +
                                  " @OFICIOREQUISICAO, @CODIGO, @NUMOFCREQ, @DATAESTORNO, @QUEMFEZ, @MOTIVO" +
                                  "); ";
            const string select = " ";
            db.CommandText = insert + values + select;

            db.AddParameter("@OFICIOREQUISICAO", Ofiiorequisicao);
            db.AddParameter("@CODIGO", Codigo);
            db.AddParameter("@NUMOFCREQ", Numofcreq);
            db.AddParameter("@DATAESTORNO", Convert.ToDateTime(Dataestorno));
            db.AddParameter("@QUEMFEZ", Quemfez);
            db.AddParameter("@MOTIVO", Motivo);

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
            const string update = " UPDATE Estorno ";
            const string set = " SET" +
                               " OFICIOREQUISICAO = @OFICIOREQUISICAO, CODIGO = @CODIGO, " +
                               " NUMOFCREQ = @NUMOFCREQ, DATAESTORNO = @DATAESTORNO, QUEMFEZ = @QUEMFEZ, MOTIVO = @MOTIVO";
            const string where = " WHERE CODIGO = @CODIGO AND OFICIOREQUISICAO = @OFICIOREQUISICAO;";
            db.CommandText = update + set + where;
            db.AddParameter("@OFICIOREQUISICAO", Ofiiorequisicao);
            db.AddParameter("@CODIGO", Codigo);
            db.AddParameter("@NUMOFCREQ", Numofcreq);
            db.AddParameter("@DATAESTORNO", Convert.ToDateTime(Dataestorno));
            db.AddParameter("@QUEMFEZ", Quemfez);
            db.AddParameter("@MOTIVO", Motivo);

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

    }
}
