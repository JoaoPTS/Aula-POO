using Bonificacoes;

var funcionario = new Funcionario(1, "João", 3000m);
var secretario = new Secretario(2, "Maria", 3500m);
var gerente = new Gerente(3, "Carlos", 5000m);
var diretor = new Diretor(4, "Ana", 8000m);

var gerenciador = new GerenciadorBonificacao();
gerenciador.TotalizadorBonificacao(funcionario);
gerenciador.TotalizadorBonificacao(secretario);
gerenciador.TotalizadorBonificacao(gerente);
gerenciador.TotalizadorBonificacao(diretor);

Console.WriteLine($"Total de bonificações: {gerenciador.TotaldeBonificacao:C}");
