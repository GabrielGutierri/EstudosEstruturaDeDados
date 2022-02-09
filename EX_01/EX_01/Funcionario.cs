using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_01
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }
    }
}
