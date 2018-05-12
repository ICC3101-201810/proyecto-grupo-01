using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
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
        
    }
}
