using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.src
{
    internal class Henrique : Presenca
    {
        public Henrique() { }
        public Henrique(string nome, int numero, string turma) : base(nome, numero, turma) { }
        public override void Presente(string presente)
        {
            Console.WriteLine($"{presente}");
        }
        //fim
    }
}
