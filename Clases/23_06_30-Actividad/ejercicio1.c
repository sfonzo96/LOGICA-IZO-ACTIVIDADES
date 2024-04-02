/*
	Consigna:
		- Leer de un archivo .txt el valor del dolar (dolarValue.txt)
		- Preguntar al usuario la cantidad de dolares que quiere comprar
		- Mostrar el importe total en pantalla
*/

#include <stdio.h>
#include <conio.h>
#include <locale.h>

void clearInputBuffer() {
	while (getchar() != '\n');
};

int main() {
	float dolarQuantity, dolarValue;
	
	setlocale(LC_CTYPE, "Spanish");
	
	FILE* valueTxt = fopen(".\\values\\dolarValue.txt", "r");
	
	if (valueTxt == NULL) {
		printf("No se pudo cargar el archivo...\n");
		
		return 0;
	};
	
	fscanf(valueTxt, "%f", &dolarValue);
	
	printf("El valor del dólar es: $%.2f.\nIngresa la cantidad de dólares que quiere comprar:\n", dolarValue);
	while (scanf("%f", &dolarQuantity) != 1 && dolarQuantity <= 0) {
		printf("El valor ingresado no es válido...Ingresá otro:\n");
		clearInputBuffer();
	}	
	clearInputBuffer();
	
	printf("El importe total de la operación es de: $%.2f", dolarValue * dolarQuantity);
	return 0;		
}
