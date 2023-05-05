#include <stdio.h>
#include <conio.h>

// APB :)

void clear() { // Declares a function that cleans the input buffer
	char c;
	while ((c = getchar()) != '\n' && c != EOF); // Reads and discards every char that's left in the input buffer as long as it is not a new line or the EOF
	printf("cleaning buffer...\n"); // Debug purpose only
}
	
int main() {
	const float AUTONOMY = 14;
	float fuelLiterPrice, loadedLiters, totalCost, maxDistance;
	
	printf("A continuación se calculan el importe a pagar por la carga de combustible y los kilometros que dicha carga permite recorrer: \n\n");
	
	printf("Por favor, ingrese el precio (en pesos argentinos) por litro de combustible:\n");
	if (scanf("%f",&fuelLiterPrice) != 1) {// Validates the input type (getch returns the number of successfully asigned values, so 1 for a correctly asigned value)
		printf("El dato ingresado no es correcto. Debes ingresar un numero.\n");
		
		return 1; // Program ends due to wrong input type 
	};
	
	clear(); // Invokes "clear" function (declared above) in case the user pressed non integers after the integers 
			// e.g. "12a", where the first scanf will use "12" and the next will automatically use "a" ending the program with status 1
	
	printf("Ahora, por favor, ingrese la cantidad de combustible cargada:\n");
	if (scanf("%f",&loadedLiters) != 1) {
		printf("El dato ingresado no es correcto. Debes ingresar un numero.\n");
		
		return 1;
	};
	
	// Calculated values are asigned
	totalCost = fuelLiterPrice * loadedLiters;
	maxDistance = AUTONOMY * loadedLiters;
	
	printf("Dado que la autonomia del automovil es de %.2f km/L y que se cargaron %.2f litros de combustible:\n", AUTONOMY, loadedLiters);
	printf("El costo total fue de $ %.2f.\n", totalCost);
	printf("La distancia maxima a recorrer con la carga sera de %.2f kilometros.\n", maxDistance);
	
	getch();
	
	return 0; // Program ends with successful execution
}

