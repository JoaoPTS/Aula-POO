using EncapuslamentoConta;

internal class Program
{
    private static void Main(string[] args)
    {
        conta c1 = new conta();
        //c1.numero = 1; este atributo não pode ser acessado, pois está encapsulado
        c1.Numero = 1; //Está chamando o método set, que está encapsulando o atributo numero
        Console.WriteLine("Número da conta" + c1.Numero); //Está chamando o método get, que está encapsulando o atributo numero
    }
}
