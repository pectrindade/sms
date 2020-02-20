namespace Atencao_Assistida.Forms.Caftrin
{
    partial class EntradaMercadoria
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
            this.txtcodigotipooperacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcuratipooperacao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnometipooperacao = new System.Windows.Forms.TextBox();
            this.btnBuscaNota = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumeronota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtserienota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnomefornecedor = new System.Windows.Forms.TextBox();
            this.btnProcurafornecedor = new System.Windows.Forms.Button();
            this.txtcodigofornecedor = new System.Windows.Forms.TextBox();
            this.txtdtemissao = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdtrecebimento = new System.Windows.Forms.MaskedTextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mercadoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnomemercadoria = new System.Windows.Forms.TextBox();
            this.btnProcuramercadoria = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcodigomercadoria = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLista = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileXml = new System.Windows.Forms.OpenFileDialog();
            this.txtpathXml = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCpfCnpjEmitente = new System.Windows.Forms.TextBox();
            this.PainelMercadoria = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.PainelMercadoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcodigotipooperacao
            // 
            this.txtcodigotipooperacao.Location = new System.Drawing.Point(193, 22);
            this.txtcodigotipooperacao.Name = "txtcodigotipooperacao";
            this.txtcodigotipooperacao.Size = new System.Drawing.Size(61, 20);
            this.txtcodigotipooperacao.TabIndex = 2;
            this.txtcodigotipooperacao.Leave += new System.EventHandler(this.txtcodigotipooperacao_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIPO DE OPERAÇÃO";
            // 
            // btnProcuratipooperacao
            // 
            this.btnProcuratipooperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcuratipooperacao.Location = new System.Drawing.Point(258, 22);
            this.btnProcuratipooperacao.Name = "btnProcuratipooperacao";
            this.btnProcuratipooperacao.Size = new System.Drawing.Size(25, 20);
            this.btnProcuratipooperacao.TabIndex = 2;
            this.btnProcuratipooperacao.TabStop = false;
            this.btnProcuratipooperacao.Text = "...";
            this.btnProcuratipooperacao.UseVisualStyleBackColor = true;
            this.btnProcuratipooperacao.Click += new System.EventHandler(this.btnProcuratipooperacao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CÓDIGO";
            // 
            // txtnometipooperacao
            // 
            this.txtnometipooperacao.Location = new System.Drawing.Point(285, 22);
            this.txtnometipooperacao.Name = "txtnometipooperacao";
            this.txtnometipooperacao.ReadOnly = true;
            this.txtnometipooperacao.Size = new System.Drawing.Size(271, 20);
            this.txtnometipooperacao.TabIndex = 3;
            // 
            // btnBuscaNota
            // 
            this.btnBuscaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaNota.Location = new System.Drawing.Point(94, 21);
            this.btnBuscaNota.Name = "btnBuscaNota";
            this.btnBuscaNota.Size = new System.Drawing.Size(25, 20);
            this.btnBuscaNota.TabIndex = 7;
            this.btnBuscaNota.TabStop = false;
            this.btnBuscaNota.Text = "...";
            this.btnBuscaNota.UseVisualStyleBackColor = true;
            this.btnBuscaNota.Click += new System.EventHandler(this.btnBuscaNota_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nº NOTA";
            // 
            // txtnumeronota
            // 
            this.txtnumeronota.Location = new System.Drawing.Point(14, 22);
            this.txtnumeronota.Name = "txtnumeronota";
            this.txtnumeronota.Size = new System.Drawing.Size(76, 20);
            this.txtnumeronota.TabIndex = 0;
            this.txtnumeronota.Leave += new System.EventHandler(this.txtnumeronota_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SÉRIE";
            // 
            // txtserienota
            // 
            this.txtserienota.Location = new System.Drawing.Point(122, 21);
            this.txtserienota.Name = "txtserienota";
            this.txtserienota.Size = new System.Drawing.Size(61, 20);
            this.txtserienota.TabIndex = 1;
            this.txtserienota.Leave += new System.EventHandler(this.txtserienota_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "FORNECEDOR";
            // 
            // txtnomefornecedor
            // 
            this.txtnomefornecedor.Location = new System.Drawing.Point(104, 68);
            this.txtnomefornecedor.Name = "txtnomefornecedor";
            this.txtnomefornecedor.ReadOnly = true;
            this.txtnomefornecedor.Size = new System.Drawing.Size(271, 20);
            this.txtnomefornecedor.TabIndex = 5;
            // 
            // btnProcurafornecedor
            // 
            this.btnProcurafornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurafornecedor.Location = new System.Drawing.Point(77, 68);
            this.btnProcurafornecedor.Name = "btnProcurafornecedor";
            this.btnProcurafornecedor.Size = new System.Drawing.Size(25, 20);
            this.btnProcurafornecedor.TabIndex = 12;
            this.btnProcurafornecedor.TabStop = false;
            this.btnProcurafornecedor.Text = "...";
            this.btnProcurafornecedor.UseVisualStyleBackColor = true;
            this.btnProcurafornecedor.Click += new System.EventHandler(this.btnProcurafornecedor_Click);
            // 
            // txtcodigofornecedor
            // 
            this.txtcodigofornecedor.Location = new System.Drawing.Point(14, 68);
            this.txtcodigofornecedor.Name = "txtcodigofornecedor";
            this.txtcodigofornecedor.Size = new System.Drawing.Size(61, 20);
            this.txtcodigofornecedor.TabIndex = 4;
            this.txtcodigofornecedor.Leave += new System.EventHandler(this.txtcodigofornecedor_Leave);
            // 
            // txtdtemissao
            // 
            this.txtdtemissao.Location = new System.Drawing.Point(14, 115);
            this.txtdtemissao.Mask = "00/00/0000";
            this.txtdtemissao.Name = "txtdtemissao";
            this.txtdtemissao.Size = new System.Drawing.Size(79, 20);
            this.txtdtemissao.TabIndex = 7;
            this.txtdtemissao.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "DT EMISSÃO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "DT RECEBIMENTO";
            // 
            // txtdtrecebimento
            // 
            this.txtdtrecebimento.Location = new System.Drawing.Point(129, 115);
            this.txtdtrecebimento.Mask = "00/00/0000";
            this.txtdtrecebimento.Name = "txtdtrecebimento";
            this.txtdtrecebimento.Size = new System.Drawing.Size(79, 20);
            this.txtdtrecebimento.TabIndex = 8;
            this.txtdtrecebimento.ValidatingType = typeof(System.DateTime);
            this.txtdtrecebimento.Leave += new System.EventHandler(this.txtdtrecebimento_Leave);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.mercadoria,
            this.qt,
            this.valor,
            this.codigo_,
            this.nome_});
            this.Grid.Location = new System.Drawing.Point(8, 213);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(805, 219);
            this.Grid.TabIndex = 19;
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            this.Grid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Grid_MouseDown);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 80;
            // 
            // mercadoria
            // 
            this.mercadoria.HeaderText = "Mercadoria";
            this.mercadoria.Name = "mercadoria";
            this.mercadoria.ReadOnly = true;
            this.mercadoria.Width = 400;
            // 
            // qt
            // 
            this.qt.HeaderText = "QT";
            this.qt.Name = "qt";
            this.qt.ReadOnly = true;
            this.qt.Width = 50;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 60;
            // 
            // codigo_
            // 
            this.codigo_.HeaderText = "codigo_";
            this.codigo_.Name = "codigo_";
            this.codigo_.ReadOnly = true;
            // 
            // nome_
            // 
            this.nome_.HeaderText = "nome_";
            this.nome_.Name = "nome_";
            this.nome_.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(594, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "VALOR";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(590, 27);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(61, 20);
            this.txtvalor.TabIndex = 11;
            this.txtvalor.Leave += new System.EventHandler(this.txtvalor_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(539, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "QT";
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(523, 27);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(61, 20);
            this.txtquantidade.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "MERCADORIA";
            // 
            // txtnomemercadoria
            // 
            this.txtnomemercadoria.Location = new System.Drawing.Point(106, 26);
            this.txtnomemercadoria.Name = "txtnomemercadoria";
            this.txtnomemercadoria.Size = new System.Drawing.Size(411, 20);
            this.txtnomemercadoria.TabIndex = 9;
            this.txtnomemercadoria.Enter += new System.EventHandler(this.txtnomemercadoria_Enter);
            // 
            // btnProcuramercadoria
            // 
            this.btnProcuramercadoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcuramercadoria.Location = new System.Drawing.Point(75, 26);
            this.btnProcuramercadoria.Name = "btnProcuramercadoria";
            this.btnProcuramercadoria.Size = new System.Drawing.Size(25, 20);
            this.btnProcuramercadoria.TabIndex = 22;
            this.btnProcuramercadoria.TabStop = false;
            this.btnProcuramercadoria.Text = "...";
            this.btnProcuramercadoria.UseVisualStyleBackColor = true;
            this.btnProcuramercadoria.Click += new System.EventHandler(this.btnProcuramercadoria_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "CÓDIGO";
            // 
            // txtcodigomercadoria
            // 
            this.txtcodigomercadoria.Location = new System.Drawing.Point(10, 27);
            this.txtcodigomercadoria.Name = "txtcodigomercadoria";
            this.txtcodigomercadoria.Size = new System.Drawing.Size(61, 20);
            this.txtcodigomercadoria.TabIndex = 9;
            this.txtcodigomercadoria.Leave += new System.EventHandler(this.txtcodigomercadoria_Leave);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(108, 438);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(201, 438);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(300, 438);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.Location = new System.Drawing.Point(390, 438);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(75, 23);
            this.btnDesfazer.TabIndex = 14;
            this.btnDesfazer.Text = "Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "CÓDIGO";
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(490, 438);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 23);
            this.btnLista.TabIndex = 15;
            this.btnLista.Text = "Listar";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 70);
            this.button1.TabIndex = 36;
            this.button1.TabStop = false;
            this.button1.Text = "Busca Nfe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileXml
            // 
            this.openFileXml.Filter = "Arquivo Xml|*.xml";
            this.openFileXml.Title = "Abrir Nota Fiscal";
            // 
            // txtpathXml
            // 
            this.txtpathXml.Location = new System.Drawing.Point(737, 75);
            this.txtpathXml.Name = "txtpathXml";
            this.txtpathXml.Size = new System.Drawing.Size(34, 20);
            this.txtpathXml.TabIndex = 37;
            this.txtpathXml.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtCpfCnpjEmitente
            // 
            this.txtCpfCnpjEmitente.Location = new System.Drawing.Point(390, 68);
            this.txtCpfCnpjEmitente.Name = "txtCpfCnpjEmitente";
            this.txtCpfCnpjEmitente.Size = new System.Drawing.Size(149, 20);
            this.txtCpfCnpjEmitente.TabIndex = 6;
            this.txtCpfCnpjEmitente.Leave += new System.EventHandler(this.txtCpfCnpjEmitente_Leave);
            // 
            // PainelMercadoria
            // 
            this.PainelMercadoria.Controls.Add(this.txtnomemercadoria);
            this.PainelMercadoria.Controls.Add(this.txtcodigomercadoria);
            this.PainelMercadoria.Controls.Add(this.label12);
            this.PainelMercadoria.Controls.Add(this.btnProcuramercadoria);
            this.PainelMercadoria.Controls.Add(this.label11);
            this.PainelMercadoria.Controls.Add(this.txtquantidade);
            this.PainelMercadoria.Controls.Add(this.label10);
            this.PainelMercadoria.Controls.Add(this.txtvalor);
            this.PainelMercadoria.Controls.Add(this.label9);
            this.PainelMercadoria.Location = new System.Drawing.Point(12, 160);
            this.PainelMercadoria.Name = "PainelMercadoria";
            this.PainelMercadoria.Size = new System.Drawing.Size(763, 53);
            this.PainelMercadoria.TabIndex = 39;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(716, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigo.TabIndex = 40;
            this.txtCodigo.Visible = false;
            // 
            // EntradaMercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 477);
            this.ControlBox = false;
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.PainelMercadoria);
            this.Controls.Add(this.txtCpfCnpjEmitente);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtpathXml);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDesfazer);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdtrecebimento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdtemissao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnomefornecedor);
            this.Controls.Add(this.btnProcurafornecedor);
            this.Controls.Add(this.txtcodigofornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtserienota);
            this.Controls.Add(this.btnBuscaNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnumeronota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnometipooperacao);
            this.Controls.Add(this.btnProcuratipooperacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcodigotipooperacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "EntradaMercadoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de  Mercadoria";
            this.Load += new System.EventHandler(this.EntradaMercadoria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntradaMercadoria_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntradaMercadoria_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.PainelMercadoria.ResumeLayout(false);
            this.PainelMercadoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigotipooperacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcuratipooperacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnometipooperacao;
        private System.Windows.Forms.Button btnBuscaNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumeronota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtserienota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnomefornecedor;
        private System.Windows.Forms.Button btnProcurafornecedor;
        private System.Windows.Forms.TextBox txtcodigofornecedor;
        private System.Windows.Forms.MaskedTextBox txtdtemissao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtdtrecebimento;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnomemercadoria;
        private System.Windows.Forms.Button btnProcuramercadoria;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcodigomercadoria;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mercadoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileXml;
        private System.Windows.Forms.TextBox txtpathXml;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCpfCnpjEmitente;
        private System.Windows.Forms.Panel PainelMercadoria;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}