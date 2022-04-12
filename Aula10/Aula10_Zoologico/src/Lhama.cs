using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_Zoologico.src
{
    internal class Lhama : Animal
    {
        public Lhama() { }

        public Lhama(string nome, string cor, int tamanho) : base(nome,cor, tamanho) { }
        public override void Comunicar(string comunicacao)
        {
            Console.WriteLine($"{Nome} está falando: {comunicacao}");
        }









        //fim
    }
}
