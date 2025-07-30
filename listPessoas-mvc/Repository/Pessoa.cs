namespace std;
public class RepositoryPessoa {
  static List<Pessoa> pessoas = new List<Pessoa>();
  public static void AdicionarPessoa(Pessoa pessoa) {
    pessoas.Add(pessoa);
  }
  public static List<Pessoa> ListarPessoa() {
    return pessoas;
  }
  public static void AlterarPessoa(Pessoa pessoa, int idAlterar) {
    if (pessoas[idAlterar] != null) {
      pessoas[idAlterar].Nome = pessoa.Nome;
      pessoas[idAlterar].Idade = pessoa.Idade;
      pessoas[idAlterar].Email = pessoa.Email;
    }
  }
  public static void DeletarPessoa(int idDeletar) {
    pessoas.RemoveAt(idDeletar);
  }
}