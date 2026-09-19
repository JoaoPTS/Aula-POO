using EncapsulamentoEstudante;
internal class Program
{
    private static void Main(string[] args)
    {
        Estudante estudante1 = new Estudante();
        estudante1.Nome = "João";
        estudante1.Nota = 8.5;

        Estudante estudante2 = new Estudante();
        estudante2.Nome = "Maria";
        estudante2.Nota = 5.0;

        estudante1.MostraAtributos();
        estudante1.ExibeInformacoes();

        estudante2.MostraAtributos();
        estudante2.ExibeInformacoes();
    }
}