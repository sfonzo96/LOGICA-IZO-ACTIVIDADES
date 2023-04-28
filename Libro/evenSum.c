#include <stdio.h>

int main() {
	
	printf("Calculando la suma de todos los numeros pares entre 2 y 1000...\n\n");
	
	int suma = 0, i;
	
	for (i = 2; i <= 1000; i += 2) {
		suma += i;
	}
	
	printf("La suma de todos los numeros pares entre 2 y 1000 es: %i", suma);
	
	getch();

	return 0;	
}
