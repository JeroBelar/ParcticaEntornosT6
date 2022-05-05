using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcticaEntornosT6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(Numero1.Text);
            int numero2 = int.Parse(Numero2.Text);

            int resultado = numero + numero2;

            label1.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int numero = int.Parse(Numero1.Text);
            int numero2 = int.Parse(Numero2.Text);

            int resultado = numero - numero2;

            label1.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int numero = int.Parse(Numero1.Text);
            int numero2 = int.Parse(Numero2.Text);

            int resultado = numero * numero2;

            label1.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int numero = int.Parse(Numero1.Text);
            int numero2 = int.Parse(Numero2.Text);

            int resultado = numero / numero2;

            label1.Text = resultado.ToString();
        }
    }
}
