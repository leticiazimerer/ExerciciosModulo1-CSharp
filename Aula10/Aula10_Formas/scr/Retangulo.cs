using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_Formas.scr
{
    internal class Retangulo : FormasGeometricas
    {
        public Retangulo(string v, double _altura, double _base) : base(_base, _altura) { }
        public override double Area()
        {
            double _area = Base * Altura;
            return _area;
        }
    }

    //fim
}