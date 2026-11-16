using SRPConta;

var validador = new ValidadorUsuario();
var usuarioAutenticado = validador.ValidarUsuario(
    "marco",
    "senha123",
    "marco",
    "senha123");

if (!usuarioAutenticado)
{
    Console.WriteLine("Usuário ou senha inválidos.");
    return;
}

var conta = new Conta("Marco", 1000m);
conta.Depositar(250m);
conta.Sacar(100m);

var geradorRelatorio = new GeradorRelatorio();
Console.WriteLine(geradorRelatorio.GerarRelatorio(conta));
