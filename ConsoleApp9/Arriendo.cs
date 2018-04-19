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
        DateTime fechayhoraarriendo;

        public Arriendo(Persona[] mipersona, Instalacion[] miinstalacion, int micantidadparticipantes, DateTime mifechayhoraarriendo)
        {
            personas = mipersona;
            cantidadparticipantes = micantidadparticipantes;
            tipoinstalacion = miinstalacion;
            fechayhoraarriendo = mifechayhoraarriendo;
        }
        
        public DateTime GetHora()
        {
            return fechayhoraarriendo;

        }



        
        
            
        
    }
}
