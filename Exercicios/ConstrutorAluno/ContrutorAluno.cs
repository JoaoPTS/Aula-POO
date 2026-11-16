using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        public long RA { get; set; } = 1570482423000;
        public string? Nome { get; set; }

        public static int Contador { get; set; } = 0;
        
        public Aluno(string nome){
            Contador++;
            this.RA += Contador;
            this.Nome = nome;
        }
    }
}