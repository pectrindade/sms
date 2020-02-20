using System;
using System.ComponentModel;
using System.Data;
using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;


namespace Atencao_Assistida.Classes.Mysql
{

    
    public class EntregaMercadoria
    {

        private int Codentregamercadoria { get; set; }
        private string Numeroprotocolo { get; set; }
        private string Codempresa { get; set; }
        private string Codpaciente { get; set; }
        
        private string Dataentrega { get; set; }
        private string Observacao { get; set; }
        private string Respinclusao { get; set; }
        private string Datainclusao { get; set; }
        private string Respalteracao { get; set; }
        private string Dataalteracao { get; set; }
        private string Excluido { get; set; }


        private string Nome { get; set; }
        private string Datanascimento { get; set; }
        private string Sexo { get; set; }
        private string Numerosus { get; set; }
        private string Nomemae { get; set; }
        private string Endereco { get; set; }
        private string Bairro { get; set; }
        private string Telefone { get; set; }



        public EntregaMercadoria()
        {

        }

        public EntregaMercadoria(int codentregamercadoria, string numeroprotocolo, string codempresa, string codpaciente, string dataentrega,
        string observacao, string respinclusao, string datainclusao, string respalteracao, string dataalteracao, string excluido)
        {
            Codentregamercadoria = codentregamercadoria;
            Numeroprotocolo = numeroprotocolo;
            Codempresa = codempresa;
            Codpaciente = codpaciente;

            Dataentrega = dataentrega;
            Observacao = observacao;
            Respinclusao = respinclusao;
            Datainclusao = datainclusao;
            Respalteracao = respalteracao;
            Dataalteracao = dataalteracao;
            Excluido = excluido;

        }

        public EntregaMercadoria(int codentregamercadoria, string numeroprotocolo, string dataentrega, string observacao, string codpaciente, string nome, string datanascimento,
                         string sexo, string numerosus, string nomemae, string endereco, string bairro, string telefone)
        {
            Codentregamercadoria = codentregamercadoria;
            Numeroprotocolo = numeroprotocolo;
           
            Dataentrega = dataentrega;
            Observacao = observacao;
            Codpaciente = codpaciente;
            Nome = nome;
            Datanascimento = datanascimento;
            Sexo = sexo;
            Numerosus = numerosus;
            Nomemae = nomemae;
            Endereco = endereco;
            Bairro = bairro;
            Telefone = telefone;


        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO EntregaMercadoria (";
            Mysql = Mysql + " NUMEROPROTOCOLO, CODEMPRESA, CODPACIENTE, DATAENTREGA, ";
            Mysql = Mysql + " OBSERVACAO, RESPINCLUSAO, DATAINCLUSAO, EXCLUIDO ";

            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES (";
            Mysql = Mysql + " @NUMEROPROTOCOLO, @CODEMPRESA, @CODPACIENTE,  @DATAENTREGA, ";
            Mysql = Mysql + " @OBSERVACAO, @RESPINCLUSAO, @DATAINCLUSAO, @EXCLUIDO ";
            Mysql = Mysql + ");";

            Mysql = Mysql + " SELECT MAX(CODENTREGAMERCADORIA) As CODENTREGAMERCADORIA FROM EntregaMercadoria;  ";

            db.CommandText = Mysql;

            db.AddParameter("@NUMEROPROTOCOLO", Numeroprotocolo);
            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODPACIENTE", Codpaciente);
           
            db.AddParameter("@DATAENTREGA", Convert.ToDateTime(Dataentrega));
            db.AddParameter("@OBSERVACAO", Observacao);
            db.AddParameter("@RESPINCLUSAO", Respinclusao);
            db.AddParameter("@DATAINCLUSAO", Convert.ToDateTime(Datainclusao));
            db.AddParameter("@EXCLUIDO", Excluido);


            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }

        public int Insert_Item(int codentregamercadoria, string codproduto, string codespecialidade, string quantidade)
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO EntregaMercadoria_item (";
            Mysql = Mysql + " CODENTREGAMERCADORIA, CODPRODUTO, CODESPECIALIDADE, QUANTIDADE ";

            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES (";
            Mysql = Mysql + " @CODENTREGAMERCADORIA, @CODPRODUTO, @CODESPECIALIDADE, @QUANTIDADE ";

            Mysql = Mysql + ");";

            db.CommandText = Mysql;

            db.AddParameter("@CODENTREGAMERCADORIA", codentregamercadoria);
            db.AddParameter("@CODPRODUTO", codproduto);
            db.AddParameter("@CODESPECIALIDADE", codespecialidade);
            db.AddParameter("@QUANTIDADE", quantidade);

            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }

        public bool Delete_Item(int codigo)
        {
            var db = new DBAcess();
            var Mysql = " DELETE FROM EntregaMercadoria_item ";
            Mysql = Mysql + " WHERE CODENTREGAMERCADORIA = @CODENTREGAMERCADORIA;";

            db.CommandText = Mysql;
            db.AddParameter("@CODENTREGAMERCADORIA", codigo);

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

        public bool Update()
        {
            var db = new DBAcess();
            var Mysql = " UPDATE EntregaMercadoria SET ";

            Mysql = Mysql + " NUMEROPROTOCOLO = @NUMEROPROTOCOLO, CODEMPRESA = @CODEMPRESA, CODPACIENTE = @CODPACIENTE,  ";
            Mysql = Mysql + " DATAENTREGA = @DATAENTREGA, OBSERVACAO = @OBSERVACAO, ";
            Mysql = Mysql + " RESPALTERACAO = @RESPALTERACAO, DATAALTERACAO = @DATAALTERACAO, EXCLUIDO = @EXCLUIDO ";

            Mysql = Mysql + " WHERE CODENTREGAMERCADORIA = @CODENTREGAMERCADORIA;";

            db.CommandText = Mysql;

            db.AddParameter("@CODENTREGAMERCADORIA", Codentregamercadoria);
            db.AddParameter("@NUMEROPROTOCOLO", Numeroprotocolo);
            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODPACIENTE", Codpaciente);
          
            db.AddParameter("@DATAENTREGA", Convert.ToDateTime(Dataentrega));
            db.AddParameter("@OBSERVACAO", Observacao);
            db.AddParameter("@RESPALTERACAO", Respalteracao);
            db.AddParameter("@DATAALTERACAO", Convert.ToDateTime(Dataalteracao));
            db.AddParameter("@EXCLUIDO", Excluido);


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
            var Mysql = " INSERT INTO EntregaMercadoria (";
            Mysql = Mysql + " CODENTREGAMERCADORIA, NUMEROPROTOCOLO, DATAENTREGA, OBSERVACAO, ";
            Mysql = Mysql + " CODPACIENTE, NOME, DATANASCIMENTO, SEXO, NUMEROSUS, NOMEMAE, ENDERECO, BAIRRO, TELEFONE ";

            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES (";
            Mysql = Mysql + " @CODENTREGAMERCADORIA, @NUMEROPROTOCOLO, @DATAENTREGA, @OBSERVACAO, ";
            Mysql = Mysql + " @CODPACIENTE, @NOME, @DATANASCIMENTO, @SEXO, @NUMEROSUS, @NOMEMAE, @ENDERECO, @BAIRRO, @TELEFONE ";

            Mysql = Mysql + ");";

            db.CommandText = Mysql;

            db.AddParameter("@CODENTREGAMERCADORIA", Codentregamercadoria);
            db.AddParameter("@NUMEROPROTOCOLO ", Numeroprotocolo);
           
            db.AddParameter("@DATAENTREGA ", Dataentrega);
            db.AddParameter("@OBSERVACAO", Observacao);
            db.AddParameter("@CODPACIENTE ", Codpaciente);
            db.AddParameter("@NOME ", Nome);
            db.AddParameter("@DATANASCIMENTO ", Datanascimento);
            db.AddParameter("@SEXO ", Sexo);
            db.AddParameter("@NUMEROSUS ", Numerosus);
            db.AddParameter("@NOMEMAE ", Nomemae);
            db.AddParameter("@ENDERECO ", Endereco);
            db.AddParameter("@BAIRRO ", Bairro);
            db.AddParameter("@TELEFONE", Telefone);



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
            const string delete = " DELETE FROM EntregaMercadoria ";

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

        public int InsertAccess_Item(int codentregamercadoria, string codproduto, string produto, string especialidade, string unidade, string quantidade)
        {
            var db = new DBAcessOleDB();
            var Mysql = " INSERT INTO EntregaMercadoria_item (";
            Mysql = Mysql + " CODENTREGAMERCADORIA, CODPRODUTO, PRODUTO, ESPECIALIDADE, UNIDADE, QUANTIDADE ";

            Mysql = Mysql + ") ";
            Mysql = Mysql + " VALUES (";
            Mysql = Mysql + " @CODENTREGAMERCADORIA, @CODPRODUTO, @PRODUTO, @ESPECIALIDADE, @UNIDADE, @QUANTIDADE ";

            Mysql = Mysql + ");";

            db.CommandText = Mysql;

            db.AddParameter("@CODENTREGAMERCADORIA", codentregamercadoria);
            db.AddParameter("@CODPRODUTO ", codproduto);
            db.AddParameter("@PRODUTO ", produto);
            db.AddParameter("@ESPECIALIDADE ", especialidade);
            db.AddParameter("@UNIDADE ", unidade);
            db.AddParameter("@QUANTIDADE ", quantidade);

            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }

        public bool DeleteAccess_Item()
        {
            var db = new DBAcessOleDB();
            const string delete = " DELETE FROM EntregaMercadoria_item ";

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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader Select(string por, string valor)
        {
            var db = new DBAcess();

            var Mysql = " SELECT pt.CODENTREGAMERCADORIA, pt.NUMEROPROTOCOLO, pt.CODPACIENTE, pa.NOME, pa.NUMEROSUS, DATE_FORMAT(pt.DATAENTREGA,'%d/%m/%Y') AS DATAENTREGA, pt.OBSERVACAO ";
            Mysql = Mysql + " FROM EntregaMercadoria AS pt ";
            Mysql = Mysql + " INNER JOIN paciente AS pa ON pa.CODPACIENTE = pt.CODPACIENTE ";

            Mysql = Mysql + " ";


            if (valor != "")
            {

                if (por == "NOME")
                {
                    Mysql = Mysql + "WHERE pa.NOME LIKE @valor";
                    valor = '%' + valor + "%";
                }
                else if (por == "SUS")
                {
                    Mysql = Mysql + "WHERE pa.NUMEROSUS LIKE @valor";
                    valor = '%' + valor + "%";
                }
                else if (por == "CPF")
                {

                }
                else if (por == "CODIGO")
                {
                    Mysql = Mysql + "WHERE  pt.CODENTREGAMERCADORIA = @valor";

                }
                else if (por == "NUMERO")
                {
                    Mysql = Mysql + "WHERE  pt.NUMEROPROTOCOLO = @valor";

                }



            }

            Mysql = Mysql + " ORDER BY pa.NOME ASC; ";
            db.CommandText = Mysql;
            db.AddParameter("@valor", valor);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectProdutos(string valor)
        {
            var db = new DBAcess();

            var Mysql = " SELECT pt.CODENTREGAMERCADORIA, pt.NUMEROPROTOCOLO, pt.CODPACIENTE, pa.NOME AS NOMEPACIENTE, pa.NUMEROSUS, ";
            Mysql = Mysql + " pti.CODPRODUTO, pr.DESCRICAO AS PRODUTO, U.DESCRICAO AS NOMEUNIDADE, E.CODESPECIALIDADE, E.DESCRICAO AS 'ESPECIALIDADE', pti.QUANTIDADE, ";
            Mysql = Mysql + " DATE_FORMAT(pt.DATAENTREGA,'%d/%m/%Y') AS DATAENTREGA, pt.OBSERVACAO ";
            Mysql = Mysql + " FROM EntregaMercadoria AS pt ";
            Mysql = Mysql + " INNER JOIN paciente AS pa ON pa.CODPACIENTE = pt.CODPACIENTE ";
            Mysql = Mysql + " INNER JOIN EntregaMercadoria_item AS pti ON pti.CODEntregaMercadoria = pt.CODEntregaMercadoria ";
            Mysql = Mysql + " INNER JOIN produtos AS pr ON pr.CODPRODUTO = pti.CODPRODUTO ";
            Mysql = Mysql + " INNER JOIN unidademedida AS U ON U.CODUNIDADEMEDIDA = pr.UNIDADE ";
            Mysql = Mysql + "  INNER JOIN especialidade AS E ON E.CODESPECIALIDADE = pti.CODESPECIALIDADE  ";


            Mysql = Mysql + "WHERE  pt.CODENTREGAMERCADORIA = @valor";

            Mysql = Mysql + " ORDER BY pa.NOME ASC; ";
            db.CommandText = Mysql;
            db.AddParameter("@valor", valor);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader BuscaCodigo()
        {
            var db = new DBAcess();

            var Mysql = " SELECT MAX(NUMEROPROTOCOLO) AS ULTIMO ";
            Mysql = Mysql + " FROM EntregaMercadoria ";
            Mysql = Mysql + " ";

            db.CommandText = Mysql;

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectRel(string por, string valor)
        {
            var db = new DBAcess();

            var Mysql = " SELECT P.CODENTREGAMERCADORIA, P.NUMEROPROTOCOLO,  DATE_FORMAT(P.DATAENTREGA,'%d/%m/%Y') AS DATAENTREGA, P.OBSERVACAO, ";
            Mysql = Mysql + " P.CODPACIENTE, PC.NOME, DATE_FORMAT(PC.DATANASCIMENTO,'%d/%m/%Y') AS DATANASCIMENTO, PC.SEXO, ";
            Mysql = Mysql + " PC.NUMEROSUS, PC.NOMEMAE, PC.ENDERECO, PC.BAIRRO, PC.TELEFONE ";
            Mysql = Mysql + " FROM EntregaMercadoria AS P ";
            Mysql = Mysql + " INNER JOIN paciente AS PC ON PC.CODPACIENTE = P.CODPACIENTE ";


            if (valor != "")
            {

                if (por == "CODIGO")
                {
                    Mysql = Mysql + "WHERE  P.CODENTREGAMERCADORIA = @valor";
                }
                else if (por == "NUMERO")
                {
                    Mysql = Mysql + "WHERE  P.NUMEROPROTOCOLO = @valor";
                }



            }

            Mysql = Mysql + " ORDER BY PC.NOME ASC; ";
            db.CommandText = Mysql;
            db.AddParameter("@valor", valor);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

    }
}
