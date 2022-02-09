using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursividadeEX01
{
    class Program
    {
        //Gabriel Gutierri da Costa RA:082200014 EC3
        static int CalculaPotencia(int p_base, int p_expoente)
        {
            if (p_expoente == 0)
                return 1;
            else if(p_expoente >= 2)
            {
                return p_base * CalculaPotencia(p_base, p_expoente - 1);
            }
            return p_base;
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CalculaPotencia(8, 10));
            Console.ReadLine();

        }
    }
}
