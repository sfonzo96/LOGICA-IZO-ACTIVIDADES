/*
	Se deben cargar las notas de n alumnos, luego mostrar en pantalla el total de aprobados, el total de aplazados y el promedio
*/

#include <stdio.h>
#include <conio.h>
#include <locale.h>
#include <stdbool.h>
#define NOTA_APROBACION 6

void clearInputBuffer() {
	while(getchar() != '\n');
};

int main() {
	bool cargaTerminada = false;
	float sumaNotas = 0, ultimaNota;
	int cantidadParciales = 0, cantidadParcialesAprobados = 0, cantidadParcialesReprobados = 0, auxCierre;
	
	while (!cargaTerminada) {
		
		if (cantidadParciales == 0) {
			printf("Ingresa una nota:\n");
		} else {
			printf("Ingresaste %d notas de parciales. Ingresa una nota:\n", cantidadParciales);
		}
		
		while(scanf("%f", &ultimaNota) != 1 || ultimaNota < 0 || ultimaNota > 10) {
			printf("El valor ingresado no es válido, ingresalo nuevamente...\n");
			clearInputBuffer();
		}
		clearInputBuffer();
		
		if (ultimaNota >= NOTA_APROBACION) {
			cantidadParcialesAprobados ++;
		} else {
			cantidadParcialesReprobados ++;
		}
				
		sumaNotas += ultimaNota;
		cantidadParciales ++;
		
		system("cls");
		
		printf("Ha ingresado %d notas. Si desea terminar la carga ingrese 0, de lo contrario introduzca cualquier otra tecla y presione \"Enter\" para continuar.\n", cantidadParciales);
		if (scanf("%d", &auxCierre) && auxCierre == 0) {
			cargaTerminada = true;
		} else
		clearInputBuffer();
	}
	
	printf("Se ingresaron %d parciales.\nAprobados: %d.\nAplazados: %d.\nPromedio de notas: %.2f", cantidadParciales, cantidadParcialesAprobados, cantidadParcialesReprobados, sumaNotas / cantidadParciales);
	
	getch();
	
	return 0;
}

