namespace Atencao_Assistida.Forms
{
    partial class Padrao_saida
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
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnBuscaUnidade = new System.Windows.Forms.Button();
            this.txtCodUnidade = new System.Windows.Forms.TextBox();
            this.txtNomeUnidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnBuscaProduto = new System.Windows.Forms.Button();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscaSaidaPadrao = new System.Windows.Forms.Button();
            this.txtdataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.btnAddGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(9, 24);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(61, 20);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.Text = "0";
            this.txtcodigo.Leave += new System.EventHandler(this.txtcodigo_Leave);
            // 
            // btnBuscaUnidade
            // 
            this.btnBuscaUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaUnidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaUnidade.Location = new System.Drawing.Point(83, 73);
            this.btnBuscaUnidade.Name = "btnBuscaUnidade";
            this.btnBuscaUnidade.Size = new System.Drawing.Size(25, 21);
            this.btnBuscaUnidade.TabIndex = 277;
            this.btnBuscaUnidade.TabStop = false;
            this.btnBuscaUnidade.Text = "...";
            this.btnBuscaUnidade.UseVisualStyleBackColor = true;
            this.btnBuscaUnidade.Click += new System.EventHandler(this.btnBuscaUnidade_Click);
            // 
            // txtCodUnidade
            // 
            this.txtCodUnidade.Location = new System.Drawing.Point(9, 73);
            this.txtCodUnidade.Name = "txtCodUnidade";
            this.txtCodUnidade.Size = new System.Drawing.Size(68, 20);
            this.txtCodUnidade.TabIndex = 2;
            this.txtCodUnidade.Leave += new System.EventHandler(this.txtCodUnidade_Leave);
            // 
            // txtNomeUnidade
            // 
            this.txtNomeUnidade.Location = new System.Drawing.Point(112, 73);
            this.txtNomeUnidade.Name = "txtNomeUnidade";
            this.txtNomeUnidade.ReadOnly = true;
            this.txtNomeUnidade.Size = new System.Drawing.Size(319, 20);
            this.txtNomeUnidade.TabIndex = 256;
            this.txtNomeUnidade.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(13, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 275;
            this.label6.Text = "Código";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(109, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 276;
            this.label7.Text = "Nome";
            // 
            // btnListar
            // 
            this.btnListar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListar.Location = new System.Drawing.Point(405, 400);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(59, 23);
            this.btnListar.TabIndex = 273;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDesfazer.Location = new System.Drawing.Point(321, 400);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(59, 23);
            this.btnDesfazer.TabIndex = 272;
            this.btnDesfazer.Text = "Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExcluir.Location = new System.Drawing.Point(232, 400);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(59, 23);
            this.BtnExcluir.TabIndex = 271;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGravar.Location = new System.Drawing.Point(142, 400);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(59, 23);
            this.btnGravar.TabIndex = 261;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(56, 400);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(59, 23);
            this.btnFechar.TabIndex = 274;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(443, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 279;
            this.label4.Text = "Quantidade";
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
            this.quantidade});
            this.Grid.Location = new System.Drawing.Point(9, 151);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersVisible = false;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(513, 226);
            this.Grid.TabIndex = 270;
            this.Grid.TabStop = false;
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
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.Width = 80;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(437, 125);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(68, 20);
            this.txtQuantidade.TabIndex = 4;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // btnBuscaProduto
            // 
            this.btnBuscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaProduto.Location = new System.Drawing.Point(83, 125);
            this.btnBuscaProduto.Name = "btnBuscaProduto";
            this.btnBuscaProduto.Size = new System.Drawing.Size(25, 21);
            this.btnBuscaProduto.TabIndex = 269;
            this.btnBuscaProduto.TabStop = false;
            this.btnBuscaProduto.Text = "...";
            this.btnBuscaProduto.UseVisualStyleBackColor = true;
            this.btnBuscaProduto.Click += new System.EventHandler(this.btnBuscaProduto_Click);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(9, 125);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(68, 20);
            this.txtCodProduto.TabIndex = 3;
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(112, 125);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(319, 20);
            this.txtNomeProduto.TabIndex = 260;
            this.txtNomeProduto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(13, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 267;
            this.label2.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(109, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 268;
            this.label5.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(127, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 265;
            this.label8.Text = "Dt. Cadastro";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(21, 20);
            this.dateTimePicker1.TabIndex = 264;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 263;
            this.label1.Text = "Código";
            // 
            // btnBuscaSaidaPadrao
            // 
            this.btnBuscaSaidaPadrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaSaidaPadrao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaSaidaPadrao.Location = new System.Drawing.Point(76, 21);
            this.btnBuscaSaidaPadrao.Name = "btnBuscaSaidaPadrao";
            this.btnBuscaSaidaPadrao.Size = new System.Drawing.Size(25, 23);
            this.btnBuscaSaidaPadrao.TabIndex = 262;
            this.btnBuscaSaidaPadrao.TabStop = false;
            this.btnBuscaSaidaPadrao.Text = "...";
            this.btnBuscaSaidaPadrao.UseVisualStyleBackColor = true;
            this.btnBuscaSaidaPadrao.Click += new System.EventHandler(this.btnBuscaSaidaPadrao_Click);
            // 
            // txtdataCadastro
            // 
            this.txtdataCadastro.Location = new System.Drawing.Point(130, 24);
            this.txtdataCadastro.Mask = "00/00/0000";
            this.txtdataCadastro.Name = "txtdataCadastro";
            this.txtdataCadastro.Size = new System.Drawing.Size(82, 20);
            this.txtdataCadastro.TabIndex = 1;
            this.txtdataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // btnAddGrid
            // 
            this.btnAddGrid.Location = new System.Drawing.Point(511, 124);
            this.btnAddGrid.Name = "btnAddGrid";
            this.btnAddGrid.Size = new System.Drawing.Size(65, 21);
            this.btnAddGrid.TabIndex = 5;
            this.btnAddGrid.Text = "Incluir";
            this.btnAddGrid.UseVisualStyleBackColor = true;
            this.btnAddGrid.Click += new System.EventHandler(this.btnAddGrid_Click);
            // 
            // Padrao_saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 437);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddGrid);
            this.Controls.Add(this.txtcodigo);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.btnBuscaProduto);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscaSaidaPadrao);
            this.Controls.Add(this.txtdataCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Padrao_saida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padrao de saida";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Padrao_saida_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnBuscaUnidade;
        private System.Windows.Forms.TextBox txtCodUnidade;
        private System.Windows.Forms.TextBox txtNomeUnidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnBuscaProduto;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscaSaidaPadrao;
        private System.Windows.Forms.MaskedTextBox txtdataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.Button btnAddGrid;
    }
}