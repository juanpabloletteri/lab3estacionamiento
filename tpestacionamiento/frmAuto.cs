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
    public partial class frmAuto : frmVehiculo 
    {
        protected Auto _autoDelFormulario;
        public Auto AutoDelFormulario
        {
            get { return this._autoDelFormulario; }
            set { this._autoDelFormulario = value; }
        }
        public frmAuto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                this._autoDelFormulario = new Auto((eColores)Enum.Parse(typeof(eColores), cmbColor.SelectedItem.ToString()), txtMarca.Text, txtPatente.Text, Convert.ToInt32(txtPuertas));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
