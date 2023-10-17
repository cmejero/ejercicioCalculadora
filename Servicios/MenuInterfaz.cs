using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.ejercicioCalculadora.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra el menú y recoge la selección del usuario
        /// 021023 - cmr
        /// </summary>
        /// <returns>un entero con la opción seleccionada</returns>
        public int mostrarMenuCalculadora();
    }
}
