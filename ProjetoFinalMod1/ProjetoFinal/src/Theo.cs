using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.src
{
    internal class Theo : Presenca
    {
        public Theo() { }
        public Theo(string nome, int numero, string turma) : base(nome, numero, turma) { }
        public override void Presente(string presente)
        {
            Console.WriteLine($"{presente}");
        }
        //fim
    }
}