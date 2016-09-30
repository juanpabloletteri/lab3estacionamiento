using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vehiculos;

namespace tpestacionamiento
{
    public partial class frmGestionAutomovil : Form
    {
        List<Vehiculo> _lista = new List<Vehiculo>();

        public delegate void agregar(Vehiculo v);

        public agregar Agrega;

        
        public void agregaVehiculo(Vehiculo v)
        {
            _lista.Add(v);
        }
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
            this.Agrega += this.agregaVehiculo;
        }

        private void nuevamotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMoto formularioMoto = new frmMoto();
            formularioMoto.Owner = this;
            formularioMoto.ShowDialog();
        }

        private void nuevoautoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuto formularioAuto = new frmAuto();
            formularioAuto.ShowDialog();
        }
    }
}
