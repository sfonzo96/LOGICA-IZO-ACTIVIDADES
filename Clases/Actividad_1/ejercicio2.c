#include <stdio.h>
#include <conio.h>	

// APB :)

void clear() { // Declares a function that cleans the input buffer
	char c;
	while ((c = getchar()) != '\n' && c != EOF); // Reads and discards every char that's left in the input buffer as long as it is not a new line or the EOF
	printf("cleaning buffer...\n"); // Debug purpose only
}

int main() {
	const float SQUARE_METER_PRICE = 50;
	float landWidth, landLength, arsPerUsd, landArea, usdPrice, arsPrice;
	
	printf("A continuacion se calcula el area del lote y el importe a pagar en pesos argentinos y en dolares estadounidenses:\n\n");
	
	printf("Por favor, ingresa la cotizacion del dolar:\n");
	if (scanf("%f",&arsPerUsd) != 1) { // Validates that the input value is asigned correctly (getch returns the number of successfully asigned values)
		printf("El dato ingresado no es correcto. Debes ingresar un namero.\n");
		
		return 1; // Program ends due to wrong input type 
	};
	
	clear(); // Invokes clear() function (declared above) in case the user pressed non integers after the integers 
			// e.g. "12a", where the first scanf will use "12" and the next will automatically use "a" ending the program with status 1
			
	printf("Ahora, por favor, ingresa el ancho del lote:\n");
	if (scanf("%f", &landWidth) != 1) {
		printf("El dato ingresado no es correcto. Debes ingresar un numero.\n");
		
		return 1;
	};
	
	clear();
	
	printf("Finalmente, por favor ingresa el largo del terreno:\n");
	if (scanf("%f", &landLength) != 1) {
		printf("El dato ingresado no es correcto. Debes ingresar un numero.\n");
		
		return 1;
	};
	
	// Calculated values are asigned
	landArea = landWidth * landLength;
	usdPrice = landArea * SQUARE_METER_PRICE;
	arsPrice = usdPrice * arsPerUsd;
	
	printf("Dado que las medidas del lote son %.2f metros (ancho) x %.2f metros (largo) y que el precio del metro cuadrado de tierra es de u$s %.2f:\n", landWidth, landLength, SQUARE_METER_PRICE);	
	printf("El area del lote es de %.2f metros cuadrados.\n", landArea);
	printf("El importe a pagar es de u$s %.2f o $ %.2f.", usdPrice, arsPrice);
	getch();
	
	return 0; // Program ends with successful execution
}
