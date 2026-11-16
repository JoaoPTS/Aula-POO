namespace OCPFuncionario;

public class FuncionarioPermanente : ICalcularSalario
{
    public decimal CalcularSalario(Funcionario funcionario)
    {
        ArgumentNullException.ThrowIfNull(funcionario);
        return funcionario.Salario * 1.03m;
    }
}
