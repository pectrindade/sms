namespace Atencao_Assistida.Consultas
{
    partial class Detalhe_saida
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.lblNome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.codunidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numpedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codunidade,
            this.nome,
            this.solicitante,
            this.numpedido,
            this.quantidade,
            this.datasaida});
            this.Grid.Location = new System.Drawing.Point(11, 25);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(928, 439);
            this.Grid.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(215, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "SAMU - MALETA MÉDIA Cor AZUL - Média";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 261;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codunidade
            // 
            this.codunidade.HeaderText = "Cod Unidade";
            this.codunidade.Name = "codunidade";
            this.codunidade.Visible = false;
            this.codunidade.Width = 60;
            // 
            // nome
            // 
            this.nome.HeaderText = "Unidade";
            this.nome.Name = "nome";
            this.nome.Width = 300;
            // 
            // solicitante
            // 
            this.solicitante.HeaderText = "Solicitante";
            this.solicitante.Name = "solicitante";
            this.solicitante.Width = 300;
            // 
            // numpedido
            // 
            this.numpedido.HeaderText = "Nº Pedido";
            this.numpedido.Name = "numpedido";
            this.numpedido.Width = 80;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // datasaida
            // 
            this.datasaida.HeaderText = "Data";
            this.datasaida.Name = "datasaida";
            // 
            // Detalhe_saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 505);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.Grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Detalhe_saida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhe da saida";
            this.Load += new System.EventHandler(this.Detalhe_saida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn codunidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn numpedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasaida;
        private System.Windows.Forms.Button button1;
    }
}