/*
Problema: 
Ingresar un conjunto de números reales positivo. Para finalizar la entrada de datos ingresar un cero. Determinar e informar la cantidad de números ingresados.
*/

#include <stdio.h>
#include <locale.h>

// When called cleans/empties the buffer to avoid typing errors (i.e. non-numeric characterss);
void cleanInputBuffer() {
	while (getchar() != '\n');
}

int main() {
	int i;
	float lastNumber;

	setlocale(LC_CTYPE, "Spanish"); // Allows the usage of spanish characters
	
	printf("Este programa cuenta la cantidad de números ingresados.\n");
	printf("Por favor, ingresá un número...\nPara salir ingresá 0.\n\n");
	
	// Validates the first input
	while (scanf("%f", &lastNumber) != 1 || lastNumber < 0 ) {
		cleanInputBuffer();
		printf("\nEl dato que ingresaste no es correcto, debe ser un número real y positivo! Ingresá uno:\n");
	};
	
	cleanInputBuffer();
	
	// Loops until the input number is 0
	while (lastNumber != 0) {
		// Increments by 1 the iterator/counter
		i++;
		
		printf("\nPor favor, ingresá otro número. Para salir ingresá 0.\n\n");
		
		// Validates the input
		while (scanf("%f", &lastNumber) != 1 || lastNumber < 0 ) {
			cleanInputBuffer();
			printf("\nEl dato que ingresaste no es correcto, debe ser un número real y positivo! Ingresá uno:");
		};
		
		cleanInputBuffer();
	}
	
	printf("\nConteo finalizado. Ingresaste %i números reales positivos.", i);
	
	return 0;
}
