// Mostrar los números del 0 al 5 de menor a mayor, luego de mayor a menor

#include <stdio.h>
#include <conio.h>


int main () {
	int i;
	
	printf("Orden ascendente:\n");
	for (i = 0; i <= 5; i++) {
		printf("%i\n", i);
	}

	printf("\n\n");
	
	printf("Orden descendente:\n");
	for (i = 5; i >= 0; i--) {
		printf("%i\n", i);
	}
	
	getch();
	
	return 0;
}

