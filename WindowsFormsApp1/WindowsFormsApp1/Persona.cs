using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Persona
    {
        string rut;
        string nombreyapellido;
        string tipopersona;

        public Persona(string mirut, string minombreyapellido, string mitipodepersona)
        {
            rut = mirut;
            nombreyapellido = minombreyapellido;
            tipopersona = mitipodepersona;
        }
        
        public string GetRut()
        {
            return rut;
        }

        public string GetNombreyApellido()
        {
            return nombreyapellido;
        }
        public string GetTipoPersona()
        {
            return tipopersona;
        }

        
    }
}
