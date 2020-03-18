namespace Atencao_Assistida.Forms
{
    partial class SaidaOficio
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
            this.txtcoddepartamento = new System.Windows.Forms.TextBox();
            this.txtdatasaida = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoUnidade = new System.Windows.Forms.TextBox();
            this.txtNomeUnidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.txtdatapedido = new System.Windows.Forms.MaskedTextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscaProtocolo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcoddepartamento
            // 
            this.txtcoddepartamento.Location = new System.Drawing.Point(655, 59);
            this.txtcoddepartamento.Name = "txtcoddepartamento";
            this.txtcoddepartamento.Size = new System.Drawing.Size(36, 20);
            this.txtcoddepartamento.TabIndex = 251;
            this.txtcoddepartamento.TabStop = false;
            this.txtcoddepartamento.Visible = false;
            // 
            // txtdatasaida
            // 
            this.txtdatasaida.Location = new System.Drawing.Point(365, 26);
            this.txtdatasaida.Mask = "00/00/0000";
            this.txtdatasaida.Name = "txtdatasaida";
            this.txtdatasaida.Size = new System.Drawing.Size(82, 20);
            this.txtdatasaida.TabIndex = 249;
            this.txtdatasaida.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(362, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 250;
            this.label8.Text = "Dt. Saida";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(446, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker1.TabIndex = 248;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtCodigoUnidade
            // 
            this.txtCodigoUnidade.Location = new System.Drawing.Point(655, 33);
            this.txtCodigoUnidade.Name = "txtCodigoUnidade";
            this.txtCodigoUnidade.Size = new System.Drawing.Size(36, 20);
            this.txtCodigoUnidade.TabIndex = 247;
            this.txtCodigoUnidade.TabStop = false;
            this.txtCodigoUnidade.Visible = false;
            // 
            // txtNomeUnidade
            // 
            this.txtNomeUnidade.Enabled = false;
            this.txtNomeUnidade.Location = new System.Drawing.Point(12, 69);
            this.txtNomeUnidade.Name = "txtNomeUnidade";
            this.txtNomeUnidade.Size = new System.Drawing.Size(338, 20);
            this.txtNomeUnidade.TabIndex = 238;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(16, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 239;
            this.label5.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(655, 7);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(36, 20);
            this.txtCodigo.TabIndex = 237;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Visible = false;
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
            this.profissional,
            this.solicitado,
            this.entregue});
            this.Grid.Location = new System.Drawing.Point(12, 139);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersVisible = false;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(833, 321);
            this.Grid.TabIndex = 236;
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
            // profissional
            // 
            this.profissional.HeaderText = "Profissional";
            this.profissional.Name = "profissional";
            this.profissional.Width = 250;
            // 
            // solicitado
            // 
            this.solicitado.HeaderText = "Solicitado";
            this.solicitado.Name = "solicitado";
            this.solicitado.Width = 74;
            // 
            // entregue
            // 
            this.entregue.HeaderText = "Entregue";
            this.entregue.Name = "entregue";
            this.entregue.Width = 74;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExcluir.Location = new System.Drawing.Point(386, 466);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(59, 23);
            this.BtnExcluir.TabIndex = 224;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // txtdatapedido
            // 
            this.txtdatapedido.Location = new System.Drawing.Point(195, 26);
            this.txtdatapedido.Mask = "00/00/0000";
            this.txtdatapedido.Name = "txtdatapedido";
            this.txtdatapedido.Size = new System.Drawing.Size(82, 20);
            this.txtdatapedido.TabIndex = 228;
            this.txtdatapedido.ValidatingType = typeof(System.DateTime);
            // 
            // btnListar
            // 
            this.btnListar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListar.Location = new System.Drawing.Point(559, 466);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(59, 23);
            this.btnListar.TabIndex = 226;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDesfazer.Location = new System.Drawing.Point(475, 466);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(59, 23);
            this.btnDesfazer.TabIndex = 225;
            this.btnDesfazer.Text = "Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(296, 466);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(59, 23);
            this.btnSalvar.TabIndex = 223;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(210, 466);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(59, 23);
            this.btnFechar.TabIndex = 227;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Location = new System.Drawing.Point(12, 26);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(136, 20);
            this.txtNumeroPedido.TabIndex = 222;
            this.txtNumeroPedido.Leave += new System.EventHandler(this.txtNumeroPedido_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 235;
            this.label1.Text = "Nº Oficio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(192, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 231;
            this.label9.Text = "Dt. Pedido";
            // 
            // btnBuscaProtocolo
            // 
            this.btnBuscaProtocolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaProtocolo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaProtocolo.Location = new System.Drawing.Point(154, 26);
            this.btnBuscaProtocolo.Name = "btnBuscaProtocolo";
            this.btnBuscaProtocolo.Size = new System.Drawing.Size(25, 23);
            this.btnBuscaProtocolo.TabIndex = 232;
            this.btnBuscaProtocolo.TabStop = false;
            this.btnBuscaProtocolo.Text = "...";
            this.btnBuscaProtocolo.UseVisualStyleBackColor = true;
            this.btnBuscaProtocolo.Click += new System.EventHandler(this.btnBuscaProtocolo_Click);
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(749, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 253;
            this.button1.Text = "teste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SaidaOficio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 506);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcoddepartamento);
            this.Controls.Add(this.txtdatasaida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtCodigoUnidade);
            this.Controls.Add(this.txtNomeUnidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.txtdatapedido);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnDesfazer);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtNumeroPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBuscaProtocolo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SaidaOficio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saida Oficio";
            this.Load += new System.EventHandler(this.SaidaOficio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtcoddepartamento;
        private System.Windows.Forms.MaskedTextBox txtdatasaida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCodigoUnidade;
        private System.Windows.Forms.TextBox txtNomeUnidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.MaskedTextBox txtdatapedido;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscaProtocolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissional;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn entregue;
        private System.Windows.Forms.Button button1;
    }
}