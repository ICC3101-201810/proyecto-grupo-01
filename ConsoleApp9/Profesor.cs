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

        public Profesor(string mirut, string minombreyapellido, int miprioridadprofesor) : base(mirut, minombreyapellido)
        {
            prioridadprofesor = miprioridadprofesor;
        }

        public void AgregarAlumno(Alumno alumno)
        { 
}
    }
}
