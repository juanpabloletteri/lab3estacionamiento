using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public class Moto:Vehiculo
    {
        #region ATRIBUTOS
        protected Single _cilindrada;
        #endregion

        #region CONSTRUCTORES
        public Moto():base()
        {

        }
        public Moto(eColores color, string marca, string patente, Single cilindrada):base(color,marca, patente)
        {
            this._cilindrada  = cilindrada;
        }
        #endregion

        #region PROPIEDADES
        public Single Cilindrada
        {
            get { return this._cilindrada; }
            set { this._cilindrada=value; }
        }
        #endregion

        #region METODOS

        #endregion

        #region SOBRECARGAS
        public override string ToString()
        {
            return base.ToString() + "\nCilindrada: " + this._cilindrada;
        }
        #endregion
    }
}
