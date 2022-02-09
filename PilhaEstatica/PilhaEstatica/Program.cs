using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();
            pilha.Empilha("Joao");
            pilha.Empilha("Pedro");
            pilha.Empilha("Maria");
            pilha.Empilha("Claudia");

            while (pilha.Tamanho() > 0)
            {
                Console.WriteLine($"{pilha.Desempilha()} - {pilha.Desempilha()}");
            }
            Console.ReadLine();
        }
    }
}
