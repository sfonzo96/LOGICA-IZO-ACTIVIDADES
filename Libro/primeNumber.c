#include <stdio.h>
#include <stdbool.h>
#include <conio.h>

int main() {
	int number = 0, divisor = 2;
	bool isPrime = false;
	
	printf("A continuación se permite definir si un numero es primo o no:\n\n");
	
	printf("Por favor ingresa un numero para definir si es primo o no.\n");
	
	if (scanf("%i", &number) != 1) { // Validates the input type (getch returns the number of successfully asigned values, so 1 for a correctly asigned value)
		printf("El valor ingresado debe ser un numero!");
		
		getch();
		
		return 1; // Program ends due to wrong input type 
	}
	
	while (number % divisor != 0) { // Checks that the module isn't 0 (if it is, then it's a prime number)
		
		divisor++; // Increases divisor value by 1 in order to look for the minimun divisor 
		
		if (number == divisor) { // If the number is the same as the divisor, then the number is prime
			isPrime = true;
			break;
		};
			
	}
	
	if (isPrime) {
		printf("El numero %i es un numero primo.", number);
		return 0; // Program ends with successful execution
	}
	
	printf("El numero %i no es un numero primo. Es divisible por %i.", number, divisor);
	
	getch();

	return 0; // Program ends with successful execution
}
