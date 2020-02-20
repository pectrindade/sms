using Atencao_Assistida.Pesquisas;
using Atencao_Assistida.Relatorios.Paciente;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace Atencao_Assistida.Forms
{
    public partial class Paciente : Form
    {

        public string glbCodpaciente;
        public string glbCaminhoImagens;

        public Paciente()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            Close();
        }

        private void Paciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            //ListScanners();
           
            //// Set JPEG as default
            //comboBox1.SelectedIndex = 1;

        }

        private void BuscaPaciente(int codigo)
        {
            if (Parametros.Valor != "")
            {
                codigo = int.Parse(Parametros.Valor);
            }

            var dr = Classes.Mysql.Pacientes.BuscaUm(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtcodigo.Text = dr.GetString(dr.GetOrdinal("CODPACIENTE"));
                    txtNome.Text = dr.GetString(dr.GetOrdinal("NOME"));
                    dtnascimento.Text = dr.GetString(dr.GetOrdinal("DATANASCIMENTO"));
                    dtRecadastro.Text = dr.GetString(dr.GetOrdinal("DATARECADASTRO"));
                    cmbsexo.Text = dr.GetString(dr.GetOrdinal("SEXO"));
                    txtNumerosus.Text = dr.GetString(dr.GetOrdinal("NUMEROSUS"));
                    txtNomemae.Text = dr.GetString(dr.GetOrdinal("NOMEMAE"));
                    txtendereco.Text = dr.GetString(dr.GetOrdinal("ENDERECO"));
                    txtbairro.Text = dr.GetString(dr.GetOrdinal("BAIRRO"));
                    txtfone.Text = dr.GetString(dr.GetOrdinal("TELEFONE"));
                    txtcell.Text = dr.GetString(dr.GetOrdinal("CELL"));

                   
                }

            }

            dr.Close();
            dr.Dispose();

            if (txtcodigo.Text.Trim() != "")
            {
                CarregaNomeImg(int.Parse(txtcodigo.Text));
            }
        }

        private void btnProcuraPaciente_Click(object sender, EventArgs e)
        {
            Parametros.Form = "Paciente";
            Parametros.Valor = "";

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaPaciente")
                {
                    if (form is PesquisaPaciente)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {
                Form tela = new PesquisaPaciente();
                tela.ShowDialog();
                if (txtcodigo.Text.Trim() != "")
                {
                    BuscaPaciente(int.Parse(txtcodigo.Text));
                }

            }

        }

        public void RetornoPesquisaPaciente()
        {
            if (Parametros.Valor != "")
            {
                BuscaPaciente(int.Parse(Parametros.Valor));
            }
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Trim() != "")
            {
                BuscaPaciente(int.Parse(txtcodigo.Text));
            }
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            LimpaTela();
            
           
        }

        private void LimpaTela()
        {
            txtcodigo.Text = "";
            txtNome.Text = "";
            dtnascimento.Text = "  /  /    ";
            dtRecadastro.Text = "  /  /    ";
            cmbsexo.Text = "Vazio";
            txtNumerosus.Text = "";
            txtNomemae.Text = "";
            txtendereco.Text = "";
            txtbairro.Text = "";
            txtfone.Text = "";
            txtcell.Text = "";

            Grid.Rows.Clear();
            Grid.Refresh();

            tabControl1.SelectedTab = Cadastro;

            Parametros.Form = "Paciente";
            txtcodigo.Focus();

        }

        private void Gravar(bool novo, int codigo)
        {

            var hoje = DateTime.Now;

            var codpaciente = txtcodigo.Text.Trim();
            var nome = txtNome.Text.Trim();
            var datanascimento = dtnascimento.Text.Trim();
            var datarecadastro = dtRecadastro.Text.Trim();
            var sexo = cmbsexo.Text;
            var numerosus = txtNumerosus.Text.Trim();
            var nomemae = txtNomemae.Text.Trim();
            var endereco = txtendereco.Text.Trim();
            var bairro = txtbairro.Text.Trim();
            var telefone = txtfone.Text.Trim();
            var cell = txtcell.Text.Trim();

            var respinclusao = Usuario.Nomeusuario.ToString();
            var datainclusao = hoje.ToString();
            var respalteracao = Usuario.Nomeusuario.ToString();
            var dataalteracao = hoje.ToString();
            var excluido = "N";
            int numero = 0;


            try
            {
                var m = new Classes.Mysql.Pacientes(int.Parse(codpaciente), nome, datanascimento, datarecadastro, sexo.ToString(), numerosus, nomemae, endereco, bairro, telefone, cell,
                    respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao, excluido);
                if (novo)
                {
                    numero = m.Insert();

                    if (Parametros.Form == "Processo")
                    {
                        Parametros.Valor = numero.ToString();
                        LimpaTela();
                        Close();

                    }

                }
                else
                {
                    m.Update();

                    if (Parametros.Form == "Processo")
                    {
                        Parametros.Valor = codpaciente;
                        LimpaTela();
                        Close();

                    }
                }


                MessageBox.Show("Registro Gravado com Sucesso !");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na Persistência");
            }

            LimpaTela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            var dat = DateTime.Now;
             dtRecadastro.Text =  dat.AddMonths(6).ToString("d");

            if (txtcodigo.Text.Trim() == "")
            {
                txtcodigo.Text = "0";
            }


                if (txtcodigo.Text.Trim() == "0")
            {

                Gravar(true, 0);

            }
            else
            {

                Gravar(false, int.Parse(txtcodigo.Text.Trim()));

            }
        }

        private void Relatorio(int codigo)
        {
            // ESVAZIA O REPOSITORIO
            var d = new Classes.Mysql.Pacientes();
            d.DeleteAccess();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Pacientes.BuscaUm(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    var hoje = DateTime.Now;
                    var codpaciente = txtcodigo.Text.Trim();
                    var nome = txtNome.Text.Trim();
                    var datanascimento = dtnascimento.Text.Trim();
                    var datarecadastro = dtRecadastro.Text.Trim();
                    var sexo = cmbsexo.Text;
                    var numerosus = txtNumerosus.Text.Trim();
                    var nomemae = txtNomemae.Text.Trim();
                    var endereco = txtendereco.Text.Trim();
                    var bairro = txtbairro.Text.Trim();
                    var telefone = txtfone.Text.Trim();
                    var cell = txtcell.Text.Trim();

                    var respinclusao = Usuario.Nomeusuario.ToString();
                    var datainclusao = hoje.ToString();
                    var respalteracao = Usuario.Nomeusuario.ToString();
                    var dataalteracao = hoje.ToString();
                    var excluido = "N";

                    try
                    {
                        var m = new Classes.Mysql.Pacientes(int.Parse(codpaciente), nome, datanascimento, datarecadastro, sexo.ToString(), numerosus, nomemae, endereco, bairro, telefone, cell,
                    respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao, excluido);

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
                if (form is RelPaciente)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelPaciente();
                tela.ShowDialog();
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            if (txtcodigo.Text.Trim() != "")
            {
                Relatorio(int.Parse(txtcodigo.Text.Trim()));

            }
            else
            {
                MessageBox.Show("Sem Paciente Selecionado");
                txtcodigo.Focus();

            }

        }

        private void btnAdicionaImg_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in Application.OpenForms)
            {
                Parametros.Valor = txtcodigo.Text;

                // Verifica se o form esta aberto
                if (form.Name == "CapturaScanner")
                {
                    if (form is CapturaScanner)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {
                Form tela = new CapturaScanner();
                tela.ShowDialog();
                RetornoPesquisaPaciente();

            }
        }

        private void btnExcluirImg_Click(object sender, EventArgs e)
        {

        }

        private void CarregaNomeImg(int valor)
        {

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[3];

            //LIMPAR GRID
            Grid.Rows.Clear();
            Grid.Refresh();

            var dr = Classes.Mysql.DocumentosImg.BuscaNomeImage(valor);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    linhaDados[0] = dr.GetString(dr.GetOrdinal("CODIMAGEM"));
                    linhaDados[1] = dr.GetString(dr.GetOrdinal("NUMEROIMAGEM"));
                    linhaDados[2] = dr.GetString(dr.GetOrdinal("NOMEIMAGEM"));

                    Grid.Rows.Add(linhaDados);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowsIndex = Grid.CurrentRow.Index;

            try
            {
                var Codigo = Grid.Rows[RowsIndex].Cells[0].Value.ToString();
                var Descricao = Grid.Rows[RowsIndex].Cells[1].Value.ToString();

                BuscaImg(int.Parse(Codigo));
            }
            catch
            {

            }
        }

        private void BuscaImg(int valor)
        {
            var dr = Classes.Mysql.DocumentosImg.BuscaImagem(valor);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    //txtcodigo.Text = dr.GetString(dr.GetOrdinal("CODPACIENTE"));
                    //txtNome.Text = dr.GetString(dr.GetOrdinal("NOMEIMAGEM"));

                    byte[] Img = (byte[])dr["IMAGEM"];
                    MemoryStream ms = new MemoryStream(Img);
                    pictureBox1.Image = Image.FromStream(ms);
                    pictureBox1.Refresh();

                }

            }

            dr.Close();
            dr.Dispose();
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            //PrintDocument pd = new PrintDocument();
            //pd.PrintPage += PrintPage;
            //pd.Print();

            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.Image, 0, 0);
        }
    }
}
