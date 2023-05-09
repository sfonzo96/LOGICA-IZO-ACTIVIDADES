#include <stdio.h>
#include <conio.h>
#include <locale.h>
#include <math.h>

/*
	Problema: El usuario debe poder ingresar los lados de un rect�ngulo y el programa calcula con esos datos la diagonal principal del rect�ngulo, superficie y per�metro. Mostrar al usuario los resultado.
	
	Algoritmo: 
		- Inicio
		- Pedir al usuario que ingrese el valor del primer lado de un react�ngulo
		- Pedir al usuario que ingrese el valor del segundo lado de un react�ngulo
		- Calcular la diagonal del react�ngulo con teorema de Pit�goras (diagonal = hipotenusa del tri�ngulo rectangulo que se forma con los lados)
		- Calcular el per�metro del rect�ngulo como la suma del doble de ambos lados
		- Calcular el �rea del react�ngulo como el producto de los lados ingresados
		- Mostrar los resultados al usuario
		- Fin
*/

void clearInputBuffer() {
	while (getchar() != '\n');
}

int main() {
	float base, height, diagonal, perimeter, area;
	
	setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config
	
	printf("A continuaci�n se permite calcular la diagonal, el per�metro y la superficie de un react�ngulo al ingresar la medida de sus lados.\n");
	
	printf("Por favor, ingres� la longitud del primer lado:\n");
	
	if (scanf("%f", &base) != 1) {
		printf("Ingresaste un s�mbolo o una letra! Debes ingresar un n�mero entero...");
		return 1;
	}
	
	clearInputBuffer();
	
	printf("Por favor, ingres� la longitud del segundo lado:\n");
	
	if (scanf("%f", &height) != 1) {
		printf("Ingresaste un s�mbolo o una letra! Debes ingresar un n�mero entero...");
		return 1;
	}
	
	diagonal = sqrt(pow(base,2) + pow(height,2));
	perimeter = base * 2 + height * 2;
	area = base * height;
	
	printf("Para el rect�ngulo de cuyos lados son %.2f cm y %.2f cm, se tiene que:\nSu diagonal es de %.2f cm, su per�metro es de %.2f cm y su superficie es de %.2f cm2.", base, height, diagonal, perimeter, area);
	
	return 0;
}
