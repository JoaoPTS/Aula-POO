using ClassProduto;

internal class Program
{
    private static void Main(string[] args)
    {
        Produto produto = new Produto();
        Console.WriteLine("Digite o nome do produto:");
        produto.Nome = Console.ReadLine();
        Console.WriteLine("Digite o preço do produto:");
        produto.Preco = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a quantidade do produto:");
        produto.Quantidade = Convert.ToDouble(Console.ReadLine());

        produto.ExibirInformacoes();
        produto.ValorTotalEstoque();

        Console.WriteLine("Adicionar quantidade ao estoque:");
        produto.AdicionarProdutos(Convert.ToDouble(Console.ReadLine()));

        produto.ExibirInformacoes();
        produto.ValorTotalEstoque();

        Console.WriteLine("Remover quantidade do estoque:");
        produto.RemoverProdutos(Convert.ToDouble(Console.ReadLine()));

        produto.ExibirInformacoes();
        produto.ValorTotalEstoque();
    }
}