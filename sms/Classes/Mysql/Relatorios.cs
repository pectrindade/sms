using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencao_Assistida.Classes.Mysql
{
    public class Relatorios
    {

        public static MySqlDataReader SelectPacienteProduto(int codigo)
        {
            var db = new DBAcess();
            string Mysql = " SELECT PR.CODPROTOCOLO, PR.NUMEROPROTOCOLO, PR.CODPACIENTE, PA.NOME AS NOMEPACIENTE, PR.SITUACAO, ";
            Mysql = Mysql + " PI.CODPRODUTO, P.DESCRICAO AS NOMEPRODUTO, PI.QUANTIDADE ";
            Mysql = Mysql + " FROM protocolo AS PR ";

            Mysql = Mysql + " INNER JOIN paciente AS PA ON PR.CODPACIENTE = PA.CODPACIENTE ";
            Mysql = Mysql + " INNER JOIN protocolo_item AS PI ON PI.CODPROTOCOLO = PR.CODPROTOCOLO ";
            Mysql = Mysql + " INNER JOIN produtos AS P ON P.CODPRODUTO = PI.CODPRODUTO ";

            Mysql = Mysql + " WHERE PR.DATASITUACAO != '0000-00-00 00:00:00'  ";


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


    }
}
