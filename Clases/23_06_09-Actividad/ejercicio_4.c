// Ingresar N cantidad de alumnos y sus respectivas notas de parciales, calcular el promedio de notas del curso.

#include <stdio.h>
#include <conio.h>
#include <locale.h>

void cleanInputBuffer() {
	while(getchar() !='\n');
}

int main() {
	int i, studentsNumber;
	float lastGrade, gradesSumSoFar = 0;
	
	setlocale(LC_CTYPE, "Spanish");
	
	printf("A continuación se calcula el promedio de notas de curso:\n");
	printf("Ingrese la cantidad de alumnos:\n");
	while (scanf("%i", &studentsNumber) != 1 || studentsNumber <= 0){
		printf("El valor ingresado no es válido. Ingresalo nuevamente...\n");
		cleanInputBuffer();
	}
	
	cleanInputBuffer();
	
	for (i = 1; i <= studentsNumber; i++) {
		printf("Ingrese la nota del %i° alumno:\n", i);
		while (scanf("%f", &lastGrade) != 1 || lastGrade > 10 || lastGrade <= 0) {
			printf("El valor ingresado no es válido. Ingresalo nuevamente...\n");
			cleanInputBuffer();
		}
		
		gradesSumSoFar += lastGrade;
		
		cleanInputBuffer();	
	};
	
	printf("\nLa nota promedio del curso es %.2f. El curso tiene %i estudiantes.", gradesSumSoFar / studentsNumber, studentsNumber);
	
	getch();
	
	return 0;
};
