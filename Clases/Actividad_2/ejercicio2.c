#include <stdio.h>
#include <conio.h>

/*
	Problema: 
		El usuario debe ingresar un importe de depósito, luego otro. Posteriormente debe ver la suma de ambos y luego ver esa suma con un 20% de interés aplicado. 
	
	Algoritmo:
		- Inicio
		- Se pide a usuario que ingrese el primer depósito
		- Se pide a usuario que ingrese el segundo depósito
		- Se suman ambos depósitos
		- Se calcula el importe con el interés adicionado
		- Se muestra al usuario
		- Fin
*/

void clear() { // Declares a function that cleans the input buffer
	char c;
	while ((c = getchar()) != '\n' && c != EOF); // Reads and discards every char that's left in the input buffer as long as it is not a new line or the EOF
	printf("cleaning buffer...\n"); // Debug purpose only
}

int main() {
	float firstDeposit, secondDeposit, totalOutcome, interestRateFactor = 1.2;
	
	printf("A continuacion se permite calcular el monto total que se obtendra por haber depositado cuando el plazo estipulado finalice.\n");
	
	printf("Por favor, ingresa el monto del primer deposito:\n");
	
	if (scanf("%f", &firstDeposit) != 1) {
		printf("Tenes que ingresar un numero! No una letra ni un simbolo...");
		
		return 1;
	}
	
	clear(); // Invokes "clear" function (declared above) in case the user pressed non integers after the integers 
			// If not called, (e.g.) "12a", where the first scanf will take and use "12" and the next will automatically use "a" ending the program with status 1
	
	printf("Por favor, ingresa el monto del segundo deposito:\n");
	
	if (scanf("%f", &secondDeposit) != 1) {
		printf("Tenes que ingresar un numero! No una letra ni un simbolo...");
		
		return 1;
	}
	
	totalOutcome = (firstDeposit + secondDeposit) * interestRateFactor;
	
	printf("Tu primer y segundo deposito fueron de %.2f y %.2f, respectivamente.\nEl total que podras retirar, con interes incluido, cuando finalice el plazo sera de %.2f", firstDeposit, secondDeposit, totalOutcome);
	
	getch();
	
	return 0;	
}
