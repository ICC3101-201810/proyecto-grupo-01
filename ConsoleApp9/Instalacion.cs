using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Instalacion
    {
        string tipoinstalacion;
        int capacidad;
        string ubicacion;

        public Instalacion(string mitipoinstalacion, int micapacidad, string miubicacion)
        {
            tipoinstalacion = mitipoinstalacion;
            capacidad = micapacidad;
            ubicacion = miubicacion;
        }
        public string GetInstalacion()
        {
            return tipoinstalacion;
        }
        public int GetCapacidad()
        {
            return capacidad;
        }

        
    }
}
