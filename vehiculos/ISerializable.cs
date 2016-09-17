using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    interface ISerializable
    {
        bool deserializar(string ruta);
        bool Serializar(string ruta);
    }
}
