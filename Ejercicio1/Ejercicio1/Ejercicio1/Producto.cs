using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Producto
    {
        private int codigo;
        private string descripcion;
        private double precio;
        private int stock;

        public Producto(int codigo, string descripcion, double precio, int stock)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}