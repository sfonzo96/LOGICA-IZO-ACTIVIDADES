// Se tienen como datos los importes de todas las facturas correspondientes al mes que acaba de finalizar de un comercio (no se sabe cuántas son). Se desea conocer:
// 	a. Cuántas facturas se realizaron.
// 	b. Importe promedio de las mismas.
// 	c. Cuántos son los importes que superan los 3000 pesos.

#include <stdio.h>
#include <locale.h>
#include <stdbool.h>
#include <conio.h>

// When called cleans/empties the buffer to avoid typing errors (i.e. non-numeric characterss);
void cleanInputBuffer() {
	while (getchar() != '\n');
}

int main() {
	int invoiceCount = 0, overThresholdCount = 0; // These store the number of introduced invoices and the number of those whos value exceeded the threshold value, respectively
	const float INVOICE_VALUE_THRESHOLD = 3000; // Sets a threshold, when exceeded it will be counted separately 
	float monthlyTotal = 0; // This stores the monthly total value (sums of every invoice total).
	float currentValue; // Auxiliary variable to store the last introduced invoice value
	bool processIsFinished = false; // When true, indicates that the process (while loop ) should be ended
	
	printf("Este programa permite procesar importes de facturas registradas en el mes y devulve: la cantidad registrada, el valor promedio y la cantidad cuyo importe supere los $3000.\n\n");
	
	setlocale(LC_CTYPE, "Spanish"); // Allows the usage of spanish characters
	
	while (!processIsFinished) {
		
		if (invoiceCount != 0) system("cls");
		
		printf("Por favor ingresá el importe de la factura.\n");
		// Validates that the input is a number and that it's not 0 nor negative
		while (scanf("%f", &currentValue) != 1 || currentValue <= 0 ) {
			cleanInputBuffer();
			printf("El valor debe ser un número positivo. Revisa el valor y volvé a introducirlo:\n");
		};
		
		cleanInputBuffer();		
		
		invoiceCount++;	// Increments the invouce count
		monthlyTotal += currentValue; // Sums the values of each invoice value
		
		
		// Checks if the latest value is over the threshold, if so, increments the counter 
		if (currentValue > INVOICE_VALUE_THRESHOLD) {
			overThresholdCount++;
		};
		
		printf("Agregaste %d facturas. Ingresá \"F\" si querér terminar la carga de facturas, para seguir cargando facturas presiona cualquier otra tecla.\n", invoiceCount);
		char input;
		scanf("%c", &input);
		// Checks if the user wants to finish the loading proces, if so, then processIsFinished is set to true leading to the ending of the while loop
		if (tolower(input) == 'f') {
			processIsFinished = true;	
		};
		
		cleanInputBuffer();
	}
	
	system("cls");
	
	// Shows a summary with the processed information
	printf("Ingresate %i facturas.\nEl número de ellas que superan los $%.2f es %i.\nEl valor total facturado en el mes es de %.2f y el valor promedio es de %.2f.\n", invoiceCount, INVOICE_VALUE_THRESHOLD, overThresholdCount, monthlyTotal, monthlyTotal / invoiceCount);
	
	getch();
	
	return 0;
}

