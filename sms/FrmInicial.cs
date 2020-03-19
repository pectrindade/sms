using Atencao_Assistida;
using Atencao_Assistida.Classes.Mysql;
using Atencao_Assistida.Consultas;
using Atencao_Assistida.Forms;
using Atencao_Assistida.Forms.Caftrin;
using Atencao_Assistida.Forms.Odonto;
using Atencao_Assistida.Pesquisas;
using Atencao_Assistida.Relatorios.Estoque_Periodo;
using Atencao_Assistida.Relatorios.PacienteProduto;
using Atencao_Assistida.Relatorios.Previsao_entrega;
using Atencao_Assistida.Relatorios.Requisicao_Periodo;
using Atencao_Assistida.Relatorios.Saida_Periodo;
using System;
using System.Windows.Forms;
using UnidadeMedida = Atencao_Assistida.Forms.UnidadeMedida;

namespace teste1
{
    public partial class FrmInicial : Form
    {
        private int childFormNumber = 0;

        public FrmInicial()
        {
            InitializeComponent();
        }

        private void FrmInicial_Load(object sender, EventArgs e)
        {


            Acesso acesso = new Acesso();
            acesso.ShowDialog();
            VerificaAcesso();

            VerificaData();
        }


        private void VerificaData()
        {
            DateTime date1 = DateTime.Now;
            DateTime date2 = new DateTime(2021, 5, 1, 0, 0, 0);

            int result = DateTime.Compare(date1, date2);

            string relationship;

            if (result < 0)
            {

            }
            else
            {
                AcessoNenhum();
                MessageBox.Show("Entre em Contato com o Desenvolvedor !",
                "INFORMAÇÃO IMPORTANTE",
                MessageBoxButtons.OK);
            }
        }

        private void VerificaAcesso()
        {
            var codigo = Usuario.Codusuario.ToString();
            var Coddepartamento = Usuario.Coddepartamento.ToString();

            if (codigo == "")
            {
                Close();

            }

            if (Coddepartamento == "1")
            {
                MicAtencaoAssit.Visible = false;
                MimAtencaoAssist.Visible = false;
                MirAtencaoAssist.Visible = false;

                Miccaftrin.Visible = false;
                MimCaftrin.Visible = false;

            }
            else if (Coddepartamento == "2")
            {
                MicOdont.Visible = false;
                MimOdont.Visible = false;
                MirOdont.Visible = false;

                Miccaftrin.Visible = false;
                MimCaftrin.Visible = false;

            }
            else if (Coddepartamento == "3")
            {
                MicOdont.Visible = false;
                MimOdont.Visible = false;
                MirOdont.Visible = false;

                MicAtencaoAssit.Visible = false;
                MimAtencaoAssist.Visible = false;
                MirAtencaoAssist.Visible = false;


            }

            AcessoNenhum();
            //AcessoTotal();
            AcessoParcial(int.Parse(codigo));
        }

        private void AcessoNenhum()
        {
            // desabilita todos os menus para que seja feita o controle de acesso 

            #region Cadastro

            MiAtencaoAssitGrupo.Enabled = false;
            MiAtencaoAssitMarca.Enabled = false;
            MiAtencaoAssitUnidadeMedida.Enabled = false;
            MiAtencaoAssitMedicamento.Enabled = false;
            MiAtencaoAssitEspecialidade.Enabled = false;
            MiAtencaoAssitAgenteSaude.Enabled = false;
            MiAtencaoAssitPaciente.Enabled = false;
            MiAtencaoAssitProcesso.Enabled = false;

            MicOdontDepartamento.Enabled = false;
            MicOdontFornecedor.Enabled = false;
            MicOdontUnidades.Enabled = false;
            MicOdontGrupos.Enabled = false;
            MicOdontMarcas.Enabled = false;
            MicOdontProdutos.Enabled = false;
            MicOdontUsuarios.Enabled = false;

            MicCaftrinDepartamento.Enabled = false;
            MicCaftrinFornecedor.Enabled = false;
            MicCaftrinUnidades.Enabled = false;
            MicCaftrinUnidadeMedida.Enabled = false;
            MicCaftrinGrupo.Enabled = false;
            MicCaftrinMarcas.Enabled = false;
            MicCaftrinCfop.Enabled = false;
            MicCaftrinProdutos.Enabled = false;



            #endregion

            #region Movimento

            MimAtencaoAssistEntregaMedicamentos.Enabled = false;
            MimAtencaoAssistVisitasAssistenteSocial.Enabled = false;
            MimAtencaoAssistManutencaoProtocolo.Enabled = false;



            MimCaftrinEntradaMercadoria.Enabled = false;
            MimCaftrinDigitacaoRequisicao.Enabled = false;
            MimCaftrinSaidaMercadoria.Enabled = false;
            MimCaftrinbalanco.Enabled = false;
            MimCaftrinDigitacaoOfício.Enabled = false;
            MimCaftrinSaidaOfício.Enabled = false;

            MimAutoriza.Enabled = false;
            MimCaftrinDevolucao.Enabled = false;


            #endregion

            #region Consultas

            MiconsEstoque.Enabled = false;

            #endregion

            #region Relatorios



            #endregion

            #region Operacional

            MioCadastroUsuarios.Enabled = false;
            MioAcessoUsuarios.Enabled = false;
            MioFechamentoEstoque.Enabled = false;


            #endregion

        }

        private void AcessoParcial(int id)
        {
            tAviso.Enabled = true;

            var dr = Acessos.SelectPermissao(id);
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    var indice = dr.GetString(dr.GetOrdinal("NOMEMENU"));
                    switch (indice)
                    {


                        #region Atencao Assistida

                        //CADASTRO
                        case "Grupo":
                            MiAtencaoAssitGrupo.Enabled = true;
                            break;
                        case "Marca":
                            MiAtencaoAssitMarca.Enabled = true;
                            break;
                        case "Unidade de Medida":
                            MiAtencaoAssitUnidadeMedida.Enabled = true;
                            break;
                        case "Medicamento":
                            MiAtencaoAssitMedicamento.Enabled = true;
                            break;
                        case "Especialidade":
                            MiAtencaoAssitEspecialidade.Enabled = true;
                            break;
                        case "Agente de Saúde":
                            MiAtencaoAssitAgenteSaude.Enabled = true;
                            break;
                        case "Paciente":
                            MiAtencaoAssitPaciente.Enabled = true;
                            break;
                        case "Processo":
                            MiAtencaoAssitProcesso.Enabled = true;
                            break;

                        //MOVIMENTO
                        case "Entrega de Medicamentos":
                            MimAtencaoAssistEntregaMedicamentos.Enabled = true;
                            break;
                        case "Visita Asistente Social":
                            MimAtencaoAssistVisitasAssistenteSocial.Enabled = true;
                            break;
                        case "Manutenção de Protocolo":
                            MimAtencaoAssistManutencaoProtocolo.Enabled = true;
                            break;

                        #endregion

                        #region CAFTRIN

                        //CADASTRO

                        case "tdDepartamento":
                            MicCaftrinDepartamento.Enabled = true;
                            break;
                        case "tdFornecedor":
                            MicCaftrinFornecedor.Enabled = true;
                            break;
                        case "tdUnidade":
                            MicCaftrinUnidades.Enabled = true;
                            break;
                        case "tdUnidadeMedida":
                            MicCaftrinUnidadeMedida.Enabled = true;
                            break;
                        case "tdGrupo":
                            MicCaftrinGrupo.Enabled = true;
                            break;
                        case "tdMarcas":
                            MicCaftrinMarcas.Enabled = true;
                            break;
                        case "tdCfop":
                            MicCaftrinCfop.Enabled = true;
                            break;
                        case "tdProdutos":
                            MicCaftrinProdutos.Enabled = true;
                            break;

                        //CONSULTAS
                        case "tdConsEstoque":
                            MiconsEstoque.Enabled = true;
                            break;

                        //MOVIMENTO
                        case "tdEntrada":
                            MimCaftrinEntradaMercadoria.Enabled = true;
                            break;
                        case "tdSaida":
                            MimCaftrinSaidaMercadoria.Enabled = true;
                            break;
                        case "tdPedidos":
                            MimCaftrinDigitacaoRequisicao.Enabled = true;
                            break;
                        case "tdBalanco":
                            MimCaftrinbalanco.Enabled = true;
                            break;
                        case "tdDigitacaoOficio":
                            MimCaftrinDigitacaoOfício.Enabled = true;
                            break;
                        case "tdSaidaOficio":
                            MimCaftrinSaidaOfício.Enabled = true;
                            break;
                        case "tdAutoriza":
                            MimAutoriza.Enabled = true;
                            break;
                        case "tdDevolve":
                            MimCaftrinDevolucao.Enabled = true;
                            break;

                        //OPERACIONAL
                        case "tdUsuario":
                            MioCadastroUsuarios.Enabled = true;
                            break;
                        case "tdAcesso":
                            MioAcessoUsuarios.Enabled = true;
                            break;
                        case "tdFechaEstoque":
                            MioFechamentoEstoque.Enabled = true;
                            break;

                            #endregion

                        #region Operacional

                            //case "tdUsuario":
                            //    MioCadastroUsuarios.Enabled = true;
                            //    break;
                            //case "Acesso de Usuário":
                            //    MioAcessoUsuarios.Enabled = true;
                            //    break;

                            #endregion
                    }


                }
            }
            dr.Dispose();
            dr.Close();

        }

        private void AcessoTotal()
        {

            #region Cadastro

            MiAtencaoAssitGrupo.Enabled = true;
            MiAtencaoAssitMarca.Enabled = true;
            MiAtencaoAssitUnidadeMedida.Enabled = true;
            MiAtencaoAssitMedicamento.Enabled = true;
            MiAtencaoAssitEspecialidade.Enabled = true;
            MiAtencaoAssitAgenteSaude.Enabled = true;
            MiAtencaoAssitPaciente.Enabled = true;
            MiAtencaoAssitProcesso.Enabled = true;

            MicOdontDepartamento.Enabled = true;
            MicOdontFornecedor.Enabled = true;
            MicOdontUnidades.Enabled = true;
            MicOdontGrupos.Enabled = true;
            MicOdontMarcas.Enabled = true;
            MicOdontProdutos.Enabled = true;
            MicOdontUsuarios.Enabled = true;

            MicCaftrinDepartamento.Enabled = true;
            MicCaftrinFornecedor.Enabled = true;
            MicCaftrinUnidades.Enabled = true;
            MicCaftrinGrupo.Enabled = true;
            MicCaftrinMarcas.Enabled = true;
            MicCaftrinCfop.Enabled = true;
            MicCaftrinProdutos.Enabled = true;

            #endregion

            #region Movimento

            MimAtencaoAssistEntregaMedicamentos.Enabled = true;
            MimAtencaoAssistVisitasAssistenteSocial.Enabled = true;
            MimAtencaoAssistManutencaoProtocolo.Enabled = true;

            MimCaftrinEntradaMercadoria.Enabled = true;
            MimCaftrinDigitacaoRequisicao.Enabled = true;
            MimCaftrinSaidaMercadoria.Enabled = true;
            MimCaftrinDevolucao.Enabled = true;

            #endregion

            #region Consultas



            #endregion

            #region Relatorios



            #endregion

            #region Operacional

            MioCadastroUsuarios.Enabled = true;
            MioAcessoUsuarios.Enabled = true;


            #endregion
        }

        private void OpenFile(object sender, EventArgs e)
        {

        }

        public void AbrePesquisaPaciente()
        {

            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is PesquisaPaciente
                )
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new PesquisaPaciente();
                tela.MdiParent = this;
                tela.Show();
            }

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MenuItemcadastroUsuarios_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Usuarios)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Usuarios();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MenuItemSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItemEntregaMedicamento_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemVistas_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemacessoUsuarios_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Forms.AcessoUsuarios)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Forms.AcessoUsuarios();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuItemprevisaodeEntrega_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Previsao_Entrega)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Previsao_Entrega();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void pacientePorProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is PacienteProduto)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new PacienteProduto();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void saidaMercadoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is SaidaMercadoria)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new SaidaMercadoria();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MiAtencaoAssitGrupo_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Forms.Grupo)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Forms.Grupo();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MiAtencaoAssitMarca_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Forms.Marca)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Forms.Marca();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MiAtencaoAssitUnidadeMedida_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is UnidadeMedida)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new UnidadeMedida();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MiAtencaoAssitMedicamento_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Medicamentos)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Medicamentos();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MiAtencaoAssitEspecialidade_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Forms.Especialidade)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Forms.Especialidade();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MiAtencaoAssitAgenteSaude_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Forms.Agente)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Forms.Agente();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MiAtencaoAssitPaciente_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Paciente)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form Equipamento = new Paciente();
                Equipamento.MdiParent = this;
                Equipamento.Show();
            }
        }

        private void MiAtencaoAssitProcesso_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Processo)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form Equipamento = new Processo();
                Equipamento.MdiParent = this;
                Equipamento.Show();
            }
        }

        private void MiOdontologiaDepartamento_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Forms.Departamento)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Forms.Departamento();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MiOdontologiaFornecedor_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Forms.Odonto.Fornecedor)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Forms.Odonto.Fornecedor();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MiOdontologiaUnidades_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Unidades)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Unidades();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MiOdontologiaGrupos_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Forms.Grupo)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Forms.Grupo();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MiOdontologiaMarcas_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Forms.Marca)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Forms.Marca();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MiOdontologiaProdutos_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Produtos)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Produtos();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MiOdontologiaUsuarios_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Forms.Cfop)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Forms.Cfop();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MimAtencaoAssistEntregaMedicamentos_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is EntregaMedicamentos)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new EntregaMedicamentos();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MimAtencaoAssistVisitasAssistenteSocial_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Forms.Visitas)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Forms.Visitas();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MimAtencaoAssistManutencaoProtocolo_Click(object sender, EventArgs e)
        {

        }

        private void MirAtencaoAssistPrevisaoEntrega_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Previsao_Entrega)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Previsao_Entrega();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MirAtencaoAssistPacienteProdutos_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is PacienteProduto)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new PacienteProduto();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MimOdontEntradaMercadoria_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is EntradaMercadoria)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new EntradaMercadoria();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MicCaftrinDepartamento_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Forms.Departamento)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Forms.Departamento();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MicCaftrinFornecedor_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Forms.Odonto.Fornecedor)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Forms.Odonto.Fornecedor();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MicCaftrinUnidades_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Unidades)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Unidades();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MicCaftrinGrupo_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Forms.Grupo)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Forms.Grupo();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MicCaftrinMarcas_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Forms.Marca)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Forms.Marca();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MicCaftrinCfop_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Forms.Cfop)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Forms.Cfop();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MicCaftrinProdutos_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Produtos)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Produtos();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MimCaftrinEntradaMercadoria_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is EntradaMercadoria)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new EntradaMercadoria();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MimCaftrinDigitacaoRequisicao_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Requisicao)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Requisicao();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MimCaftrinSaidaMercadoria_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is SaidaMercadoria)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new SaidaMercadoria();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void balançoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Balanço)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Balanço();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void fechamentoDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is FechamentoEstoque)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new FechamentoEstoque();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MicCaftrinUnidadeMedida_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is UnidadeMedida)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new UnidadeMedida();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void digitaçãoDeOfícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Oficio)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Oficio();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void saidaDeOfícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is SaidaOficio)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new SaidaOficio();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void autorizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Autoriza)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Autoriza();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Atencao_Assistida.Consultas.Estoque)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Atencao_Assistida.Consultas.Estoque();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void tAviso_Tick(object sender, EventArgs e)
        {
            AvisaOficio();
        }

        private void AvisaOficio()
        {
            var retorno = Avisos.TemAcessoOficio(int.Parse(Usuario.Codusuario));
            if (retorno != "")
            {
                // tipo = 1 - Oficicio, s 
                retorno = Avisos.TemOficio(int.Parse(Usuario.Codempresa), int.Parse(Usuario.Coddepartamento), 0, 1, "ABERTO");

                if (retorno != "")
                {
                    tAviso.Interval = tAviso.Interval + 5000;

                    if (Usuario.Login == "renato") { return; }
                    if (Usuario.Login == "R. DIEGO") { return; }
                    if (Usuario.Login == "Administra") { return; }

                    bool open = false;
                    foreach (Form form in this.MdiChildren)
                    {
                        if (form is AvisoReqOfc)
                        {
                            form.BringToFront();
                            open = true;
                        }
                    }
                    if (!open)
                    {
                        Form tela = new AvisoReqOfc();
                        tela.MdiParent = this;
                        tela.Show();
                    }
                    
                }

            }

        }

        private void AvisaAutoriza()
        {


        }

        private void MimCaftrinDevolucao_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is TrocaDevolucao)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new TrocaDevolucao();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MiCafSaidaMercadoria_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Chama_RelSaida)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Chama_RelSaida();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MiconsSaldo_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Saldo)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Saldo();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MimCaftrinAjusteEstoque_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is AjusteEstoque)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new AjusteEstoque();
                tela.MdiParent = this;
                tela.Show();
            }

        }

        private void MiCafPedidosPeríodo_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Chama_RelRequisicao)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Chama_RelRequisicao();
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void MiCafEstoque_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is Chama_RelEstoque)
                {
                    form.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form tela = new Chama_RelEstoque();
                tela.MdiParent = this;
                tela.Show();
            }
        }
    }
}
