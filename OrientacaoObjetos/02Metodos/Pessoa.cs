using System;

class Pessoa
{

    // metodo 01
    public void apresentar()
    {
        Console.WriteLine("Olá!!");
    }
        // metodo 02
    public void apresentar(string nome)
    {
        Console.WriteLine($"Olá {nome}");
    }

        // metodo 03
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine($"Olá {nome}, você tem {idade}!");
    }
}