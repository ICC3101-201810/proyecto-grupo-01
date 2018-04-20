using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Proyecto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de reserva de instalaciones!!");
            DateTime n = new DateTime(2, 0, 0);
            Console.WriteLine("hora:" + n);
            //Creamos un administrador para que nadie pueda hacerse pasar por el y modificar.
            Administrador admin1 = new Administrador("191234567", "Administrador1", "123456789", "Administrador");
            Alumno alumn1 = new Alumno("194632126", "Antonia Saez", 2, "Alumno");
            Profesor prof1 = new Profesor("139827892", "Juan Perez", 1, "Profesor");
            Funcionario fun1 = new Funcionario("106732541", "Andres Soto", 3, "Funcionario");
            Cancha cancha = new Cancha("futbol1", "Univ Los Andes", 12, "Cancha");
            SalaClases salaclas = new SalaClases("Biblioteca", 33, 90, "Sala Clases");
            SalaEstudio salaestudio = new SalaEstudio(25, "Sala Estudio", 5, "Reloj");
            EspaciosPublicos esppubl = new EspaciosPublicos("Auditorio", 100, "Biblioteca", "Espacio Publico");
            RegistroHistorico nuevoregistro = new RegistroHistorico();
            nuevoregistro.AgregarUsuario(admin1);
            nuevoregistro.AgregarAdministrador(admin1);
            nuevoregistro.AgregarUsuario(alumn1);
            nuevoregistro.AgregarAlumno(alumn1);
            nuevoregistro.AgregarUsuario(prof1);
            nuevoregistro.AgregarProfesor(prof1);
            nuevoregistro.AgregarUsuario(fun1);
            nuevoregistro.AgregarFuncionario(fun1);
            nuevoregistro.AgregarInstalacion(cancha);
            nuevoregistro.AgregarCancha(cancha);
            nuevoregistro.AgregarInstalacion(salaclas);
            nuevoregistro.AgregarSalaClase(salaclas);
            nuevoregistro.AgregarInstalacion(salaestudio);
            nuevoregistro.AgregarSalaEstudio(salaestudio);
            nuevoregistro.AgregarInstalacion(esppubl);
            nuevoregistro.AgregarEspacioPublico(esppubl);

            //Como mostrar lista usuarios 
            nuevoregistro.MostrarListaUsuarios();

            //Hay que ingresar un par de alumnos para comprobar que funciona
            Console.WriteLine("Ingrese su rut");
            var rut = Console.ReadLine();
            
            nuevoregistro.VerificarUsuarioExistente(rut);
            Persona persona1 = nuevoregistro.VerificarUsuarioExistente(rut);
            nuevoregistro.MostrarListaUsuarios();
            
            
            
            //si ya estaba creado preguntar
            while (true)
            {
                Console.WriteLine("Desea a)Arrendar una instalacion, b)Revisar los eventos disponibles, c)Agregar una instalacion");
                var respuesta1 = Console.ReadLine();
                try
                {
                    if (respuesta1 == "a")
                    {
                        Console.WriteLine("Cual de las siguientes desea reservar: a)Cancha, b)Sala de Estudio, c) Sala de Clase o d)Espacio Público?");
                        var respuesta2 = Console.ReadLine();
                        try
                        {
                            if (respuesta2 == "a")
                            {
                                Console.WriteLine("Ha escogido la opcion reservar Cancha");            
                                Console.WriteLine("Escriba la cantidad de participantes:");
                                var cantparticipantes = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese fecha de la sgte forma (dia mes año) de la solicitud de reserva");
                                var fecha = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("Ingrese hora de la sgte forma (hora:minuto:segundo AM/PM) de la solicitud de reserva");
                                var hora = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("Que tipo de cancha busca?: Futbol o Tenis");
                                var tipocancha = Console.ReadLine();
                                nuevoregistro.VerificarExistenciaCancha(tipocancha);
                                Cancha cancha1 = nuevoregistro.VerificarExistenciaCancha(tipocancha);
                                Arriendo nuevoArriendo = new Arriendo(persona1, cancha1, cantparticipantes, fecha, hora);
                                //Arriendo nuevoarriendo = new Arriendo(persona,  
                                //RegistroHistorico.ConsultarDisponibilidad(nuevoarriendo);

                            }
                            if (respuesta2 == "b")
                            {
                                Console.WriteLine("Ha escogido la opcion reservar Sala de Estudio");
                                Console.WriteLine("Escriba la cantidad de participantes:");
                                var cantparticipantes = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese fecha y hora de la sgte forma (dia mes año) de la solicitud de reserva");
                                var fecha = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("Ingrese hora de la sgte forma (hora:minuto:segundo AM/PM) de la solicitud de reserva");
                                var hora = Convert.ToDateTime(Console.ReadLine());
                            }
                            if (respuesta2 == "c")
                            {
                                Console.WriteLine("Ha escogido la opcion reservar Sala de Clase");
                                Console.WriteLine("Escriba la cantidad de participantes:");
                                var cantparticipantes = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese fecha y hora de la sgte forma (dia mes año) de la solicitud de reserva");
                                var fecha = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("Ingrese hora de la sgte forma (hora:minuto:segundo AM/PM) de la solicitud de reserva");
                                var hora = Convert.ToDateTime(Console.ReadLine());

                            }
                            if (respuesta2 == "d")
                            {
                                Console.WriteLine("Ha escogido la opcion reservar Espacio Público");
                                Console.WriteLine("Escriba la cantidad de participantes:");
                                var cantparticipantes = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese fecha y hora de la sgte forma (dia mes año) de la solicitud de reserva");
                                var fecha = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("Ingrese hora de la sgte forma (hora:minuto:segundo AM/PM) de la solicitud de reserva");
                                var hora = Convert.ToDateTime(Console.ReadLine());
                            }
                            
                        }
                        catch
                        {
                            Console.WriteLine("Opcion no valida, intente de nuevo");
                        }
                    }
                    if (respuesta1 == "b")
                    {
                        Console.WriteLine("Ha escogido revisar los eventos disponibles!");
                    }
                    if (respuesta1 == "c")
                    {
                        Console.WriteLine("Ha escogido agregar una nueva instalacion!");
                        Console.WriteLine("Para verificar que de verdad es el administrador, escriba su contraseña");
                        var contraseña = Console.ReadLine();
                        try
                        {
                            if (admin1.Confirmarcontraseña(contraseña))
                            {
                                Console.WriteLine("Verificacion realizada con exito!");
                                Console.WriteLine("Ingrese su tipo de instalacion(Sala de Clase, Sala Estudio, Cancha, Espacio Publico");
                                var mitipoinstalacion = Console.ReadLine();
                                Console.WriteLine("Ingrese la capacidad (numero) de su instalacion");
                                var micapacidad = int.Parse(Console.ReadLine());
                                Console.WriteLine("Escriba la ubicacion de su instalacion");
                                var miubicacion = Console.ReadLine();
                                Instalacion instalacionnueva = new Instalacion(mitipoinstalacion, micapacidad, miubicacion);
                                if (mitipoinstalacion == "Sala de Clase")
                                {
                                    Console.WriteLine("Que numero de sala desea que esta sea?(escoja una inexistente)");
                                    var minumerosala = int.Parse(Console.ReadLine());
                                    SalaClases nuevasala = new SalaClases(miubicacion, minumerosala, micapacidad, mitipoinstalacion);

                                }
                            }

                        }
                        catch
                        {
                            Console.WriteLine("Usted no es el administrador");
                        }
                        
                        
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Opcion no valida, intente de nuevo");
                }
            }
            
            
        
            
        }
    }
}
