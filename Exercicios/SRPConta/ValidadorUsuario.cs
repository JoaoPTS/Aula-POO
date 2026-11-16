namespace SRPConta;

public class ValidadorUsuario
{
    public bool ValidarUsuario(
        string usuario,
        string senha,
        string usuarioEsperado,
        string senhaEsperada)
    {
        return usuario == usuarioEsperado && senha == senhaEsperada;
    }
}
