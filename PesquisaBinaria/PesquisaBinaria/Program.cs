using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaBinaria
{
    class Program
    {
        static int BuscaBinaria(int[] array, int chave)
        {
            int inicio = 0, fim = array.Length -1;
            int meio;
            do
            {
                meio = (inicio + fim) / 2;

                if(chave == array[meio])
                {
                    return meio;
                }
                if(chave < array[meio])
                {
                    fim = meio - 1;
                }

                if(chave > array[meio])
                {
                    inicio = meio + 1;
                }
            } while (inicio <= fim);
            return -1;
        }
        static void Main(string[] args)
        {
            int[] array = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            
            int buscaBinaria = BuscaBinaria(array, 20); 
            Console.WriteLine(buscaBinaria);
            Console.ReadLine();
        }
    }
}
