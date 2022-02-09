using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    class Nodo
    {
        private string valor; 
        private Nodo anterior; 
        public string Valor       
        { 
            get 
            { 
                return valor; 
            } 
            set 
            { 
                valor = value; 
            }         
        } 
        public Nodo Anterior 
        { 
            get 
            { 
                return anterior; 
            } 
            set 
            { 
                anterior = value; 
            }         
        }
    }
}
