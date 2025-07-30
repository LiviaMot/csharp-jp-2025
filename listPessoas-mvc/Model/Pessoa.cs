
namespace std;
public class Pessoa : Usuario {
  // Atributos
  public string Nome { get; set; }
  public int Idade { get; set; }

  // Para não permitir criação de objetos vazios, preciso modificar o construtor da classe.
  public Pessoa(string nome, int idade, string email) : base(email)
  {
    Nome = nome;
    Idade = idade;

    RepositoryPessoa.AdicionarPessoa(this);
  }

  // Métodos
  public void Comer()
  {
    Console.WriteLine($"{Nome} está comendo neste momento, aguarde um momento.");
  }
  // override ToString()
  public void MostrarDados() {
    Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Email: {Email}");
  }
}