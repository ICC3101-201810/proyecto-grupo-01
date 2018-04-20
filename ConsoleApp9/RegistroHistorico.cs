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
        List<Persona> usuarios = new List<Persona>();
        List<Arriendo> listaArriendos = new List<Arriendo>();
        //DateTime n = new DateTime();
        
        public RegistroHistorico()
        {
            

        }

        public void AgregarUsuario(Persona persona)
        {
            usuarios.Add(persona);
            
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
                Console.WriteLine("el rut es" + rut );
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
            Console.WriteLine("Que tipo de persona es ud?: Si es profesor escriba 1, si es alumno escriba 2, si es funcionario escriba 3");
            var resptipo = int.Parse(Console.ReadLine());
            if (resptipo == 1)
            {
                Profesor nuevoprofesor = new Profesor(rut, nombre, resptipo);
                RegistroHistorico nuevoregistrohistorico = new RegistroHistorico();
                nuevoregistrohistorico.AgregarUsuario(nuevoprofesor);
                nuevoprofesor.VerAtributosPersona();
                Console.WriteLine("caca" + usuarios.Count());
            }
            if (resptipo == 2)
            {

            }
            Persona nuevapersona = new Persona(rut, nombre);
            RegistroHistorico nuevoregistro = new RegistroHistorico();
            nuevoregistro.AgregarUsuario(nuevapersona);
            nuevapersona.VerAtributosPersona();
            Console.WriteLine("caca" + usuarios.Count());
            return nuevapersona;
            
        }
        
        public void VerificarInstalacionDisponible(string TipoInstalacion, DateTime HoraInicio)
        {
            var Duracion = Convert.ToDateTime(2);
            //HoraFin = Duracion +  HoraInicio;
            //listaArriendos.Where(x => x.GetInstalacion == TipoInstalacion and )
        }
        //Agregar metodos para agregar instalaciones

        //Agregar metodos para revisar si hay una instalacion creada con el mismo nombre (para no repetir)
        


    }
}
