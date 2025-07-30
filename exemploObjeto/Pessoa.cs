namespace std;
public class Pessoa {
  // Atributos ou Características - 5
  public string Nome { get; set; }
  public int Idade { get; set; }
  public string Genero { get; set; }
  public double Altura { get; set; }
  public string Nacionalidade { get; set; }
  // Métodos ou Funções - 2
  public Pessoa(
    string nome,
    int idade,
    string genero,
    double altura,
    string nacionalidade) {
    Nome = nome;
    Idade = idade;
    Genero = genero;
    Altura = altura;
    Nacionalidade = nacionalidade;
  }
  public void Apresentar() {
    Console.WriteLine($"Olá Meu nome é {Nome}, Eu tenho {Idade} anos, Meu gênero é {Genero}, Tenho {Altura} de altura e Sou {Nacionalidade}.");
  }
  // Comer
  public void Comer() {
    Console.WriteLine("Estou comendo alguma coisa");
  }
}