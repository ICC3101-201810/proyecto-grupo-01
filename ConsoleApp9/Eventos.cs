using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Eventos: Arriendo
    {
        string nombreevento;
        //string cuposdisponibles;
        //FALTA OPCION AGREGARSE A UN EVENTO

        public Eventos(Persona[] mipersona, Instalacion[] miinstalacion, int micantidadparticipantes, DateTime mifecha, DateTime mihora, string minombreevento) : base(mipersona, miinstalacion, micantidadparticipantes, mifecha, mihora)
        {
            nombreevento = minombreevento;
        }
    }
}
