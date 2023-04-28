#include <stdio.h>
#include <conio.h>
	
int main() {
	const float AUTONOMY = 14;
	float fuelLiterPrice = 0, loadedLiters = 0, totalCost, maxDistance;
	
	printf("A continuación se calculan el importe a pagar por la carga de combustible y los kilometros que dicha carga permite recorrer: \n\n");
	
	printf("Por favor, ingrese el precio (en pesos argentinos) por litro de combustible:\n");
	if (scanf("%f",&fuelLiterPrice) != 1) {// Validates the input type (getch returns the number of successfully asigned values, so 1 for a correctly asigned value)
		printf("El dato ingresado no es correcto. Debes ingresar un numero.\n");
		
		return 1; // Program ends due to wrong input type 
	};
	
	printf("Ahora, por favor, ingrese la cantidad de combustible cargada:\n");
	if (scanf("%f",&loadedLiters) != 1) {
		printf("El dato ingresado no es correcto. Debes ingresar un numero.\n");
		
		return 1;
	};
	
	
	// Calculated values are asigned
	totalCost = fuelLiterPrice * loadedLiters;
	maxDistance = AUTONOMY * loadedLiters;
	
	printf("Dado que la autonomia del automovil es de %.2f km/L y que se cargaron %.2f litros de combustible, el costo total sera de $ %.2f y la distancia maxima a recorrer con la carga sera de %.2f kilometros.\n", AUTONOMY, loadedLiters, totalCost, maxDistance);
	
	getch();
	
	return 0; // Program ends with successful execution
}

