namespace std;
public class Program {
  static List<string> nomes = new List<string>();
  static void Main() {
    int op;
    Console.WriteLine("Bem-vindo(a) ao nosso Programa de pessoas para pessoa!");
    do {
      Console.WriteLine("Digite a opção Desejada: ");
      Console.WriteLine("1 - Adicionar");
      Console.WriteLine("2 - Listar");
      Console.WriteLine("3 - Alterar");
      Console.WriteLine("4 - Deletar");
      Console.WriteLine("5 - Sair");
      Console.WriteLine("------- ------ ------");
      op = Convert.ToInt32(Console.ReadLine());

      switch (op) {
        case 1 : {
          Adicionar();
          break;
        }
        case 2 : {
          Listar();
          break;
        }
        case 3 : {
          Alterar();
          break;
        }
        case 4 : {
          Deletar();
          break;
        }
        case 5 : {
          Console.WriteLine("Saindo do Programa!");
          break;
        }
        default: {
          break;
        }
      }
    } while (op != 5);
  }
  // Adicionar
  public static void Adicionar() {
    Console.WriteLine("----- Adicionando -----");
    Console.WriteLine("Digite um nome: ");
    nomes.Add(Console.ReadLine() ?? "");
    // string nome = Console.ReadLine() ?? "";
    // nomes.Add(nome); // outra forma de fazer
    Console.WriteLine("------- ------ ------");
  }
  // Listar
  public static void Listar() {
    Console.WriteLine("----- Listando -----");
    foreach (string nome in nomes) {
      Console.WriteLine(nome);
    }
    Console.WriteLine("------- ------ ------");
  }
  // Alterar
  public static void Alterar() {
    Console.WriteLine("----- Alterar -----");
    Console.WriteLine("Informe o INDEX da pessoa para Alterar: ");
    int idAlterar = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Informe o Nome da pessoa novamente: ");
    nomes[idAlterar] = Console.ReadLine() ?? "";
    Console.WriteLine("Pessoa alterada com sucesso!"); 
    Console.WriteLine("------- ------ ------");
  }
  // Deletar
  public static void Deletar() {
    Console.WriteLine("----- Deletando -----");

    Console.WriteLine("Informe o INDEX da pessoa para deletar: ");
    int idDeletar = Convert.ToInt32(Console.ReadLine());
    nomes.RemoveAt(idDeletar);
    foreach (string nome in nomes) {
      Console.WriteLine(nome);
    }
    Console.WriteLine("Deletado com sucesso!");

    Console.WriteLine("------- ------ ------");
  }
}