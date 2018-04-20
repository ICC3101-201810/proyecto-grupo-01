using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Arriendo
    {
        Instalacion[] tipoinstalacion;
        Persona[] personas;
        int cantidadparticipantes;
        DateTime fecha;
        DateTime hora;

        public Arriendo(Persona[] mipersona, Instalacion[] miinstalacion, int micantidadparticipantes, DateTime mifecha, DateTime mihora)
        {
            personas = mipersona;
            cantidadparticipantes = micantidadparticipantes;
            tipoinstalacion = miinstalacion;
            fecha = mifecha;
            hora = mihora;
        }
        
        public DateTime GetFecha()
        {
            return fecha;

        }
        public DateTime GetHora()
        {
            return hora;
        }



        
        
            
        
    }
}
