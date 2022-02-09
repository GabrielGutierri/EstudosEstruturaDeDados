using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    class Nodo
    {
        public Contato Dado { get; set; }
        public Nodo Proximo { get; set; }
        /// <summary>
        /// Construtor sem parâmetros
        /// </summary>
        public Nodo()
        {
            Dado = null;
            Proximo = null;
        }
    }
}
