using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Arriendo
    {
        Instalacion tipoinstalacion;
        string subtipoinstalacion;
        Persona personas;
        string subtipopersona;
        int cantidadparticipantes;
        DateTime horayfecha;

        public Arriendo(Persona mipersona, string misubtipopersona, Instalacion miinstalacion, string misubtipoinstalacion, int micantidadparticipantes, DateTime mihorayfecha)
        {
            personas = mipersona;
            subtipopersona = misubtipopersona;
            cantidadparticipantes = micantidadparticipantes;
            tipoinstalacion = miinstalacion;
            subtipoinstalacion = misubtipoinstalacion;
            horayfecha = mihorayfecha;
        }

        public Instalacion GetInstalacion()
        {
            return tipoinstalacion;
        }

        public string GetSubtipoInstalacion()
        {
            return subtipoinstalacion;
        }

        public Persona GetPersona()
        {
            return personas;
        }
        public string GetSubtipoPersona()
        {
            return subtipopersona;
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
