namespace ComposicaoBanco;

public class Corrente
{
    private int _numero;
    private decimal _saldo;
    private decimal _chequeEspecial;

    public int Numero
    {
        get { return _numero; }
        private set { _numero = value; }
    }

    public decimal Saldo
    {
        get { return _saldo; }
        private set { _saldo = value; }
    }

    public decimal ChequeEspecial
    {
        get { return _chequeEspecial; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "O cheque especial não pode ser negativo.");
            }

            _chequeEspecial = value;
        }
    }

    public Corrente(int numero, decimal saldoInicial, decimal chequeEspecial)
    {
        if (saldoInicial < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(saldoInicial), "O saldo inicial não pode ser negativo.");
        }

        Numero = numero;
        Saldo = saldoInicial;
        ChequeEspecial = chequeEspecial;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(valor), "O depósito deve ser maior que zero.");
        }

        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(valor), "O saque deve ser maior que zero.");
        }

        if (valor > Saldo + ChequeEspecial)
        {
            throw new InvalidOperationException("Saldo e limite do cheque especial insuficientes.");
        }

        Saldo -= valor;
    }

    public string GerarExtrato()
    {
        return $"Conta corrente: {Numero} | Saldo: {Saldo:C} | Cheque especial: {ChequeEspecial:C}";
    }

    public void Mostrar()
    {
        Console.WriteLine(GerarExtrato());
    }

    ~Corrente()
    {
        Console.WriteLine($"Destrutor da conta corrente {Numero}");
    }
}
