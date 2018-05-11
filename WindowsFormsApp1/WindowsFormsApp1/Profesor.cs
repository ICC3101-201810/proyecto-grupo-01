using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Profesor: Persona
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
        public string GetRutProfesor()
        {
            return GetRut();
        }
        public string GetNombreyApellidoProfesor()
        {
            return GetNombreyApellido();
        }
        public string GetTipoPersonaProfesor()
        {
            return GetTipoPersona();
        }
        public void VerAtributosProfesor()
        {
            Console.WriteLine("La persona es tipo " + GetTipoPersonaProfesor());
            Console.WriteLine("La prioridad del profesor es " + prioridadprofesor);
            Console.WriteLine("El rut del profesor es " + GetRutProfesor());
            Console.WriteLine("El nombre y apellido del profesor es " + GetNombreyApellidoProfesor());
        }
    }
}
