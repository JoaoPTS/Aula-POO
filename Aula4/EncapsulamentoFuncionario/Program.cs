using EncapsulamentoFuncionario;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f1 = new Funcionario();

        Console.WriteLine("Digite a matrícula do funcionário:");
        f1.Matricula = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o nome do funcionário:");
        f1.Nome = Console.ReadLine();

        Console.WriteLine("Digite o salário do funcionário:");
        f1.Salario = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nAtributos do funcionário:");
        f1.MostrarAtributos();

        Console.WriteLine("\nDigite o percentual de aumento do salário:");
        double percentual = Convert.ToDouble(Console.ReadLine());
    }
}