#include <stdio.h>
#include <conio.h>
#include <locale.h>

/*
	Problema: Ingresar tres valores, sumarlos e imprimir esta suma.
	
	Algoritmo: 
		- Inicio
		- Pedir al usuario ingresar la cantidad de numeros que quiere sumar // Modificaci�n para que la permita sumar cualquier cantidad de n�meros
		- Pedir n veces al usuario que ingrese un numero, siendo n la cantidad que el usuario elige en el paso anterior
		- Sumar los n�meros ingresados en la medida que el usuario los ingresa
		- Mostrar el resultado de la suma al usuario
		- Fin
*/

void clearInputBuffer() {
	while (getchar() != '\n');
}

int main( ) {
	float amountOfNumbers, sum = 0;
	int i;
	
	setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config
	
	printf("A continuaci�n se permite obtener la suma de n n�meros ingresados.\n");
	
	printf("Por favor, ingres� la cantidad de numeros que quieras sumar:\n");
	
	// Sets the amount of numbers to be added
	if (scanf("%f", &amountOfNumbers) != 1) {
		printf("Ingresaste un s�mbolo o una letra! Debes ingresar un n�mero...");
		return 1;
	}
	
	clearInputBuffer();
	
	// loops n times asking for the n-th number, validates and adds it to the sum
	for (i = 0; i < amountOfNumbers; i++) {
		float userNumber;
		
		printf("Por favor, ingres� el %d� n�mero:\n", i + 1);
		
		if (scanf("%f", &userNumber) != 1) {
			printf("Ingresaste un s�mbolo o una letra! Debes ingresar un n�mero...");
			return 1;
		}
		
		sum += userNumber;
		
		clearInputBuffer();
	}
	
	printf("La suma de los n�meros ingresados es: %.0f.", sum);
	
	getch();
	
	return 0;
}
