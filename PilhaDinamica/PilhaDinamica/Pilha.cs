using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    class Pilha
    {
        private Nodo topo = null; 
        // quantidade de elementos na pilha 
        int quantidade = 0; 
        public int Quantidade 
        { 
            get 
            { 
                return quantidade; 
            } 
        } 
        ///<summary> /// Método para empilhar strings ///</summary> ///<param name="valor"></param> 
        public void Empilha(string valor)      
        { 
            Nodo novoNodo = new Nodo();      
            novoNodo.Valor = valor;    
            novoNodo.Anterior = topo;         
            topo = novoNodo;         
            quantidade++;       
        } 
        ///<summary> /// Desempilhar elementos da pilha ///</summary> ///<returns></returns> 
        public string Desempilha()     
        { 
            if (quantidade == 0) 
                throw new Exception("A pilha está vazia!"); 
            else             
            { 
                string retorno = topo.Valor;       
                topo = topo.Anterior;          
                quantidade--; 
                return retorno;           
            }       
        } ///<summary> /// Método para retornar o topo da pilha ///</summary> ///<returns></returns> 
        public string RetornaTopo()         
        { 
            if (quantidade == 0) 
                throw new Exception("A pilha está vazia!"); 
            else        
            { 
                return topo.Valor;         
            }      
        }

        public string MostraPilha()
        {
            string resultado = "";

            Nodo auxiliar = topo;
            while(auxiliar != null)
            {
                resultado += $"{auxiliar.Valor} - ";
                auxiliar = auxiliar.Anterior;
            }
            return resultado;
        }
    }
}
