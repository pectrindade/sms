namespace Atencao_Assistida.Relatorios.Estoque_Extrato
{
    partial class Chama_extrato
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
            this.label9 = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.btnDesfaz = new System.Windows.Forms.Button();
            this.btnBuscaProduto = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.dtpfinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 317;
            this.label9.Text = "Grupo";
            this.label9.Visible = false;
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(463, 52);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(147, 21);
            this.cmbGrupo.TabIndex = 2;
            this.cmbGrupo.Visible = false;
            // 
            // btnDesfaz
            // 
            this.btnDesfaz.Location = new System.Drawing.Point(154, 264);
            this.btnDesfaz.Name = "btnDesfaz";
            this.btnDesfaz.Size = new System.Drawing.Size(121, 23);
            this.btnDesfaz.TabIndex = 8;
            this.btnDesfaz.Text = "Desfaz";
            this.btnDesfaz.UseVisualStyleBackColor = true;
            this.btnDesfaz.Click += new System.EventHandler(this.btnDesfaz_Click);
            // 
            // btnBuscaProduto
            // 
            this.btnBuscaProduto.Image = global::Atencao_Assistida.Properties.Resources.lupa1;
            this.btnBuscaProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaProduto.Location = new System.Drawing.Point(85, 141);
            this.btnBuscaProduto.Name = "btnBuscaProduto";
            this.btnBuscaProduto.Size = new System.Drawing.Size(25, 25);
            this.btnBuscaProduto.TabIndex = 312;
            this.btnBuscaProduto.TabStop = false;
            this.btnBuscaProduto.UseVisualStyleBackColor = true;
            this.btnBuscaProduto.Click += new System.EventHandler(this.btnBuscaProduto_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(12, 143);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(67, 20);
            this.txtcodigo.TabIndex = 3;
            this.txtcodigo.Leave += new System.EventHandler(this.txtcodigo_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(116, 143);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(320, 23);
            this.txtNome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(20, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 313;
            this.label3.Text = "Código";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(115, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 314;
            this.label8.Text = "Nome";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(13, 264);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(120, 23);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(179, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 308;
            this.label2.Text = "Data Final";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(174, 207);
            this.txtDataFinal.Mask = "00/00/0000";
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(82, 20);
            this.txtDataFinal.TabIndex = 6;
            this.txtDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // dtpfinal
            // 
            this.dtpfinal.Location = new System.Drawing.Point(255, 207);
            this.dtpfinal.Name = "dtpfinal";
            this.dtpfinal.Size = new System.Drawing.Size(20, 20);
            this.dtpfinal.TabIndex = 307;
            this.dtpfinal.TabStop = false;
            this.dtpfinal.ValueChanged += new System.EventHandler(this.dtpfinal_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 306;
            this.label5.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(12, 81);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(319, 21);
            this.cmbDepartamento.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 305;
            this.label4.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(12, 25);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(319, 21);
            this.cmbEmpresa.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(289, 264);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(120, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(19, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 320;
            this.label1.Text = "Data Inicial";
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Location = new System.Drawing.Point(16, 207);
            this.txtDataInicial.Mask = "00/00/0000";
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(82, 20);
            this.txtDataInicial.TabIndex = 5;
            this.txtDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // dtpInicial
            // 
            this.dtpInicial.Location = new System.Drawing.Point(97, 207);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(20, 20);
            this.dtpInicial.TabIndex = 319;
            this.dtpInicial.TabStop = false;
            this.dtpInicial.ValueChanged += new System.EventHandler(this.dtpInicial_ValueChanged);
            // 
            // Chama_extrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 298);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataInicial);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.btnDesfaz);
            this.Controls.Add(this.btnBuscaProduto);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataFinal);
            this.Controls.Add(this.dtpfinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.btnListar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Chama_extrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque Analítico";
            this.Load += new System.EventHandler(this.Chama_extrato_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Chama_extrato_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Chama_extrato_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Button btnDesfaz;
        private System.Windows.Forms.Button btnBuscaProduto;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDataFinal;
        private System.Windows.Forms.DateTimePicker dtpfinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDataInicial;
        private System.Windows.Forms.DateTimePicker dtpInicial;
    }
}