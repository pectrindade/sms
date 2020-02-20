namespace Atencao_Assistida.Pesquisas
{
    partial class PesquisaPaciente
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
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.codpaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastraPaciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(12, 56);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(473, 20);
            this.txtpesquisa.TabIndex = 1;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            this.txtpesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpesquisa_KeyPress);
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codpaciente,
            this.nome});
            this.Grid.Location = new System.Drawing.Point(12, 100);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(549, 299);
            this.Grid.TabIndex = 2;
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // codpaciente
            // 
            this.codpaciente.HeaderText = "Código";
            this.codpaciente.Name = "codpaciente";
            this.codpaciente.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Descrição";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 400;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Texto de Pesquisa";
            // 
            // btnCadastraPaciente
            // 
            this.btnCadastraPaciente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastraPaciente.FlatAppearance.BorderSize = 0;
            this.btnCadastraPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastraPaciente.Image = global::Atencao_Assistida.Properties.Resources.addP;
            this.btnCadastraPaciente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastraPaciente.Location = new System.Drawing.Point(503, 57);
            this.btnCadastraPaciente.Name = "btnCadastraPaciente";
            this.btnCadastraPaciente.Size = new System.Drawing.Size(21, 19);
            this.btnCadastraPaciente.TabIndex = 173;
            this.btnCadastraPaciente.TabStop = false;
            this.btnCadastraPaciente.UseVisualStyleBackColor = true;
            this.btnCadastraPaciente.Click += new System.EventHandler(this.btnCadastraPaciente_Click);
            // 
            // PesquisaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnCadastraPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtpesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "PesquisaPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisaPaciente";
            this.Load += new System.EventHandler(this.PesquisaPaciente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PesquisaPaciente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button btnCadastraPaciente;
    }
}