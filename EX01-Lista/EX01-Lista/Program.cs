using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gabriel Gutierri da Costa RA:082200014 EC3
            string opcao = "", valor;
            Pilha pilha = new Pilha();
            
            do
            {
                try
                {
                    Console.WriteLine("\nDigite: \n 1-> Empilhar \n " + "2-> Desempilhar \n " + "3-> Tamanho \n " + "9-> Sair");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Digite um valor para empilhar:");
                            valor = Console.ReadLine();
                            pilha.Empilha(valor);
                            break;
                        case "2":
                            string retorno = pilha.Desempilha();
                            Console.WriteLine($"Desempilhado: {retorno}");
                            break;
                        case "3":
                            Console.WriteLine("Tamanho da pilha:{0}", pilha.Tamanho());
                            break;
                        case "9":
                            Console.WriteLine("Saindo do sistema...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida!!!");
                            break;
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            } while (opcao != "9");
        }

        
    }
}
