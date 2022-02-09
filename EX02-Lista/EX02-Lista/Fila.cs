using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02_Lista
{
    public class Fila
    {
        Lista listaDaFila;

        public Fila()
        {
            listaDaFila = new Lista();
        }
        public int Tamanho()
        {
            return listaDaFila.Tamanho();
        }
        // enfileira um valor string 
        public void Enfileirar(string p_valor)
        {
            try
            {
                listaDaFila.InsereNoFim(p_valor);
            }
            catch
            {
                throw new Exception("A fila está cheia.");
            }
        } // remove o primeiro elemento da fila e devolve. 
        public string Desenfileira()
        {
            try
            {
                return listaDaFila.RemoveDaPosicao(0);
            }
            catch
            {
                throw new Exception("A fila está vazia.");
            }
        }
    }
}
