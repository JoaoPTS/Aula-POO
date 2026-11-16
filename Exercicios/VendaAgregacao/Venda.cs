namespace VendaAgregacao;

public class Venda
{
    private readonly List<Produto> _produtos;
    private bool _realizada;

    public Comprador Comprador { get; }
    public Vendedor Vendedor { get; }
    public IReadOnlyList<Produto> Produtos => _produtos.AsReadOnly();
    public decimal Total { get; private set; }
    public decimal Comissao { get; private set; }

    public Venda(Comprador comprador, Vendedor vendedor, IEnumerable<Produto> produtos)
    {
        _produtos = produtos.ToList();
        Comprador = comprador;
        Vendedor = vendedor;
    }

    public void RealizarVenda()
    {
        if (_realizada)
        {
            Console.WriteLine("Esta venda já foi realizada.");
            return;
        }

        decimal total = _produtos.Sum(produto => produto.Preco);
        decimal comissao = Vendedor.CalcularComissao(total);

        if (!Comprador.Pagar(total))
        {
            return;
        }

        Total = total;
        Comissao = comissao;
        Vendedor.RegistrarComissao(comissao);
        _realizada = true;
    }

    public void Mostrar()
    {
        Console.WriteLine($"Venda para {Comprador.Nome}, realizada por {Vendedor.Nome}:");

        foreach (Produto produto in _produtos)
        {
            produto.Mostrar();
        }

        Console.WriteLine($"Total: {Total:C} | Comissão: {Comissao:C}");
    }
}
