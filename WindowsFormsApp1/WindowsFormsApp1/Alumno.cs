using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
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
        public void VerAtributosAlumno()
        {
            Console.WriteLine("La persona es tipo " + GetTipoPersonaAlumno());
            Console.WriteLine("La prioridad del alumno es " + prioridadalumno);
            Console.WriteLine("El rut del alumno es " + GetRutAlumno());
            Console.WriteLine("El nombre y apellido del alumno es " + GetNombreyApellidoAlumno());
        }

    }
}
