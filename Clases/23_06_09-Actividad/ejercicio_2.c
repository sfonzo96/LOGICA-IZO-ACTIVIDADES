// Calcular la suma de 10 n�meros reales ingresados por teclado (acumulador) 

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
	
	printf("Se calcular� la suma de 10 n�meros:\n");
	for (i = 1; i <= 10; i++) {
		printf("Ingresa el %i� n�mero a continuaci�n:\n", i);
		while (scanf("%f", &lastNumber) != 1) {
			printf("El valor ingresado no es v�lido. Ingresalo de nuevo...\n");
			cleanInputBuffer();
		};
		
		sumSoFar += lastNumber;
		
		cleanInputBuffer();
	};
	
	printf("\nLa suma de todos los n�meros ingresados es %.2f.", sumSoFar);
	
	getch();
	
	return 0;
};

