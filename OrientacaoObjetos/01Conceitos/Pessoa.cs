using System; // por que queremos exibir uma mensagem

class Pessoa // é um molde (algo abstrato, generico)
{
    // Atributos
    public string nome; //
    public int idade;

    // Metodos
    public void mensagem() // void: nao ha retorno / este metodo vai exibir a mensagem abaixo
    {
        Console.WriteLine($"Olá {nome}, você tem {idade} anos");
    }
}
