using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceIAutenticavel
{
    public class Diretor : Funcionario, IAutenticavel
    {        
        public bool Autenticar(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("Diretor validado!");
                return true;
            } 
            return false;
        }
    }
}