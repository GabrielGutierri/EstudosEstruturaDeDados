using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03Listas
{
    public class Lista
    {
        private const int CAPACIDADE = 32;
        private Aluno[] dados = new Aluno[CAPACIDADE];
        private int quantidade = 0;

        public int Tamanho()
        {
            return quantidade;
        }
        public void InsereNaPosicao(int p_posicao, Aluno p_valor)
        {
            if (Tamanho() == CAPACIDADE)
                throw new Exception("A lista está cheia!!!\n\n");
            else if (p_posicao > Tamanho())
                throw new Exception("Não é possível inserir nesta posição");
            else
            {
                if (VerificaRA(p_valor))
                {
                    quantidade++;
                    for (int i = Tamanho() - 1; i > p_posicao; i--)
                    {
                        dados[i] = dados[i - 1];
                    }
                    dados[p_posicao] = p_valor;
                }
                
            }
        }
        public Aluno RemoveDaPosicao(int posicao)
        {
            if (Tamanho() == 0)
                throw new Exception("A lista está vazia!!!");
            else if (posicao > Tamanho() - 1)
                throw new Exception("Posição inválida!!!");
            else
            {
                Aluno aux = dados[posicao];
                for (int i = posicao; i < Tamanho() - 1; i++)
                {
                    dados[i] = dados[i + 1];
                }
                quantidade--;
                return aux;
            }
        }
        public void InsereNoInicio(Aluno p_valor)
        {
            InsereNaPosicao(0, p_valor);
        }
        public void InsereNoFim(Aluno p_valor)
        {
            InsereNaPosicao(Tamanho(), p_valor);
        }

        public string RetornaPrimeiro()
        {
            if (Tamanho() == 0)
                throw new Exception("A lista está vazia.");
            return $"Nome: {dados[0].Nome} - RA: {dados[0].RA}";
        }

        public string RetornaUltimo()
        {
            if (Tamanho() == 0)
                throw new Exception("A lista está vazia.");
            return $"Nome: {dados[Tamanho() - 1].Nome} - RA: {dados[Tamanho() - 1].RA}";
        }

        public string PesquisaPorRA(string ra)
        {
            for(int i=0; i<=Tamanho()-1; i++)
            {
                if(dados[i].RA == ra)
                {
                    return $"Nome: {dados[i].Nome} - RA: {dados[i].RA}";
                }
            }
            throw new Exception("Esse RA não existe");
        }

        public bool VerificaRA(Aluno a)
        {
            for (int i = 0; i < Tamanho(); i++) { 
                if(dados[i].RA == a.RA)
                {
                    throw new Exception("Esse RA já foi cadastrado.");
                }
            }
            return true;
        }
    }
}
