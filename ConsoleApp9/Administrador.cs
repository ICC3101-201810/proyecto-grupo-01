using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Administrador: Persona
    {
        string contraseña;

        public Administrador(string mirut, string minombreyapellido, string micontraseña): base(mirut, minombreyapellido)
        {
            contraseña = micontraseña;
        }

        public void Confirmarcontraseña(string contraseña)
        {
            if (contraseña == "123456789")
            {
                Console.Write("Verificacion realizada con exito!");
            }
            else
            {
                Console.Write("Usted no es el administrador");
            }

        }
    }
}
