using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio
{
    internal abstract class FiguraGeometrica
    {
        public string Color { get; set; }
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }
        public decimal Angulo { get; set; }
        public int Identificador { get; set; }

        public abstract double Area();
        public abstract double Perimetro();
    }
}
