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
        
        
        public void ConsultarDisponibilidad(Arriendo arrendar)
        {
            //foreach ( in arrendar)
            {
                //arrendar.Getinstalacion();

            }
                
            
         // if (instalacion.Arrendar == "cancha")
         //   foreach(salaclase in SalaClases[3])
         //   if cantparticipantes.Arrendar <= SalaClases[3] and hora.Arrendo =! SalaClases
         //            
         //   return salaclase    
         //       foreach 
        }

        

        public Persona VerificarUsuarioExistente(string rut)
        {
            foreach (Persona p in usuarios)
            {
                string rutpersonaexistente = p.GetRut();
                Console.WriteLine("el rut es" + rut);
                if (rutpersonaexistente == rut)
                {
                    Console.WriteLine("Usted ya ha sido registrado");
                    return p;
                }
                break;

            }

            Console.WriteLine("Debe ingresarse al sistema");
            Console.WriteLine("Escriba su nombre");
            var nombre = Console.ReadLine();
            Persona nuevapersona = new Persona(rut, nombre);
            RegistroHistorico nuvpersona = new RegistroHistorico();
            NewMethod(nuevapersona, nuvpersona);
            return nuevapersona;

        }

        private static void NewMethod(Persona nuevapersona, RegistroHistorico nuvpersona)
        {
            nuvpersona.AgregarUsuario(nuevapersona);
        }

        public void VerificarInstalacionDisponible(string TipoInstalacion, DateTime HoraInicio)
        {
            var Duracion = Convert.ToDateTime(2);
            //HoraFin = Duracion +  HoraInicio;
            //listaArriendos.Where(x => x.GetInstalacion == TipoInstalacion and )
        }

        


    }
}
