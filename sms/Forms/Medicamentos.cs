﻿using Atencao_Assistida.Classes.Funcoes;
using Atencao_Assistida.Pesquisas;
using Atencao_Assistida.Relatorios.Produto;
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
    public partial class Medicamentos : Form
    {
        public Medicamentos()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            Close();
        }

        private void Medicamentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {
                LimpaTela();
                        
                CarregaCmbUnidadeMedida();
                CarregaCmbGrupo();
                CarregaCmbMarca();

        }

        private void CarregaCmbUnidadeMedida()
        {
            int codigo;
            string nome;


            cmbUnidaemedida.Items.Clear();


            cmbUnidaemedida.Items.Insert(0, "--SELECIONE--");

            var dr = Classes.Mysql.UnidadeMedida.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    codigo = int.Parse(dr.GetString(dr.GetOrdinal("CODUNIDADEMEDIDA")));
                    nome = dr.GetString(dr.GetOrdinal("DESCRICAO"));

                    cmbUnidaemedida.Items.Insert(codigo, nome);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void CarregaCmbGrupo()
        {
            int codigo;
            string nome;


            cmbgrupo.Items.Clear();


            cmbgrupo.Items.Insert(0, "--SELECIONE--");

            var dr = Classes.Mysql.Grupo.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    codigo = int.Parse(dr.GetString(dr.GetOrdinal("CODGRUPO")));
                    nome = dr.GetString(dr.GetOrdinal("DESCRICAO"));

                    cmbgrupo.Items.Insert(codigo, nome);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void CarregaCmbMarca()
        {
            int codigo;
            string nome;


            cmbmarca.Items.Clear();


            cmbmarca.Items.Insert(0, "--SELECIONE--");

            var dr = Classes.Mysql.Marca.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    codigo = int.Parse(dr.GetString(dr.GetOrdinal("CODMARCA")));
                    nome = dr.GetString(dr.GetOrdinal("DESCRICAO"));

                    cmbmarca.Items.Insert(codigo, nome);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void btnBuscaProduto_Click(object sender, EventArgs e)
        {
            Parametros.Form = "Medicamentos";
            Parametros.Valor = "";

            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaPaciente")
                {
                    if (form is PesquisaProdutos)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {
                Form tela = new PesquisaProdutos();
                //tela.MdiParent = this.MdiParent;
                tela.ShowDialog();
                RetornoPesquisaMedicamento();
            }
        }

        public void RetornoPesquisaMedicamento()
        {
            if (Parametros.Valor != "")
            {
                BuscaProduto(int.Parse(Parametros.Valor));
            }
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Trim() != "")
            {
                BuscaProduto(int.Parse(txtcodigo.Text));
            }
        }

        private void BuscaProduto(int codigo)
        {

           var dr = Classes.Mysql.Produto.Select(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtcodigo.Text = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    txtNome.Text = dr.GetString(dr.GetOrdinal("NOME"));

                    CarregaCmbUnidadeMedida();
                    cmbUnidaemedida.SelectedIndex = dr.GetInt32(dr.GetOrdinal("CODUNIDADE"));

                    CarregaCmbGrupo();
                    cmbgrupo.SelectedIndex =  dr.GetInt32(dr.GetOrdinal("CODGRUPO"));

                    CarregaCmbMarca();
                    cmbmarca.SelectedIndex =  dr.GetInt32(dr.GetOrdinal("CODMARCA"));

                    cmbativo.Text = dr.GetString(dr.GetOrdinal("ATIVO"));

                }

            }

            dr.Close();
            dr.Dispose();

            txtNome.Focus();
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {

            LimpaTela();

        }

        private void LimpaTela()
        {
            txtcodigo.Text = "";
            txtNome.Text = "";
            cmbUnidaemedida.Text = "";
            cmbgrupo.Text = "";
            cmbmarca.Text = "";
            cmbativo.Text = "";

            txtcodigo.Focus();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
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

        private void Gravar(bool novo, int codigo)
        {
            var hoje = DateTime.Now;

            var cod = txtcodigo.Text.Trim();
            var nome = txtNome.Text.Trim();
            var unidademedida = cmbUnidaemedida.SelectedIndex.ToString();
            var grupo = cmbgrupo.SelectedIndex.ToString();
            var marca = cmbmarca.SelectedIndex.ToString();
            var ativo = cmbativo.SelectedIndex.ToString();

            var respinclusao = Usuario.Nomeusuario.ToString();
            var datainclusao = hoje.ToString();
            var respalteracao = Usuario.Nomeusuario.ToString();
            var dataalteracao = hoje.ToString();
            var excluido = "N";
            var coddepartamento = Usuario.Coddepartamento.ToString();

            try
            {
                var m = new Classes.Mysql.Produto(int.Parse(cod), nome, nome, unidademedida, grupo, marca, ativo,
                    respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao, excluido, int.Parse(coddepartamento));
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

            LimpaTela();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Relatorio();
        }

        private void Relatorio()
        {
            var cria = new CriaArquivo();
            cria.Cria_Produtos();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Produto.SelectRel();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    
                    var cod = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    var nome = dr.GetString(dr.GetOrdinal("NOME"));
                    var descricao = dr.GetString(dr.GetOrdinal("DESCRICAO"));

                    var coddepartamento = dr.GetInt32(dr.GetOrdinal("CODDEPARTAMENTO"));
                    var nomedepartamento = dr.GetString(dr.GetOrdinal("NOMEDEPARTAMENTO"));

                    var codgrupo = dr.GetInt32(dr.GetOrdinal("CODGRUPO"));
                    var grupo = Utilidades.BuscaGrupo(dr.GetInt32(dr.GetOrdinal("CODGRUPO")));

                    var codmarca = dr.GetInt32(dr.GetOrdinal("CODMARCA"));
                    var marca = Utilidades.BuscaMarca(dr.GetInt32(dr.GetOrdinal("CODMARCA")));

                    var unidademedida = Utilidades.BuscaUnidadeMedida(int.Parse(dr.GetString(dr.GetOrdinal("UNIDADE"))));
                   
                    var respinclusao = "";
                    var datainclusao = "";
                    var respalteracao = "";
                    var dataalteracao = "";
                    
                    


                    try
                    {
                        var m = new Classes.Mysql.Produto();

                        m.InsertAccess(int.Parse(cod), nome, descricao, coddepartamento, nomedepartamento, codgrupo, grupo, codmarca, marca, unidademedida,
                            respinclusao.ToString(), datainclusao, respalteracao.ToString(), dataalteracao);
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
                if (form is RelProdutos)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelProdutos();
                tela.ShowDialog();
            }

        }

        private void Medicamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {

                if (ActiveControl.Name == "txtcodigo") { btnBuscaProduto.PerformClick(); return; }


            }
        }
    }
}
