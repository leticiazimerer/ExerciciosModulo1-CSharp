using System; // importar alguma funcionalidade

namespace _01Conceitos // local/pasta onde está o projeto / pode ser apagado
{
    class Program // podemos ter mais program's, mas em outras pastas somente
    {
        static void Main(string [] args) // todos os arq. em c# tem o static / mostra qual arq. que manda / todo arq. só pode ter 1 static void Main
        {
            // instaciar(criar) um objeto
            Pessoa obj = new Pessoa(); // criando uma pessoa
            obj.nome = "Leticia";
            obj.idade = 22;
            obj.mensagem();

        }
    }  
}