using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencao_Assistida.Classes.Mysql
{
    [DataObject(true)]
    public class Avisos
    {

        public Avisos()
        {

           

        }

        public static string TemAcessoOficio(int codusuario)
        {
            var db = new DBAcess();

            var Mysql = " SELECT codusuario ";
            Mysql = Mysql + " FROM acesso_permisao  ";
            Mysql = Mysql + " WHERE codusuario = @Codusuario ";
            Mysql = Mysql + " AND CODFORM = 17 ";
            Mysql = Mysql + " AND EDITAR = 'S' ";

            db.CommandText = Mysql;

            db.AddParameter("@Codusuario", codusuario);

            try
            {
                var r = Convert.ToString(db.ExecuteScalar());
                return r;
            }
            finally
            {
                
            }
        }

        public static string TemOficio(int codempresa, int coddepartamento, int tipo, int aprovado, string status)
        {
            var db = new DBAcess();

            var Mysql = " SELECT CODEMPRESA ";
            Mysql = Mysql + " FROM pedido ";
            Mysql = Mysql + " WHERE CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND TIPO = @TIPO ";
            Mysql = Mysql + " AND APROVADO = @APROVADO ";
            Mysql = Mysql + " AND STATUS = @STATUS ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@TIPO", tipo);
            db.AddParameter("@APROVADO", aprovado);
            db.AddParameter("@STATUS", status);

            try
            {
                var r = Convert.ToString(db.ExecuteScalar());
                return r;
            }
            finally
            {

            }
        }

        public static string TemAcessoAutoriza(int codusuario)
        {
            var db = new DBAcess();

            var Mysql = " SELECT codusuario ";
            Mysql = Mysql + " FROM acesso_permisao  ";
            Mysql = Mysql + " WHERE codusuario = @Codusuario ";
            Mysql = Mysql + " AND CODFORM = 17 ";
            Mysql = Mysql + " AND EDITAR = 'S' ";

            db.CommandText = Mysql;

            db.AddParameter("@Codusuario", codusuario);

            try
            {
                var r = Convert.ToString(db.ExecuteScalar());
                return r;
            }
            finally
            {

            }
        }

        public static string TemAutoriza(int codempresa, int coddepartamento, int tipo, int aprovado, string status)
        {
            var db = new DBAcess();

            var Mysql = " SELECT CODEMPRESA ";
            Mysql = Mysql + " FROM pedido ";
            Mysql = Mysql + " WHERE CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND TIPO = @TIPO ";
            Mysql = Mysql + " AND APROVADO = @APROVADO ";
            Mysql = Mysql + " AND STATUS = @STATUS ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@TIPO", tipo);
            db.AddParameter("@APROVADO", aprovado);
            db.AddParameter("@STATUS", status);

            try
            {
                var r = Convert.ToString(db.ExecuteScalar());
                return r;
            }
            finally
            {

            }
        }

    }
}
