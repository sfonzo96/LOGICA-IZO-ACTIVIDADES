#include <stdio.h>
#include <stdbool.h>

int main() {
	int number = 0, divisor = 2;
	bool isPrime = false;
	
	printf("Por favor ingresa un numero para definir si es primo o no. Si quieres detener el programa introduce un caracter que no sea un numero.\n");
	
	if (scanf("%i", &number) != 1) {
		printf("El valor ingresado debe ser un numero!");
		
		getch();
		
		return 1;	
	}
	
	while (number % divisor != 0) {
		
		divisor++;
		
		if (number == divisor) {
			isPrime = true;
			break;
		};
			
	}
	
	if (isPrime) {
		printf("El numero %i es un numero primo.", number);
		return 0;
	}
	
	printf("El numero %i no es un numero primo. Es divisible por %i.", number, divisor);
	
	getch();

	return 0;
	
}
