namespace ComposicaoBanco;

public class Poupança
{
    private int _numero;
    private decimal _saldo;
    private decimal _taxaRendimento;

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

    public decimal TaxaRendimento
    {
        get { return _taxaRendimento; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "A taxa de rendimento não pode ser negativa.");
            }

            _taxaRendimento = value;
        }
    }

    public Poupança(int numero, decimal saldoInicial, decimal taxaRendimento)
    {
        if (saldoInicial < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(saldoInicial), "O saldo inicial não pode ser negativo.");
        }

        Numero = numero;
        Saldo = saldoInicial;
        TaxaRendimento = taxaRendimento;
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

        if (valor > Saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }

        Saldo -= valor;
    }

    public void GerarRendimento()
    {
        Saldo += Saldo * TaxaRendimento;
    }

    public void Mostrar()
    {
        Console.WriteLine(
            $"Poupança: {Numero} | Saldo: {Saldo:C} | Taxa de rendimento: {TaxaRendimento:P}");
    }

    ~Poupança()
    {
        Console.WriteLine($"Destrutor da poupança {Numero}");
    }
}
