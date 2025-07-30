// Calculo de Velocidade

// Exercicio 22
float velocidadePermitida, velocidadePraticada, diferenca, percentual;

// ENTRADA
cout<<"\nDigite a Velocidade Permitida: ";
cin>>velocidadePermitida;
cout<<"Digite a Velocidade Praticada: ";
cin>>velocidadePraticada;
			
// SAÍDA
if (velocidadePraticada <= velocidadePermitida) {
   cout<<"\nNão foi multado.\n\n";
} else {
// CONTA

diferenca = (velocidadePraticada - velocidadePermitida);

percentual = (diferenca / velocidadePermitida) * 1;
	
if (percentual <= 0.2) {
    cout<<"\nA multa é de R$ 102,00.\n\n";
} else {
    cout<<"\nA multa é de R$ 500,00.\n\n";
  }
}