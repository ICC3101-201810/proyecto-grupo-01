﻿using System;
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

        public void AgregarArriendo(Arriendo arriendos)
        {
            listaArriendos.Add(arriendos);
        }
        public void AgregarEventos(Eventos eventos)
        {
            listaEventos.Add(eventos);
        }


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


            Console.WriteLine("Que tipo de persona es ud?: Si es profesor escriba 1, si es alumno escriba 2, si es funcionario escriba 3, si es administrador escriba 4");
            var priori = int.Parse(Console.ReadLine());

            if (priori == 1)
            {
                Persona nuevoprofesor = new Persona(rut, nombre, "Profesor");
                AgregarUsuario(nuevoprofesor);
                nuevoprofesor.VerAtributosPersona();
                CrearProfesor(rut, nombre);
                return nuevoprofesor;

            }
            if (priori == 2)
            {
                Persona nuevoalumno = new Persona(rut, nombre, "Alumno");
                AgregarUsuario(nuevoalumno);
                nuevoalumno.VerAtributosPersona();
                CrearAlumno(rut, nombre);

                return nuevoalumno;


            }
            if (priori == 3)
            {
                Persona nuevofuncionario = new Persona(rut, nombre, "Funcionario");
                AgregarUsuario(nuevofuncionario);
                nuevofuncionario.VerAtributosPersona();
                CrearProfesor(rut, nombre);
                return nuevofuncionario;

            }
            if (priori == 4)
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
