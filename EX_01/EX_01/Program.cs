using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Feito por Gabriel Gutierri da Costa RA: 082200014
            int opcao = 0;
            string valor;
            Funcionarios func = new Funcionarios();

            do
            {
                try
                {
                    Console.Write("\n\n Escolha: 1-> empilha  2->desempilha  " + " 3->topo  4-> tamanho  5-> Listar dados  6-> Somar Salários  9-> sair : "); 
                    opcao = Convert.ToInt32(Console.ReadLine()); 
                    if (opcao == 1) { 
                        Console.Write(">>Digite o valor que deseja empilhar: "); 
                        valor = Console.ReadLine();
                        Funcionario f = new Funcionario(valor, 10000);
                        func.Empilha(f);
                    }
                    else if(opcao == 2)                     
                    { 
                        Funcionario f = func.Desempilha(); 
                        Console.WriteLine(">>Desempilhado: {0} \n\n", f.Nome); 
                    }
                    else if(opcao == 3)                     
                    {
                        Funcionario f = func.Topo(); 
                        Console.WriteLine(">>Valor no topo: {0} \n\n", f.Nome); 
                    }
                    else if(opcao == 4)                     
                    { 
                        Console.WriteLine(">>Tamanho da pilha: {0}", func.Tamanho()); 
                    }
                    else if(opcao == 5)
                    {
                        MostraPilha(func);
                    }

                    else if(opcao == 6)
                    {
                        SomaSalario(func);
                    }
                    else if(opcao == 7)
                    {
                        RemoveBase(func);
                    }
                    else if(opcao == 9)                     
                    { // sai do programa                     
                    }     
                }
                catch(Exception erro)
                {
                    Console.WriteLine("ERRO: " + erro.Message);
                }
            } while (opcao != 9);

            
            Console.ReadLine();
        }

        //Complexidade: O(2n)
        static void MostraPilha(Funcionarios func)
        {
            Funcionarios pilhaAuxiliar = new Funcionarios();

            //O(n)
            while (func.Tamanho() > 0)
            {
                Funcionario f = func.Desempilha();
                Console.WriteLine($"Nome: {f.Nome} - Salário: {f.Salario}");
                pilhaAuxiliar.Empilha(f);
            }

            //O(n)
            while(pilhaAuxiliar.Tamanho() > 0)
            {
                func.Empilha(pilhaAuxiliar.Desempilha());
            }
        }

        //Complexidade: O(2n)
        static void SomaSalario(Funcionarios func)
        {
            Funcionarios pilhaAuxiliar = new Funcionarios();
            double soma = 0;
            while (func.Tamanho() > 0)
            {
                Funcionario f = func.Desempilha();
                soma += f.Salario;
                pilhaAuxiliar.Empilha(f);
            }

            while (pilhaAuxiliar.Tamanho() > 0)
            {
                func.Empilha(pilhaAuxiliar.Desempilha());
            }
            Console.WriteLine($"Soma: R$ {soma:F2}");
        }

        //Complexidade: O(2n)
        static void RemoveBase(Funcionarios func)
        {
            Funcionarios pilhaAuxiliar = new Funcionarios();
            while (func.Tamanho() > 1)
            {
                pilhaAuxiliar.Empilha(func.Desempilha());
            }

            Funcionario f = func.Desempilha();
            Console.WriteLine($"Base: {f.Nome}");
            while (pilhaAuxiliar.Tamanho() > 0)
            {
                func.Empilha(pilhaAuxiliar.Desempilha());
            }
            
        }
    }
}
