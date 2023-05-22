using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Rey
    {
        private string tipo;
        private string color;
        private int cantidadMovimientos;
        private int fila;
        private int columna;

        public Rey(string tipo, string color, int cantidadMovimientos, int fila, int columna)
        {
            this.tipo = tipo;
            this.color = color;
            this.cantidadMovimientos = cantidadMovimientos;
            this.fila = fila;
            this.columna = columna;
        }

        public void mostrarInfo()
        {
            Console.WriteLine("Tipo de pieza: " + this.tipo);
            Console.WriteLine("Color: " + this.color);
            Console.WriteLine("Cantidad de Movimientos: " + this.cantidadMovimientos);
            Console.WriteLine("Fila en la que se encuentra: " + this.fila + " fila");
            Console.WriteLine("Columna en la que se encuentra: " + this.columna + " columna");
        }

        public string Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int CantidadMovimientos
        {
            get { return cantidadMovimientos; }
            set { cantidadMovimientos = value; }
        }

        public int Fila
        {
            get { return fila; }
            set { fila = value; }
        }

        public int Columna
        {
            get { return columna; }
            set { columna = value; }
        }
    }
}
