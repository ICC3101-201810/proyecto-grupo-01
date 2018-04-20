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
            Persona admin1 = new Persona("191234567", "Administrador1");
            RegistroHistorico nuevoregistro = new RegistroHistorico();
            nuevoregistro.AgregarUsuario(admin1);
            //Como mostrar lista usuarios 
            nuevoregistro.MostrarListaUsuarios();

            //Hay que ingresar un par de alumnos para comprobar que funciona
            Console.WriteLine("Ingrese su rut");
            var rut = Console.ReadLine();
            RegistroHistorico revrut = new RegistroHistorico();
            revrut.VerificarUsuarioExistente(rut);
            
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
                                Console.WriteLine("Ingrese fecha y hora de la sgte forma (dia mes año) de la solicitud de reserva");
                                var fecha = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("Ingrese hora de la sgte forma (hora:minuto:segundo AM/PM) de la solicitud de reserva");
                                var hora = Convert.ToDateTime(Console.ReadLine());



                            }
                            if (respuesta2 == "b")
                            {
                                Console.WriteLine("Ha escogido la opcion reservar Sala de Estudio");
                            }
                            if (respuesta2 == "c")
                            {
                                Console.WriteLine("Ha escogido la opcion reservar Sala de Clase");

                            }
                            if (respuesta2 == "d")
                            {
                                Console.WriteLine("Ha escogido la opcion reservar Espacio Público");
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
                        //Como pasar los datos del administrador ya ingresado desde la lista usuarios? Linq!!!!
                        //Administrador revcontraseña = new Administrador();
                        //revcontraseña.Confirmarcontraseña(contraseña);
                        //Revisar eventos disponibles
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
