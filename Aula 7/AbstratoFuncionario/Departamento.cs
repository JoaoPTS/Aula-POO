using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int Codigo, string? Nome)
        {
            Codigo = Codigo;
            Nome = Nome;
        }

        public void Adimitir(Funcionario f)
        {
            VetF.Add(f);
        }
        public void Listar()
        {
            Console.WriteLine($"\nDepartamento: {Nome}..............");
            foreach (var f in VetF)
            {
                f.Mostrar();
            }
        }
        public void Demitir(int codigoExclusao)
        {
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == codigoExclusao)
                {
                    VetF.RemoveAt(i);
                    Console.WriteLine($"\nFuncionário {f.Nome} demitido com sucesso!\n");
                    break;
                }
            }
        }
        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha += f.CalcularSalario(diasUteis);
            }
            return folha;
        }
    }
}