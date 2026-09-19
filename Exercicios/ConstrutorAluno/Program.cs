using ConstrutorAluno;

internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno("Aluno 1");
        Aluno aluno2 = new Aluno("Aluno 2");
        Aluno aluno3 = new Aluno("Aluno 3");

        Console.WriteLine("Alunos Cadastrados:");
        Console.WriteLine(aluno1.RA + " - " + aluno1.Nome);
        Console.WriteLine(aluno2.RA + " - " + aluno2.Nome);
        Console.WriteLine(aluno3.RA + " - " + aluno3.Nome);

        Console.WriteLine("\nQuantidade de instâncias: " + Aluno.Contador);
    }
}