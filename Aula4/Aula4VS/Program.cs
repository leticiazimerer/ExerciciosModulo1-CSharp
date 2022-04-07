using System;

namespace _04._04._2022___Aula_VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre com seu nome: ");
            string nome = Console.ReadLine(); // lê a variavel nome que é string

            Console.WriteLine("entre com sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine()); // lê a idade que é inteiro = int

            Console.WriteLine("oi " + nome + "\nQue legal que voce tem " + idade + "anos de idade")
;
        }
    }
}

