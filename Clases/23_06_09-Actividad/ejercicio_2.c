// Calcular la suma de 10 números reales ingresados por teclado (acumulador) 

#include <stdio.h>
#include <conio.h>
#include <locale.h>

void cleanInputBuffer() {
	while(getchar() !='\n');
}

int main () {
	int i;
	float lastNumber, sumSoFar = 0;
	
	setlocale(LC_CTYPE, "Spanish");
	
	printf("Se calculará la suma de 10 números:\n");
	for (i = 1; i <= 10; i++) {
		printf("Ingresa el %i° número a continuación:\n", i);
		while (scanf("%f", &lastNumber) != 1) {
			printf("El valor ingresado no es válido. Ingresalo de nuevo...\n");
			cleanInputBuffer();
		};
		
		sumSoFar += lastNumber;
		
		cleanInputBuffer();
	};
	
	printf("\nLa suma de todos los números ingresados es %.2f.", sumSoFar);
	
	getch();
	
	return 0;
};

