/*
Consigna:
	Generar un tablero tipo ajedrez de tamaño dinámico, es decir, el ususario ingresa la cantidad de filas y columnas deseadas.
*/

#include <stdio.h>
#include <conio.h>
#include <locale.h>

void clearInputBuffer() {
	while (getchar() != '\n');
}

void drawLine(int columns) {
	int z;
	
	for  (z = 0; z < columns * 3; z++ ) {
		printf("%c", '-');
	}	
	
	printf("%c", '\n');
	
}

int main() {
	int x, y;
	int rows, columns;
	
	setlocale(LC_CTYPE, "Spanish");
	
	printf("Por favor ingrese el número de filas del tablero:\n");
	while (scanf("%d", &rows) != 1 || rows < 0 )  {
		printf("El valor ingresado no es válido. Vuelve a ingresarlo:\n");
		clearInputBuffer();
	};
	
	clearInputBuffer();
	
	printf("Por favor ingrese el número de columnas del tablero:\n");
	while (scanf("%d", &columns) != 1 || columns < 0) {
		printf("El valor ingresado no es válido. Vuelve a ingresarlo:\n");
		clearInputBuffer();
	};
	
	drawLine(columns);
	
	for (x = 0; x < rows; x++) {
		
		printf("%c",'|');
		
		for (y = 0; y < columns; y++) {
			
            // Primer alternativa
			/* if (x % 2 == 0) {
				
				if (y % 2 != 0) {
					printf("%s", "##|");
				} else {
					printf("%s","  |");
				}	
				
			} else {
				
				if (y % 2 != 0) {
					printf("%s","  |");
				} else {
					printf("%s", "##|");
				}
	
			} */
			
			// Alternativa compacta, se combinan los caminos de la alternativa anterior
            if ((x + y) % 2 != 0) {
                printf("%s", "##|");
            } else {
                printf("%s", "  |");
            }
		}
		
		printf("%c", '\n');
	}
	
	drawLine(columns);

	return 0;
}
