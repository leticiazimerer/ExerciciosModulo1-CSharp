using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_Formas.scr
{
    public class Quadrado : FormasGeometricas
    {
        public Quadrado(string v, double _altura, double _base) : base(_altura, _base) { }
        public override double Area()
        {
            double _area = Altura * Base;
            return _area;
        }

        //fim
    }
}