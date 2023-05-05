#include <stdio.h>
#include <conio.h>

/*
	Problema: 
		El usuario debe ingresar y numero. Debe recibir de vuelta el numero posterior al ingresado, luego el anterior.
	
	Algoritmo:
		- Inicio
		- Se pide al usuario que ingrese un número
		- El usuario debe ingresar un número y este debe almacenarse en una variable
 		- Se muestra al usuario el valor ingresado, su posterior (ingresado + 1) y su anterior (ingresado - 1)
		- Fin		 
*/

int main() {
	int userNumber, prevNumber, nextNumber;
	printf("A continuacion se permite obtener los numeros enteros anterior y posterior al numero que se ingrese.\n");
	
	printf("Por favor ingresa un numero para ver su anterior y posterior: \n");
	if (scanf("%d", &userNumber) != 1) {
		printf("Tenes que ingresar un numero! No una letra ni un simbolo...");
		
		return 1;
	}
	
	prevNumber = userNumber - 1; // Can be reduced to using only one variable and passing it as parameter to printf method as userNumber - 1. Kept for readability
	nextNumber = userNumber + 1; // Same as previous line
	
	printf("El numero que ingresaste es %d.\nSu entero posterior es %d y su entero anterior es %d", userNumber, nextNumber, prevNumber);
	
	getch();
		
	return 0;
}
