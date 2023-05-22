using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Jugador
    {
        private string nombre;
        private int puntaje;
        private string nacionalidad;
        private int edad;
        public Jugador () //constructor vacio
        { }
        public Jugador(string nom, int pun, string nacio, int ed )
        {
            this.Nombre = nom;
            this.Puntaje = pun;
            this.Nacionalidad = nacio;
            this.Edad = ed;
        }
        public Jugador(string nom, int ed)
        {
            this.Nombre = nom;
            this.Edad = ed;
        }
        public void setNombre(string nom)// metodo set del atributo nombre
        {
            this.Nombre = nom;
        }
        public string getNombre()//metodo get del atributo nombre
        {
            return (this.Nombre);
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public int Edad { get => edad; set => edad = value; }

        public void Mostrar()
        {
            Console.WriteLine("Nombre" + this.getNombre());
            Console.WriteLine("Puntaje" + this.Puntaje);
            Console.WriteLine("Nacionalidad" + this.Nacionalidad);
            Console.WriteLine("Edad" + this.Edad);
        }
    }
}
