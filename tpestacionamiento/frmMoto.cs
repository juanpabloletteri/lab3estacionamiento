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
                MessageBox.Show("Guardado exitoso, confirme al salir");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea agregar la moto a la lista antes de salir?", "Saliendo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                ((frmGestionAutomovil)this.Owner).Agrega(this._motoDelFormulario);
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
            }
        }

    }
}
