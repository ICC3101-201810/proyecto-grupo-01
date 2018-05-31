using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
            Alumno nuevoalumno = new Alumno("194632126", "Antonia Saez", 2, "Alumno");
            //Persona otrapersona = new Persona("190843408", "Joaquin Alonso", "Administrador");
            Administrador admin1 = new Administrador("191234567", "Administrador1", "123456789", "Administrador");
            Profesor nuevoprofesor = new Profesor("10443292", "Juan Perez", 1, "Profesor");
            Cancha cancha1 = new Cancha("futbol1", "Univ Los Andes", 12, "Cancha");
            Cancha cancha2 = new Cancha("futbol2", "Univ Los Andes", 12, "Cancha");
            SalaClases salaclase1 = new SalaClases("Univ Los Andes", "B25", 90, "Sala de Clases");
            SalaClases salaclase2 = new SalaClases("Univ Los Andes", "B26", 80, "Sala de Clases");
            SalaEstudio salaestudio1 = new SalaEstudio("C15", "Sala de Estudios", 6, "Univ Los Andes");
            SalaEstudio salaestudio2 = new SalaEstudio("C20", "Sala de Estudios", 5, "Univ Los Andes");
            EspaciosPublicos espaciopub1 = new EspaciosPublicos("Auditorio Biblioteca", 100, "Univ Los Andes", "Espacios Públicos");
            EspaciosPublicos espaciospub2 = new EspaciosPublicos("Comedor Reloj", 50, "Univ Los Andes", "Espacios Públicos");
            string fechayhoraprueba = "2018-03-09 11";
            DateTime fechaprueba = DateTime.ParseExact(fechayhoraprueba, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
            Arriendo arriendoprueba = new Arriendo(nuevoalumno, "Alumno", cancha1, "futbol1", 11, fechaprueba);
            Arriendo arriendoprueba2 = new Arriendo(nuevoalumno, "Alumno", salaclase1, "B25", 10, fechaprueba);
            Arriendo arriendoprueba3 = new Arriendo(nuevoprofesor, "Profesor", salaclase2, "B26", 10, fechaprueba);
            Eventos eventorprueba = new Eventos(arriendoprueba2, "Charla Gatos", 10);
            Eventos eventosprueba2 = new Eventos(arriendoprueba3, "Clase Ciencias", 10);


            //nuevoregistro.AgregarUsuario(nuevapersona);
            nuevoregistro.AgregarAlumno(nuevoalumno);
            nuevoregistro.AgregarUsuario(nuevoalumno);
            nuevoregistro.AgregarProfesor(nuevoprofesor);
            nuevoregistro.AgregarUsuario(nuevoprofesor);
            nuevoregistro.AgregarAdministrador(admin1);
            nuevoregistro.AgregarUsuario(admin1);
            nuevoregistro.AgregarInstalacion(cancha1);
            nuevoregistro.AgregarInstalacion(cancha2);
            nuevoregistro.AgregarInstalacion(salaclase1);
            nuevoregistro.AgregarInstalacion(salaclase2);
            nuevoregistro.AgregarInstalacion(salaestudio1);
            nuevoregistro.AgregarInstalacion(salaestudio2);
            nuevoregistro.AgregarInstalacion(espaciopub1);
            nuevoregistro.AgregarInstalacion(espaciospub2); 
            nuevoregistro.AgregarCancha(cancha1);
            nuevoregistro.AgregarCancha(cancha2);
            nuevoregistro.AgregarSalaClase(salaclase1);
            nuevoregistro.AgregarSalaClase(salaclase2);
            nuevoregistro.AgregarSalaEstudio(salaestudio1);
            nuevoregistro.AgregarSalaEstudio(salaestudio2);
            nuevoregistro.AgregarEspacioPublico(espaciopub1);
            nuevoregistro.AgregarEspacioPublico(espaciospub2);
            nuevoregistro.AgregarArriendo(arriendoprueba);
            nuevoregistro.AgregarArriendo(arriendoprueba2);
            nuevoregistro.AgregarArriendo(arriendoprueba3);
            nuevoregistro.AgregarEventos(eventorprueba);
            nuevoregistro.AgregarEventos(eventosprueba2);
            BinaryFormatter bin = new BinaryFormatter();
            if (File.Exists("../../Serialized.txt"))
            {
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Open, FileAccess.Read);
                nuevoregistro = (RegistroHistorico)bin.Deserialize(stream);
                stream.Close();
            }


                Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            Application.Run(new Form1(nuevoregistro));
        }
    }
}
