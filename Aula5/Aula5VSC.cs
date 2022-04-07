using System;

namespace Aula5VSC
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("entre com o valor vendido mensal: ");
            double valorVendido = double.Parse( Console.ReadLine());

            if (valorVendido <= 10000)
            {
                Console.WriteLine("o valor a receber R$ " + (valorVendido * 0.01));
            }
            else if (valorVendido <= 20000)
            {
                Console.WriteLine("o valor a receber R$ " + (valorVendido * 0.02));
            }
            else if (valorVendido <= 3000)
            {
                Console.WriteLine("o valor a receber R$ " + (valorVendido * 0.03));
            }
            else
            {
                Console.WriteLine("o valor a receber R$ " + valorVendido * 0.01);
            }
            //fim
        }
    }
}
