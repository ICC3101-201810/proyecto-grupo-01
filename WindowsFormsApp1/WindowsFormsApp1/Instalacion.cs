using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
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
    }
}
