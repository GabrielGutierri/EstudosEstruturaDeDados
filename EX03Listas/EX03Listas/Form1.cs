using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX03Listas
{
    public partial class Form1 : Form
    {
        //Gabriel Gutierri da Costa RA:082200014 EC3
        public Form1()
        {
            InitializeComponent();
            btnPesquisar.Enabled = false;
            txtResultado.Enabled = false;
        }

        static Lista lista = new Lista();
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                lista.InsereNoFim(new Aluno(txtNome.Text, txtRA.Text));
                MessageBox.Show($"{lista.Tamanho()} - {lista.RetornaUltimo()} - {lista.RetornaPrimeiro()}");
                btnPesquisar.Enabled = true;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisa.Text))
            {
                MessageBox.Show("campo obrigatório.");
            }
            else
            {
                try
                {
                    txtResultado.Text = lista.PesquisaPorRA(txtPesquisa.Text);
                    txtResultado.Enabled = true;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
