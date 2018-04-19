using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class EspaciosPublicos: Instalacion
    {
        string tipoespacio;

        public EspaciosPublicos(string mitipoespacio, int micapacidad, string miubicacion): base(micapacidad, miubicacion)
        {
            tipoespacio = mitipoespacio;
        }
    }
}
