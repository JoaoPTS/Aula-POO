using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceIAutenticavel
{
    public interface IAutenticavel
    {
        //implicitamente o método é abstrato
        bool Autenticar(int senha);
    }
}