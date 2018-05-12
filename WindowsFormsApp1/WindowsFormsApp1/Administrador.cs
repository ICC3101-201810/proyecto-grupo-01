using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Administrador: Persona
    {
        string contraseña;

        public Administrador(string mirut, string minombreyapellido, string micontraseña, string mitipodepersona) : base(mirut, minombreyapellido, mitipodepersona)
        {
            contraseña = micontraseña;
        }

        public bool Confirmarcontraseña(string contraseña)
        {
            if (contraseña == "123456789")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetRutAdministrador()
        {
            return GetRut();
        }
        public string GetNombreyApellidoAdministrador()
        {
            return GetNombreyApellido();
        }
        public string GetTipoPersonaAdministrador()
        {
            return GetTipoPersona();
        }
        
    }
}
