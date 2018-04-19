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
            Console.WriteLine("Ingrese su rut");
            var rut = Console.ReadLine();
            RegistroHistorico revrut = new RegistroHistorico();
            revrut.VerificarUsuarioExistente(rut);
            //si ya estaba creado preguntar
            Console.WriteLine("Desea a)Arrendar una instalacion, b)Revisar los eventos disponibles?, c)Agregar una instalacion");
            var respuesta1 = Console.ReadLine();
            if (respuesta1 == "a")
            {
                Console.WriteLine("Cual de las siguientes desea reservar: a)Cancha, b)Sala de Estudio, c) Sala de Clase o d)Espacio Público?");
                var respuesta2 = Console.ReadLine();
                if (respuesta2 == "a")
                {
                    Console.WriteLine("Ha escogido la opcion reservar Cancha");


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
                else
                {
                    Console.WriteLine("Se ha equivocado de respuesta, porfavor ingrese de nuevo la opcion de instalacion por reservar");
                    //INVESTIGAR FUNCION TRY CATCH
                }
            }
            if (respuesta1 =="b")
            {
                Console.WriteLine("Ha escogido revisar los eventos disponibles!");
            }
            if (respuesta1 == "c")
            {
                Console.WriteLine("Escriba su contraseña de administrador");
                var contraseña = Console.ReadLine();
                //Como pasar los datos del administrador ya ingresado desde la lista usuarios?
                Administrador revcontraseña = new Administrador();
                revcontraseña.Confirmarcontraseña(contraseña);
                //Revisar eventos disponibles
            }

            
        
            
        }
    }
}
