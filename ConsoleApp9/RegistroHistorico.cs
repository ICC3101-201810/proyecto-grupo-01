using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class RegistroHistorico
    {
        List<Instalacion> listaInstalaciones;
        List<Persona> usuarios;
        List<Arriendo> listaArriendos;
        Persona[] personas;
        Arriendo[] arrendars;
        DateTime n = new DateTime();
        
        

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
            //Ejemplo profesora investigar linq
            Persona p = usuarios.Where(x => x.GetRut() == rut).First();
            

            //foreach(Persona personas in usuarios)
            //{
                //string rutpersonaexist = personas.GetRut();
                //if (rutpersonaexist == rut)
                //{
                    //Console.WriteLine("Esta persona ya fue creada");
                //}
                //else
                //{
                    //Console.Write("Debe completar sus datos para seguir");

                //}

                

            //}
        }
        public void VerificarInstalacionDisponible()
        {
            //listaArriendos.Where(x => x.GetInstalacion == Instalacion)
        }

        
    }
}
