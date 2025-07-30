// criar a MAIN
namespace std;
public class Program {
  static void Main() {
    // string nome, genero, nacionalidade;
    // int idade;
    // double altura;
    // Console.WriteLine("Criando pessoas: ");
    // Console.WriteLine("Digite o Nome da pessoa: ");
    // nome = Console.ReadLine() ?? "Sem nome.";
    // Console.WriteLine("Digite a Idade da pessoa: ");
    // idade  = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Digite o Gênero da pessoa: ");
    // genero  = Console.ReadLine() ?? "Prefiro não informar.";
    // Console.WriteLine("Digite a Altura da pessoa: ");
    // altura  = Convert.ToDouble(Console.ReadLine());
    // Console.WriteLine("Digite a Nacionalidade da pessoa: ");
    // nacionalidade  = Console.ReadLine() ?? "BR";
    // // pode ser criado assim: Pessoa pessoa1; | pessoa1 = new Pessoa();
    // Pessoa pessoaUm = new Pessoa(nome, idade, genero, altura, nacionalidade);
    // pessoaUm.Apresentar();

    // ANIMAL
    Animal animal = new Animal("ET");
    animal.MakeSound();

    Cat gato = new Cat("Boris Mingau III");    
    gato.Meow();
  }
}