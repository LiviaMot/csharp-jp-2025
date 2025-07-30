namespace std;
public class Inseto {
  // NOME
  protected string Name { set; get; }
  protected int QuanLegs { set; get; }
  protected string Cor { set; get; }
  protected string Tipo { set; get; }

  public Inseto(string name)
  {
    Name = name;
  }

  public Inseto(
    int quanLegs,
    string cor,
    string tipo
    ) {
      QuanLegs = quanLegs;
      Cor = cor;
      Tipo = tipo;
  }

  // QUANTIDADE DE PERNAS
  public virtual void Legs() {
    Console.WriteLine($"O Inseto tem {QuanLegs} pernas.");
  }
  // COR
  public virtual void Color() {
    Console.WriteLine($"A cor dele é {Cor}.");
  }
  // TIPO
  public virtual void Type() {
    Console.WriteLine($"É tipo {Tipo}.");
  }
}
