namespace std;
public class Pessoa : Usuario {
  // Atributos
  public string Nome { get; set; }
  public int Idade { get; set; }

  // Métodos
  public void Comer() {
    Console.WriteLine($"{Nome} está comendo neste momento, aguarde um momento.");
  }
  // override ToString()
  public void MostrarDados() {
    Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Email: {Email}");
  }
}