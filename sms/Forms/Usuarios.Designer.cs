namespace Atencao_Assistida.Forms
{
    partial class Usuarios
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
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.cmbativo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnProcuraUsuario = new System.Windows.Forms.Button();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbUnidade = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbFuncao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(12, 27);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(68, 20);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.Text = "0";
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcodigo.Leave += new System.EventHandler(this.txtcodigo_Leave);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(12, 64);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(369, 20);
            this.txtnome.TabIndex = 1;
            this.txtnome.Leave += new System.EventHandler(this.txtnome_Leave);
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(12, 181);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(100, 20);
            this.txttelefone.TabIndex = 4;
            this.txttelefone.Leave += new System.EventHandler(this.txttelefone_Leave);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(12, 142);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(286, 20);
            this.txtemail.TabIndex = 3;
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // cmbativo
            // 
            this.cmbativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbativo.FormattingEnabled = true;
            this.cmbativo.Location = new System.Drawing.Point(12, 362);
            this.cmbativo.Name = "cmbativo";
            this.cmbativo.Size = new System.Drawing.Size(121, 21);
            this.cmbativo.TabIndex = 8;
            this.cmbativo.Leave += new System.EventHandler(this.cmbativo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cpf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ativo";
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDesfazer.Location = new System.Drawing.Point(292, 401);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(59, 23);
            this.btnDesfazer.TabIndex = 11;
            this.btnDesfazer.Text = "Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExcluir.Location = new System.Drawing.Point(203, 401);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(59, 23);
            this.BtnExcluir.TabIndex = 10;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(113, 401);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(59, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnGravarClick);
            // 
            // btnFechar
            // 
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(27, 401);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(59, 23);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnProcuraUsuario
            // 
            this.btnProcuraUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProcuraUsuario.Location = new System.Drawing.Point(87, 24);
            this.btnProcuraUsuario.Name = "btnProcuraUsuario";
            this.btnProcuraUsuario.Size = new System.Drawing.Size(25, 23);
            this.btnProcuraUsuario.TabIndex = 183;
            this.btnProcuraUsuario.TabStop = false;
            this.btnProcuraUsuario.UseVisualStyleBackColor = true;
            this.btnProcuraUsuario.Click += new System.EventHandler(this.btnProcuraUsuario_Click);
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(12, 104);
            this.mskCpf.Mask = "999.999.999-99";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(84, 20);
            this.mskCpf.TabIndex = 2;
            this.mskCpf.Leave += new System.EventHandler(this.mskCpf_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 185;
            this.label7.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(283, 226);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(238, 21);
            this.cmbDepartamento.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 187;
            this.label8.Text = "Empresa";
            // 
            // CmbEmpresa
            // 
            this.CmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEmpresa.FormattingEnabled = true;
            this.CmbEmpresa.Location = new System.Drawing.Point(12, 226);
            this.CmbEmpresa.Name = "CmbEmpresa";
            this.CmbEmpresa.Size = new System.Drawing.Size(238, 21);
            this.CmbEmpresa.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 189;
            this.label9.Text = "Unidade";
            // 
            // CmbUnidade
            // 
            this.CmbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUnidade.FormattingEnabled = true;
            this.CmbUnidade.Location = new System.Drawing.Point(283, 272);
            this.CmbUnidade.Name = "CmbUnidade";
            this.CmbUnidade.Size = new System.Drawing.Size(238, 21);
            this.CmbUnidade.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 191;
            this.label10.Text = "Função";
            // 
            // CmbFuncao
            // 
            this.CmbFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFuncao.FormattingEnabled = true;
            this.CmbFuncao.Location = new System.Drawing.Point(12, 272);
            this.CmbFuncao.Name = "CmbFuncao";
            this.CmbFuncao.Size = new System.Drawing.Size(238, 21);
            this.CmbFuncao.TabIndex = 190;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 466);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CmbFuncao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmbUnidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbEmpresa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.btnProcuraUsuario);
            this.Controls.Add(this.btnDesfazer);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbativo);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtcodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Usuarios_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ComboBox cmbativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnProcuraUsuario;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbEmpresa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbUnidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbFuncao;
    }
}