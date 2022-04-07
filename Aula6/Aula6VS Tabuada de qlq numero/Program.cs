using System;

namespace Aula6VS_Tabuada_de_qlq_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Escreva algum nº para fazer a Tabuada: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= 10; x++)
            {
               
                for (int y = 1; y <= 10; y++)
                {
                    Console.WriteLine(x + "x" + n + "=" + x * n);
                    x++;
                }

            }



            //fim
        }
    }
}
