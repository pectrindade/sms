namespace Atencao_Assistida.Pesquisas
{
    partial class PesquisaEntrada
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
            this.Rb1 = new System.Windows.Forms.RadioButton();
            this.Rb2 = new System.Windows.Forms.RadioButton();
            this.Rb3 = new System.Windows.Forms.RadioButton();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipooperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codfornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datarecebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empresa,
            this.tipooperacao,
            this.numero,
            this.serie,
            this.codfornecedor,
            this.nomefornecedor,
            this.datarecebimento});
            this.Grid.Location = new System.Drawing.Point(12, 99);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(769, 299);
            this.Grid.TabIndex = 20;
            this.Grid.TabStop = false;
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(12, 61);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(473, 20);
            this.txtpesquisa.TabIndex = 18;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Texto de Pesquisa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rb1
            // 
            this.Rb1.AutoSize = true;
            this.Rb1.Checked = true;
            this.Rb1.Location = new System.Drawing.Point(19, 12);
            this.Rb1.Name = "Rb1";
            this.Rb1.Size = new System.Drawing.Size(88, 17);
            this.Rb1.TabIndex = 22;
            this.Rb1.TabStop = true;
            this.Rb1.Text = "Número Nota";
            this.Rb1.UseVisualStyleBackColor = true;
            this.Rb1.Click += new System.EventHandler(this.Rb1_Click);
            // 
            // Rb2
            // 
            this.Rb2.AutoSize = true;
            this.Rb2.Location = new System.Drawing.Point(120, 12);
            this.Rb2.Name = "Rb2";
            this.Rb2.Size = new System.Drawing.Size(110, 17);
            this.Rb2.TabIndex = 23;
            this.Rb2.TabStop = true;
            this.Rb2.Text = "Nome Fornecedor";
            this.Rb2.UseVisualStyleBackColor = true;
            this.Rb2.Click += new System.EventHandler(this.Rb1_Click);
            // 
            // Rb3
            // 
            this.Rb3.AutoSize = true;
            this.Rb3.Location = new System.Drawing.Point(236, 12);
            this.Rb3.Name = "Rb3";
            this.Rb3.Size = new System.Drawing.Size(114, 17);
            this.Rb3.TabIndex = 24;
            this.Rb3.TabStop = true;
            this.Rb3.Text = "Data Recebimento";
            this.Rb3.UseVisualStyleBackColor = true;
            this.Rb3.Click += new System.EventHandler(this.Rb1_Click);
            // 
            // empresa
            // 
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            this.empresa.Width = 60;
            // 
            // tipooperacao
            // 
            this.tipooperacao.HeaderText = "CFOP";
            this.tipooperacao.Name = "tipooperacao";
            this.tipooperacao.ReadOnly = true;
            this.tipooperacao.Width = 60;
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero NF";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // serie
            // 
            this.serie.HeaderText = "Série";
            this.serie.Name = "serie";
            this.serie.ReadOnly = true;
            this.serie.Width = 50;
            // 
            // codfornecedor
            // 
            this.codfornecedor.HeaderText = "Codfornecedor";
            this.codfornecedor.Name = "codfornecedor";
            this.codfornecedor.ReadOnly = true;
            this.codfornecedor.Width = 5;
            // 
            // nomefornecedor
            // 
            this.nomefornecedor.HeaderText = "Fornecedor";
            this.nomefornecedor.Name = "nomefornecedor";
            this.nomefornecedor.ReadOnly = true;
            this.nomefornecedor.Width = 320;
            // 
            // datarecebimento
            // 
            this.datarecebimento.HeaderText = "Data Recebimento";
            this.datarecebimento.Name = "datarecebimento";
            this.datarecebimento.ReadOnly = true;
            this.datarecebimento.Width = 120;
            // 
            // PesquisaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 489);
            this.ControlBox = false;
            this.Controls.Add(this.Rb3);
            this.Controls.Add(this.Rb2);
            this.Controls.Add(this.Rb1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PesquisaEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Entrada";
            this.Load += new System.EventHandler(this.PesquisaEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipooperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn codfornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn datarecebimento;
        private System.Windows.Forms.RadioButton Rb1;
        private System.Windows.Forms.RadioButton Rb2;
        private System.Windows.Forms.RadioButton Rb3;
    }
}