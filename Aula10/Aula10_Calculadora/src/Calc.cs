using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_Calculadora.src
{
    internal class Calc : IOperações
    {
        public double Dividir(double a, double b)
        {
            return a / b;
        }
        public double Multiplicar(double a, double b)
        {
            return (a * b);
        }
        public double Somar(double a, double b)
        {
            return (a + b);
        }
        public double Subtrair(double a, double b)
        {
            return (a - b);
        }








        //fim
    }
}
