using edu.ejercicioCalculadora.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.ejercicioCalculadora.Servicios
{   /// <summary>
    /// Implementa la interfaz del menú
    /// 200923 - cmr
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuCalculadora()
        {
            int operacionIntroducida;

            Console.WriteLine("###########################");
            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Realizar suma");
            Console.WriteLine("2. Realizar resta");
            Console.WriteLine("3. Realizar division");
            Console.WriteLine("4. Realizar multiplicacion");
            Console.WriteLine("###########################");
            Console.WriteLine("Seleccione una opcion");

            operacionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return operacionIntroducida;
        }


    }
}