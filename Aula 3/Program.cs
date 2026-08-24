using ArrayConta;

//Declaração de vetor com 3 indices
Conta[] vetConta = new Conta[3];

Console.WriteLine("Cadastro de Contas:");
for (int i = 0; i < 3; i++)
{
    vetConta[i] = new Conta();
    Console.WriteLine("Digite o Número:");
    vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o Titular:");
    vetConta[i].titular = Console.ReadLine();
    Console.WriteLine("Digite o Saldo:");
    vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
}
foreach (Conta c in vetConta)
    c.MostrarAtributos();
