using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        /*
         * En un nuevo proyecto para un juego de ajedrez, nos piden modelar e implementar una clase que
         * representa una Pieza de dicho juego. Usted deberá pensar que atributos serían necesarios para describir las
         * características de dicha clase, agregarle los métodos getter y setter correspondientes y luego probar desde
         * el main de la clase principal del proyecto. 
         */

        static void Main(string[] args)
        {
            Rey rey = new Rey("Rey", "Negro", 1, 1, 4);

            Console.WriteLine("\n---------------------------------------------------------------------------------------\n");

            Console.WriteLine("Datos de la pieza de Ajedrez:\n");

            rey.mostrarInfo();

            Console.WriteLine("\n---------------------------------------------------------------------------------------\n");


            Console.ReadKey();
        }
    }
}
