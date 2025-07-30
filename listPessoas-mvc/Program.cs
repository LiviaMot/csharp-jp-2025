namespace std;
public class Program {
  public static void Main() {
    int op;
    Console.WriteLine("Bem-vindo(a) ao nosso Programa de pessoas para pessoa!");
    do {
      Console.WriteLine("Digite a opção Desejada: ");
      Console.WriteLine("1 - Adicionar");
      Console.WriteLine("2 - Listar");
      Console.WriteLine("3 - Alterar");
      Console.WriteLine("4 - Deletar");
      Console.WriteLine("5 - Sair");
      op = Convert.ToInt32(Console.ReadLine());

      switch (op) {
        case 1 : {
          // Fluxo de dados: 
          // Program -> View -> Controller -> Model||Repository
          // Program <- View <- Controller <- Model||Repository 
          ViewPessoa.AdicionarPessoa();
          break;
        }
        case 2 : {
          ViewPessoa.ListarPessoa();
          break;
        }
        case 3 : {
          ViewPessoa.AlterarPessoa();
          break;
        }
        case 4: {
          ViewPessoa.DeletarPessoa();
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