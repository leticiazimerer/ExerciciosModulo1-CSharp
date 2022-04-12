using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_Zoologico.src
{
    internal class Barata : Animal
    {
        public Barata() { }
        public Barata (string nome, string cor, int tamanaho) : base(nome, cor, tamanaho) { }
        public override void Comunicar(string comunicacao)
        {
            Console.WriteLine($"{Nome} está falando: {comunicacao}");
        }







    }
        //fim
    
}
