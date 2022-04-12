using System;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista");

            Lista<string> lista = new List<string>();

            Lista.Add("yasmin");
            Lista.Add("kaique");
            Lista.Add("let");

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

/*
using System;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista");

            Lista<string> lista = new List<string>();

            for (int i= 0; i < 4; i++)
            {
                console.WriteLine ("entre com o nome: ");
                var nome = Console.ReadLine();
                lista.Add(nome);
            }
            Console.WriteLine("lista: ");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"elementos da lista: {lista.Count}");



            //fim
        }
    }
}
/*