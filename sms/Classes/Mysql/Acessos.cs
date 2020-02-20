using Atencao_Assistida.Classes.DAL;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;

namespace Atencao_Assistida.Classes.Mysql
{
    [DataObject(true)]
    public class Acessos
    {



        private int Codusuario { get; set; }
        private int Codempresa { get; set; }
        private int Coddepartamento { get; set; }
        private int Codunidade { get; set; }
        private int Tipousuario { get; set; }
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private string Email { get; set; }
        private string Telefone { get; set; }
        private string Login { get; set; }
        private string Senha { get; set; }
        private int Ativo { get; set; }
        private string Respinclusao { get; set; }
        private string Datahorainclusao { get; set; }
        private string Respalteracao { get; set; }
        private string Datahoraalteracao { get; set; }
        private string Excluido { get; set; }
        

        public Acessos(int codusuario, int codempresa, int coddepartamento, int codunidade, int tipousuario, string nome, string cpf, string email, string telefone,
        string login, string senha, int ativo, string respinclusao, string datahorainclusao, string respalteracao,
        string datahoraalteracao, string excluido)
        {
            Codusuario = codusuario;
            Codempresa = codempresa;
            Coddepartamento = coddepartamento;
            Codunidade = codunidade;
            Tipousuario = tipousuario;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Login = login;
            Senha = senha;
            Ativo = ativo;
            Respinclusao = respinclusao;
            Datahorainclusao = datahorainclusao;
            Respalteracao = respalteracao;
            Datahoraalteracao = datahoraalteracao;
            Excluido = excluido;

        }

        public Acessos(int codusuario)
        {
            Codusuario = codusuario;
        }

        public Acessos(int codusuario, string login, string senha)
        {
            Codusuario = codusuario;
            Login = login;
            Senha = senha;
        }

        public Acessos()
        {
        }

        public static string Acessar(int codempresa, int coddepartamento, string login, string senha)
        {
            var db = new DBAcess();
            var Mysql = "SELECT * ";
            Mysql = Mysql + " FROM usuarios ";
            Mysql = Mysql + " WHERE (CODEMPRESA = @CODEMPRESA) ";
            Mysql = Mysql + "AND (LOGIN = @login) ";
            Mysql = Mysql + "AND (SENHA = @senha) ";

            db.CommandText = Mysql;

            db.AddParameter("@CODEMPRESA", codempresa);
            db.AddParameter("@coddepartamento", coddepartamento);
            db.AddParameter("@LOGIN", login);
            db.AddParameter("@SENHA", senha);
            var r = Convert.ToString(db.ExecuteScalar());
            return r;
        }

        public int Insert()
        {
            var db = new DBAcess();
            var Mysql = " INSERT INTO usuarios(";

            Mysql = Mysql + " CODEMPRESA, CODDEPARTAMENTO, CODUNIDADE, TIPOUSUARIO, NOME, CPF, EMAIL, TELEFONE, ";
            Mysql = Mysql + " LOGIN, SENHA, ATIVO, RESPINCLUSAO, DATAHORAINCLUSAO, EXCLUIDO ";
            Mysql = Mysql + ")";

            Mysql = Mysql + " VALUES (";
            Mysql = Mysql + " @CODEMPRESA, @CODDEPARTAMENTO, @CODUNIDADE, @TIPOUSUARIO, @NOME, @CPF, @EMAIL, @TELEFONE, ";
            Mysql = Mysql + " @LOGIN, @SENHA, @ATIVO, @RESPINCLUSAO, @DATAHORAINCLUSAO, @EXCLUIDO ";
            Mysql = Mysql + ");";

            // RETORNA O ULTIMO ITEM ADICIONADO 
            const string select = " SELECT MAX(CODUSUARIO) FROM usuarios ";

            db.CommandText = Mysql + select;

            db.AddParameter("@CODUSUARIO", Codusuario);
            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@CODUNIDADE", Codunidade);
            db.AddParameter("@TIPOUSUARIO", Tipousuario);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@CPF", Cpf);
            db.AddParameter("@EMAIL", Email);
            db.AddParameter("@TELEFONE", Telefone);
            db.AddParameter("@LOGIN", Login);
            db.AddParameter("@SENHA", Senha);
            db.AddParameter("@ATIVO", Ativo);
            db.AddParameter("@RESPINCLUSAO", Respinclusao);
            db.AddParameter("@DATAHORAINCLUSAO", Convert.ToDateTime(Datahorainclusao));
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

        public bool Update()
        {
            var db = new DBAcess();
            var Mysql = " UPDATE usuarios ";

            Mysql = Mysql + "SET ";
            Mysql = Mysql + " CODEMPRESA = @CODEMPRESA, CODDEPARTAMENTO = @CODDEPARTAMENTO, CODUNIDADE = @CODUNIDADE, TIPOUSUARIO = @TIPOUSUARIO,  ";
            Mysql = Mysql + " NOME = @NOME, CPF = @CPF, EMAIL = @EMAIL, TELEFONE = @TELEFONE, LOGIN = @LOGIN, SENHA = @SENHA, ATIVO = @ATIVO,   ";
            Mysql = Mysql + " RESPALTERACAO = @RESPALTERACAO, DATAHORAALTERACAO = @DATAHORAALTERACAO, EXCLUIDO = @EXCLUIDO  ";

            Mysql = Mysql + " WHERE Codusuario = @Codusuario;";
            db.CommandText = Mysql;

            db.AddParameter("@CODUSUARIO", Codusuario);
            db.AddParameter("@CODEMPRESA", Codempresa);
            db.AddParameter("@CODDEPARTAMENTO", Coddepartamento);
            db.AddParameter("@CODUNIDADE", Codunidade);


            db.AddParameter("@TIPOUSUARIO", Tipousuario);
            db.AddParameter("@NOME", Nome);
            db.AddParameter("@CPF", Cpf);
            db.AddParameter("@EMAIL", Email);
            db.AddParameter("@TELEFONE", Telefone);
            db.AddParameter("@LOGIN", Login);
            db.AddParameter("@SENHA", Senha);
            db.AddParameter("@ATIVO", Ativo);
            db.AddParameter("@RESPALTERACAO", Respalteracao);
            db.AddParameter("@DATAHORAALTERACAO", Convert.ToDateTime(Datahoraalteracao));
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

        public bool UpdateSenha()
        {
            var db = new DBAcess();
            const string update = " UPDATE usuarios ";
            const string set = "SET " +
            " Login = @Login, Senha = @Senha ";

            const string where = " WHERE Codusuario = @Codusuario;";
            db.CommandText = update + set + where;
            db.AddParameter("@Codusuario", Codusuario);
            db.AddParameter("@Login", Login);
            db.AddParameter("@Senha", Senha);

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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public MySqlDataReader Select()
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM usuarios  ";
            Mysql = Mysql + " WHERE codusuario = @Codusuario ";
            db.CommandText = Mysql;
            db.AddParameter("@Codusuario", Codusuario);

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
        public static MySqlDataReader Select(int id)
        {
            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM usuarios  ";
            Mysql = Mysql + " WHERE codusuario = @Codusuario ";
            db.CommandText = Mysql;
            db.AddParameter("@Codusuario", id);

            var dr = (MySqlDataReader)db.ExecuteReader();
            return dr;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public MySqlDataReader SelectRecSenha()
        {

            var db = new DBAcess();
            var Mysql = " SELECT * ";
            Mysql = Mysql + " FROM usuarios   ";
            Mysql = Mysql + " WHERE EMAIL = @EMAIL " +
                                 " AND CPF = @CPF ";
            db.CommandText = Mysql;
            db.AddParameter("@Email", Email);


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
        public static MySqlDataReader SelectTudo()
        {
            var db = new DBAcess();
            string Mysql = " SELECT * ";
            Mysql = Mysql + " FROM usuarios ";

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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader SelectDepartamento(int codigo)
        {
            var db = new DBAcess();
            string Mysql = " SELECT * ";
            Mysql = Mysql + " FROM usuarios ";
            Mysql = Mysql + " WHERE CODDEPARTAMENTO = @CODDEPARTAMENTO ";
            Mysql = Mysql + " AND ATIVO = 1 ";

            db.CommandText = Mysql;
            db.AddParameter("@CODDEPARTAMENTO", codigo);
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

        //-> Tem de definir quais as buscas 
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static DataSet Select(string por, string valor)
        {
            var db = new DBAcess();
            var Mysql = " SELECT U.*, UN.NOME AS UNIDADE ";
            Mysql = Mysql + " FROM USUARIOS AS U ";
            Mysql = Mysql + " INNER JOIN UNIDADE AS UN ON U.CODUNIDADE = UN.CODUNIDADE ";
            Mysql = Mysql + " WHERE U.EXCLUIDO = 'N' ";

            switch (por)
            {
                case "nome":
                    {
                        Mysql = Mysql + " AND U.NOME LIKE CONCAT(@valor) ";
                        valor = '%' + valor + "%";
                    }
                    break;
                case "empresa":
                    {
                        Mysql = Mysql + " AND (NOME LIKE CONCAT(@valor)) ";
                        valor = '%' + valor + "%";
                    }
                    break;
                case "unidade":
                    {
                        Mysql = Mysql + " AND UN.NOME LIKE CONCAT(@valor) ";
                        valor = '%' + valor + "%";
                    }
                    break;
            }

            Mysql = Mysql + " ORDER BY U.NOME ASC ; ";

            db.CommandText = Mysql;
            db.AddParameter("@valor", valor);
            try
            {
                var ds = db.ExecuteDataSet();
                return ds;
            }
            finally
            {
                db.Dispose();
            }
        }

        public static MySqlDataReader Selectdr(string valor)
        {
            var db = new DBAcess();
            string Mysql = " SELECT * ";
            Mysql = Mysql + " FROM usuarios ";

            if (valor != "")
            {

                {
                    Mysql = Mysql + "WHERE NOME LIKE CONCAT(@valor)";
                    valor = '%' + valor + "%";
                }


            }

            db.CommandText = Mysql;
            db.AddParameter("@valor", valor);
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

        //-------------Permissoes

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static MySqlDataReader BuscaAcessos(int codigo)
        {

            var db = new DBAcess();
            string Mysql = " SELECT ap.CODPERMISAO, ap.CODUSUARIO, ap.CODFORM, af.`LOCAL` AS REFERENTE, af.NOMEMENU, af.NOME, ";
            Mysql = Mysql + " ap.ACESSAR, ap.GRAVAR, ap.EDITAR, ap.EXCLUIR, ap.IMPRIMIR ";
            Mysql = Mysql + " FROM acesso_permisao AS ap ";
            Mysql = Mysql + " INNER JOIN acesso_forms AS af ON af.CODFORM = ap.CODFORM ";

            Mysql = Mysql + " WHERE ap.CODUSUARIO = @codigo ";

            db.CommandText = Mysql;
            db.AddParameter("@codigo", codigo);

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
        public static MySqlDataReader BuscaTodosAcessos()
        {

            var db = new DBAcess();
            string Mysql = " SELECT * ";
            Mysql = Mysql + " FROM acesso_forms ";

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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public MySqlDataReader BuscaPermisaoCodigo(int codigo, int codform)
        {
            var db = new DBAcess();
            //const string select = " SELECT p.codusuario, p.codform  ";
            var Mysql = " SELECT  COUNT(*) as codigo  ";
            Mysql = Mysql + " FROM acesso_Permisao p  ";
            Mysql = Mysql + " WHERE p.codusuario = @codusuario ";
            Mysql = Mysql + " AND p.codform = @codform ";

            db.CommandText = Mysql;
            db.AddParameter("@codusuario", codigo);
            db.AddParameter("@codform", codform);

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
        public static MySqlDataReader SelectPermissao(int Codusuario)
        {

            var db = new DBAcess();
            var Mysql = "SELECT ap.CODPERMISAO, ap.CODUSUARIO, ap.CODFORM, af.NOMEMENU, ap.ACESSAR ";
            Mysql = Mysql + " from acesso_permisao ap ";
            Mysql = Mysql + " inner join acesso_forms af on ap.CODFORM = af.CODFORM ";
            Mysql = Mysql + " WHERE ap.CODUSUARIO = @CODUSUARIO  AND ap.ACESSAR = 'S'";

            db.CommandText = Mysql;

            db.AddParameter("@CODUSUARIO", Codusuario);

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
        public static MySqlDataReader BuscaForm(int codigo)
        {

            var db = new DBAcess();
            string Mysql = "SELECT * ";
            Mysql = Mysql + " from acesso_forms ";

            Mysql = Mysql + " WHERE CODFORM = @CODFORM  ";
            db.CommandText = Mysql;
            db.AddParameter("@CODFORM", codigo);

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

        public int InsertPermissao(int codusuario, string codform)
        {
            var db = new DBAcess();
            const string insert = " INSERT INTO acesso_Permisao(" +
            " CODUSUARIO, CODFORM, ACESSAR, GRAVAR, EDITAR, EXCLUIR, IMPRIMIR " +
            ")";
            const string values = " VALUES (" +
           " @CODUSUARIO, @CODFORM, @ACESSAR, @GRAVAR, @EDITAR, @EXCLUIR, @IMPRIMIR " +
           ");";

            db.CommandText = insert + values;
            db.AddParameter("@CODUSUARIO", codusuario);
            db.AddParameter("@CODFORM", codform);
            db.AddParameter("@ACESSAR", "N");
            db.AddParameter("@GRAVAR", "N");
            db.AddParameter("@EDITAR", "N");
            db.AddParameter("@EXCLUIR", "N");
            db.AddParameter("@IMPRIMIR", "N");

            try
            {
                return Convert.ToInt32(db.ExecuteScalar());
            }
            finally
            {
                db.Dispose();
            }
        }

        public bool UpdatePermisao(int codusuario, int codform, string acessar, string gravar, string editar, string excluir, string imprimir)
        {
            var db = new DBAcess();
            const string update = " UPDATE acesso_permisao ";
            const string set = "SET " +
            "codform = @codform, acessar = @acessar, gravar = @gravar, editar = @editar, excluir = @excluir, imprimir = @imprimir ";

            const string where = " WHERE Codusuario = @Codusuario AND codform = @codform;";
            db.CommandText = update + set + where;
            db.AddParameter("@Codusuario", codusuario);
            db.AddParameter("@codform", codform);
            db.AddParameter("@acessar", acessar);
            db.AddParameter("@gravar", gravar);
            db.AddParameter("@editar", editar);
            db.AddParameter("@excluir", excluir);
            db.AddParameter("@imprimir", imprimir);

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

        public bool Delete_Item(int codigo)
        {
            var db = new DBAcess();
            var Mysql = " DELETE FROM acesso_permisao ";

            Mysql = Mysql + " WHERE CODUSUARIO = @CODUSUARIO  ";
            db.CommandText = Mysql;
            db.AddParameter("@CODUSUARIO", codigo);

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

        public int GravaPermissao(int codusuario, int codform, string gravar, string editar, string excluir, string listar)
        {
            var db = new DBAcess();
            const string insert = " INSERT INTO acesso_Permisao(" +
            " CODUSUARIO, CODFORM, ACESSAR, GRAVAR, EDITAR, EXCLUIR, IMPRIMIR " +
            ")";
            const string values = " VALUES (" +
           " @CODUSUARIO, @CODFORM, @ACESSAR, @GRAVAR, @EDITAR, @EXCLUIR, @IMPRIMIR " +
           ");";

            db.CommandText = insert + values;
            db.AddParameter("@CODUSUARIO", codusuario);
            db.AddParameter("@CODFORM", codform);
            db.AddParameter("@ACESSAR", "S");
            db.AddParameter("@GRAVAR", gravar);
            db.AddParameter("@EDITAR", editar);
            db.AddParameter("@EXCLUIR", excluir);
            db.AddParameter("@IMPRIMIR", listar);

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