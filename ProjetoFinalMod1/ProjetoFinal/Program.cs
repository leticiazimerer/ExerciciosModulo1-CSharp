using System;
using System.Collections.Generic;
using ProjetoFinal.src;


namespace ProjetoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boa Tarde, Professores! Para consultar a Lista de Chamada de hoje, aperte ENTER: ");
            Console.ReadLine();
            Console.WriteLine("Processando...");
            Console.WriteLine("Lista pronta! Aperte ENTER novamente para ver ");
            Console.ReadLine();

            List<Presenca> presencas = new List<Presenca>(new Presenca[]{
            new Aurora("Aurora", 1, "Turma 1 .NET"),
            new Arthur("Arthur", 2, "Turma 1 .NET"),
            new Cecilia("Cecilia", 3, "Turma 1 .NET"),
            new Clara("Clara", 4, "Turma 1 .NET"),
            new Fernanda("Fernanda", 5, "Turma 1 .NET"),
            new Henri("Henri", 6, "Turma 1 .NET"),
            new Henrique("Henrique", 7, "Turma 1 .NET"),
            new Jade("Jade", 8, "Turma 1 .NET"),
            new Lucca("Lucca", 9, "Turma 1 .NET"),
            new Luigi("Luigi", 10, "Turma 1 .NET"),
            new Theo("Theo", 11, "Turma 1 .NET"),
             }
                 );
            foreach ( Presenca presenca in presencas)
            {
                if (presenca.Numero == 1)
                {
                    Console.Write($"Aluno: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Turma} - ");
                    presenca.Presente("Presente");
                    Console.WriteLine("Aperte enter para continuar");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 2)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Turma} - "); presenca.Presente("Presente");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 3)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Turma} - "); presenca.Presente("Presente");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 4)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Turma} - "); presenca.Presente("Falta");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 5)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Turma} - "); presenca.Presente("Presente");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 6)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Turma} - "); presenca.Presente("Falta");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 7)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Turma} - "); presenca.Presente("Presente");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 8)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Turma} - "); presenca.Presente("Falta");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 9)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Turma} - "); presenca.Presente("Presente");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 10)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Turma} - "); presenca.Presente("Falta");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 11)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Turma} - "); presenca.Presente("Falta");
                    Console.ReadLine();
                    Console.WriteLine("Lista Finalizada");
                }
            }
            //fim
        }
    }
}
