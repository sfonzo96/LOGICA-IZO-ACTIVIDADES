/*
	Problema:
		Una empresa de transporte, desea calcular los litros de combustible que necesita para
		llenar todos los tanques de sus camiones. Sus unidades son del tipo PESADAS con una
		capacidad de carga de 600 litros y de REPARTO, los cuales cargan 80 litros. A la fecha
		cuenta con 36 de las primeras y 11 de REPARTO, pero este número puedo cambiar debido
		a compras de nuevas unidades, por lo tanto se deben ingresar al momento de ejecutar
		el programa. Nos solicitan automatizar este cálculo.

	Datos requeridos:
		- Cantidades de camiones de cada tipo
		- Cantidad de carga por camión por tipo
		- Precio de combustible
		- Forma de pago
		
	Algoritmo:
	 	- Inicio
	 	- Leer número de unidades pesadas
	 	- Leer número de unidades de reparto
	 	- Leer precio de combustible
	 	- Calcular cantidd total de litros necesarios para cargar todos los camiones
	 	- Calcular importe final sin descuento
		- Leer método de pago
	 	- Mostar importe final
*/

#include <stdio.h>
#include <conio.h>
#include <locale.h>
// Constantes semánticas
#define PAGO_CONTADO 1
#define PAGO_TRANSFERENCIA 2
#define CARGA_PESADOS 600
#define CARGA_REPARTO 80

void clearInputBuffer() {
	while(getchar() != '\n');
};

int main() {
	int cantidadCamionesPesados, cantidadCamionesReparto, cargaTotal = 0;
	int metodoPago;
	float precioCombustible, factorDescuentoContado = 0.1, totalAPagarSinDescuento;
	
	setlocale(LC_CTYPE, "Spanish");
	
	printf("Se calculará a continuación el precio a pagar para la carga completa de combustible a todos los camiones:\n");
	
	printf("Ingresa la cantidad de camiones pesados a día de hoy:\n");
	while(scanf("%d", &cantidadCamionesPesados) != 1 || cantidadCamionesPesados < 0) {
		printf("El valor ingresado no es válido, ingresalo nuevamente...\n");
		clearInputBuffer();
	}
	clearInputBuffer();
	
	printf("Ingresa la cantidad de camiones de reparto a día de hoy:\n");
	while(scanf("%d", &cantidadCamionesReparto) != 1 || cantidadCamionesReparto < 0) {
		printf("El valor ingresado no es válido, ingresalo nuevamente...\n");
		clearInputBuffer();
	}
	clearInputBuffer();
	
	cargaTotal = cantidadCamionesPesados * CARGA_PESADOS + cantidadCamionesReparto * CARGA_REPARTO;

	printf("Ingresa el precio del combustible:\n");
	while(scanf("%f", &precioCombustible) != 1 || precioCombustible < 0) {
		printf("El valor ingresado no es válido, ingresalo nuevamente...\n");
		clearInputBuffer();
	}
	clearInputBuffer();
	
	totalAPagarSinDescuento = cargaTotal * precioCombustible;
	
	printf("El costo total para llenar todos los vehículos es de $%.2f.\nSeleccione un método de pago:\n1- Contado (10 %% de descuento)\n2- Transferencia\n", totalAPagarSinDescuento);
	while(scanf("%d", &metodoPago) != 1 || metodoPago < 0 || metodoPago > 2) {
		printf("El valor ingresado no es válido, ingresalo nuevamente...\n");
		clearInputBuffer();
	}
	clearInputBuffer();
	
	switch (metodoPago) {
		case PAGO_CONTADO:
			printf("El total a pagar es de $%.2f.", totalAPagarSinDescuento *  (1 - factorDescuentoContado));
			break;
		case PAGO_TRANSFERENCIA:
			printf("El total a pagar es de $%.2f.", totalAPagarSinDescuento);
			break;
	}
	
	getch();
	
	return 0;
}
