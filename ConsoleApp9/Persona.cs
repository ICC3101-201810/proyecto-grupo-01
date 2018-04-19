using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Persona
    {
        string rut;
        string nombreyapellido;
        int Horainicio;
        int Duracion;
        List<Persona> usuarios;
        

        public Persona(string mirut, string minombreyapellido)
        {
            rut = mirut;
            nombreyapellido = minombreyapellido;
        }

        public void CrearUsuario(Persona persona)
        {
            usuarios.Add(persona);
        }

        public void Arrendar()
        {

        }
        
        public string GetRut()
        {
            return rut;
        }
        
        

        
        
    }
}
