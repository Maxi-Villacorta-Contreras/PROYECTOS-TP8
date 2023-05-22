using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Perro
    {
        private String nombre;
        private string raza;
        private double peso;
        private int edad;

        public Perro(string nombre, string raza, double peso, int edad)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.peso = peso;
            this.edad = edad;
        }

        public void mostrarInfo()
        {
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Raza: " + this.raza);
            Console.WriteLine("Peso: " + this.peso + "Kg");
            Console.WriteLine("Edad: " + this.edad + " año");
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}
