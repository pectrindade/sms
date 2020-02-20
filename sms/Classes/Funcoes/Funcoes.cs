﻿using System;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace Atencao_Assistida.Classes.Funcoes
{
    class Funcoes
    {


        public static DateTime ConvertJulianToDateTime(double julianDate)
        {
            var dataRef = new DateTime(1900, 1, 1);
            return dataRef.AddDays(julianDate - 2);
        }

        public static string RetiraAcentos(string valor)
        {
            var acentos = new[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û" };
            var semAcento = new[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
            for (int i = 0; i < acentos.Length; i++)
            {
                valor = valor.Replace(acentos[i], semAcento[i]);
            }
            string[] caracteresEspeciais = { "\\.", ",", "-", ":", "\\(", "\\)", "ª", "\\|", "\\\\", "°" };
            valor = caracteresEspeciais.Aggregate(valor, (current, t) => current.Replace(t, ""));
            valor = valor.Replace("^\\s+", "");
            valor = valor.Replace("\\s+$", "");
            valor = valor.Replace("\\s+", " ");
            return valor;
        }

        public static void EnviarEmail1(string destinatarioNome, string destinatarioEmail, string assunto, string corpoEmail)
        {
            var cliente = new SmtpClient();
            cliente.Host = "smtp.gmail.com";
            cliente.Port = 465;
            cliente.EnableSsl = true;
            cliente.UseDefaultCredentials = false;
            var credenciais = new NetworkCredential("renatolsouza@gmail.com", "pedroefelipe");
            cliente.Credentials = credenciais;

            var remetente = new MailAddress("renatolsouza@gmail.com", "Oficio Informática - TI (Programação)");
            var destinatario = new MailAddress(destinatarioEmail, destinatarioNome);
            var mensagem = new MailMessage(remetente, destinatario) { Body = corpoEmail, Subject = assunto, IsBodyHtml = true };


            cliente.Send(mensagem);
        }

        public static void EnviarEmail(string destinatarioNome, string destinatarioEmail, string assunto, string corpoEmail)
        {
            var cliente = new SmtpClient("smtp.gmail.com", 587) { EnableSsl = true };
            var remetente = new MailAddress("oficiotecnologia@gmail.com", "Oficio Tecnologia - TI (Programação)");
            var destinatario = new MailAddress(destinatarioEmail, destinatarioNome);
            var mensagem = new MailMessage(remetente, destinatario) { Body = corpoEmail, Subject = assunto, IsBodyHtml = true };
            var credenciais = new NetworkCredential("oficiotecnologia@gmail.com", "@cpdrede12");
            cliente.Credentials = credenciais;
            cliente.Send(mensagem);
        }

        public static string removeFormatacao(string texto)
        {
            string txt = "";
            txt = texto.Replace(".", "");
            txt = txt.Replace("-", "");
            txt = txt.Replace("/", "");
            txt = txt.Replace("(", "");
            txt = txt.Replace(")", "");
            txt = txt.Replace(" ", "");
            return txt;
        }

        public static string tiraponto(string texto)
        {
            string txt = "";
            txt = texto.Replace(".", ",");

            return txt;
        }

        public static int FaltaQuantofinAno()
        {
            DateTime agora = DateTime.Now;
            var ano = agora.Year;

            DateTime inicio = Convert.ToDateTime(ano + ", 12, 31");


            DateTime data_inicial = agora;
            DateTime data_final = inicio;

            // obtém a diferença
            TimeSpan dif = data_final.Subtract(data_inicial);

            // exibe o resultado
            var quatos = (dif.Days / 30);

            return quatos;
        }

        public static string TirarAcento(string palavra)
        {
            string palavraSemAcento = "";
            string caracterComAcento = "áàãâäéèêëíìîïóòõôöúùûüçÁÀÃÂÄÉÈÊËÍÌÎÏÓÒÕÖÔÚÙÛÜÇ";
            string caracterSemAcento = "aaaaaeeeeiiiiooooouuuucAAAAAEEEEIIIIOOOOOUUUUC";

            for (int i = 0; i < palavra.Length; i++)
            {
                if (caracterComAcento.IndexOf(Convert.ToChar(palavra.Substring(i, 1))) >= 0)
                {
                    int car = caracterComAcento.IndexOf(Convert.ToChar(palavra.Substring(i, 1)));
                    palavraSemAcento += caracterSemAcento.Substring(car, 1);
                }
                else
                {
                    palavraSemAcento += palavra.Substring(i, 1);
                }
            }

            return palavraSemAcento;
        }

        public static string soNumero(string txt)
        {
            if (txt == "a") { txt = "0"; };
            if (txt == "b") { txt = "0"; };
            if (txt == "c") { txt = "0"; };
            if (txt == "d") { txt = "0"; };
            if (txt == "e") { txt = "0"; };
            if (txt == "f") { txt = "0"; };
            if (txt == "g") { txt = "0"; };
            if (txt == "h") { txt = "0"; };
            if (txt == "i") { txt = "0"; };
            if (txt == "j") { txt = "0"; };
            if (txt == "l") { txt = "0"; };
            if (txt == "m") { txt = "0"; };
            if (txt == "n") { txt = "0"; };
            if (txt == "o") { txt = "0"; };
            if (txt == "p") { txt = "0"; };
            if (txt == "q") { txt = "0"; };
            if (txt == "r") { txt = "0"; };
            if (txt == "s") { txt = "0"; };
            if (txt == "t") { txt = "0"; };
            if (txt == "u") { txt = "0"; };
            if (txt == "v") { txt = "0"; };
            if (txt == "x") { txt = "0"; };
            if (txt == "z") { txt = "0"; };

            if (txt == "A") { txt = "0"; };
            if (txt == "B") { txt = "0"; };
            if (txt == "C") { txt = "0"; };
            if (txt == "D") { txt = "0"; };
            if (txt == "E") { txt = "0"; };
            if (txt == "F") { txt = "0"; };
            if (txt == "G") { txt = "0"; };
            if (txt == "H") { txt = "0"; };
            if (txt == "I") { txt = "0"; };
            if (txt == "J") { txt = "0"; };
            if (txt == "L") { txt = "0"; };
            if (txt == "M") { txt = "0"; };
            if (txt == "N") { txt = "0"; };
            if (txt == "O") { txt = "0"; };
            if (txt == "P") { txt = "0"; };
            if (txt == "Q") { txt = "0"; };
            if (txt == "R") { txt = "0"; };
            if (txt == "S") { txt = "0"; };
            if (txt == "T") { txt = "0"; };
            if (txt == "U") { txt = "0"; };
            if (txt == "V") { txt = "0"; };
            if (txt == "X") { txt = "0"; };
            if (txt == "Z") { txt = "0"; };

            return txt;
        }
    }
}
