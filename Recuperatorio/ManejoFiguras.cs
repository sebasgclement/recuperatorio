using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio
{
    internal class ManejoFiguras
    {
        private List<FiguraGeometrica> figuras = new List<FiguraGeometrica>();

        public void AgregarFigura(FiguraGeometrica figura)
        {
            figuras.Add(figura);
        }

        public List<string> SumatoriaAreaPerimetro()
        {
            var result = new List<string>();

            var tipos = new Dictionary<Type, string>()
        {
            { typeof(Rectangulo), "Rectángulo" },
            { typeof(TrianguloRectangulo), "Triángulo Rectángulo" },
            { typeof(Circulo), "Círculo" }
        };

            foreach (var tipo in tipos)
            {
                double sumaAreas = 0;
                double sumaPerimetros = 0;

                foreach (var figura in figuras)
                {
                    if (tipo.Key.IsInstanceOfType(figura))
                    {
                        sumaAreas += figura.Area();
                        sumaPerimetros += figura.Perimetro();
                    }
                }

                result.Add($"{tipo.Value}: Sumatoria de Áreas {sumaAreas}, Sumatoria Perímetros {sumaPerimetros}");
            }

            return result;
        }

        public List<double> ListadoPerimetrosPorFigura(Type tipo)
        {
            var perimetros = new List<double>();

            foreach (var figura in figuras)
            {
                if (tipo.IsInstanceOfType(figura))
                {
                    perimetros.Add(figura.Perimetro());
                }
            }

            return perimetros;
        }

        public List<double> ListadoAreasPorFigura(Type tipo)
        {
            var areas = new List<double>();

            foreach (var figura in figuras)
            {
                if (tipo.IsInstanceOfType(figura))
                {
                    areas.Add(figura.Area());
                }
            }

            return areas;
        }
    }
}
