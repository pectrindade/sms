namespace Atencao_Assistida.Relatorios.EntradaPeriodo
{
    partial class ChamaRelEntrada
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
            this.btnDesfaz = new System.Windows.Forms.Button();
            this.btnBuscaProduto = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscaFornecedor = new System.Windows.Forms.Button();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDesfaz
            // 
            this.btnDesfaz.Location = new System.Drawing.Point(166, 263);
            this.btnDesfaz.Name = "btnDesfaz";
            this.btnDesfaz.Size = new System.Drawing.Size(121, 23);
            this.btnDesfaz.TabIndex = 7;
            this.btnDesfaz.Text = "Desfaz";
            this.btnDesfaz.UseVisualStyleBackColor = true;
            this.btnDesfaz.Click += new System.EventHandler(this.btnDesfaz_Click);
            // 
            // btnBuscaProduto
            // 
            this.btnBuscaProduto.Image = global::Atencao_Assistida.Properties.Resources.lupa1;
            this.btnBuscaProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaProduto.Location = new System.Drawing.Point(86, 155);
            this.btnBuscaProduto.Name = "btnBuscaProduto";
            this.btnBuscaProduto.Size = new System.Drawing.Size(25, 26);
            this.btnBuscaProduto.TabIndex = 10;
            this.btnBuscaProduto.TabStop = false;
            this.btnBuscaProduto.UseVisualStyleBackColor = true;
            this.btnBuscaProduto.Click += new System.EventHandler(this.btnBuscaProduto_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(13, 157);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(67, 20);
            this.txtcodigo.TabIndex = 3;
            this.txtcodigo.Leave += new System.EventHandler(this.txtcodigo_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(115, 160);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(319, 20);
            this.txtNome.TabIndex = 315;
            this.txtNome.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(17, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 317;
            this.label3.Text = "Código";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(112, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 318;
            this.label8.Text = "Nome";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(11, 263);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(120, 23);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(16, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 312;
            this.label2.Text = "Dt Inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(163, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 311;
            this.label1.Text = "Dt Final";
            // 
            // btnBuscaFornecedor
            // 
            this.btnBuscaFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaFornecedor.Image = global::Atencao_Assistida.Properties.Resources.lupa1;
            this.btnBuscaFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaFornecedor.Location = new System.Drawing.Point(86, 112);
            this.btnBuscaFornecedor.Name = "btnBuscaFornecedor";
            this.btnBuscaFornecedor.Size = new System.Drawing.Size(25, 24);
            this.btnBuscaFornecedor.TabIndex = 9;
            this.btnBuscaFornecedor.TabStop = false;
            this.btnBuscaFornecedor.UseVisualStyleBackColor = true;
            this.btnBuscaFornecedor.Click += new System.EventHandler(this.btnBuscaFornecedor_Click);
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Location = new System.Drawing.Point(12, 114);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(68, 20);
            this.txtCodFornecedor.TabIndex = 2;
            this.txtCodFornecedor.Leave += new System.EventHandler(this.txtCodFornecedor_Leave);
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(115, 114);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.ReadOnly = true;
            this.txtNomeFornecedor.Size = new System.Drawing.Size(319, 20);
            this.txtNomeFornecedor.TabIndex = 307;
            this.txtNomeFornecedor.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(11, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 308;
            this.label6.Text = "Fornecedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(112, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 309;
            this.label7.Text = "Nome";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(157, 210);
            this.txtDataFinal.Mask = "00/00/0000";
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(82, 20);
            this.txtDataFinal.TabIndex = 5;
            this.txtDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(238, 210);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker2.TabIndex = 305;
            this.dateTimePicker2.TabStop = false;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Location = new System.Drawing.Point(13, 210);
            this.txtDataInicial.Mask = "00/00/0000";
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(82, 20);
            this.txtDataInicial.TabIndex = 4;
            this.txtDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker1.TabIndex = 303;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 302;
            this.label5.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(11, 67);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(238, 21);
            this.cmbDepartamento.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 301;
            this.label4.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(11, 24);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(238, 21);
            this.cmbEmpresa.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChamaRelEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 298);
            this.ControlBox = false;
            this.Controls.Add(this.btnDesfaz);
            this.Controls.Add(this.btnBuscaProduto);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscaFornecedor);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDataFinal);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txtDataInicial);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "ChamaRelEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Mercadoria";
            this.Load += new System.EventHandler(this.ChamaRelEntrada_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChamaRelEntrada_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChamaRelEntrada_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesfaz;
        private System.Windows.Forms.Button btnBuscaProduto;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscaFornecedor;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtDataFinal;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.MaskedTextBox txtDataInicial;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Button button1;
    }
}