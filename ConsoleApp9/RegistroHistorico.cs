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
        List<Arrendar> listaArriendos;
        Persona[] personas;
        Arrendar[] arrendars;
        DateTime n = new DateTime(2018)
        
        

        public void ConsultarDisponibilidad(Arrendar arrendar)
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
            Persona p = usuarios.Where(x => x.GetRut() == rut).First();

            foreach(Persona personas in usuarios)
            {
                string rutpersonaexist = personas.GetRut();
                if (rutpersonaexist == rut)
                {
                    Console.WriteLine("Esta persona ya fue creada");
                }
                else
                {
                    Console.Write("Debe completar sus datos para seguir");

                }

                

            }
        }
    }
}
