using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaCircularEstatica
{
    public class Program
    {
        static void Main(string[] args)
        {
            string opcao = "", valor; 
            Fila minhafila = new Fila();
            
            Console.WriteLine("Sistema em C# para testar a execução de uma fila circular\n"); 
            do { 
                try { 
                    Console.WriteLine("\n\nDigite: 1->Enfileirar 2->Desenfileirar \n" + "3-> Tamanho  4-> Mostrar fim da fila\n" + 
                        "5-> Mostrar início da fila 6-> Mostrar Fila" + "\n7-> Mostrar fila invertida 9->Sair"); 
                    opcao = Console.ReadLine(); 
                    switch (opcao) { 
                        case "1": 
                            Console.WriteLine("Digite um valor para enfileirar:"); 
                            valor = Console.ReadLine(); 
                            minhafila.Enfileirar(valor); 
                            break; 
                        case "2": 
                            Console.WriteLine("Desenfileirado: {0}", minhafila.Desenfileira()); 
                            break; 
                        case "3": 
                            Console.WriteLine("Tamanho da fila:{0}", minhafila.Tamanho()); 
                            break;
                        case "4":
                            Console.WriteLine("Dado no fim: {0}", minhafila.RetornaFim());
                            break;
                        case "5":
                            Console.WriteLine("Dado no início: {0}", minhafila.RetornaInicio());
                            break;
                        case "6":
                            Console.WriteLine("Dados da lista: ");
                            minhafila.Listar();
                            break;
                        case "7":
                            MostraFila(minhafila);
                            break;
                        case "9": 
                            Console.WriteLine("Saindo do sistema..."); 
                            break; 
                        default: 
                            Console.WriteLine("Opção inválida!!!"); 
                            break; 
                    } 
                } catch (Exception erro) { 
                    Console.WriteLine(erro.Message); 
                } 
            } while (opcao != "9");
        }

        //O(3n) = dois whiles + while do listar
        static void MostraFila(Fila fila)
        {
            Pilha p = new Pilha();
            while (fila.Tamanho() > 0)
                p.Empilha(fila.Desenfileira());
            while (p.Tamanho() > 0)
                fila.Enfileirar(p.Desempilha());
            fila.Listar();
        }
    }
}
