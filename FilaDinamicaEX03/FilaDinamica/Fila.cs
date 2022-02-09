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

        public void Enfileira(Aluno valor)
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
         
        public Aluno Desenfileira()
        {
            if (quantidade == 0)
                throw new Exception("A fila está vazia!");
            else
            {
                if (inicio != null)
                {
                    Aluno retorno = inicio.Valor;
                    inicio = inicio.Proximo;
                    quantidade--;
                    return retorno;
                }
                throw new Exception("Fila vazia!");  
            }
        } 
        public Aluno RetornaTopo()
        {
            if (quantidade == 0)
                throw new Exception("A fila está vazia!");
            else
            {
                return fim.Valor;
            }
        }

        public Aluno RetornaInicio()
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
                    resultado += $"Nome: {t.Valor.Nome}, RA: {t.Valor.RA}.";
                else
                    resultado += $"Nome: {t.Valor.Nome}, RA: {t.Valor.RA} - ";
                t = t.Proximo;
            }

            return resultado;
        }
    }
}
