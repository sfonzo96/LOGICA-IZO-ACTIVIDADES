#include <stdio.h>
#include <conio.h>
#include <locale.h>
#include <math.h>

/*
	Problema: Solicitar ingresar dos lados de un tri�ngulo rect�ngulo y calcular, la hipotenusa, el	per�metro, la superficie (�rea). Imprima los resultados de las operaciones solicitadas.
	
	Algoritmo: 
		- Inicio
		- Pedir al usuario que ingrese el valor del primer lado de un tri�ngulo rect�ngulo
		- Pedir al usuario que ingrese el valor del segundo lado de un tri�ngulo rect�ngulo
		- Calcular la hipotenusa del tri�ngulo con teorema de Pit�goras
		- Calcular el per�metro como la suma de los tres lados
		- Calcular el �rea del tri�ngulo como el producto de los lados ingresados / 2
		- Mostrar los resultados al usuario
		- Fin
*/

void clearInputBuffer() {
	while (getchar() != '\n');
}

int main() {
	float firstLeg, secondLeg, hypotenuse, perimeter, area;
	
	setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config
	
	printf("A continuaci�n se permite calcular la hipotenusa, el per�metro y la superficie de un tri�ngulo rect�ngulo al ingresar la medida de sus lados.");
	
	printf("Por favor, ingres� la longitud del primer lado:\n");
	
	if (scanf("%f", &firstLeg) != 1) {
		printf("Ingresaste un s�mbolo o una letra! Debes ingresar un n�mero entero...");
		return 1;
	}
	
	clearInputBuffer();
	
	printf("Por favor, ingres� la longitud del segundo lado:\n");
	
	if (scanf("%f", &secondLeg) != 1) {
		printf("Ingresaste un s�mbolo o una letra! Debes ingresar un n�mero entero...");
		return 1;
	}
	
	hypotenuse = sqrt(pow(firstLeg,2) + pow(secondLeg,2));
	perimeter = firstLeg + secondLeg + hypotenuse;
	area = (firstLeg * secondLeg) / 2;
	
	printf("Para el tri�ngulo rect�ngulo de cuyos catetos son %.2f cm y %.2f cm, se tiene que:\nSu hipotenusa es de %.2f cm, su per�metro es de %.2f cm y su superficie es de %.2f cm2.",firstLeg, secondLeg, hypotenuse, perimeter, area);
	
	return 0;
}
