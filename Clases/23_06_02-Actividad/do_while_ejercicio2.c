/* Problema: 
	Se dispone de una planilla con los sueldos a pagar a los empleados de una empresa.
	- Se desea conocer cuál es el sueldo promedio que se debe abonar. 
	- Como no se conoce la cantidad de empleados, luego de ingresar cada sueldo deberá aparecer en la pantalla el siguiente cartel: 
		“¿Continua o Finaliza? (C/F)”,
		el operador entonces deberá ingresar una “C” o una “F”, según quiera continuar ingresando datos o no.

*/
#include <stdio.h>
#include <locale.h>
#include <stdbool.h>
#include <conio.h>
#include <ctype.h>

// When called cleans/empties the buffer to avoid typing errors (i.e. non-numeric characterss);
void cleanInputBuffer() {
	while (getchar() != '\n');
}

int main() {
	int employeesCounter = 0; // Stores the employees counting
	float lastSalary; // Stores the las introduced salary
	float salariesSum = 0; // Stores the sum of all salaries
	bool processIsNotFinished = true; // When false, indicates that the process (while loop) is finished
	
	setlocale(LC_CTYPE, "Spanish"); // Allows the usage of spanish characters
	
	printf("A continuación se permite calcular el sueldo promedio que se debe abonar:\n\n");
	
	do {
		
		if (employeesCounter != 0) system("cls");
		
		printf("Ingrese un sueldo a continuación:\n");
		while (scanf("%f", &lastSalary) != 1 || lastSalary <= 0) {
			cleanInputBuffer();
			printf("El valor ingresado no es válido. Ingresá un número positivo:\n");
		};
		
		cleanInputBuffer();
		
		employeesCounter++; // Increment the employees/salary counter
		salariesSum += lastSalary; // Accumulates the last introduced salary to the current sum
		
		printf("Introduciste %i sueldos.\n\n ¿Continua o Finaliza? (C/F)\n", employeesCounter);
		char choice;
		// Validates the input value 
		while (scanf("%c", &choice) != 1 || (tolower(choice) != 'c' && tolower(choice) != 'f')) {
			cleanInputBuffer();
			printf("El valor que ingresaste no es una opción válida. Volvé a ingresar tu selección:\n");
		};
				
		// Checks if the user wants to finish the loading proces, if so, then processIsFinished is set to true leading to the ending of the while loop	
		if (tolower(choice) == 'f') {
			processIsNotFinished = false;	
		};
		
		cleanInputBuffer();
						
	} while (processIsNotFinished);
	
	system("cls");
	
	printf("El sueldo promedio que se debe abonar es $%.2f. Se cargaron los sueldos de %i empleados.\n", salariesSum / employeesCounter, employeesCounter);
	
	getch();
	
	return 0;
}
