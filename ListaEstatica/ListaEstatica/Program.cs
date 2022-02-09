using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "", valor; 
            int posicao; 
            ListaEstatica minhaLista = new ListaEstatica();
            
            Console.WriteLine("Sistema em C# para testar a execução de uma lista estática\n"); 
            do 
            { 
                try 
                { 
                    Console.WriteLine("\nDigite: \n 1-> Inserir no início \n " + "2-> Inserir no fim \n " + "3-> Inserir em uma posição (lembre-se que inicia do do zero!)\n " + "4-> Tamanho \n 5-> Listar \n " + "6-> Remover elemento de uma posição \n 9-> Sair"); 
                    opcao = Console.ReadLine(); 
                    switch (opcao) 
                    { 
                        case "1": 
                            Console.WriteLine("Digite um valor para inserir no início:"); 
                            valor = Console.ReadLine(); 
                            minhaLista.InsereNoInicio(valor); 
                            break; 
                        case "2": 
                            Console.WriteLine("Digite um valor para inserir no fim:");
                            valor = Console.ReadLine(); 
                            minhaLista.InsereNoFim(valor); 
                            break; 
                        case "3": 
                            Console.WriteLine("Digite um valor para inserir:"); 
                            valor = Console.ReadLine(); 
                            Console.WriteLine("Digite a posição:"); 
                            posicao = Convert.ToInt32(Console.ReadLine()); 
                            minhaLista.InsereNaPosicao(posicao, valor); 
                            break; 
                        case "4": 
                            Console.WriteLine("Tamanho da lista:{0}", minhaLista.Tamanho());
                            break; 
                        case "5": 
                            minhaLista.ImprimeLista(); 
                            break; 
                        case "6": 
                            Console.WriteLine("Digite a posição que deseja remover:");
                            posicao = Convert.ToInt32(Console.ReadLine()); 
                            Console.WriteLine("Removido:{0}", minhaLista.RemoveDaPosicao(posicao)); 
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
