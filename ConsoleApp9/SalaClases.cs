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
        //int horario;

        public SalaClases(string miubicacion, int minumerosala, int micapacidad, string mitipoinstalacion): base(mitipoinstalacion, micapacidad, miubicacion)
        {
            numerosala = minumerosala;
        }
        public string GetNumSala()
        {
            string numsala = Convert.ToString(numerosala);
            return numsala;
        }
    }
}
