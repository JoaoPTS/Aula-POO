namespace Bonificacoes;

public class Funcionario
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public decimal Salario { get; set; }

    public Funcionario(int codigo, string nome, decimal salario)
    {
        Codigo = codigo;
        Nome = nome;
        Salario = salario;
    }

    public virtual decimal CalcularBonificacao()
    {
        return Salario * 0.10m;
    }
}
