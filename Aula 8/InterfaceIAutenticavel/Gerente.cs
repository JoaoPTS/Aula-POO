using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceIAutenticavel
{
    //classe derivada : classe base, interface
    public class Gerente : Funcionario, IAutenticavel
    {
        public bool Autenticar(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("Gerente validado!");
                return true;
            } 
            return false;
        }
    }
}