namespace std;
public class Imposto {
  public static void Dados() {
    int cpf, dependentes;
    double rendaM, desconto, rendaAjustada, imposto, qntdSalarios, salarioMinimo = 1.412;
    // ENTRADA
    Console.WriteLine("Digite seu CPF: ");
    cpf = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o Número de Dependentes: ");
    dependentes = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite sua Renda Mensal: ");
    rendaM = Convert.ToDouble(Console.ReadLine());
    // CONTA
    desconto = (dependentes * 0.05 * salarioMinimo);
		rendaAjustada = (rendaM - desconto);
		qntdSalarios = (rendaAjustada / salarioMinimo);
    // SAÍDA (VERIFICAÇÃO)
    if (qntdSalarios <= 2) {
      Console.WriteLine("Você está isento do imposto de renda.");
	  } else if (qntdSalarios <= 3) {
      Console.WriteLine("Sua alíquota é de 5%. Será cobrado imposto sobre s renda ajustada.");
			
		  imposto = rendaAjustada * 0.05;
      Console.WriteLine($"Valor do imposto a pagar: R$ {imposto}");
	  }	else if (qntdSalarios <= 5) {
		  Console.WriteLine("Sua alíquota é de 10%. Imposto será calculado sobre  renda ajustada.");
			
		  imposto = rendaAjustada * 0.1;
      Console.WriteLine($"Valor do imposto a pagar: R$ {imposto}");
	  } else if (qntdSalarios <= 7) {
      Console.WriteLine($"Sua alíquota é de 15%. Haverá uma cobrança maior sob sua renda.");
			
		  imposto = rendaAjustada * 0.15;
      Console.WriteLine($"Valor do imposto a pagar: R$ {imposto}");
	  } else if (qntdSalarios > 7) {
      Console.WriteLine($"Sua alíquota é de 20%. Você se enquadra na fai máxima de imposto.");
			
		  imposto = rendaAjustada * 0.2;
      Console.WriteLine($"Valor do imposto a pagar: R$ {imposto}");
	  }
  }
}