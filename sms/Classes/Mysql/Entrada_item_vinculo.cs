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
    [DataObject(true)]
    public class Entrada_item_vinculo
    {
        private int Id { get; set; }
        private int Codproduto { get; set; }
        private int Codfornecedor { get; set; }
        private string Codprodutofornecedor { get; set; }
        private string Nomeprodutofornecedor { get; set; }

        public Entrada_item_vinculo(int codproduto, int codfornecedor, string codprodutofornecedor, string nomeprodutofornecedor)
        {
           
            Codproduto = codproduto;
            Codfornecedor = codfornecedor;
            Codprodutofornecedor = codprodutofornecedor;
            Nomeprodutofornecedor = nomeprodutofornecedor;
            

        }
               

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO Entrada_item_vinculo(";
            Mysql = Mysql + " CODPRODUTO, CODFORNECEDOR, CODPRODUTOFORNECEDOR, NOMEPRODUTOFORNECEDOR ";
            Mysql = Mysql + ") ";

            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODPRODUTO, @CODFORNECEDOR, @CODPRODUTOFORNECEDOR, @NOMEPRODUTOFORNECEDOR ";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@CODFORNECEDOR", Codfornecedor);
            db.AddParameter("@CODPRODUTOFORNECEDOR", Codprodutofornecedor);
            db.AddParameter("@NOMEPRODUTOFORNECEDOR", Nomeprodutofornecedor);
           


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
            var Mysql = " UPDATE Entrada_item_vinculo ";
            Mysql = Mysql + " SET";
            Mysql = Mysql + " CODPRODUTO = @CODPRODUTO,  ";
            Mysql = Mysql + " CODFORNECEDOR = @CODFORNECEDOR, ";
            Mysql = Mysql + " CODPRODUTOFORNECEDOR = @CODPRODUTOFORNECEDOR, ";
            Mysql = Mysql + " NOMEPRODUTOFORNECEDOR = @NOMEPRODUTOFORNECEDOR ";

            Mysql = Mysql + " WHERE CODPRODUTO = @CODPRODUTO ";
            Mysql = Mysql + " AND CODFORNECEDOR = @CODFORNECEDOR ";

            db.CommandText = Mysql;
            
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@CODFORNECEDOR", Codfornecedor);
            db.AddParameter("@CODPRODUTOFORNECEDOR", Codprodutofornecedor);
            db.AddParameter("@NOMEPRODUTOFORNECEDOR", Nomeprodutofornecedor);

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
                
        public void Delete(string Numeronota, int Codproduto, int Mes, int Ano)
        {
            var db = new DBAcess();
            var Mysql = " DELETE FROM Entrada_item_vinculo ";
            Mysql = Mysql + " WHERE NUMERONOTA = @NUMERONOTA ";
            Mysql = Mysql + " AND CODPRODUTO = @CODPRODUTO ";
            Mysql = Mysql + " AND ANO = @ANO ";
            Mysql = Mysql + " AND MES = @MES ";

            db.CommandText = Mysql;

            db.AddParameter("@NUMERONOTA", Numeronota);
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@MES", Mes);
            db.AddParameter("@ANO", Ano);

            try
            {
                db.ExecuteNonQuery();
            }
            catch
            {

            }
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectItem(int codentrada, int codfornecedor)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";

            Mysql = Mysql + " FROM Entrada_item_vinculo ";
            Mysql = Mysql + " WHERE CODPRODUTO = @CODPRODUTO ";
            Mysql = Mysql + " AND CODFORNECEDOR = @CODFORNECEDOR ";

            db.CommandText = Mysql;
            db.AddParameter("@CODPRODUTO", codentrada);
            db.AddParameter("@CODFORNECEDOR", codfornecedor);
           
            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

      

    }
}