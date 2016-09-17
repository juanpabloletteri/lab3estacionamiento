using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public class Camioneta:Vehiculo
    {
        #region ATRIBUTOS
        protected double _altura;
        #endregion

        #region CONSTRUCTORES
        public Camioneta():base()
        {

        }
        public Camioneta(eColores color, string marca, string patente, double altura):base(color,marca, patente)
        {
            this._altura = altura;
        }
        #endregion

        #region PROPIEDADES
        public double Altura
        {
            get { return this._altura; }
            set { this._altura = value; }
        }
        #endregion

        #region METODOS

        #endregion

        #region SOBRECARGAS
        public override string ToString()
        {
            return base.ToString() + "\nAltura: " + this._altura;
        }
        #endregion
    }
}
