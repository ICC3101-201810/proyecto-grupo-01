using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Arriendo
    {
        Instalacion tipoinstalacion;
        Persona personas;
        int cantidadparticipantes;
        DateTime horayfecha;

        public Arriendo(Persona mipersona, Instalacion miinstalacion, int micantidadparticipantes, DateTime mihorayfecha)
        {
            personas = mipersona;
            cantidadparticipantes = micantidadparticipantes;
            tipoinstalacion = miinstalacion;
            horayfecha = mihorayfecha;
        }
        
        public Instalacion GetInstalacion()
        {
            return tipoinstalacion;
        }
        public Persona GetPersona()
        {
              return personas;
        }
        
        public int GetCantidadParticipantes()
        {
            return cantidadparticipantes;
        }
        public DateTime GetHoraFecha()
        {
            return horayfecha;
        }
        public void VerAtributosArriendo()
        {
            Console.WriteLine("La persona es " + personas.GetNombreyApellido());
            Console.WriteLine("La instalacion es " + tipoinstalacion.GetInstalacion());
            Console.WriteLine("La cantidad de personas es " + cantidadparticipantes);
            Console.WriteLine("La fecha y hora es " + horayfecha);
        }


        
        
            
        
    }
}
