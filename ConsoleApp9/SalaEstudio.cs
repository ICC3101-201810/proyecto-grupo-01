using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class SalaEstudio: Instalacion
    {
        int numerosala;
        //int horario;

        public SalaEstudio(int minumerosala, int micapacidad, string miubicacion ): base(micapacidad, miubicacion)
        {
            numerosala = minumerosala;
        }
    }
}
