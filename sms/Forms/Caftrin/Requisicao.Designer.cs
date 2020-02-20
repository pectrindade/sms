namespace Atencao_Assistida.Forms.Caftrin
{
    partial class Requisicao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtdataPedido = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscaRequisicao = new System.Windows.Forms.Button();
            this.txtnomeSolicitante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscaProduto = new System.Windows.Forms.Button();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueubs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnBuscaUnidade = new System.Windows.Forms.Button();
            this.txtCodUnidade = new System.Windows.Forms.TextBox();
            this.txtNomeUnidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtestoqueubs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdataPedido
            // 
            this.txtdataPedido.Location = new System.Drawing.Point(206, 35);
            this.txtdataPedido.Mask = "00/00/0000";
            this.txtdataPedido.Name = "txtdataPedido";
            this.txtdataPedido.Size = new System.Drawing.Size(82, 20);
            this.txtdataPedido.TabIndex = 1;
            this.txtdataPedido.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(203, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 225;
            this.label8.Text = "Dt. Requisição";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(21, 20);
            this.dateTimePicker1.TabIndex = 223;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Location = new System.Drawing.Point(12, 35);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(136, 20);
            this.txtNumeroPedido.TabIndex = 0;
            this.txtNumeroPedido.Leave += new System.EventHandler(this.txtNumeroPedido_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 222;
            this.label1.Text = "Nº Requisição";
            // 
            // btnBuscaRequisicao
            // 
            this.btnBuscaRequisicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaRequisicao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaRequisicao.Location = new System.Drawing.Point(154, 35);
            this.btnBuscaRequisicao.Name = "btnBuscaRequisicao";
            this.btnBuscaRequisicao.Size = new System.Drawing.Size(25, 23);
            this.btnBuscaRequisicao.TabIndex = 221;
            this.btnBuscaRequisicao.TabStop = false;
            this.btnBuscaRequisicao.Text = "...";
            this.btnBuscaRequisicao.UseVisualStyleBackColor = true;
            this.btnBuscaRequisicao.Click += new System.EventHandler(this.btnBuscaRequisicao_Click);
            // 
            // txtnomeSolicitante
            // 
            this.txtnomeSolicitante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnomeSolicitante.Location = new System.Drawing.Point(12, 80);
            this.txtnomeSolicitante.Name = "txtnomeSolicitante";
            this.txtnomeSolicitante.Size = new System.Drawing.Size(422, 20);
            this.txtnomeSolicitante.TabIndex = 2;
            this.txtnomeSolicitante.Enter += new System.EventHandler(this.txtnomeSolicitante_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 229;
            this.label3.Text = "Solicitante";
            // 
            // btnBuscaProduto
            // 
            this.btnBuscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaProduto.Location = new System.Drawing.Point(86, 184);
            this.btnBuscaProduto.Name = "btnBuscaProduto";
            this.btnBuscaProduto.Size = new System.Drawing.Size(25, 21);
            this.btnBuscaProduto.TabIndex = 235;
            this.btnBuscaProduto.TabStop = false;
            this.btnBuscaProduto.Text = "...";
            this.btnBuscaProduto.UseVisualStyleBackColor = true;
            this.btnBuscaProduto.Click += new System.EventHandler(this.btnBuscaProduto_Click);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(12, 184);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(68, 20);
            this.txtCodProduto.TabIndex = 4;
            this.txtCodProduto.Enter += new System.EventHandler(this.txtCodProduto_Enter);
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(115, 184);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(319, 20);
            this.txtNomeProduto.TabIndex = 6;
            this.txtNomeProduto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(16, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 233;
            this.label2.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(112, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 234;
            this.label5.Text = "Nome";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(440, 184);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(68, 20);
            this.txtQuantidade.TabIndex = 5;
            this.txtQuantidade.Enter += new System.EventHandler(this.txtQuantidade_Enter);
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToOrderColumns = true;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.quantidade,
            this.estoqueubs});
            this.Grid.Location = new System.Drawing.Point(12, 210);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersVisible = false;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(576, 226);
            this.Grid.TabIndex = 237;
            this.Grid.TabStop = false;
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 65;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 360;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Solicitado";
            this.quantidade.Name = "quantidade";
            this.quantidade.Width = 80;
            // 
            // estoqueubs
            // 
            this.estoqueubs.HeaderText = "Estoque";
            this.estoqueubs.Name = "estoqueubs";
            this.estoqueubs.Width = 60;
            // 
            // btnListar
            // 
            this.btnListar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListar.Location = new System.Drawing.Point(440, 457);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(59, 23);
            this.btnListar.TabIndex = 241;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDesfazer.Location = new System.Drawing.Point(356, 457);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(59, 23);
            this.btnDesfazer.TabIndex = 240;
            this.btnDesfazer.Text = "Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExcluir.Location = new System.Drawing.Point(267, 457);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(59, 23);
            this.BtnExcluir.TabIndex = 239;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGravar.Location = new System.Drawing.Point(177, 457);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(59, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(91, 457);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(59, 23);
            this.btnFechar.TabIndex = 242;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnBuscaUnidade
            // 
            this.btnBuscaUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaUnidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaUnidade.Location = new System.Drawing.Point(86, 132);
            this.btnBuscaUnidade.Name = "btnBuscaUnidade";
            this.btnBuscaUnidade.Size = new System.Drawing.Size(25, 21);
            this.btnBuscaUnidade.TabIndex = 247;
            this.btnBuscaUnidade.TabStop = false;
            this.btnBuscaUnidade.Text = "...";
            this.btnBuscaUnidade.UseVisualStyleBackColor = true;
            this.btnBuscaUnidade.Click += new System.EventHandler(this.btnBuscaUnidade_Click);
            // 
            // txtCodUnidade
            // 
            this.txtCodUnidade.Location = new System.Drawing.Point(12, 132);
            this.txtCodUnidade.Name = "txtCodUnidade";
            this.txtCodUnidade.Size = new System.Drawing.Size(68, 20);
            this.txtCodUnidade.TabIndex = 3;
            this.txtCodUnidade.Enter += new System.EventHandler(this.txtCodUnidade_Enter);
            this.txtCodUnidade.Leave += new System.EventHandler(this.txtCodUnidade_Leave);
            // 
            // txtNomeUnidade
            // 
            this.txtNomeUnidade.Location = new System.Drawing.Point(115, 132);
            this.txtNomeUnidade.Name = "txtNomeUnidade";
            this.txtNomeUnidade.ReadOnly = true;
            this.txtNomeUnidade.Size = new System.Drawing.Size(319, 20);
            this.txtNomeUnidade.TabIndex = 4;
            this.txtNomeUnidade.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(16, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 245;
            this.label6.Text = "Código";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(112, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 246;
            this.label7.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(474, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(50, 20);
            this.txtCodigo.TabIndex = 248;
            this.txtCodigo.Text = "0";
            this.txtCodigo.Visible = false;
            // 
            // txtestoqueubs
            // 
            this.txtestoqueubs.Location = new System.Drawing.Point(521, 184);
            this.txtestoqueubs.Name = "txtestoqueubs";
            this.txtestoqueubs.Size = new System.Drawing.Size(53, 20);
            this.txtestoqueubs.TabIndex = 6;
            this.txtestoqueubs.Leave += new System.EventHandler(this.txtestoqueubs_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(446, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 250;
            this.label4.Text = "Solicitado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(513, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 251;
            this.label9.Text = "Estoque Ubs";
            // 
            // Requisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(604, 492);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtestoqueubs);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnBuscaUnidade);
            this.Controls.Add(this.txtCodUnidade);
            this.Controls.Add(this.txtNomeUnidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnDesfazer);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.btnBuscaProduto);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnomeSolicitante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdataPedido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNumeroPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscaRequisicao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Requisicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requisicao";
            this.Load += new System.EventHandler(this.Requisicao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Requisicao_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Requisicao_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtdataPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscaRequisicao;
        private System.Windows.Forms.TextBox txtnomeSolicitante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscaProduto;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnBuscaUnidade;
        private System.Windows.Forms.TextBox txtCodUnidade;
        private System.Windows.Forms.TextBox txtNomeUnidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtestoqueubs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueubs;
    }
}