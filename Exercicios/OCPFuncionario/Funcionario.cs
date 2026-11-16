namespace OCPFuncionario;

public class Funcionario
{
    public int Codigo { get; }
    public string Nome { get; }
    public decimal Salario { get; }

    public Funcionario(int codigo, string nome, decimal salario)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(nome);
        ArgumentOutOfRangeException.ThrowIfNegative(salario);

        Codigo = codigo;
        Nome = nome;
        Salario = salario;
    }
}
