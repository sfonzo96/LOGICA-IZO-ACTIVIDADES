#include <stdio.h>
#include <locale.h>

/*
	Problema: Mostrar un men� de tres opciones al usuario:
		- La primera debe mostrar datos de alumnos del IZO al usuario
		- La segunda debe pedir dos n�meros y mostrar el mayor de ellos
		- La tercera debe finalizar el programa
		
	Algoritmo: 
		- Inicio
		- Mostrar men� al usuario
		- Accionar de acuerdo al valor que introdujo el usuario
			+ Si se introdujo la opci�n 1: imprimir los datos de los alumnos
			+ Si se introdujo la opci�n 2: solicitar al usuario dos n�meros, definir cu�l es mayor y mostrarlo
			+ Si se introdujo la opci�n 3: cerrar la ejecuci�n del programa
		- Fin
*/

void clearInputBuffer() { // Clears the input buffer in order to avoid unexpected behaviour
	while (getchar() != '\n');
}


int main( ) {	

	int chosenOption;
	float firstNumber, secondNumber, maxNumber;
	char students[6][25] = {"Fonzo Santiago, 1er a�o", "Gauto Santiago, 1er a�o", "Gomez Alejandro, 1er a�o", "Montero Yael, 1er a�o", "John Doe, 2do a�o", "Jane Doe, 3er a�o"}; // Defines a 2D matrix array that stores students data (6 students and a max length of 25 char for their data) 
	
	setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config
	
	printf("A continuaci�n se ofrece un men� para realizar distintas operaciones.\n\n");
	
	printf("MEN�:\n");
	
	printf("1- Listar alumnos del IZO.\n2- Determinar el mayor entre dos n�meros.\n3- Salir del programa.\n\n");
	
	scanf("%d", &chosenOption);
	
	int i;
	switch (chosenOption) {
		case 1:
			for (i = 0; i <= sizeof(students)/sizeof(students[0]) - 1; i++ ) {
				printf("\n%s.\n", students[i]);
			}
			break;
			
		case 2:

			printf("Se calcular� el mayor de dos n�meros.\nPor favor, introduc� el primer n�mero:\n\n");
			if (scanf("%f", &firstNumber) != 1) {
				printf("Es necesario que introduzcas un n�mero!");
				return 1;
			}
			clearInputBuffer();
			
			printf("Por favor, introduc� el segundo n�mero:\n\n");
			if (scanf("%f", &secondNumber) != 1 || firstNumber == secondNumber) {
				
				if (firstNumber == secondNumber) {
					printf("Son el mismo n�mero!");
					return 1;
				}
				
				printf("Es necesario que introduzcas un n�mero!");
				return 1;
			}
			clearInputBuffer();
			
			maxNumber = firstNumber > secondNumber ? firstNumber : secondNumber; // Sets the max number	
			
			printf("Se ignresaron los n�meros %.1f y %.1f. El mayor de ellos es: %.1f.", firstNumber, secondNumber, maxNumber);
			
			break;
		
		case 3:
			printf("Saliendo del programa...");
			break;
		
		default: // If the input value doesn't match values 1, 2 or 3 => the below message will be printed indicating a wrong input
			printf("La opci�n que seleccionaste no es v�lida, por favor ten� en cuenta que solo se pueden ingresar los valores '1', '2', y '3'.");
			return 1;
	}
	
	return 0;
}
