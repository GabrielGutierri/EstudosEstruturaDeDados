using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursividadeEX04
{
    //Gabriel Gutierri da Costa RA:082200014 EC3
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextboxes(this);
        }

        public static void ClearTextboxes(Control container)
        {
            foreach (Control ctl in container.Controls)//controls = elementos que consigo colocar outros elementos dentro dele.
            {
                var textBox = ctl as TextBox;
                if (textBox != null)
                { 
                    textBox.Clear(); 
                }
                var masked = ctl as MaskedTextBox;
                if(masked != null)
                {
                    masked.Clear();
                }
                if (ctl.Controls.Count > 0)
                { 
                    ClearTextboxes(ctl); 
                }
            }
        }
    }
}
