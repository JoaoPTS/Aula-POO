using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceITributavel
{
    public class SeguroDeVida : ITributavel
    {
        public double ValorSeguro { get; private set; }
        public double CalcularTributos()
        {
            this.ValorSeguro = 75.0;
            Console.WriteLine($"Valor do Seguro de Vida: R${this.ValorSeguro:c}");
            return this.ValorSeguro;
        }
    }
}