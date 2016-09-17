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
    public partial class frmGestionAutomovil : Form
    {
        public frmGestionAutomovil()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGestionAutomovil_Load(object sender, EventArgs e)
        {

        }

        private void nuevamotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMoto formularioMoto = new frmMoto();
            formularioMoto.ShowDialog();
        }

        private void nuevoautoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuto formularioAuto = new frmAuto();
            formularioAuto.ShowDialog();
        }
    }
}
