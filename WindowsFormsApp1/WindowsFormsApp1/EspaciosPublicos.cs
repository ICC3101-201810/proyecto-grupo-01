using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class EspaciosPublicos: Instalacion
    {
        string tipoespacio;

        public EspaciosPublicos(string mitipoespacio, int micapacidad, string miubicacion, string mitipoinstalacion) : base(mitipoinstalacion, micapacidad, miubicacion)
        {
            tipoespacio = mitipoespacio;
        }

        public string GetTipoEspaciosPublicos()
        {
            return tipoespacio;
        }
        public void VerAtributosEspacioPublico()
        {
            Console.WriteLine("El tipo espacio es " + tipoespacio);
        }
    }
}
