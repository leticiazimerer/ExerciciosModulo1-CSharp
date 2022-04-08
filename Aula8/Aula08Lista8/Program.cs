using Aula08Lista8.scr;
using System;

namespace Aula08Lista8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pantera");
            Pantera tera = new Pantera("tera", "azul", "preta", 12);
            Pantera pan = new Pantera("pan", "marrom", "branca", 8);
            Pantera molly = new Pantera("molly", "branca", "listrada", 20);
            Pantera fera = new Pantera("fera", "verde", "branca", 5);

            Console.WriteLine($"o nome da Pantera é: {tera.nome}, a cor so seu olho é: {tera.corOlho}, a cor da sua pelugem é: {tera.cor} e seu tamanho é: {tera.tamanho}");
            Console.WriteLine($"o nome da Pantera é: {pan.nome}, a cor so seu olho é: {pan.corOlho}, a cor da sua pelugem é: {pan.cor} e seu tamanho é: {pan.tamanho}");
            Console.WriteLine($"o nome da Pantera é: {molly.nome}, a cor so seu olho é: {molly.corOlho}, a cor da sua pelugem é: {molly.cor} e seu tamanho é: {molly.tamanho}");
            Console.WriteLine($"o nome da Pantera é: {fera.nome}, a cor so seu olho é: {fera.corOlho}, a cor da sua pelugem é: {fera.cor} e seu tamanho é: {fera.tamanho}");


            tera.dormir();
            pan.defecar();
            molly.cacar();
            string retorno = fera.rugir();
            Console.WriteLine(retorno);






        }
    }
}
