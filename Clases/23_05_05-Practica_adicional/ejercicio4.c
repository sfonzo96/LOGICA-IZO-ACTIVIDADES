#include <stdio.h>
#include <conio.h>
#include <locale.h>
#include <math.h>

/*
	Problema: Solicitar ingresar dos lados de un triángulo rectángulo y calcular, la hipotenusa, el	perímetro, la superficie (área). Imprima los resultados de las operaciones solicitadas.
	
	Algoritmo: 
		- Inicio
		- Pedir al usuario que ingrese el valor del primer lado de un triángulo rectángulo
		- Pedir al usuario que ingrese el valor del segundo lado de un triángulo rectángulo
		- Calcular la hipotenusa del triángulo con teorema de Pitágoras
		- Calcular el perímetro como la suma de los tres lados
		- Calcular el área del triángulo como el producto de los lados ingresados / 2
		- Mostrar los resultados al usuario
		- Fin
*/

void clearInputBuffer() {
	char c;
	while (getchar() != '\n');
}

int main() {
	float firstLeg, secondLeg, hypotenuse, perimeter, area;
	
	setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config
	
	printf("A continuación se permite calcular la hipotenusa, el perímetro y la superficie de un triángulo rectángulo al ingresar la medida de sus lados.");
	
	printf("Por favor, ingresá la longitud del primer lado:\n");
	
	if (scanf("%f", &firstLeg) != 1) {
		printf("Ingresaste un símbolo o una letra! Debes ingresar un número entero...");
		return 1;
	}
	
	clearInputBuffer();
	
	printf("Por favor, ingresá la longitud del segundo lado:\n");
	
	if (scanf("%f", &secondLeg) != 1) {
		printf("Ingresaste un símbolo o una letra! Debes ingresar un número entero...");
		return 1;
	}
	
	hypotenuse = sqrt(pow(firstLeg,2) + pow(secondLeg,2));
	perimeter = firstLeg + secondLeg + hypotenuse;
	area = (firstLeg * secondLeg) / 2;
	
	printf("Para el triángulo rectángulo de cuyos catetos son %.2f cm y %.2f cm, se tiene que:\nSu hipotenusa es de %.2f cm, su perímetro es de %.2f cm y su superficie es de %.2f cm2.",firstLeg, secondLeg, hypotenuse, perimeter, area);
	
	return 0;
}
