﻿using System;

namespace Aula7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.Write("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine()); //ler o numero

            Console.Write("Digite o operador: ");
            string operador = Console.ReadLine();

             Console.Write("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            switch (operador)
                {
                    case "+":
                    Console.WriteLine($"Resultado: {Somar(num1,num2)}"); //interpolação
                    break;

                    case "-":
                    Console.WriteLine("Resultado: " + Subtrair(num1,num2));
                    break;

                    case "*":
                    Console.WriteLine("Resultado: " + Multiplicar(num1,num2));
                    break;

                    case "/":
                    Console.WriteLine("Resultado: " + Dividir(num1,num2));
                    break;

                    default:
                    Console.WriteLine("Operador Invalido!");
                    break;
                    
                } 


        }

        public static string Somar (int num1, int num2) //metodo
        {
            return(num1 + num2).ToString();
        }

         public static string Subtrair (int num1, int num2) //metodo
        {
            return(num1 - num2).ToString();
        }

         public static string Multiplicar (int num1, int num2) //metodo
        {
            return(num1 * num2).ToString();
        }

           public static string Dividir (int num1, int num2) //metodo
        {
            if (valorDividendoMenorOuIgualQue0 (num2))
            {
                return "nao é possivel dividir por 0";
            }

            return(num1 / num2).ToString();

            bool valorDividendoMenorOuIgualQue0(int num2) //função
                {
                    if (num2 <= 0)
                        {
                            return true;
                        }
                        return false;
                }
        }


        //fim
    }
}
