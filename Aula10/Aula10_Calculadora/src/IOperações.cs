using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_Calculadora.src
{
    internal interface IOperações
    {
        public double Dividir { get; set; }
        public double Multiplicar { get; set; }
        public double Somar { get; set; }
        public double Subtrair { get; set; }


    }
}
