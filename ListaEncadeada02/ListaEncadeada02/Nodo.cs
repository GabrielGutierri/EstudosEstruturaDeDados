using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada02
{
    public class Nodo
    {
        public string Dado { get; set; }
        public Nodo Proximo { get; set; } 
        ///<summary>/// Construtor sem parâmetros///</summary> 
        public Nodo()      
        {             
            Dado = string.Empty;      
            Proximo = null;      
        } 
    }
}
