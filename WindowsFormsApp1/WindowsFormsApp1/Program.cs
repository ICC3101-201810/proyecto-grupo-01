using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegistroHistorico nuevoregistro = new RegistroHistorico();
            Persona persona = null;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(nuevoregistro, persona));
        }
    }
}
