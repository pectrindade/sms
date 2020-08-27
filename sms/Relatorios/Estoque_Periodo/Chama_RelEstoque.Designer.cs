namespace Atencao_Assistida.Relatorios.Estoque_Periodo
{
    partial class Chama_RelEstoque
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
            this.btnBuscaProduto = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnDesfaz = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.chkNegativo = new System.Windows.Forms.CheckBox();
            this.PnlPorCodigo = new System.Windows.Forms.Panel();
            this.RbCodigo = new System.Windows.Forms.RadioButton();
            this.RbNome = new System.Windows.Forms.RadioButton();
            this.PnlPorNome = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.PnlPorCodigo.SuspendLayout();
            this.PnlPorNome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscaProduto
            // 
            this.btnBuscaProduto.Image = global::Atencao_Assistida.Properties.Resources.lupa1;
            this.btnBuscaProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscaProduto.Location = new System.Drawing.Point(77, 23);
            this.btnBuscaProduto.Name = "btnBuscaProduto";
            this.btnBuscaProduto.Size = new System.Drawing.Size(25, 25);
            this.btnBuscaProduto.TabIndex = 292;
            this.btnBuscaProduto.TabStop = false;
            this.btnBuscaProduto.UseVisualStyleBackColor = true;
            this.btnBuscaProduto.Click += new System.EventHandler(this.btnBuscaProduto_Click_1);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(4, 26);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(67, 20);
            this.txtcodigo.TabIndex = 290;
            this.txtcodigo.Leave += new System.EventHandler(this.txtcodigo_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(317, 20);
            this.txtNome.TabIndex = 291;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(8, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 293;
            this.label3.Text = "Código";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(103, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 294;
            this.label8.Text = "Nome";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(12, 287);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(120, 23);
            this.btnFechar.TabIndex = 289;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(17, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 288;
            this.label2.Text = "Data";
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Location = new System.Drawing.Point(14, 243);
            this.txtDataInicial.Mask = "00/00/0000";
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(82, 20);
            this.txtDataInicial.TabIndex = 275;
            this.txtDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker1.TabIndex = 279;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 278;
            this.label5.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(12, 66);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(319, 21);
            this.cmbDepartamento.TabIndex = 276;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 277;
            this.label4.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(12, 23);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(319, 21);
            this.cmbEmpresa.TabIndex = 274;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(304, 287);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(120, 23);
            this.btnListar.TabIndex = 273;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnDesfaz
            // 
            this.btnDesfaz.Location = new System.Drawing.Point(157, 287);
            this.btnDesfaz.Name = "btnDesfaz";
            this.btnDesfaz.Size = new System.Drawing.Size(121, 23);
            this.btnDesfaz.TabIndex = 297;
            this.btnDesfaz.Text = "Desfaz";
            this.btnDesfaz.UseVisualStyleBackColor = true;
            this.btnDesfaz.Click += new System.EventHandler(this.btnDesfaz_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 299;
            this.label9.Text = "Grupo";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(14, 112);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(319, 21);
            this.cmbGrupo.TabIndex = 298;
            // 
            // chkNegativo
            // 
            this.chkNegativo.AutoSize = true;
            this.chkNegativo.Location = new System.Drawing.Point(146, 248);
            this.chkNegativo.Name = "chkNegativo";
            this.chkNegativo.Size = new System.Drawing.Size(289, 17);
            this.chkNegativo.TabIndex = 300;
            this.chkNegativo.Text = "Mostrar apenas produtos com estoque zero ou negativo";
            this.chkNegativo.UseVisualStyleBackColor = true;
            // 
            // PnlPorCodigo
            // 
            this.PnlPorCodigo.Controls.Add(this.txtNome);
            this.PnlPorCodigo.Controls.Add(this.label8);
            this.PnlPorCodigo.Controls.Add(this.label3);
            this.PnlPorCodigo.Controls.Add(this.txtcodigo);
            this.PnlPorCodigo.Controls.Add(this.btnBuscaProduto);
            this.PnlPorCodigo.Location = new System.Drawing.Point(12, 166);
            this.PnlPorCodigo.Name = "PnlPorCodigo";
            this.PnlPorCodigo.Size = new System.Drawing.Size(438, 57);
            this.PnlPorCodigo.TabIndex = 301;
            // 
            // RbCodigo
            // 
            this.RbCodigo.AutoSize = true;
            this.RbCodigo.Checked = true;
            this.RbCodigo.Location = new System.Drawing.Point(12, 139);
            this.RbCodigo.Name = "RbCodigo";
            this.RbCodigo.Size = new System.Drawing.Size(77, 17);
            this.RbCodigo.TabIndex = 302;
            this.RbCodigo.TabStop = true;
            this.RbCodigo.Text = "Por Código";
            this.RbCodigo.UseVisualStyleBackColor = true;
            this.RbCodigo.CheckedChanged += new System.EventHandler(this.RbCodigo_CheckedChanged);
            // 
            // RbNome
            // 
            this.RbNome.AutoSize = true;
            this.RbNome.Location = new System.Drawing.Point(118, 139);
            this.RbNome.Name = "RbNome";
            this.RbNome.Size = new System.Drawing.Size(72, 17);
            this.RbNome.TabIndex = 303;
            this.RbNome.Text = "Por Nome";
            this.RbNome.UseVisualStyleBackColor = true;
            this.RbNome.CheckedChanged += new System.EventHandler(this.RbNome_CheckedChanged);
            // 
            // PnlPorNome
            // 
            this.PnlPorNome.Controls.Add(this.label6);
            this.PnlPorNome.Controls.Add(this.txtBuscaNome);
            this.PnlPorNome.Location = new System.Drawing.Point(12, 167);
            this.PnlPorNome.Name = "PnlPorNome";
            this.PnlPorNome.Size = new System.Drawing.Size(438, 57);
            this.PnlPorNome.TabIndex = 302;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(8, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 293;
            this.label6.Text = "Nome";
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Location = new System.Drawing.Point(4, 26);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(419, 20);
            this.txtBuscaNome.TabIndex = 290;
            // 
            // Chama_RelEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 322);
            this.ControlBox = false;
            this.Controls.Add(this.PnlPorNome);
            this.Controls.Add(this.RbNome);
            this.Controls.Add(this.RbCodigo);
            this.Controls.Add(this.PnlPorCodigo);
            this.Controls.Add(this.chkNegativo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.btnDesfaz);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataInicial);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.btnListar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Chama_RelEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Chama_RelEstoque_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Chama_RelEstoque_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Chama_RelEstoque_KeyPress);
            this.PnlPorCodigo.ResumeLayout(false);
            this.PnlPorCodigo.PerformLayout();
            this.PnlPorNome.ResumeLayout(false);
            this.PnlPorNome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscaProduto;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDataInicial;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnDesfaz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.CheckBox chkNegativo;
        private System.Windows.Forms.Panel PnlPorCodigo;
        private System.Windows.Forms.RadioButton RbCodigo;
        private System.Windows.Forms.RadioButton RbNome;
        private System.Windows.Forms.Panel PnlPorNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscaNome;
    }
}