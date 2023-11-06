using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio
{
    internal class TrianguloRectangulo: FiguraGeometrica
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public override double Area()
        {
            // Fórmula para el área de un triángulo rectángulo
            double semiperimetro = (Lado1 + Lado2 + Lado3) / 2;
            return Math.Sqrt(semiperimetro * (semiperimetro - Lado1) * (semiperimetro - Lado2) * (semiperimetro - Lado3));
        }

        public override double Perimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }
}
