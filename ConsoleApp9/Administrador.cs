using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Administrador: Persona
    {
        string contraseña;

        public Administrador(string mirut, string minombreyapellido, string micontraseña, string mitipodepersona): base(mirut, minombreyapellido, mitipodepersona)
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
        public void VerAtributosAdministrador()
        {
            Console.WriteLine("La persona es tipo " + GetTipoPersonaAdministrador());
            Console.WriteLine("El rut del administrador es " + GetRutAdministrador());
            Console.WriteLine("El nombre y apellido del administrador es " + GetNombreyApellidoAdministrador());
        }

    }
}
