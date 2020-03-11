namespace Atencao_Assistida.Forms
{
    partial class Balanço
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdtBalanco = new System.Windows.Forms.MaskedTextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnBuscaProduto = new System.Windows.Forms.Button();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtunidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker1.TabIndex = 41;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Dt. Balanço";
            // 
            // txtdtBalanco
            // 
            this.txtdtBalanco.Location = new System.Drawing.Point(12, 24);
            this.txtdtBalanco.Mask = "00/00/0000";
            this.txtdtBalanco.Name = "txtdtBalanco";
            this.txtdtBalanco.Size = new System.Drawing.Size(79, 20);
            this.txtdtBalanco.TabIndex = 0;
            this.txtdtBalanco.ValidatingType = typeof(System.DateTime);
            this.txtdtBalanco.Leave += new System.EventHandler(this.txtdtBalanco_Leave);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(678, 69);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(68, 20);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // btnBuscaProduto
            // 
            this.btnBuscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaProduto.Location = new System.Drawing.Point(86, 69);
            this.btnBuscaProduto.Name = "btnBuscaProduto";
            this.btnBuscaProduto.Size = new System.Drawing.Size(25, 21);
            this.btnBuscaProduto.TabIndex = 255;
            this.btnBuscaProduto.TabStop = false;
            this.btnBuscaProduto.Text = "...";
            this.btnBuscaProduto.UseVisualStyleBackColor = true;
            this.btnBuscaProduto.Click += new System.EventHandler(this.btnBuscaProduto_Click);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(12, 69);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(68, 20);
            this.txtCodProduto.TabIndex = 1;
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(115, 69);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(457, 20);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 253;
            this.label2.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(112, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 254;
            this.label5.Text = "Nome";
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
            this.unidade,
            this.quantidade});
            this.Grid.Location = new System.Drawing.Point(12, 96);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersVisible = false;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(770, 367);
            this.Grid.TabIndex = 256;
            this.Grid.TabStop = false;
            this.Grid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
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
            this.nome.Width = 500;
            // 
            // unidade
            // 
            this.unidade.HeaderText = "Unidade";
            this.unidade.Name = "unidade";
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // btnListar
            // 
            this.btnListar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListar.Location = new System.Drawing.Point(534, 469);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(59, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDesfazer.Location = new System.Drawing.Point(450, 469);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(59, 23);
            this.btnDesfazer.TabIndex = 6;
            this.btnDesfazer.Text = "Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExcluir.Location = new System.Drawing.Point(361, 469);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(59, 23);
            this.BtnExcluir.TabIndex = 5;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGravar.Location = new System.Drawing.Point(271, 469);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(59, 23);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(185, 469);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(59, 23);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtunidade
            // 
            this.txtunidade.Enabled = false;
            this.txtunidade.Location = new System.Drawing.Point(578, 70);
            this.txtunidade.Name = "txtunidade";
            this.txtunidade.Size = new System.Drawing.Size(81, 20);
            this.txtunidade.TabIndex = 257;
            // 
            // Balanço
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 504);
            this.ControlBox = false;
            this.Controls.Add(this.txtunidade);
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
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdtBalanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Balanço";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balanco";
            this.Load += new System.EventHandler(this.Balanço_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Balanço_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Balanço_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtdtBalanco;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnBuscaProduto;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.TextBox txtunidade;
    }
}