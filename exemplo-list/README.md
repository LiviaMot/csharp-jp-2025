// tipo nomeVariável;
// static List<tipo> nomeVariavel = new List<tipo>();
// uma lista para armazenar strings

static void Main() {
  Console.WriteLine("-------------------CRIANDO-------------------");
  nomes.Add("Ana");
  nomes.Add("Ana");
  nomes.Add("Bruno");
  nomes.Add("Jão");
  foreach (string nome in nomes) {
    Console.WriteLine(nome);
  }
  Console.WriteLine("-------------------ALTERANDO-------------------");
  nomes[2] = "Batata";
  foreach (var item in nomes) {
    Console.WriteLine(item);
  }
  Console.WriteLine("-------------------DELETANDO-------------------");
  nomes.RemoveAt(1); // RemoveAt(1) = Remove pelo Index
  foreach (var item in nomes) {
    Console.WriteLine(item);
  }
}