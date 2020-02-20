namespace Atencao_Assistida.Forms.Caftrin
{
    partial class TrocaDevolucao
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mercadoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdtdevolucao = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcurapedido = new System.Windows.Forms.Button();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.RbOficio = new System.Windows.Forms.RadioButton();
            this.RbRequisicao = new System.Windows.Forms.RadioButton();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(714, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigo.TabIndex = 66;
            this.txtCodigo.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker1.TabIndex = 64;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.mercadoria,
            this.qt});
            this.Grid.Location = new System.Drawing.Point(12, 57);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(784, 162);
            this.Grid.TabIndex = 60;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 80;
            // 
            // mercadoria
            // 
            this.mercadoria.HeaderText = "Mercadoria";
            this.mercadoria.Name = "mercadoria";
            this.mercadoria.ReadOnly = true;
            this.mercadoria.Width = 600;
            // 
            // qt
            // 
            this.qt.HeaderText = "QT";
            this.qt.Name = "qt";
            this.qt.ReadOnly = true;
            this.qt.Width = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "DT DEVOLUÇÃO";
            // 
            // txtdtdevolucao
            // 
            this.txtdtdevolucao.Location = new System.Drawing.Point(205, 23);
            this.txtdtdevolucao.Mask = "00/00/0000";
            this.txtdtdevolucao.Name = "txtdtdevolucao";
            this.txtdtdevolucao.Size = new System.Drawing.Size(79, 20);
            this.txtdtdevolucao.TabIndex = 53;
            this.txtdtdevolucao.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "CÓDIGO";
            // 
            // btnProcurapedido
            // 
            this.btnProcurapedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurapedido.Location = new System.Drawing.Point(94, 26);
            this.btnProcurapedido.Name = "btnProcurapedido";
            this.btnProcurapedido.Size = new System.Drawing.Size(25, 20);
            this.btnProcurapedido.TabIndex = 45;
            this.btnProcurapedido.TabStop = false;
            this.btnProcurapedido.Text = "...";
            this.btnProcurapedido.UseVisualStyleBackColor = true;
            this.btnProcurapedido.Click += new System.EventHandler(this.btnProcurapedido_Click);
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Location = new System.Drawing.Point(12, 26);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(78, 20);
            this.txtNumeroPedido.TabIndex = 44;
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.Location = new System.Drawing.Point(471, 345);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(75, 23);
            this.btnDesfazer.TabIndex = 69;
            this.btnDesfazer.Text = "Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(380, 345);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 67;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(287, 345);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 71;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // RbOficio
            // 
            this.RbOficio.AutoSize = true;
            this.RbOficio.Location = new System.Drawing.Point(526, 13);
            this.RbOficio.Name = "RbOficio";
            this.RbOficio.Size = new System.Drawing.Size(54, 17);
            this.RbOficio.TabIndex = 80;
            this.RbOficio.Text = "Ofício";
            this.RbOficio.UseVisualStyleBackColor = true;
            this.RbOficio.Visible = false;
            // 
            // RbRequisicao
            // 
            this.RbRequisicao.AutoSize = true;
            this.RbRequisicao.Checked = true;
            this.RbRequisicao.Location = new System.Drawing.Point(607, 13);
            this.RbRequisicao.Name = "RbRequisicao";
            this.RbRequisicao.Size = new System.Drawing.Size(78, 17);
            this.RbRequisicao.TabIndex = 81;
            this.RbRequisicao.TabStop = true;
            this.RbRequisicao.Text = "Requisição";
            this.RbRequisicao.UseVisualStyleBackColor = true;
            this.RbRequisicao.Visible = false;
            // 
            // txtMotivo
            // 
            this.txtMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMotivo.Location = new System.Drawing.Point(12, 245);
            this.txtMotivo.MaxLength = 255;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(470, 85);
            this.txtMotivo.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "MOTIVO";
            // 
            // TrocaDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 375);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.RbRequisicao);
            this.Controls.Add(this.RbOficio);
            this.Controls.Add(this.btnDesfazer);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdtdevolucao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProcurapedido);
            this.Controls.Add(this.txtNumeroPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TrocaDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troca ou Devolucao";
            this.Load += new System.EventHandler(this.TrocaDevolucao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtdtdevolucao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcurapedido;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mercadoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt;
        private System.Windows.Forms.RadioButton RbOficio;
        private System.Windows.Forms.RadioButton RbRequisicao;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label1;
    }
}