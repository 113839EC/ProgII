using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoApp
{
    internal class Suelto : Producto
    {
        public int Medida { get; set; }

        public Suelto() : base()
        {

        }

        public override double CalcularPrecio()
        {
            return Precio * Medida;
        }
    }
}
