/*
	Consigna parcial:
	
		Elaborar programa para cobro de peaje:
			- Categoria auto = importe 1 (100)
			- Categoria camion = importe 2 (200)
			- El importe se paga por eje de acuerdo a la categoria del vehiculo.
			- Se debe mostrar el total a pagar y guardar en un historial.
			- Se deben poder cargar tantos cobros como se quiera hasta que se decida finalizar.
*/

#include <stdio.h>
#include <locale.h>
#include <conio.h>
#include <stdbool.h>

void clearInputBuffer() {
	while (getchar() != '\n');
}

int main() {
	float importeAuto, importeCamion, totalACobrar;
	int tipoVehiculo, cantidadEjes, i = 0;
	bool cargaEstaTerminada = false;
	
	FILE* importeAutoTxt = fopen(".\\importe1.txt", "r");
	FILE* importeCamionTxt = fopen(".\\importe2.txt", "r");
	FILE* historialTxt = fopen(".\\historial.txt", "a");
	
	setlocale(LC_CTYPE, "Spanish");

	printf("Se inicia una nueva tanda de cobro de peajes.\n\n");
	
	if (importeAutoTxt == NULL || importeCamionTxt == NULL || historialTxt == NULL) {
		printf("Uno de los archivos no se pudo abrir de manera exitosa. Se cerrará el programa.");
		getch();
		return 1;
	}
	
	fscanf(importeCamionTxt,"%f", &importeCamion);
	fscanf(importeAutoTxt,"%f", &importeAuto);
	
	while (!cargaEstaTerminada) {
		printf("Seleccione la categoría correspondiente al vehículo:\n1- Auto\n2- Camión\n");
		while(scanf("%d", &tipoVehiculo) != 1 || tipoVehiculo < 0 || tipoVehiculo > 2) {
			printf("El valor ingresado no es correcto, por favor ingresalo nuevamente...\n");
			clearInputBuffer();
		}
		clearInputBuffer;
		
		system("cls");
		
		printf("Ingrese la cantidad de ejes del vehículo:");
		while(scanf("%d", &cantidadEjes) != 1 || cantidadEjes < 0) {
			printf("El valor ingresado no es correcto, por favor ingresalo nuevamente...\n");
			clearInputBuffer();
		}
		clearInputBuffer;
		printf("%d", cantidadEjes);
		
		system("cls");
		
		totalACobrar = (tipoVehiculo == 1? importeAuto : importeCamion) * cantidadEjes;
		
		fprintf(historialTxt, "%.2f", totalACobrar);
		fprintf(historialTxt, "%c", '\n');
		
		printf("Se cobrarán $%.2f.\n\nPresione cualquier tecla para confirmar...\n", totalACobrar);
		getch();
		
		i++;
		
		system("cls");
		
		int opcionMenu;
		printf("Se registraron %i cobros. Seleccione como continuar:\n1- Seguir cobrando\n2- Finalizar\n", i);
		while(scanf("%d", &opcionMenu) != 1 || opcionMenu < 0 || opcionMenu > 2) {
			printf("El valor ingresado no es correcto, por favor ingresalo nuevamente...\n");
			clearInputBuffer();
		}
		clearInputBuffer();
		
		system("cls");
		
		if (opcionMenu == 2) {
			cargaEstaTerminada = true;
		}
	}
	
	printf("Se ha finalizado la cobranza.");
	
	return 0;
}
