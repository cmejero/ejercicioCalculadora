using edu.ejercicioCalculadora.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.ejercicioCalculadora.Servicios
{
    internal class CalculadoraImplementacion : CalculadoraInterfaz
    {



        public void menuSuma()
        {
            double op1 = cogerOp();
            double op2 = cogerOp();
            Console.WriteLine(op1 + op2);

        }
        public void menuResta()
        {
            double op1 = cogerOp();
            double op2 = cogerOp();
            Console.WriteLine(op1 - op2);


        }
        public void menuDivision()
        {
            double op1 = cogerOp();
            double op2 = cogerOp();
            Console.WriteLine(op1 / op2);


        }
        public void menuMultiplicacion()

        {
            double op1 = cogerOp();
            double op2 = cogerOp();
            Console.WriteLine(op1 * op2);




        }
        private double cogerOp()
        {
            Console.WriteLine("elija su operador");
            double op = Convert.ToDouble(Console.ReadLine());
            return op;
        }

    }


}

