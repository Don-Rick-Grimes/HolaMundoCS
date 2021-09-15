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
            button1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OperacionFracciones objetoFracciones = new OperacionFracciones(decimal.ToInt32(numericUpDown1.Value),decimal.ToInt32(numericUpDown2.Value) , decimal.ToInt32(numericUpDown3.Value), decimal.ToInt32(numericUpDown4.Value));
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

        private void NumericUpDown2_Leave(object sender, EventArgs e)
        {
            if(numericUpDown2.Value==0)
            {
                numericUpDown2.Value = 1;
            }
        }

        private void NumericUpDown4_Leave(object sender, EventArgs e)
        {
            if (numericUpDown4.Value == 0)
            {
                numericUpDown4.Value = 1;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }
    }
}
