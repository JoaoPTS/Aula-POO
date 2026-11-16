using AbstratoCliente;
internal class Program
{
    private static void Main(string[] args)
    {
        // Cliente c = new Cliente(1, "João", 19);
        Fisico f = new Fisico(1, "Maria", 30, 123456);
        f.Mostrar();
    }
}