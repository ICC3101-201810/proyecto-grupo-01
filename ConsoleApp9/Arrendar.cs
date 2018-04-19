using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Arrendar
    {
        string instalacion;
        int cantidadparticipantes;
        // hora

        public Arrendar(string miinstalacion, int micantidadparticipantes)
        {
            instalacion = miinstalacion;
            cantidadparticipantes = micantidadparticipantes;
        }

        public string GetInstalacion()
        {
            return instalacion;
        }
        
            
        
    }
}
