namespace SRPConta;

public class Conta
{
    public string Titular { get; }
    public decimal Saldo { get; private set; }

    public Conta(string titular, decimal saldoInicial)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(titular);
        ArgumentOutOfRangeException.ThrowIfNegative(saldoInicial);

        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Depositar(decimal valor)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(valor);
        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(valor);

        if (valor > Saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }

        Saldo -= valor;
    }
}
