#include <stdio.h>
#include <conio.h>
#include <locale.h>

/*
	Problema: 
		El usuario debe ingresar un importe de dep�sito, luego otro. Posteriormente debe ver la suma de ambos y luego ver esa suma con un 20% de inter�s aplicado. 
	
	Algoritmo:
		- Inicio
		- Se pide a usuario que ingrese el primer dep�sito
		- Se pide a usuario que ingrese el segundo dep�sito
		- Se suman ambos dep�sitos
		- Se calcula el importe con el inter�s adicionado
		- Se muestra al usuario
		- Fin
*/

void clear() { // Declares a function that cleans the input buffer
	while (getchar() != '\n'); // Reads and discards every char that's left in the input buffer as long as it is not a new line char
}

int main() {
	float firstDeposit, secondDeposit, totalOutcome, interestRateFactor = 1.2;
	
  setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config

	printf("A continuación se permite calcular el monto total que se obtendría por haber depositado cuando el plazo estipulado finalice.\n");
	
	printf("Por favor, ingresá el monto del primer depósito:\n");
	
	if (scanf("%f", &firstDeposit) != 1) {
		printf("Tenés que ingresar un número! No una letra ni un símbolo...");
		
		return 1;
	}
	
	clear(); // Invokes "clear" function (declared above) in case the user pressed non integers after the integers 
			// If not called, (e.g.) "12a", where the first scanf will take and use "12" and the next will automatically use "a" ending the program with status 1
	
	printf("Por favor, ingresá el monto del segundo depósito:\n");
	
	if (scanf("%f", &secondDeposit) != 1) {
		printf("Tenés que ingresar un número! No una letra ni un símbolo...");
		
		return 1;
	}
	
	totalOutcome = (firstDeposit + secondDeposit) * interestRateFactor;
	
	printf("Tu primer y segundo depósito fueron de %.2f y %.2f, respectivamente.\nEl total que podrás retirar al finalizar el plazo será de %.2f. Esto incluye un interés generado del 20%% del total depositado.", firstDeposit, secondDeposit, totalOutcome);
	
	getch();
	
	return 0;	
}
