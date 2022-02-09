using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursividadeEX03
{
    class Program
    {
        //Gabriel Gutierri da Costa RA:082200014 EC3
        static void ImprimeTabuada(int numero, int multiplicador = 10)
        {
            Console.WriteLine($"{numero} x {multiplicador} = {numero * multiplicador}");
            if (multiplicador >= 1)
            {
                ImprimeTabuada(numero, multiplicador - 1);   
            }

        }
        static void Main(string[] args)
        {
            ImprimeTabuada(9);
            Console.ReadLine();
        }
    }
}
