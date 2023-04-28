#include <stdio.h>
#include <conio.h>

int main() {
	
	printf("Calculando la suma de todos los numeros pares entre 2 y 1000...\n\n");
	
	int sum = 0, i;
	
	for (i = 2; i <= 1000; i += 2) { // Loops over even numbers: starts from i = 2 and adds 2 every iteration.
		sum += i; // Accumulates the sum in the so called variable.
	}
	
	printf("La suma de todos los numeros pares entre 2 y 1000 es: %i", sum);
	
	getch();

	return 0; // Program ends with successful execution
}
