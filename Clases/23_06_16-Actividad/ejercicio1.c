/*
	Se tiene la cantidad de alumnos de un curso.
	Debe ingresarla el usuario.
	El usuario debe ingresar la edad de cada estudiante.
	Al finalizar mostrar el promedio de edad del curso.

	Algoritmo:
		- Inicio
		- El usuario ingresa la cantidad de alumnos en el curso (n)
		- El usuario ingresa la cantidad de un estudiante n veces
		- Al finalizar la n carga de edad, se de muestra el promedio de edad del curso.
		- Fin
		
	Pseudocódigo:
		Inclusión de archivo de cabecera
		
		Función main
		
			Declaración de variables:
			int studentsQuantity, agesSum = 0, i, lastAge;
			
			Escribir: "Ingrese la cantidad de alumnos en el curso";
			Leer: studentsQuantity;
			
			Para i = 0, mientras que i < studentsQuantity, i++ hacer:
				
				Escribir: "Ingresa la edad del alumno";
				Leer: lastAge;
				
				agesSum += lastAge;
				
			FinPara
			
			Escribir: ("La edad promedio del curso es", agesSum / studentsQuantity);	
		
*/

#include <stdio.h>
#include <conio.h>
#include <locale.h>

void clearInputBuffer() {
	while (getchar() != '\n');
}

int main() {
	int studentsQuantity, agesSum = 0, i, lastAge;
	
	setlocale(LC_CTYPE, "Spanish");
	
	printf("Ingrese la cantidad de alumnos del curso:\n");
	while (scanf("%i", &studentsQuantity) != 1 || studentsQuantity < 1) {
		printf("El valor ingresado no es válido. Vuelve a ingresarlo:\n");
		clearInputBuffer();
	};
	
	
	for (i = 1; i <= studentsQuantity; i++) {
		clearInputBuffer();
		printf("Ingresa la edad del %iº alumno:\n", i);
		while (scanf("%i", &lastAge) != 1 || lastAge < 1) {
			printf("El valor ingresado no es válido. Vuelve a ingresarlo:\n");
			clearInputBuffer();
		};
		
		agesSum += lastAge;
	};
	
	clearInputBuffer();
	
	printf("\nLa edad promedio del curso es: %.2f.", (float) agesSum / studentsQuantity);
	
	getch();
	
	return 0;
}
