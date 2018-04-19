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
        //int horario;

        public SalaEstudio(int minumerosala, string mitipoinstalacion, int micapacidad, string miubicacion ): base(mitipoinstalacion, micapacidad, miubicacion)
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
