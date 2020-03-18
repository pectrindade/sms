namespace Atencao_Assistida.Forms
{
    partial class Medicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicamentos));
            this.btnBuscaProduto = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbUnidaemedida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbmarca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbgrupo = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbativo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBuscaProduto
            // 
            resources.ApplyResources(this.btnBuscaProduto, "btnBuscaProduto");
            this.btnBuscaProduto.Name = "btnBuscaProduto";
            this.btnBuscaProduto.TabStop = false;
            this.btnBuscaProduto.UseVisualStyleBackColor = true;
            this.btnBuscaProduto.Click += new System.EventHandler(this.btnBuscaProduto_Click);
            // 
            // txtcodigo
            // 
            resources.ApplyResources(this.txtcodigo, "txtcodigo");
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Leave += new System.EventHandler(this.txtcodigo_Leave);
            // 
            // txtNome
            // 
            resources.ApplyResources(this.txtNome, "txtNome");
            this.txtNome.Name = "txtNome";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // cmbUnidaemedida
            // 
            this.cmbUnidaemedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidaemedida.FormattingEnabled = true;
            this.cmbUnidaemedida.Items.AddRange(new object[] {
            resources.GetString("cmbUnidaemedida.Items"),
            resources.GetString("cmbUnidaemedida.Items1"),
            resources.GetString("cmbUnidaemedida.Items2")});
            resources.ApplyResources(this.cmbUnidaemedida, "cmbUnidaemedida");
            this.cmbUnidaemedida.Name = "cmbUnidaemedida";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmbmarca
            // 
            this.cmbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmarca.FormattingEnabled = true;
            this.cmbmarca.Items.AddRange(new object[] {
            resources.GetString("cmbmarca.Items"),
            resources.GetString("cmbmarca.Items1"),
            resources.GetString("cmbmarca.Items2")});
            resources.ApplyResources(this.cmbmarca, "cmbmarca");
            this.cmbmarca.Name = "cmbmarca";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cmbgrupo
            // 
            this.cmbgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgrupo.FormattingEnabled = true;
            this.cmbgrupo.Items.AddRange(new object[] {
            resources.GetString("cmbgrupo.Items"),
            resources.GetString("cmbgrupo.Items1"),
            resources.GetString("cmbgrupo.Items2")});
            resources.ApplyResources(this.cmbgrupo, "cmbgrupo");
            this.cmbgrupo.Name = "cmbgrupo";
            // 
            // btnListar
            // 
            resources.ApplyResources(this.btnListar, "btnListar");
            this.btnListar.Name = "btnListar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnDesfazer
            // 
            resources.ApplyResources(this.btnDesfazer, "btnDesfazer");
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // BtnExcluir
            // 
            resources.ApplyResources(this.BtnExcluir, "BtnExcluir");
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            resources.ApplyResources(this.btnSalvar, "btnSalvar");
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            resources.ApplyResources(this.btnFechar, "btnFechar");
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // cmbativo
            // 
            this.cmbativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbativo.FormattingEnabled = true;
            this.cmbativo.Items.AddRange(new object[] {
            resources.GetString("cmbativo.Items"),
            resources.GetString("cmbativo.Items1")});
            resources.ApplyResources(this.cmbativo, "cmbativo");
            this.cmbativo.Name = "cmbativo";
            // 
            // Medicamentos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbativo);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnDesfazer);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbgrupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbmarca);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbUnidaemedida);
            this.Controls.Add(this.btnBuscaProduto);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Medicamentos";
            this.Load += new System.EventHandler(this.Medicamentos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Medicamentos_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Medicamentos_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscaProduto;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbUnidaemedida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbmarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbgrupo;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbativo;
    }
}