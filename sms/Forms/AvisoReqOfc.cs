using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencao_Assistida.Forms
{
    public partial class AvisoReqOfc : Form
    {
        public AvisoReqOfc()
        {
            InitializeComponent();
        }

        private void AvisoReqOfc_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblAtencao.ForeColor == System.Drawing.Color.Red)
            {
                lblAtencao.ForeColor = System.Drawing.Color.Black;
                lblMensagem.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                lblAtencao.ForeColor = System.Drawing.Color.Red;
                lblMensagem.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
