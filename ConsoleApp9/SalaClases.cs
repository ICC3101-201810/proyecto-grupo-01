using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class SalaClases: Instalacion
    {
        int numerosala;

        public SalaClases(string miubicacion, int minumerosala, int micapacidad, string mitipoinstalacion): base(mitipoinstalacion, micapacidad, miubicacion)
        {
            numerosala = minumerosala;
        }
        public int GetNumSala()
        {
            return numerosala;
        }
        public int GetCapacidadSalaC()
        {
            return this.GetCapacidadInstalacion();
        }
        public void VeratributosSalaClases()
        {
            Console.WriteLine("El numero de sala es" + numerosala);
            

        }
    }
}
