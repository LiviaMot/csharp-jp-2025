namespace std;
public class Weight {
  public static void Dados() {
    double weight, weight2, weight3, weight4, weight5, result;
    // ENTRADA
    Console.WriteLine("Digite o Peso da 1° Pessoa: ");
    weight = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o Peso da 2° Pessoa: ");
    weight2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o Peso da 3° Pessoa: ");
    weight3 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o Peso da 4° Pessoa: ");
    weight4 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o Peso da 5° Pessoa: ");
    weight5 = Convert.ToDouble(Console.ReadLine());
    // SAÍDA
    result = Media(weight, weight2, weight3, weight4, weight5);
    Console.WriteLine($"A Média é --> {result}");
  }
  public static double Media(double weight, double weight2, double weight3, double weight4, double weight5) {
    return (weight + weight2 + weight3 + weight4 + weight5) / 5;
  }
}