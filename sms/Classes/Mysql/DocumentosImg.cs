using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;

namespace Atencao_Assistida.Classes.Mysql
{
    public class DocumentosImg
    {

        private int Codimagem { get; set; }
        private int Codpaciente { get; set; }
        private int Numeroimagem { get; set; }
        private string Nomeimagem { get; set; }
        private string Imagem { get; set; }

        public DocumentosImg(int codimagem, int codpaciente, int numeroimagem, string nomeimagem, string imagem)
        {
            Codimagem = codimagem;

            Codpaciente = codpaciente;
            Numeroimagem = numeroimagem;
            Nomeimagem = nomeimagem;
            Imagem = imagem;

        }

        public int Insert()
        {

            FileStream fs;
            BinaryReader br;
            string FileName = Imagem;
            byte[] ImageData;
            fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            ImageData = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();

            var db = new DBAcess();
            const string insert = " INSERT INTO img_paciente( " +
                                " CODPACIENTE, NUMEROIMAGEM, NOMEIMAGEM, IMAGEM " +
                                ") ";
            const string values = " VALUES(" +
                                " @CODPACIENTE, @NUMEROIMAGEM, @NOMEIMAGEM, @IMAGEM " +
                                "); ";
            const string select = " ";
            db.CommandText = insert + values + select;

            db.AddParameter("@CODPACIENTE", Codpaciente);
            db.AddParameter("@NUMEROIMAGEM", Numeroimagem);
            db.AddParameter("@NOMEIMAGEM", Nomeimagem);
            db.AddParameter("@IMAGEM", ImageData);


            try
            {

                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }


        public static Image redimensionarImagem(Image imagem, Size tamanho)
        {
            int larguraOrigem = imagem.Width;
            int alturaOrigem = imagem.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)tamanho.Width / (float)larguraOrigem);
            nPercentH = ((float)tamanho.Height / (float)alturaOrigem);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int larguraDestino = (int)(larguraOrigem * nPercent);
            int alturaDestino = (int)(alturaOrigem * nPercent);

            Bitmap b = new Bitmap(larguraDestino, alturaDestino);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imagem, 0, 0, larguraDestino, alturaDestino);
            g.Dispose();

            return (Image)b;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader BuscaNomeImage(int codigo)
        {
            var db = new DBAcess();
            string Mysql = " SELECT CODIMAGEM, CODPACIENTE, NUMEROIMAGEM, NOMEIMAGEM, IMAGEM ";
           
            Mysql = Mysql + " FROM img_paciente ";
            Mysql = Mysql + " WHERE CODPACIENTE = @CODPACIENTE ";

            db.CommandText = Mysql;
            db.AddParameter("@CODPACIENTE", codigo);

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
        public static MySqlDataReader BuscaImagem(int codigo)
        {
            var db = new DBAcess();
            string Mysql = " SELECT CODIMAGEM, CODPACIENTE, NUMEROIMAGEM, NOMEIMAGEM, IMAGEM ";

            Mysql = Mysql + " FROM img_paciente ";
            Mysql = Mysql + " WHERE CODIMAGEM = @CODIMAGEM ";

            db.CommandText = Mysql;
            db.AddParameter("@CODIMAGEM", codigo);

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
        public static MySqlDataReader BuscaNumeroImagem(int codigo)
        {
            var db = new DBAcess();
            string Mysql = " SELECT max(NUMEROIMAGEM) AS ULTIMO ";

            Mysql = Mysql + " FROM img_paciente ";
            Mysql = Mysql + " WHERE CODPACIENTE = @CODPACIENTE ";

            db.CommandText = Mysql;
            db.AddParameter("@CODPACIENTE", codigo);

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
