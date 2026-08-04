internal class Program
{
	private static void Main(string[] args)
	{
		//Estrutura de repetição while
		//Tabuada do 1 ao 10
		Console.WriteLine(new string('-', 40));
		Console.WriteLine("Tabuada do 1 ao 10");
		int num1 = 1;
		int mult1 = 1;
		while (num1 <= 10)
		{
			while (mult1 <= 10)
			{
				Console.WriteLine($"{num1} x {mult1} = {num1 * mult1}");
				mult1++;
			}
			Console.WriteLine(new string('-', 40));
			mult1 = 1;
			num1++;
		}

		//Estrutura de repetição for
		//Fatorial de um número
		Console.WriteLine();
		Console.WriteLine("Fatorial de um número");
		Console.Write("Digite um número: ");
		int num2 = Convert.ToInt32(Console.ReadLine());

		int fatorial = 1;
		for (int i = 1; i <= num2; i++)
		{
			fatorial *= i;
		}
		
		Console.WriteLine($"O fatorial de {num2} é {fatorial}");

		//Estrutura de repetição do while
		//Soma de números até que o usuário digite 0
		Console.WriteLine(new string('-', 40));
		Console.WriteLine("Soma de números até que o usuário digite 0");

		int soma = 0;
		int num3;

		do
		{
			Console.Write("Digite um número (0 para sair): ");
			num3 = Convert.ToInt32(Console.ReadLine());
			soma += num3;
		} while (num3 != 0);
		Console.WriteLine($"A soma dos números digitados é: {soma}");

		//Estrutura de repetição foreach
		//Exibir elementos de um array
		Console.WriteLine(new string('-', 40));
		Console.WriteLine("Exibir elementos de um array");

		int[] numeros = { 1, 2, 3, 4, 5 };
		foreach (int numero in numeros)
		{
			Console.WriteLine(numero);
		}			
	}
}