#include <stdio.h>
#include <stdlib.h>
int main()
{
 int Laenge = 0;
 int Breite = 0;
 int Flaeche = 0;
 int *pLaenge = &Laenge;
 int *pBreite = &Breite;
 int *pFlaeche = &Flaeche;
 // Eingabe von Länge und Breite
 scanf_s("%d", &Laenge);
 scanf_s("%d", &Breite);

 // Verarbeitung der Eingabe, Berechnung der Fläche
 *pFlaeche = *pLaenge * *pBreite;

 // Ausgabe von Länge, Breite und Fläche
 printf("Lange: %d; Breite: %d; Flache: %d", *pLaenge, *pBreite, *pFlaeche);
 
 system("pause");
 return 0;
}

