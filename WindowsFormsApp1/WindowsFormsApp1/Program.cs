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
            Alumno nuevoalumno = new Alumno("194632126", "Antonia Saez", 2, "Alumno");
            Persona otrapersona = new Persona("190843408", "Joaquin Alonso", "Administrador");
            Administrador admin1 = new Administrador("191234567", "Administrador1", "123456789", "Administrador");
            Cancha cancha1 = new Cancha("futbol1", "Univ Los Andes", 12, "Cancha");
            Cancha cancha2 = new Cancha("futbol2", "Univ Los Andes", 12, "Cancha");
            SalaClases salaclase1 = new SalaClases("Univ Los Andes", "B25", 90, "Sala de Clases");
            string fechayhoraprueba = "2018-03-09 11";
            DateTime fechaprueba = DateTime.ParseExact(fechayhoraprueba, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
            Arriendo arriendoprueba = new Arriendo(nuevapersona, "Alumno", cancha1, "futbol1", 11, fechaprueba);
            Arriendo arriendoprueba2 = new Arriendo(nuevapersona, "Alumno", salaclase1, "B25", 10, fechaprueba);


            nuevoregistro.AgregarUsuario(nuevapersona);
            nuevoregistro.AgregarAlumno(nuevoalumno);
            nuevoregistro.AgregarUsuario(otrapersona);
            nuevoregistro.AgregarAdministrador(admin1);
            nuevoregistro.AgregarUsuario(admin1);
            nuevoregistro.AgregarInstalacion(cancha1);
            nuevoregistro.AgregarInstalacion(cancha2);
            nuevoregistro.AgregarInstalacion(salaclase1);
            nuevoregistro.AgregarCancha(cancha1);
            nuevoregistro.AgregarCancha(cancha2);
            nuevoregistro.AgregarSalaClase(salaclase1);
            nuevoregistro.AgregarArriendo(arriendoprueba);
            nuevoregistro.AgregarArriendo(arriendoprueba2);

            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            Application.Run(new Form1(nuevoregistro));
        }
    }
}
