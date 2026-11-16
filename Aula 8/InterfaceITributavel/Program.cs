using InterfaceITributavel;

System.Console.WriteLine();

ContaCorrente conta1 = new ContaCorrente();
conta1.Saldo = 1000.0;

ContaCorrente conta2 = new ContaCorrente();
conta2.Saldo = 2000.0;

ContaCorrente conta3 = new ContaCorrente();
conta3.Saldo = 3000.0;

TotalizadorDeTributos totalizador = new TotalizadorDeTributos();

ITributavel[] contas = new ITributavel[] { conta1, conta2, conta3 };
foreach (ITributavel conta in contas)
{
    totalizador.Adicionar(conta);
}

Console.WriteLine("\n ------------------------------------ \n");

Console.WriteLine($"Total de tributos: R${totalizador.Total:c}");

Console.WriteLine("\n ------------------------------------ \n");

SeguroDeVida seguro = new SeguroDeVida();
seguro.CalcularTributos();

System.Console.WriteLine();