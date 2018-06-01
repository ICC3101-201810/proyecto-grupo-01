using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class RegistroHistorico
    {
        List<Instalacion> listainstalaciones;
        List<Cancha> listacanchas;
        List<SalaClases> listaSalaClases;
        List<SalaEstudio> listasalaestudio;
        List<EspaciosPublicos> listaespaciospublicos;
        List<Persona> usuarios;
        List<Alumno> listaAlumnos;
        List<Profesor> listaProfesores ;
        List<Funcionario> listaFuncionarios;
        List<Administrador> listaAdministradores;
        List<Arriendo> listaArriendos;
        List<Eventos> listaEventos;
        List<String> listaparticipantesEvento;

        public RegistroHistorico()
        {
            listainstalaciones = new List<Instalacion>();
            listacanchas = new List<Cancha>();
            listaSalaClases = new List<SalaClases>();
            listasalaestudio = new List<SalaEstudio>();
            listaespaciospublicos = new List<EspaciosPublicos>();
            usuarios = new List<Persona>();
            listaAlumnos = new List<Alumno>();
            listaProfesores = new List<Profesor>();
            listaFuncionarios = new List<Funcionario>();
            listaAdministradores = new List<Administrador>();
            listaArriendos = new List<Arriendo>();
            listaEventos = new List<Eventos>();
            listaparticipantesEvento = new List<String>();
        }
        public Persona GetPersona(string rut)
        {

            foreach (Persona p in usuarios)
            {
                string rutpersonaexistente = p.GetRut();
                if (rutpersonaexistente == rut)
                {
                    
                    return p;
                }
            }
            return null;

        }
        public Instalacion GetInstalacion(string instalacion)
        {
            foreach (Instalacion i in listainstalaciones)
            {
                string instalacionexistente = i.GetInstalacion();
                if (instalacionexistente == instalacion)
                {
                    return i;
                }
            
            }
            return null;
        }

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
        public void EliminarArriendo(Arriendo arriendos)
        {
            listaArriendos.Remove(arriendos);
        }
        public void AgregarEventos(Eventos eventos)
        {
            listaEventos.Add(eventos);
        }
        public void EliminarEvento(Eventos evento)
        {
            listaEventos.Remove(evento);
        }
        public void AgregarParticipanteEvento(String participanteEvento)
        {
            listaparticipantesEvento.Add(participanteEvento);
        }


        //OPCIONES PARA VERIFICAR EXISTENCIA ARRIENDO


        public bool VerificarArriendoCanchaExistente(Persona persona1, Cancha cancha1, DateTime fecha1)
        {
            foreach (Arriendo a in listaArriendos)
            {
                string subtipoinstalacion = a.GetSubtipoInstalacion();
                DateTime fechaexistente = a.GetHoraFecha();
                string canchaconsulta = cancha1.GetTipoCancha();
                if (subtipoinstalacion == canchaconsulta & fechaexistente == fecha1)
                {
                    return false;                 
                    
                }
            }
            return true;
            
        }

        public bool VerificarArriendoSaladeEstudioExistente(Persona persona1, SalaEstudio salaestudio1, DateTime fecha1)
        {
            foreach (Arriendo a in listaArriendos)
            {
                string subtipoinstalacion = a.GetSubtipoInstalacion();
                DateTime fechaexistente = a.GetHoraFecha();
                string numsalae = salaestudio1.GetNumSala();
                if (subtipoinstalacion == numsalae & fechaexistente == fecha1)
                {
                    return false;
                    
                }
            }
            return true;
            
        }
        public Arriendo ArriendoPorBorrar2(string atributos)
        {
            foreach(Arriendo a in listaArriendos)
            {
                string subtipoinstalacion = a.GetSubtipoInstalacion();
                string fechayhora = a.GetHoraFecha().ToString();
                string atributoexist = (subtipoinstalacion + " " + fechayhora);
                if (atributoexist == atributos)
                {
                    return a;
                }
            }
            return null;
        }
        public Arriendo ArriendoPorBorrar(string subtipoinstalacionescog, DateTime fecha1)
        {
            foreach (Arriendo a in listaArriendos)
            {
                string subtipoinstalacion = a.GetSubtipoInstalacion();
                DateTime fechaexistente = a.GetHoraFecha();
                
                if (subtipoinstalacion == subtipoinstalacionescog && fechaexistente == fecha1)
                {
                    return a;

                }
            }
            return null;

        }
        public Eventos EventoPorBorrar(string nombreEvento)
        {
            foreach (Eventos e in listaEventos)
            {
                string nombreeventoexistente = e.GetNomnbreEvento();
                if (nombreEvento == nombreeventoexistente)
                {
                    return e;
                }
            }
            return null;
        }

        public bool VerificarArriendoSaladeClaseExistente(Persona persona1, SalaClases salaclase1, DateTime fecha1)
        {
            foreach (Arriendo a in listaArriendos)
            {
                string subtipoinstalacion = a.GetSubtipoInstalacion();
                DateTime fechaexistente = a.GetHoraFecha();
                string numsalae = salaclase1.GetNumSala();
                if (subtipoinstalacion == numsalae & fechaexistente == fecha1)
                {
                    return false;
                                        
                }
            }
            return true;
            
        }

        public bool VerificarArriendoEspaciosPublicosExistente(Persona persona1, EspaciosPublicos espaciopublico1, DateTime fecha1)
        {
            foreach (Arriendo a in listaArriendos)
            {
                string subtipoinstalacion = a.GetSubtipoInstalacion();
                DateTime fechaexistente = a.GetHoraFecha();
                string espaciopublicoconsulta = espaciopublico1.GetTipoEspaciosPublicos();
                if (subtipoinstalacion == espaciopublicoconsulta & fechaexistente == fecha1)
                {
                    return false;
                    
                }
            }
            return true;
            
        }

        public bool VerificarUsuarioExistente(string rut)
        {

            foreach (Persona p in usuarios)
            {
                string rutpersonaexistente = p.GetRut();
                if (rutpersonaexistente == rut)
                {
                    
                    return true;
                }
            }
            return false;
            
        }
        public bool VerificarAdministrador(string rut)
        {
            foreach (Administrador admin in listaAdministradores)
            {
                if (rut == admin.GetRut())
                {
                    return true;
                }
            }
            return false;
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
                    //"Su cancha existe"
                    return c;
                }
            }
            //"Su cancha no existe"
            return null;
        }
        public SalaEstudio VerificarExistenciaSalaEstudio(string numsalaestudio)
        {
            foreach (SalaEstudio se in listasalaestudio)
            {
                string salaestudioexistente = se.GetNumSala();
                if (salaestudioexistente == numsalaestudio)
                {
                    //Console.WriteLine("La sala estudio existe!");
                    return se;
                }
            }
            //Console.WriteLine("Su sala de estudio no existe");
            return null;
        }
        public SalaClases VerificarExistenciaSalaClase(string numsalaclase)
        {
            foreach (SalaClases sc in listaSalaClases)
            {
                string salaclaseexistente = sc.GetNumSala();
                if (salaclaseexistente == numsalaclase)
                {
                    //"La sala clase existe!");
                    return sc;
                }
            }
            //"Su sala de clases no existe");
            return null;
        }
        public EspaciosPublicos VerificarExistenciaEspaciosPublicos(string tipoespaciopubl)
        {
            foreach (EspaciosPublicos ep in listaespaciospublicos)
            {
                string esppublexistente = ep.GetTipoEspaciosPublicos();
                if (esppublexistente == tipoespaciopubl)
                {
                    //Console.WriteLine("El espacio publico existe!");
                    return ep;
                }
            }
            Console.WriteLine("Su espacio publico no existe");
            return null;
        }

        //OPCION CREAR EVENTO
        
        
        public bool CrearEvento(string nombreevento, int cuposDisponibles, Arriendo arriendo)
        {
            
            
            Instalacion instalacionarriendo = arriendo.GetInstalacion();
            int capacidadInstalacion = instalacionarriendo.GetCapacidadInstalacion();
            
            if (capacidadInstalacion >= cuposDisponibles)
            {
                //"Evento creado con exito");
                
                return true;
            }
            //"no puede crear evento");
            return false;


        }

        public bool VerificarExistenciaEventos(string nombreEvento)
        {
            foreach (Eventos e in listaEventos)
            {
                string eventoExistente = e.GetNomnbreEvento();
                if (eventoExistente == nombreEvento)
                {
                    return true;
                }
            }
            return false;
        }

        public bool InscribirseAevento(string nombreEvento)
        {
            
            foreach (Eventos ev in listaEventos)
            {
                string nombreEventoExist = ev.GetNomnbreEvento();
                if (nombreEventoExist == nombreEvento && ev.Disponibilidad() > 0)
                {

                    ev.ActualizarDisponibilidad();
                    return true;
                }
                if (nombreEventoExist == nombreEvento && ev.Disponibilidad() == 0)
                {
                    return false;
                }
                
            }
            return false;
        }
        
        //Obtener listas para los combobox
        public List<Cancha> ObtenerListaCanchas()
        {
            return listacanchas;
        }
        public List<Persona> ObtenerListaPersonas()
        {
            return usuarios;
        }
        public List<Instalacion> ObtenerListaInstalaciones()
        {
            return listainstalaciones;
        }
        public List<Arriendo> ObtenerListaArriendos()
        {
            return listaArriendos;
        }
        public List<Eventos> ObtenerEventos()
        {
            return listaEventos;
        }
        
        public List<SalaEstudio> ObtenerListaSalasEstudio()
        {
            return listasalaestudio;
        }
        public List<SalaClases> ObtenerListaSalaClases()
        {
            return listaSalaClases;
        }
        public List<EspaciosPublicos> ObtenerListaEspaciosPublicos()
        {
            return listaespaciospublicos;
        }
        public List<string> ObtenerListaParticipantesEvento()
        {
            return listaparticipantesEvento;
        }
    }



}

