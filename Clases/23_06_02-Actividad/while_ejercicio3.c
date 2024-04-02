/*
Problema: 
Realizar un proceso que confeccione una factura de compra, ingresando el c�digo de art�culo, la cantidad comprada del mismo y su precio unitario. Proponer un fin de datos.
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
	
	printf("Este programa permite confeccionar una factura de compra de acuerdo a los datos ingresados por el usuario.\nSe pueden agregar hasta 10 productos en cantidades m�ximas de 99 unidades y de valor m�ximo $9999 (Solo se admiten valores redondos).\n\n");
	
	int i = 0; // Iterator that points the arrays position where the data will be stored, also works as a loaded articles counter
	while (!processIsFinished || i == 10) {
		
		// Clears the console, aesthetic purposes
		system("cls");
		
		printf("Por favor, ingres� el art�culo (SKU) identificador del producto (m�ximo de 10 caracteres alfanum�ricas):\n");
		// 10s sets a limit for the max characters allowed for the input
		while (scanf("%10s", &productsCodes[i]) != 1) {
			cleanInputBuffer();
			printf("El c�digo que ingresaste excede los 10 caracteres. Ingres� un c�digo v�lido:\n");
		};
		
		cleanInputBuffer();
		
		printf("Por favor, ingres� la cantidad comprada del art�culo %s:\n", productsCodes[i]);
		// Validates that the input is a number (if an decimal number is entered it will only consider the integer part of it since no product can be split in half) and that's positive
		while (scanf("%d", &productsQuantities[i]) != 1 || productsQuantities[i] < 1) {
			cleanInputBuffer();
			printf("La cantidad que ingresaste no es v�lida. Ingres� un n�mero entero positivo:\n");
		};
		
		cleanInputBuffer();
		
		printf("Por favor, ingres� el precio del art�culo %s:\n", productsCodes[i]);
		// Validates that the input is a number and that's positive
		while (scanf("%f", &productsPrices[i]) != 1 || productsPrices[i] <= 0) {
			cleanInputBuffer();
			printf("El precio que ingresaste no es v�lido. Debe ser un n�mero y ser positivo:\n");
		};
		
		cleanInputBuffer();
		
		// Increments the iterator after the article data is loaded correctly
		i++;
		
		printf("Agregaste %d art�culos. Ingres� \"F\" si quer�r terminar la carga de productos, para seguir cargando art�culos presiona cualquier otra tecla.\n", i);
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
	if (i == 10) printf("Alcanzaste el n�mero m�ximo de art�culos por factura. La factura se cerr� con los datos cargados de los primeros 10 productos.\n\n");
	
	printf("Ingresate %i art�culos. A continuaci�n se muestra la factura:\n\n", i);
	
	// Prints the invoice header
	printf("------------------------------------------------FACTURA------------------------------------------\n");
	printf("|\tC�DIGO\t\t|\tCANTIDAD\t|\tPRECIO\t\t|\tSUBTOTAL\t|\n");
	
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
