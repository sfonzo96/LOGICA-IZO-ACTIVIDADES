#include <stdio.h>
#include <conio.h>
#include <locale.h>
#include <stdbool.h> // Allows the use of boolean type values

/*
	Problema: Ingresar tres notas, mostrar el promedio de las mismas y si el alumno aprobó o debe recuperar.
	
	Algoritmo: 
		- Inicio
		- Pedir al usuario que ingrese la primera nota
		- Pedir al usuario que ingrese la segunda nota
		- Pedir al usuario que ingrese la tercera nota
		- Calcular el promedio de las tres
		- Verificar si el promedio es mayor o igual a 6, o no
		- Mostrar si el alumno aprobó
		- Fin
*/

void clearInputBuffer() { // Clears the input buffer in order to avoid unexpected behaviour
	while (getchar() != '\n');
}

int main( ) {	
	float firstGrade, secondGrade, thirdGrade;
	int numberOfGrades = 3;
	float gradePointAverage;
	bool studentAproves = false; // Indicates the student condition, true is for aproved and false the opposite
	
	setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config
	
	printf("A continuación se determina si un alumno aprobó la asignatura Lógica y Estructura de Datos a acuerdo a las 3 notas obtenidas en los exámenes parciales.\n");
	
	printf("Por favor, ingresá la primera nota:\n");
	
	if (scanf("%f", &firstGrade) != 1 || firstGrade < 0 || firstGrade > 10) { // Grade should be a number between 1 and 10 (extremes included)
		printf("Solo podés ingresar números y la nota necesita ser un valor entre 1 y 10!");
		return 1;
	}
	
	clearInputBuffer();
	
	printf("Por favor, ingresá la segunda nota:\n");
	
	if (scanf("%f", &secondGrade) != 1 || secondGrade < 0 || secondGrade > 10) {
		printf("Solo podés ingresar números y la nota necesita ser un valor entre 1 y 10!");
		return 1;
	}

	clearInputBuffer();
	
	printf("Por favor, ingresá la tercera nota:\n");
	
	if (scanf("%f", &thirdGrade) != 1 || thirdGrade < 0 || thirdGrade > 10) {
		printf("Solo podés ingresar números y la nota necesita ser un valor entre 1 y 10!");
		return 1;
	}  
	
	clearInputBuffer();

	gradePointAverage = (firstGrade + secondGrade + thirdGrade) / numberOfGrades;

  if (gradePointAverage >= 6) {
    studentAproves = true;
  }
	
	printf("Los notas ingresadas fueron: %.2f, %.2f y %.2f.\nLa nota promedio es: %.2f.\nPor lo tanto el alumno %s.", firstGrade, secondGrade, thirdGrade, gradePointAverage, studentAproves ? "aprobó" : "debe recuperar");
	
	getch();
	
	return 0;
}
