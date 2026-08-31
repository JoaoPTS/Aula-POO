using System;
using System.Collections.Generic;
using System.Linq;
using	System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
	public class Funcionario
	{
		private int matricula;
		private string? nome;
		private double salario;

		public int Matricula
		{
			get { return matricula; }
			set { matricula = value; }
		}

		public string? Nome
		{
			get { return nome; }
			set { if (value != "") nome = value; else Console.WriteLine("Nome não pode ser vazio."); }
		}

		public double Salario
		{
			get { return salario; }
			set { salario = value; }
		}

		public void MostrarAtributos()
		{
			Console.WriteLine($"Matrícula: {matricula}");
			Console.WriteLine($"Nome: {nome}");
			Console.WriteLine($"Salário: {salario}");
		}

		public void AumentarSalario(double percentual)
		{
			if (percentual > 0)
			{
				salario += salario * percentual / 100;
			}
			else
			{
				Console.WriteLine("Percentual de aumento deve ser maior que zero.");
			}
		}
	}
}