using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_Zoologico.src
{
    internal class Grilo : Animal
    {
        public Grilo () { }
        public Grilo(string name, string cor, int tamanho) : base (name, cor, tamanho) { }
        public override void Comunicar(string comunicacao)
        {
            Console.WriteLine($"{Nome} está falando: {comunicacao}");
        }




        //fim
    }
}
