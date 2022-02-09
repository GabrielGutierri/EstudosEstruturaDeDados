using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDuplamenteEncadeada
{
   public  class Nodo
    {
        public string Dado { get; set; }
        public Nodo Proximo { get; set; }
        public Nodo Anterior { get; set; }
        ///<summary>/// Construtor sem parâmetros///</summary> 
        public Nodo()
        {
            Dado = string.Empty;
            Proximo = null;
            Anterior = null;
        }
    }
}
