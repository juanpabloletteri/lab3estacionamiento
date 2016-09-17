using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpestacionamiento
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcerca acerca = new frmAcerca();
            acerca.MdiParent=this;
            acerca.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionAutomovil gestion = new frmGestionAutomovil();
            gestion.MdiParent = this;
            gestion.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
