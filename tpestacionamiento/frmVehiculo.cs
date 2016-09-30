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
    public partial class frmVehiculo : Form
    {
        public frmVehiculo()
        {
            InitializeComponent();
        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            
            //cmbColor.Items.AddRange(new string[] {"Rojo", "Amarillo", "Negro", "Azul" });
            foreach (eColores color in Enum.GetValues(typeof(eColores)))
            {
                cmbColor.Items.Add(color);
            }
        }


    }
}
