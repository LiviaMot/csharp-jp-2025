namespace std;
public class Usuario {
  // Atributos ou Caracteristicas:
  // public + tipo + nome + { get; set; }
  public string Email { get; set; }
  
  // Métodos ou Funções
  // Acessar Login
  // public + tipo do retorno + nome () {}
  public void Login() {
    Console.WriteLine($"{Email} está entrando no sistema.");
  }
}