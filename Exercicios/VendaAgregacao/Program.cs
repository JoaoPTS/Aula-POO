using VendaAgregacao;

var vendedor = new Vendedor(1, "Mariana");
var comprador = new Comprador(1, "Rafael", 1000m);

var produtosVenda1 = new List<Produto>
{
    new("Teclado", 150m),
    new("Mouse", 80m)
};

var produtosVenda2 = new List<Produto>
{
    new("Monitor", 500m),
    new("Cabo HDMI", 30m)
};

var venda1 = new Venda(comprador, vendedor, produtosVenda1);
var venda2 = new Venda(comprador, vendedor, produtosVenda2);

venda1.RealizarVenda();
venda2.RealizarVenda();

venda1.Mostrar();
Console.WriteLine();
venda2.Mostrar();
Console.WriteLine();
comprador.Mostrar();
vendedor.Mostrar();
