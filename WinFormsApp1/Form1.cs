using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
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
            OperacionFracciones objetoFracciones = new OperacionFracciones(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
             switch(comboBox1.Text)
            {
                case "+":
                    objetoFracciones.sumar();
                    break;
                case "-":
                    objetoFracciones.restar();
                    break;
                case "x":
                    objetoFracciones.multiplicar();
                    break;
                case "/":
                    objetoFracciones.dividir();
                    break;
                default:
                    break;
            }

            label2.Text = objetoFracciones.getResultado1().ToString() + "/" + objetoFracciones.getResultado2().ToString();
        }
    }
}
