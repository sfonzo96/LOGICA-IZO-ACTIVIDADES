#include <stdio.h>
#include <conio.h>
#include <locale.h>
#include <math.h>

/*
	Problema: El usuario debe poder ingresar los lados de un rectángulo y el programa calcula con esos datos la diagonal principal del rectángulo, superficie y perímetro. Mostrar al usuario los resultado.
	
	Algoritmo: 
		- Inicio
		- Pedir al usuario que ingrese el valor del primer lado de un reactángulo
		- Pedir al usuario que ingrese el valor del segundo lado de un reactángulo
		- Calcular la diagonal del reactángulo con teorema de Pitágoras (diagonal = hipotenusa del triángulo rectangulo que se forma con los lados)
		- Calcular el perímetro del rectángulo como la suma del doble de ambos lados
		- Calcular el área del reactángulo como el producto de los lados ingresados
		- Mostrar los resultados al usuario
		- Fin
*/

void clearInputBuffer() {
	char c;
	while (getchar() != '\n');
}

int main() {
	float base, height, diagonal, perimeter, area;
	
	setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config
	
	printf("A continuación se permite calcular la diagonal, el perímetro y la superficie de un reactángulo al ingresar la medida de sus lados.\n");
	
	printf("Por favor, ingresá la longitud del primer lado:\n");
	
	if (scanf("%f", &base) != 1) {
		printf("Ingresaste un símbolo o una letra! Debes ingresar un número entero...");
		return 1;
	}
	
	clearInputBuffer();
	
	printf("Por favor, ingresá la longitud del segundo lado:\n");
	
	if (scanf("%f", &height) != 1) {
		printf("Ingresaste un símbolo o una letra! Debes ingresar un número entero...");
		return 1;
	}
	
	diagonal = sqrt(pow(base,2) + pow(height,2));
	perimeter = base * 2 + height * 2;
	area = base * height;
	
	printf("Para el rectángulo de cuyos lados son %.2f cm y %.2f cm, se tiene que:\nSu diagonal es de %.2f cm, su perímetro es de %.2f cm y su superficie es de %.2f cm2.", base, height, diagonal, perimeter, area);
	
	return 0;
}
