using System;
using System.Collections.Generic;
using Aula10_Zoologico.src;

namespace Aula10_Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoologico");
            List<Animal> animais = new List<Animal>(
                new Animal[]
                {
                    new Lhama("Lhama Thamyres", "cinza", 10),
                    new Lhama("Lhama Kauanne", "branca", 8),
                    new Barata("Lhama Leticia", "cinza", 10),
                    new Barata("Lhama Evandra", "branca", 8),
                    new Grilo("Lhama Guilherme", "cinza", 10),
                    new Grilo("Lhama Guilherme", "branca", 8),

                }
                );
            foreach (Animal animal in animais)
            {
                if (animal.Tamanho == 10)
                {
                    Console.WriteLine($"{animal.Nome} tem um tamanho: {animal.Tamanho} ");
                    animal.Comunicar("olá, meu tamanho´é 10, sou enooooorme!");
                }
                else if (animal.Tamanho == 8)
                {
                    Console.WriteLine($"{animal.Nome} tem um tamanho: {animal.Tamanho} ");
                    animal.Comunicar("olá, meu tamanho´é 8, sou menorzinho!");

                }

            }

            //fim
        }
    }
}
