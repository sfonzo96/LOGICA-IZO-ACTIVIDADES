/*
Problema: 
Dado un conjunto de n�meros naturales, determinar cu�ntos de ellos son mayores o iguales que 100. Un n�mero igual a cero indica fin de datos.
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
	
	printf("Este programa permite ingresar n�meros naturales y al finalizar muestra la cantidad de ellos que son mayores o iguales que 100.\n");
	printf("Por favor, ingres� un n�mero natural (entero positivo).\nPara salir ingres� 0.\n\n");
	
	// Loops the input until the user inputs a valid number 
	while (scanf("%d", &number) != 1 || number < 0 ) {
		cleanInputBuffer();
		printf("\nEl dato que ingresaste no es correcto, debe ser un n�mero natural! Ingres� uno:\n");
	};
	
	cleanInputBuffer();
	
	// Loops until the input number is 0 
	while (number != 0) {
		// Increments by 1 the iterator/counter only if the number is bigger or equal to 100
		if (number >= 100) {
			i++;
		}
		
		printf("\nPor favor, ingres� otro n�mero. Para salir ingres� 0.\n\n");
		
		while (scanf("%d", &number) != 1 || number < 0 ) {
			cleanInputBuffer();
			printf("\nEl dato que ingresaste no es correcto, debe ser un n�mero natural! Ingres� uno:");
		};
		
		cleanInputBuffer();
	}
	
	printf("\nConteo finalizado. Ingresaste %i n�meros naturales mayores o iguales que 100.", i);
	
	return 0;
}
