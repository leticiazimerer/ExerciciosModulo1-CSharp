using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.src
{
    internal class Henri : Presenca
    {
        public Henri() { }
        public Henri(string nome, int numero, string turma) : base(nome, numero, turma) { }
        public override void Presente(string presente)
        {
            Console.WriteLine($"{presente}");
        }
        //fim
    }
}