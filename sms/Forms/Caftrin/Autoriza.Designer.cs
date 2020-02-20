namespace Atencao_Assistida.Forms.Caftrin
{
    partial class Autoriza
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.oficio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coddepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codpedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(12, 26);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(238, 21);
            this.cmbEmpresa.TabIndex = 26;
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oficio,
            this.codempresa,
            this.coddepartamento,
            this.codpedido,
            this.departamento,
            this.datapedido});
            this.Grid.Location = new System.Drawing.Point(13, 89);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(659, 349);
            this.Grid.TabIndex = 260;
            this.Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentClick);
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // oficio
            // 
            this.oficio.HeaderText = "Ofício";
            this.oficio.Name = "oficio";
            // 
            // codempresa
            // 
            this.codempresa.HeaderText = "codempresa";
            this.codempresa.Name = "codempresa";
            this.codempresa.Visible = false;
            // 
            // coddepartamento
            // 
            this.coddepartamento.HeaderText = "coddepartamento";
            this.coddepartamento.Name = "coddepartamento";
            this.coddepartamento.Visible = false;
            // 
            // codpedido
            // 
            this.codpedido.HeaderText = "codpedido";
            this.codpedido.Name = "codpedido";
            this.codpedido.Visible = false;
            // 
            // departamento
            // 
            this.departamento.HeaderText = "Departamento";
            this.departamento.Name = "departamento";
            this.departamento.Width = 300;
            // 
            // datapedido
            // 
            this.datapedido.HeaderText = "Data do  Pedido";
            this.datapedido.Name = "datapedido";
            this.datapedido.Width = 200;
            // 
            // btnFechar
            // 
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(237, 463);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(206, 23);
            this.btnFechar.TabIndex = 313;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Autoriza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 498);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Autoriza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autoriza";
            this.Load += new System.EventHandler(this.Autoriza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn oficio;
        private System.Windows.Forms.DataGridViewTextBoxColumn codempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapedido;
        private System.Windows.Forms.Button btnFechar;
    }
}