﻿using Atencao_Assistida.Classes.Mysql;
using Atencao_Assistida.Pesquisas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Relatorios.Requisicao_Periodo
{
    public partial class Chama_RelRequisicao : Form
    {
        public Chama_RelRequisicao()
        {
            InitializeComponent();
        }

        private void Chama_RelRequisicao_Load(object sender, EventArgs e)
        {
            CarregaCmbEmpresa();
            CarregaCmbDepartamento();

        }

        private void CarregaCmbEmpresa()
        {
            int codigo;
            string nome;


            cmbEmpresa.Items.Clear();

            cmbEmpresa.Items.Insert(0, "--SELECIONE--");

            var dr = Empresa.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    codigo = int.Parse(dr.GetString(dr.GetOrdinal("CODEMPRESA")));
                    nome = dr.GetString(dr.GetOrdinal("NOME"));

                    cmbEmpresa.Items.Insert(codigo, nome);
                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void CarregaCmbDepartamento()
        {
            int codigo;
            string nome;

            cmbDepartamento.Items.Clear();

            cmbDepartamento.Items.Insert(0, "--SELECIONE--");

            var dr = Classes.Mysql.Departamento.SelectTudo();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    codigo = int.Parse(dr.GetString(dr.GetOrdinal("CODDEPARTAMENTO")));
                    nome = dr.GetString(dr.GetOrdinal("NOME"));

                    cmbDepartamento.Items.Insert(codigo, nome);
                }

            }

            dr.Close();
            dr.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarRelatorio();
        }

        private void CarregarRelatorio()
        {
            try
            {
                System.Threading.Thread tFormAguarde = new System.Threading.Thread(new System.Threading.ThreadStart(CarregaFormAguarde));
                tFormAguarde.Start();

                Relatorio();


                tFormAguarde.Abort();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CarregaFormAguarde()
        {
            Form f = new Forms.Espera();
            f.ShowDialog();
        }

        private void Relatorio()
        {

            DateTime dtInicial = Convert.ToDateTime(txtDataInicial.Text.Trim());
            string DataInicial = dtInicial.Year.ToString() + "-" + dtInicial.Month.ToString() + "-" + dtInicial.Day.ToString();

            DateTime dtFinal = Convert.ToDateTime(txtDataFinal.Text.Trim());
            string DataFinal = dtFinal.Year.ToString() + "-" + dtFinal.Month.ToString() + "-" + dtFinal.Day.ToString();

            var codempresa = 0;
            var nomeempresa = "";
            var coddepartamento = 0;
            var nomedepartamento = "";
            var codunidade = 0;
            var nomeunidade = "";
            var tipo = 0; // 0 é rquisiação, 1 é oficio
            var codpedido = 0;
            var solicitante = "";
            var numeropedido = "";
            var codproduto = 0;
            var nomeproduto = "";
            var quantidade = "";
            var datapedido = "";
            var status = "";

            if (txtCodUnidade.Text.Trim() != "") { codunidade = int.Parse(txtCodUnidade.Text.Trim()); }
            if (txtcodigo.Text.Trim() != "") { codproduto = int.Parse(txtcodigo.Text.Trim()); }

            var cria = new Classes.Funcoes.CriaArquivo();
            cria.Cria_PedidoPeriodo();

            // BUSCA E GRAVA NO REPOSITORIO
            var dr = Classes.Mysql.Pedido.SelectPedido(cmbEmpresa.SelectedIndex, cmbDepartamento.SelectedIndex, codunidade, codproduto, tipo, DataInicial, DataFinal);

            if (dr.HasRows)
            {
                while (dr.Read())
                {


                    if (!dr.IsDBNull(dr.GetOrdinal("CODEMPRESA"))) { codempresa = dr.GetInt32(dr.GetOrdinal("CODEMPRESA")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEEMPRESA"))) { nomeempresa = dr.GetString(dr.GetOrdinal("NOMEEMPRESA")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("CODDEPARTAMENTO"))) { coddepartamento = dr.GetInt32(dr.GetOrdinal("CODDEPARTAMENTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEDEPARTAMENTO"))) { nomedepartamento = dr.GetString(dr.GetOrdinal("NOMEDEPARTAMENTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("CODUNIDADE"))) { codunidade = dr.GetInt32(dr.GetOrdinal("CODUNIDADE")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEUNIDADE"))) { nomeunidade = dr.GetString(dr.GetOrdinal("NOMEUNIDADE")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("TIPO"))) { tipo = dr.GetInt32(dr.GetOrdinal("TIPO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("CODPEDIDO"))) { codpedido = dr.GetInt32(dr.GetOrdinal("CODPEDIDO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("SOLICITANTE"))) { solicitante = dr.GetString(dr.GetOrdinal("SOLICITANTE")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NUMEROPEDIDO"))) { numeropedido = dr.GetString(dr.GetOrdinal("NUMEROPEDIDO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("CODPRODUTO"))) { codproduto = dr.GetInt32(dr.GetOrdinal("CODPRODUTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("NOMEPRODUTO"))) { nomeproduto = dr.GetString(dr.GetOrdinal("NOMEPRODUTO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("QUANTIDADE"))) { quantidade = dr.GetString(dr.GetOrdinal("QUANTIDADE")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("DATAPEDIDO"))) { datapedido = dr.GetString(dr.GetOrdinal("DATAPEDIDO")); }
                    if (!dr.IsDBNull(dr.GetOrdinal("STATUS"))) { status = dr.GetString(dr.GetOrdinal("STATUS")); }


                    try
                    {
                        var m = new Classes.Mysql.Pedido();

                        m.InsertAccessPedidoPeriodo(codempresa, nomeempresa, coddepartamento, nomedepartamento, codunidade, nomeunidade, tipo,
                        codpedido, solicitante, numeropedido, codproduto, nomeproduto, quantidade, datapedido, status);
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
                if (form is RelRequisicaoPeriodo)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new RelRequisicaoPeriodo();
                tela.ShowDialog();
            }

        }

        private void txtCodUnidade_Leave(object sender, EventArgs e)
        {
            if (txtCodUnidade.Text.Trim() != "")
            {
                BuscaUnidades();
            }
            else
            {
                txtNomeUnidade.Text = "";
            }
        }

        private void btnBuscaUnidade_Click(object sender, EventArgs e)
        {

            txtCodUnidade.Text = "";
            txtNomeUnidade.Text = "";
            bool open = false;
            foreach (Form form in Application.OpenForms)
            {

                // Verifica se o form esta aberto
                if (form.Name == "PesquisaUnidade")
                {
                    if (form is PesquisaUnidade)
                    {
                        form.BringToFront();
                        open = true;
                    }

                }
            }

            if (!open)
            {

                Form tela = new PesquisaUnidade();

                tela.ShowDialog();
                RetornoPesquisaUnidade();

            }
        }

        private void RetornoPesquisaUnidade()
        {
            if (Parametros.Valor != "")
            {
                txtCodUnidade.Text = Parametros.Valor;
                BuscaUnidades();
            }

        }

        private void BuscaUnidades()
        {
            var dr = Unidade.Select(int.Parse(txtCodUnidade.Text));

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtCodUnidade.Text = dr.GetString(dr.GetOrdinal("CODUNIDADE"));
                    txtNomeUnidade.Text = dr.GetString(dr.GetOrdinal("NOME"));

                }

            }

            dr.Close();
            dr.Dispose();

        }

        private void Chama_Relrequisicao_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Chama_Relrequisicao_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;

            this.txtDataInicial.Text = date.ToString("dd/MM/yyyy");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker2.Value;

            this.txtDataFinal.Text = date.ToString("dd/MM/yyyy");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Trim() != "")
            {
                BuscaProduto(int.Parse(txtcodigo.Text));
            }
            else
            {
                txtNome.Text = "";
            }
        }

        private void BuscaProduto(int codigo)
        {
            var cod1 = Usuario.Coddepartamento;

            var dr = Classes.Mysql.Produto.Select(codigo);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtcodigo.Text = dr.GetString(dr.GetOrdinal("CODPRODUTO"));
                    txtNome.Text = dr.GetString(dr.GetOrdinal("NOME"));
                }

            }

            dr.Close();
            dr.Dispose();

            txtNome.Focus();
        }

        private void btnBuscaProduto_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtNome.Text = "";

            Parametros.Form = "Produtos";
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

        private void btnDesfaz_Click(object sender, EventArgs e)
        {
            CarregaCmbEmpresa();
            CarregaCmbDepartamento();
            txtCodUnidade.Text = "";
            txtNomeUnidade.Text = "";
            txtcodigo.Text = "";
            txtNome.Text = "";
            txtDataInicial.Text = "";
            txtDataFinal.Text = "";

            cmbEmpresa.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread tFormAguarde = new System.Threading.Thread(new System.Threading.ThreadStart(CarregaFormAguarde));
            tFormAguarde.Start();
        }
    }
}
