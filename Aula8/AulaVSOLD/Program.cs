using System;

namespace Aula8
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato frajola;

            Gato garfield = new Gato( "Garfield", "laranja", 8 );
            Gato tomas = new Gato ("Thomas", "cinza",5 );
            Gato frajola = new Gato();

            String objeto = new String(String.Empty)

            frajola = new Gato();
            frajola.Nome = "Frajola";
            frajola.Cor = "preto";
            frajola.Tamanho = "4";

            Console.WriteLine($"Gato 1 é o {garfield.Nome} de cor {garfield.Cor}, e tamanho {garfield.Tamanho}");
            Console.WriteLine($"Gato 2 é o {tomas.Nome} de cor {tomas.Cor}, e tamanho {tomas.Tamanho}");
            Console.WriteLine($"Gato 3 é o {frajola.Nome} de cor {frajola.Cor}, e tamanho {frajola.Tamanho}");

            garfield.comer ("Lazanha");
            tomas.comer ();
           string retorno frajola. ronronar();
            Console.WriteLine(retorno);


       //fim
        }
    }
}
