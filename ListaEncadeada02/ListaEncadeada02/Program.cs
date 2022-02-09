using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada02
{
    class Program
    {
        //Gabriel Gutierri da Costa RA:082200014 EC3
        static void Main(string[] args)
        {
            string opcao = "", valor; 
            int posicao; 
            Lista minhaLista = new Lista();
            LinkedList<string> lista = new LinkedList<string>();
            Console.WriteLine("Sistema em C# para testar a execução de uma lista estática\n"); 
            do 
            { 
                try 
                { 
                    Console.WriteLine("\nDigite: \n 1-> Inserir no início \n " + 
                        "2-> Inserir no fim \n " + 
                        "3-> Inserir em uma posição (lembre-se que inicia do do zero!)\n " + 
                        "4-> Tamanho \n 5-> Listar \n " + "6-> Remover elemento de uma posição \n " +
                        "7-> Pesquisar por nome \n 9-> Sair"); 
                    opcao = Console.ReadLine(); 
                    switch (opcao) 
                    { 
                        case "1": 
                            Console.WriteLine("Digite um valor para inserir no início:"); 
                            valor = Console.ReadLine(); 
                            minhaLista.InserirNoInicio(valor); 
                            break; 
                        case "2": 
                            Console.WriteLine("Digite um valor para inserir no fim:"); 
                            valor = Console.ReadLine(); minhaLista.InserirNoFim(valor); 
                            break; 
                        case "3": 
                            Console.WriteLine("Digite um valor para inserir:"); 
                            valor = Console.ReadLine(); 
                            Console.WriteLine("Digite a posição:"); 
                            posicao = Convert.ToInt32(Console.ReadLine()); 
                            minhaLista.InserirNaPosicao(valor, posicao); 
                            break; 
                        case "4": 
                            Console.WriteLine("Tamanho da lista:{0}", minhaLista.Quantidade); 
                            break; 
                        case "5": 
                            valor = minhaLista.Listar();
                            Console.WriteLine(valor);
                            break; 
                        case "6": 
                            Console.WriteLine("Digite a posição que deseja remover:"); 
                            posicao = Convert.ToInt32(Console.ReadLine());
                            minhaLista.RemoverDaPosicao(posicao);
                            break;
                        case "7":
                            Console.WriteLine("Insira um nome para pesquisar.");
                            valor = Console.ReadLine();
                            if (minhaLista.Pesquisar(valor, out Nodo encontrado))
                                Console.WriteLine($"Elemento encontrado: {encontrado.Dado}");
                            else
                                Console.WriteLine($"Esse elemento não existe");
                            break;
                        case "8":
                            Console.WriteLine($"último: {minhaLista.Ultimo.Dado}");
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
            } 
            while (opcao != "9");
        }
    }
}
