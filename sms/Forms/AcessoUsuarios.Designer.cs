namespace Atencao_Assistida.Forms
{
    partial class AcessoUsuarios
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
            this.btnProcuraUsuario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbGravar = new System.Windows.Forms.ComboBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gravar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imprimir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcodigoTela = new System.Windows.Forms.TextBox();
            this.btnBuscaTela = new System.Windows.Forms.Button();
            this.txtTela = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbEditar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbExcuir = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbListar = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtmenu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcuraUsuario
            // 
            this.btnProcuraUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProcuraUsuario.Location = new System.Drawing.Point(80, 29);
            this.btnProcuraUsuario.Name = "btnProcuraUsuario";
            this.btnProcuraUsuario.Size = new System.Drawing.Size(25, 23);
            this.btnProcuraUsuario.TabIndex = 189;
            this.btnProcuraUsuario.TabStop = false;
            this.btnProcuraUsuario.UseVisualStyleBackColor = true;
            this.btnProcuraUsuario.Click += new System.EventHandler(this.btnProcuraUsuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 187;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 186;
            this.label1.Text = "Código";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(111, 32);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(270, 20);
            this.txtnome.TabIndex = 185;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(5, 32);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(68, 20);
            this.txtcodigo.TabIndex = 184;
            this.txtcodigo.Text = "0";
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcodigo.Leave += new System.EventHandler(this.txtcodigo_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(393, 80);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 13);
            this.label20.TabIndex = 201;
            this.label20.Text = "Gravar";
            // 
            // cmbGravar
            // 
            this.cmbGravar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGravar.FormattingEnabled = true;
            this.cmbGravar.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cmbGravar.Location = new System.Drawing.Point(391, 96);
            this.cmbGravar.Name = "cmbGravar";
            this.cmbGravar.Size = new System.Drawing.Size(44, 21);
            this.cmbGravar.TabIndex = 192;
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.menu,
            this.nome,
            this.gravar,
            this.editar,
            this.excluir,
            this.imprimir});
            this.Grid.Location = new System.Drawing.Point(6, 135);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(621, 290);
            this.Grid.TabIndex = 195;
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            this.codigo.Width = 65;
            // 
            // menu
            // 
            this.menu.HeaderText = "Menu";
            this.menu.Name = "menu";
            this.menu.ReadOnly = true;
            this.menu.Width = 180;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 210;
            // 
            // gravar
            // 
            this.gravar.HeaderText = "Gravar";
            this.gravar.Name = "gravar";
            this.gravar.ReadOnly = true;
            this.gravar.Width = 55;
            // 
            // editar
            // 
            this.editar.HeaderText = "Editar";
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Width = 55;
            // 
            // excluir
            // 
            this.excluir.HeaderText = "Excluir";
            this.excluir.Name = "excluir";
            this.excluir.ReadOnly = true;
            this.excluir.Width = 55;
            // 
            // imprimir
            // 
            this.imprimir.HeaderText = "Listar";
            this.imprimir.Name = "imprimir";
            this.imprimir.ReadOnly = true;
            this.imprimir.Width = 55;
            // 
            // txtcodigoTela
            // 
            this.txtcodigoTela.Location = new System.Drawing.Point(6, 96);
            this.txtcodigoTela.Name = "txtcodigoTela";
            this.txtcodigoTela.Size = new System.Drawing.Size(67, 20);
            this.txtcodigoTela.TabIndex = 190;
            this.txtcodigoTela.Leave += new System.EventHandler(this.txtcodigoTela_Leave);
            // 
            // btnBuscaTela
            // 
            this.btnBuscaTela.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaTela.Location = new System.Drawing.Point(80, 94);
            this.btnBuscaTela.Name = "btnBuscaTela";
            this.btnBuscaTela.Size = new System.Drawing.Size(25, 23);
            this.btnBuscaTela.TabIndex = 196;
            this.btnBuscaTela.TabStop = false;
            this.btnBuscaTela.UseVisualStyleBackColor = true;
            this.btnBuscaTela.Click += new System.EventHandler(this.btnBuscaTela_Click);
            // 
            // txtTela
            // 
            this.txtTela.Location = new System.Drawing.Point(111, 97);
            this.txtTela.Name = "txtTela";
            this.txtTela.Size = new System.Drawing.Size(270, 20);
            this.txtTela.TabIndex = 191;
            this.txtTela.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(111, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 198;
            this.label5.Text = "Tela";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(8, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 197;
            this.label3.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(448, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 203;
            this.label4.Text = "Editar";
            // 
            // CmbEditar
            // 
            this.CmbEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEditar.FormattingEnabled = true;
            this.CmbEditar.Items.AddRange(new object[] {
            "S",
            "N"});
            this.CmbEditar.Location = new System.Drawing.Point(446, 96);
            this.CmbEditar.Name = "CmbEditar";
            this.CmbEditar.Size = new System.Drawing.Size(44, 21);
            this.CmbEditar.TabIndex = 202;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(503, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 205;
            this.label6.Text = "Excluir";
            // 
            // CmbExcuir
            // 
            this.CmbExcuir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbExcuir.FormattingEnabled = true;
            this.CmbExcuir.Items.AddRange(new object[] {
            "S",
            "N"});
            this.CmbExcuir.Location = new System.Drawing.Point(501, 97);
            this.CmbExcuir.Name = "CmbExcuir";
            this.CmbExcuir.Size = new System.Drawing.Size(44, 21);
            this.CmbExcuir.TabIndex = 204;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(558, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 207;
            this.label7.Text = "Listar";
            // 
            // CmbListar
            // 
            this.CmbListar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbListar.FormattingEnabled = true;
            this.CmbListar.Items.AddRange(new object[] {
            "S",
            "N"});
            this.CmbListar.Location = new System.Drawing.Point(556, 97);
            this.CmbListar.Name = "CmbListar";
            this.CmbListar.Size = new System.Drawing.Size(44, 21);
            this.CmbListar.TabIndex = 206;
            // 
            // btnInserir
            // 
            this.btnInserir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInserir.Location = new System.Drawing.Point(623, 95);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(52, 23);
            this.btnInserir.TabIndex = 208;
            this.btnInserir.TabStop = false;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDesfazer.Location = new System.Drawing.Point(410, 438);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(59, 23);
            this.btnDesfazer.TabIndex = 211;
            this.btnDesfazer.Text = "Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExcluir.Location = new System.Drawing.Point(321, 438);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(59, 23);
            this.BtnExcluir.TabIndex = 212;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(231, 438);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(59, 23);
            this.btnSalvar.TabIndex = 210;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(145, 438);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(59, 23);
            this.btnFechar.TabIndex = 213;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtmenu
            // 
            this.txtmenu.Location = new System.Drawing.Point(729, 250);
            this.txtmenu.Name = "txtmenu";
            this.txtmenu.Size = new System.Drawing.Size(136, 20);
            this.txtmenu.TabIndex = 214;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(726, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 215;
            this.label8.Text = "Menu";
            // 
            // AcessoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 473);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmenu);
            this.Controls.Add(this.btnDesfazer);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbListar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbExcuir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbEditar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cmbGravar);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtcodigoTela);
            this.Controls.Add(this.btnBuscaTela);
            this.Controls.Add(this.txtTela);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProcuraUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtcodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "AcessoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso de Usuários";
            this.Load += new System.EventHandler(this.AcessoUsuarios_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcessoUsuarios_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcuraUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbGravar;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn gravar;
        private System.Windows.Forms.DataGridViewTextBoxColumn editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn imprimir;
        public System.Windows.Forms.TextBox txtcodigoTela;
        private System.Windows.Forms.Button btnBuscaTela;
        private System.Windows.Forms.TextBox txtTela;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbExcuir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbListar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtmenu;
        private System.Windows.Forms.Label label8;
    }
}