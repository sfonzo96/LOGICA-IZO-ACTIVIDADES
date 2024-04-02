/*
	Consigna:
		Crear un programa que:
			- Consuma de un archivo .txt el valor del dolar (dolarValue.txt).
			- Muestre al usuario dicho valor y le consulte la cantidad de dolares a adquirir
			- Guarde el importe total del monto de la venta de dolares en un archivo .txt (records.txt) en forma de lista
*/

#include <stdio.h>
#include <conio.h>
#include <locale.h>

void clearInputBuffer() {
	while (getchar() != '\n');
};

int main() {
	float dolarValue, dolarQuantity, total;
	
	setlocale(LC_CTYPE, "Spanish");
	
	FILE* dolarValueTxt = fopen(".\\values\\dolarValue.txt", "r");
	FILE* recordsTxt = fopen(".\\records\\records.txt", "a");
	
	if (dolarValueTxt == NULL) {
		printf("No se pudo cargar el archivo...\n");
		
		return 1;
	};
	
	fscanf(dolarValueTxt, "%f", &dolarValue);
	 
	if (recordsTxt == NULL) {
		printf("No se pudo cargar el archivo...\n");
		
		return 1;
	};
		
	printf("El valor del dolar es: $%.2f.\nIngrese la cantidad de dolares deseada:\n", dolarValue);
	while (scanf("%f", &dolarQuantity) != 1 && dolarQuantity < 0 ) {
		printf("El valor ingresado no es válido...Ingresá otro:\n");
		clearInputBuffer();
	};
	
	clearInputBuffer();
	
	total = dolarValue * dolarQuantity;
	
	printf("El importe total a pagar por la operación es: $%.2f.", total);
	
	fprintf(recordsTxt, "%.2f;%.2f%c", total, dolarQuantity,'\n');
	
	return 0;
}
