﻿using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;

namespace Atencao_Assistida.Classes.Mysql
{
    [DataObject(true)]
    public class Estoque
    {
        private int Id { get; set; }
        private int Codempresa { get; set; }
        private int Coddepartamento { get; set; }
        private int Mes { get; set; }
        private int Ano { get; set; }
        private int Codproduto { get; set; }
        private string Qtanterior { get; set; }
        private string Entrada { get; set; }
        private string Saida { get; set; }
        private string Qtatual { get; set; }

        public Estoque(int id, int codempresa, int coddepartamento, int mes, int ano, int codproduto, string qtanterior, string entrada, string saida, string qtatual)
        {
            Id = id;
            Codempresa = codempresa;
            Coddepartamento = coddepartamento;
            Mes = mes;
            Ano = ano;
            Codproduto = codproduto;
            Qtanterior = qtanterior;
            Entrada = entrada;
            Saida = saida;
            Qtatual = qtatual;

        }

        public Estoque(int codempresa, int coddepartamento, int mes, int ano, int codproduto)
        {
            Codempresa = codempresa;
            Coddepartamento = coddepartamento;
            Mes = mes;
            Ano = ano;
            Codproduto = codproduto;
        }

        public Estoque()
        {

        }


        public int GravaAnterior()
        {
            var db = new DBAcess();
            string Mysql = " select * ";
            Mysql = Mysql + " from estoque ";

            string where = " WHERE CODEMPRESA = @CODEMPRESA";
            where = where + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO";
            where = where + " AND MES = @MES";
            where = where + " AND ANO = @ANO";
            where = where + " AND CODPRODUTO = @CODPRODUTO;";


            db.CommandText = Mysql + where;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@MES", Mes);
            db.AddParameter("@ANO", Ano);
            db.AddParameter("@CODPRODUTO", Codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();


            if (dr.HasRows)
            {
                Update();
            }
            else
            {
                Insert();
            }
            dr.Dispose();
            dr.Close();

            return 1;
        }

        public bool UpdateAnterior(string qtanterior)
        {
            var db = new DBAcess();
            const string update = " UPDATE estoque ";
            const string set = " SET" +
                               " QTANTERIOR = @QTANTERIOR ";
            string where = " WHERE CODEMPRESA = @CODEMPRESA";
            where = where + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO";
            where = where + " AND MES = @MES";
            where = where + " AND ANO = @ANO";
            where = where + " AND CODPRODUTO = @CODPRODUTO;";

            db.CommandText = update + set + where;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@MES", Mes);
            db.AddParameter("@ANO", Ano);
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@QTANTERIOR", Convert.ToDecimal(qtanterior));


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

        public int Insert()
        {
            var db = new DBAcess();
            const string insert = " INSERT INTO estoque(" +
                                  " CODEMPRESA, CODDEPARTAMENTO, MES, ANO, CODPRODUTO, QTANTERIOR, ENTRADA, SAIDA, QTATUAL " +

                                  ") ";
            const string values = " VALUES(" +
                                  " @CODEMPRESA, @CODDEPARTAMENTO, @MES, @ANO, @CODPRODUTO, @QTANTERIOR, @ENTRADA, @SAIDA, @QTATUAL" +
                                  "); ";
            //const string select = " ";
            const string select = " ";
            db.CommandText = insert + values + select;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@MES", Mes);
            db.AddParameter("@ANO", Ano);
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@QTANTERIOR", Convert.ToDecimal(Qtanterior));
            db.AddParameter("@ENTRADA", Entrada);
            db.AddParameter("@SAIDA", Saida);
            db.AddParameter("@QTATUAL", Qtatual);

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
            const string update = " UPDATE estoque ";
            const string set = " SET" +
                               " CODEMPRESA = @CODEMPRESA, CODDEPARTAMENTO = @CODDEPARTAMENTO, MES = @MES, ANO = @ANO, CODPRODUTO = @CODPRODUTO, QTANTERIOR = @QTANTERIOR ";

            string where = " WHERE CODEMPRESA = @CODEMPRESA";
            where = where + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO";
            where = where + " AND MES = @MES";
            where = where + " AND ANO = @ANO";
            where = where + " AND CODPRODUTO = @CODPRODUTO;";

            db.CommandText = update + set + where;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@MES", Mes);
            db.AddParameter("@ANO", Ano);
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@QTANTERIOR", Convert.ToDecimal(Qtanterior));



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

        public bool UpdateEntrada(string qtentrada)
        {
            var db = new DBAcess();
            const string update = " UPDATE estoque ";
            const string set = " SET" +
                               " ENTRADA = @ENTRADA ";
            string where = " WHERE CODEMPRESA = @CODEMPRESA";
            where = where + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO";
            where = where + " AND MES = @MES";
            where = where + " AND ANO = @ANO";
            where = where + " AND CODPRODUTO = @CODPRODUTO;";

            db.CommandText = update + set + where;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@MES", Mes);
            db.AddParameter("@ANO", Ano);
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@ENTRADA", Convert.ToDecimal(qtentrada));


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

        public bool UpdateSaida(string qtsaida)
        {
            var db = new DBAcess();
            const string update = " UPDATE estoque ";
            const string set = " SET" +
                               " SAIDA = @SAIDA ";
            string where = " WHERE CODEMPRESA = @CODEMPRESA";
            where = where + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO";
            where = where + " AND MES = @MES";
            where = where + " AND ANO = @ANO";
            where = where + " AND CODPRODUTO = @CODPRODUTO;";

            db.CommandText = update + set + where;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@MES", Mes);
            db.AddParameter("@ANO", Ano);
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@SAIDA", Convert.ToDecimal(qtsaida));


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

        public bool UpdateSaldoAtual(string SaldoAtual)
        {
            var db = new DBAcess();
            const string update = " UPDATE estoque ";
            const string set = " SET" +
                               " QTATUAL = @QTATUAL ";
            string where = " WHERE CODEMPRESA = @CODEMPRESA";
            where = where + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO";
            where = where + " AND MES = @MES";
            where = where + " AND ANO = @ANO";
            where = where + " AND CODPRODUTO = @CODPRODUTO;";

            db.CommandText = update + set + where;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@MES", Mes);
            db.AddParameter("@ANO", Ano);
            db.AddParameter("@CODPRODUTO", Codproduto);
            db.AddParameter("@QTATUAL", Convert.ToDecimal(SaldoAtual));


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


        public bool DeleteMesAno(int codempresa, int coddepartamento, int mes, int ano, string produto, string grupo)
        {
            var db = new DBAcess();
            var Mysql = " DELETE E.* FROM estoque E ";
            Mysql = Mysql + " INNER JOIN produtos P ON P.CODPRODUTO = E.CODPRODUTO ";
            Mysql = Mysql + " WHERE E.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND E.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND E.MES = @MES ";
            Mysql = Mysql + " AND E.ANO = @ANO ";
            if (produto != "") { Mysql = Mysql + " AND E.CODPRODUTO = @CODPRODUTO "; }
            if (grupo != "") { Mysql = Mysql + " AND P.CODGRUPO = @CODGRUPO "; }

            db.CommandText = Mysql;
            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@MES", mes);
            db.AddParameter("@ANO", ano);

            if (produto == "") { produto = "0"; }
            if (grupo == "") { grupo = "0"; }

            db.AddParameter("@CODPRODUTO", int.Parse(produto));
            db.AddParameter("@CODGRUPO", int.Parse(grupo));



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

        #region QtAnterior

        // -> Depois ver esse codigo para melhoras 
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader BuscaAnterior(int codempresa, int coddepartamento, int mes, int ano, int codproduto)
        {
            var db = new DBAcess();
            const string select = " SELECT QTATUAL ";
            const string from = " FROM estoque ";

            string where = " WHERE CODEMPRESA = @CODEMPRESA";
            where = where + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO";
            where = where + " AND MES = @MES";
            where = where + " AND ANO = @ANO";
            where = where + " AND CODPRODUTO = @CODPRODUTO;";

            db.CommandText = select + from + where;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@MES", mes);
            db.AddParameter("@ANO", ano);
            db.AddParameter("@CODPRODUTO", codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        public float Anterior(int codempresa, int coddepartamento, int mes, int ano, int codproduto)
        {
            float qtanterior = 0;

            var dr = BuscaAnterior(codempresa, coddepartamento, mes, ano, codproduto);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    qtanterior = dr.GetFloat(dr.GetOrdinal("QTATUAL"));
                }
            }
            else
            {
                qtanterior = 0;
            }
            dr.Dispose();
            dr.Close();

            return qtanterior;
        }

        public string BuscaMesAnterior(int mes, int ano)
        {

            string MesAno = "";

            mes = mes - 1;
            if (mes == 0)
            {
                mes = 12;
                ano = ano - 1;
            }
            MesAno = mes.ToString("D2") + "" + ano;

            return MesAno;
        }

        #endregion

        #region Entrada

        public int GravaEntradaUnica()
        {
            float qtEntradaAntes = 0;
            float qtEntrada = 0;

            var db = new DBAcess();
            string Mysql = " select ENTRADA ";
            Mysql = Mysql + " from estoque ";

            string where = " WHERE CODEMPRESA = @CODEMPRESA";
            where = where + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO";
            where = where + " AND MES = @MES";
            where = where + " AND ANO = @ANO";
            where = where + " AND CODPRODUTO = @CODPRODUTO;";


            db.CommandText = Mysql + where;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@MES", Mes);
            db.AddParameter("@ANO", Ano);
            db.AddParameter("@CODPRODUTO", Codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (Entrada == null) { Entrada = "0"; }
                    qtEntradaAntes = dr.GetFloat(dr.GetOrdinal("ENTRADA"));
                    qtEntrada = float.Parse(Entrada) + qtEntradaAntes;

                }

                UpdateEntrada(qtEntrada.ToString());
            }

            dr.Dispose();
            dr.Close();

            return 1;
        }

        public int Fecha_Entradas(int codempresa, int coddepartamento, string data, int codproduto)
        {

            //-> PROCESSO EM QUE BUSCA TODAS AS ENTRADAS NO MES DO REFERIDO PRODUTO
            //-> PROCESSO DE CORREÇÃO DE ESTOQUE 

            float qtEntrada = 0;

            var db = new DBAcess();
            string Mysql = " select E.CODENTRADA, E.CODEMPRESA, E.CODDEPARTAMENTO, E.NUMERONOTA, E.DATARECEBIMENTO, I.CODPRODUTO, P.DESCRICAO, I.LOTE, I.VALIDADE, I.QUANTIDADE ";
            Mysql = Mysql + " from entrada E  ";
            Mysql = Mysql + " inner join entrada_item as I on E.CODENTRADA = I.CODENTRADA ";
            Mysql = Mysql + " inner join produtos as P on I.CODPRODUTO = P.CODPRODUTO ";

            Mysql = Mysql + " WHERE E.DATARECEBIMENTO = @DATA ";
            Mysql = Mysql + " AND I.CODPRODUTO = @CODPRODUTO";
            Mysql = Mysql + " AND P.ATIVO = 1 ";
            Mysql = Mysql + " AND E.CODEMPRESA = @CODEMPRESA";
            Mysql = Mysql + " AND E.CODDEPARTAMENTO = @CODDEPARTAMENTO;";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATA", Convert.ToDateTime(data));

            db.AddParameter("@CODPRODUTO", codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    var QtB = BuscaBalanco(codempresa, coddepartamento, data, codproduto);
                    // se tem Balanço entao a entrada é o balanço
                    if (QtB != "")
                    {
                        qtEntrada = float.Parse(QtB);
                    }
                    else
                    {
                        qtEntrada = BuscaEntrada();

                        qtEntrada = qtEntrada + dr.GetFloat(dr.GetOrdinal("QUANTIDADE"));


                        var QtAjuste = BuscaAjuste(codempresa, coddepartamento, data, codproduto);
                        // se tem Ajuste entao a entrada é o ajuste
                        if (QtAjuste != "")
                        {

                            DateTime data1 = Convert.ToDateTime(data);

                            var vmes = data1.ToString("MM");
                            var vano = data1.ToString("yyyy");

                            UpdateAnterior("0");
                            UpdateEntrada(qtEntrada.ToString());

                            qtEntrada = float.Parse(QtAjuste);
                        }
                        else
                        {
                            UpdateEntrada(qtEntrada.ToString());
                        }
                    }
                }


            }
            else
            {
                var QtB = BuscaBalanco(codempresa, coddepartamento, data, codproduto);
                // se tem Balanço entao a entrada é o balanço
                if (QtB != "")
                {
                    qtEntrada = float.Parse(QtB);
                    UpdateEntrada(qtEntrada.ToString());
                }
                else
                {
                    var QtAjuste = BuscaAjuste(codempresa, coddepartamento, data, codproduto);
                    // se tem Ajuste entao a entrada é o ajuste
                    if (QtAjuste != "")
                    {

                        DateTime data1 = Convert.ToDateTime(data);

                        var vmes = data1.ToString("MM");
                        var vano = data1.ToString("yyyy");

                        UpdateAnterior("0");

                        qtEntrada = float.Parse(QtAjuste);
                        UpdateEntrada(qtEntrada.ToString());
                    }
                }
            }

            dr.Dispose();
            dr.Close();

            return 1;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader BuscaEntradaMes(int codempresa, int coddepartamento, string dtinicial, string dtfinal, int codproduto)
        {
            //-> PROCESSO EM QUE BUSCA TODAS AS ENTRADAS NO MES DO REFERIDO PRODUTO
            //-> PROCESSO DE CORREÇÃO DE ESTOQUE 

            var db = new DBAcess();
            string Mysql = " select E.CODENTRADA, E.CODEMPRESA, E.CODDEPARTAMENTO, E.NUMERONOTA, E.SERIE, E.DATARECEBIMENTO, I.CODPRODUTO, P.NOME AS DESCRICAO, I.LOTE, I.VALIDADE, I.QUANTIDADE ";
            Mysql = Mysql + " from entrada E  ";
            Mysql = Mysql + " inner join entrada_item as I on E.CODENTRADA = I.CODENTRADA ";
            Mysql = Mysql + " inner join produtos as P on I.CODPRODUTO = P.CODPRODUTO ";

            string where = " WHERE E.DATARECEBIMENTO BETWEEN @DATAINICIAL AND @DATAFINAL ";
            where = where + " AND I.CODPRODUTO = @CODPRODUTO";
            where = where + " AND E.CODEMPRESA = @CODEMPRESA";
            where = where + " AND E.CODDEPARTAMENTO = @CODDEPARTAMENTO;";

            db.CommandText = Mysql + where;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATAINICIAL", Convert.ToDateTime(dtinicial));
            db.AddParameter("@DATAFINAL", Convert.ToDateTime(dtfinal));
            db.AddParameter("@CODPRODUTO", codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        public float EntradaMes(int codempresa, int coddepartamento, string dtinicial, string dtfinal, int codproduto)
        {
            //-> PROCESSO EM QUE BUSCA TODAS AS ENTRADAS NO MES DO REFERIDO PRODUTO
            //-> PROCESSO DE CORREÇÃO DE ESTOQUE 

            float QtEntrada = 0;

            var dr = Estoque.BuscaEntradaMes(codempresa, coddepartamento, dtinicial, dtfinal, codproduto);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    QtEntrada = dr.GetFloat(dr.GetOrdinal("QUANTIDADE"));

                }
            }
            else
            {
                QtEntrada = 0;
            }
            dr.Dispose();
            dr.Close();



            return QtEntrada;
        }


        #endregion

        #region Saida

        public int GravaSaidaUnica()
        {
            float qtSaidaAntes = 0;
            float qtSaida = 0;

            var db = new DBAcess();
            string Mysql = " select SAIDA ";
            Mysql = Mysql + " from estoque ";

            string where = " WHERE CODEMPRESA = @CODEMPRESA";
            where = where + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO";
            where = where + " AND MES = @MES";
            where = where + " AND ANO = @ANO";
            where = where + " AND CODPRODUTO = @CODPRODUTO;";


            db.CommandText = Mysql + where;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@MES", Mes);
            db.AddParameter("@ANO", Ano);
            db.AddParameter("@CODPRODUTO", Codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    qtSaidaAntes = dr.GetFloat(dr.GetOrdinal("SAIDA"));
                    qtSaida = float.Parse(Saida) + qtSaidaAntes;

                }

                UpdateSaida(qtSaida.ToString());
            }

            dr.Dispose();
            dr.Close();

            return 1;
        }

        public int Fecha_Saida(int codempresa, int coddepartamento, string data, int codproduto)
        {
            //-> PROCESSO EM QUE BUSCA TODAS AS SAIDAS NO MES DO REFERIDO PRODUTO
            //-> PROCESSO DE CORREÇÃO DE ESTOQUE 

            float qtSaida = 0;

            var db = new DBAcess();
            string Mysql = " select S.CODSAIDA, S.CODEMPRESA, S.CODDEPARTAMENTO, S.NUMEROPEDIDO, S.DATAENTREGA, ";
            Mysql = Mysql + " I.CODPRODUTO, P.DESCRICAO, I.LOTE, I.VALIDADE, I.ENTREGUE ";
            Mysql = Mysql + " FROM saida S ";
            Mysql = Mysql + " inner JOIN saida_item as I ON S.CODSAIDA = I.CODSAIDA ";
            Mysql = Mysql + " inner join produtos as P on I.CODPRODUTO = P.CODPRODUTO ";

            Mysql = Mysql + " WHERE S.DATAENTREGA = @DATA";
            Mysql = Mysql + " AND I.CODPRODUTO = @CODPRODUTO";
            Mysql = Mysql + " AND P.ATIVO = 1 ";
            Mysql = Mysql + " AND S.CODEMPRESA = @CODEMPRESA";
            Mysql = Mysql + " AND S.CODDEPARTAMENTO = @CODDEPARTAMENTO;";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATA", Convert.ToDateTime(data));
            db.AddParameter("@CODPRODUTO", codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();


            if (dr.HasRows)
            {
                qtSaida = BuscaSaida();

                while (dr.Read())
                {

                    var QtB = BuscaBalanco(codempresa, coddepartamento, data, codproduto);


                    // se tem Balanço entao a saida é zero
                    if (QtB != "")
                    {
                        qtSaida = 0;
                    }
                    else
                    {
                        qtSaida = qtSaida + dr.GetFloat(dr.GetOrdinal("ENTREGUE"));
                    }


                }

                UpdateSaida(qtSaida.ToString());

            }

            dr.Dispose();
            dr.Close();

            return 1;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader BuscaSaidaMes(int codempresa, int coddepartamento, string dtinicial, string dtfinal, int codproduto)
        {
            //-> PROCESSO EM QUE BUSCA TODAS AS ENTRADAS NO MES DO REFERIDO PRODUTO
            //-> PROCESSO DE CORREÇÃO DE ESTOQUE 

            var db = new DBAcess();
            string Mysql = " select S.CODSAIDA, S.CODEMPRESA, S.CODDEPARTAMENTO, S.NUMEROPEDIDO, S.DATAENTREGA, ";
            Mysql = Mysql + " I.CODPRODUTO, P.NOME AS DESCRICAO, I.LOTE, I.VALIDADE, I.ENTREGUE ";
            Mysql = Mysql + " FROM saida S ";
            Mysql = Mysql + " inner JOIN saida_item as I ON S.CODSAIDA = I.CODSAIDA ";
            Mysql = Mysql + " inner join produtos as P on I.CODPRODUTO = P.CODPRODUTO ";

            Mysql = Mysql + " WHERE S.DATAENTREGA BETWEEN @DATAINICIAL AND @DATAFINAL ";
            Mysql = Mysql + " AND S.CODEMPRESA = @CODEMPRESA";
            Mysql = Mysql + " AND S.CODDEPARTAMENTO = @CODDEPARTAMENTO";
            Mysql = Mysql + " AND I.CODPRODUTO = @CODPRODUTO";
            Mysql = Mysql + " AND P.ATIVO = 1 ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATAINICIAL", Convert.ToDateTime(dtinicial));
            db.AddParameter("@DATAFINAL", Convert.ToDateTime(dtfinal));
            db.AddParameter("@CODPRODUTO", codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        #endregion

        #region Quantidade Atual

        public int AtualizaQtAtual()
        {

            float SaldoAnterior = 0;
            float qtEntrada = 0;
            float qtSaida = 0;
            float SaldoAtual = 0;

            var db = new DBAcess();
            string Mysql = " select QTANTERIOR, ENTRADA, SAIDA ";
            Mysql = Mysql + " from estoque ";

            string where = " WHERE CODEMPRESA = @CODEMPRESA";
            where = where + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO";
            where = where + " AND MES = @MES";
            where = where + " AND ANO = @ANO";
            where = where + " AND CODPRODUTO = @CODPRODUTO;";


            db.CommandText = Mysql + where;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@MES", Mes);
            db.AddParameter("@ANO", Ano);
            db.AddParameter("@CODPRODUTO", Codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    SaldoAnterior = dr.GetFloat(dr.GetOrdinal("QTANTERIOR"));
                    qtEntrada = dr.GetFloat(dr.GetOrdinal("ENTRADA"));
                    qtSaida = dr.GetFloat(dr.GetOrdinal("SAIDA"));

                    SaldoAtual = SaldoAnterior + qtEntrada - qtSaida;

                }

                UpdateSaldoAtual(SaldoAtual.ToString());
            }

            dr.Dispose();
            dr.Close();

            return 1;
        }

        public string VerQtAtual()
        {

            float SaldoAnterior = 0;
            float qtEntrada = 0;
            float qtSaida = 0;
            float SaldoAtual = 0;

            var db = new DBAcess();
            string Mysql = " select QTANTERIOR, ENTRADA, SAIDA ";
            Mysql = Mysql + " from estoque ";

            string where = " WHERE CODEMPRESA = @CODEMPRESA";
            where = where + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO";
            where = where + " AND MES = @MES";
            where = where + " AND ANO = @ANO";
            where = where + " AND CODPRODUTO = @CODPRODUTO;";


            db.CommandText = Mysql + where;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@MES", Mes);
            db.AddParameter("@ANO", Ano);
            db.AddParameter("@CODPRODUTO", Codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    SaldoAnterior = dr.GetFloat(dr.GetOrdinal("QTANTERIOR"));
                    qtEntrada = dr.GetFloat(dr.GetOrdinal("ENTRADA"));
                    qtSaida = dr.GetFloat(dr.GetOrdinal("SAIDA"));

                    SaldoAtual = SaldoAnterior + qtEntrada - qtSaida;

                }

                UpdateSaldoAtual(SaldoAtual.ToString());
            }

            dr.Dispose();
            dr.Close();

            return SaldoAtual.ToString();
        }

        #endregion


        #region Balanco

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader BuscaBalancoMes(int codempresa, int coddepartamento, string dtinicial, string dtfinal, int codproduto)
        {
            //-> PROCESSO EM QUE BUSCA TODAS OS BALANCOS NO MES DO REFERIDO PRODUTO
            //-> PROCESSO DE CORREÇÃO DE ESTOQUE 

            var db = new DBAcess();
            var Mysql = " SELECT B.CODPRODUTO, P.NOME AS NOMEPRODUTO, DATE_FORMAT(B.DATABALANCO, '%d/%m/%Y') AS DATABALANCO, B.QUANTIDADE ";
            Mysql = Mysql + " FROM Balanco B ";
            Mysql = Mysql + " INNER JOIN produtos P ON P.CODPRODUTO = B.CODPRODUTO ";

            Mysql = Mysql + " WHERE B.DATABALANCO BETWEEN @DATAINICIAL AND @DATAFINAL ";
            Mysql = Mysql + " AND B.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND B.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND B.CODPRODUTO = @CODPRODUTO;";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATAINICIAL", Convert.ToDateTime(dtinicial));
            db.AddParameter("@DATAFINAL", Convert.ToDateTime(dtfinal));
            db.AddParameter("@CODPRODUTO", codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        public bool TemBalanco(int codempresa, int coddepartamento, string dtinicial, string dtfinal, int Codproduto)
        {

            bool resposta = true;

            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Balanco ";
            Mysql = Mysql + " WHERE DATABALANCO BETWEEN @DATAINICIAL AND @DATAFINAL ";
            Mysql = Mysql + " AND CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND CODPRODUTO = @CODPRODUTO;";


            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATAINICIAL", Convert.ToDateTime(dtinicial));
            db.AddParameter("@DATAFINAL", Convert.ToDateTime(dtfinal));
            db.AddParameter("@CODPRODUTO", Codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    var teste = dr.GetString(dr.GetOrdinal("DATABALANCO"));


                }


            }
            else
            {
                resposta = false;
            }

            dr.Dispose();
            dr.Close();

            return resposta;
        }

        public string TemBalancoData(int codempresa, int coddepartamento, string data, string datafinal, int Codproduto)
        {

            string resposta = "";

            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Balanco ";
            Mysql = Mysql + " WHERE DATABALANCO >= @DATABALANCO ";
            Mysql = Mysql + " AND DATABALANCO <= @DATAFINAL ";
            Mysql = Mysql + " AND CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND CODPRODUTO = @CODPRODUTO;";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATABALANCO", Convert.ToDateTime(data));
            db.AddParameter("@DATAFINAL", Convert.ToDateTime(datafinal));

            db.AddParameter("@CODPRODUTO", Codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    resposta = dr.GetString(dr.GetOrdinal("DATABALANCO")).ToString();
                }

            }
            else
            {
                resposta = "";
            }

            dr.Dispose();
            dr.Close();

            return resposta;
        }

        public string BuscaBalanco(int codempresa, int coddepartamento, string data, int Codproduto)
        {

            string resposta = "";
            data = Convert.ToDateTime(data).ToString();

            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM Balanco ";
            Mysql = Mysql + " WHERE DATABALANCO = @DATABALANCO ";
            Mysql = Mysql + " AND CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND CODPRODUTO = @CODPRODUTO;";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATABALANCO", Convert.ToDateTime(data));
            db.AddParameter("@CODPRODUTO", Codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    resposta = dr.GetString(dr.GetOrdinal("QUANTIDADE")).ToString();
                }

            }
            else
            {
                resposta = "";
            }

            dr.Dispose();
            dr.Close();

            return resposta;
        }

        //AJUSTE
        public string BuscaAjuste(int codempresa, int coddepartamento, string data, int Codproduto)
        {

            string resposta = "";

            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM ajuste_estoque ";
            Mysql = Mysql + " WHERE DATAAJUSTE = @DATAAJUSTE ";
            Mysql = Mysql + " AND CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND AUTORIZADO = @AUTORIZADO ";
            Mysql = Mysql + " AND CODPRODUTO = @CODPRODUTO;";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@DATAAJUSTE", Convert.ToDateTime(data));
            db.AddParameter("@AUTORIZADO", "S");
            db.AddParameter("@CODPRODUTO", Codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    resposta = dr.GetString(dr.GetOrdinal("QUANTIDADE")).ToString();
                }

            }
            else
            {
                resposta = "";
            }

            dr.Dispose();
            dr.Close();

            return resposta;
        }


        #endregion


        public float BuscaEntrada()
        {
            float qtEntradaAntes = 0;

            var db = new DBAcess();
            string Mysql = " select ENTRADA ";
            Mysql = Mysql + " from estoque ";

            string where = " WHERE CODEMPRESA = @CODEMPRESA";
            where = where + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO";
            where = where + " AND MES = @MES";
            where = where + " AND ANO = @ANO";
            where = where + " AND CODPRODUTO = @CODPRODUTO;";


            db.CommandText = Mysql + where;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@MES", Mes);
            db.AddParameter("@ANO", Ano);
            db.AddParameter("@CODPRODUTO", Codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    qtEntradaAntes = dr.GetFloat(dr.GetOrdinal("ENTRADA"));
                }

            }

            dr.Dispose();
            dr.Close();

            return qtEntradaAntes;
        }

        public float BuscaSaida()
        {
            float qtSaidaAntes = 0;

            var db = new DBAcess();
            string Mysql = " select SAIDA ";
            Mysql = Mysql + " from estoque ";

            string where = " WHERE CODEMPRESA = @CODEMPRESA";
            where = where + " AND CODDEPARTAMENTO = @CODDEPARTAMENTO";
            where = where + " AND MES = @MES";
            where = where + " AND ANO = @ANO";
            where = where + " AND CODPRODUTO = @CODPRODUTO;";


            db.CommandText = Mysql + where;

            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@MES", Mes);
            db.AddParameter("@ANO", Ano);
            db.AddParameter("@CODPRODUTO", Codproduto);

            var dr = (MySqlDataReader)db.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    qtSaidaAntes = dr.GetFloat(dr.GetOrdinal("SAIDA"));
                }

            }

            dr.Dispose();
            dr.Close();

            return qtSaidaAntes;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader BuscaEstoque(int codempresa, int coddepartamento, string mes, string ano, int codproduto)
        {

            var db = new DBAcess();
            string Mysql = " SELECT E.CODEMPRESA, EP.NOME AS NOMEEMPRESA, E.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, E.MES, E.ANO, ";
            Mysql = Mysql + " E.CODPRODUTO, P.NOME AS NOMEPRODUTO, ";
            Mysql = Mysql + " E.QTANTERIOR, E.ENTRADA, E.SAIDA, E.QTATUAL ";
            Mysql = Mysql + " FROM ESTOQUE E ";

            Mysql = Mysql + " INNER JOIN empresa AS EP ON EP.CODEMPRESA = E.CODEMPRESA ";
            Mysql = Mysql + " INNER JOIN departamento AS D ON D.CODDEPARTAMENTO = E.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN produtos AS P ON P.CODPRODUTO = E.CODPRODUTO ";

            Mysql = Mysql + " WHERE E.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND E.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND E.MES = @MES ";
            Mysql = Mysql + " AND E.ANO = @ANO ";

            if (codproduto != 0)
            { Mysql = Mysql + " AND E.CODPRODUTO = @CODPRODUTO "; }

            Mysql = Mysql + " ORDER BY E.CODPRODUTO";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@MES", mes);
            db.AddParameter("@ANO", ano);
            db.AddParameter("@CODPRODUTO", codproduto);


            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader BuscaEstoque(int codempresa, int coddepartamento, string mes, string ano, int codproduto, int codgrupo)
        {

            var db = new DBAcess();
            string Mysql = " SELECT E.CODEMPRESA, EP.NOME AS NOMEEMPRESA, E.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, E.MES, E.ANO, ";
            Mysql = Mysql + " E.CODPRODUTO, P.NOME AS NOMEPRODUTO, P.SAIDAPADRAO, ";
            Mysql = Mysql + " G.DESCRICAO AS NOMEGRUPO, ";
            Mysql = Mysql + " E.QTANTERIOR, E.ENTRADA, E.SAIDA, E.QTATUAL ";
            Mysql = Mysql + " FROM ESTOQUE E ";

            Mysql = Mysql + " INNER JOIN empresa AS EP ON EP.CODEMPRESA = E.CODEMPRESA ";
            Mysql = Mysql + " INNER JOIN departamento AS D ON D.CODDEPARTAMENTO = E.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN produtos P ON P.CODPRODUTO = E.CODPRODUTO AND P.CODDEPARTAMENTO = E.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN grupo AS G ON G.CODGRUPO = P.CODGRUPO ";

            Mysql = Mysql + " WHERE E.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND E.CODDEPARTAMENTO = @CODDEPARTAMENTO ";

            if (codgrupo != 0) { Mysql = Mysql + " AND P.CODGRUPO = @CODGRUPO "; }

            Mysql = Mysql + " AND E.MES = @MES ";
            Mysql = Mysql + " AND E.ANO = @ANO ";

            if (codproduto != 0) { Mysql = Mysql + " AND E.CODPRODUTO = @CODPRODUTO "; }

            Mysql = Mysql + " ORDER BY P.NOME";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@CODGRUPO", codgrupo);
            db.AddParameter("@MES", mes);
            db.AddParameter("@ANO", ano);
            db.AddParameter("@CODPRODUTO", codproduto);


            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader BuscaEstoqueNome(int codempresa, int coddepartamento, string mes, string ano, string valor, int codgrupo)
        {

            var db = new DBAcess();
            string Mysql = " SELECT E.CODEMPRESA, EP.NOME AS NOMEEMPRESA, E.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, E.MES, E.ANO, ";
            Mysql = Mysql + " E.CODPRODUTO, P.NOME AS NOMEPRODUTO, P.SAIDAPADRAO, ";
            Mysql = Mysql + " E.QTANTERIOR, E.ENTRADA, E.SAIDA, E.QTATUAL ";
            Mysql = Mysql + " FROM ESTOQUE E ";

            Mysql = Mysql + " INNER JOIN empresa AS EP ON EP.CODEMPRESA = E.CODEMPRESA ";
            Mysql = Mysql + " INNER JOIN departamento AS D ON D.CODDEPARTAMENTO = E.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN produtos AS P ON P.CODPRODUTO = E.CODPRODUTO AND P.CODDEPARTAMENTO = E.CODDEPARTAMENTO ";

            Mysql = Mysql + " WHERE E.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND E.CODDEPARTAMENTO = @CODDEPARTAMENTO ";

            if (valor != "")
            {
                Mysql = Mysql + " AND p.NOME LIKE @valor ";
                valor = '%' + valor + "%";
            }

            if (codgrupo != 0) { Mysql = Mysql + " AND P.CODGRUPO = @CODGRUPO "; }

            Mysql = Mysql + " AND E.MES = @MES ";
            Mysql = Mysql + " AND E.ANO = @ANO ";
            Mysql = Mysql + " ORDER BY P.NOME";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@CODGRUPO", codgrupo);
            db.AddParameter("@MES", mes);
            db.AddParameter("@ANO", ano);
            db.AddParameter("@valor", valor);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader BuscaProdutoEstoque(int codempresa, int coddepartamento, string mes, string ano, int codproduto)
        {

            var db = new DBAcess();
            string Mysql = " SELECT E.CODEMPRESA, EP.NOME AS NOMEEMPRESA, E.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, E.MES, E.ANO, ";
            Mysql = Mysql + " E.CODPRODUTO, P.NOME AS NOMEPRODUTO, ";
            Mysql = Mysql + " E.QTANTERIOR, E.ENTRADA, E.SAIDA, E.QTATUAL ";
            Mysql = Mysql + " FROM ESTOQUE E ";

            Mysql = Mysql + " INNER JOIN empresa AS EP ON EP.CODEMPRESA = E.CODEMPRESA ";
            Mysql = Mysql + " INNER JOIN departamento AS D ON D.CODDEPARTAMENTO = E.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN produtos AS P ON P.CODPRODUTO = E.CODPRODUTO ";

            Mysql = Mysql + " WHERE E.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND E.CODDEPARTAMENTO = @CODDEPARTAMENTO";
            Mysql = Mysql + " AND E.MES = @MES";
            Mysql = Mysql + " AND E.ANO = @ANO";

            if (codproduto != 0)
            { Mysql = Mysql + " AND E.CODPRODUTO = @CODPRODUTO;"; }

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@MES", mes);
            db.AddParameter("@ANO", ano);
            db.AddParameter("@CODPRODUTO", codproduto);


            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        public int InsertAccess(int codempresa, int coddepartamento, string nomedepartamento,
           string mes, string ano, int codproduto, string nomeproduto,
           string qtanterior, string entrada, string saida, string qtatual)
        {
            var db = new DBAcessOleDB();

            var Mysql = " INSERT INTO Estoque(";
            Mysql = Mysql + " CODEMPRESA, CODDEPARTAMENTO, NOMEDEPARTAMENTO, MES, ANO, CODPRODUTO, NOMEPRODUTO, ";
            Mysql = Mysql + " QTANTERIOR, ENTRADA, SAIDA, QTATUAL ";


            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODEMPRESA, @CODDEPARTAMENTO, @NOMEDEPARTAMENTO, @MES, @ANO, @CODPRODUTO, @NOMEPRODUTO, ";
            Mysql = Mysql + " @QTANTERIOR, @ENTRADA, @SAIDA, @QTATUAL ";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);

            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@NOMEDEPARTAMENTO", nomedepartamento);

            db.AddParameter("@MES", mes);
            db.AddParameter("@ANO", ano);

            db.AddParameter("@CODPRODUTO", codproduto);
            db.AddParameter("@NOMEPRODUTO", nomeproduto);

            db.AddParameter("@QTANTERIOR", qtanterior);
            db.AddParameter("@ENTRADA", entrada);
            db.AddParameter("@SAIDA", saida);
            db.AddParameter("@QTATUAL", qtatual);
            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }

        public int InsertAccess(int codempresa, int coddepartamento, string nomedepartamento, string nomegrupo,
           string mes, string ano, int codproduto, string nomeproduto,
           string qtanterior, string entrada, string saida, string qtatual, string saidapadrao, string estimativa)
        {
            var db = new DBAcessOleDB();

            var Mysql = " INSERT INTO Estoque(";
            Mysql = Mysql + " CODEMPRESA, CODDEPARTAMENTO, NOMEDEPARTAMENTO, NOMEGRUPO, MES, ANO, CODPRODUTO, NOMEPRODUTO, ";
            Mysql = Mysql + " QTANTERIOR, ENTRADA, SAIDA, QTATUAL, SAIDAPADRAO, ESTIMATIVAMES ";


            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODEMPRESA, @CODDEPARTAMENTO, @NOMEDEPARTAMENTO, @NOMEGRUPO, @MES, @ANO, @CODPRODUTO, @NOMEPRODUTO, ";
            Mysql = Mysql + " @QTANTERIOR, @ENTRADA, @SAIDA, @QTATUAL, @SAIDAPADRAO, @ESTIMATIVAMES ";

            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);

            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@NOMEDEPARTAMENTO", nomedepartamento);
            db.AddParameter("@NOMEGRUPO", nomegrupo);

            db.AddParameter("@MES", mes);
            db.AddParameter("@ANO", ano);

            db.AddParameter("@CODPRODUTO", codproduto);
            db.AddParameter("@NOMEPRODUTO", nomeproduto);

            db.AddParameter("@QTANTERIOR", qtanterior);
            db.AddParameter("@ENTRADA", entrada);
            db.AddParameter("@SAIDA", saida);
            db.AddParameter("@QTATUAL", qtatual);
            db.AddParameter("@SAIDAPADRAO", saidapadrao);
            db.AddParameter("@ESTIMATIVAMES", estimativa);
            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }

        public int InsertAccessExtrato(int codempresa, string nomeempresa, int coddepartamento, string nomedepartamento, int codgrupo, string nomegrupo,
        string dtinicial, string dtfinal, int codproduto, string nomeproduto, string datamovimento, int codmovimento, string numeromovimento, string tipomovimento, string quantidade, string saldo)
        {
            var db = new DBAcessOleDB();

            var Mysql = " INSERT INTO Temp(";
            Mysql = Mysql + " CODEMPRESA, NOMEEMPRESA, CODDEPARTAMENTO, NOMEDEPARTAMENTO, CODGRUPO, NOMEGRUPO, DTINICIAL, DTFINAL, CODPRODUTO, NOMEPRODUTO, ";
            Mysql = Mysql + " DATAMOVIMENTO, CODMOVIMENTO, NUMEROMOVIMENTO, TIPOMOVIMENTO, QUANTIDADE ";

            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODEMPRESA, @NOMEEMPRESA, @CODDEPARTAMENTO, @NOMEDEPARTAMENTO, @CODGRUPO, @NOMEGRUPO, @DTINICIAL, @DTFINAL, @CODPRODUTO, @NOMEPRODUTO, ";
            Mysql = Mysql + " @DATAMOVIMENTO, @CODMOVIMENTO, @NUMEROMOVIMENTO, @TIPOMOVIMENTO, @QUANTIDADE ";

            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@NOMEEMPRESA", nomeempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@NOMEDEPARTAMENTO", nomedepartamento);
            db.AddParameter("@CODGRUPO", codgrupo);
            db.AddParameter("@NOMEGRUPO", nomegrupo);
            db.AddParameter("@DTINICIAL", dtinicial);
            db.AddParameter("@DTFINAL", dtfinal);
            db.AddParameter("@CODPRODUTO", codproduto);
            db.AddParameter("@NOMEPRODUTO", nomeproduto);
            db.AddParameter("@DATAMOVIMENTO", datamovimento); //Convert.ToDateTime(datamovimento))
            db.AddParameter("@CODMOVIMENTO", codmovimento);
            db.AddParameter("@NUMEROMOVIMENTO", numeromovimento);
            db.AddParameter("@TIPOMOVIMENTO", tipomovimento);
            db.AddParameter("@QUANTIDADE", quantidade);
            db.AddParameter("@SALDO", saldo);

            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }


        public int InsertAccessSaldo(string nomeempresa, string nomedepartamento, string nomegrupo,
           string dataestoque, 
           int codproduto, string nomeproduto, string entrada, string saida, string atual, string padrao, string estimativa)
        {
            var db = new DBAcessOleDB();

            var Mysql = " INSERT INTO Saldo(";
            Mysql = Mysql + " NOMEEMPRESA, NOMEDEPARTAMENTO, NOMEGRUPO, DATAESTOQUE, ";
            Mysql = Mysql + " CODPRODUTO, NOMEPRODUTO, ENTRADA, SAIDA, ATUAL, PADRAO, ESTIMATIVA ";

            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @NOMEEMPRESA, @NOMEDEPARTAMENTO, @NOMEGRUPO, @DATAESTOQUE, ";
            Mysql = Mysql + " @CODPRODUTO, @NOMEPRODUTO, @ENTRADA, @SAIDA, @ATUAL, @PADRAO, @ESTIMATIVA ";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@NOMEEMPRESA", nomeempresa);
            db.AddParameter("@NOMEDEPARTAMENTO", nomedepartamento);
            db.AddParameter("@NOMEGRUPO", nomegrupo);
            db.AddParameter("@DATAESTOQUE", dataestoque);//Convert.ToDateTime(datamovimento))
            db.AddParameter("@CODPRODUTO", codproduto);
            db.AddParameter("@NOMEPRODUTO", nomeproduto);
            db.AddParameter("@ENTRADA", entrada);
            db.AddParameter("@SAIDA", saida);
            db.AddParameter("@ATUAL", atual);
            db.AddParameter("@PADRAO", padrao);
            db.AddParameter("@ESTIMATIVA", estimativa);

            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static OleDbDataReader BuscaExtratoAccess()
        {

            var db = new DBAcessOleDB();
            string Mysql = " SELECT E.CODPRODUTO, E.NOMEPRODUTO, E.DATAMOVIMENTO, E.CODMOVIMENTO, E.NUMEROMOVIMENTO, E.TIPOMOVIMENTO, E.QUANTIDADE ";
            Mysql = Mysql + " FROM TEMP E ";
            Mysql = Mysql + " ORDER BY E.DATAMOVIMENTO, E.NOMEPRODUTO, E.CODMOVIMENTO ";

            db.CommandText = Mysql;
            var dr = (OleDbDataReader)db.ExecuteReader();
            return dr;
        }


        public int InsertAccessExtrato1(int codempresa, string nomeempresa, int coddepartamento, string nomedepartamento, int codgrupo, string nomegrupo,
        string dtinicial, string dtfinal, int codproduto, string nomeproduto, string datamovimento, int codmovimento, string numeromovimento, string tipomovimento, string quantidade, string saldo)
        {
            var db = new DBAcessOleDB();

            var Mysql = " INSERT INTO Extrato(";
            Mysql = Mysql + " CODEMPRESA, NOMEEMPRESA, CODDEPARTAMENTO, NOMEDEPARTAMENTO, CODGRUPO, NOMEGRUPO, DTINICIAL, DTFINAL, CODPRODUTO, NOMEPRODUTO, ";
            Mysql = Mysql + " DATAMOVIMENTO, CODMOVIMENTO, NUMEROMOVIMENTO, TIPOMOVIMENTO, QUANTIDADE, SALDO ";

            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODEMPRESA, @NOMEEMPRESA, @CODDEPARTAMENTO, @NOMEDEPARTAMENTO, @CODGRUPO, @NOMEGRUPO, @DTINICIAL, @DTFINAL, @CODPRODUTO, @NOMEPRODUTO, ";
            Mysql = Mysql + " @DATAMOVIMENTO, @CODMOVIMENTO, @NUMEROMOVIMENTO, @TIPOMOVIMENTO, @QUANTIDADE, @SALDO ";

            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@NOMEEMPRESA", nomeempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@NOMEDEPARTAMENTO", nomedepartamento);
            db.AddParameter("@CODGRUPO", codgrupo);
            db.AddParameter("@NOMEGRUPO", nomegrupo);
            db.AddParameter("@DTINICIAL", dtinicial);
            db.AddParameter("@DTFINAL", dtfinal);
            db.AddParameter("@CODPRODUTO", codproduto);
            db.AddParameter("@NOMEPRODUTO", nomeproduto);
            db.AddParameter("@DATAMOVIMENTO", datamovimento);
            db.AddParameter("@CODMOVIMENTO", codmovimento);
            db.AddParameter("@NUMEROMOVIMENTO", numeromovimento);
            db.AddParameter("@TIPOMOVIMENTO", tipomovimento);
            db.AddParameter("@QUANTIDADE", quantidade);
            db.AddParameter("@SALDO", saldo);

            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }



        public bool DeleteAccess()
        {
            var db = new DBAcessOleDB();
            var Mysql = " DELETE FROM Estoque ";

            db.CommandText = Mysql;

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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Estoque_Periodo(int codempresa, int coddepartamento, int codgrupo, int codproduto, string nome, string mes, string ano, bool negativo)
        {

            var db = new DBAcess();
            string Mysql = " SELECT E.CODEMPRESA, EM.NOME AS NOMEEMPRESA, E.CODDEPARTAMENTO, D.NOME AS NOMEDEPARTAMENTO, E.MES, E.ANO, ";
            Mysql = Mysql + " P.CODGRUPO, G.DESCRICAO AS NOMEGRUPO, E.CODPRODUTO, P.NOME AS NOMEPRODUTO, E.QTANTERIOR, E.ENTRADA, E.SAIDA, E.QTATUAL ";

            Mysql = Mysql + " FROM estoque E ";

            Mysql = Mysql + " INNER JOIN empresa EM ON EM.CODEMPRESA = E.CODEMPRESA ";
            Mysql = Mysql + " INNER JOIN departamento D ON D.CODDEPARTAMENTO = E.CODDEPARTAMENTO ";
            Mysql = Mysql + " INNER JOIN produtos P ON P.CODPRODUTO = E.CODPRODUTO ";
            Mysql = Mysql + " INNER JOIN grupo G ON G.CODGRUPO = P.CODGRUPO ";

            Mysql = Mysql + " WHERE E.CODEMPRESA = @CODEMPRESA ";
            Mysql = Mysql + " AND E.CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            if (codgrupo != 0) { Mysql = Mysql + " AND P.CODGRUPO = @CODGRUPO "; }
            if (codproduto != 0) { Mysql = Mysql + " AND  E.CODPRODUTO = @CODPRODUTO "; }
            if (nome != "") { Mysql = Mysql + " AND p.NOME LIKE @NOME "; nome = '%' + nome + "%"; }

            Mysql = Mysql + " AND E.MES = @MES ";
            Mysql = Mysql + " AND E.ANO = @ANO ";

            if (negativo == true) { Mysql = Mysql + " AND E.QTATUAL < 1 "; }

            Mysql = Mysql + " ORDER BY P.NOME";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@CODGRUPO", codgrupo);
            db.AddParameter("@CODPRODUTO", codproduto);
            db.AddParameter("@NOME", nome);
            db.AddParameter("@MES", mes);
            db.AddParameter("@ANO", ano);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        public int InsertAccess_Estoque_Periodo(int codempresa, string nomeempresa, int coddepartamento, string nomedepartamento,
        string mes, string ano, int codgrupo, string nomegrupo,
        int codproduto, string nomeproduto, string qtanterior, string entrada, string saida, string qtatual)
        {
            var db = new DBAcessOleDB();

            var Mysql = " INSERT INTO Estoque(";
            Mysql = Mysql + " CODEMPRESA, NOMEEMPRESA, CODDEPARTAMENTO, NOMEDEPARTAMENTO, MES, ANO, CODGRUPO, NOMEGRUPO, ";
            Mysql = Mysql + " CODPRODUTO, NOMEPRODUTO, QTANTERIOR, ENTRADA, SAIDA, QTATUAL ";

            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES(";
            Mysql = Mysql + " @CODEMPRESA, @NOMEEMPRESA, @CODDEPARTAMENTO, @NOMEDEPARTAMENTO, @MES, @ANO, @CODGRUPO, @NOMEGRUPO, ";
            Mysql = Mysql + " @CODPRODUTO, @NOMEPRODUTO, @QTANTERIOR, @ENTRADA, @SAIDA, @QTATUAL ";
            Mysql = Mysql + "); ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@NOMEEMPRESA", nomeempresa);
            db.AddParameter("@CODDEPARTAMENTO", coddepartamento);
            db.AddParameter("@NOMEDEPARTAMENTO", nomedepartamento);

            db.AddParameter("@MES", mes);
            db.AddParameter("@ANO", ano);

            db.AddParameter("@CODGRUPO", codgrupo);
            db.AddParameter("@NOMEGRUPO", nomegrupo);

            db.AddParameter("@CODPRODUTO", codproduto);
            db.AddParameter("@NOMEPRODUTO", nomeproduto);
            db.AddParameter("@QTANTERIOR", qtanterior);
            db.AddParameter("@ENTRADA", entrada);
            db.AddParameter("@SAIDA", saida);
            db.AddParameter("@QTATUAL", qtatual);
            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }


    }
}