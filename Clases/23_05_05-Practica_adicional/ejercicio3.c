#include <stdio.h>
#include <conio.h>
#include <locale.h>

/*
	Problema: Ingresar los lados de un triángulo calcular su perímetro e imprimirlo.
	
	Algoritmo: 
		- Inicio
		- Pedir al usuario que ingrese el valor del primer lado de un triángulo
		- Pedir al usuario que ingrese el valor del segundo lado de un triángulo
		- Pedir al usuario que ingrese el valor del tercer lado de un triángulo
		- Calcular el perímetro como la suma de los tres lados
		- Mostrar el resultado al usuario
		- Fin
*/

void clearInputBuffer() {
	char c;
	while (getchar() != '\n');
}

int main() {
	int i;
	float perimeter;
	
	setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config
	
	printf("A continuación se permite calcular el perímetro de un triángulo al ingresar la medida de sus lados.");
	
	for (i = 0; i < 3; i++) {
		float triangleSide;
		
		printf("Por favor, ingresá la longitud del %d° lado del triángulo en cm:\n", i + 1);
		
		if (scanf("%f", &triangleSide) != 1) {
			printf("Ingresaste un símbolo o una letra! Debes ingresar un número...");
			return 1;
		}
		
		perimeter += triangleSide;
		
		clearInputBuffer();
	}
	
	printf("El perímetro del triángulo es de: %.2f cm", perimeter);
	
	getch();
	
	return 0;
}
