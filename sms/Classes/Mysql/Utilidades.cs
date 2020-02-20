using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencao_Assistida.Classes.Funcoes
{
    public class Utilidades
    {
        private int Codigo { get; set; }
        private string Descricao { get; set; }

        public Utilidades()
        {

        }

        public static string BuscaUnidadeMedida(int codigo)
        {
            var nome = "";

            var dr = Classes.Mysql.UnidadeMedida.Select(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    nome = dr.GetString(dr.GetOrdinal("DESCRICAO"));
                }
            }

            dr.Close();
            dr.Dispose();
            return nome;
        }

        public static string BuscaGrupo(int codigo)
        {
            var nome = "";

            var dr = Classes.Mysql.Grupo.Select(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    nome = dr.GetString(dr.GetOrdinal("DESCRICAO"));
                }
            }

            dr.Close();
            dr.Dispose();
            return nome;
        }

        public static string BuscaMarca(int codigo)
        {
            var nome = "";

            var dr = Classes.Mysql.Marca.Select(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    nome = dr.GetString(dr.GetOrdinal("DESCRICAO"));
                }
            }

            dr.Close();
            dr.Dispose();
            return nome;
        }

        public static string LeituraArquivo(string caminho)
        {

            var texto = "";

            string arquivo = @"C:\sms.ini";
            if (File.Exists(arquivo))
            {
                try
                {
                    StreamReader streamReader = new StreamReader(arquivo);
                    String linha;

                    // Lê linha por linha até o final do arquivo
                    while ((linha = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                }
            }
            else
            {
                //Console.WriteLine(" O arquivo " + arquivo + "não foi localizado !");
            }

            return texto;
        }

        public static bool ValidaCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public static string RemoveFormatacao(string texto)
        {
            string txt = "";
            txt = texto.Replace(".", "");
            txt = texto.Replace(",", "");
            txt = txt.Replace("-", "");
            txt = txt.Replace("/", "");
            txt = txt.Replace("(", "");
            txt = txt.Replace(")", "");
            txt = txt.Replace(" ", "");
            return txt;
        }

        public static string  FormataNomeImagem(string texto)
        {
            string txt = "";
            txt = texto.Replace(" ", "_");
            txt = txt.Replace("/", "-");
            txt = txt.Replace("+", "-");
            txt = txt.Replace("*", "-");
            return txt;
        }

    }
}
