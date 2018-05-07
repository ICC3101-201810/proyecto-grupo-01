using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class RegistroHistorico
    {
        List<Instalacion> listainstalaciones = new List<Instalacion>();
        List<Cancha> listacanchas = new List<Cancha>();
        List<SalaClases> listaSalaClases = new List<SalaClases>();
        List<SalaEstudio> listasalaestudio = new List<SalaEstudio>();
        List<EspaciosPublicos> listaespaciospublicos = new List<EspaciosPublicos>();
        List<Persona> usuarios = new List<Persona>();
        List<Alumno> listaAlumnos = new List<Alumno>();
        List<Profesor> listaProfesores = new List<Profesor>();
        List<Funcionario> listaFuncionarios = new List<Funcionario>();
        List<Administrador> listaAdministradores = new List<Administrador>();
        List<Arriendo> listaArriendos = new List<Arriendo>();
        List<Eventos> listaEventos = new List<Eventos>();

        //OPCIONES PARA AGREGAR PERSONAS Y DERIVADOS

        public void AgregarUsuario(Persona persona)
        {
            usuarios.Add(persona);
        }
        public void AgregarAlumno(Alumno alumno)
        {
            listaAlumnos.Add(alumno);
        }
        public void AgregarFuncionario(Funcionario funcionario)
        {
            listaFuncionarios.Add(funcionario);
        }
        public void AgregarProfesor(Profesor profesor)
        {
            listaProfesores.Add(profesor);
        }
        public void AgregarAdministrador(Administrador administrador)
        {
            listaAdministradores.Add(administrador);
        }

        //OPCIONES PARA AGREGAR INSTALACIONES Y DERIVADOS

        public void AgregarInstalacion(Instalacion instalacion)
        {
            listainstalaciones.Add(instalacion);
        }
        public void AgregarCancha(Cancha cancha)
        {
            listacanchas.Add(cancha);
        }
        public void AgregarSalaClase(SalaClases salaclases)
        {
            listaSalaClases.Add(salaclases);
        }
        public void AgregarSalaEstudio(SalaEstudio salaestudio)
        {
            listasalaestudio.Add(salaestudio);
        }
        public void AgregarEspacioPublico(EspaciosPublicos espaciospublicos)
        {
            listaespaciospublicos.Add(espaciospublicos);
        }

        //OPCION PARA AGREGAR ARRIENDO Y EVENTO

        public void AgregarArriendo(Arriendo arriendos)
        {
            listaArriendos.Add(arriendos);
        }
        public void AgregarEventos(Eventos eventos)
        {
            listaEventos.Add(eventos);
        }

        //OPCIONES PARA MOSTRAR LISTAS
        public void MostrarListaUsuarios()
        {
            foreach (Persona p in usuarios)
            {
                p.VerAtributosPersona();

            }

        }
        public void MostrarListaArriendos()
        {
            foreach (Arriendo a in listaArriendos)
            {
                a.VerAtributosArriendo();
            }
        }
        public void MostrarListaCanchas()
        {
            foreach (Cancha c in listacanchas)
            {
                c.VerAtributosCancha();
            }
        }
        public void MostrarListaSalasdeEstudio()
        {
            foreach (SalaEstudio se in listasalaestudio)
            {
                se.VerAtributoSalaE();
            }
        }
        public void MostrarListaSaladeClases()
        {
            foreach (SalaClases sc in listaSalaClases)
            {
                sc.VeratributosSalaClases();
            }
        }
        public void MostrarListaEspaciosPublicos()
        {
            foreach (EspaciosPublicos ep in listaespaciospublicos)
            {
                ep.VerAtributosEspacioPublico();
            }
        }

        //OPCIONES PARA VERIFICAR EXISTENCIA
        public bool ConsultaDisponibilidad(Arriendo arriendo)
        {
            foreach(Arriendo a in listaArriendos)
            {
                Arriendo arriendoexistente = a;
                if (arriendoexistente == arriendo)
                {
                    Console.WriteLine("Ya esta arrendado");
                    return false;
                }
            }
            Console.WriteLine("Arriendo exitoso");
            AgregarArriendo(arriendo);
            return true;
        }

        public Arriendo VerificarArriendoCanchaExistente(Persona persona1, Cancha cancha1, DateTime fecha1)
        {
            foreach (Arriendo a in listaArriendos)
            {
                string subtipoinstalacion = a.GetSubtipoInstalacion();
                DateTime fechaexistente = a.GetHoraFecha();
                string canchaconsulta = cancha1.GetTipoCancha();
                if (subtipoinstalacion == canchaconsulta & fechaexistente == fecha1)
                {
                    Console.WriteLine("La cancha ya esta arrendada");
                    Console.WriteLine("Desea:");
                    Console.WriteLine("a) Cambiar la fecha y/o hora de arriendo");
                    Console.WriteLine("b) Cambiar la cancha escogida");
                    Console.WriteLine("c) Cambiar ambos");
                    var respuestacambio = Console.ReadLine();
                    try
                    {
                        if (respuestacambio == "a")
                        {
                            Console.WriteLine("Ha escogido a) Cambiar la fecha y/o hora de arriendo");
                            Console.WriteLine("Escriba la nueva fecha de arriendo de la sgte forma (año(YYYY)-mes(MM)-dia(DD) hora(HH))");
                            var fechayhoranueva = Console.ReadLine();
                            DateTime fechanueva = DateTime.ParseExact(fechayhoranueva, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
                            VerificarArriendoCanchaExistente(persona1, cancha1, fechanueva);
                            continue;
                        }
                        if (respuestacambio == "b")
                        {
                            Console.WriteLine("Ha escogido b) Cambiar la cancha escogida");
                            Console.WriteLine("Estos son los tipos de cancha disponibles: ");
                            MostrarListaCanchas();
                            Console.WriteLine("Cual escoge?: ");
                            var tipocancha = Console.ReadLine();
                            Cancha canchanueva = VerificarExistenciaCancha(tipocancha);
                            if (canchanueva != null)
                            {
                                VerificarArriendoCanchaExistente(persona1, canchanueva, fecha1);
                            }
                            continue;
                        }
                        if (respuestacambio == "c")
                        {
                            Console.WriteLine("Ha escogido c) Cambiar ambos");
                            Console.WriteLine("Escriba la nueva fecha de arriendo de la sgte forma (año(YYYY)-mes(MM)-dia(DD) hora(HH))");
                            var fechayhoranueva = Console.ReadLine();
                            DateTime fechanueva = DateTime.ParseExact(fechayhoranueva, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
                            Console.WriteLine("Estos son los tipos de cancha disponibles: ");
                            MostrarListaCanchas();
                            Console.WriteLine("Cual escoge?: ");
                            var tipocancha = Console.ReadLine();
                            Cancha canchanueva = VerificarExistenciaCancha(tipocancha);
                            if (canchanueva != null)
                            {
                                VerificarArriendoCanchaExistente(persona1, canchanueva, fechanueva);
                            }
                            continue;

                        }

                    }
                    catch
                    {
                        Console.WriteLine("Se ha equivocado de opcion");
                    }
                    
                    
                }
            }
            Console.WriteLine("Esta disponible!");
            Console.WriteLine("Escriba la cantidad de participantes:");
            var cantparticipantes = int.Parse(Console.ReadLine());
            string subpersona1 = persona1.GetTipoPersona();
            string subcancha1 = cancha1.GetTipoCancha();
            Arriendo nuevoarriendo = new Arriendo(persona1, subpersona1, cancha1, subcancha1, cantparticipantes, fecha1);
            AgregarArriendo(nuevoarriendo);
            Console.Write("Su arriendo ha sido realizado con exito! ");
            nuevoarriendo.VerAtributosArriendo();
            return nuevoarriendo;
        }

        public Arriendo VerificarArriendoSaladeEstudioExistente(Persona persona1, SalaEstudio salaestudio1, DateTime fecha1)
        {
            foreach (Arriendo a in listaArriendos)
            {
                string subtipoinstalacion = a.GetSubtipoInstalacion();
                DateTime fechaexistente = a.GetHoraFecha();
                string numsalae = salaestudio1.GetNumSala();
                if (subtipoinstalacion == numsalae & fechaexistente == fecha1)
                {
                    Console.WriteLine("La sala de estudio ya esta arrendada");
                    Console.WriteLine("Desea:");
                    Console.WriteLine("a) Cambiar la fecha y/o hora de arriendo");
                    Console.WriteLine("b) Cambiar la sala de estudio escogida");
                    Console.WriteLine("c) Cambiar ambos");
                    var respuestacambio = Console.ReadLine();
                    try
                    {
                        if (respuestacambio == "a")
                        {
                            Console.WriteLine("Ha escogido a) Cambiar la fecha y/o hora de arriendo");
                            Console.WriteLine("Escriba la nueva fecha de arriendo de la sgte forma (año(YYYY)-mes(MM)-dia(DD) hora(HH))");
                            var fechayhoranueva = Console.ReadLine();
                            DateTime fechanueva = DateTime.ParseExact(fechayhoranueva, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
                            VerificarArriendoSaladeEstudioExistente(persona1, salaestudio1, fechanueva);
                            continue;
                        }
                        if (respuestacambio == "b")
                        {
                            Console.WriteLine("Ha escogido b) Cambiar la sala de estudio escogida");
                            Console.WriteLine("Estos son los tipos de salas disponibles: ");
                            MostrarListaSalasdeEstudio();
                            Console.WriteLine("Cual escoge?: ");
                            var numsalaest = Console.ReadLine();
                            SalaEstudio salaestudionueva = VerificarExistenciaSalaEstudio(numsalaest);
                            if (salaestudionueva != null)
                            {
                                VerificarArriendoSaladeEstudioExistente(persona1, salaestudionueva, fecha1);
                            }
                            continue;
                        }
                        if (respuestacambio == "c")
                        {
                            Console.WriteLine("Ha escogido c) Cambiar ambos");
                            Console.WriteLine("Escriba la nueva fecha de arriendo de la sgte forma (año(YYYY)-mes(MM)-dia(DD) hora(HH))");
                            var fechayhoranueva = Console.ReadLine();
                            DateTime fechanueva = DateTime.ParseExact(fechayhoranueva, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
                            Console.WriteLine("Estos son los tipos de sala de estudio disponibles: ");
                            MostrarListaSalasdeEstudio();
                            Console.WriteLine("Cual escoge?: ");
                            var salaestnueva = Console.ReadLine();
                            SalaEstudio salaestudionueva = VerificarExistenciaSalaEstudio(salaestnueva);
                            if (salaestudionueva != null)
                            {
                                VerificarArriendoSaladeEstudioExistente(persona1, salaestudionueva, fechanueva);
                            }
                            continue;

                        }

                    }
                    catch
                    {
                        Console.WriteLine("Se ha equivocado de opcion");
                    }


                }
            }
            Console.WriteLine("Esta disponible!");
            Console.WriteLine("Escriba la cantidad de participantes:");
            var cantparticipantes = int.Parse(Console.ReadLine());
            string subpersona1 = persona1.GetTipoPersona();
            string subsalaestudio1 = salaestudio1.GetNumSala();
            Arriendo nuevoarriendo = new Arriendo(persona1, subpersona1, salaestudio1, subsalaestudio1, cantparticipantes, fecha1);
            AgregarArriendo(nuevoarriendo);
            Console.WriteLine("Su arriendo ha sido realizado con exito!");
            nuevoarriendo.VerAtributosArriendo();
            return nuevoarriendo;
        }

        public Arriendo VerificarArriendoSaladeClaseExistente(Persona persona1, SalaClases salaclase1, DateTime fecha1)
        {
            foreach (Arriendo a in listaArriendos)
            {
                string subtipoinstalacion = a.GetSubtipoInstalacion();
                DateTime fechaexistente = a.GetHoraFecha();
                string numsalae = salaclase1.GetNumSala();
                if (subtipoinstalacion == numsalae & fechaexistente == fecha1)
                {
                    Console.WriteLine("La sala de clases ya esta arrendada");
                    Console.WriteLine("Desea:");
                    Console.WriteLine("a) Cambiar la fecha y/o hora de arriendo");
                    Console.WriteLine("b) Cambiar la sala de estudio escogida");
                    Console.WriteLine("c) Cambiar ambos");
                    var respuestacambio = Console.ReadLine();
                    try
                    {
                        if (respuestacambio == "a")
                        {
                            Console.WriteLine("Ha escogido a) Cambiar la fecha y/o hora de arriendo");
                            Console.WriteLine("Escriba la nueva fecha de arriendo de la sgte forma (año(YYYY)-mes(MM)-dia(DD) hora(HH))");
                            var fechayhoranueva = Console.ReadLine();
                            DateTime fechanueva = DateTime.ParseExact(fechayhoranueva, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
                            VerificarArriendoSaladeClaseExistente(persona1, salaclase1, fechanueva);
                            continue;
                        }
                        if (respuestacambio == "b")
                        {
                            Console.WriteLine("Ha escogido b) Cambiar la sala de clases escogida");
                            Console.WriteLine("Estos son los tipos de salas de clases disponibles: ");
                            MostrarListaSaladeClases();
                            Console.WriteLine("Cual escoge?: ");
                            var numsalaclases = Console.ReadLine();
                            SalaClases salaclasesnueva = VerificarExistenciaSalaClase(numsalaclases);
                            if (salaclasesnueva != null)
                            {
                                VerificarArriendoSaladeClaseExistente(persona1, salaclasesnueva, fecha1);
                            }
                            continue;
                        }
                        if (respuestacambio == "c")
                        {
                            Console.WriteLine("Ha escogido c) Cambiar ambos");
                            Console.WriteLine("Escriba la nueva fecha de arriendo de la sgte forma (año(YYYY)-mes(MM)-dia(DD) hora(HH))");
                            var fechayhoranueva = Console.ReadLine();
                            DateTime fechanueva = DateTime.ParseExact(fechayhoranueva, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
                            Console.WriteLine("Estos son los tipos de sala de clases disponibles: ");
                            MostrarListaSaladeClases();
                            Console.WriteLine("Cual escoge?: ");
                            var tiposalaclase = Console.ReadLine();
                            SalaClases salaclasenueva = VerificarExistenciaSalaClase(tiposalaclase);
                            if (salaclasenueva != null)
                            {
                                VerificarArriendoSaladeClaseExistente(persona1, salaclasenueva, fechanueva);
                            }
                            continue;

                        }

                    }
                    catch
                    {
                        Console.WriteLine("Se ha equivocado de opcion");
                    }


                }
            }
            Console.WriteLine("Esta disponible!");
            Console.WriteLine("Escriba la cantidad de participantes:");
            var cantparticipantes = int.Parse(Console.ReadLine());
            string subpersona1 = persona1.GetTipoPersona();
            string subsalaclase1 = salaclase1.GetNumSala();
            Arriendo nuevoarriendo = new Arriendo(persona1, subpersona1, salaclase1, subsalaclase1, cantparticipantes, fecha1);
            AgregarArriendo(nuevoarriendo);
            Console.WriteLine("Su arriendo ha sido realizado con exito!");
            nuevoarriendo.VerAtributosArriendo();
            return nuevoarriendo;
        }

        public Arriendo VerificarArriendoEspaciosPublicosExistente(Persona persona1, EspaciosPublicos espaciopublico1, DateTime fecha1)
        {
            foreach (Arriendo a in listaArriendos)
            {
                string subtipoinstalacion = a.GetSubtipoInstalacion();
                DateTime fechaexistente = a.GetHoraFecha();
                string espaciopublicoconsulta = espaciopublico1.GetTipoEspaciosPublicos();
                if (subtipoinstalacion == espaciopublicoconsulta & fechaexistente == fecha1)
                {
                    Console.WriteLine("El espacio público ya esta arrendado");
                    Console.WriteLine("Desea:");
                    Console.WriteLine("a) Cambiar la fecha y/o hora de arriendo");
                    Console.WriteLine("b) Cambiar la cancha escogida");
                    Console.WriteLine("c) Cambiar ambos");
                    var respuestacambio = Console.ReadLine();
                    try
                    {
                        if (respuestacambio == "a")
                        {
                            Console.WriteLine("Ha escogido a) Cambiar la fecha y/o hora de arriendo");
                            Console.WriteLine("Escriba la nueva fecha de arriendo de la sgte forma (año(YYYY)-mes(MM)-dia(DD) hora(HH))");
                            var fechayhoranueva = Console.ReadLine();
                            DateTime fechanueva = DateTime.ParseExact(fechayhoranueva, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
                            VerificarArriendoEspaciosPublicosExistente(persona1, espaciopublico1, fechanueva);
                            continue;
                        }
                        if (respuestacambio == "b")
                        {
                            Console.WriteLine("Ha escogido b) Cambiar la cancha escogida");
                            Console.WriteLine("Estos son los tipos de espacios publicos disponibles: ");
                            MostrarListaEspaciosPublicos();
                            Console.WriteLine("Cual escoge?: ");
                            var tipoespaciopublico = Console.ReadLine();
                            EspaciosPublicos espaciopubliconuevo = VerificarExistenciaEspaciosPublicos(tipoespaciopublico);
                            if (espaciopubliconuevo != null)
                            {
                                VerificarArriendoEspaciosPublicosExistente(persona1, espaciopubliconuevo, fecha1);
                            }
                            continue;
                        }
                        if (respuestacambio == "c")
                        {
                            Console.WriteLine("Ha escogido c) Cambiar ambos");
                            Console.WriteLine("Escriba la nueva fecha de arriendo de la sgte forma (año(YYYY)-mes(MM)-dia(DD) hora(HH))");
                            var fechayhoranueva = Console.ReadLine();
                            DateTime fechanueva = DateTime.ParseExact(fechayhoranueva, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
                            Console.WriteLine("Estos son los tipos de espacios públicos disponibles: ");
                            MostrarListaEspaciosPublicos();
                            Console.WriteLine("Cual escoge?: ");
                            var tipoespaciopublico = Console.ReadLine();
                            EspaciosPublicos espaciopubliconuevo = VerificarExistenciaEspaciosPublicos(tipoespaciopublico);
                            if (espaciopubliconuevo != null)
                            {
                                VerificarArriendoEspaciosPublicosExistente(persona1, espaciopubliconuevo, fechanueva);
                            }
                            continue;

                        }

                    }
                    catch
                    {
                        Console.WriteLine("Se ha equivocado de opcion");
                    }


                }
            }
            Console.WriteLine("Esta disponible!");
            Console.WriteLine("Escriba la cantidad de participantes:");
            var cantparticipantes = int.Parse(Console.ReadLine());
            string subpersona1 = persona1.GetTipoPersona();
            string subespaciopublico1 = espaciopublico1.GetTipoEspaciosPublicos();
            Arriendo nuevoarriendo = new Arriendo(persona1, subpersona1, espaciopublico1, subespaciopublico1, cantparticipantes, fecha1);
            AgregarArriendo(nuevoarriendo);
            Console.Write("Su arriendo ha sido realizado con exito! ");
            nuevoarriendo.VerAtributosArriendo();
            return nuevoarriendo;
        }

        public Persona VerificarUsuarioExistente(string rut)
        {

            foreach (Persona p in usuarios)
            {
                string rutpersonaexistente = p.GetRut();
                if (rutpersonaexistente == rut)
                {
                    Console.WriteLine("Usted ya ha sido registrado");
                    p.VerAtributosPersona();
                    return p;
                }
            }
            Console.WriteLine("Debe ingresarse al sistema");
            Console.WriteLine("Escriba su nombre");
            var nombre = Console.ReadLine();

            //return nuevoalumn;


            Console.WriteLine("Que tipo de persona es ud?:");
            Console.WriteLine("Si es profesor escriba a");
            Console.WriteLine("si es alumno escriba b");
            Console.WriteLine("si es funcionario escriba c");
            Console.WriteLine("si es administrador escriba d");
            var priori = Console.ReadLine();

            if (priori == "a")
            {
                Persona nuevoprofesor = new Persona(rut, nombre, "Profesor");
                AgregarUsuario(nuevoprofesor);
                nuevoprofesor.VerAtributosPersona();
                CrearProfesor(rut, nombre);
                return nuevoprofesor;

            }
            if (priori == "b")
            {
                Persona nuevoalumno = new Persona(rut, nombre, "Alumno");
                AgregarUsuario(nuevoalumno);
                nuevoalumno.VerAtributosPersona();
                CrearAlumno(rut, nombre);

                return nuevoalumno;


            }
            if (priori == "c")
            {
                Persona nuevofuncionario = new Persona(rut, nombre, "Funcionario");
                AgregarUsuario(nuevofuncionario);
                nuevofuncionario.VerAtributosPersona();
                CrearProfesor(rut, nombre);
                return nuevofuncionario;

            }
            if (priori == "d")
            {
                Persona nuevoadministrador = new Persona(rut, nombre, "Administrador");
                AgregarUsuario(nuevoadministrador);
                nuevoadministrador.VerAtributosPersona();
                CrearAdministrador(rut, nombre);
                return nuevoadministrador;
            }

            else
            {
                return null;
            }

        }

        //OPCIONES DE CREACION

        public Alumno CrearAlumno(string rut, string nombre)
        {
            Alumno alumni = new Alumno(rut, nombre, 2, "Alumno");
            AgregarAlumno(alumni);
            return alumni;
        }
        public Funcionario CrearFuncionario(string rut, string nombre)
        {
            Funcionario funi = new Funcionario(rut, nombre, 3, "Funcionario");
            AgregarFuncionario(funi);
            return funi;
        }
        public Profesor CrearProfesor(string rut, string nombre)
        {
            Profesor profi = new Profesor(rut, nombre, 1, "Profesor");
            AgregarProfesor(profi);
            return profi;
        }
        public Administrador CrearAdministrador(string rut, string nombre)
        {
            Administrador admini = new Administrador(rut, nombre, "123456789", "Alumno");
            AgregarAdministrador(admini);
            return admini;
        }

        public Instalacion CrearInstalacion(string mitipoinstalacion, int micapacidad, string miubicacion)
        {
            Instalacion instalacioni = new Instalacion(mitipoinstalacion, micapacidad, miubicacion);
            AgregarInstalacion(instalacioni);
            return instalacioni;
        }

        public Cancha CrearCancha(string tipocancha, string miubicacion, int micapacidad)
        {
            Cancha canchai = new Cancha(tipocancha, miubicacion, micapacidad, "Cancha");
            AgregarCancha(canchai);
            return canchai;
        }
        public SalaClases CrearSalaClases(string miubicacion, string minumerosala, int micapacidad)
        {
            SalaClases salaclasei = new SalaClases(miubicacion, minumerosala, micapacidad, "Sala de Clases");
            AgregarSalaClase(salaclasei);
            return salaclasei;
        }
        public SalaEstudio CrearSalaEstudio(string miubicacion, string minumerosala, int micapacidad)
        {
            SalaEstudio salaestudioi = new SalaEstudio(minumerosala, "Sala de Estudio", micapacidad, miubicacion);
            AgregarSalaEstudio(salaestudioi);
            return salaestudioi;
        }
        public EspaciosPublicos CrearEspaciosPublicos(string tipoespacio, string miubicacion, int micapacidad)
        {
            EspaciosPublicos espaciospubli = new EspaciosPublicos(tipoespacio, micapacidad, miubicacion, "Espacio Publico");
            AgregarEspacioPublico(espaciospubli);
            return espaciospubli;
        }

        //VERIFICAR EXISTENCIA INSTALACIONES (PARA NO CREARLAS DE NUEVO, NI ARRENDAR ALGO QUE NO EXISTE)

        public Cancha VerificarExistenciaCancha(string tipocancha)
        {
            foreach (Cancha c in listacanchas)
            {
                string canchaexistente = c.GetTipoCancha();
                if (canchaexistente == tipocancha)
                {
                    Console.WriteLine("La cancha existe!");
                    return c;
                }
            }
            Console.WriteLine("Su cancha no existe");
            return null;
        }
        public SalaEstudio VerificarExistenciaSalaEstudio(string numsalaestudio)
        {
            foreach (SalaEstudio se in listasalaestudio)
            {
                string salaestudioexistente = se.GetNumSala();
                if (salaestudioexistente == numsalaestudio)
                {
                    Console.WriteLine("La sala estudio existe!");
                    return se;
                }
            }
            Console.WriteLine("Su sala de estudio no existe");
            return null;
        }
        public SalaClases VerificarExistenciaSalaClase(string numsalaclase)
        {
            foreach (SalaClases sc in listaSalaClases)
            {
                string salaclaseexistente = sc.GetNumSala();
                if (salaclaseexistente == numsalaclase)
                {
                    Console.WriteLine("La sala clase existe!");
                    return sc;
                }
            }
            Console.WriteLine("Su sala de clases no existe");
            return null;
        }
        public EspaciosPublicos VerificarExistenciaEspaciosPublicos(string tipoespaciopubl)
        {
            foreach (EspaciosPublicos ep in listaespaciospublicos)
            {
                string esppublexistente = ep.GetTipoEspaciosPublicos();
                if (esppublexistente == tipoespaciopubl)
                {
                    Console.WriteLine("El espacio publico existe!");
                    return ep;
                }
            }
            Console.WriteLine("Su espacio publico no existe");
            return null;
        }

        //OPCION CREAR EVENTO
        public Eventos CrearEvento(Arriendo arriendo)
        {
            Console.WriteLine("Ingrese nombre evento");
            string nombreevento = Console.ReadLine();
            Instalacion instalacionarriendo = arriendo.GetInstalacion();
            Console.WriteLine("Ingrese cantidad participantes");
            int cantidadParticipantes = int.Parse(Console.ReadLine());
            var capacidadInstalacion = instalacionarriendo.GetCapacidadInstalacion();
            try
            {
                if (capacidadInstalacion >= cantidadParticipantes)
                {
                    Console.WriteLine("Evento creado con exito");
                    Eventos e = new Eventos(arriendo, nombreevento, cantidadParticipantes);
                    return e;
                }
                Console.Write("no puede crear evento");
                return null;

            }
            catch
            {
                Console.Write("no puede crear evento");
                return null;
            }

        }
    }
}
