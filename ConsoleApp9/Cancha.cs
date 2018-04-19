using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Cancha: Instalacion
    {
        string tipocancha;
        //tipocancha = futbol1, futbol2, tenis

        public Cancha(string mitipocancha, string miubicacion, int micapacidad): base(micapacidad, miubicacion)
        {
            tipocancha = mitipocancha;
        }

        public string GetTipoCancha()
        {
             
            return tipocancha;
        }
    }
}
