namespace std;
public class Speed {
  public static void Dados() {
    double velocidadePermitida, velocidadePraticada, diferenca, percentual;
    // ENTRADA
    Console.WriteLine("Digite a Velocidade Permitida: ");
    velocidadePermitida = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite a Velocidade Praticada: ");
    velocidadePraticada = Convert.ToDouble(Console.ReadLine());
    // CONTA
    diferenca = (velocidadePraticada - velocidadePermitida);
    percentual = (diferenca / velocidadePermitida) * 1;

    // SAÍDA
    if (percentual <= 0.2) {
      Console.WriteLine("A multa é de R$ 102,00.");
    } else {
      Console.WriteLine("A multa é de R$ 500,00.");
    }
  }
}