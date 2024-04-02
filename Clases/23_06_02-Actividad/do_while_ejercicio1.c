// Problema: Realizar un programa que tome un valor entero y verifique si el mismo se encuentra entre 1 y 10 incluidos.

#include <stdio.h>
#include <locale.h>
#include <conio.h>

// When called cleans/empties the buffer to avoid typing errors (i.e. non-numeric characterss);
void cleanInputBuffer() {
	while (getchar() != '\n');
}

int main() {
	int number; // Stores the last introduced number
	int i = 0; // an auxiliary operator
	
	setlocale(LC_CTYPE, "Spanish"); // Allows the usage of spanish characters
	
	printf("Este programa verifica si el númerto introducido esté en el intervalo [1;10].\n");
	
	do {
	
		// Verifies if it's the first try or not, in order to show a different message
		if (i == 0) {
			printf("Introduce un número entero entre 1 y 10.");
		} else {
			printf("El número que ingresaste está fuera del rango. Introduce otro a continuación:\n");
		};
		
		// Increments the iterator
		i++;
		
		// Validates that the input is a number
		while (scanf("%i", &number) != 1) {
			printf("El valor ingresado no es un número entero. Ingresalo otra vez: \n");
			cleanInputBuffer();
		};
		
		cleanInputBuffer();
		
	} while (number < 1 || number > 10);
	
	system("cls");
		
	printf("Ingresaste el número %i. Correctamente, está en entre 1 y 10, incluídos.", number);
	
	getch();
	
	return 0;
}
