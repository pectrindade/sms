using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencao_Assistida.Classes.Mysql
{
    public class Cfop
    {
        public Cfop(string codcfop, string descricao, string aplicacao)
        {
            Codcfop = codcfop;
            Descricao = descricao;
            Aplicacao = aplicacao;
        }

        public Cfop(string codcfop)
        {
            Codcfop = codcfop;
        }
        public Cfop()
        {

        }

        private string Codcfop { get; set; }
        private string Descricao { get; set; }
        private string Aplicacao { get; set; }


        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO Cfop(";
            Mysql = Mysql + " CODCFOP, DESCRICAO, APLICACAO ";
            Mysql = Mysql + " ) ";
            Mysql = Mysql + " VALUES (";
            Mysql = Mysql + " @CODCFOP, @DESCRICAO, @APLICACAO ";
            Mysql = Mysql + ");";

            db.CommandText = Mysql;

            db.AddParameter("@CODCFOP", Codcfop);
            db.AddParameter("@DESCRICAO", Descricao);
            db.AddParameter("@APLICACAO", Aplicacao);

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
            var Mysql = " UPDATE Cfop SET ";
            Mysql = Mysql + " CODCFOP = @CODCFOP, ";
            Mysql = Mysql + " DESCRICAO = @DESCRICAO, ";
            Mysql = Mysql + " APLICACAO = @APLICACAO ";

            Mysql = Mysql + " WHERE CODCFOP = @CODCFOP;";

            db.CommandText = Mysql;

            db.AddParameter("@CODCFOP", Codcfop);
            db.AddParameter("@DESCRICAO", Descricao);
            db.AddParameter("@APLICACAO", Aplicacao);

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
            const string insert = " INSERT INTO Cfop (CODCfop, DESCRICAO) ";
            const string values = " VALUES (@CODCfop, @Descricao);";
            const string select = " ";
            db.CommandText = insert + values + select;
            db.AddParameter("@CODCfop", Codcfop);
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
            const string update = " UPDATE `Cfop` ";
            const string set = " SET DESCRICAO = @Descricao ";
            const string where = " WHERE CODCfop = @CodCfop;";
            db.CommandText = update + set + where;
            db.AddParameter("@CodCfop", Codcfop);
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
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Cfop ";
            Mysql = Mysql + " WHERE CODCFOP = @CODCFOP ";
            db.CommandText = Mysql;
            db.AddParameter("@CODCFOP", Codcfop);

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
            Mysql = Mysql + " FROM Cfop ";

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
            const string delete = " DELETE FROM Cfop ";

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
            const string update = " UPDATE `Cfop` ";
            const string set = " SET EXCLUIDO = @Excluido, DATAHORAEXCLUSAO = @DataHoraExclusao, EXCLUIDOPOR = @ExcluidoPor";
            const string where = " WHERE CODCURSO = @CodCurso;";
            db.CommandText = update + set + where;
            db.AddParameter("@CodCurso", Codcfop);


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
        public static MySqlDataReader Select(string Descricao)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Cfop ";

            if (Descricao != "")
            {
                Mysql = Mysql + "WHERE DESCRICAO LIKE CONCAT(@DESCRICAO)";
                Descricao = '%' + Descricao + "%";
            }

            db.CommandText = Mysql;
            db.AddParameter("@DESCRICAO", Descricao);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet Select(bool todas)
        {
            var db = new DBAcess();
            const string select = " SELECT * ";
            const string from = " FROM Cfop ";

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
        public static MySqlDataReader Select(string campo, string valor)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Cfop ";

            switch (campo)
            {
                case "descricao":
                    {
                        Mysql = Mysql + " WHERE descricao LIKE CONCAT(@valor) ";
                        valor = '%' + valor + "%";
                    }
                    break;
                case "codigo":
                    {
                        Mysql = Mysql + " WHERE CODCFOP = @valor ";
                    }
                    break;


            }
            Mysql = Mysql + " ORDER BY descricao ASC; ";
            db.CommandText = Mysql;

            db.AddParameter("@valor", valor);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

    }
}
