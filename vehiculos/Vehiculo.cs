using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public abstract class Vehiculo
    {
        #region ATRIBUTOS
        protected eColores _color;
        protected string _marca;
        protected string _patente;
        #endregion

        #region CONSTRUCTORES
        public Vehiculo()
        {

        }
        public Vehiculo(eColores color, string marca, string patente)
        {
            this._color = color;
            this._marca = marca;
            this._patente = patente;
        }
        #endregion

        #region PROPIEDADES
        eColores Color
        {
            get { return this._color; }
            set { this._color = value; }
        }
        string Marca
        {
            get { return this._marca; }
            set { this._marca =value; }
        }
        string Pantente
        {
            get { return this._patente; }
            set { this._patente =value; }
        }
        #endregion

        #region METODOS
        public int OrdenarPorPatente(Vehiculo aux1, Vehiculo aux2)
        {
            if (aux1._patente[0]>aux2._patente[0])
            {
                return 1;
            }
            else if (aux1._patente[0]<aux2._patente[0])
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region SOBRECARGAS
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Color: " + this._color);
            sb.AppendFormat("Marca: " + this._marca);
            sb.AppendLine("Patente: " + this._patente);
            return sb.ToString();
        }
        #endregion

    }
}
