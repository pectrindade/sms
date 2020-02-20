using Atencao_Assistida.Forms;
using System;
using System.Windows.Forms;

namespace Atencao_Assistida.Pesquisas
{
    public partial class PesquisaPaciente : Form
    {
        public PesquisaPaciente()
        {
            InitializeComponent();
        }


        private void Carrega(string valor)
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[2];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.Pacientes.Selectdr(valor);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODPACIENTE"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NOME"));

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void txtpesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void PesquisaPaciente_Load(object sender, EventArgs e)
        {
            Carrega("");

        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            Carrega(txtpesquisa.Text);
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                var Codigo = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                var Descricao = Grid.Rows[RowsIndex].Cells[1].Value.ToString();
               
                Parametros.Valor = Grid.Rows[RowsIndex].Cells[0].Value.ToString();

                if(Parametros.Form == "Paciente")
                {
                    //Form tela = new Paciente();
                    //tela.MdiParent = this.MdiParent;
                    //tela.Show();
                }

                if (Parametros.Form == "Processo")
                {
                    //Form tela = new Processo();
                    //tela.MdiParent = this.MdiParent;
                    //tela.Show();
                }


                Close();
            }
            catch
            {

            }
        }

        private void PesquisaPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnCadastraPaciente_Click(object sender, EventArgs e)
        {
            Parametros.Form = "Processo";
            Parametros.Valor = "";

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "Paciente")
                {
                    if (form is Paciente)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {

                Form tela = new Paciente();
                // tela.MdiParent = MdiParent;
                tela.ShowDialog();
                RetornoPesquisaPaciente();


            }
        }


        public void RetornoPesquisaPaciente()
        {
            if (Parametros.Valor != "")
            {
                Close();
            }
        }


    }
}
