using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Funcionario: Persona
    {
        int prioridadfuncionario;

        public Funcionario(string mirut, string minombreyapellido, int miprioridadfuncionario, string mitipodepersona) : base(mirut, minombreyapellido, mitipodepersona)
        {
            prioridadfuncionario = miprioridadfuncionario;
        }
        public int GetPrioridadFuncionario()
        {
            return prioridadfuncionario;
        }
        public string GetRutFuncionario()
        {
            return GetRut();
        }
        public string GetNombreyApellidoFuncionario()
        {
            return GetNombreyApellido();
        }
        public string GetTipoPersonaFuncionario()
        {
            return GetTipoPersona();
        }
        public void VerAtributosFuncionario()
        {
            Console.WriteLine("La persona es tipo " + GetTipoPersonaFuncionario());
            Console.WriteLine("La prioridad del funcionario es " + prioridadfuncionario);
            Console.WriteLine("El rut del funcionario es " + GetRutFuncionario());
            Console.WriteLine("El nombre y apellido del funcionario es " + GetNombreyApellidoFuncionario());
        }
    }
}
