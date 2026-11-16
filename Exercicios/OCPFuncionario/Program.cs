using System.Globalization;
using OCPFuncionario;

var funcionarioPermanente = new Funcionario(1, "Ana", 3000m);
var funcionarioContrato = new Funcionario(2, "Bruno", 3000m);

var calculadoresSalario = new (Funcionario Funcionario, ICalcularSalario Calculador)[]
{
    (funcionarioPermanente, new FuncionarioPermanente()),
    (funcionarioContrato, new FuncionarioContrato())
};

foreach (var (funcionario, calculador) in calculadoresSalario)
{
    var salario = calculador.CalcularSalario(funcionario);
    Console.WriteLine(
        $"{funcionario.Nome}: {salario.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
}
