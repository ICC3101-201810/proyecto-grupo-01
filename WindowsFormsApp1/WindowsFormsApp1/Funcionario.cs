using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
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
        
    }
}
