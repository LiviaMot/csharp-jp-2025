namespace std;
public class ViewPessoa {
  public static void AdicionarPessoa() {
    // Pessoa pessoa = new Pessoa(); = APAGAR ESTA LINHA
    Console.WriteLine("Digite o nome da Pessoa: ");
    string nome = Console.ReadLine() ?? "";
    Console.WriteLine("Digite a idade da pessoa: ");
    int idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o email da pessoa: ");
    string email = Console.ReadLine() ?? "";
    ControllerPessoa.AdicionarPessoa(nome, idade, email);
    Console.WriteLine("Cadastrado com sucesso!");
  }
  public static void ListarPessoa() {
    // quem que o viw pode ver?
    // preciso acessar o controllerPessoa e pegar a função ListarPessoas
    List<Pessoa> pessoas = ControllerPessoa.ListarPessoa();
    Console.WriteLine("===== Listando as Pessoas =====");
    foreach (Pessoa pessoa in pessoas) {
      pessoa.MostrarDados();
    }
    Console.WriteLine("===============================");
  }
  // TODO: Fazer o alterar funcionar
  public static void AlterarPessoa() {
    Console.WriteLine("Informe o INDEX da pessoa para Alterar: ");
    int idAlterar = Convert.ToInt32(Console.ReadLine());
    // Dados
    Console.WriteLine("Informe o Nome da pessoa novamente: ");
    string nome = Console.ReadLine() ?? "";
    Console.WriteLine("Informe o Idade da pessoa novamente: ");
    int idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Informe o Email da pessoa novamente: ");
    string email = Console.ReadLine() ?? "";
    
    Pessoa pessoa = new Pessoa(nome, idade, email);
    ControllerPessoa.AlterarPessoa(pessoa, idAlterar);
    Console.WriteLine("Pessoa alterada com sucesso!");
  }
  public static void DeletarPessoa() {
    Console.WriteLine("Informe o INDEX da pessoa para deletar: ");
    int idDeletar = Convert.ToInt32(Console.ReadLine());
    ControllerPessoa.DeletarPessoa(idDeletar);
    Console.WriteLine("Deletado com sucesso!");
  }
}