namespace std;
public class Ladybug : Inseto {
  public Ladybug(string name) : base(name) {}
  // QUANTIDADE DE PERNAS
  public override void Legs() {
    Console.WriteLine($"O Inseto tem {QuanLegs} pernas.");
  }
  // COR
  public override void Color() {
    Console.WriteLine($"A cor dele é {Cor}.");
  }
  // TIPO
  public override void Type() {
    Console.WriteLine($"É tipo {Tipo}.");
  }
}