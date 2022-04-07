using System;

namespace Aula6VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            int i = 0;

            for (i = 0; i < 20; i++) // i = posição que começa com o 0, caso queira comecar no 1, colocar i = 1
            {
                Console.WriteLine($"Posição {i} Entre com o valor que deseja somar: ");
                valor += int.Parse(Console.ReadLine()); // = valor = valor + int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"somatória: {valor}"); // = Console.WriteLine( "somatória: " + valor );



            //fim
        }
    }
}
