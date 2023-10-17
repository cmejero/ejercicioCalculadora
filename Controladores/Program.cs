
using edu.ejercicioCalculadora.Servicios;

namespace edu.ejercicioCalculadora.Controladores
{       /// <summary>
        /// Clase principal de la aplicación
        /// 021023 - cmr
        /// </summary>
    internal class Program
    {
        /// <summary>
        /// Método de entrada a la aplicación
        /// 021023 - cmr
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();

            CalculadoraInterfaz ci = new CalculadoraImplementacion();

            // variable que controla la entrada y salida del bucle while
            bool cerrarMenu = false;
            //contener la opción del usuario
            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenuCalculadora();
                Console.WriteLine(opcionSeleccionada);
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se ejecuta caso 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Se ejecuta caso 1");
                        ci.menuSuma();
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - Se ejecuta caso 2");
                        ci.menuResta();
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - Se ejecuta caso 3");
                        ci.menuDivision();
                        break;
                    case 4:
                        Console.WriteLine("[INFO] - Se ejecuta caso 4");
                        ci.menuMultiplicacion();
                        break;
                    default:
                        Console.WriteLine("[INFO] - Esta opción no coincide con ninguna");
                        break;


                }
            }
        }
    }
}
