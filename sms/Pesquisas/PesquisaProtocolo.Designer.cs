namespace Atencao_Assistida.Pesquisas
{
    partial class PesquisaProtocolo
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
            this.codpaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RbBusca1 = new System.Windows.Forms.RadioButton();
            this.RbBusca2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codpaciente,
            this.protocolo,
            this.nome});
            this.Grid.Location = new System.Drawing.Point(12, 97);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(549, 341);
            this.Grid.TabIndex = 11;
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // codpaciente
            // 
            this.codpaciente.HeaderText = "codigo";
            this.codpaciente.Name = "codpaciente";
            this.codpaciente.ReadOnly = true;
            this.codpaciente.Visible = false;
            this.codpaciente.Width = 50;
            // 
            // protocolo
            // 
            this.protocolo.HeaderText = "Protocolo";
            this.protocolo.Name = "protocolo";
            this.protocolo.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Descrição";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 400;
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(158, 71);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(403, 20);
            this.txtpesquisa.TabIndex = 1;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Texto de Pesquisa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RbBusca1
            // 
            this.RbBusca1.AutoSize = true;
            this.RbBusca1.Checked = true;
            this.RbBusca1.Location = new System.Drawing.Point(19, 12);
            this.RbBusca1.Name = "RbBusca1";
            this.RbBusca1.Size = new System.Drawing.Size(105, 17);
            this.RbBusca1.TabIndex = 0;
            this.RbBusca1.TabStop = true;
            this.RbBusca1.Text = "Busca Por Nome";
            this.RbBusca1.UseVisualStyleBackColor = true;
            // 
            // RbBusca2
            // 
            this.RbBusca2.AutoSize = true;
            this.RbBusca2.Location = new System.Drawing.Point(19, 35);
            this.RbBusca2.Name = "RbBusca2";
            this.RbBusca2.Size = new System.Drawing.Size(96, 17);
            this.RbBusca2.TabIndex = 15;
            this.RbBusca2.TabStop = true;
            this.RbBusca2.Text = "Cartão do SUS";
            this.RbBusca2.UseVisualStyleBackColor = true;
            // 
            // PesquisaProtocolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 481);
            this.ControlBox = false;
            this.Controls.Add(this.RbBusca2);
            this.Controls.Add(this.RbBusca1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "PesquisaProtocolo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Protocolo";
            this.Load += new System.EventHandler(this.PesquisaProtocolo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PesquisaProtocolo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RbBusca1;
        private System.Windows.Forms.RadioButton RbBusca2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
    }
}