#include <stdio.h>
#include <conio.h>
#include <locale.h>
#include <math.h>

/*
	Problema: Ingresar el valor de la hora y el tiempo trabajado por un comerciante, calcular su sueldo e imprimirlo.
	
	Algoritmo: 
		- Inicio
		- Pedir al usuario que ingrese el valor de la hora de trabajo.
		- Pedir al usuario que ingrese la cantidad de horas trabajadas.
		- Calcular el sueldo.
		- Mostrar el sueldo calculado al usuario
		- Fin
*/

void clearInputBuffer() {
	while (getchar() != '\n');
}

int main() {
	float hourlyPayment, workedHours, monthlyPayment;
	
	setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config
	
	printf("A continuaci�n se permite calcular el sueldo de un comerciante con base en valor de la hora y en la cantidad de horas trabajadas.\n");
	
	printf("Por favor ingresa el valor de la hora de trabajo en pesos:\n");
	if (scanf("%f", &hourlyPayment) != 1) {
		printf("Ingresaste un s�mbolo o una letra! Debes ingresar un n�mero entero...");
		return 1;
	}
	
	clearInputBuffer();
	
	printf("Por favor ingresa la cantidad de horas trabajadas en el mes:\n");
	if (scanf("%f", &workedHours) != 1) {
		printf("Ingresaste un s�mbolo o una letra! Debes ingresar un n�mero entero...");
		return 1;
	}
	
	monthlyPayment = hourlyPayment * workedHours;
	
	printf("Habiendo trabajado %.1f horas, a raz�n de $ %.2f por hora, el sueldo correspondiente del mes es: %.2f.", workedHours, hourlyPayment, monthlyPayment);
	
	getch();
	
	return 0;	
}
