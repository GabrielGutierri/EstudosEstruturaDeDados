using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    class Aluno
    {
        public Aluno(string nome, int rA)
        {
            Nome = nome;
            RA = rA;
        }

        public string Nome { get; set; }
        public int RA { get; set; }
    }
}
