namespace Bonificacoes;

public class Gerente : Funcionario
{
    public Gerente(int codigo, string nome, decimal salario)
        : base(codigo, nome, salario)
    {
    }

    public override decimal CalcularBonificacao()
    {
        return Salario * 0.15m;
    }
}
