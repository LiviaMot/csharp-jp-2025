namespace std;
public class Program {
  public static void Main() {
    // Array
    Pessoa[] pessoas = new Pessoa[100];
    int op;
    Console.WriteLine("Bem-vinso(a) ao nosso Programa de pessoas para pessoa!");
    do {
      Console.WriteLine("Dijite a opção Desejada: ");
      Console.WriteLine("1 - Adicionar");
      Console.WriteLine("2 - Listar");
      Console.WriteLine("3 - Alterar");
      Console.WriteLine("4 - Deletar");
      Console.WriteLine("5 - Sair");
      op = Convert.ToInt32(Console.ReadLine());

      switch (op) {
        case 1 : {

          break;
        }
        case 2 : {
          break;
        }
        case 3 : {
          break;
        }
        case 4 : { 
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
}