using ComposicaoBanco;

internal class Program
{
    private static void Main(string[] args)
    {
        Banco banco = new Banco(
            "Banco Aula",
            1001,
            1000m,
            500m,
            2001,
            800m,
            0.01m);

        banco.ContaCorrente.Depositar(250m);
        banco.ContaCorrente.Sacar(100m);
        banco.ContaPoupança.Depositar(200m);
        banco.ContaPoupança.GerarRendimento();

        banco.Mostrar();
    }
}
