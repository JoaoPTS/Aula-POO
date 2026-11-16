using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceIAutenticavel
{
    public class Cliente : IAutenticavel
    {
        public int Senha { get; set; }
        public bool Autenticar(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("Cliente validado!");
                return true;
            } 
            return false;
        }
    }
}