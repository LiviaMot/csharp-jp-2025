namespace std;
public class Program {
  public static void Main() {
    // Array
    Pessoa[] pessoas = new Pessoa[100];
    int op, count = 0;
    Console.WriteLine("Bem-vindo(a) ao nosso Programa de pessoas para pessoa!");
    do {
      Console.WriteLine("Digite a opção Desejada: ");
      Console.WriteLine("1 - Adicionar"); // segundo + fácil
      Console.WriteLine("2 - Listar"); // mais fácil
      Console.WriteLine("3 - Alterar"); // quarto + fácil
      Console.WriteLine("4 - Deletar"); // terceiro + fácil
      Console.WriteLine("5 - Sair");
      op = Convert.ToInt32(Console.ReadLine());

      switch (op) {
        case 1 : {
          // adicionar uma pessoa dentro do array
          Pessoa pessoa = new Pessoa();
          Console.WriteLine("Digite o nome da Pessoa: ");
          pessoa.Nome = Console.ReadLine() ?? "";
          Console.WriteLine("Digite a idade da pessoa: ");
          pessoa.Idade = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Digite o email da pessoa: ");
          pessoa.Email = Console.ReadLine() ?? "";
          // pedir as atributos da pessoa
          pessoas[count] = pessoa;
          count++;

          Console.WriteLine("Cadastrado com sucesso!");
          break;
        }
        case 2 : {
          Console.WriteLine("===== Listando as Pessoas =====");
          for (int i = 0; i < pessoas.Length; i++) {
            if (pessoas[i] != null) {
              Console.Write($"{i}. ");
              pessoas[i].MostrarDados();
            }
          }
          Console.WriteLine("===============================");
          break;
        }
        case 3 : {
          Console.WriteLine("Informe o INDEX da pessoa para Alterar: ");
          int idAlterar = Convert.ToInt32(Console.ReadLine());
          if (pessoas[idAlterar] != null) {
            Console.WriteLine("Informe o Nome da pessoa novamente: ");
            pessoas[idAlterar].Nome = Console.ReadLine() ?? "";
            Console.WriteLine("Informe o Idade da pessoa novamente: ");
            pessoas[idAlterar].Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o Email da pessoa novamente: ");
            pessoas[idAlterar].Email = Console.ReadLine() ?? "";

            Console.WriteLine("Pessoa alterada com sucesso!");
          } 
          break;
        }
        case 4 : {
          // deletar uma posição do meu array
          // saber qual a posição
          Console.WriteLine("Informe o INDEX da pessoa para deletar: ");
          int idDeletar = Convert.ToInt32(Console.ReadLine());
          pessoas[idDeletar] = null;
          Console.WriteLine("Deletado com sucesso!");
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