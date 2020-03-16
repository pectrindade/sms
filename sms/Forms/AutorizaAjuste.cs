using Atencao_Assistida.Classes.Mysql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Forms
{
    public partial class AutorizaAjuste : Form
    {
        public AutorizaAjuste()
        {
            InitializeComponent();
            CarregaCmbUsuario();
        }

        private void btnsai_Click(object sender, EventArgs e)
        {
            Parametros.Valor = "N";
            Close();
        }

        private void CarregaCmbUsuario()
        {

            int cod = int.Parse(Usuario.Coddepartamento);
            int codigo;
            string nome;

            cmbUsuario.Items.Clear();

            cmbUsuario.Items.Insert(0, "--SELECIONE--");

            //var dr = Acessos.SelectTudo();

            var dr = Acessos.SelectDepartamento(cod);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    codigo = int.Parse(dr.GetString(dr.GetOrdinal("CODUSUARIO")));
                    nome = dr.GetString(dr.GetOrdinal("LOGIN"));

                    //cmbUsuario.Items.Insert(codigo, nome);
                    cmbUsuario.Items.Add(nome);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void btnEntra_Click(object sender, EventArgs e)
        {
            var login = cmbUsuario.Text.Trim();
            var senha = txtsenha.Text.Trim();

            Parametros.Nome ="";
            Parametros.Valor = "N";

            var dr = Acessos.BuscaAutoriza(login, senha, 24);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    
                    Parametros.Nome = dr.GetString(dr.GetOrdinal("NOME"));
                    Parametros.Valor = "S";
                }
            }
           
            Close();
        }
    }
}
