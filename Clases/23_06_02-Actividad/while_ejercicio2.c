/*
Problema: 
Dado un conjunto de números naturales, determinar cuántos de ellos son mayores o iguales que 100. Un número igual a cero indica fin de datos.
*/

#include <stdio.h>
#include <locale.h>

// When called cleans/empties the buffer to avoid typing errors (i.e. non-numeric characterss);
void cleanInputBuffer() {
	while (getchar() != '\n');
}

int main() {
	int i, number;

	setlocale(LC_CTYPE, "Spanish"); // Allows the usage of spanish characters
	
	printf("Este programa permite ingresar números naturales y al finalizar muestra la cantidad de ellos que son mayores o iguales que 100.\n");
	printf("Por favor, ingresá un número natural (entero positivo).\nPara salir ingresá 0.\n\n");
	
	// Loops the input until the user inputs a valid number 
	while (scanf("%d", &number) != 1 || number < 0 ) {
		cleanInputBuffer();
		printf("\nEl dato que ingresaste no es correcto, debe ser un número natural! Ingresá uno:\n");
	};
	
	cleanInputBuffer();
	
	// Loops until the input number is 0 
	while (number != 0) {
		// Increments by 1 the iterator/counter only if the number is bigger or equal to 100
		if (number >= 100) {
			i++;
		}
		
		printf("\nPor favor, ingresá otro número. Para salir ingresá 0.\n\n");
		
		while (scanf("%d", &number) != 1 || number < 0 ) {
			cleanInputBuffer();
			printf("\nEl dato que ingresaste no es correcto, debe ser un número natural! Ingresá uno:");
		};
		
		cleanInputBuffer();
	}
	
	printf("\nConteo finalizado. Ingresaste %i números naturales mayores o iguales que 100.", i);
	
	return 0;
}
