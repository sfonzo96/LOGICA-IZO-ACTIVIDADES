/* 
	Transformar en código el pseudocódigo que se muestra a continuación, correspondiente
	a proporcionar el precio promedio de una moto, calculado a partir del precio de la
	misma en tres agencias locales.
	Los precios para el cálculo son introducidos por el usuario.
	1. Inicio
	2. Mostrar “Introduzca el precio en AGENCIA_1”: precio1
	3. Mostrar “Introduzca el precio en AGENCIA_2”: precio2
	4. Mostrar “Introduzca el precio en AGENCIA_3": precio3
	5. promedio = (precio1 + precio2 + precio3) / 3
	6. Mostrar “El precio medio de la moto es”, promedio, “PESOS”
	7. Fin
*/

#include <stdio.h>
#include <conio.h>
#include <locale.h>

void clearInputBuffer() {
	while(getchar() != '\n');
};

int main() {
	float precioAgencia1, precioAgencia2, precioAgencia3, precioPromedio = 0;
	
	setlocale(LC_CTYPE, "Spanish");
	
	printf("Ingresa el precio de la moto de interés en la agencia 1:\n");
	while(scanf("%f", &precioAgencia1) != 1 || precioAgencia1 < 0) {
		printf("El valor ingresado no es válido, ingresalo nuevamente...\n");
		clearInputBuffer();
	}
	clearInputBuffer();
	
	printf("Ingresa el precio de la moto de interés en la agencia 2:\n");
	while(scanf("%f", &precioAgencia2) != 1 || precioAgencia2 < 0) {
		printf("El valor ingresado no es válido, ingresalo nuevamente...\n");
		clearInputBuffer();
	}
	clearInputBuffer();
	
	printf("Ingresa el precio de la moto de interés en la agencia 3:\n");
	while(scanf("%f", &precioAgencia3) != 1 || precioAgencia3 < 0) {
		printf("El valor ingresado no es válido, ingresalo nuevamente...\n");
		clearInputBuffer();
	}
	clearInputBuffer();
	
	precioPromedio = (precioAgencia1 + precioAgencia2 + precioAgencia3) / 3;
	
	printf("El precio promedio de la moto entre las agencias es de: %.2f.", precioPromedio);

	getch();
	
	return 0;
}	
