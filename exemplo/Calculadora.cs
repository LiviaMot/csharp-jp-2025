namespace std;
// pode colocar o nome de namespace que quiser, não recomendado ainda.
// namespace batata;
// using std; importar de outro
public class Calculadora {
    // Soma
    public static void Somar(int num, int num2) {
      Console.WriteLine("O resultado da soma é: " + (num + num2));
      // Console.WriteLine($"O resultado da soma é: {result}"); = template string
    }
    // Subtração
    public static int Sub(int num, int num2) {
      return num - num2;
    }
    // Multiplicação
    public static void Mult(int num, int num2) {
      Console.WriteLine("O resultado da multiplicação é: " + (num * num2));
    }
    // Divisão
    public static double Div(int num, int num2) {
      return num % num2;
    }
}