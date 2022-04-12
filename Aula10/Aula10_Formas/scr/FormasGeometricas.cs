using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_Formas.scr
{
public abstract class FormasGeometricas
{
    public double Altura { get; set; }
    public double Base { get; set; }
    public FormasGeometricas (double _altura, double _base)
    {
        Altura = _altura;
        Base = _base;
    }
    public abstract double Area();
}
}