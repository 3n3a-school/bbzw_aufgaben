# Aufgabe 4

```c++
00: #include <stdio.h>
01: #include <stdlib.h>
02:
03: int main(void)
04: {
05: //Variablen deklarieren und initialisieren
06: int Zahl = 10.0;
07: char Buchstabe = 'A';
08: short Liste[8] = {1, 2, 4, 8, 16, 32, 64, 128};
09: double Wert = 0.00;
10:
11: //Pointervariablen deklarieren und initialisieren
12: int *pZahl = null;
13: char *pBuchstabe = &Buchstabe;
14: short *pListe = *Liste;
15: double *pWert = &Wert;
16: pZahl = &Zahl;
17:
18: //Ausgabe 1
19: printf ("%i, %i\n", Zahl, pZahl);
20: printf ("%c, %c\n", &Buchstabe, *pBuchstabe);
21: printf ("%d, %d\n", *Liste, Liste[1 + 2] + Liste[0]);
22: printf ("%lf, %lf\n", &pWert +1, *Zahl);
23:
24: //Veränderungen 1
25: Zahl = *pZahl++;
26: Buchstabe = "X";
27: pListe = &Liste[3];
28: pListe++;
29: pWert = --Wert + 8;
30:
31: //Ausgabe 2
32: printf ("%i, %i\n", Zahl, *pZahl);
33: printf ("%c, %c\n", Buchstabe, pBuchstabe);
34: printf ("%lf, %lf\n", *(pWert+5), Wert);
35:
36: system("pause");
37: return 0;
38: }
```

| Zeile | Fehler-Beschrieb                                                                                 |
|-------|--------------------------------------------------------------------------------------------------|
| 6     | Einer int-Variablen kann kein Double-Wert zugewiesen werden --> int Zahl = 10;                   |
| 12    | null muss gross geschrieben werden --> int* pZahl = NULL;                                        |
| 14    | einem Pointer muss eine Adresse zugewiesen werden --> short* pListe = Liste;                     |
| 22    | ein Dereferenzierungsoperator '*' funktioniert nur mit Pointer, nicht mit lf für Adress --> Zahl |
| 26    | einer char-Variable kann kein String zugewiesen werden --> Buchstabe = 'X'                       |
| 29    | einem Pointer kann kein Wert zugewiesen werden --> *pWert = ...;                                 |
| 33    | pBuchstabe ist ein Pointer und kein char --> ..., *pBuchstabe);                                  |
| 25    | pZahl wird inkrementiert bevor Wert ausgelesen wird --> pointer nicht inkrementieren |