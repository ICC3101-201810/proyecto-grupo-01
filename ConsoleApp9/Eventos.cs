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
        public void VerAtributosEventos()
        {
            Console.WriteLine("El nombre del evento es " + nombreevento);
            Console.WriteLine("El numero de cupos disponibles es" + cuposdisponibles);
            Console.WriteLine("La instalacion donde se lleva a cabo es " + arriendo.GetSubtipoInstalacion());
        }
        public void ActualizarDisponibilidad()
        {
            cuposdisponibles = cuposdisponibles - 1;
        }
    }
}
