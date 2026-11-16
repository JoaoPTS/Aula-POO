namespace HerancaMensalista
{
  public class Mensalista : Funcionario
  {
    public Mensalista(int codigo, string nome, double salario, int qtdeHorasTrabalhadas)
      : base(codigo, nome, salario, qtdeHorasTrabalhadas)
    {
    }
  }
}