using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp9
{
    class Proyecto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de reserva de instalaciones!!");
            
            //Creamos un administrador para que nadie pueda hacerse pasar por el y modificar.
            Administrador admin1 = new Administrador("191234567", "Administrador1", "123456789", "Administrador");
            Alumno alumn1 = new Alumno("194632126", "Antonia Saez", 2, "Alumno");
            string subtipopersona = alumn1.GetTipoPersona();
            Profesor prof1 = new Profesor("139827892", "Juan Perez", 1, "Profesor");
            Funcionario fun1 = new Funcionario("106732541", "Andres Soto", 3, "Funcionario");
            Cancha cancha = new Cancha("futbol1", "Univ Los Andes", 12, "Cancha");
            string subtipoinstalacion = cancha.GetTipoCancha();
            Cancha otracancha = new Cancha("tenis1", "Univ Los Andes", 2, "Cancha");
            SalaClases salaclas = new SalaClases("Biblioteca", "33", 90, "Sala Clases");
            string subtiposalaclas = salaclas.GetNumSala();
            SalaEstudio salaestudio = new SalaEstudio("25", "Sala Estudio", 5, "Reloj");
            EspaciosPublicos esppubl = new EspaciosPublicos("Auditorio", 100, "Biblioteca", "Espacio Publico");
            RegistroHistorico nuevoregistro = new RegistroHistorico();
            string fecha3 = "2009-03-12 05";
            DateTime fecha2 = DateTime.ParseExact(fecha3, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
            Arriendo arriendo1 = new Arriendo(alumn1, subtipopersona, cancha, subtipoinstalacion, 10, fecha2);
            Arriendo arriendo2 = new Arriendo(alumn1, subtipopersona, salaclas, subtiposalaclas, 30, fecha2);
            nuevoregistro.AgregarArriendo(arriendo1);
            nuevoregistro.AgregarArriendo(arriendo2);
            nuevoregistro.MostrarListaArriendos();
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
            nuevoregistro.AgregarInstalacion(otracancha);
            nuevoregistro.AgregarCancha(otracancha);
            nuevoregistro.AgregarInstalacion(salaclas);
            nuevoregistro.AgregarSalaClase(salaclas);
            nuevoregistro.AgregarInstalacion(salaestudio);
            nuevoregistro.AgregarSalaEstudio(salaestudio);
            nuevoregistro.AgregarInstalacion(esppubl);
            nuevoregistro.AgregarEspacioPublico(esppubl);

            //Como mostrar lista usuarios 
            //nuevoregistro.MostrarListaUsuarios();

            //Hay que ingresar un par de alumnos para comprobar que funciona
            Console.WriteLine("Ingrese su rut");
            var rut = Console.ReadLine();
            
            //nuevoregistro.VerificarUsuarioExistente(rut); (no se porque lo puse dos veces)
            bool persona1 = nuevoregistro.VerificarUsuarioExistente(rut);
            if (persona1 == true)
            {
                Console.WriteLine("Ya estaba registrado");
                
            }
            if(persona1 == false)
            {
                Console.WriteLine("Debe ingresarse al sistema");
                Console.WriteLine("Escriba su nombre");
                var nombre = Console.ReadLine();
                Console.WriteLine("Que tipo de persona es ud?:");
                Console.WriteLine("Si es profesor escriba a");
                Console.WriteLine("si es alumno escriba b");
                Console.WriteLine("si es funcionario escriba c");
                Console.WriteLine("si es administrador escriba d");
                var priori = Console.ReadLine();

                if (priori == "a")
                {
                    Persona nuevoprofesor = new Persona(rut, nombre, "Profesor");
                    nuevoregistro.AgregarUsuario(nuevoprofesor);
                    nuevoprofesor.VerAtributosPersona();
                    nuevoregistro.CrearProfesor(rut, nombre);
                    

                }
                if (priori == "b")
                {
                    Persona nuevoalumno = new Persona(rut, nombre, "Alumno");
                    nuevoregistro.AgregarUsuario(nuevoalumno);
                    nuevoalumno.VerAtributosPersona();
                    nuevoregistro.CrearAlumno(rut, nombre);

                    


                }
                if (priori == "c")
                {
                    Persona nuevofuncionario = new Persona(rut, nombre, "Funcionario");
                    nuevoregistro.AgregarUsuario(nuevofuncionario);
                    nuevofuncionario.VerAtributosPersona();
                    nuevoregistro.CrearProfesor(rut, nombre);
                    

                }
                if (priori == "d")
                {
                    Persona nuevoadministrador = new Persona(rut, nombre, "Administrador");
                    nuevoregistro.AgregarUsuario(nuevoadministrador);
                    nuevoadministrador.VerAtributosPersona();
                    nuevoregistro.CrearAdministrador(rut, nombre);
                    
                }

                else
                {
                    Console.WriteLine("Se equivoco de letra");
                }
            }
            //string subpersona1 = persona1.GetTipoPersona();
            Console.WriteLine("Usuario ha ingresado con exito");
            //Mostrar como esta la lista de usuarios (para ver si se agrego o no un usuario)
            nuevoregistro.MostrarListaUsuarios();
            

            while (true)
            {
                Console.WriteLine("Desea:");
                Console.WriteLine("a)Arrendar una instalacion");
                Console.WriteLine("b)Revisar los eventos disponibles");
                Console.WriteLine("c)Agregar una instalacion");
                Console.WriteLine("d)Mostrar Datos");
                Console.WriteLine("e)Salir");
                var respuesta1 = Console.ReadLine();

                try
                {
                    if (respuesta1 == "a")
                    {
                        Console.WriteLine("Cual de las siguientes instalaciones desea reservar:");
                        Console.WriteLine("a)Cancha");
                        Console.WriteLine("b)Sala de Estudio");
                        Console.WriteLine("c) Sala de Clase");
                        Console.WriteLine("d)Espacio Público?");
                        var respuesta2 = Console.ReadLine();
                        try
                        {
                            if (respuesta2 == "a")
                            {
                                Console.WriteLine("Ha escogido la opcion reservar Cancha");
                                Console.WriteLine("Las Canchas disponibles son: ");
                                nuevoregistro.MostrarListaCanchas();

                                Console.WriteLine("Cual desea escoger?: ");
                                var tipocancha = Console.ReadLine();
                                //nuevoregistro.VerificarExistenciaCancha(tipocancha);
                                Cancha cancha1 = nuevoregistro.VerificarExistenciaCancha(tipocancha);
                                try
                                {

                                    if (cancha1 != null)
                                    {
                                        Console.WriteLine("Ingrese fecha y hora de la sgte forma (año(YYYY)-mes(MM)-dia(DD) hora(HH)) de la solicitud de reserva");
                                        var fechayhora = Console.ReadLine();
                                        DateTime fecha1 = DateTime.ParseExact(fechayhora, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
                                        Arriendo nuevoarriendo = nuevoregistro.VerificarArriendoCanchaExistente(persona1, cancha1, fecha1);

                                        //nuevoregistro.ConsultaDisponibilidad(nuevoArriendo);
                                        Console.WriteLine("Los arriendos realizados hasta el momento son: ");
                                        nuevoregistro.MostrarListaArriendos();
                                        Console.WriteLine("¿Desea crear un evento?");
                                        Console.WriteLine("a) Si");
                                        Console.WriteLine("b) No");
                                        string respuesta = Console.ReadLine();
                                        try
                                        {
                                            if (respuesta == "a")
                                            {
                                                nuevoregistro.CrearEvento(nuevoarriendo);
                                            }
                                            else
                                            {
                                                continue;
                                            }
                                        }
                                        catch
                                        {

                                        }
                                    }
                                
                                }
                                catch
                                {
                                    
                                }
                            }
                            if (respuesta2 == "b")
                            {
                                Console.WriteLine("Ha escogido la opcion reservar Sala de Estudio");
                                Console.WriteLine("Las salas de estudio disponibles son: ");
                                nuevoregistro.MostrarListaSalasdeEstudio();
                                Console.WriteLine("Qué numero de sala desea?");
                                string numerosala = Console.ReadLine();
                                SalaEstudio salaestudio1 = nuevoregistro.VerificarExistenciaSalaEstudio(numerosala);
                                try
                                {
                                    if (salaestudio1 != null)
                                    {
                                        Console.WriteLine("Ingrese fecha y hora de la sgte forma (año(YYYY)-mes(MM)-dia(DD) hora(HH)) de la solicitud de reserva");
                                        var fechayhorasalae = Console.ReadLine();
                                        DateTime fechasalae = DateTime.ParseExact(fechayhorasalae, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
                                        Arriendo nuevoarriendo = nuevoregistro.VerificarArriendoSaladeEstudioExistente(persona1, salaestudio1, fechasalae);

                                        //nuevoregistro.ConsultaDisponibilidad(nuevoArriendo);
                                        Console.WriteLine("Los arriendos realizados hasta el momento son: ");
                                        nuevoregistro.MostrarListaArriendos();
                                        Console.WriteLine("¿Desea crear un evento?");
                                        Console.WriteLine("a) Si");
                                        Console.WriteLine("b) No");
                                        string respuesta = Console.ReadLine();
                                        try
                                        {
                                            if (respuesta == "a")
                                            {
                                                nuevoregistro.CrearEvento(nuevoarriendo);
                                            }
                                            else
                                            {
                                                continue;
                                            }
                                        }
                                        catch
                                        {

                                        }
                                    }
                                }
                                catch
                                {
                                 
                                }
                                
                            }
                            if (respuesta2 == "c")
                            {
                                Console.WriteLine("Ha escogido la opcion reservar Sala de Clase");
                                Console.WriteLine("Las salas de clases disponibles son: ");
                                nuevoregistro.MostrarListaSaladeClases();
                                Console.WriteLine("Qué numero de sala desea?");
                                string numerosala = Console.ReadLine();
                                SalaClases salaclase1 = nuevoregistro.VerificarExistenciaSalaClase(numerosala);
                                try
                                {
                                    if (salaclase1 != null)
                                    {
                                        Console.WriteLine("Ingrese fecha y hora de la sgte forma (año(YYYY)-mes(MM)-dia(DD) hora(HH)) de la solicitud de reserva");
                                        var fechayhorasalae = Console.ReadLine();
                                        DateTime fechasalae = DateTime.ParseExact(fechayhorasalae, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
                                        Arriendo nuevoarriendo = nuevoregistro.VerificarArriendoSaladeClaseExistente(persona1, salaclase1, fechasalae);

                                        //nuevoregistro.ConsultaDisponibilidad(nuevoArriendo);
                                        Console.WriteLine("Los arriendos realizados hasta el momento son: ");
                                        nuevoregistro.MostrarListaArriendos();
                                        Console.WriteLine("¿Desea crear un evento?");
                                        Console.WriteLine("a) Si");
                                        Console.WriteLine("b) No");
                                        string respuesta = Console.ReadLine();
                                        try
                                        {
                                            if (respuesta == "a")
                                            {
                                                nuevoregistro.CrearEvento(nuevoarriendo);
                                            }
                                            else
                                            {
                                                continue;
                                            }
                                        }
                                        catch
                                        {

                                        }
                                    }
                                }
                                catch
                                {

                                }


                            }
                            if (respuesta2 == "d")
                            {
                                Console.WriteLine("Ha escogido la opcion reservar Espacio Público");
                                Console.WriteLine("Los espacios públicos disponibles son: ");
                                nuevoregistro.MostrarListaEspaciosPublicos();

                                Console.WriteLine("Cual desea escoger?: ");
                                var tipoespacio = Console.ReadLine();
                                //nuevoregistro.VerificarExistenciaCancha(tipocancha);
                                EspaciosPublicos espaciopublico1 = nuevoregistro.VerificarExistenciaEspaciosPublicos(tipoespacio);
                                try
                                {

                                    if (espaciopublico1 != null)
                                    {
                                        Console.WriteLine("Ingrese fecha y hora de la sgte forma (año(YYYY)-mes(MM)-dia(DD) hora(HH)) de la solicitud de reserva");
                                        var fechayhora = Console.ReadLine();
                                        DateTime fecha1 = DateTime.ParseExact(fechayhora, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
                                        Arriendo nuevoarriendo = nuevoregistro.VerificarArriendoEspaciosPublicosExistente(persona1, espaciopublico1, fecha1);

                                        //nuevoregistro.ConsultaDisponibilidad(nuevoArriendo);
                                        Console.WriteLine("Los arriendos realizados hasta el momento son: ");
                                        nuevoregistro.MostrarListaArriendos();
                                        Console.WriteLine("¿Desea crear un evento?");
                                        Console.WriteLine("a) Si");
                                        Console.WriteLine("b) No");
                                        string respuesta = Console.ReadLine();
                                        try
                                        {
                                            if (respuesta == "a")
                                            {
                                                nuevoregistro.CrearEvento(nuevoarriendo);
                                            }
                                            else
                                            {
                                                continue;
                                            }
                                        }
                                        catch
                                        {

                                        }
                                    }

                                }
                                catch
                                {

                                }
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
                        nuevoregistro.MostrarListaEventos();
                        Console.WriteLine("Desea inscribirse a algun evento?");
                        Console.WriteLine("a) Si");
                        Console.WriteLine("b) No");
                        string opcion = Console.ReadLine();
                        try
                        {
                            if (opcion == "a")
                            {
                                Console.WriteLine("Escriba nombre de evento");
                                string nombre = Console.ReadLine();
                                Eventos ev = nuevoregistro.VerificarExistenciaEventos(nombre);
                                nuevoregistro.InscribirseAevento(ev);
                            }
                            else
                            {
                                continue;
                            }
                        }
                        catch
                        {

                        }
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
                                nuevoregistro.AgregarInstalacion(instalacionnueva);
                                if (mitipoinstalacion == "Sala de Clase")
                                {
                                    Console.WriteLine("Que numero de sala desea que esta sea?");
                                    var minumerosalaclas = Console.ReadLine();
                                    SalaClases nuevasala = new SalaClases(miubicacion, minumerosalaclas, micapacidad, mitipoinstalacion);
                                    nuevoregistro.AgregarSalaClase(nuevasala);
                                }
                                if (mitipoinstalacion == "Sala de Estudio")
                                {
                                    Console.WriteLine("Que numero de sala desea que esta sea?");
                                    var minumerosalaest = int.Parse(Console.ReadLine());
                                    string numsalaest = minumerosalaest.ToString();
                                    SalaEstudio nuevasalaestudio = new SalaEstudio(numsalaest, mitipoinstalacion, micapacidad, miubicacion);
                                    nuevoregistro.AgregarSalaEstudio(nuevasalaestudio);

                                }
                                if (mitipoinstalacion == "Espacio publico")
                                {
                                    Console.WriteLine("Que tipo de espacio publico es?");
                                    var mitipoesp = Console.ReadLine();
                                    EspaciosPublicos nuevoesppublic = new EspaciosPublicos(mitipoesp, micapacidad, miubicacion, mitipoinstalacion);
                                    nuevoregistro.AgregarEspacioPublico(nuevoesppublic);
                                }
                            }

                        }
                        catch
                        {
                            Console.WriteLine("Usted no es el administrador");
                        }
                        
                        
                    }
                    if (respuesta1 == "d")
                    {
                        Console.WriteLine("Ha decidido mostrar los datos almacenados");
                        Console.WriteLine("a) Ver lista usuarios");
                        Console.WriteLine("b) Ver lista instalaciones");
                        Console.WriteLine("c) Ver lista canchas");
                        Console.WriteLine("d) Ver lista salas estudio");
                        Console.WriteLine("e) Ver listas salas clases");
                        Console.WriteLine("f) Ver listas espacios publicos");
                        Console.WriteLine("g) Ver lista alumnos");
                        Console.WriteLine("h) Ver lista profesores");
                        Console.WriteLine("i) Ver lista funcionarios");
                        Console.WriteLine("j) Ver lista administradores");
                        Console.WriteLine("k) Ver lista arriendos");

                        Console.WriteLine("Escoja una opcion: a, b, c, d, e, f, g, h, i, j, k");
                        var respuesta5 = Console.ReadLine();
                        try
                        {
                            if (respuesta5 == "a")
                            {
                                Console.WriteLine("Ha escogido a) Ver lista usuarios");
                                nuevoregistro.MostrarListaUsuarios();

                            }
                            if (respuesta5 == "b")
                            {
                                Console.WriteLine("Ha escogido a) Ver lista instalaciones");
                                nuevoregistro.MostrarListaInstalaciones();

                            }
                            if (respuesta5 == "c")
                            {
                                Console.WriteLine("Ha escogido c) Ver lista de canchas");
                                nuevoregistro.MostrarListaCanchas();

                            }
                            if (respuesta5 == "d")
                            {
                                Console.WriteLine("Ha escogido d) Ver lista de salas de estudio");
                                nuevoregistro.MostrarListaSalasdeEstudio();

                            }
                            if (respuesta5 == "e")
                            {
                                Console.WriteLine("Ha escogido e) Ver lista de salas de clases");
                                nuevoregistro.MostrarListaSaladeClases();
                            }
                            if (respuesta5 == "f")
                            {
                                Console.WriteLine("Ha escogido f) Ver lista de espacios públicos");
                                nuevoregistro.MostrarListaEspaciosPublicos();

                            }
                            if (respuesta5 == "g")
                            {
                                Console.WriteLine("Ha escogido g) Ver lista de alumnos");
                                nuevoregistro.MostrarListaAlumnos();

                            }
                            if (respuesta5 == "h")
                            {
                                Console.WriteLine("Ha escogido h) Ver lista de profesores");
                                nuevoregistro.MostrarListaProfesores();

                            }
                            if (respuesta5 == "i")
                            {
                                Console.WriteLine("Ha escogido i) Ver lista de funcionarios");
                                nuevoregistro.MostrarListaFuncionarios();

                            }
                            if (respuesta5 == "j")
                            {
                                Console.WriteLine("Ha escogido j) Ver lista de administradores");
                                nuevoregistro.MostrarListaAdministradores();

                            }
                            if (respuesta5 == "k")
                            {
                                Console.WriteLine("Ha escogido k) Ver lista de arriendos");
                                nuevoregistro.MostrarListaArriendos();

                            }

                        }
                        catch
                        {
                            Console.WriteLine("Se ha equivocado de opcion");
                        }
                        

                    }
                    if (respuesta1 == "e")
                    {
                        Environment.Exit(0);
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
