using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDuplasComListas
{
    class Program
    {
        //Gabriel Gutierri da Costa     RA:082200014    EC3
        static int SorteiaValor(List<int> alunos)
        {
            Random gerador = new Random();
            int posicaoSorteada = gerador.Next(0, alunos.Count);
            int alunoSorteado = alunos[posicaoSorteada];
            alunos.RemoveAt(posicaoSorteada);
            return alunoSorteado;
        }

        static List<string> MontaDuplas(List<int> alunos)
        {
            var duplas = new List<string>();

            while (alunos.Count >= 2)
            {
                int primeiroSorteio = SorteiaValor(alunos);
                int segundoSorteio = SorteiaValor(alunos);
                duplas.Add(primeiroSorteio + "," + segundoSorteio);
            }

            if (alunos.Count == 1)                                          
                duplas[0] = duplas[0] + "," + alunos[0];

            return duplas;
        }

        static void Main(string[] args)
        {

            int[] RAs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 30 };
            List<int> listaRAs = new List<int>(RAs);

            var retorno = MontaDuplas(listaRAs);

            foreach (string dupla in retorno)
                Console.WriteLine(dupla);

            Console.ReadLine();
        }
    }
}
