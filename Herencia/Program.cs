using Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIA1
{
    /*clase principal o clase papá que guardará los metodos de lectura de valores y almacenado de valores en variables*/
    //nombre de clase
    class operacion
    {
        //declaracion de variables que usa la clase
        //tipo de acceso    tipo de dato    nombre de dato
        protected float valor1;
        protected float valor2;
        protected float resultado;

        //atributos de la clase operación
        //metodos o fuciones de operacion
        /*los metodos que se ponen acontinuacón
         * son las funciones de obtener el valor
         * de la caja de texto y guardarlo en la 
         * memoria dentro de la variable indicada*/
        //constructor de dato valor 1
        public float Valor1
        {
            get { return valor1; } //vamos por el valor de la caja de texto
            set { valor1 = value; }//lo guardamos en memoria
        }
        public float Valor2
        {
            get { return valor2; } //vamos por el valor de la caja de texto
            set { valor2 = value; }//lo guardamos en memoria
        }

        public float Resultado
        {
            get { return resultado; } //vamos por el valor de la caja de texto
            set { resultado = value; }//lo guardamos en memoria
        }
    }
    //creamos nuestra clase hijo que usara los
    //metodos de crear dato
    class Sumar : operacion //los : nos dan permiso de usar lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus propios atributos y métodos
        //pueden tener variables de uso solamente para la clase hijo
        //declarar variables de esta clase
        //atributos de esta clase
        //metodos de clase
        public float operar(float v1, float v2)
        {
            valor1 = v1; //accemos al constructor de operación
            valor2 = v2;
            return resultado = valor1 + valor2;
        }
    }
    class Restar : operacion //los : nos dan permiso de usar lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus propios atributos y métodos
        //pueden tener variables de uso solamente para la clase hijo
        //declarar variables de esta clase
        //atributos de esta clase
        //metodos de clase
        public float operar(float v1, float v2)
        {
            valor1 = v1; //accemos al constructor de operación
            valor2 = v2;
            return resultado = valor1 - valor2;
        }
    }
    class Multiplicar : operacion //los : nos dan permiso de usar lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus propios atributos y métodos
        //pueden tener variables de uso solamente para la clase hijo
        //declarar variables de esta clase
        //atributos de esta clase
        //metodos de clase
        public float operar(float v1, float v2)
        {
            valor1 = v1; //accemos al constructor de operación
            valor2 = v2;
            return resultado = valor1 * valor2;
        }
    }

    class Dividir : operacion //los : nos dan permiso de usar lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus propios atributos y métodos
        //pueden tener variables de uso solamente para la clase hijo
        //declarar variables de esta clase
        //atributos de esta clase
        //metodos de clase
        public float operar(float v1, float v2)
        {
            valor1 = v1; //accemos al constructor de operación
            valor2 = v2;
            if (valor1 == 0)
            {
                throw new ArgumentException("No se puede dividir por cero");//lanza una advertencia de un error que ocurre cuando se está corriendo el programa.
            }
            else if (valor2 == 0)
            {
                throw new ArgumentException("No se puede dividir por cero");//lanza una advertencia de un error que ocurre cuando se está corriendo el programa.
            }
            return resultado = valor1 / valor2;
        }
    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
