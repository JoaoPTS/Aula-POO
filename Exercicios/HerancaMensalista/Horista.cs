namespace HerancaMensalista
{
  public class Horista : Funcionario
  {
    public int QtdeHorasSemana { get; set; }

    public Horista(int codigo, string nome, double salario, int qtdeHorasSemana)
      : base(codigo, nome, salario)
    {
      QtdeHorasSemana = qtdeHorasSemana;
    }

    public override double CalcularSalario()
    {
      return Salario * QtdeHorasSemana / 4.5;
    }
  }
}
