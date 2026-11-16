namespace OCPFuncionario;

public class FuncionarioContrato : ICalcularSalario
{
    public decimal CalcularSalario(Funcionario funcionario)
    {
        ArgumentNullException.ThrowIfNull(funcionario);
        return funcionario.Salario;
    }
}
