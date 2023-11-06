using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio
{
    internal class Rectangulo: FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return Base * Altura;
        }

        public override double Perimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
