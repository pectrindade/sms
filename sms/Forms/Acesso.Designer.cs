namespace Atencao_Assistida.Forms
{
    partial class Acesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acesso));
            this.lblAltera = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmensagem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.btnsai = new System.Windows.Forms.Button();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.btnEntra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAltera
            // 
            this.lblAltera.AutoSize = true;
            this.lblAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltera.Location = new System.Drawing.Point(18, 285);
            this.lblAltera.Name = "lblAltera";
            this.lblAltera.Size = new System.Drawing.Size(261, 15);
            this.lblAltera.TabIndex = 17;
            this.lblAltera.Text = "Favor usar o login e a senha recem informada.";
            this.lblAltera.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Acesso ao Sistema";
            // 
            // lblmensagem
            // 
            this.lblmensagem.AutoSize = true;
            this.lblmensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensagem.ForeColor = System.Drawing.Color.Red;
            this.lblmensagem.Location = new System.Drawing.Point(35, 260);
            this.lblmensagem.Name = "lblmensagem";
            this.lblmensagem.Size = new System.Drawing.Size(197, 20);
            this.lblmensagem.TabIndex = 15;
            this.lblmensagem.Text = "Login ou Senha Incorreto !";
            this.lblmensagem.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuario";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(35, 169);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(238, 21);
            this.cmbUsuario.TabIndex = 9;
            // 
            // btnsai
            // 
            this.btnsai.Location = new System.Drawing.Point(162, 326);
            this.btnsai.Name = "btnsai";
            this.btnsai.Size = new System.Drawing.Size(135, 23);
            this.btnsai.TabIndex = 12;
            this.btnsai.Text = "Fechar";
            this.btnsai.UseVisualStyleBackColor = true;
            this.btnsai.Click += new System.EventHandler(this.btnsai_Click_1);
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(35, 219);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(168, 20);
            this.txtsenha.TabIndex = 10;
            // 
            // btnEntra
            // 
            this.btnEntra.Location = new System.Drawing.Point(7, 326);
            this.btnEntra.Name = "btnEntra";
            this.btnEntra.Size = new System.Drawing.Size(135, 23);
            this.btnEntra.TabIndex = 11;
            this.btnEntra.Text = "Entrar";
            this.btnEntra.UseVisualStyleBackColor = true;
            this.btnEntra.Click += new System.EventHandler(this.btnEntra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(35, 66);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(238, 21);
            this.cmbEmpresa.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(35, 119);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(238, 21);
            this.cmbDepartamento.TabIndex = 20;
            this.cmbDepartamento.TextChanged += new System.EventHandler(this.cmbDepartamento_TextChanged);
            // 
            // Acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 378);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.lblAltera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblmensagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.btnsai);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.btnEntra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Acesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso";
            this.Load += new System.EventHandler(this.Acesso_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Acesso_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmensagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Button btnsai;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button btnEntra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDepartamento;
    }
}