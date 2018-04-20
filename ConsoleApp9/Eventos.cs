using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Eventos
    {
        Arriendo arriendo;
        string nombreevento;
        int cuposdisponibles;
        //string cuposdisponibles;
        //FALTA OPCION AGREGARSE A UN EVENTO

        public Eventos(Arriendo miarriendo, string minombreevento, int miscuposdisponibles)
        {
            arriendo = miarriendo;
            nombreevento = minombreevento;
            cuposdisponibles = miscuposdisponibles;
        }

    }
}
