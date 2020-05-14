namespace Atencao_Assistida.Pesquisas
{
    partial class PesquisaPadraoSaida
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
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.codpaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codunidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codpaciente,
            this.codunidade,
            this.Unidade,
            this.datacadastro});
            this.Grid.Location = new System.Drawing.Point(12, 68);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(498, 299);
            this.Grid.TabIndex = 15;
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(12, 30);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(473, 20);
            this.txtpesquisa.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Texto de Pesquisa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codpaciente
            // 
            this.codpaciente.HeaderText = "Código";
            this.codpaciente.Name = "codpaciente";
            this.codpaciente.ReadOnly = true;
            this.codpaciente.Visible = false;
            // 
            // codunidade
            // 
            this.codunidade.HeaderText = "CodUnidade";
            this.codunidade.Name = "codunidade";
            this.codunidade.ReadOnly = true;
            this.codunidade.Visible = false;
            // 
            // Unidade
            // 
            this.Unidade.HeaderText = "Unidade";
            this.Unidade.Name = "Unidade";
            this.Unidade.ReadOnly = true;
            this.Unidade.Width = 350;
            // 
            // datacadastro
            // 
            this.datacadastro.HeaderText = "Data Cadastro";
            this.datacadastro.Name = "datacadastro";
            this.datacadastro.ReadOnly = true;
            // 
            // PesquisaPadraoSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 403);
            this.ControlBox = false;
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PesquisaPadraoSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padrao de Solicitações UBS";
            this.Load += new System.EventHandler(this.PesquisaPadraoSaida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codunidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadastro;
    }
}