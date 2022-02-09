using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_01
{
    class Funcionarios
    {
        private const int CAPACIDADE = 5;
        private Funcionario[] funcionarios = new Funcionario[CAPACIDADE];

        private int topo = -1;

        //Complexidade: O(1)
        public int Tamanho()
        {
            return topo + 1;
        }

        //Complexidade: O(1)
        public void Empilha(Funcionario func)
        {
            if (Tamanho() != CAPACIDADE)
            {
                topo++;
                funcionarios[topo] = func;
            }
            else
            {
                throw new Exception("Pilha já está na sua capacidade total");
            }
        }

        //Complexidade: O(1) -> instruções não variam com a quantidade de elementos
        public Funcionario Desempilha()
        {
            if (Tamanho() == 0)
            {
                throw new Exception("A pilha está vazia");
            }
            else
            {
                Funcionario funcTopo = funcionarios[topo];
                funcionarios[topo] = null;
                
                topo--;
                return funcTopo;
            }
        }

        //Complexidade: O(1)
        public Funcionario Topo()
        {
            if (Tamanho() == 0)
                throw new Exception("A pilha está vazia!");
            else    
                return funcionarios[topo];
        }
        
    }
}
