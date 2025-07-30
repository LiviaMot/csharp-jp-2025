
namespace std;
// receber os valores
// criar o objeto
public class ControllerPessoa() {
  public static void AdicionarPessoa(
    string nome,
    int idade,
    string email
  ) {
    // TODO: validar dados
    new Pessoa(nome, idade, email);
  }
  public static List<Pessoa> ListarPessoa() {
    return RepositoryPessoa.ListarPessoa();
  }
  public static void AlterarPessoa(Pessoa pessoa, int idAlterar) {
    RepositoryPessoa.AlterarPessoa(pessoa, idAlterar);
  }
  public static void DeletarPessoa(int idDeletar) {
    RepositoryPessoa.DeletarPessoa(idDeletar);
  }
}