using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Eventos
    {
        Arriendo arriendo;
        string nombreevento;
        int cuposdisponibles;

        public Eventos(Arriendo miarriendo, string minombreevento, int miscuposdisponibles)
        {
            arriendo = miarriendo;
            nombreevento = minombreevento;
            cuposdisponibles = miscuposdisponibles;
        }
        public string GetNomnbreEvento()
        {
            return nombreevento;
        }
        public int Disponibilidad()
        {
            return cuposdisponibles;
        }
        
        public void ActualizarDisponibilidad()
        {
            cuposdisponibles = cuposdisponibles - 1;
        }
    }
}
