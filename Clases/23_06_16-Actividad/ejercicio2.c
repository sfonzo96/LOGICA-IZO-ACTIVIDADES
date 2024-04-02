/*
	Un rapipago ingresa el valor de las facturas cobradas en el d�a.
	Su comisi�n es del 3% de lo recaudado.
	Mostrar al final de la carga (salir con input 0), el total del dinero en caja, el neto a pagar y la comisi�n generada.

	Algoritmo:
		- Inicio
		- El usuario ingresa el valor de una factura (n veces)
		- El usuario ingresa la cantidad de un estudiante (n veces)
		- El usuario ingresa 0 para salir
		- Se muestra la suma del total, la comisi�n a cobrar y el neto a pagar
		- Fin
		
	Pseudoc�digo:
		Inclusi�n de archivo de cabecera
		
		Funci�n main
		
			Declaraci�n de variables:
			int invoicesSum = 0, i, lastInvoice;
			float comisionRate = 0.03
			bool loadIsOver = false;
			
			Mientras loadIsOver no sea true hacer:
				
				Escribir: "Ingresa el importe de la factura";
				Leer: lastInvoice;
				
				invocesSum += lastInvoice;
				
			FinMientras
						
			Escribir: ("El importe total de las factuas es : xxxx. La comisi�n a cobrar es de xxxx y el importe neto a pagar es de xxxx");	
		
*/

#include <stdio.h>
#include <conio.h>
#include <locale.h>
#include <stdbool.h>

void clearInputBuffer() {
	while (getchar() != '\n');
}

int main() {
	float invoicesSum = 0, lastInvoiceAmount, comissionRate = 0.03;
	bool loadIsOver = false;
	
	setlocale(LC_CTYPE, "Spanish");
	
	while (!loadIsOver) {
		printf("Ingrese el importe de la factura a continuacion. Ingrese 0 para finalizar.:\n");
		while (scanf("%f", &lastInvoiceAmount) != 1 || lastInvoiceAmount < 0) {
			printf("El valor ingresado no es v�lido. Vuelve a ingresarlo:\n");
			clearInputBuffer();
		};
		
		if (lastInvoiceAmount == 0) {
			loadIsOver = true;
		};
		
		invoicesSum += lastInvoiceAmount; // Case lastInvoice == 0 is irrelevant, doesn't add
		
		clearInputBuffer();
		system("cls");
	};
	
	printf("El total acumulado del d�a es de %.2f.\nSe deben pagar %.2f y la comisi�n a cobrar es de %.2f.", invoicesSum, invoicesSum * (1 - comissionRate), invoicesSum * comissionRate);
	
	getch();
	
	return 0;
}
