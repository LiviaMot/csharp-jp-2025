namespace std;
public class Usuario {
  public string Email { get; set; }

  public Usuario(string email)
  {
    Email = email;
  }

  public void Login()
  {
    Console.WriteLine($"{Email} está entrando no sistema.");
  }
}