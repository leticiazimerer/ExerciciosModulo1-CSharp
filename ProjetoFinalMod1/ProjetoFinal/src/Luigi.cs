using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.src
{
    internal class Luigi : Presenca
    {
        public Luigi() { }
        public Luigi(string nome, int numero, string turma) : base(nome, numero, turma) { }
        public override void Presente(string presente)
        {
            Console.WriteLine($"{presente}");
        }
        //fim
    }
}