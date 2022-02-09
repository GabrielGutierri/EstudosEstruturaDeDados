using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class Form1 : Form
    {
        //Gabriel Gutierri da Costa RA:082200014 EC3
        public Form1()
        {
            InitializeComponent();
            txtDados.Text = "";
        }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string telefone = txtTelefone.Text;

                Contato contato = new Contato(nome, telefone);
                Contato.contatos.InserirNoFim(contato);
                
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDados.Text = Contato.contatos.Listar();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            txtDados.Text = Contato.contatos.PesquisaTelPorNome(txtPesquisa.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Contato.contatos.AlteraNome(txtAlterar.Text, txtNovoNome.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato.contatos.RemoverContato(txtPesquisa.Text);
        }
    }
}
