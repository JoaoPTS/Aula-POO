using ConstrutorConta;

internal class Program
{
    private static void Main(string[] args)
    {
        Conta c1 = new Conta();
        c1.MostrarAtributos();

        Conta c2 = new Conta(123, "João", 1000.0);
        c2.MostrarAtributos();

        Conta c3 = new Conta(1);
        c3.MostrarAtributos();
    }
}