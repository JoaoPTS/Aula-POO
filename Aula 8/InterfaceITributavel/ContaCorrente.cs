using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceITributavel
{
    public class ContaCorrente : ITributavel
    {
        public double Saldo { get; set; }
        public double CalcularTributos()
        {
            double tributo = this.Saldo * 0.05;
            Console.WriteLine($"Saldo da Conta Corrente: R${this.Saldo - tributo:c} \nCom tributo de 5%: {tributo:c}");
            return tributo;
        }
    }
}