using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoEstudante
{
    public class Estudante
    {
        private string? nome;
        private double nota;

        public string? Nome
        {
            set { this.nome = value; }
            get { return this.nome?.ToUpper(); }
        }
        public double Nota
        {
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.nota = value;
                }
                else
                {
                    Console.WriteLine("Nota inválida");
                }
            }
            get { return this.nota; }
        }
        public void MostraAtributos()
        {
            Console.WriteLine($"Nome: {this.Nome} \tNota: {this.Nota}");
        }
        public bool EstaAprovado()
        {
            return this.nota >= 6;
        }
        public void ExibeInformacoes()
        {
            Console.WriteLine("Status: " + (EstaAprovado() ? "Aprovado" : "Reprovado"));
        }
    }
}