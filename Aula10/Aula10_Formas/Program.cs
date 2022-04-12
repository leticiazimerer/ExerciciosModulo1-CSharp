using System;
using System.Collections.Generic;
using Aula10_Formas.scr;


namespace Aula10_Formas
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Área");

            Quadrado Quadrado1 = new("quadrado", 20, 40);
            Retangulo Retangulo1 = new ("retangulo", 30, 15);
            Triangulo Triangulo1 = new ("triangulo", 10, 15);

            Console.WriteLine($"a area do {Quadrado1} é: {Quadrado1.Area()}");
            Console.WriteLine($"a area do {Retangulo1} é: {Retangulo1.Area()}");
            Console.WriteLine($"a area do {Triangulo1} é: {Retangulo1.Area()}");


            //fim
        }
    }
}
