using HERENCIA1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija sumar
            Sumar suma = new Sumar(); //instancie, o
                                      //hice un nuevo objeto suma
                                      //llamar al metodo de clase suma operar
            resultado.Text = suma.operar
            (float.Parse(valor1.Text), float.Parse(valor2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija dividir
            try
            {
                Dividir division = new Dividir(); //instancie, o
                                                  //hice un nuevo objeto resta
                                                  //llamar al metodo de clase restar operar
                resultado.Text = division.operar
                (float.Parse(valor1.Text), float.Parse(valor2.Text)).ToString();
            }
            catch(ArgumentException ex) { 
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                valor1.Clear();
                valor2.Clear();
            }
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija multiplicar
            Multiplicar multiplicar = new Multiplicar(); //instancie, o
                                                         //hice un nuevo objeto multiplicacion
                                                         //llamar al metodo de clase multiplicar operar
            resultado.Text = multiplicar.operar
            (float.Parse(valor1.Text), float.Parse(valor2.Text)).ToString();
        }

        private void restar_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija restar
            Restar resta = new Restar(); //instancie, o
                                         //hice un nuevo objeto resta
                                         //llamar al metodo de clase restar operar
            resultado.Text = resta.operar
            (float.Parse(valor1.Text), float.Parse(valor2.Text)).ToString();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            valor1.Clear();
            valor2.Clear();
            resultado.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void valor1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
