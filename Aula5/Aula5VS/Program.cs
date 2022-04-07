using System;

namespace Aula5VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string condicaoCursoConcluido = Console.ReadLine();
            int condicaoQuantidadeCursoConcluido = Convert.ToInt32(Console.ReadLine());
            string condicaoQuitacao = Console.ReadLine();
            string condicaoBiblioteca = Console.ReadLine();

            Console.WriteLine("voce concluiu o curso (sim ou nao)? ");
            condicaoCursoConcluido = Console.ReadLine();

            Console.WriteLine("quantos cursos voce concluiu? ");
            condicaoQuantidadeCursoConcluido = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("voce quitou o curso? (sim ou nao) ");
            condicaoQuitacao = Console.ReadLine();

            Console.WriteLine("devolveu os livros? (sim ou nao) ");
            condicaoQuitacao = Console.ReadLine();

            if (condicaoCursoConcluido == "sim" && condicaoQuantidadeCursoConcluido >= 25 && condicaoQuitacao == "sim" && condicaoBiblioteca == "sim")
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("não aprovado!");
            }

            //fim
        }
    }
}
