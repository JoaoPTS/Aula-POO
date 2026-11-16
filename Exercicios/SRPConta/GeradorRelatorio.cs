using System.Globalization;

namespace SRPConta;

public class GeradorRelatorio
{
    public string GerarRelatorio(Conta conta)
    {
        ArgumentNullException.ThrowIfNull(conta);

        return $"Titular: {conta.Titular}{Environment.NewLine}" +
               $"Saldo: {conta.Saldo.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}";
    }
}
