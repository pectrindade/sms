namespace Atencao_Assistida.Forms
{
    partial class EntregaMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntregaMedicamentos));
            this.mskDtEntrega = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscaProtocolo = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroProtocolo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codespecialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodEntregaMercadoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // mskDtEntrega
            // 
            resources.ApplyResources(this.mskDtEntrega, "mskDtEntrega");
            this.mskDtEntrega.Name = "mskDtEntrega";
            this.mskDtEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // btnBuscaProtocolo
            // 
            resources.ApplyResources(this.btnBuscaProtocolo, "btnBuscaProtocolo");
            this.btnBuscaProtocolo.Name = "btnBuscaProtocolo";
            this.btnBuscaProtocolo.TabStop = false;
            this.btnBuscaProtocolo.UseVisualStyleBackColor = true;
            this.btnBuscaProtocolo.Click += new System.EventHandler(this.btnBuscaProtocolo_Click);
            // 
            // txtcodigo
            // 
            resources.ApplyResources(this.txtcodigo, "txtcodigo");
            this.txtcodigo.Name = "txtcodigo";
            // 
            // txtnome
            // 
            resources.ApplyResources(this.txtnome, "txtnome");
            this.txtnome.Name = "txtnome";
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
            // txtNumeroProtocolo
            // 
            resources.ApplyResources(this.txtNumeroProtocolo, "txtNumeroProtocolo");
            this.txtNumeroProtocolo.Name = "txtNumeroProtocolo";
            this.txtNumeroProtocolo.TextChanged += new System.EventHandler(this.txtNumeroProtocolo_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.codespecialidade,
            this.especialidade,
            this.unidade,
            this.quantidade});
            resources.ApplyResources(this.Grid, "Grid");
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersVisible = false;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.TabStop = false;
            // 
            // codigo
            // 
            resources.ApplyResources(this.codigo, "codigo");
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // descricao
            // 
            resources.ApplyResources(this.descricao, "descricao");
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // codespecialidade
            // 
            resources.ApplyResources(this.codespecialidade, "codespecialidade");
            this.codespecialidade.Name = "codespecialidade";
            // 
            // especialidade
            // 
            resources.ApplyResources(this.especialidade, "especialidade");
            this.especialidade.Name = "especialidade";
            this.especialidade.ReadOnly = true;
            // 
            // unidade
            // 
            resources.ApplyResources(this.unidade, "unidade");
            this.unidade.Name = "unidade";
            this.unidade.ReadOnly = true;
            // 
            // quantidade
            // 
            resources.ApplyResources(this.quantidade, "quantidade");
            this.quantidade.Name = "quantidade";
            // 
            // txtCodEntregaMercadoria
            // 
            resources.ApplyResources(this.txtCodEntregaMercadoria, "txtCodEntregaMercadoria");
            this.txtCodEntregaMercadoria.Name = "txtCodEntregaMercadoria";
            this.txtCodEntregaMercadoria.TabStop = false;
            // 
            // EntregaMedicamentos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.txtCodEntregaMercadoria);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnDesfazer);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroProtocolo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskDtEntrega);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBuscaProtocolo);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "EntregaMedicamentos";
            this.Load += new System.EventHandler(this.EntregaMedicamentos_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Entrega_de_Medicamentos_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskDtEntrega;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscaProtocolo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroProtocolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn codespecialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.TextBox txtCodEntregaMercadoria;
    }
}