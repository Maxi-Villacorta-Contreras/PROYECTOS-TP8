using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Computadora
    {
        private int ram;
        private string procesador;
        private string disco;
        private double memoria;
        private int bits;


        public Computadora(int ram, string procesador, string disco, double memoria, int bits)
        {
            this.ram = ram;
            this.procesador = procesador;
            this.disco = disco;
            this.memoria = memoria;
            this.bits = bits;
        }

        public int Ram
        {
            get { return ram; }
            set { ram = value; }
        }

        public string Procesador
        {
            get { return procesador; }
            set { procesador = value; }
        }

        public string Disco
        {
            get { return disco; }
            set { disco = value; }
        }

        public double Memoria
        {
            get { return memoria; }
            set { memoria = value; }
        }

        public int Bits
        {
            get { return bits; }
            set { bits = value; }
        }
    }
}