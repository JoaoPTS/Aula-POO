namespace VendaAgregacao;

public class Produto
{
    private static int _proximoCodigo = 501;

    private int _codigo;
    private string _nome = string.Empty;
    private decimal _preco;

    public int Codigo
    {
        get { return _codigo; }
        private set { _codigo = value; }
    }

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("O nome do produto não pode ser vazio.");
                return;
            }

            _nome = value.Trim();
        }
    }

    public decimal Preco
    {
        get { return _preco; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("O preço do produto deve ser maior que zero.");
                return;
            }

            _preco = value;
        }
    }

    public Produto(string nome, decimal preco)
    {
        Codigo = _proximoCodigo++;
        Nome = nome;
        Preco = preco;
    }

    public void Mostrar()
    {
        Console.WriteLine($"Produto {Codigo}: {Nome} | Preço: {Preco:C}");
    }
}
