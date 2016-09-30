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
    public partial class frmMoto : frmVehiculo
    {
        protected Moto _motoDelFormulario;

        public Moto MotoDelFormuario
        {
            get { return this._motoDelFormulario; }
            set { this._motoDelFormulario = value; }
        }
        public frmMoto()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            //this._motoDelFormulario = new Moto(eColores.Amarillo, "audi", "sad452", 21);
            try
            {
                this._motoDelFormulario = new Moto((eColores)Enum.Parse(typeof(eColores), cmbColor.SelectedItem.ToString()), txtMarca.Text, txtPatente.Text, Convert.ToSingle(txtCilindrada.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMoto_Load(object sender, EventArgs e)
        {

        }

        private void frmMoto_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmMoto_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmGestionAutomovil padre = new frmGestionAutomovil();
            padre.Agrega(_motoDelFormulario);
        }
    }
}
