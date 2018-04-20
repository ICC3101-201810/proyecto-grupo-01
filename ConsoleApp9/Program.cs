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
            //Creamos un administrador para que nadie pueda hacerse pasar por el y modificar.
            Administrador admin1 = new Administrador("191234567", "Administrador1", "123456789");
            RegistroHistorico nuevoregistro = new RegistroHistorico();
            nuevoregistro.AgregarUsuario(admin1);
            //Como mostrar lista usuarios 
            nuevoregistro.MostrarListaUsuarios();

            //Hay que ingresar un par de alumnos para comprobar que funciona
            Console.WriteLine("Ingrese su rut");
            var rut = Console.ReadLine();
            
            nuevoregistro.VerificarUsuarioExistente(rut); //Deberia retornar persona
            
            
            
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
                                Console.WriteLine("Desea arrendar a)Cancha de Futbol1, b)Cancha de futbol 2 o c)Cancha de tenis");
                                var respuesta3 = Console.ReadLine();
                                try
                                {
                                    if (respuesta3 == "a")
                                    {
                                        Console.WriteLine("Ha escogido la opcion reservar Cancha de Futbol 1");
                                        Console.WriteLine("Escriba la cantidad de participantes:");
                                        var cantparticipantes = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese fecha y hora de la sgte forma (dia mes año) de la solicitud de reserva");
                                        var fecha = Convert.ToDateTime(Console.ReadLine());
                                        Console.WriteLine("Ingrese hora de la sgte forma (hora:minuto:segundo AM/PM) de la solicitud de reserva");
                                        var hora = Convert.ToDateTime(Console.ReadLine());
                                        //Arriendo nuevoarriendo = new Arriendo(, 
                                        //RegistroHistorico.ConsultarDisponibilidad(nuevoarriendo);
                                    }
                                    if (respuesta3 == "b")
                                    {
                                        Console.WriteLine("Ha escogido la opcion reservar Cancha de Futbol 2");
                                        Console.WriteLine("Escriba la cantidad de participantes:");
                                        var cantparticipantes = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese fecha y hora de la sgte forma (dia mes año) de la solicitud de reserva");
                                        var fecha = Convert.ToDateTime(Console.ReadLine());
                                        Console.WriteLine("Ingrese hora de la sgte forma (hora:minuto:segundo AM/PM) de la solicitud de reserva");
                                        var hora = Convert.ToDateTime(Console.ReadLine());
                                        //Arriendo nuevoarriendo = new Arriendo(, 
                                        //RegistroHistorico.ConsultarDisponibilidad(nuevoarriendo);
                                    }
                                    if (respuesta3 == "c")
                                    {
                                        Console.WriteLine("Ha escogido la opcion reservar Cancha de Tenis");
                                        Console.WriteLine("Escriba la cantidad de participantes:");
                                        var cantparticipantes = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese fecha y hora de la sgte forma (dia mes año) de la solicitud de reserva");
                                        var fecha = Convert.ToDateTime(Console.ReadLine());
                                        Console.WriteLine("Ingrese hora de la sgte forma (hora:minuto:segundo AM/PM) de la solicitud de reserva");
                                        var hora = Convert.ToDateTime(Console.ReadLine());
                                        //Arriendo nuevoarriendo = new Arriendo(, 
                                        //RegistroHistorico.ConsultarDisponibilidad(nuevoarriendo);

                                    }

                                }
                                catch
                                {
                                    Console.WriteLine("Opcion no valida, intente de nuevo");

                                }
                                   

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
