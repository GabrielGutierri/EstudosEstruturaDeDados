using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    class Fila
    {
        private Nodo fim = null;
        private Nodo inicio = null;
        int quantidade = 0;

        public int Quantidade
        {
            get
            {
                return quantidade;
            }
        }

        public void Enfileira(string valor)
        {
            Nodo novoNodo = new Nodo();
            novoNodo.Valor = valor;
            novoNodo.Proximo = fim;
            if (quantidade == 0)
            {
                inicio = novoNodo;
            }
            else
            {
                fim.Proximo = novoNodo;
            }
            fim = novoNodo;
            quantidade++;
        }
         
        public string Desenfileira()
        {
            if (quantidade == 0)
                throw new Exception("A fila está vazia!");
            else
            {
                if (inicio != null)
                {
                    string retorno = inicio.Valor;
                    inicio = inicio.Proximo;
                    quantidade--;
                    return retorno;
                }
                throw new Exception("Fila vazia!");  
            }
        } 
        public string RetornaTopo()
        {
            if (quantidade == 0)
                throw new Exception("A fila está vazia!");
            else
            {
                return fim.Valor;
            }
        }

        public string RetornaInicio()
        {
            if (quantidade == 0)
                throw new Exception("A fila está vazia!");
            else
            {
                return inicio.Valor;
            }
        }

        public string MostraFila()
        {
            string resultado = "";
            Nodo t = inicio;
            for (int i = 0; i < quantidade; i++)
            {
                if (i == quantidade - 1)
                    resultado += $"{t.Valor}.";
                else
                    resultado += $"{t.Valor} - ";
                t = t.Proximo;
            }

            return resultado;
        }
    }
}
