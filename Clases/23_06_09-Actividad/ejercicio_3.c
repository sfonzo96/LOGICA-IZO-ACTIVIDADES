// Calcular la suma de los N primeros números naturales. Ingrese N por teclado. 


#include <stdio.h>
#include <conio.h>
#include <locale.h>

void cleanInputBuffer() {
	while(getchar() !='\n');
}

int main() {
	int i, topIndex;
	float sumSoFar = 0;
	
	setlocale(LC_CTYPE, "Spanish");
	
	printf("Se calcula la suma de los N primeros números naturales:\n");
	printf("Ingrese N:\n");
	while (scanf("%i", &topIndex) != 1 || topIndex <= 0){
		printf("El valor ingresado no es un número válido. Ingresalo nuevamente...\n");
		cleanInputBuffer();
	}
	
	for (i = 0; i <= topIndex; i++) {
		sumSoFar += i;
	};
	
	printf("La suma de los %i primeros números naturales es: %.1f.", topIndex, sumSoFar);
	
	getch();
	
	return 0;
}
