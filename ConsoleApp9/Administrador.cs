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
        List<Instalacion> listainstalacionesnuevas = new List<Instalacion>();

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
        public void CrearInstalacionnueva(Instalacion instalacion)
        {
            listainstalacionesnuevas.Add(instalacion);

        }
    }
}
