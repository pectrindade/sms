namespace Atencao_Assistida.Forms
{
    partial class AvisoReqOfc
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
            this.components = new System.ComponentModel.Container();
            this.lblAtencao = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblAtencao
            // 
            this.lblAtencao.AutoSize = true;
            this.lblAtencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtencao.ForeColor = System.Drawing.Color.Black;
            this.lblAtencao.Location = new System.Drawing.Point(202, 20);
            this.lblAtencao.Name = "lblAtencao";
            this.lblAtencao.Size = new System.Drawing.Size(175, 46);
            this.lblAtencao.TabIndex = 0;
            this.lblAtencao.Text = "Atenção";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(39, 97);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(501, 46);
            this.lblMensagem.TabIndex = 1;
            this.lblMensagem.Text = "Tem uma Nova Requisição";
            // 
            // timer1
            // 
            this.timer1.Interval = 790;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AvisoReqOfc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 206);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblAtencao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AvisoReqOfc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aviso";
            this.Load += new System.EventHandler(this.AvisoReqOfc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtencao;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Timer timer1;
    }
}