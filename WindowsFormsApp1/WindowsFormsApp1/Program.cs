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
            Persona nuevapersona = new Persona("194632126", "Antonia Saez", "Alumno");
            Persona otrapersona = new Persona("190843408", "Joaquin Alonso", "Administrador");
            Administrador admin1 = new Administrador("191234567", "Administrador1", "123456789", "Administrador");
            Cancha cancha1 = new Cancha("futbol1", "Univ Los Andes", 12, "Cancha");
            Cancha cancha2 = new Cancha("futbol2", "Univ Los Andes", 12, "Cancha");


            nuevoregistro.AgregarUsuario(nuevapersona);
            nuevoregistro.AgregarUsuario(otrapersona);
            nuevoregistro.AgregarAdministrador(admin1);
            nuevoregistro.AgregarUsuario(admin1);
            nuevoregistro.AgregarCancha(cancha1);
            nuevoregistro.AgregarCancha(cancha2);

            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            Application.Run(new Form1(nuevoregistro));
        }
    }
}
