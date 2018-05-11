using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
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
        public void VerAtributoSalaE()
        {
            Console.WriteLine("El numero de sala es " + numerosala);
        }
    }
}
