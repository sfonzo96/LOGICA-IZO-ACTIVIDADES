/*
Problema:	
	Dada una lista de espera de pasajeros de un micro, donde se indica el peso de equipaje de cada uno de ellos, 
	deberá determinarse cuantas personas viajarán en el mismo de acuerdo a las siguientes condiciones:
		a. El peso del equipaje total no debe superar los 3500 kg.
		b. No se permiten pasajeros de pie.
		c. Para lo cual se tiene además los siguientes datos del micro: número del mismo y
		cantidad de asientos que posee el mismo.
		d. Exhibir el número del micro, la cantidad de pasajeros y el peso del equipaje.
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
	const float MAX_LUGGAGE_WEIGHT = 3500; // Sets a limit to the total luggage weight
	float totalLuggageWeight = 0; // Accumulates the passangers lugagge weight
	float lastLuggageWeight; // Auxiliary variable in order to store and then accumulate the last weight luggage
	int passengersQuantity = 0; // Stores the number of passangers so far
	int seatsQuantity; // Stores the quantity of max seats available on the bus
	int busID; // Stores the identification number of the bus
	
	setlocale(LC_CTYPE, "Spanish"); // Allows the usage of spanish characters
	
	printf("Se permite calcular la cantidad de pasajeros que abordarán un viaje en micro de acuerdo a las reglas de la empresa de transporte.\n\n");
	
	printf("Por favor, introduzca el número de micro a continuación:\n");
	// Validates that the bus ID is a number
	while(scanf("%i", &busID) != 1 || busID <= 0) {
		cleanInputBuffer();
		printf("El valor que ingresaste no es válido, debe ser un número entero positivo. Prueba otra vez:\n");
	};
	
	cleanInputBuffer();
	
	printf("Por favor, introduzca la cantidad de asientos disponibles en el micro a continuación:\n");
	// Validates that the bus seats quantity is a number
	while(scanf("%i", &seatsQuantity) != 1 || seatsQuantity <= 0) {
		cleanInputBuffer();
		printf("El valor que ingresaste no es válido, debe ser un número entero positivo. Prueba otra vez:\n");
	};
	
	cleanInputBuffer();
	
	do {
		system("cls");
		
		printf("Por favor, introduzca el peso del equipaje del pasajero a continuación:\n");
		
		// Validates that the luggage weight is a number and thats positive
		while(scanf("%f", &lastLuggageWeight) != 1 || lastLuggageWeight <= 0) {			
			cleanInputBuffer();
			printf("El valor que ingresaste no es válido, debe ser un número positivo. Prueba otra vez:\n");
		};
		
		cleanInputBuffer();
		
		// Verificates that the last introduced luggage weight doesn't exceed the max allowed, is so, skips the iteration without
		if (lastLuggageWeight + totalLuggageWeight > MAX_LUGGAGE_WEIGHT) {
			printf("El equipaje de este pasajero hará que se exceda el peso máximo permitido. Relocalizalo en otro viaje con más capacidad disponible. Presiona una tecla para continuar.\n");
			
			getch();
			
			continue;
		}
		
		passengersQuantity++; // Increments the passengers quantity
		totalLuggageWeight += lastLuggageWeight; // Sums the last introduced luggage weight to the total so far
		
		// Lets the user know how many passengers has been registered so far and asks if the loading is finished
		printf("Introduciste los pesos de los equipajes de %i pasajeros.\n\n ¿Continua o Finaliza? (C/F)\n", passengersQuantity);
		char choice;
		// Validates the input value 
		while (scanf("%c", &choice) != 1 || (tolower(choice) != 'c' && tolower(choice) != 'f')) {
			cleanInputBuffer();
			printf("El valor que ingresaste no es una opción válida. Volvé a ingresar tu selección:\n");
		};
		
		// Checks if the user wants to finish the luggage loading proces, if so, then breaks the loop	
		if (tolower(choice) == 'f') {
			break;	
		};
		
		cleanInputBuffer();
		
	} while (totalLuggageWeight <= MAX_LUGGAGE_WEIGHT && passengersQuantity < seatsQuantity);
	
	system("cls");
	
	printf("En el micro  \"%i\", de %i asientos, se registraron %i pasajeros. Se alcanzó la suma de %.2f kg de equpaje entre ellos.", busID, seatsQuantity, passengersQuantity, totalLuggageWeight);
	
	getch();
	
	return 0;
}
