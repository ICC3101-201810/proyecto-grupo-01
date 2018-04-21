using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Funcionario : Persona
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
    }

}
     