using Atencao_Assistida.Classes.Funcoes;
using Atencao_Assistida.Relatorios.Grupo;
using System;
using System.Windows.Forms;

namespace Atencao_Assistida.Forms
{
    public partial class Grupo : Form
    {
        public Grupo()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Grupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Grupo_Load(object sender, EventArgs e)
        {
            BuscaGrupo();

            
        }

        private void BuscaGrupo()
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[2];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.Grupo.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODGRUPO"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("DESCRICAO"));

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void Grid_grupo_DoubleClick(object sender, EventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;
            
            try
            {
                txtCodigo.Text = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                txtDescricao.Text = Grid.Rows[RowsIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void Grid_grupo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDesfaz_Click(object sender, EventArgs e)
        {
            Limpatela();
        }
        
        private void Limpatela()
        {
            txtCodigo.Text = "0";
            txtDescricao.Text = "";

            BuscaGrupo();
            txtDescricao.Focus();

        }

        private void Gravar(bool novo, int codigo)
        {

            var hoje = DateTime.Now;

            var descricao = txtDescricao.Text.Trim();
           

            try
            {
                var m = new Classes.Mysql.Grupo(codigo, descricao);
                if (novo)
                    m.Insert();
                else
                    m.Update();

                MessageBox.Show("Registro Gravado com Sucesso !");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Persistência");
            }

            Limpatela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "0")
            {

                Gravar(true, 0);

            }
            else
            {

                Gravar(false, int.Parse(txtCodigo.Text.Trim()));

            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                txtCodigo.Text = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                txtDescricao.Text = Grid.Rows[RowsIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void Relatorio()
        {
            var cria = new CriaArquivo();
            cria.Cria_Grupo();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Grupo.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    var cod = dr.GetString(dr.GetOrdinal("CODGRUPO"));
                    var nome = dr.GetString(dr.GetOrdinal("DESCRICAO"));

                    try
                    {
                        var m = new Classes.Mysql.Grupo(int.Parse(cod), nome);

                        m.InsertAccess();
                    }
                    catch (Exception erro)
                    {

                    }

                }

            }

            dr.Close();
            dr.Dispose();

            //CHAMA A TELA DE RELATORIO
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is RelGrupo)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelGrupo();
                tela.ShowDialog();
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Relatorio();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
