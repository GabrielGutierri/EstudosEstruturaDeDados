using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstatica
{
    public class Pilha
    {
        private const int CAPACIDADE = 5;
        private string[] vetor = new string[CAPACIDADE];
        private int topo = -1;

        public int Tamanho()
        {
            return topo + 1;
        }

        public bool Vazia()
        {
            return Tamanho() == 0;
        }

        public void Empilha(string param)
        {
            if (Tamanho() != CAPACIDADE)
            {
                topo++;
                vetor[topo] = param;
            }
            else
            {
                throw new Exception("Pilha já está na sua capacidade total");
            }
        }

        public string Desempilha()
        {
            if (Vazia() == true)
            {
                throw new Exception("A pilha está vazia");
            }
            else
            {
                string textoTopo = vetor[topo];
                vetor[topo] = null;
                topo--;
                return textoTopo;
            }
        }

        public string Topo()
        {
            if (!Vazia())
                return vetor[topo];
            else
                throw new Exception("A pilha está vazia!");
        }

        public void MostraVetor()
        {
            foreach (var elemento in vetor)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
