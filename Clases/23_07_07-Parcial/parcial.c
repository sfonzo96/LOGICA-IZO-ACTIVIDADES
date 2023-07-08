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
	float importeAuto, importeCamion, totalACobrar, importeLista, totalPeriodo = 0;;
	int tipoVehiculo, cantidadEjes, i = 0, opcionMenu;
	bool cargaEstaTerminada = false;
	
	FILE* importeAutoTxt = fopen(".\\importe1.txt", "r");
	FILE* importeCamionTxt = fopen(".\\importe2.txt", "r");
	FILE* historialTxtAppend = fopen(".\\historial.txt", "a");
	FILE* historialTxtRead = fopen(".\\historial.txt", "r");
	
	setlocale(LC_CTYPE, "Spanish");

	printf("Se inicia una nueva tanda de cobro de peajes.\n\n");
	
	// Verifica que se hayan encontrado los archivos
	if (importeAutoTxt == NULL || importeCamionTxt == NULL || historialTxtAppend == NULL || historialTxtRead == NULL) {
		printf("Uno de los archivos no se pudo abrir de manera exitosa. Se cerrará el programa.");
		getch();
		return 1;
	}
	
	// Toma los valores de los archivos
	fscanf(importeCamionTxt,"%f", &importeCamion);
	fscanf(importeAutoTxt,"%f", &importeAuto);
	
	// Cierra la conexión a los archivos
	fclose(importeAutoTxt);
    fclose(importeCamionTxt);
	
	while (!cargaEstaTerminada) {
		// Píde al usuario la categoría del vehículo
		printf("Seleccione la categoría correspondiente al vehículo:\n1- Auto\n2- Camión\n");
		while(scanf("%d", &tipoVehiculo) != 1 || tipoVehiculo < 0 || tipoVehiculo > 2) {
			printf("El valor ingresado no es correcto, por favor ingresalo nuevamente...\n");
			clearInputBuffer();
		}
		clearInputBuffer;
		
		system("cls");
		
		// Pide al usuario la cantidad de ejes del vehículo
		printf("Ingrese la cantidad de ejes del vehículo:");
		while(scanf("%d", &cantidadEjes) != 1 || cantidadEjes < 0) {
			printf("El valor ingresado no es correcto, por favor ingresalo nuevamente...\n");
			clearInputBuffer();
		}
		clearInputBuffer;
		printf("%d", cantidadEjes);
		
		system("cls");
		
		// Calcula el total a cobrar de acuerdo al tipo de vehículo
		totalACobrar = (tipoVehiculo == 1? importeAuto : importeCamion) * cantidadEjes;
		
		// Guarda el valor a cobrar en el historia y agrega un salto de línea
		fprintf(historialTxtAppend, "%.2f\n", totalACobrar);
		
		printf("Se cobrarán $%.2f.\n\nPresione cualquier tecla para confirmar...\n", totalACobrar);
		getch();
		
		i++;
		
		system("cls");
		
		// Pide al usuario que elija como continuar
		printf("Se registraron %i cobros. Seleccione como continuar:\n1- Seguir cobrando\n2- Finalizar\n", i);
		while(scanf("%d", &opcionMenu) != 1 || opcionMenu < 0 || opcionMenu > 2) {
			printf("El valor ingresado no es correcto, por favor ingresalo nuevamente...\n");
			clearInputBuffer();
		}
		clearInputBuffer();
		
		system("cls");
		
		// Si el usuario elige salir se cambia la condición que controla el bucle
		if (opcionMenu == 2) {
			cargaEstaTerminada = true;
		}
	}
	
	printf("Se ha finalizado la cobranza.\n\n");
	
	printf("----COBROS REGISTRADOS AL CORRIENTE----\n");

    while(fscanf(historialTxtRead, "%f", &importeLista) == 1) {
		printf("$\t%.2f\n", importeLista);
		totalPeriodo += importeLista;
	}
	printf("---------------------TOTAL:\n$\t%.2f", totalPeriodo);
	
	
	fclose(historialTxtRead);
	fclose(historialTxtAppend);
	
	return 0;
};
