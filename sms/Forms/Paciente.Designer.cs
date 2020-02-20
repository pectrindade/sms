namespace Atencao_Assistida.Forms
{
    partial class Paciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paciente));
            this.btnListar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirImg = new System.Windows.Forms.Button();
            this.btnAdicionaImg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Cadastro = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dtRecadastro = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcell = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumerosus = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtNomemae = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfone = new System.Windows.Forms.TextBox();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.dtnascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnProcuraPaciente = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Cadastro.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPrint);
            this.tabPage2.Controls.Add(this.Grid);
            this.tabPage2.Controls.Add(this.btnExcluirImg);
            this.tabPage2.Controls.Add(this.btnAdicionaImg);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.listBox1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.numero,
            this.Nome});
            resources.ApplyResources(this.Grid, "Grid");
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // codigo
            // 
            resources.ApplyResources(this.codigo, "codigo");
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // numero
            // 
            resources.ApplyResources(this.numero, "numero");
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // Nome
            // 
            resources.ApplyResources(this.Nome, "Nome");
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // btnExcluirImg
            // 
            resources.ApplyResources(this.btnExcluirImg, "btnExcluirImg");
            this.btnExcluirImg.Name = "btnExcluirImg";
            this.btnExcluirImg.UseVisualStyleBackColor = true;
            this.btnExcluirImg.Click += new System.EventHandler(this.btnExcluirImg_Click);
            // 
            // btnAdicionaImg
            // 
            resources.ApplyResources(this.btnAdicionaImg, "btnAdicionaImg");
            this.btnAdicionaImg.Name = "btnAdicionaImg";
            this.btnAdicionaImg.UseVisualStyleBackColor = true;
            this.btnAdicionaImg.Click += new System.EventHandler(this.btnAdicionaImg_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            // 
            // Cadastro
            // 
            this.Cadastro.Controls.Add(this.label4);
            this.Cadastro.Controls.Add(this.dtRecadastro);
            this.Cadastro.Controls.Add(this.label1);
            this.Cadastro.Controls.Add(this.txtcell);
            this.Cadastro.Controls.Add(this.label18);
            this.Cadastro.Controls.Add(this.label15);
            this.Cadastro.Controls.Add(this.label13);
            this.Cadastro.Controls.Add(this.label12);
            this.Cadastro.Controls.Add(this.txtNumerosus);
            this.Cadastro.Controls.Add(this.txtbairro);
            this.Cadastro.Controls.Add(this.txtNomemae);
            this.Cadastro.Controls.Add(this.txtendereco);
            this.Cadastro.Controls.Add(this.label10);
            this.Cadastro.Controls.Add(this.label8);
            this.Cadastro.Controls.Add(this.label7);
            this.Cadastro.Controls.Add(this.label3);
            this.Cadastro.Controls.Add(this.label2);
            this.Cadastro.Controls.Add(this.txtfone);
            this.Cadastro.Controls.Add(this.cmbsexo);
            this.Cadastro.Controls.Add(this.dtnascimento);
            this.Cadastro.Controls.Add(this.txtNome);
            this.Cadastro.Controls.Add(this.txtcodigo);
            this.Cadastro.Controls.Add(this.btnProcuraPaciente);
            resources.ApplyResources(this.Cadastro, "Cadastro");
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // dtRecadastro
            // 
            resources.ApplyResources(this.dtRecadastro, "dtRecadastro");
            this.dtRecadastro.Name = "dtRecadastro";
            this.dtRecadastro.TabStop = false;
            this.dtRecadastro.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtcell
            // 
            resources.ApplyResources(this.txtcell, "txtcell");
            this.txtcell.Name = "txtcell";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // txtNumerosus
            // 
            resources.ApplyResources(this.txtNumerosus, "txtNumerosus");
            this.txtNumerosus.Name = "txtNumerosus";
            // 
            // txtbairro
            // 
            resources.ApplyResources(this.txtbairro, "txtbairro");
            this.txtbairro.Name = "txtbairro";
            // 
            // txtNomemae
            // 
            resources.ApplyResources(this.txtNomemae, "txtNomemae");
            this.txtNomemae.Name = "txtNomemae";
            // 
            // txtendereco
            // 
            resources.ApplyResources(this.txtendereco, "txtendereco");
            this.txtendereco.Name = "txtendereco";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtfone
            // 
            resources.ApplyResources(this.txtfone, "txtfone");
            this.txtfone.Name = "txtfone";
            // 
            // cmbsexo
            // 
            this.cmbsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Items.AddRange(new object[] {
            resources.GetString("cmbsexo.Items"),
            resources.GetString("cmbsexo.Items1"),
            resources.GetString("cmbsexo.Items2")});
            resources.ApplyResources(this.cmbsexo, "cmbsexo");
            this.cmbsexo.Name = "cmbsexo";
            // 
            // dtnascimento
            // 
            resources.ApplyResources(this.dtnascimento, "dtnascimento");
            this.dtnascimento.Name = "dtnascimento";
            this.dtnascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtNome
            // 
            resources.ApplyResources(this.txtNome, "txtNome");
            this.txtNome.Name = "txtNome";
            // 
            // txtcodigo
            // 
            resources.ApplyResources(this.txtcodigo, "txtcodigo");
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Leave += new System.EventHandler(this.txtcodigo_Leave);
            // 
            // btnProcuraPaciente
            // 
            resources.ApplyResources(this.btnProcuraPaciente, "btnProcuraPaciente");
            this.btnProcuraPaciente.Name = "btnProcuraPaciente";
            this.btnProcuraPaciente.TabStop = false;
            this.btnProcuraPaciente.UseVisualStyleBackColor = true;
            this.btnProcuraPaciente.Click += new System.EventHandler(this.btnProcuraPaciente_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Cadastro);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Paciente
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnDesfazer);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Paciente";
            this.Load += new System.EventHandler(this.Paciente_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Paciente_KeyPress);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Cadastro.ResumeLayout(false);
            this.Cadastro.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Cadastro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox dtRecadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcell;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumerosus;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtNomemae;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfone;
        private System.Windows.Forms.ComboBox cmbsexo;
        private System.Windows.Forms.MaskedTextBox dtnascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnProcuraPaciente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnExcluirImg;
        private System.Windows.Forms.Button btnAdicionaImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}