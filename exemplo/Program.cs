namespace std {
  public class Program {
    static void Main(string[] args) {
      int num, num2;
      double result;
      Console.WriteLine("|Somando dois números|");
      Console.WriteLine("Informe o Primeiro número: ");
      num = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Informe o Segundo número: ");
      num2 = Convert.ToInt32(Console.ReadLine());
      // RESULTADO
      Calculadora.Somar(num, num2);
      result = Calculadora.Sub(num, num2);
      Console.WriteLine($"O resultado da subtração é: {result}");
      Calculadora.Mult(num, num2);
      result = Calculadora.Div(num, num2);
      Console.WriteLine("O resultado da divisão é: {result}");
    }
  
    // CRIAR FUNÇÃO AQUI - QUANTAS QUISER
  }
}