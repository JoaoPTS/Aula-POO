namespace HerancaMensalista
{
  public class Funcionario
  {
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public double Salario { get; set; }
    public int QtdeHorasTrabalhadas { get; set; }

    public Funcionario(int codigo, string nome, double salario, int qtdeHorasTrabalhadas)
    {
      Codigo = codigo;
      Nome = nome;
      Salario = salario;
      QtdeHorasTrabalhadas = qtdeHorasTrabalhadas;
    }

    protected Funcionario(int codigo, string nome, double salario)
      : this(codigo, nome, salario, 0)
    {
    }

    public virtual double CalcularSalario()
    {
      return Salario * QtdeHorasTrabalhadas / 30;
    }
  }
}