using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaCircularEstatica
{
    class Fila
    {
        const int CAPACIDADE = 4;
        private int quantidade = 0;
        private int inicio = 0;
        private int fim = 0;
        private string[] dados = new string[CAPACIDADE];

        // retorna o tamanho da fila 
        public int Tamanho(){ 
            return quantidade;         
        } 
        // enfileira um valor string 
        public void Enfileirar(string p_valor)         
        { 
            if (Tamanho() == CAPACIDADE)             
            { 
                throw new Exception("A fila está cheia!!!!");             
            } else             
            {                 
                dados[fim] = p_valor;                 
                fim = (fim + 1) % CAPACIDADE;                 
                quantidade++;             
            }         
        } // remove o primeiro elemento da fila e devolve. 
        public string Desenfileira()         
        { 
            if (Tamanho() == 0)             
            { 
                throw new Exception("A fila está vazia!");                             
            } else             
            { 
                string valor = dados[inicio];
                dados[inicio] = null;
                inicio = (inicio + 1) % CAPACIDADE;                
                quantidade--;
                return valor;             
            }         
        }
        
        public string RetornaInicio()
        {
            if (Tamanho() == 0)
                throw new Exception("A fila está vazia!");
            return dados[inicio];
        }

        public string RetornaFim()
        {
            if (Tamanho() == 0)
                throw new Exception("A fila está vazia!");
            if (fim == 0)
                return dados[CAPACIDADE -1];
            return dados[fim -1];
        }

        public void Listar()
        { 
            int qtde = Tamanho();
            int posicaoAtual = inicio;

            while(qtde > 0)
            {
                Console.WriteLine(dados[posicaoAtual]);
                posicaoAtual = (posicaoAtual + 1) % CAPACIDADE;
                qtde--;
            }
        }
    }
}
