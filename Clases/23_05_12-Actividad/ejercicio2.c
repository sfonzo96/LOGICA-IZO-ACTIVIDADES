#include <stdio.h>
#include <locale.h>

/*
	Problema: Mostrar un menú de tres opciones al usuario:
		- La primera debe mostrar datos de alumnos del IZO al usuario
		- La segunda debe pedir dos números y mostrar el mayor de ellos
		- La tercera debe finalizar el programa
		
	Algoritmo: 
		- Inicio
		- Mostrar menú al usuario
		- Accionar de acuerdo al valor que introdujo el usuario
			+ Si se introdujo la opción 1: imprimir los datos de los alumnos
			+ Si se introdujo la opción 2: solicitar al usuario dos números, definir cuál es mayor y mostrarlo
			+ Si se introdujo la opción 3: cerrar la ejecución del programa
		- Fin
*/

void clearInputBuffer() {
	while (getchar() != '\n');
}


int main( ) {	

	int chosenOption;
	float firstNumber, secondNumber, maxNumber;
	char students[6][25] = {"Fonzo Santiago, 1er año", "Gauto Santiago, 1er año", "Gomez Alejandro, 1er año", "Montero Yael, 1er año", "John Doe, 2do año", "Jane Doe, 3er año"};
	
	setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config
	
	printf("A continuación se ofrece un menú para realizar distintas operaciones.\n\n");
	
	printf("MENÚ:\n");
	
	printf("1- Listar alumnos del IZO.\n2- Determinar el mayor entre dos números.\n3- Salir del programa.\n\n");
	
	scanf("%d", &chosenOption);
	
	int i;
	switch (chosenOption) {
		case 1:
			for (i = 0; i <= sizeof(students)/sizeof(students[0]) - 1; i++ ) {
				printf("\n%s.\n", students[i]);
			}
			break;
			
		case 2:

			printf("Se calculará el mayor de dos números.\nPor favor, introducí el primer número:\n\n");
			if (scanf("%f", &firstNumber) != 1) {
				printf("Es necesario que introduzcas un número!");
				return 1;
			}
			clearInputBuffer();
			
			printf("Por favor, introducí el segundo número:\n\n");
			if (scanf("%f", &secondNumber) != 1) {
				printf("Es necesario que introduzcas un número!");
				return 1;
			}
			
			maxNumber = firstNumber > secondNumber ? firstNumber : secondNumber; 		
			
			printf("Se ignresaron los números %.1f y %.1f. El mayor de ellos es: %.1f.", firstNumber, secondNumber, maxNumber);
			
			break;
		
		case 3:
			printf("Saliendo del programa...");
			break;
		
		default:
			printf("La opción que seleccionaste no es válida, por favor tené en cuenta que solo se pueden ingresar los valores '1', '2', y '3'.");
			return 1;
	}
	
	return 0;
}
