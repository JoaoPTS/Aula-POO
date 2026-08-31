using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapuslamentoConta
{
    public class conta
    {
        //Primeira etapa do encapsulamento
        //inserir a palavra private do lado
        //esquerdo do atributo/método

        private int numero;
        private string titular;
        private double saldo;

        //Segunda etapa, criar os métodos de
        //encapsulamento set e get

        public int Numero //com maiusculo é função, com minusculo é atributo
        {
            set { this.numero = value; }
            get { return this.numero; }
        }

        public string? Titular
        {
            set 
						{ 
							if (this.titular != "") this.titular = value;
							else Console.WriteLine("Titular não pode ser vazio"); 
						}
        		get { return this.titular; }
        }

        public double Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

				public void MostraAtributos()
				{
						Console.WriteLine($"Número: {this.numero} \tTitular: {this.titular} \tSaldo: {this.saldo}");
				}
    }
}
