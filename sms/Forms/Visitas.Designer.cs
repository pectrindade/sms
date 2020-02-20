namespace Atencao_Assistida.Forms
{
    partial class Visitas
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
            this.txtNumeroProtocolo = new System.Windows.Forms.TextBox();
            this.btnBuscaProtocolo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.mskDataVisita = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.datavisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAgenteSaude = new System.Windows.Forms.ComboBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskDtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtnumerovisita = new System.Windows.Forms.TextBox();
            this.txtcodvisitas = new System.Windows.Forms.TextBox();
            this.txtcodprotocolo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumeroProtocolo
            // 
            this.txtNumeroProtocolo.Location = new System.Drawing.Point(2, 30);
            this.txtNumeroProtocolo.Name = "txtNumeroProtocolo";
            this.txtNumeroProtocolo.Size = new System.Drawing.Size(173, 20);
            this.txtNumeroProtocolo.TabIndex = 0;
            this.txtNumeroProtocolo.Leave += new System.EventHandler(this.txtNumeroProtocolo_Leave);
            // 
            // btnBuscaProtocolo
            // 
            this.btnBuscaProtocolo.Location = new System.Drawing.Point(181, 27);
            this.btnBuscaProtocolo.Name = "btnBuscaProtocolo";
            this.btnBuscaProtocolo.Size = new System.Drawing.Size(25, 23);
            this.btnBuscaProtocolo.TabIndex = 188;
            this.btnBuscaProtocolo.TabStop = false;
            this.btnBuscaProtocolo.UseVisualStyleBackColor = true;
            this.btnBuscaProtocolo.Click += new System.EventHandler(this.btnBuscaProtocolo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 189;
            this.label7.Text = "Número de Protocolo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 190;
            this.label9.Text = "Dt. Cadastro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 191;
            this.label4.Text = "Código Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 192;
            this.label3.Text = "Nome Paciente";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(347, 149);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 13);
            this.label19.TabIndex = 197;
            this.label19.Text = "Status do Paciente";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cmbStatus.Location = new System.Drawing.Point(342, 165);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 7;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // mskDataVisita
            // 
            this.mskDataVisita.Location = new System.Drawing.Point(8, 165);
            this.mskDataVisita.Mask = "00/00/0000";
            this.mskDataVisita.Name = "mskDataVisita";
            this.mskDataVisita.Size = new System.Drawing.Size(82, 20);
            this.mskDataVisita.TabIndex = 5;
            this.mskDataVisita.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 195;
            this.label11.Text = "Dt. Visita";
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datavisita,
            this.agente,
            this.status});
            this.Grid.Location = new System.Drawing.Point(2, 265);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(499, 201);
            this.Grid.TabIndex = 198;
            this.Grid.TabStop = false;
            // 
            // datavisita
            // 
            this.datavisita.HeaderText = "Data Visita";
            this.datavisita.Name = "datavisita";
            this.datavisita.ReadOnly = true;
            // 
            // agente
            // 
            this.agente.HeaderText = "Agente";
            this.agente.Name = "agente";
            this.agente.ReadOnly = true;
            this.agente.Width = 250;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(5, 207);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(496, 37);
            this.txtObs.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 200;
            this.label13.Text = "Observação";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(393, 472);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(59, 23);
            this.btnListar.TabIndex = 12;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.Location = new System.Drawing.Point(309, 472);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(59, 23);
            this.btnDesfazer.TabIndex = 11;
            this.btnDesfazer.Text = "Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(220, 472);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(59, 23);
            this.BtnExcluir.TabIndex = 10;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(130, 472);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(59, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(44, 472);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(59, 23);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(135, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 207;
            this.label1.Text = "Agente de Saúde";
            // 
            // cmbAgenteSaude
            // 
            this.cmbAgenteSaude.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgenteSaude.FormattingEnabled = true;
            this.cmbAgenteSaude.Location = new System.Drawing.Point(130, 165);
            this.cmbAgenteSaude.Name = "cmbAgenteSaude";
            this.cmbAgenteSaude.Size = new System.Drawing.Size(189, 21);
            this.cmbAgenteSaude.TabIndex = 6;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(3, 77);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(81, 20);
            this.txtcodigo.TabIndex = 3;
            this.txtcodigo.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(99, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(364, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.TabStop = false;
            // 
            // mskDtCadastro
            // 
            this.mskDtCadastro.Location = new System.Drawing.Point(381, 48);
            this.mskDtCadastro.Mask = "00/00/0000";
            this.mskDtCadastro.Name = "mskDtCadastro";
            this.mskDtCadastro.Size = new System.Drawing.Size(82, 20);
            this.mskDtCadastro.TabIndex = 2;
            this.mskDtCadastro.TabStop = false;
            this.mskDtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtnumerovisita
            // 
            this.txtnumerovisita.Location = new System.Drawing.Point(229, 29);
            this.txtnumerovisita.Name = "txtnumerovisita";
            this.txtnumerovisita.Size = new System.Drawing.Size(100, 20);
            this.txtnumerovisita.TabIndex = 1;
            this.txtnumerovisita.TabStop = false;
            // 
            // txtcodvisitas
            // 
            this.txtcodvisitas.Location = new System.Drawing.Point(577, 14);
            this.txtcodvisitas.Name = "txtcodvisitas";
            this.txtcodvisitas.Size = new System.Drawing.Size(61, 20);
            this.txtcodvisitas.TabIndex = 212;
            this.txtcodvisitas.TabStop = false;
            this.txtcodvisitas.Text = "0";
            this.txtcodvisitas.Visible = false;
            // 
            // txtcodprotocolo
            // 
            this.txtcodprotocolo.Location = new System.Drawing.Point(577, 48);
            this.txtcodprotocolo.Name = "txtcodprotocolo";
            this.txtcodprotocolo.Size = new System.Drawing.Size(61, 20);
            this.txtcodprotocolo.TabIndex = 213;
            this.txtcodprotocolo.TabStop = false;
            this.txtcodprotocolo.Visible = false;
            // 
            // Visitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 498);
            this.ControlBox = false;
            this.Controls.Add(this.txtcodprotocolo);
            this.Controls.Add(this.txtcodvisitas);
            this.Controls.Add(this.txtnumerovisita);
            this.Controls.Add(this.mskDtCadastro);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAgenteSaude);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnDesfazer);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.mskDataVisita);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNumeroProtocolo);
            this.Controls.Add(this.btnBuscaProtocolo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Visitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitas";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Visitas_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumeroProtocolo;
        private System.Windows.Forms.Button btnBuscaProtocolo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.MaskedTextBox mskDataVisita;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAgenteSaude;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn agente;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskDtCadastro;
        private System.Windows.Forms.TextBox txtnumerovisita;
        private System.Windows.Forms.TextBox txtcodvisitas;
        private System.Windows.Forms.TextBox txtcodprotocolo;
    }
}