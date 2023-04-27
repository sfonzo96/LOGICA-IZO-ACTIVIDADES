#include <stdio.h>
#include <conio.h>	

int main() {
	float SQUARE_METER_PRICE = 50;
	float landWidth = 0, landLength = 0, arsPerUsd = 0, landArea, usdPrice, arsPrice;
	
	printf("Por favor, ingresa la cotizacion del dolar:\n");
	if (scanf("%f",&arsPerUsd) != 1) { // scanf devuelve la cantidad de punteros correctamente asignados, si no logra asignarlos devuelve 0.
		printf("El dato ingresado no es correcto. Debes ingresar un namero.\n");
		
		return 1;
	};
	
	printf("Ahora, por favor, ingresa el ancho del lote:\n");
	if (scanf("%f", &landWidth) != 1) {
		printf("El dato ingresado no es correcto. Debes ingresar un namero.\n");
		
		return 1;
	};
	
	printf("Finalmente, por favor ingresa el largo del terreno:\n");
	if (scanf("%f", &landLength) != 1) {
		printf("El dato ingresado no es correcto. Debes ingresar un namero.\n");
		
		return 1;
	};
	
	landArea = landWidth * landLength;
	usdPrice = landArea * SQUARE_METER_PRICE;
	arsPrice = usdPrice * arsPerUsd;
	
	printf("Dado que las medidas del lote son %.2f metros (ancho) x %.2f metros (largo) y que el precio del metro cuadrado de tierra es de u$s %.2f, el area del lote es de %.2f metros cuadrados y el importe a pagar es de u$s %.2f o $ %.2f.", landWidth, landLength, SQUARE_METER_PRICE, landArea, usdPrice, arsPrice);	
	
	getch();
	
	return 0;
}
