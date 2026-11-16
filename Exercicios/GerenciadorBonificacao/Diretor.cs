namespace Bonificacoes;

public class Diretor : Funcionario
{
    public Diretor(int codigo, string nome, decimal salario)
        : base(codigo, nome, salario)
    {
    }

    public override decimal CalcularBonificacao()
    {
        return Salario * 0.10m + 1000m;
    }
}
