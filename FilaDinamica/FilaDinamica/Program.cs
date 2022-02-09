using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gabriel Gutierri da Costa RA:082200014 EC3
            int opcao = 0;
            string valor;
            Fila minhaFila = new Fila(); // cria uma instância da classe pilha!
            do
            {
                try
                {
                    Console.Write("\n\n Escolha: 1-> enfileira 2->desenfileira " +
                    " 3->topo 4-> tamanho "+" 5->inicio 6->mostrar fila 9-> sair : ");
                    opcao = Convert.ToInt32(Console.ReadLine());
                    if (opcao == 1)
                    {
                        Console.Write(">>Digite o valor que deseja enfileirar: ");
                        valor = Console.ReadLine();
                        minhaFila.Enfileira(valor);
                    }
                    else if (opcao == 2)
                    {
                        valor = minhaFila.Desenfileira();
                        Console.WriteLine(">>Desenfileirado: {0} \n\n", valor);
                    }
                    else if (opcao == 3)
                    {
                        valor = minhaFila.RetornaTopo();
                        Console.WriteLine(">>Valor no topo: {0} \n\n", valor);
                    }
                    else if (opcao == 4)
                    {
                        Console.WriteLine(">>Tamanho da fila: {0}", minhaFila.Quantidade);
                    }
                    else if (opcao == 5)
                    {
                        valor = minhaFila.RetornaInicio();
                        Console.WriteLine(">>Valor no inicio: {0}", valor);
                    }
                    else if (opcao == 6)
                    {
                        valor = minhaFila.MostraFila();
                        Console.WriteLine(">>Fila: {0}", valor);
                    }
                    else if (opcao == 9)
                    {
                        // sai do programa
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine("ERRO: " + erro.Message);
                }
            }
            while (opcao != 9);
        }
    
    }
}
