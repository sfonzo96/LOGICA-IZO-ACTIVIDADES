/*
Problema: 
Realizar un proceso que confeccione una factura de compra, ingresando el código de artículo, la cantidad comprada del mismo y su precio unitario. Proponer un fin de datos.
*/

#include <stdio.h>
#include <locale.h>
#include <stdbool.h>
#include <conio.h>

// When called cleans/empties the buffer to avoid typing errors (i.e. non-numeric characterss);
void cleanInputBuffer() {
	while (getchar() != '\n');
}

int main() {	
	bool processIsFinished = false; // When true, indicates that the process (while loop ) should be ended
	char productsCodes[11][11]; // Creates an array of 10 strings, each allowing up to 10 characters (11 in order to contemplate '\0' character: end of array indicator
	int productsQuantities[11]; // Creates an array of 10 integers (reason for 11: read previous comment)
	float productsPrices[11]; // Creates an array of 10 float numbers (reason for 11: read previous comments)
	
	setlocale(LC_CTYPE, "Spanish"); // Allows the usage of spanish characters
	
	printf("Este programa permite confeccionar una factura de compra de acuerdo a los datos ingresados por el usuario.\nSe pueden agregar hasta 10 productos en cantidades máximas de 99 unidades y de valor máximo $9999 (Solo se admiten valores redondos).\n\n");
	
	int i = 0; // Iterator that points the arrays position where the data will be stored, also works as a loaded articles counter
	while (!processIsFinished || i == 10) {
		
		// Clears the console, aesthetic purposes
		system("cls");
		
		printf("Por favor, ingresá el artículo (SKU) identificador del producto (máximo de 10 caracteres alfanuméricas):\n");
		// 10s sets a limit for the max characters allowed for the input
		while (scanf("%10s", &productsCodes[i]) != 1) {
			cleanInputBuffer();
			printf("El código que ingresaste excede los 10 caracteres. Ingresá un código válido:\n");
		};
		
		cleanInputBuffer();
		
		printf("Por favor, ingresá la cantidad comprada del artículo %s:\n", productsCodes[i]);
		// Validates that the input is a number (if an decimal number is entered it will only consider the integer part of it since no product can be split in half) and that's positive
		while (scanf("%d", &productsQuantities[i]) != 1 || productsQuantities[i] < 1) {
			cleanInputBuffer();
			printf("La cantidad que ingresaste no es válida. Ingresá un número entero positivo:\n");
		};
		
		cleanInputBuffer();
		
		printf("Por favor, ingresá el precio del artículo %s:\n", productsCodes[i]);
		// Validates that the input is a number and that's positive
		while (scanf("%f", &productsPrices[i]) != 1 || productsPrices[i] <= 0) {
			cleanInputBuffer();
			printf("El precio que ingresaste no es válido. Debe ser un número y ser positivo:\n");
		};
		
		cleanInputBuffer();
		
		// Increments the iterator after the article data is loaded correctly
		i++;
		
		printf("Agregaste %d artículos. Ingresá \"F\" si querér terminar la carga de productos, para seguir cargando artículos presiona cualquier otra tecla.\n", i);
		char input;
		scanf("%c", &input);
		// Checks if the user wants to finish the loading proces, if so, then processIsFinished is set to true leading to the ending of the while loop
		if (tolower(input) == 'f') {
			processIsFinished = true;	
		};
		
		cleanInputBuffer();
	}
	
	system("cls");
	
	// Limits the amount of products to the previously defined array size
	if (i == 10) printf("Alcanzaste el número máximo de artículos por factura. La factura se cerró con los datos cargados de los primeros 10 productos.\n\n");
	
	printf("Ingresate %i artículos. A continuación se muestra la factura:\n\n", i);
	
	// Prints the invoice header
	printf("------------------------------------------------FACTURA------------------------------------------\n");
	printf("|\tCÓDIGO\t\t|\tCANTIDAD\t|\tPRECIO\t\t|\tSUBTOTAL\t|\n");
	
	int j; // Iterator that goes over the arrays positions getting the data in order to show it
	float total = 0; // Accumulates the subtotal of each product in order to show the invoice total
	
	// Goes overs every position of the array that has stored data (since arrays positions indexes starts at 0, it will be the number of products (i) - 1) and prints a table line with it
	for (j = 0; j < i; j++) {
		printf("-------------------------------------------------------------------------------------------------\n");
		printf("|\t%-10s\t|\t%-2d\t\t|\t%.2f\t\t|\t%.2f\t\t|\n", productsCodes[j], productsQuantities[j], productsPrices[j], productsQuantities[j] * productsPrices[j]);
		// Accumulates the subtotals
		total += productsQuantities[j] * productsPrices[j];
	}
	printf("|-------------------------------------------------------------------------------| Total: %.2f|\n", total);

	getch();

	return 0;
}
