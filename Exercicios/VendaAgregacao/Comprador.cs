namespace VendaAgregacao;

public class Comprador
{
    private int _codigo;
    private string _nome = string.Empty;
    private decimal _verba;

    public int Codigo
    {
        get { return _codigo; }
        private set { _codigo = value; }
    }

    public string Nome
    {
        get { return _nome; }
        private set
        {
            _nome = value;
        }
    }

    public decimal Verba
    {
        get { return _verba; }
        private set { _verba = value; }
    }

    public Comprador(int codigo, string nome, decimal verba)
    {
        Codigo = codigo;
        Nome = nome;
        Verba = verba;
    }

    internal bool Pagar(decimal valor)
    {
        if (valor > Verba)
        {
            Console.WriteLine($"Verba insuficiente para {Nome}.");
            return false;
        }

        Verba -= valor;
        return true;
    }

    public void Mostrar()
    {
        Console.WriteLine($"Comprador {Codigo}: {Nome} | Verba disponível: {Verba:C}");
    }
}
