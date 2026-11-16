namespace ComposicaoBanco;

public class Banco
{
    private readonly string _nome;
    private readonly Corrente _corrente;
    private readonly Poupança _poupança;

    public string Nome
    {
        get { return _nome; }
    }

    public Corrente ContaCorrente
    {
        get { return _corrente; }
    }

    public Poupança ContaPoupança
    {
        get { return _poupança; }
    }

    public Banco(
        string nome,
        int numeroCorrente,
        decimal saldoCorrente,
        decimal chequeEspecial,
        int numeroPoupança,
        decimal saldoPoupança,
        decimal taxaRendimento)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome do banco não pode ser vazio.", nameof(nome));
        }

        _nome = nome;
        _corrente = new Corrente(numeroCorrente, saldoCorrente, chequeEspecial);
        _poupança = new Poupança(numeroPoupança, saldoPoupança, taxaRendimento);
    }

    public void Mostrar()
    {
        Console.WriteLine($"Banco: {Nome}");
        ContaCorrente.Mostrar();
        ContaPoupança.Mostrar();
    }

    ~Banco()
    {
        Console.WriteLine($"Destrutor do banco {Nome}");
    }
}
