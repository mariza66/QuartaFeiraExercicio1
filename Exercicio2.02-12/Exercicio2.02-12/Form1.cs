using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2._02_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mensagem1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mensagem1.Text = "B";
            mensagem1.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mensagem1.Text = "ba";
            mensagem1.Visible = true;
        }
    }
}
