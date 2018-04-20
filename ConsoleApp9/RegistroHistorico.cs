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

        

        public void VerificarUsuarioExistente(string rut)
        {
            foreach(Persona persona in usuarios)
            {
                string rutpersonaexistente = persona.GetRut();
                if (rutpersonaexistente == rut)
                {
                    Console.WriteLine("Usted ya ha sido registrado");
                    persona.GetPersona(rut);
                    persona.VerAtributosPersona();
                }
                
                

            }

                         
        }
        public void VerificarInstalacionDisponible(string TipoInstalacion, DateTime HoraInicio)
        {
            var Duracion = Convert.ToDateTime(2);
            //HoraFin = Duracion +  HoraInicio;
            //listaArriendos.Where(x => x.GetInstalacion == TipoInstalacion and )
        }

        


    }
}
