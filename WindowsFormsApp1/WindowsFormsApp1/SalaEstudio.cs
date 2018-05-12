using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    [Serializable]
    public class SalaEstudio: Instalacion
    {
        string numerosala;

        public SalaEstudio(string minumerosala, string mitipoinstalacion, int micapacidad, string miubicacion) : base(mitipoinstalacion, micapacidad, miubicacion)
        {
            numerosala = minumerosala;
        }

        public string GetNumSala()
        {
            return numerosala;
        }
        public int GetCapacidadSalaE()
        {
            return this.GetCapacidadInstalacion();
        }
        
    }
}
