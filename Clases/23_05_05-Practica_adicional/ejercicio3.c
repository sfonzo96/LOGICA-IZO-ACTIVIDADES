#include <stdio.h>
#include <conio.h>
#include <locale.h>

/*
	Problema: Ingresar los lados de un tri�ngulo calcular su per�metro e imprimirlo.
	
	Algoritmo: 
		- Inicio
		- Pedir al usuario que ingrese el valor del primer lado de un tri�ngulo
		- Pedir al usuario que ingrese el valor del segundo lado de un tri�ngulo
		- Pedir al usuario que ingrese el valor del tercer lado de un tri�ngulo
		- Calcular el per�metro como la suma de los tres lados
		- Mostrar el resultado al usuario
		- Fin
*/

void clearInputBuffer() {
	while (getchar() != '\n');
}

int main() {
	int i;
	float perimeter;
	
	setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config
	
	printf("A continuaci�n se permite calcular el per�metro de un tri�ngulo al ingresar la medida de sus lados.");
	
	for (i = 0; i < 3; i++) {
		float triangleSide;
		
		printf("Por favor, ingres� la longitud del %d� lado del tri�ngulo en cm:\n", i + 1);
		
		if (scanf("%f", &triangleSide) != 1) {
			printf("Ingresaste un s�mbolo o una letra! Debes ingresar un n�mero...");
			return 1;
		}
		
		perimeter += triangleSide;
		
		clearInputBuffer();
	}
	
	printf("El per�metro del tri�ngulo es de: %.2f cm", perimeter);
	
	getch();
	
	return 0;
}
