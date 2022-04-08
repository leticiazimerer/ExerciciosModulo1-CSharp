using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8VS.src
{
   
    public class Gato
    {
        public string Nome { get; set; } // "get e set" GET: podemos acessar pelo nome e e SET: alterar o que está dentro dele
        public string Cor { get; set; }
        public int Tamanho { get; set; }

        public Gato()
        {

        }


        public Gato(string _nome, string _cor, int _tamanho)
        {
            Nome = _nome;
            Cor = _cor;
            Tamanho = _tamanho;
        }

        public void dormir()
        {
            Console.WriteLine("zzzzzzzzzzzz..");

        }
        public void comer(string comida)
        {
            Console.WriteLine($"Estou comendo {comida}");
        }
        public string ronronar()
        {
            Console.WriteLine($"Estou comendo {comida}");



        }


        //fim
    }
}



