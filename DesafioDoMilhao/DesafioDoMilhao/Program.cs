using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDoMilhao
{
    class Program
    {
        //Gabriel Gutierri RA:082200014 EC3
        static HashSet<int> valoresEtapa1 = new HashSet<int>();
        static HashSet<int> valoresEtapa2 = new HashSet<int>();
        static Random randomico = new Random();
        static void Main(string[] args)
        {
            DateTime inicio = DateTime.Now; // guarda a hora inicial

            Etapa1();
            Console.WriteLine("Etapa 1 feita");
            Etapa2();
            Console.WriteLine("Etapa 2 feita");
            OrdenaESalva(valoresEtapa2);
            
            TimeSpan tempo = DateTime.Now.Subtract(inicio); // calcula o total de segundos que demorou o processo

            Console.WriteLine(tempo.TotalSeconds);
            Console.ReadLine();
        }

        static void Etapa1()
        {
            int n = 0;
            bool continua;
            do
            {
                do
                {
                    int valorSorteado = randomico.Next(1, 50000000);
                    if (valoresEtapa1.Contains(valorSorteado))
                        continua = false;
                    else
                    {
                        valoresEtapa1.Add(valorSorteado);
                        continua = true;
                    }
                }
                while (!continua);
                n++;
            }
            while (n < 20000000);
        }

        static void Etapa2()
        {
            int n = 0;
            bool continua;
            do
            {
                do
                {
                    int valorSorteado = randomico.Next(1, 50000000);
                    if (valoresEtapa1.Contains(valorSorteado) || valoresEtapa2.Contains(valorSorteado))
                        continua = false;
                    else
                    {
                        valoresEtapa2.Add(valorSorteado);
                        continua = true;
                    }
                }
                while (!continua);
                n++;
            }
            while (n < 10000000);
           
        }

        static void OrdenaESalva(HashSet<int> set)
        {
            List<int> valoresOrdenados = set.ToList();
            valoresOrdenados.Sort();
            Console.WriteLine("Ordenação feita");

            string caminho = "dados.txt";
            string dados = "";
            foreach (var item in valoresOrdenados)
            {
                dados += item + Environment.NewLine;
            }
            File.AppendAllText(caminho, dados);
        }
    }
}
