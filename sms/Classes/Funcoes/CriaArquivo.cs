using Atencao_Assistida.Classes.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencao_Assistida.Classes.Funcoes
{
    [DataObject(true)]
    public class CriaArquivo
    {

        public CriaArquivo()
        {

        }

        public bool CriaTb()
        {

            var db = new DBAcessOleDB();
            var Mysql = "CREATE TABLE Contato ( ";
            Mysql = Mysql + " ID int not null, ";
            Mysql = Mysql + " Nome varchar(50) ";

            Mysql = Mysql + ")";

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

        public bool Cria_Departamento()
        {

        Inicio:

            var db = new DBAcessOleDB();

            var tableName = "Departamento";

            var Mysql = "CREATE TABLE " + tableName + "( ";

            Mysql = Mysql + " [CODDEPARTAMENTO] Int, ";
            Mysql = Mysql + " [NOME]  varchar(100), ";
            Mysql = Mysql + " [TELEFONE]  varchar(50), ";
            Mysql = Mysql + " [EMAIL]  varchar(50), ";

            Mysql = Mysql + " [RESPINCLUSAO]  varchar(255), ";
            Mysql = Mysql + " [DATAHORAINCLUSAO]  varchar(50), ";
            Mysql = Mysql + " [RESPALTERACAO]  varchar(255), ";
            Mysql = Mysql + " [DATAHORAALTERACAO]  varchar(50) ";

            Mysql = Mysql + " )";

            db.CommandText = Mysql;

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            catch 
            {
                                
                db.Dispose();
                db = new DBAcessOleDB();

                Mysql = "DROP  TABLE " + tableName;
                db.CommandText = Mysql;
                try
                {
                    db.ExecuteNonQuery();
                }
                finally
                {
                    db.Dispose();
                }

                goto Inicio;

            }
            finally
            {
                db.Dispose();
            }

            
        }

        public bool Cria_Fornecedor()
        {

        Inicio:

            var db = new DBAcessOleDB();

            var tableName = "Fornecedor";

            var Mysql = "CREATE TABLE " + tableName + "( ";

            Mysql = Mysql + " [CODFORNECEDOR] Int, ";
            Mysql = Mysql + " [NOMEFORNECEDOR]  varchar(100), ";
            Mysql = Mysql + " [CODDEPARTAMENTO] Int, ";
            Mysql = Mysql + " [NOMEDEPARTAMENTO]  varchar(100), ";
            Mysql = Mysql + " [CNPJ]  varchar(50), ";
            Mysql = Mysql + " [TELEFONE]  varchar(50), ";
            Mysql = Mysql + " [EMAIL]  varchar(50), ";

            Mysql = Mysql + " [RESPINCLUSAO]  varchar(255), ";
            Mysql = Mysql + " [DATAHORAINCLUSAO]  varchar(50), ";
            Mysql = Mysql + " [RESPALTERACAO]  varchar(255), ";
            Mysql = Mysql + " [DATAHORAALTERACAO]  varchar(50) ";

            Mysql = Mysql + " )";

            db.CommandText = Mysql;

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            catch
            {

                db.Dispose();
                db = new DBAcessOleDB();

                Mysql = "DROP  TABLE " + tableName;
                db.CommandText = Mysql;
                try
                {
                    db.ExecuteNonQuery();
                }
                finally
                {
                    db.Dispose();
                }

                goto Inicio;

            }
            finally
            {
                db.Dispose();
            }
        }

        public bool Cria_Unidade()
        {

        Inicio:

            var db = new DBAcessOleDB();

            var tableName = "Unidade";

            var Mysql = "CREATE TABLE " + tableName + "( ";

            Mysql = Mysql + " [CODUNIDADE] Int, ";
            Mysql = Mysql + " [NOME]  varchar(100), ";
            Mysql = Mysql + " [TELEFONE]  varchar(50), ";
            Mysql = Mysql + " [EMAIL]  varchar(50), ";
            Mysql = Mysql + " [ENDERECO]  varchar(255), ";
            Mysql = Mysql + " [BAIRRO]  varchar(100), ";

            Mysql = Mysql + " [RESPINCLUSAO]  varchar(255), ";
            Mysql = Mysql + " [DATAHORAINCLUSAO]  varchar(50), ";
            Mysql = Mysql + " [RESPALTERACAO]  varchar(255), ";
            Mysql = Mysql + " [DATAHORAALTERACAO]  varchar(50) ";

            Mysql = Mysql + " )";

            db.CommandText = Mysql;

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            catch
            {

                db.Dispose();
                db = new DBAcessOleDB();

                Mysql = "DROP  TABLE " + tableName;
                db.CommandText = Mysql;
                try
                {
                    db.ExecuteNonQuery();
                }
                finally
                {
                    db.Dispose();
                }

                goto Inicio;

            }
            finally
            {
                db.Dispose();
            }
        }

        public bool Cria_Grupo()
        {

        Inicio:

            var db = new DBAcessOleDB();

            var tableName = "Grupo";

            var Mysql = "CREATE TABLE " + tableName + "( ";

            Mysql = Mysql + " [CODGRUPO] Int, ";
            Mysql = Mysql + " [DESCRICAO]  varchar(100) ";

            Mysql = Mysql + " )";

            db.CommandText = Mysql;

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            catch
            {

                db.Dispose();
                db = new DBAcessOleDB();

                Mysql = "DROP  TABLE " + tableName;
                db.CommandText = Mysql;
                try
                {
                    db.ExecuteNonQuery();
                }
                finally
                {
                    db.Dispose();
                }

                goto Inicio;

            }
            finally
            {
                db.Dispose();
            }
        }

        public bool Cria_Marca()
        {

        Inicio:

            var db = new DBAcessOleDB();

            var tableName = "Marca";

            var Mysql = "CREATE TABLE " + tableName + "( ";

            Mysql = Mysql + " [CODMARCA] Int, ";
            Mysql = Mysql + " [DESCRICAO]  varchar(100) ";

            Mysql = Mysql + " )";

            db.CommandText = Mysql;

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            catch
            {

                db.Dispose();
                db = new DBAcessOleDB();

                Mysql = "DROP  TABLE " + tableName;
                db.CommandText = Mysql;
                try
                {
                    db.ExecuteNonQuery();
                }
                finally
                {
                    db.Dispose();
                }

                goto Inicio;

            }
            finally
            {
                db.Dispose();
            }
        }

        public bool Cria_Produtos()
        {

        Inicio:

            var db = new DBAcessOleDB();

            var tableName = "Produtos";

            var Mysql = "CREATE TABLE " + tableName + "( ";

            Mysql = Mysql + " [CODPRODUTO] Int, ";
            Mysql = Mysql + " [NOME]  varchar(255), ";
            Mysql = Mysql + " [DESCRICAO]  varchar(255), ";
            Mysql = Mysql + " [CODDEPARTAMENTO] Int, ";
            Mysql = Mysql + " [NOMEDEPARTAMENTO]  varchar(255), ";
            Mysql = Mysql + " [CODGRUPO]  int, ";
            Mysql = Mysql + " [NOMEGRUPO]  varchar(255), ";
            Mysql = Mysql + " [CODMARCA]  int, ";
            Mysql = Mysql + " [NOMEMARCA]  varchar(255), ";
            Mysql = Mysql + " [UNIDADE]  varchar(50), ";
           
            Mysql = Mysql + " [RESPINCLUSAO]  varchar(255), ";
            Mysql = Mysql + " [DATAHORAINCLUSAO]  varchar(50), ";
            Mysql = Mysql + " [RESPALTERACAO]  varchar(255), ";
            Mysql = Mysql + " [DATAHORAALTERACAO]  varchar(50) ";

            Mysql = Mysql + " )";

            db.CommandText = Mysql;

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            catch
            {

                db.Dispose();
                db = new DBAcessOleDB();

                Mysql = "DROP  TABLE " + tableName;
                db.CommandText = Mysql;
                try
                {
                    db.ExecuteNonQuery();
                }
                finally
                {
                    db.Dispose();
                }

                goto Inicio;

            }
            finally
            {
                db.Dispose();
            }
        }

        public bool Cria_Cfop()
        {

        Inicio:

            var db = new DBAcessOleDB();

            var tableName = "Cfop";

            var Mysql = "CREATE TABLE " + tableName + "( ";

            Mysql = Mysql + " [CODCFOP] varchar(4), ";
            Mysql = Mysql + " [DESCRICAO]  varchar(200), ";
            Mysql = Mysql + " [APLICACAO]  varchar(530), ";

            Mysql = Mysql + " )";

            db.CommandText = Mysql;

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            catch
            {

                db.Dispose();
                db = new DBAcessOleDB();

                Mysql = "DROP  TABLE " + tableName;
                db.CommandText = Mysql;
                try
                {
                    db.ExecuteNonQuery();
                }
                finally
                {
                    db.Dispose();
                }

                goto Inicio;

            }
            finally
            {
                db.Dispose();
            }
        }

        public bool Cria_Entrada()
        {

        Inicio:

            var db = new DBAcessOleDB();

            var tableName = "Entrada";

            var Mysql = "CREATE TABLE " + tableName + "( ";

            Mysql = Mysql + " [CODENTRADA]  Int, ";
            Mysql = Mysql + " [CODEMPRESA]  Int, ";
            Mysql = Mysql + " [NOMEEMPRESA]  varchar(200), ";
            Mysql = Mysql + " [CODDEPARTAMENTO]  Int, ";
            Mysql = Mysql + " [NOMEDEPARTAMENTO]  varchar(200), ";
            Mysql = Mysql + " [NUMERONOTA]  varchar(20), ";
            Mysql = Mysql + " [SERIE]  varchar(5), ";
            Mysql = Mysql + " [CFOP]  varchar(10), ";
            Mysql = Mysql + " [CODFORNECEDOR]   Int, ";
            Mysql = Mysql + " [NOMEFORNECEDOR]  varchar(200), ";
            Mysql = Mysql + " [EMISSAO]  varchar(20), ";
            Mysql = Mysql + " [RECEBIMENTO]  varchar(20), ";
            Mysql = Mysql + " [CODPRODUTO]   Int, ";
            Mysql = Mysql + " [NOMEPRODUTO]  varchar(200), ";
            Mysql = Mysql + " [QUANTIDADE]  varchar(10) ";

            Mysql = Mysql + " )";

            db.CommandText = Mysql;

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            catch
            {

                db.Dispose();
                db = new DBAcessOleDB();

                Mysql = "DROP  TABLE " + tableName;
                db.CommandText = Mysql;
                try
                {
                    db.ExecuteNonQuery();
                }
                finally
                {
                    db.Dispose();
                }

                goto Inicio;

            }
            finally
            {
                db.Dispose();
            }
        }

        public bool Cria_Pedido()
        {

        Inicio:

            var db = new DBAcessOleDB();

            var tableName = "Pedido";

            var Mysql = "CREATE TABLE " + tableName + "( ";

            Mysql = Mysql + " [CODPEDIDO]  Int, ";
            Mysql = Mysql + " [CODEMPRESA]  Int, ";
            Mysql = Mysql + " [CODDEPARTAMENTO]  Int, ";
            Mysql = Mysql + " [NOMEDEPARTAMENTO]  varchar(200), ";
            Mysql = Mysql + " [CODUNIDADE]  Int, ";
            Mysql = Mysql + " [NOMEUNIDADE]  varchar(200), ";
            Mysql = Mysql + " [SOLICITANTE]  varchar(200), ";
            Mysql = Mysql + " [NUMEROPEDIDO]   varchar(10), ";
            Mysql = Mysql + " [DATAPEDIDO]  varchar(20), ";
            Mysql = Mysql + " [STATUS]  varchar(20), ";
            Mysql = Mysql + " [CODPRODUTO]   Int, ";
            Mysql = Mysql + " [NOMEPRODUTO]  varchar(200), ";
            Mysql = Mysql + " [QUANTIDADE]  varchar(10), ";
            Mysql = Mysql + " [ESTOQUEUBS]  varchar(10) ";

            Mysql = Mysql + " )";

            db.CommandText = Mysql;

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            catch
            {

                db.Dispose();
                db = new DBAcessOleDB();

                Mysql = "DROP  TABLE " + tableName;
                db.CommandText = Mysql;
                try
                {
                    db.ExecuteNonQuery();
                }
                finally
                {
                    db.Dispose();
                }

                goto Inicio;

            }
            finally
            {
                db.Dispose();
            }
        }

        public bool Cria_Oficio()
        {

        Inicio:

            var db = new DBAcessOleDB();

            var tableName = "Oficio";

            var Mysql = "CREATE TABLE " + tableName + "( ";

            Mysql = Mysql + " [CODOFICIO]  Int, ";
            Mysql = Mysql + " [CODEMPRESA]  Int, ";
            Mysql = Mysql + " [CODDEPARTAMENTO]  Int, ";
            Mysql = Mysql + " [NOMEDEPARTAMENTO]  varchar(200), ";
            Mysql = Mysql + " [CODUNIDADE]  Int, ";
            Mysql = Mysql + " [NOMEUNIDADE]  varchar(200), ";
            Mysql = Mysql + " [SOLICITANTE]  varchar(200), ";
            Mysql = Mysql + " [NUMEROPEDIDO]   varchar(10), ";
            Mysql = Mysql + " [DATAPEDIDO]  varchar(20), ";
            Mysql = Mysql + " [STATUS]  varchar(20), ";
            Mysql = Mysql + " [CODPRODUTO]   Int, ";
            Mysql = Mysql + " [NOMEPRODUTO]  varchar(200), ";
            Mysql = Mysql + " [QUANTIDADE]  varchar(10), ";
            Mysql = Mysql + " [PARAQUEM]  varchar(255) ";

            Mysql = Mysql + " )";

            db.CommandText = Mysql;

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            catch
            {

                db.Dispose();
                db = new DBAcessOleDB();

                Mysql = "DROP  TABLE " + tableName;
                db.CommandText = Mysql;
                try
                {
                    db.ExecuteNonQuery();
                }
                finally
                {
                    db.Dispose();
                }

                goto Inicio;

            }
            finally
            {
                db.Dispose();
            }
        }

        public bool Cria_Saida()
        {

        Inicio:

            var db = new DBAcessOleDB();

            var tableName = "Saida";

            var Mysql = "CREATE TABLE " + tableName + "( ";

            Mysql = Mysql + " [CODSAIDA]  Int, ";
            Mysql = Mysql + " [CODEMPRESA]  Int, ";
            Mysql = Mysql + " [CODDEPARTAMENTO]  Int, ";
            Mysql = Mysql + " [NOMEDEPARTAMENTO]  varchar(200), ";
            Mysql = Mysql + " [CODUNIDADE]  Int, ";
            Mysql = Mysql + " [NOMEUNIDADE]  varchar(200), ";
            Mysql = Mysql + " [SOLICITANTE]  varchar(200), ";
            Mysql = Mysql + " [NUMEROPEDIDO]   varchar(10), ";
            Mysql = Mysql + " [DATAENTREGA]  varchar(20), ";
            Mysql = Mysql + " [CODPRODUTO]   Int, ";
            Mysql = Mysql + " [NOMEPRODUTO]  varchar(200), ";
            Mysql = Mysql + " [SOLICITADO]  varchar(10), ";
            Mysql = Mysql + " [ENTREGUE]  varchar(10), ";
            Mysql = Mysql + " [RESPINCLUSAO]  varchar(200), ";
            Mysql = Mysql + " [DATAINCLUSAO]  varchar(20) ";

            Mysql = Mysql + " )";

            db.CommandText = Mysql;

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            catch
            {

                db.Dispose();
                db = new DBAcessOleDB();

                Mysql = "DROP  TABLE " + tableName;
                db.CommandText = Mysql;
                try
                {
                    db.ExecuteNonQuery();
                }
                finally
                {
                    db.Dispose();
                }

                goto Inicio;

            }
            finally
            {
                db.Dispose();
            }
        }

        public bool Cria_Balanco()
        {

        Inicio:

            var db = new DBAcessOleDB();

            var tableName = "Balanco";

            var Mysql = "CREATE TABLE " + tableName + "( ";

            Mysql = Mysql + " [CODEMPRESA]  Int, ";
            Mysql = Mysql + " [CODDEPARTAMENTO]  Int, ";
            Mysql = Mysql + " [NOMEDEPARTAMENTO]  varchar(200), ";
            Mysql = Mysql + " [DATABALANCO]  varchar(20), ";
            Mysql = Mysql + " [CODPRODUTO]   Int, ";
            Mysql = Mysql + " [NOMEPRODUTO]  varchar(200), ";
            Mysql = Mysql + " [QUANTIDADE]  varchar(10), ";
            Mysql = Mysql + " [RESPINCLUSAO]  varchar(200), ";
            Mysql = Mysql + " [DATAINCLUSAO]  varchar(20), ";
            Mysql = Mysql + " [RESPALTERACAO]  varchar(200), ";
            Mysql = Mysql + " [DATAALTERACAO]  varchar(20) ";

            Mysql = Mysql + " )";

            db.CommandText = Mysql;

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            catch
            {

                db.Dispose();
                db = new DBAcessOleDB();

                Mysql = "DROP TABLE " + tableName;
                db.CommandText = Mysql;
                try
                {
                    db.ExecuteNonQuery();
                }
                finally
                {
                    db.Dispose();
                }

                goto Inicio;

            }
            finally
            {
                db.Dispose();
            }
        }

        public bool Cria_Estoque()
        {

        Inicio:

            var db = new DBAcessOleDB();

            var tableName = "Estoque";

            var Mysql = "CREATE TABLE " + tableName + "( ";

            Mysql = Mysql + " [CODEMPRESA]  Int, ";
            Mysql = Mysql + " [CODDEPARTAMENTO]  Int, ";
            Mysql = Mysql + " [NOMEDEPARTAMENTO]  varchar(200), ";
            Mysql = Mysql + " [MES]  varchar(2), ";
            Mysql = Mysql + " [ANO]  varchar(4), ";
            Mysql = Mysql + " [CODPRODUTO]   Int, ";
            Mysql = Mysql + " [NOMEPRODUTO]  varchar(200), ";
            Mysql = Mysql + " [QTANTERIOR]  varchar(10), ";
            Mysql = Mysql + " [ENTRADA]  varchar(200), ";
            Mysql = Mysql + " [SAIDA]  varchar(20), ";
            Mysql = Mysql + " [QTATUAL]  varchar(20), ";
            Mysql = Mysql + " [USUARIO]  varchar(60), ";
            Mysql = Mysql + " [FUNCAO]  varchar(60) ";

            Mysql = Mysql + " )";

            db.CommandText = Mysql;

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            catch
            {

                db.Dispose();
                db = new DBAcessOleDB();

                Mysql = "DROP TABLE " + tableName;
                db.CommandText = Mysql;
                try
                {
                    db.ExecuteNonQuery();
                }
                finally
                {
                    db.Dispose();
                }

                goto Inicio;

            }
            finally
            {
                db.Dispose();
            }
        }

        public bool Cria_SaidaPeriodo()
        {

        Inicio:

            var db = new DBAcessOleDB();

            var tableName = "SaidaPeriodo";

            var Mysql = "CREATE TABLE " + tableName + "( ";

            Mysql = Mysql + " [CODEMPRESA]  Int, ";
            Mysql = Mysql + " [NOMEEMPRESA]  varchar(200), ";
            Mysql = Mysql + " [CODDEPARTAMENTO]  Int, ";
            Mysql = Mysql + " [NOMEDEPARTAMENTO]  varchar(200), ";
            Mysql = Mysql + " [CODSAIDA]  Int, ";
            Mysql = Mysql + " [DATASAIDA]  varchar(20), ";
            Mysql = Mysql + " [CODUNIDADE]  Int, ";
            Mysql = Mysql + " [NOMEUNIDADE]  varchar(200), ";
            Mysql = Mysql + " [SOLICITANTE]  varchar(200), ";
            Mysql = Mysql + " [NUMEROPEDIDO]   varchar(10), ";
            Mysql = Mysql + " [CODPRODUTO]   Int, ";
            Mysql = Mysql + " [NOMEPRODUTO]  varchar(200), ";
            Mysql = Mysql + " [QUANTIDADE]  varchar(10), ";

            Mysql = Mysql + " )";

            db.CommandText = Mysql;

            try
            {
                db.ExecuteNonQuery();
                return true;
            }
            catch
            {

                db.Dispose();
                db = new DBAcessOleDB();

                Mysql = "DROP  TABLE " + tableName;
                db.CommandText = Mysql;
                try
                {
                    db.ExecuteNonQuery();
                }
                finally
                {
                    db.Dispose();
                }

                goto Inicio;

            }
            finally
            {
                db.Dispose();
            }
        }


    }
}
