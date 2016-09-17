using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public class Auto:Vehiculo
    {
        #region ATRIBUTOS
        protected int _cantidadPuertas;
        #endregion

        #region CONSTRUCTORES
        public Auto():base()
        {

        }
        public Auto(eColores color, string marca, string patente, int puertas):base(color,marca, patente)
        {
            this._cantidadPuertas = puertas;
        }
        #endregion

        #region PROPIEDADES
        public int CantidadPueras
        {
            get { return this._cantidadPuertas; }
            set { this._cantidadPuertas = value; }
        }
        #endregion

        #region METODOS

        #endregion

        #region SOBRECARGAS
        public override string ToString()
        {
            return base.ToString()+"\nCantidad de puertas: "+this._cantidadPuertas;
        }
        #endregion
    }
}
