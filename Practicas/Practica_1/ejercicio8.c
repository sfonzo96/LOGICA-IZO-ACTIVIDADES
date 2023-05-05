#include <stdio.h>
#include <conio.h>
#include <locale.h>

/*
	Problema: Ingresar el tiempo trabajado por un contador y considerando que el valor de la hora es de 800 pesos, calcular su sueldo e imprimirlo.
	
	Algoritmo: 
		- Inicio
		- Pedir al usuario que ingrese la cantidad de horas trabajadas.
		- Calcular el sueldo.
		- Mostrar el sueldo calculado al usuario
		- Fin
*/

void clearInputBuffer() {
	char c;
	while (getchar() != '\n');
}

int main() {
	float workedHours, monthlyPayment;
	const float HOURLY_PAYMENT = 800.00;
	
	setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config
	
	printf("A continuación se permite calcular el sueldo de un contador con base en el valor de la hora y en la cantidad de horas trabajadas.\n");
	
	printf("Por favor ingresá la cantidad de horas trabajadas este mes:\n");
	if (scanf("%f", &workedHours) != 1) {
		printf("Ingresaste un símbolo o una letra! Debes ingresar un número entero...");
		return 1;
	}
	
	monthlyPayment = workedHours * HOURLY_PAYMENT;
	
	printf("Habiendo trabajado %.1f horas, a razón de $ %.2f por hora, el sueldo correspondiente del mes es: %.2f.", workedHours, HOURLY_PAYMENT, monthlyPayment);
	
	getch();
	
	return 0;
}
