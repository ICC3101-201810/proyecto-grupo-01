using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class SalaEstudio: Instalacion
    {
        int numerosala;

        public SalaEstudio(int minumerosala, string mitipoinstalacion, int micapacidad, string miubicacion ): base(mitipoinstalacion, micapacidad, miubicacion)
        {
            numerosala = minumerosala;
        }

        public int GetNumSala()
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
