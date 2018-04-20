using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Persona
    {
        string rut;
        string nombreyapellido;

        public Persona(string mirut, string minombreyapellido)
        {
            rut = mirut;
            nombreyapellido = minombreyapellido;
        }

        public void Arrendar()
        {

        }
        
        public string GetRut()
        {
            return rut;
        }

        public string GetNombreyApellido()
        {
            return nombreyapellido;
        }

        public void VerAtributosPersona()
        {
            Console.WriteLine("El rut de la persona es" + rut);
            Console.WriteLine("El nombre completo de la persona es" + nombreyapellido);
        }
        

        
        


    }
}
