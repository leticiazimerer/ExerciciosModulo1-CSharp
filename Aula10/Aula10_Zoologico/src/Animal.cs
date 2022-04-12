using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_Zoologico.src
{
    public class Animal

    {
        public string Nome { get; set; } // "get e set" GET: podemos acessar pelo nome e e SET: alterar o que está dentro dele
        public string Cor { get; set; }
        public int Tamanho { get; set; }

        public Animal() { }

        public Animal(string nome, string cor, int tamanho)
        {
            Nome = nome;
            Cor = cor;
            Tamanho = Tamanho;
        }
        public virtual void Comunicar(string comunicacao)
        {
            Console.WriteLine($"{Nome} está falando: {comunicacao}");
        }
        //fim
    }
}

