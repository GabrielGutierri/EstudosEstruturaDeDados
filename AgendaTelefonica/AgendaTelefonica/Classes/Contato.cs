using AgendaTelefonica.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    
    class Contato
    {
        private string nome;
        private string telefone;

        public static Lista contatos = new Lista();

        public string Nome { 
            get => nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("nome obrigatório.");
                }
                else
                    nome = value;
            }
        }
        public string Telefone {
            get => telefone;
            private set {
                if (!Auxiliar.VerificaTelefone(value))
                    throw new Exception("telefone está em um formato inválido.");

                else
                {
                    string[] telefoneSplitado = value.Replace('(', ' ').Replace(')', ' ').Replace('-', ' ').Split(' ');
                    string telefoneFormatado = string.Join("", telefoneSplitado);

                    if (!contatos.PesquisarTelefone(telefoneFormatado))
                        throw new Exception("o telefone já existe.");
                    telefone = telefoneFormatado;
                }
            } 
        }
        public Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Telefone: {Telefone}";
        }
    }
}
