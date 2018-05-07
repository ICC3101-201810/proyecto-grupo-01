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
        public int GetCapacidadInstalacion()
        {
            return capacidad;
        }
        public string GetUbicacion()
        {
            return ubicacion;
        }

        public void VerAtributosInstalacion()
        {
            Console.WriteLine("El tipo de instalacion es" + tipoinstalacion);
            Console.WriteLine("El numero de capacidad es" + capacidad);

        }

        
    }
}
