using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        //encapsulamento compacto
        public int Numero { get; set; }
        public string? Titular { get; set; }
        public double Saldo { get; set; }
        public static int Contador { get; set; } = 0;

        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {Numero} \t Titular: {Titular} \t Saldo: {Saldo}");
        }  
        public Conta() //Construtor padrão
        { //Contador
            Contador += 1;
        }
        public Conta(int numero) //Construtor padrão
        {
            Contador += 1;
            this.Numero = numero;
        }
        public Conta(int numero, string titular, double saldo) //Construtor com parâmetros
        {//atributo       parametro
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;

            Contador += 1;
        }
    }
}