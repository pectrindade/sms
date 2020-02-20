using Atencao_Assistida.Classes.DAL;

namespace Atencao_Assistida.Classes.Mysql
{
    public class CriaArquivo
    {
        public bool Create_PacienteProdutos()
        {
            var db = new DBAcessOleDB();
            
            var tableName = "PacienteProdutos";

            var Mysql = "CREATE TABLE " + tableName + "( ";

            Mysql = Mysql + " [CODPROTOCOLO] Int, ";
            Mysql = Mysql + "[NUMEROPROTOCOLO]  varchar(50), ";
            Mysql = Mysql + "[CODPACIENTE] Int, ";
            Mysql = Mysql + "[NOMEPACIENTE]  varchar(50), ";
            Mysql = Mysql + "[CODPRODUTO] Int, ";
            Mysql = Mysql + "[NOMEPRODUTO]  varchar(50), ";
            Mysql = Mysql + "[QUANTIDADE] Int ";
       
            Mysql = Mysql + " )";
            
            db.CommandText = Mysql;

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

        public bool Insert_PacienteProdutos( string Codprotocolo, string Numeroprotocolo, string Codpaciente, string Nomepaciente, string Codproduto, string Nomeproduto, string Quantidade)
        {
            var db = new DBAcessOleDB();
            var Mysql = " INSERT INTO PacienteProdutos (CODPROTOCOLO, NUMEROPROTOCOLO, CODPACIENTE, NOMEPACIENTE, CODPRODUTO, NOMEPRODUTO, QUANTIDADE) ";
            Mysql = Mysql + " VALUES (@CODPROTOCOLO, @NUMEROPROTOCOLO, @CODPACIENTE, @NOMEPACIENTE, @CODPRODUTO, @NOMEPRODUTO, @QUANTIDADE";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODPROTOCOLO", Codprotocolo);
            db.AddParameter("@NUMEROPROTOCOLO", Numeroprotocolo);
            db.AddParameter("@CODPACIENTE", Codpaciente);
            db.AddParameter("@NOMEPACIENTE", Nomepaciente);
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@NOMEPRODUTO", Nomeproduto);
            db.AddParameter("@QUANTIDADE", Quantidade);

            try
            {
                db.ExecuteScalar();
                return true;
            }
            finally
            {
                db.Dispose();
            }
        }

        public bool Drop_PacienteProdutos()
        {
            var db = new DBAcessOleDB();

            var tableName = "PacienteProdutos";

            var Mysql = "DROP  TABLE " + tableName;

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
