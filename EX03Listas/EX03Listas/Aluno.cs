using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03Listas
{
    public class Aluno
    {
        private string _nome;
        private string _ra;

        public string Nome {
            get => _nome;
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("nome obrigatório.");
                }
                _nome = value;       
            } 
        }

        public string RA { get => _ra;
            set { 
                if(value.Length > 9 || string.IsNullOrEmpty(value))
                {
                    throw new Exception("RA obrigatório.");
                }
                _ra = value;
            } 
        }

        public Aluno(string nome, string ra)
        {
            RA = ra;
            Nome = nome;
        }
    }
}
