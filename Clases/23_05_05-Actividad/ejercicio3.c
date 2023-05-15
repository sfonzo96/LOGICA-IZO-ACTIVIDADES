#include <stdio.h>
#include <conio.h>
#include <locale.h>

// Adds support for math constants
#define _USE_MATH_DEFINES
#include <math.h>

/*
	Problema: 
		Dado un valor para el radio de un círculo, se debe devolver el área del mismo. 
	
	Algoritmo:
		- Inicio
		- Se pide a usuario que ingrese el radio del círculo
		- Se calcula el área del c?rculo como PI*r^2
		- Se muestra al usuario el valor del área del círculo
		- Fin
*/

int main() {
	float radius, circleArea;
	
  setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config

	printf("A continuación se permite calcular el área de un círculo a través de su radio.\n");
	
	printf("Por favor, ingresá el radio del círculo cuyo área quieras calcular en cm: \n");
	if(scanf("%f", &radius) != 1) {
		printf("Tenés que ingresar un número! No una letra ni un símbolo...");
		
		return 1;
	}
	
	circleArea = M_PI * pow(radius,2);
	
	printf("El área del círculo cuyo radio es %.2f cm es: %.2f cm cuadrados.", radius, circleArea);
	
	getch();
	
	return 0;
}
