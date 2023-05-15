#include <stdio.h>
#include <conio.h>
#include <locale.h>

/*
	Problema: 
		El usuario debe ingresar un numero. Debe recibir de vuelta el numero posterior al ingresado, luego el anterior.
	
	Algoritmo:
		- Inicio
		- Se pide al usuario que ingrese un n?mero
		- El usuario debe ingresar un n?mero y este debe almacenarse en una variable
 		- Se muestra al usuario el valor ingresado, su posterior (ingresado + 1) y su anterior (ingresado - 1)
		- Fin		 
*/

int main() {
	int userNumber, prevNumber, nextNumber;

  setlocale(LC_CTYPE, "Spanish"); // Adds support for spanish regional config

	printf("A continuación se permite obtener los números enteros anterior y posterior al número que se ingrese.\n");
	
	printf("Por favor ingresa un número:\n");
	if (scanf("%d", &userNumber) != 1) {
		printf("Tenés que ingresar un número! No una letra ni un símbolo...");
		
		return 1;
	}
	
	prevNumber = userNumber - 1; // Can be reduced to using only one variable and passing it as parameter to printf method as userNumber - 1. Kept for readability
	nextNumber = userNumber + 1; // Same as previous line
	
	printf("El número que ingresaste es %d.\nSu entero posterior es %d y su entero anterior es %d", userNumber, nextNumber, prevNumber);
	
	getch();
		
	return 0;
}
