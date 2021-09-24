#include <stdio.h>
#include <stdlib.h>
int main() {
	// 01.
	int Zahl = 345;
	int Wert;

	// 02.
	int *pZeig1, *pZeig2;

	// 03. 04
	pZeig1 = &Zahl;
	pZeig2 = &Wert;
	
	// 05.
	*pZeig2 = 45;
	
	// 06.
	pZeig2 = pZeig1;
	
	// 07.
	*pZeig2 = 100;
	
	// 08.
	printf("ZAHL:: Zahl: %d; Addr: %p\n", Zahl, &Zahl);

	// 09.
	printf("pZEIG1:: Addr: %p; Wert: %d\n", &pZeig1, *pZeig1);

	// 10.
	printf("WERT:: Wert: %d; Addr: %p\n", Wert, &Wert);

	// 11.
	printf("pZEIG2:: Wert: %d; Addr: %p\n", *pZeig2, &pZeig2);

	system("pause");
	return 0;
}
