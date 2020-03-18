namespace Atencao_Assistida.Consultas
{
    partial class Estoque
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
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.txtDataEstoque = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnBuscaProduto = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtanterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtatual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnDesfaz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(12, 68);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(238, 21);
            this.cmbDepartamento.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(12, 25);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(238, 21);
            this.cmbEmpresa.TabIndex = 0;
            // 
            // txtDataEstoque
            // 
            this.txtDataEstoque.Location = new System.Drawing.Point(292, 23);
            this.txtDataEstoque.Mask = "00/00/0000";
            this.txtDataEstoque.Name = "txtDataEstoque";
            this.txtDataEstoque.Size = new System.Drawing.Size(82, 20);
            this.txtDataEstoque.TabIndex = 1;
            this.txtDataEstoque.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(289, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 253;
            this.label8.Text = "Dt. Estoque";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(373, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker1.TabIndex = 251;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnBuscaProduto
            // 
            this.btnBuscaProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaProduto.Location = new System.Drawing.Point(71, 186);
            this.btnBuscaProduto.Name = "btnBuscaProduto";
            this.btnBuscaProduto.Size = new System.Drawing.Size(25, 23);
            this.btnBuscaProduto.TabIndex = 256;
            this.btnBuscaProduto.TabStop = false;
            this.btnBuscaProduto.UseVisualStyleBackColor = true;
            this.btnBuscaProduto.Click += new System.EventHandler(this.btnBuscaProduto_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(12, 186);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(53, 20);
            this.txtcodigo.TabIndex = 4;
            this.txtcodigo.Leave += new System.EventHandler(this.txtcodigo_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(102, 186);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(962, 20);
            this.txtNome.TabIndex = 255;
            this.txtNome.TabStop = false;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 257;
            this.label1.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(99, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 258;
            this.label3.Text = "Nome";
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.qtanterior,
            this.entrada,
            this.saida,
            this.qtatual});
            this.Grid.Location = new System.Drawing.Point(10, 247);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(1212, 209);
            this.Grid.TabIndex = 259;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 60;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 700;
            // 
            // qtanterior
            // 
            this.qtanterior.HeaderText = "Qt. Anterior";
            this.qtanterior.Name = "qtanterior";
            this.qtanterior.ReadOnly = true;
            // 
            // entrada
            // 
            this.entrada.HeaderText = "Entrada";
            this.entrada.Name = "entrada";
            this.entrada.ReadOnly = true;
            // 
            // saida
            // 
            this.saida.HeaderText = "Saida";
            this.saida.Name = "saida";
            this.saida.ReadOnly = true;
            // 
            // qtatual
            // 
            this.qtatual.HeaderText = "Qt. Atual";
            this.qtatual.Name = "qtatual";
            this.qtatual.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 260;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(834, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 261;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(1094, 170);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(113, 43);
            this.btnBusca.TabIndex = 5;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(292, 52);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(915, 23);
            this.progressBar1.TabIndex = 263;
            this.progressBar1.Visible = false;
            // 
            // BtnDesfaz
            // 
            this.BtnDesfaz.Location = new System.Drawing.Point(501, 473);
            this.BtnDesfaz.Name = "BtnDesfaz";
            this.BtnDesfaz.Size = new System.Drawing.Size(166, 23);
            this.BtnDesfaz.TabIndex = 264;
            this.BtnDesfaz.Text = "Desfaz";
            this.BtnDesfaz.UseVisualStyleBackColor = true;
            this.BtnDesfaz.Click += new System.EventHandler(this.BtnDesfaz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 266;
            this.label2.Text = "Grupo";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(12, 113);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(238, 21);
            this.cmbGrupo.TabIndex = 3;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 508);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.BtnDesfaz);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.btnBuscaProduto);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataEstoque);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Estoque_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Estoque_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.MaskedTextBox txtDataEstoque;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnBuscaProduto;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtanterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtatual;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnDesfaz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrupo;
    }
}