using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gabriel Gutierri da Costa RA:082200014 EC3

            string opcao = "", valor;
            Fila fila = new Fila();
            
            do
            {
                try
                {
                    Console.WriteLine("\nDigite: \n 1-> Enfileirar \n " + "2-> Desenfileirar \n " + "3-> Tamanho \n" + "9-> Sair");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Digite um valor para enfileirar:");
                            valor = Console.ReadLine();
                            fila.Enfileirar(valor);
                            break;
                        case "2":
                            string retorno = fila.Desenfileira();
                            Console.WriteLine($"Desenfileirado: {retorno}");
                            break;
                        case "3":
                            Console.WriteLine("Tamanho da fila:{0}",fila.Tamanho());
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
