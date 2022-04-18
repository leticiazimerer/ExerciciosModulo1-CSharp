using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.src
{
    internal class Presenca
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public string Turma { get; set; }
        public Presenca() { }
        public Presenca ( string nome, int numero, string turma)
        {
            Nome = nome;
            Numero = numero;
            Turma = turma;
        }
        public virtual void Presente(string presente)
        {
            Console.WriteLine($"{presente}");
        }
        //fim
    }
}
