using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador marcelo = new Jugador(); //utilizo el constructor vacio
            Jugador ramon = new Jugador("Ramon", 32); //utilizo el constructor de 2 parametros
            Jugador zulma = new Jugador("Zulma", 123, "Argentina",45); //utilizo el constructor de  parametros

            marcelo.setNombre("Cano");
            marcelo.Edad = 35;
            marcelo.Nacionalidad = "Argentino";
            Console.WriteLine(marcelo.getNombre());
            Console.WriteLine(marcelo.Nacionalidad);
            zulma.Mostrar();

            Console.ReadKey();



        }
    }
}
