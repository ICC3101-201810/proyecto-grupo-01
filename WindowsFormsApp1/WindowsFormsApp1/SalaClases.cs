using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class SalaClases: Instalacion
    {
        string numerosala;

        public SalaClases(string miubicacion, string minumerosala, int micapacidad, string mitipoinstalacion) : base(mitipoinstalacion, micapacidad, miubicacion)
        {
            numerosala = minumerosala;
        }
        public string GetNumSala()
        {
            return numerosala;
        }
        public int GetCapacidadSalaC()
        {
            return this.GetCapacidadInstalacion();
        }
        
    }
}
