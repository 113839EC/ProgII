using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoApp
{
    public abstract class Producto : IPrecio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public abstract double CalcularPrecio();

        //public double CalcularPrecio()
        //{
        //    return Precio;
        //}


    }
}
