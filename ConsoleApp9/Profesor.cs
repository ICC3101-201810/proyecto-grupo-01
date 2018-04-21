using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Profesor : Persona
    {
        int prioridadprofesor;

        public Profesor(string mirut, string minombreyapellido, int miprioridadprofesor, string mitipodepersona) : base(mirut, minombreyapellido, mitipodepersona)
        {
            prioridadprofesor = miprioridadprofesor;
        }
        public int GetPrioridadProfesor()
        {
            return prioridadprofesor;
        }
    }    
}
