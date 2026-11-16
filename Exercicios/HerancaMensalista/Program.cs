using HerancaMensalista;

Funcionario funcionario = new(1, "Ana", 3000, 30);
Mensalista mensalista = new(2, "Bruno", 3000, 30);
Horista horista = new(3, "Carla", 100, 40);

Console.WriteLine($"{funcionario.Nome}: {funcionario.CalcularSalario():C}");
Console.WriteLine($"{mensalista.Nome}: {mensalista.CalcularSalario():C}");
Console.WriteLine($"{horista.Nome}: {horista.CalcularSalario():C}");
