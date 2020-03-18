namespace Atencao_Assistida.Forms
{
    partial class SaidaMercadoria
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdatapedido = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscaProtocolo = new System.Windows.Forms.Button();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeUnidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtlote = new System.Windows.Forms.TextBox();
            this.txtsolicitado = new System.Windows.Forms.TextBox();
            this.txtentregue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoUnidade = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtdatasaida = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcoddepartamento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(655, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(36, 20);
            this.txtCodigo.TabIndex = 206;
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
            this.lote,
            this.solicitado,
            this.entregue});
            this.Grid.Location = new System.Drawing.Point(12, 136);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersVisible = false;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(679, 321);
            this.Grid.TabIndex = 205;
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
            // lote
            // 
            this.lote.HeaderText = "Lote";
            this.lote.Name = "lote";
            this.lote.Width = 74;
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
            // btnListar
            // 
            this.btnListar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListar.Location = new System.Drawing.Point(472, 463);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(59, 23);
            this.btnListar.TabIndex = 194;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDesfazer.Location = new System.Drawing.Point(388, 463);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(59, 23);
            this.btnDesfazer.TabIndex = 193;
            this.btnDesfazer.Text = "Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExcluir.Location = new System.Drawing.Point(299, 463);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(59, 23);
            this.BtnExcluir.TabIndex = 192;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(209, 463);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(59, 23);
            this.btnSalvar.TabIndex = 191;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(123, 463);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(59, 23);
            this.btnFechar.TabIndex = 195;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Location = new System.Drawing.Point(12, 23);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(136, 20);
            this.txtNumeroPedido.TabIndex = 190;
            this.txtNumeroPedido.Leave += new System.EventHandler(this.txtNumeroPedido_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 203;
            this.label1.Text = "Nº Requisição";
            // 
            // txtdatapedido
            // 
            this.txtdatapedido.Location = new System.Drawing.Point(195, 23);
            this.txtdatapedido.Mask = "00/00/0000";
            this.txtdatapedido.Name = "txtdatapedido";
            this.txtdatapedido.Size = new System.Drawing.Size(82, 20);
            this.txtdatapedido.TabIndex = 196;
            this.txtdatapedido.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(192, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 199;
            this.label9.Text = "Dt. Pedido";
            // 
            // btnBuscaProtocolo
            // 
            this.btnBuscaProtocolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaProtocolo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaProtocolo.Location = new System.Drawing.Point(154, 23);
            this.btnBuscaProtocolo.Name = "btnBuscaProtocolo";
            this.btnBuscaProtocolo.Size = new System.Drawing.Size(25, 23);
            this.btnBuscaProtocolo.TabIndex = 200;
            this.btnBuscaProtocolo.TabStop = false;
            this.btnBuscaProtocolo.Text = "...";
            this.btnBuscaProtocolo.UseVisualStyleBackColor = true;
            this.btnBuscaProtocolo.Click += new System.EventHandler(this.btnBuscaProtocolo_Click);
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(12, 109);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(68, 20);
            this.txtCodigoProduto.TabIndex = 197;
            this.txtCodigoProduto.Visible = false;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(115, 109);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(319, 20);
            this.txtnome.TabIndex = 198;
            this.txtnome.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(16, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 201;
            this.label4.Text = "Código";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(112, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 202;
            this.label3.Text = "Nome";
            this.label3.Visible = false;
            // 
            // txtNomeUnidade
            // 
            this.txtNomeUnidade.Enabled = false;
            this.txtNomeUnidade.Location = new System.Drawing.Point(12, 66);
            this.txtNomeUnidade.Name = "txtNomeUnidade";
            this.txtNomeUnidade.Size = new System.Drawing.Size(338, 20);
            this.txtNomeUnidade.TabIndex = 207;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(16, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 208;
            this.label5.Text = "Nome";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(86, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 21);
            this.button1.TabIndex = 209;
            this.button1.TabStop = false;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // txtlote
            // 
            this.txtlote.Location = new System.Drawing.Point(440, 109);
            this.txtlote.Name = "txtlote";
            this.txtlote.Size = new System.Drawing.Size(68, 20);
            this.txtlote.TabIndex = 210;
            this.txtlote.Visible = false;
            // 
            // txtsolicitado
            // 
            this.txtsolicitado.Location = new System.Drawing.Point(514, 110);
            this.txtsolicitado.Name = "txtsolicitado";
            this.txtsolicitado.Size = new System.Drawing.Size(68, 20);
            this.txtsolicitado.TabIndex = 211;
            this.txtsolicitado.Visible = false;
            // 
            // txtentregue
            // 
            this.txtentregue.Location = new System.Drawing.Point(588, 110);
            this.txtentregue.Name = "txtentregue";
            this.txtentregue.Size = new System.Drawing.Size(68, 20);
            this.txtentregue.TabIndex = 212;
            this.txtentregue.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(446, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 213;
            this.label2.Text = "Lote";
            this.label2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(514, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 214;
            this.label6.Text = "Solicitado";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(585, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 215;
            this.label7.Text = "Entregue";
            this.label7.Visible = false;
            // 
            // txtCodigoUnidade
            // 
            this.txtCodigoUnidade.Location = new System.Drawing.Point(655, 30);
            this.txtCodigoUnidade.Name = "txtCodigoUnidade";
            this.txtCodigoUnidade.Size = new System.Drawing.Size(36, 20);
            this.txtCodigoUnidade.TabIndex = 216;
            this.txtCodigoUnidade.TabStop = false;
            this.txtCodigoUnidade.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(446, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker1.TabIndex = 217;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtdatasaida
            // 
            this.txtdatasaida.Location = new System.Drawing.Point(365, 23);
            this.txtdatasaida.Mask = "00/00/0000";
            this.txtdatasaida.Name = "txtdatasaida";
            this.txtdatasaida.Size = new System.Drawing.Size(82, 20);
            this.txtdatasaida.TabIndex = 218;
            this.txtdatasaida.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(362, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 219;
            this.label8.Text = "Dt. Saida";
            // 
            // txtcoddepartamento
            // 
            this.txtcoddepartamento.Location = new System.Drawing.Point(655, 56);
            this.txtcoddepartamento.Name = "txtcoddepartamento";
            this.txtcoddepartamento.Size = new System.Drawing.Size(36, 20);
            this.txtcoddepartamento.TabIndex = 220;
            this.txtcoddepartamento.TabStop = false;
            this.txtcoddepartamento.Visible = false;
            // 
            // SaidaMercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 498);
            this.Controls.Add(this.txtcoddepartamento);
            this.Controls.Add(this.txtdatasaida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtCodigoUnidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtentregue);
            this.Controls.Add(this.txtsolicitado);
            this.Controls.Add(this.txtlote);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNomeUnidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnDesfazer);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtNumeroPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdatapedido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBuscaProtocolo);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SaidaMercadoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saida de Mercadoria";
            this.Load += new System.EventHandler(this.SaidaMercadoria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaidaMercadoria_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaidaMercadoria_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtdatapedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscaProtocolo;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn entregue;
        private System.Windows.Forms.TextBox txtNomeUnidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtlote;
        private System.Windows.Forms.TextBox txtsolicitado;
        private System.Windows.Forms.TextBox txtentregue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoUnidade;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox txtdatasaida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcoddepartamento;
    }
}