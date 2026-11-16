using AbstratoFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Assalariado a1 = new Assalariado(1, "João", 3000);
        Assalariado a2 = new Assalariado(2, "Maria", 4000);

        Comissionado c1 = new Comissionado(3, "José", 2000, 0.10);
        Comissionado c2 = new Comissionado(4, "Ana", 2500, 0.15);

        Departamento d1 = new Departamento(1, "TI");
        d1.VetF = new List<Funcionario>();
        d1.Adimitir(a1);
        d1.Adimitir(c1);
        d1.Listar();
        d1.Listar();
        // d1.Demitir(3); // c1 tem código 3, então será demitido
        // d1.Listar();
        Console.WriteLine($"Total {d1.CalcularFolha(30):c}");

        Departamento d2 = new Departamento(2, "RH");
        d2.VetF = new List<Funcionario>();
        d2.Adimitir(a2);
        d2.Adimitir(c2);
        d2.Listar();
        // d2.Demitir(2); // a2 tem código 2, então será demitido
        // d2.Listar();
        Console.WriteLine($"Total {d2.CalcularFolha(30):c}");
    }
}