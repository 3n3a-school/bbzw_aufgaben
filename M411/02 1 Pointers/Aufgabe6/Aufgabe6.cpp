#include <stdio.h>
#include <stdlib.h>

int main()
{
	// Variablen deklarieren und initialisieren
	int Zahl = 10.0;
	char Zeichen = 'A';
	double Wert = 0.00;

	// Pointervariablen deklarieren und initialisieren
	int* pZahl = NULL; // null kleingeschrieben nicht korrekt --> Compiler Fehler
	char* pZeichen = &Zeichen;
	double* pWert = &Wert;
	pZahl = &Zahl;

	// Ausgaben
	printf("%i, %i\n", Zahl, *pZahl); // %i ist nicht pointer; korrekt *pZahl anstatt von pZahl --> Compiler Warnung
	printf("%c, %c\n", Zeichen, *pZeichen); // %c ist nicht adresse; korrekt Zeichen anstatt &Zeichen --> Compiler Warnung
	printf("%lf, %lf\n", *pWert + 1, *pWert); // '*' ---> Dereferenzierungsoperator

	// Veränderungen
	Zahl = *pZahl++; // increments where pointer points to; saves that to Zahl
	Zeichen = 'A'; // schreiben als 'A' nicht "A", jedoch andere Lösung: *"A"
	*pWert = --Wert + 8; // pWert is a pointer, to save to its reference: *pWert

	// Ausgaben 2
	printf("%i, %i\n", Zahl, *pZahl);
	printf("%c, %c\n", Zeichen, *pZeichen);
	printf("%lf, %lf\n", *(pWert + 5), Wert);

	system("pause");
	return 0;
}
