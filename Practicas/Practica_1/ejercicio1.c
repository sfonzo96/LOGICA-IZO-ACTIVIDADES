#include <stdio.h>
#include <conio.h>
#include <locale.h>

/*
	Problema: Ingresar dos valores enteros, sumarlos e imprimir esta suma.
	
	Algoritmo: 
		- Inicio
		- Pedir al usuario que ingrese un n�mero
		- Pedir al usuario que ingrese un segundo n�mero
		- Sumar los n�meros ingresados
		- Mostrar el resultado al usuario
		- Fin
*/

void clearInputBuffer() {
	char c;
	while (getchar() != '\n');
}

int main( ) {	
	int firstNumber, secondNumber, sum;
	
	setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config
	
	printf("A continuación se permite obtener la suma de dos números ingresados.\n");
	
	printf("Por favor, ingresá el primer número:\n");
	
	if (scanf("%d", &firstNumber) != 1) {
		printf("Ingresaste un símbolo, una letra o un número con cifras decimales! Debes ingresar un número entero...");
		return 1;
	}
	
	clearInputBuffer();
	
	printf("Por favor, ingresá el segundo número:\n");
	
	if (scanf("%d", &secondNumber) != 1) {
		printf("Ingresaste un símbolo, una letra o un número con cifras decimales! Debes ingresar un número entero...");
		return 1;
	}
	
	sum = firstNumber + secondNumber;
	
	printf("Los números ingresados fueron: %d y %d.\nLa suma de ambos es: %d", firstNumber, secondNumber, sum);
	
	getch();
	
	return 0;
}
