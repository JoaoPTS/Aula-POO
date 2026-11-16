namespace VendaAgregacao;

public class Vendedor
{
    private int _codigo;
    private string _nome = string.Empty;
    private decimal _comissaoAcumulada;

    public int Codigo
    {
        get { return _codigo; }
        private set { _codigo = value; }
    }

    public string Nome
    {
        get { return _nome; }
        private set { _nome = value; }
    }

    public decimal ComissaoAcumulada
    {
        get { return _comissaoAcumulada; }
        private set { _comissaoAcumulada = value; }
    }

    public Vendedor(int codigo, string nome)
    {
        Codigo = codigo;
        Nome = nome;
    }

    public decimal CalcularComissao(decimal valorVenda)
    {
        return valorVenda * 0.02m;
    }

    internal void RegistrarComissao(decimal comissao)
    {
        ComissaoAcumulada += comissao;
    }

    public void Mostrar()
    {
        Console.WriteLine(
            $"Vendedor {Codigo}: {Nome} | Comissão acumulada: {ComissaoAcumulada:C}");
    }
}
