using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade_EX05
{
    class Program
    {
        //Gabriel Gutierri da Costa RA:082200014 EC3
        public static double CalculaPA(double primeiro, double razao, int numeroTermos)
        {
            if(numeroTermos == 0)
            {
                return primeiro;
            }
            else
            {
                Console.WriteLine(primeiro);
                return CalculaPA(primeiro + razao, razao, numeroTermos - 1);
            }
        }
        
        static void Main(string[] args)
        {
            double primeiro;
            double razao;
            int numeroTermos;

            do
            {
                LacoRepeticao("Insira o primeiro termo da P.A: ", out primeiro);
                LacoRepeticao("Insira a razão da P.A: ", out razao);
                LacoRepeticao("Insira o número de termos da P.A: ", out numeroTermos);
                CalculaPA(primeiro, razao, numeroTermos);
                Console.WriteLine("Deseja continuar? [S para sair] ");
                if (Console.ReadLine() == "S")
                    break;
            } while (true);
            
            Console.ReadLine();
        }

        static void LacoRepeticao(string mensagem, out double valor)
        {
            do
            {
                Console.WriteLine(mensagem);
                bool ehDouble = double.TryParse(Console.ReadLine(), out valor);
                if (ehDouble) break;
            } while (true);
        }

        static void LacoRepeticao(string mensagem, out int valor)
        {
            do
            {
                Console.WriteLine(mensagem);
                bool ehInt = int.TryParse(Console.ReadLine(), out valor);
                if (ehInt) break;
            } while (true);
        }
    }
}
