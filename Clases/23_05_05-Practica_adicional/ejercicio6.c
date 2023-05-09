#include <stdio.h>
#include <conio.h>
#include <locale.h>

/*
	Problema: Ingresar dos valores, calcular su suma, su producto y la resta del 1ro menos el 2do valor ingresado, imprimir los resultados.
	
	Algoritmo: 
		- Inicio
		- Pedir al usuario que ingrese el primer valor.
		- Pedir al usuario que ingrese el segundo valor.
		- Calcular la suma de los valores.
		- Calcular el producto de los valores.
		- Calcular la diferencia de los valores (primero - segundo).
		- Mostrar los resultados al usuario
		- Fin
*/

void clearInputBuffer() {
	while (getchar() != '\n');
}

int main() {
	float firstNumber, secondNumber, sum, product, subtraction;
	
	setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config
	
	printf("A continuaci�n se permite obtener la suma, el producto y la diferencia entre dos n�meros ingresados.\n");
	
	printf("Por favor, ingres� el primer n�mero:\n");
	
	if (scanf("%f", &firstNumber) != 1) {
		printf("Ingresaste un s�mbolo o una letra! Debes ingresar un n�mero entero...");
		return 1;
	}
	
	clearInputBuffer();
	
	printf("Por favor, ingres� el segundo n�mero:\n");
	
	if (scanf("%f", &secondNumber) != 1) {
		printf("Ingresaste un s�mbolo o una letra! Debes ingresar un n�mero entero...");
		return 1;
	}
	
	sum = firstNumber + secondNumber;
	product = firstNumber * secondNumber;
	subtraction = firstNumber - secondNumber;
	
	printf("Los n�meros ingresados fueron: %.2f y %.2f.\nLa suma de ambos es %.2f, su producto es %.2f y su resta es %.2f", firstNumber, secondNumber, sum, product, subtraction);
	
	getch();
	
	return 0;
}
