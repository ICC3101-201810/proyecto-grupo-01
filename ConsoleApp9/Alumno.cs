using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Alumno : Persona
    {
        int prioridadalumno;


        public Alumno(string mirut, string minombreyapellido, int miprioridadalumno, string mitipodepersona) : base(mirut, minombreyapellido, mitipodepersona)
        {
            prioridadalumno = miprioridadalumno;
        }

        
    }
}
