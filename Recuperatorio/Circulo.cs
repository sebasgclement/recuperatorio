using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Recuperatorio
{
    internal class Circulo:FiguraGeometrica
    {
        public double Radio { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}
