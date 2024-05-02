using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    internal static class Program
    {
        //clase principal o clase papá que guardará los metodos de lectura de valores y almacendao de valores en variables
        //NOMBRE DE CLASE
        class operación
        {
            //declaración de variables que usa la clase
            //tipo de acceso    tipo de dato    nombre de dato
            protected           int             valor1;
            protected           int             valor2;
            protected           int             resultado;
           
        }
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
