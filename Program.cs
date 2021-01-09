using System;
using primeiro_projeto.Exemplos;

namespace primeiro_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pilha();
            p.Empilha(1);
            p.Empilha(10);
            p.Empilha(100);            
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
        }
    }
}
