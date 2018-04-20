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
        //DateTime n = new DateTime();
        
        public RegistroHistorico()
        {
            

        }

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


        public void MostrarListaUsuarios()
        {
            foreach (Persona p in usuarios)
            {
                p.VerAtributosPersona();
                
            }
            
        }
        
        
        public void ConsultarDisponibilidad(Arriendo arriendo)
        {
            foreach (Arriendo a in listaArriendos)
            {
               

            }
                
                 
        }

        

        public Persona VerificarUsuarioExistente(string rut)
        {
            Console.WriteLine("caca" + usuarios.Count());
            foreach(Persona p in usuarios)
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
            //Persona nuevoalumn = new Persona(rut, nombre, tippersona);
            //AgregarUsuario(nuevoalumn);

            //return nuevoalumn;
            

            Console.WriteLine("Que tipo de persona es ud?: Si es profesor escriba 1, si es alumno escriba 2, si es funcionario escriba 3, si es administrador escriba 4");
            var priori = int.Parse(Console.ReadLine());

            if (priori == 1)
            {
                Persona nuevoprofesor = new Persona(rut, nombre, "Profesor");
                AgregarUsuario(nuevoprofesor);
                nuevoprofesor.VerAtributosPersona();
                Console.WriteLine("caca" + usuarios.Count());
                CrearProfesor(rut, nombre);
                return nuevoprofesor;

            }
            if (priori == 2)
            {
                Persona nuevoalumno = new Persona(rut, nombre, "Alumno");
                AgregarUsuario(nuevoalumno);
                nuevoalumno.VerAtributosPersona();
                Console.WriteLine("caca" + usuarios.Count());
                CrearAlumno(rut, nombre);

                return nuevoalumno;
                

            }
            if (priori == 3)
            {
                Persona nuevofuncionario = new Persona(rut, nombre, "Funcionario");
                AgregarUsuario(nuevofuncionario);
                nuevofuncionario.VerAtributosPersona();
                Console.WriteLine("caca" + usuarios.Count());
                CrearProfesor(rut, nombre);
                return nuevofuncionario;

            }
            if (priori == 4)
            {
                Persona nuevoadministrador = new Persona(rut, nombre, "Administrador");
                AgregarUsuario(nuevoadministrador);
                nuevoadministrador.VerAtributosPersona();
                Console.WriteLine("caca" + usuarios.Count());
                CrearAdministrador(rut, nombre);
                return nuevoadministrador;
            }

            else
            {
                return null;
            }

        }

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
        public  Profesor CrearProfesor(string rut, string nombre)
        {
            Profesor profi = new Profesor(rut, nombre, 1, "Profesor");
            AgregarProfesor(profi);
            return profi;
        }
        public Administrador CrearAdministrador(string rut, string nombre)
        {  
            Administrador admini = new Administrador(rut, nombre, "123456789"  ,"Alumno");
            AgregarAdministrador(admini);
            return admini;
        }

        public Cancha CrearCancha(string tipocancha, string miubicacion, int micapacidad)
        {
            Cancha canchai = new Cancha(tipocancha, miubicacion, micapacidad, "Cancha");
            AgregarCancha(canchai);
            return canchai;
        }
        public SalaClases CrearSalaClases(string miubicacion, int minumerosala, int micapacidad)
        {
            SalaClases salaclasei = new SalaClases(miubicacion, minumerosala, micapacidad, "Sala de Clases");
            AgregarSalaClase(salaclasei);
            return salaclasei;
        }
        public SalaEstudio CrearSalaEstudio(string miubicacion, int minumerosala, int micapacidad)
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

        public Instalacion VerificarExistenciaInstalacion(string tipoinstalacion)
        {
            foreach (Instalacion i in listainstalaciones)
            {
                string instalacionexistente = i.GetInstalacion();
                if (instalacionexistente == tipoinstalacion)
                {
                    Console.WriteLine("La instalacion existe!");
                    return i;
                }
            }
            Console.WriteLine("Su instalacion no existe");
            return null;
        }

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
        public SalaEstudio VerificarExistenciaSalaEstudio(int capacidad)
        {
            foreach (SalaEstudio se in listasalaestudio)
            {
                int salaestudioexistente = se.GetCapacidadSalaE();
                if (salaestudioexistente == capacidad)
                {
                    Console.WriteLine("La sala estudio existe!");
                    return se;
                }
            }
            Console.WriteLine("Su sala de estudio no existe");
            return null;
        }
        public SalaClases VerificarExistenciaSalaClase(int capacidad)
        {
            foreach (SalaClases sc in listaSalaClases)
            {
                int salaclaseexistente = sc.GetCapacidadSalaC();
                if (salaclaseexistente == capacidad)
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





        public void VerificarInstalacionDisponible(string TipoInstalacion, DateTime HoraInicio)
        {
            var Duracion = Convert.ToDateTime(2);
            //HoraFin = Duracion +  HoraInicio;
            //listaArriendos.Where(x => x.GetInstalacion == TipoInstalacion and )
        }
        //Agregar metodos para agregar instalaciones

        //Agregar metodos para revisar si hay una instalacion creada con el mismo nombre (para no repetir)

        //public Arriendo CrearArriendo(Persona persona, Instalacion instalacion)
        //{
            //Console.WriteLine
            //Arriendo arriendo1 = new Arriendo(persona, instalacion)
        //}

        
        

    }
}
