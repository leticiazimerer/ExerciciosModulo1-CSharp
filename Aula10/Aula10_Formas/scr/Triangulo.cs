using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_Formas.scr
{
    public class Triangulo : FormasGeometricas
    {
        public Triangulo(string v, double _altura, double _base) : base(_altura, _base) { }
        public override double Area()
        {
            double area = (Altura * Base) / 2;
            return area;
        }

    }

    //fim
}
