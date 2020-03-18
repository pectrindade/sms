namespace Atencao_Assistida.Forms
{
    partial class AjusteEstoque
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
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnBuscaProduto = new System.Windows.Forms.Button();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdtAjuste = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAddGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(12, 109);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(98, 20);
            this.txtQuantidade.TabIndex = 3;
            // 
            // btnBuscaProduto
            // 
            this.btnBuscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaProduto.Location = new System.Drawing.Point(86, 67);
            this.btnBuscaProduto.Name = "btnBuscaProduto";
            this.btnBuscaProduto.Size = new System.Drawing.Size(25, 21);
            this.btnBuscaProduto.TabIndex = 266;
            this.btnBuscaProduto.TabStop = false;
            this.btnBuscaProduto.Text = "...";
            this.btnBuscaProduto.UseVisualStyleBackColor = true;
            this.btnBuscaProduto.Click += new System.EventHandler(this.btnBuscaProduto_Click);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(12, 67);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(68, 20);
            this.txtCodProduto.TabIndex = 2;
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(115, 67);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(366, 20);
            this.txtNomeProduto.TabIndex = 260;
            this.txtNomeProduto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 264;
            this.label2.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(112, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 265;
            this.label5.Text = "Nome";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(348, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker1.TabIndex = 263;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 262;
            this.label8.Text = "Dt. Ajuste";
            // 
            // txtdtAjuste
            // 
            this.txtdtAjuste.Location = new System.Drawing.Point(270, 24);
            this.txtdtAjuste.Mask = "00/00/0000";
            this.txtdtAjuste.Name = "txtdtAjuste";
            this.txtdtAjuste.Size = new System.Drawing.Size(79, 20);
            this.txtdtAjuste.TabIndex = 1;
            this.txtdtAjuste.ValidatingType = typeof(System.DateTime);
            this.txtdtAjuste.Leave += new System.EventHandler(this.txtdtAjuste_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 268;
            this.label1.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(12, 23);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(238, 21);
            this.cmbDepartamento.TabIndex = 0;
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
            this.motivo});
            this.Grid.Location = new System.Drawing.Point(12, 228);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersVisible = false;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(469, 216);
            this.Grid.TabIndex = 269;
            this.Grid.TabStop = false;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
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
            this.nome.Width = 300;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // motivo
            // 
            this.motivo.HeaderText = "Motivo";
            this.motivo.Name = "motivo";
            this.motivo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 270;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(14, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 272;
            this.label4.Text = "Motivo";
            // 
            // txtMotivo
            // 
            this.txtMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMotivo.Location = new System.Drawing.Point(10, 151);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(352, 55);
            this.txtMotivo.TabIndex = 4;
            // 
            // btnListar
            // 
            this.btnListar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListar.Location = new System.Drawing.Point(385, 462);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(59, 23);
            this.btnListar.TabIndex = 276;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDesfazer.Location = new System.Drawing.Point(301, 462);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(59, 23);
            this.btnDesfazer.TabIndex = 275;
            this.btnDesfazer.Text = "Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExcluir.Location = new System.Drawing.Point(212, 462);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(59, 23);
            this.BtnExcluir.TabIndex = 274;
            this.BtnExcluir.Text = "Autoriza";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGravar.Location = new System.Drawing.Point(122, 462);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(59, 23);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(36, 462);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(59, 23);
            this.btnFechar.TabIndex = 277;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAddGrid
            // 
            this.btnAddGrid.Location = new System.Drawing.Point(385, 161);
            this.btnAddGrid.Name = "btnAddGrid";
            this.btnAddGrid.Size = new System.Drawing.Size(75, 45);
            this.btnAddGrid.TabIndex = 5;
            this.btnAddGrid.Text = "Incluir";
            this.btnAddGrid.UseVisualStyleBackColor = true;
            this.btnAddGrid.Click += new System.EventHandler(this.btnAddGrid_Click);
            // 
            // AjusteEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 497);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddGrid);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnDesfazer);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.btnBuscaProduto);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdtAjuste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AjusteEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuste de Estoque";
            this.Load += new System.EventHandler(this.AjusteEstoque_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AjusteEstoque_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AjusteEstoque_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnBuscaProduto;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtdtAjuste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
        private System.Windows.Forms.Button btnAddGrid;
    }
}