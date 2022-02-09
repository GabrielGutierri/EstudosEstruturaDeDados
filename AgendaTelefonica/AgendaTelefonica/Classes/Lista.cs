using AgendaTelefonica.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    class Lista
    {
        Nodo primeiro = null; // ponteiro para o primeiro elemento da lista
        int qtde = 0;


        public int Quantidade
        {
            get { return qtde; }
        }

        public Nodo Inicio { get => primeiro; }
        /// <summary>
        /// Método para inserir um valor na lista
        /// </summary>
        /// <param name="anterior">o nodo que será o anterior ao nodo inserido.
        /// Se o novo nodo for o primeiro, passe null</param>
        /// <param name="valor">o valor a ser inserido</param>
        private void InserirNaPosicao(Nodo anterior, Contato valor)
        {
            Nodo novo = new Nodo();
            novo.Dado = valor;
            if (anterior == null) // indica que é o primeiro da lista
            {
                novo.Proximo = primeiro;
                primeiro = novo;
            }
            else
            {
                novo.Proximo = anterior.Proximo;
                anterior.Proximo = novo;
            }
            qtde++;
        }
        /// <summary>
        /// Insere um valor no início da lista
        /// </summary>
        /// <param name="valor"></param>
        public void InserirNoInicio(Contato valor)
        {
            InserirNaPosicao(null, valor);
        }
        /// <summary>
        /// Insere um valor no final da lista
        /// </summary>
        /// <param name="valor"></param>
        public void InserirNoFim(Contato valor)
        {
            if (qtde == 0)
                InserirNoInicio(valor);
            else
            {
                Nodo aux = primeiro;
                while (aux.Proximo != null)
                    aux = aux.Proximo;
                InserirNaPosicao(aux, valor);
            }
        }
        /// <summary>
        /// Insere em uma posição, iniciando do 0
        /// </summary>
        /// <param name="valor">valor</param>
        /// <param name="posicao">posicao iniciando do 1</param>
        public void InserirNaPosicao(Contato valor, int posicao)
        {
            if (posicao > qtde || posicao < 0)
                throw new Exception("Não é possível inserir.");
            if (posicao == 0)
                InserirNoInicio(valor);
            else
            {
                //descobre qual é o nodo anterior ao que será incluído
                Nodo aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;
                InserirNaPosicao(aux, valor);
            }
        }
        /// <summary>
        /// Remove um elemento da lista com base em sua posição, que inicia
        /// do zero
        /// </summary>
        /// <param name="posicao">posição</param>
        public string RemoverDaPosicao(int posicao)
        {
            string retorno = "";
            if (posicao > qtde || posicao < 0)
                throw new Exception("Não é possível remover.");
            if (posicao == 0)
                primeiro = primeiro.Proximo;
            else
            {
                //descobre qual é o nodo anterior que será excluido
                Nodo aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

                retorno = aux.Proximo.Dado.ToString();

                aux.Proximo = aux.Proximo.Proximo;
            }
            qtde--;

            return retorno;
        }
        /// <summary>
        /// Retorna um string com todos os elementos da lista concatenados
        /// </summary>
        /// <returns></returns>
        public string Listar()
        {
            string r = string.Empty;
            Nodo aux = primeiro;
            while (aux != null)
            {
                r += $"Nome: {aux.Dado.Nome} - Telefone: {aux.Dado.Telefone}" + Environment.NewLine;
                aux = aux.Proximo;
            }
            return r.Trim();
        }

        public bool PesquisarTelefone(string telefone)
        {
            Nodo aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado.Telefone == telefone)
                    return false;
                else
                    aux = aux.Proximo;
            }
            return true;
        }
        public string PesquisaTelPorNome(string nome)
        {
            Nodo aux = primeiro;
            string resultado = "";
            for (int i = 0; i < Quantidade; i++)
            {
                if (aux.Dado.Nome.Contains(nome))
                {
                    resultado += $"Nome: {aux.Dado.Nome} - Telefone: {aux.Dado.Telefone}" + Environment.NewLine;
                }
                aux = aux.Proximo;
            }

            if (resultado == "")
                resultado += "Nome não encontrado ou não foi informado um nome no campo de pesquisa.";
            return resultado;
        }

        public void AlteraNome(string dado, string nome)
        {
            Nodo aux = primeiro;
            if (string.IsNullOrEmpty(dado) || string.IsNullOrEmpty(nome)) 
            {
                throw new Exception("Alteração necessita de um dado e um novo nome.");
            }
            else if (Auxiliar.VerificaTelefone(dado))
            {
                for (int i = 0; i < Quantidade; i++)
                {
                    if (aux.Dado.Telefone == dado)
                    {
                        aux.Dado.Nome = nome;
                    }
                    aux = aux.Proximo;
                }
            }
            else
            {
                for (int i = 0; i < Quantidade; i++)
                {
                    if (aux.Dado.Nome == dado)
                    {
                        aux.Dado.Nome = nome;
                    }
                    aux = aux.Proximo;
                }
            } 
        }

        public void RemoverContato(string dado)
        {
            Nodo aux = primeiro;
            if (string.IsNullOrEmpty(dado))
            {
                throw new Exception("Remoção necessita de um dado.");
            }
            else if (Auxiliar.VerificaTelefone(dado))
            {
                for (int i = 0; i < Quantidade; i++)
                {
                    if (aux.Dado.Telefone == dado)
                    {
                        RemoverDaPosicao(i);
                        return;
                    }
                    aux = aux.Proximo;
                }
            }
            else
            {
                for (int i = 0; i < Quantidade; i++)
                {
                    if (aux.Dado.Nome == dado)
                    {
                        RemoverDaPosicao(i);
                    }
                    aux = aux.Proximo;
                }
            }
        }
    }
}
