using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Alumno: Persona
    {
        int prioridadalumno;


        public Alumno(string mirut, string minombreyapellido, int miprioridadalumno, string mitipodepersona) : base(mirut, minombreyapellido, mitipodepersona)
        {
            prioridadalumno = miprioridadalumno;
        }

        public int GetPrioridadAlumno()
        {
            return prioridadalumno;
        }
        public string GetRutAlumno()
        {
            return GetRut();
        }
        public string GetNombreyApellidoAlumno()
        {
            return GetNombreyApellido();
        }
        public string GetTipoPersonaAlumno()
        {
            return GetTipoPersona();
        }
        
    }
}
