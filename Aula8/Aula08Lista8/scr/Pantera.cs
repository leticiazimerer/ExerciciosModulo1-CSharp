using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08Lista8.scr
{
    internal class Pantera
    {
        public string nome { get; set; }
        public string corOlho { get; set; }
        public string cor { get; set; }
        public int tamanho { get; set; }
        
        public Pantera (string _nome, string _corOlho, string _cor, int _tamanho)
        {
            nome = _nome;
            corOlho = _corOlho;
            cor = _cor;
            tamanho = _tamanho;

        }

        public void dormir ()
        {
            Console.WriteLine("zzzzzzzz.....");
        }
        public void defecar ()
        {
            Console.WriteLine("estou fazendo minhas necessidades");
        }
        public void cacar ()
        {
            Console.WriteLine("cadê minha presa? ");
        }
        public string rugir ()
        {
            return "rugindo";
        }










        //fim
    }
}
