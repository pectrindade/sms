using Atencao_Assistida.Classes.Mysql;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

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

        //FUNÇÃO PARA FECHAR ESTOQUE DE UM ITEM 

        public static void FechaEstoqueUm(string coddepartamento, string grupo, string codproduto, string dtprocesso )
        {
            var codempresa = Usuario.Codempresa.ToString();
                                   
            DateTime data = Convert.ToDateTime(dtprocesso);

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);


            //PRIMEIRO PEGA O PRIMEIRO E O ULTIMO DIA DO MES 
            //DateTime com o primeiro dia do mês
            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);
            var dtinicial = primeiroDiaDoMes.ToString("dd/MM/yyyy");

            //DateTime com o último dia do mês
            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
            var dtfinal = ultimoDiaDoMes.ToString("dd/MM/yyyy");
            var UltimoDia = ultimoDiaDoMes.ToString("dd");

            var Est = new Estoque();

            var retorno = Est.DeleteMesAno(int.Parse(codempresa), int.Parse(coddepartamento), mes, ano, codproduto, grupo);

            //SEGUNDO PEGA OS PRODUTOS
            var dr = Produto.Select(codproduto, int.Parse(coddepartamento), grupo);

            var cont = new Produto();
            var Cont = cont.SelectCount();

            //int progresso1 = 0;
            //int progresso2 = 0;
           

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    SaldoAnterior(int.Parse(codempresa), int.Parse(dr.GetString(dr.GetOrdinal("CODPRODUTO"))), dtprocesso);

                  
                    var cod = int.Parse(dr.GetString(dr.GetOrdinal("CODPRODUTO")));

                    DateTime totalDeDias = primeiroDiaDoMes;
                    for (int i = 0; i < int.Parse(UltimoDia); i++)
                    {
                        EntradaProduto(int.Parse(codempresa), int.Parse(coddepartamento), totalDeDias.ToString("dd/MM/yyyy"), int.Parse(dr.GetString(dr.GetOrdinal("CODPRODUTO"))), dtprocesso);

                        SaidaProduto(int.Parse(codempresa), int.Parse(coddepartamento), totalDeDias.ToString("dd/MM/yyyy"), int.Parse(dr.GetString(dr.GetOrdinal("CODPRODUTO"))), dtprocesso);

                        var Adiciona = totalDeDias.AddDays(1).ToString("dd/MM/yyyy");
                        totalDeDias = Convert.ToDateTime(Adiciona);

                        //progresso2 = progresso2 + 1;
                       // progressBar2.Value = i;
                    }

                    SaldoAtual(int.Parse(codempresa), int.Parse(dr.GetString(dr.GetOrdinal("CODPRODUTO"))), dtprocesso);

                   

                }

            }

            dr.Close();
            dr.Dispose();


            MessageBox.Show("Fim do Processo !");
        }

        public static void SaldoAnterior(int codempresa, int codproduto, string dtprocesso)
        {

            DateTime data = Convert.ToDateTime(dtprocesso);

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);

            var coddepartamento = Usuario.Coddepartamento.ToString();

            var Est = new Estoque();

            #region Quantidade Mes Anterior

            var mesanterior = Est.BuscaMesAnterior(mes, ano);
            vmes = mesanterior.Substring(0, 2);
            vano = mesanterior.Substring(2, 4);

            #region Verrificação de Balanco

            //DateTime com o primeiro dia do mês
            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);
            var dtinicial = primeiroDiaDoMes.ToString("dd/MM/yyyy");

            //DateTime com o último dia do mês
            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
            var dtfinal = ultimoDiaDoMes.ToString("dd/MM/yyyy");

            var temBalanco = Est.TemBalanco(codempresa, int.Parse(coddepartamento), dtinicial, dtfinal, codproduto);
            var QtAnterior = "0";

            #endregion
            if (temBalanco == true)
            {
                QtAnterior = "0";
            }
            else
            {
                //-> Buscando a quantidade do mes anterior 
                QtAnterior = Est.Anterior(codempresa, int.Parse(coddepartamento), int.Parse(vmes), int.Parse(vano), codproduto).ToString();
            }

            // id, codempresa, mes, ano,codproduto, qtanterior, entrada, saida , qtatual 
            var m = new Estoque(0, codempresa, int.Parse(coddepartamento), mes, ano, codproduto, QtAnterior.ToString(), "0", "0", "0");

            m.GravaAnterior();

            #endregion;

        }

        public static void EntradaProduto(int codempresa, int coddepartamento, string dia, int codproduto, string dtprocesso)
        {

            DateTime data = Convert.ToDateTime(dtprocesso);

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);


            var ent = new Estoque(codempresa, coddepartamento, mes, ano, codproduto);

            ent.Fecha_Entradas(codempresa, coddepartamento, dia, codproduto);


        }

        public static void SaidaProduto(int codempresa, int coddepartamento, string dia, int codproduto, string dtprocesso)
        {
            DateTime data = Convert.ToDateTime(dtprocesso);

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);


            var ent = new Estoque(codempresa, coddepartamento, mes, ano, codproduto);

            ent.Fecha_Saida(codempresa, coddepartamento, dia, codproduto);

        }

        public static void SaldoAtual(int codempresa, int codproduto, string dtprocesso)
        {
            DateTime data = Convert.ToDateTime(dtprocesso);

            var vmes = data.ToString("MM");
            int mes = int.Parse(vmes);

            var vano = data.ToString("yyyy");
            int ano = int.Parse(vano);
            var coddepartamento = Usuario.Coddepartamento.ToString();

            #region Quantidade Atual

            var atual = new Estoque(0, codempresa, int.Parse(coddepartamento), mes, ano, codproduto, "0", "0", "0", "0");

            atual.AtualizaQtAtual();

            #endregion

        }


    }
}
