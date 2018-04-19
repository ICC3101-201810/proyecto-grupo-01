using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class SalaClases: Instalacion
    {
        int numerosala;
        //int horario;

        public SalaClases(string miubicacion, int minumerosala, int micapacidad): base(micapacidad, miubicacion)
        {
            numerosala = minumerosala;
        }
    }
}
