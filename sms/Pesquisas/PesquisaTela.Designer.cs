namespace Atencao_Assistida.Pesquisas
{
    partial class PesquisaTela
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
            this.btnCadastraTela = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.codpaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastraTela
            // 
            this.btnCadastraTela.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastraTela.FlatAppearance.BorderSize = 0;
            this.btnCadastraTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastraTela.Image = global::Atencao_Assistida.Properties.Resources.addP;
            this.btnCadastraTela.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastraTela.Location = new System.Drawing.Point(499, 25);
            this.btnCadastraTela.Name = "btnCadastraTela";
            this.btnCadastraTela.Size = new System.Drawing.Size(21, 19);
            this.btnCadastraTela.TabIndex = 183;
            this.btnCadastraTela.TabStop = false;
            this.btnCadastraTela.UseVisualStyleBackColor = true;
            this.btnCadastraTela.Click += new System.EventHandler(this.btnCadastraTela_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 182;
            this.label2.Text = "Texto de Pesquisa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 181;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codpaciente,
            this.Referente,
            this.nome});
            this.Grid.Location = new System.Drawing.Point(8, 75);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(549, 299);
            this.Grid.TabIndex = 180;
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // codpaciente
            // 
            this.codpaciente.HeaderText = "Código";
            this.codpaciente.Name = "codpaciente";
            this.codpaciente.ReadOnly = true;
            this.codpaciente.Width = 60;
            // 
            // Referente
            // 
            this.Referente.HeaderText = "Referênte";
            this.Referente.Name = "Referente";
            this.Referente.ReadOnly = true;
            this.Referente.Width = 220;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 220;
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(8, 24);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(473, 20);
            this.txtpesquisa.TabIndex = 179;
            this.txtpesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpesquisa_KeyPress);
            // 
            // PesquisaTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 416);
            this.Controls.Add(this.btnCadastraTela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtpesquisa);
            this.Name = "PesquisaTela";
            this.Text = "Pesquisa Tela";
            this.Load += new System.EventHandler(this.PesquisaTela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastraTela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
    }
}